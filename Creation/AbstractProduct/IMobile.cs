namespace Creation.AbstractProduct
{
    public interface IMobile
    {
        string BrandName { get; }
        void DialNumber(int number);
        void SendMessage(int number, string message);
    }
}