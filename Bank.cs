using System;

namespace Heist
{
    public class Bank
    {
        private int _difficulty = 100;
        public int Difficulty { get { return _difficulty; } }
        public void CalculateLuck()
        {
            int Random = new Random().Next(-10, 11);
            _difficulty += Random;
        }
    }
}