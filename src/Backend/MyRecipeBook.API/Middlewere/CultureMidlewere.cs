using System.Globalization;

namespace MyRecipeBook.API.Middlewere
{
    public class CultureMidlewere
    {

        public async Task Invoke(HttpContext context) 
        {
            var requestCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();//busca do herder

            CultureInfo.CurrentCulture = new CultureInfo(requestCulture);//manda trocar

            //add UI


        }

    }
}
