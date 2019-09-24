using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame_G2.GameEngine
{
    class Game
    {
        public int[] PlayerCards { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerTurnScore { get; set; }

        public int[] ComputerCards { get; set; }
        public int ComputerScore { get; set; }
        public int ComputerTurnScore { get; set; }


        public int ComputerSelectedCard { get; private set; }

        private int _number_of_cards = 3;

        public Game()
        {
            PlayerCards = new int[_number_of_cards];
            ComputerCards = new int[_number_of_cards];
            Shuflle();
        }

        public void Shuflle()
        {
            Random random = new Random();

            //todo: deal with card douplication
            for (int i = 0; i < _number_of_cards; i++)
            {
                PlayerCards[i] = random.Next(1,14);
                ComputerCards[i] = random.Next(1,14);
            }
        }

        private void SelectComputerCard()
        {
            //todo: make the computer smarter!
            Random random = new Random();

            ComputerSelectedCard = ComputerCards[random.Next(0, ComputerCards.Length)];
            //todo: remove the selected card from the list

        }

        private void UpdateScores(int playerCard)
        {
            int score = (playerCard + ComputerSelectedCard) * 10;

            if (ComputerSelectedCard > playerCard)
            {
                ComputerScore += score;
                ComputerTurnScore = score;
                PlayerTurnScore = 0;
            }
            else if (playerCard > ComputerSelectedCard)
            {
                PlayerScore += score;
                PlayerTurnScore = score;
                ComputerTurnScore = 0;
            }


        }
        public void SetPlayerCard(int playerCard)
        {
            SelectComputerCard();
            UpdateScores(playerCard);
            //update scores
        }




}

}
