using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo
{
    internal class Haiku
    {
        string[] OneSyllable = new string[] { "a", "and", "it", "is", "the", "tree", "sky", "leaf", "hill", "lake", "moon", "bird", "dawn", "wind", "cloud", "snow", "field", "rain", "road", "stream", "fire", "dusk", "ice", "mist", "soil", "star", "sun", "dew", "rose", "spring", "night", "day", "peace", "life", "love", "death", "grace", "smile", "bloom", "frost", "fall" };
        


        private string WriteStanza(int syllables)
        {
            Random random= new Random();

            string line = string.Empty;

            for (int i = 0; i < syllables; i++)
            {
                line += OneSyllable[random.Next(0, OneSyllable.Length - 1)] + " ";
            }

            return line;
        }

        public void BuidHaiku()
        {
            Console.WriteLine(WriteStanza(5));
            Console.WriteLine(WriteStanza(7));
            Console.WriteLine(WriteStanza(5));
        }
    }
}
