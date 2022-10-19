using Kitteh_s_Modern_Shop.src.interfaces;

namespace Kitteh_s_Modern_Shop.src.classes
{
    internal class ShopItem : IShopItem
    {
        //Constructor
        public ShopItem(string itemName, double itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        //Interface
        public string? ItemName { get; private set; }
        public double ItemPrice { get; private set; }
        public int QuantityOrdered { get; set; }

        public double ReturnPrice()
        {
            return ItemPrice * QuantityOrdered;
        }
    }
}
