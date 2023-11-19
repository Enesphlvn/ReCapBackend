﻿using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class PasswordUpdateDto : IDto
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
