using System.Globalization;

namespace MyRecipeBook.API.Middlewere
{
    public class CultureMidlewere
    {

        private readonly RequestDelegate _next;

        public CultureMidlewere(RequestDelegate next) 
        {
            _next = next;
        }
        


        public async Task Invoke(HttpContext context) 
        {
            var requestCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();//busca do herder

            var culture = new CultureInfo(requestCulture);

            CultureInfo.CurrentCulture = culture;//manda trocar
            CultureInfo.CurrentUICulture = culture;

            //add UI

            await _next(context);


        }

    }
}
