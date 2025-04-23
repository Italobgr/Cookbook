using MyRecipeBook.Comunication.Requests;
using MyRecipeBook.Comunication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUseUseCases
    {

        public ResponseRegisterUserJson Execute(RequestRegisterUsersJson request)
        {
            Validate(request);

            //mapear a requet em uma entidade -- entidade e como uma outra classe, umas representação dos dados quue vai estar no BD

            //criptografia da senha 

            // salvar no banco de dados

            return new ResponseRegisterUserJson { Name = request.Name };

        }
        private void Validate(RequestRegisterUsersJson request) 
        {
            var validator = new RegisterUserValidator();

          var result =  validator.Validate(request);//ele retorna um obj validare result

            if (!result.IsValid)
            {
                var erroMessage = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();//fazer a manipulação das exceptions
            }


        }
    }
}
