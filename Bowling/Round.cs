using System;

namespace Bowling
{
    public class Round
    {
        public int[] rolls = new int[21];
        public int[] frame = new int[10];
        int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public void Rolls(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }

        private bool strike(int frameNumber)
        {
            return rolls[frameNumber] == 10;
        }

        private bool spare(int frameNumber)
        {
            return rolls[frameNumber] + rolls[frameNumber + 1] == 10;
        }


        public int Score()
        {
            int score = 0;
            int frameNumber = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if(strike(frameNumber))
                {
                    score += 10 + rolls[frameNumber + 1] + rolls[frameNumber + 2];
                    frameNumber++;
                }
                else if(spare(frameNumber))
                {
                    score += 10 + rolls[frameNumber + 2];
                    frameNumber += 2;
                }
                else
                {
                    score += rolls[frameNumber] + rolls[frameNumber + 1];
                    frameNumber += 2;
                }
            }
            return score;
        }
    }
}
