using System;
using System.Collections.Generic;

namespace RT2.FizzBuzz
{
    public class FizzBuzzTool
    {
        public static FuzzNumberOutputCollection Evaluate(int end, Dictionary<int, string> mappings)
        {
            if (end < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(end), "Value should be greater than 1.");
            }

            if (mappings == null || mappings.Count == 0)
            {
                throw new ArgumentException("At least one mapping should be provided.", nameof(mappings));
            }

            return new FuzzNumberOutputCollection(end, mappings);
        }
    }
}
