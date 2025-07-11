namespace MyRecipeBook.Comunication.Responses
{
    public class ResponseErrorJson
    {
        //para garantir que pra quem instaciar essa classe vai retornar uma lista de erros, tem o ctor
        public IList<string> Errors { get; set; }

        public ResponseErrorJson(IList<string> errors) => Errors = errors;//{}

        //para não passar uma lista de erro 
        public ResponseErrorJson(string error)
        {
            Errors = [error];
        }


    }
}
