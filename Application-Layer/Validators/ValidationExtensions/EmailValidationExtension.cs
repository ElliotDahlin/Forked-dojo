﻿
using FluentValidation;

namespace Application_Layer.Validators.ValidationExtensions
{
    public static class EmailValidationExtension
    {
        public static IRuleBuilderOptions<T, string> MustBeValidEmail<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage("Email is required.")
                .NotNull().WithMessage("Email cant be Null")
                .EmailAddress().WithMessage("A valid email address is required.");
        }
    }
}