# ReCapProject - Araç Kiralama Sistemi

![primeDrive](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/d4015fde-2d39-49bc-85a3-fd3fc4e39d6b)
Bu repo **Yazılım Geliştirici Yetiştirme Kampı**'nda yapılan çalışmaları kapsayan **Araç Kiralama Projesi**'ni içerir.
## :pushpin:Getting Started
EntityFramework kullanılarak gerçekleştirilen ve CRUD işlemlerini içeren, araç kiralama iş yerleri için tasarlanmış N-Katmanlı bir mimariye sahip bu projede, **Entities**, **DataAccess**, **Business**, **Core** ve **WebAPI** katmanları bulunmaktadır.
## :books:Layers  
![entities](https://user-images.githubusercontent.com/77868230/107870096-c5609600-6ea6-11eb-82e6-8e797c8a3617.png)
### Entities Layer
Veritabanı nesneleri için oluşturulmuş **Entities Katmanı**'nda, projemizde üç farklı klasör bulunmaktadır: **Abstract**, **Concrete** ve **DTOs**. Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri ve DTOs klasörü de veri transfer nesnelerini tutmak için oluşturulmuştur.  
<br> :file_folder:`Abstract` 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~IEntity.cs~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)  
<br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Brand.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Brand.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Car.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Car.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImage.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/CarImage.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Color.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Color.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Customer.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Customer.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Payment.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Payment.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Rental.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/Concrete/Rental.cs)  
<br> :file_folder:`DTOs`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarDetailDTO.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/CarDetailDTO.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarsByBrandIdDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/CarsByBrandIdDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarsByCarImageDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/CarsByCarImageDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarsByColorIdDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/CarsByColorIdDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PasswordUpdateDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/PasswordUpdateDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalDetailDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/RentalDetailDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UpdateUserDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/UpdateUserDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForLoginDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/UserForLoginDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForRegisterDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Entities/DTOs/UserForRegisterDto.cs)  
<br>
![dal](https://user-images.githubusercontent.com/77868230/107870097-c5f92c80-6ea6-11eb-90e2-4bbd7f36c561.png)
###  Data Access Layer  
Veritabanı CRUD işlemlerini gerçekleştirmek amacıyla oluşturulan **Data Access Katmanı**'nda, soyut ve somut nesneleri ayrı tutmak için iki adet klasör bulunmaktadır. Soyut nesneleri içeren klasör **Abstract** olarak adlandırılmış ve içinde bulunan interface'leri, **Concrete** klasörü altında yer alan **EntityFramework** klasöründeki sınıflar uygulamaktadır.    
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IBrandDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/IBrandDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICarDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/ICarDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICarImageDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/ICarImageDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IColorDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/IColorDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICustomerDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/ICustomerDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IPaymentDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/IPaymentDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IRentalDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/IRentalDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IUserDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Abstract/IUserDal.cs)  
<br>:file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfBrandDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfCarDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfCarImageDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfCarImageDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfColorDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfCustomerDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfPaymentDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfPaymentDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfRentalDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfUserDal.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentACarContext.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/DataAccess/Concrete/EntityFramework/RentACarContext.cs)  
<br>
![business](https://user-images.githubusercontent.com/77868230/107870095-c5609600-6ea6-11eb-901d-9e7c21c3b614.png)
###  Business Layer  
Sunum katmanından gelen bilgileri işlemek veya denetlemek amacıyla oluşturulan **Business Katmanı**'nda, projemde altı ana klasör bulunmaktadır. Bunlar şu şekildedir: **Abstract**, **BusinessAspects**, **Concrete**, **Constants**, **DependencyResolvers** ve **ValidationRules**. Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur. BusinessAspects klasörü, işlemleri yönetmek ve güvenlik, yetkilendirme gibi konulara odaklanan işlemleri içermektedir. Constants klasörü, sabit değerleri içermektedir. DependencyResolvers klasörü, bağımlılık çözümleme işlemlerini içermektedir. ValidationRules klasörü ise doğrulama işlemlerinin gerçekleştiği classları içermektedir.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IAuthService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/IAuthService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IBrandService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/IBrandService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICarImageService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/ICarImageService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICarService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/ICarService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IColorService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/IColorService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICustomerService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/ICustomerService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IPaymentService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/IPaymentService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IRentalService.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Abstract/IRentalService.cs)  
<br>:file_folder:`BusinessAspects`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Autofac`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [SecuredOperation.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs)  
<br>:file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AuthManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/AuthManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [BrandManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/BrandManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImageManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/CarImageManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/CarManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ColorManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/ColorManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CustomerManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/CustomerManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PaymentManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/PaymentManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Concrete/RentalManager.cs)  
<br>:file_folder:`Constans`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Messages.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Constants/Messages.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PathConstants.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/Constants/PathConstants.cs)  
<br>:file_folder:`DependencyResolvers`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Autofac`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AutofacBusinessModule.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)  
<br>:file_folder:`ValidationRules`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `FluentValidation`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [BrandValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImageValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/CarImageValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ColorValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CustomerValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PasswordUpdateValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/PasswordUpdateValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserLoginValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/UserLoginValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserRegisterValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/UserRegisterValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserValidator.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)  
<br>
![core](https://user-images.githubusercontent.com/77868230/107870091-c42f6900-6ea6-11eb-863e-63d30fa2128c.png)
###  Core Layer  
Bir framework katmanı olarak tasarlanmış olup projemin temel bileşenlerini içerir. Bu katmanda bulunan klasörler, projemin genelinde ortak kullanılan kodları gruplamak ve organizasyonu sağlamak için oluşturulmuştur. **Core Katmanı**'nda Aspects, CrossCuttingConcerns, DataAccess, DependencyResolvers, Entities, Extensions ve Utilities olmak üzere 7 adet klasör bulunmaktadır.  
***Aspects Klasörü***, Aspect (yön) odaklı konuları içerir. Özellikle, Autofac klasörü, projede kullanılan Autofac IOC container'ını barındırır.  
***CrossCuttingConcerns Klasörü***'nde Caching klasörü önbellekleme işlemlerini, Validation klasörü ise doğrulama işlemlerini içerir.  
***DataAccess Klasörü***, veri erişim nesnelerini içerir. EntityFramework klasörü, projede kullanılan Entity Framework ORM aracını barındırır.  
***DependencyResolvers Klasörü***, bağımlılık çözümleme işlemlerini ele alır ve projede kullanılan IOC container'ının konfigürasyonunu içerir.  
***Entities Klasörü***, temel nesneleri içerir. Abstract ve Concrete klasörleri, soyut ve somut nesneleri gruplar.  
***Extensions Klasörü***, genel amaçlı genişletme (extension) metodlarını içerir. Bu metodlar, projede kullanılan nesneleri genişletmek ve farklı işlevselliği sağlamak amacıyla kullanılır.  
***Utilities Klasörü***, genel amaçlı yardımcı kodları içerir. Business, Helpers, Interceptors, IoC, Results ve Security klasörleri, iş mantığı, yardımcı fonksiyonlar, interceptorlar, IOC konfigürasyonu, sonuç sınıfları ve güvenlikle ilgili kodları içerir.  
<br>**⚠ Core Katmanı, diğer katmanları referans almaz.**
<br> <br>:file_folder:`Aspects`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Autofac`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Caching`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CacheAspect.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CacheRemoveAspect.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Performance`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PerformanceAspect.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Transaction`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [TransactionScopeAspect.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Validation`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ValidationAspect.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)  
<br> <br>:file_folder:`CrossCuttingConcerns`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Caching`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Microsoft`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [MemoryCacheManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICacheManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/CrossCuttingConcerns/Caching/ICacheManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Validation`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ValidationTool.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)  
<br> <br>:file_folder:`DataAccess`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfEntityRepositoryBase.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IEntityRepository.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/DataAccess/IEntityRepository.cs)  
<br> <br>:file_folder:`DependencyResolvers`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CoreModule.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/DependencyResolvers/CoreModule.cs)  
<br> <br>:file_folder:`Entities`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IDto.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Entities/Abstract/IDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IEntity.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Entities/Abstract/IEntity.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [OperationClaim.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Entities/Concrete/OperationClaim.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [User.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Entities/Concrete/User.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserOperationClaim.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Entities/Concrete/UserOperationClaim.cs)  
<br> <br>:file_folder:`Extensions`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ClaimExtensions.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ClaimExtensions.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ClaimsPrincipalExtensions.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ErrorDetails.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ErrorDetails.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ExceptionMiddleware.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ExceptionMiddleware.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ExceptionMiddlewareExtensions.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ExceptionMiddlewareExtensions.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ServiceCollectionExtensions.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Extensions/ServiceCollectionExtensions.cs)  
<br> <br>:file_folder:`Utilities`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Business`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [BusinessRules.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Business/BusinessRules.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Helpers`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `FileHelper`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [FileHelperManager.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Helpers/FileHelper/FileHelperManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IFileHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Helpers/FileHelper/IFileHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `GuidHelper`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [GuidHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Helpers/GuidHelper/GuidHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Interceptors`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AspectInterceptorSelector.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [MethodInterception.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [MethodInterceptionBaseAttribute.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `IoC`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICoreModule.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/IoC/ICoreModule.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ServiceTool.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/IoC/ServiceTool.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Results`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [DataResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/DataResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ErrorDataResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/ErrorDataResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ErrorResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/ErrorResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IDataResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/IDataResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/IResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Result.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/Result.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [SuccessDataResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/SuccessDataResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [SuccessResult.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Results/SuccessResult.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Security`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Encryption`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [SecurityKeyHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [SigningCredentialsHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Hashing`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [HashingHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Jwt`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AccessToken.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Jwt/AccessToken.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [JwtHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Jwt/JwtHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [TokenOptions.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/Jwt/TokenOptions.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ITokenHelper.cs](https://github.com/Enesphlvn/ReCapBackend/blob/master/Core/Utilities/Security/ITokenHelper.cs)  
## :computer:ScreenShots  
Projenin ekran görüntüleri  
<br> 
<br>![homePage](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/7a7b3af1-c846-45d7-84c6-73f1b7634bf9)  
<br>![carFilterByBrandAndColor](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/41d2ca26-b3ce-4190-b968-1b8c5910e04f)  
<br>![login](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/f45abafa-6f3f-4669-92c2-79dd225e4e20)  
<br>![carDetail](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/51185f84-614c-4959-8730-071bda63609b)  
<br>![rentalAdd](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/34a07e6d-2f97-486c-a3c6-ec6cefa2351a)  
<br>![pay](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/5f3fb345-5886-48b2-a7f2-c3433fe770fa)  
<br>![userUpdate](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/f6c16979-cd9f-435c-bc43-22360848c150)  
<br>![passwordUpdate](https://github.com/Enesphlvn/ReCapBackend/assets/98655108/664896a4-4419-44c4-9b31-d332372e668d)  

## :pencil2:Authors  
***Enes Pehlivan*** - [EnesPehlivan](https://github.com/Enesphlvn)







