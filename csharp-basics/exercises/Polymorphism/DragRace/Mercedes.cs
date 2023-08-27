using System;

namespace DragRace
{
    public class Mercedes : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public void SlowDown()
        {
            _currentSpeed -= 6;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Vroooom.....");
        }
    }
}
