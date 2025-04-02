using BenchmarkDotNet.Attributes;
using CSharpFunctionalExtensions;
using FluentValidation.Results;

namespace FluentValidationVsCShapExtensions;

public class Tests
{
    [Benchmark]
    public Result CSharpFunctionalExtensions()
    {
        var customer = new User(Guid.NewGuid(), "name", "email", "password", "role");

        if (string.IsNullOrEmpty(customer.Name))
        {
            return Result.Failure<User>("Error");
        }

        if (string.IsNullOrEmpty(customer.Email))
        {
            return Result.Failure<User>("Error");
        }

        if (string.IsNullOrEmpty(customer.Password))
        {
            return Result.Failure<User>("Error");
        }

        if (string.IsNullOrEmpty(customer.Role))
        {
            return Result.Failure<User>("Error");
        }

        return Result.Success("Sucesso");
    }

    [Benchmark]
    public ValidationResult BenchmarkDotNetAttributes()
    {
        var customer = new User(Guid.NewGuid(), "name", "email", "password", "role");
        UserValidator validator = new UserValidator();
        return validator.Validate(customer);
    }
}
