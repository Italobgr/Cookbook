using FluentValidation;
using MyRecipeBook.Comunication.Requests;
using MyRecipeBook.Exepition;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestRegisterUsersJson>
    {

        public RegisterUserValidator()
        {

            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMensagesExeption.NAME_EMPTY);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMensagesExeption.EMAIL_EMPTY);
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMensagesExeption.EMAIL_INVALID);
            RuleFor(user => user.Password.Length).GreaterThan(6).WithMessage(ResourceMensagesExeption.PASSWORD_EMPTY); ;

        }

    }
}
