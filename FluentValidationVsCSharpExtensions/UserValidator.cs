﻿using FluentValidation;

namespace FluentValidationVsCShapExtensions;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
        RuleFor(x => x.Role).NotEmpty();
    }
}
