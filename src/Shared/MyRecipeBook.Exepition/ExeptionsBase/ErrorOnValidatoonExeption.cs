namespace MyRecipeBook.Exepition.ExeptionsBase
{
    public class ErrorOnValidatoonExeption : MyRecipeBookExeption
    {

        public IList<string> ErrorsMessages { get; set; }

        public ErrorOnValidatoonExeption(IList<string> erros)
        {

            ErrorsMessages = erros;

        }





    }
}
