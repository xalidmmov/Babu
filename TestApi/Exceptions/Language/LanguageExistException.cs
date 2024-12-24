namespace TestApi.Exceptions.Language
{
    public class LanguageExistException : Exception, IBaseException
    {

        public int StatusCode => StatusCodes.Status409Conflict;

        public string ErrrorMessage { get; }

        int IBaseException.StatusCode => throw new NotImplementedException();

        string IBaseException.ErrorMessage => throw new NotImplementedException();

        public LanguageExistException()
        {
            ErrrorMessage = "Bu dil movcuddur";
        }

        public LanguageExistException(string? message) : base(message)
        {
        }

    }
}
