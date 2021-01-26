using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndString
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            var summaryWords = new List<string>();
            if (text.Length < maxLength)
                return text;
            else
            {
                //put words in the sentence to words list
                var words = text.Split(' ');
                //init totalChars in words
                var totalChars = 0;
                foreach (var word in words)
                {
                    //add to summaryWords list the word
                    //exit when totalChars > maxLength
                    summaryWords.Add(word);
                    totalChars += word.Length + 1;  // 1 = space between words
                    if (totalChars > maxLength)
                        break;
                }

                return String.Join(" ", summaryWords) + "...";
            }
        }
    }

    



}
