﻿using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailDTO:IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
