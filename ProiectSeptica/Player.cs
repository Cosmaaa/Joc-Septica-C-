using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSeptica
{
    internal class Player
    {
        private string id;
        private int score;
        List<Card> hand;
        public Player(string playerId)
        {
            id = playerId;
            score = 0;
            hand = new List<Card>();
        }
        public void setCard(Card card)
        {
            hand.Add(card);
        }

        public void setCard(int index, Card card)
        {
            hand.Insert(index, card);
        }

        public Card getCard(int index)
        {
            return hand[index];
        }

        public string getId()
        {
            return id;
        }

        public Card removeCard(int index)
        {   
            Card cardToRemove = hand[index];
            hand.RemoveAt(index);

            return cardToRemove;
        }

        public void updateScore(int firstCardValue, int secondCardValue)
        {
            score += firstCardValue + secondCardValue;
        }

        public int getScore()
        {
            return score;
        }
    }
}
