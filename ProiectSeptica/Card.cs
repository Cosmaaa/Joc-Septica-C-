using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSeptica
{
    internal class Card
    {
        private int value;
        private Image cardImage;
        private int cardNumber;
        public Card(string cardPath)
        {
            cardNumber = getCardNumber(cardPath);
            cardImage = Image.FromFile(cardPath);
            value = getCardValue(cardNumber);
        }

        private int getCardNumber(string cardPath)
        {
            string fullCardName = cardPath.Substring(cardPath.LastIndexOf('\\'));
            string cardValueSuite = fullCardName.Substring(fullCardName.IndexOf("_"));
            string cardNumberString = cardValueSuite.Substring(1, cardValueSuite.LastIndexOf("_") - 1);

            return int.Parse(cardNumberString);
        }
        public int getCardNumber() {
            return cardNumber;
        }

        private int getCardValue(int cardNumber)
        {
            if((cardNumber == 1) || (cardNumber == 10))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int getValue()
        {
            return value;
        }

        public Image getCardImage()
        {
            return cardImage;
        }
    }
}
