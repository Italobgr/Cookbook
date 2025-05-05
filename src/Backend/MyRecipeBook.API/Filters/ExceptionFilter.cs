using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyRecipeBook.Comunication.Responses;
using MyRecipeBook.Exepition;
using MyRecipeBook.Exepition.ExeptionsBase;
using System.Net;

namespace MyRecipeBook.API.Filters
{
    public class ExceptionFilter : IExceptionFilter //identifica a classa como  um filtro de excepitions 
    {
        public void OnException(ExceptionContext context)
        {

            if (context.Exception is MyRecipeBookExeption) //se o contexto da exeção for o mesmo do my
                HandlerProjectException(context);            
            else
                throwUnknowExcepion(context);




        }



        private void HandlerProjectException(ExceptionContext context)
        {

            if (context.Exception is ErrorOnValidatoonExeption)
            {

                var excepition = context.Exception as ErrorOnValidatoonExeption;

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new BadRequestObjectResult(new ResponseErrorJson(excepition.ErrorsMessages)); //result devolve para o body da minha resposta
            }

        }


        private void throwUnknowExcepion(ExceptionContext context)
        {

            if (context.Exception is ErrorOnValidatoonExeption)
            {

                /*FALTA CRIAR O RESTO DOS UNKNOW_ERROR ITALIANO E PORTUGUES  */

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;//internal server erro usa o obj result
                context.Result = new ObjectResult(new ResponseErrorJson(ResourceMensagesExeption.UNKNOW_ERROR)); //result devolve para o body da minha resposta
            }

        }


    }
}
