using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Cards
    {
        public int value { set; get; }
        public string path { set; get; }

        //метод класса по удалению уже использованной карты
        public Cards() {}
        public static Cards[] DelElement
            (Cards[] cards, int randomCard)
        {
            Cards[] newCards = new Cards[cards.Length - 1];

            for(int i = 0; i < randomCard; i++)
            {
                newCards[i] = cards[i];
            }

            for(int i = randomCard;
                i < newCards.Length; i++)
            {
                newCards[i] = cards[i+1];
            }
            return newCards;
        }
    }

}
