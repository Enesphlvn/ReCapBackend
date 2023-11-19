using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private ITokenHelper _tokenHelper;
        private IUserDal _userDal;

        public AuthManager(ITokenHelper tokenHelper, IUserDal userDal)
        {
            _tokenHelper = tokenHelper;
            _userDal = userDal;
        }
       
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        [ValidationAspect(typeof(UserLoginValidator))]
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = GetByMail(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data, Messages.SuccessfulLogin);
        }

        [ValidationAspect(typeof(UserRegisterValidator))]
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            var user = CreateUserWithHashedPassword(userForRegisterDto);

            Add(user);
            
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IResult UserExists(string email)
        {
            var user = GetByMail(email);
            
            if (user.Data != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IResult Delete(int userId)
        {
            User user = _userDal.Get(u => u.Id == userId);
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IDataResult<User> GetByMail(string email)
        {
            var user = _userDal.Get(u => u.Email == email);
            if(user is null)
            {
                return new ErrorDataResult<User>(Messages.MailNotFound);
            }
            return new SuccessDataResult<User>(user);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Update(UpdateUserDto user)
        {
            User entity = _userDal.Get(e => e.Email == user.Email);

            if (entity is null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

            entity.FirstName = user.FirstName;
            entity.LastName = user.LastName;
            entity.Email = user.Email;

            _userDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        private User CreateUserWithHashedPassword(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordhash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordhash, out passwordSalt);
            return new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordhash,
                PasswordSalt = passwordSalt,                
                Status = true
            };
        }

        [ValidationAspect(typeof(PasswordUpdateValidator))]
        public IResult UpdatePassword(PasswordUpdateDto password)
        {
            var userToCheck = GetByMail(password.Email);
            if(userToCheck.Data is null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(password.OldPassword, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorResult(Messages.OldPasswordError);
            }

            byte[] passwordhash, passwordSalt;
            HashingHelper.CreatePasswordHash(password.NewPassword, out passwordhash, out passwordSalt);

            userToCheck.Data.PasswordHash= passwordhash;
            userToCheck.Data.PasswordSalt= passwordSalt;
            _userDal.Update(userToCheck.Data);

            return new SuccessResult();
        }
    }
}
