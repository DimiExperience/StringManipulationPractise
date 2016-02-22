using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StrUtilities
{
    public class StringUtils : IStringUtils
    {
        private string _mStr;
        public StringUtils(string str)
        {
            _mStr = str;
        }

        public int GetWordCount()
        {
            //var spaceCount = 0;   prebaceno u linq
            //for (var i = 0; i < _mStr.Length; i++)
            //{
            //    var c = _mStr[i];
            //    if (c == ' ')
            //    {
            //        spaceCount++;
            //    }
            //}
            var spaceCount = _mStr.Count(c => c == ' ');
            return spaceCount + 1;
        }

        public string GetReverseString()
        {
            var sb = new StringBuilder();
            for (var i = _mStr.Length - 1; i >= 0; i--)
            {
                sb.Append(_mStr[i]);
            }

            return sb.ToString();
        }

        public string GetReverseWords()
        {
            var reverseWords = new List<string>();
            var words = _mStr.Split(' ');
            for (var i = words.Length - 1; i >= 0; i--)
            {
                reverseWords.Add(words[i]);
                
            }
            return string.Join(" ", reverseWords);

        }

        public List<char> GetDiscreteChars()
        {
            var listOfChars = new List<char>();




            return listOfChars;
        }

        public int GetSentenceCount() // DOMACI!
        {
            var wordsInString = new List<string>();
            var words = _mStr.Split(' ');
            var retVal = 0;
            for (var i = words.Length - 1; i >= 0; i--)
            {
                wordsInString.Add(words[i]);
            }
            var sentanceEnding = new List<string> {".", "!", "?"};
            var exceptionEnding = new List<string> {"dr.", "mr.", "mrs.", "ms."};

            foreach (string word in wordsInString)
            {
                foreach (string end in sentanceEnding)
                {
                    if (word.EndsWith(end))
                    {
                        retVal++;
                    }
                }
                foreach (string falseEnd in sentanceEnding)
                {
                    if (word.EndsWith(falseEnd))
                    {
                        retVal--;
                    }
                }
            }
            return retVal;
        }

        public int GetCharCount(char c)
        {
            //var charCount = 0;    prebaceno u Linq
            //foreach (char character in _mStr)
            //{
            //    if (character == c)
            //    {
            //        charCount++;
            //    }
            //}
            //return charCount;

            return _mStr.Count(character => character == c);
        }
    }
}
