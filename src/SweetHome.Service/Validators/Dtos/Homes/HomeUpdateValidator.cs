﻿using FluentValidation;
using SweetHome.Service.Common.Helpers;
using SweetHome.Service.Dtos.Homes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetHome.Service.Validators.Dtos.Homes;

public class HomeUpdateValidator : AbstractValidator<HomeUpdateDto>
{
    public HomeUpdateValidator()
    {
        //int maxImageSize = 5;
        //RuleFor(dto => dto.Describtion).NotNull().NotEmpty().WithMessage("Describtion filed is Required")
        //    .MinimumLength(3).WithMessage("describtion must be more than 3 characters")
        //    .MaximumLength(1500).WithMessage("describtion must be less than 1500 characters");
        //RuleFor(dto => dto.ImagePath.Length).LessThan(maxImageSize * 1024 * 1024).WithMessage($"Image Size must be lass then {maxImageSize} MB");
        //RuleFor(dto => dto.ImagePath.FileName).Must(pradicate =>
        //{
        //    FileInfo fileInfo = new FileInfo(pradicate);
        //    return MediaHealper.GetImageExtensions().Contains(fileInfo.Extension);
        //}).WithMessage("this file type is not image file");

        //RuleFor(dto => dto.ImagePath).NotEmpty().NotNull().WithMessage("image file is required!");

        //RuleFor(dto => dto.CommonPrice).NotNull().NotEmpty().WithMessage("You have not entered a price");

        //RuleFor(dto => dto.RoomCount).NotEmpty().NotNull().WithMessage("You have not entered a Room Count");

    }
}
