using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Comunication.Requests;
using MyRecipeBook.Comunication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]//o status que ele vai devolver e o body 
        public IActionResult Register(RequestRegisterUsersJson request) 
        {



                var usecase = new RegisterUseUseCases();

                var result = usecase.Execute(request);

                return Created(string.Empty, result);


        }

    }
}
