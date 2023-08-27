using System;

namespace DragRace
{
    public class Porsche : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 9;
        }

        public void SlowDown()
        {
            _currentSpeed -= 9;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrrrrr.....");
        }
    }
}
