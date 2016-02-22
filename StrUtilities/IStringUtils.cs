using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrUtilities
{
    public interface IStringUtils
    {
        int GetWordCount(); //Broj reci u stringu
        string GetReverseString(); //Obrni svako slovo

        string GetReverseWords(); //Obrni po recima

        List<char> GetDiscreteChars(); //Daj sve karaktere koji se koriste u stringu

        int GetSentenceCount(); //Broj recenica u stringu

        int GetCharCount(char c); //Broj zadatog karaktera u stringu

    }
}
