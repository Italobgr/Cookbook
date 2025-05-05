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

            var supportLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures);//busca todas as culturas diponives

            var requestCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();//busca do herder

            var culture = new CultureInfo("en");

            if (string.IsNullOrWhiteSpace(requestCulture) == false && supportLanguages.Any(p => p.Name.Equals(requestCulture)))
            {
                culture = new CultureInfo(requestCulture);
            }

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            //add UI

            await _next(context);


        }

    }
}
