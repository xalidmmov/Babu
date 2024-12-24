namespace TestApi.Exceptions.BannedWord
{
    public class BannedWordExistException:Exception,IBaseException
    {
        int IBaseException.StatusCode => StatusCodes.Status409Conflict;

        public string ErrorMessage { get; }

        public string ErrrorMessage => throw new NotImplementedException();

        public BannedWordExistException()
        {
            ErrorMessage = "Bu soz movcuddur";
        }

        public BannedWordExistException(string? message) : base(message)
        {
            ErrorMessage = message;
        }
    }
}
