using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.UWP.Models
{
    public class CardCollection
    {
        public string CollectionName { get; set; }
        public List<Card> Cards { get; set; }   

        public CardCollection() { }
        public CardCollection(string collectionName) : this()
        {
            this.CollectionName = collectionName;
            this.Cards = new List<Card>();
        }
    }
}
