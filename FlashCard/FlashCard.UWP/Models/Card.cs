using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.UWP.Models
{
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Card() { }
        public Card(string question, string answer) : this()
        {
            this.Question = question;
            this.Answer = answer;
        }
    }
}
