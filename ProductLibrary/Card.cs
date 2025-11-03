using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class Card : IRepository
    {
        private List<CardLine> cards;

        public Card()
        {
            cards = new List<CardLine>();
        }

        public void Add(CardLine item)
        {
            item.CardId = cards.Count;
            if (item.Quantity > 0)
                cards.Add(item);
        }

        public CardLine Delete(int id)
        {
            try
            {
                var card = GetById(id);
                if (card != null)
                {
                    cards.Remove(card);
                    return card;
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new CardLine();
            }
        }

        public List<CardLine> Get()
        => cards;

        public CardLine? GetById(int id)
        => cards.FirstOrDefault(card => card.CardId == id);


        public void Update(int id, decimal quantity)
        {
            var card = GetById(id);
            if (card != null)
                card.Product.Stock = quantity;
        }
    }
}
