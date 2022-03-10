using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling
{
    public class BowlingGame
    {
        private int count = 0;
        private bool firstRoll = true;

        public List<Player> Players { get; set; } = new List<Player>();

        public Player currentPlayer => Players[count];

        public BowlingGame(List<string> names)
        {
            foreach(var name in names)
            {
                var player = new Player(name);
                Players.Add(player);
            }
        }

        public void Roll(int pins)
        {
            currentPlayer.Round.Roll(pins);
            if(pins == 10)
            {
                count++;
            }
            else
            {
                if(firstRoll == true)
                {
                    firstRoll = false;
                }
                else
                {
                    firstRoll = true;
                    count++;
                }
            }
        }
    }
}
