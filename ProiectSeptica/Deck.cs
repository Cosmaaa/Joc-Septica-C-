using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSeptica
{
    internal class Deck
    {
        List<Card> card;
        Random random;
        public Deck()
        {
            card = new List<Card>();
            string deckPath = getDeckPath();
            string[] filePaths = Directory.GetFiles(deckPath, "*.png");
            random = new Random();
            for (int i = 0; i < 32; i++)
            {
                card.Add(new Card(filePaths[i]));
            }
        }
        private string getDeckPath()
        {
            string assetsPath = "\\GameAssets\\DeckAssets\\";
            string workingDirectory = Environment.CurrentDirectory;
            string fullPath = Directory.GetParent(workingDirectory).Parent.FullName;
            string gameAssetsFolderPath = fullPath + assetsPath;

            return gameAssetsFolderPath;
        }
        public Card getCard()
        {

            Card randomCard = card[random.Next(0, card.Count())];
            card.Remove(randomCard);

            return randomCard;
        }
        public bool hasCards()
        {
            return card.Count > 0;
        }

    }
}
