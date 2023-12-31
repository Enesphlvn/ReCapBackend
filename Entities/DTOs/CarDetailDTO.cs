﻿using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
        public string ModelYear { get; set; }
        public string? Description { get; set; }
        public int FindexScore { get; set; }
    }
}
