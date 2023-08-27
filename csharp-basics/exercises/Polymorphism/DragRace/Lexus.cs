using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 8;
        }

        public void SlowDown()
        {
            _currentSpeed -= 8;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 15;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
