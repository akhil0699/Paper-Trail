﻿using System;
using Cik.CoreLibs.Model;

namespace Cik.Services.Magazine.MagazineService.Api.Category.Dtos
{
    public class CategoryDto : DtoBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}