using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT2.FizzBuzz
{
    public class FizzBuzzNumberOutput
    {
        private readonly Dictionary<int, string> _mappings;
        private Dictionary<int, string> _matchedNumbersMappings;
        private int[] _matchedNumbers;

        internal FizzBuzzNumberOutput(int number, Dictionary<int, string> mappings)
        {
            Number = number;
            _mappings = mappings;
            if (_mappings != null && _mappings.Count > 0)
            {
                foreach (var item in _mappings)
                {
                    if (Number % item.Key == 0)
                    {
                        if (_matchedNumbersMappings == null)
                        {
                            _matchedNumbersMappings = new Dictionary<int, string>();
                        }

                        _matchedNumbersMappings.Add(item.Key, item.Value);
                    }
                }

                _matchedNumbers = _matchedNumbersMappings == null ? new int[0] : _matchedNumbersMappings.Keys.ToArray();
            }
        }

        public int Number
        {
            get;
        }

        public bool IsMatch
        {
            get
            {
                return _matchedNumbersMappings != null && _matchedNumbersMappings.Count > 0;
            }
        }

        public int[] MatchedNumbers
        {
            get
            {
                return _matchedNumbers;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (!IsMatch)
            {
                stringBuilder.Append(Number);
            }
            else
            {
                foreach (var item in _matchedNumbersMappings)
                {
                    stringBuilder.Append(item.Value);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
