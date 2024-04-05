﻿using FluentValidation;

namespace Application_Layer.Validators.ValidationExtensions
{
    public static class NameValidationExtension
    {
        public static IRuleBuilderOptions<T, string> MustBeValidName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage("Name is required.")
                .NotNull().WithMessage("Name cant be Null")
                .MinimumLength(2).WithMessage("Name must be at least 2 characters long.")
                .MaximumLength(20).WithMessage("Name cannot exceed 20 characters.")
                .Matches("^[a-zA-Z]+$").WithMessage("Name can only contain letters.");
        }
    }
}