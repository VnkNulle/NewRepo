using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> soundMakers = new List<ISound>
            {
                new Parrot(),
                new Radio(),
                new Firework(),
                new Parrot(),
                new Radio()
            };

            foreach (var soundMaker in soundMakers)
            {
                soundMaker.PlaySound();
            }
        }
    }
}
