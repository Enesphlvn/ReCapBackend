using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class UpdateUserDto : IDto
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
