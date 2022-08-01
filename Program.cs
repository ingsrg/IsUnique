using System;

namespace IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique3("ab"));
        }

        static bool IsUnique(string word)
        {
            if(word.Length > 128) return false;

            bool[] char_set = new bool[128];

            for(int i=0; i < word.Length; i++)
            {
                if(char_set[word[i]])
                    return false;
                
                char_set[word[i]] = true;
            }

            return true;
        }

        static bool IsUnique2(string word)
        {
            char[] wordArray = word.ToCharArray();
            Array.Sort(wordArray);

            for(int i=0; i < word.Length - 1; i++)
            {
                if(wordArray[i] == wordArray[i+1])
                    return false;
            }
            return true;
        }

        static bool IsUnique3(string word)
        {
            int checker = 0;
            for(int i=0; i < word.Length; i++)
            {
                int val = word[i] - 'a';
                if( (int) (checker & (1 << val))  > 0  )
                {
                    return false;
                }

                checker |= (1 << val);
            }
            return true;
        }
    }
}
