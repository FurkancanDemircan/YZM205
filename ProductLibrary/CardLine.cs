using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class CardLine
    {
        private decimal _quantity;

        public decimal CardId { get; set; }
        public Product Product { get; set; }

        public decimal Quantity
        {
            get { return _quantity; }
            set
            {
                if (value <= Product.Stock)
                    _quantity = value;
                else
                {
                    Console.WriteLine("Not enought stock!");
                    _quantity = 0;
                }
            }
        }


        public CardLine() { }

        public CardLine(int cardId, Product product, decimal quantity)
        {
            CardId = cardId;
            Product = product;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var kdv = (double)Product.Price * .20;
            var otv = (double)((double)Product.Price + kdv) * .20;

            return ((double)Product.Price + kdv + otv) * (double)Quantity;
        }

        public override string? ToString()
        {
            return $"{CardId} {Product.ToString()} {Quantity} {TotalPrice()}";
        }
    }
}
