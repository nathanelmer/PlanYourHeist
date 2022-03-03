using System;

namespace Heist
{
    public class Bank
    {
        private int _difficulty = 0;
        public int Difficulty { get { return _difficulty; } }
        public void CalculateDifficulty(int difficulty)
        {
            int Random = new Random().Next(-10, 11);
            _difficulty = Random + difficulty;
        }
    }
}