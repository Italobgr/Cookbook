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
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email não pode ser vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email não e valido");
            RuleFor(user => user.Password.Length).GreaterThan(6);

        }

    }
}
