using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSeptica
{
    internal class Rule
    {
        public Rule() { }

        public string getWinner(Card player1Card, Card player2Card, Player lastPlayer)
        {
            string winner = "Player1";
            if (lastPlayer.getId() == "Player1")
            {
                if ((player2Card.getCardNumber() == 7) || (player2Card.getCardNumber() == player1Card.getCardNumber()))
                {
                    winner = "Player2";
                }
                else if (player2Card.getCardNumber() != player1Card.getCardNumber())
                {
                    winner = "Player1";
                }
            }
            else if (lastPlayer.getId() == "Player2")
            {
                if ((player1Card.getCardNumber() == 7) || (player1Card.getCardNumber() == player2Card.getCardNumber()))
                {
                    winner = "Player1";
                }
                else if (player1Card.getCardNumber() != player2Card.getCardNumber())
                {
                    winner = "Player2";
                }
            }

            return winner;
        }

    }

}
