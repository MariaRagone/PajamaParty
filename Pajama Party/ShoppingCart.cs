using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }

        //constructor

        //defaults
        public ShoppingCart()
        {
            ShoppingCartId = 0;
        }

        public ShoppingCart(int _shoppingCartId)
        {
            ShoppingCartId = _shoppingCartId;
        }   
    }

    internal class Items : ShoppingCart
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        //constructor
        public Items(int _itemID, string _itemName, double _price, int _quantity, int _shoppingCartId)
                : base(_shoppingCartId)
        {
            itemID = _itemID;
            itemName = _itemName;
            price = _price;
            quantity = _quantity;
        }
 
    //defaults

        public Items ()
        {
            itemID = 0;
            itemName = "Free Gift";
            price = 0; 
            quantity = 1;
        }
        //methods

        public override string ToString()
        {
            return String.Format("{0,20} {1,20} {2,20} {3,20}", itemID, itemName, price, quantity);
        }
    }

}
