using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int[] _frame = new int[10];
        private int _currentRoll = 0;
        private bool Spare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }

        private bool Strike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (Spare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else if (Strike(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex++;
                }
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }

            }

            return score;
        }
    }
}