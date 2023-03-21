using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//var result = new List<string>();
namespace cviko4
{
    internal class StringStatistics
    {
        string testString = "";
        public StringStatistics(string testString)
        {
            this.testString = testString;
        }     
        
        public string[] getWords()
        {
            string[] test = testString.Split();
            for (int i =0 ; i < test.Length; i++)
            {
                test[i] = test[i].Trim(new char[] { '!', ')', '(', '.', '?' });
            }
            Array.Sort(test);
            return test;
        }
        public int wordCount()
        {
            int count = 0;
            foreach (string c in getWords())
            {
                count++;
            }      
            return count;
        }
        public int rowCount()
        {
            string[] test = testString.Split("\n");
            return test.Length;
        }

        public int sentenceCount()
        {
            bool capture = false;
            int count = -1;
            for (int i = 0; i < testString.Length; i++)
            {
                if (char.IsUpper(testString[i])) capture = true;
                if(testString[i]== '.' || testString[i] == '!' || testString[i] == '?')
                {
                    capture = false;
                    count++;
                }
            }
  
            return count;
        }
        public string mostWord()
        {
            string word = "";
            int count = 0;
            int best = 0;
            for (int i = 1; i < wordCount(); i++)
            {
                if (getWords()[i] == getWords()[i - 1]) count++;
                else
                {
                    if (best < count)
                    {
                        word = getWords()[i - 1];
                        best = count;
                        count = 0;
                    }
                }
            }
            return word;
        }
        public string[] longestWords()
        {
            List<string> list = new List<string>();
            int length = 0;
            foreach (string c in getWords())
            {
                if (c.Length > length)
                {
                    length = c.Length;
                }
            }
            foreach (string c in getWords())
            {
                if (c.Length == length)
                {
                    list.Add(c);
                }
            }
            string[] words = list.ToArray();
            return words;
        }
        public string[] shortestWords()
        {
            List<string> list = new List<string>();
            int length = int.MaxValue;
            foreach (string c in getWords())
            {
                if (c.Length <= length)
                {
                    length = c.Length;
                    list.Add(c);
                }
            }
            string[] words = list.ToArray();
            return words;
        }
    }
}
