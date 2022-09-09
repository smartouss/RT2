using System;
using System.Collections.Generic;

namespace RT2.FizzBuzz
{
    public class FuzzNumberOutputCollection
    {
        private readonly Dictionary<int, string> _mappings;

        public FuzzNumberOutputCollection(int max, Dictionary<int, string> mappings)
        {
            Max = max;
            _mappings = mappings;
        }

        public FizzBuzzNumberOutput this[int number]
        {
            get
            {
                if (number < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Value cannot be less than 1.");
                }

                if (number > Max)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), $"Value cannot be larger than {Max}");
                }

                return new FizzBuzzNumberOutput(number, _mappings);
            }
        }

        public int Max
        {
            get;
        }

        public void PrintToConsole()
        {
            for (int i = 1; i < Max; i++)
            {
                Console.WriteLine(this[i].ToString());
            }
        }
    }
}

