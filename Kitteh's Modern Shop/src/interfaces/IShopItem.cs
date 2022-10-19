namespace Kitteh_s_Modern_Shop.src.interfaces
{
    internal interface IShopItem
    {
        public string? ItemName { get; }
        public double ItemPrice { get; }
        public int QuantityOrdered { get; }
        public double ReturnPrice(); //Method will be used to format price into two decimal places
    }
}
