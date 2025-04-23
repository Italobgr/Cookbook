using FluentValidation;
using MyRecipeBook.Comunication.Requests;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestRegisterUsersJson>
    {

        public RegisterUserValidator()
        {

            RuleFor(user => user.Name).NotEmpty();
            RuleFor(user => user.Email).NotEmpty();
            RuleFor(user => user.Email).EmailAddress();
            RuleFor(user => user.Password.Length).GreaterThan(6);

        }

    }
}
