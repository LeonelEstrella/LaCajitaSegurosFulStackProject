namespace Application.Exceptions
{
    public class CustomBadRequest : Exception
    {
        public CustomBadRequest(string message) : base(message)
        {
        }
    }
}
