using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_64_Summarizing_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "to bedzie naprawde zajebiscie zajebiscie ale to naprawde zajebiscie dlugi String. Co prawda to nie jest prawda, ale na potrzeby tego cwiczenia uznajmy, ze jest tak jak tutaj jest napisane";
            
            }
        }

        static string SummarizeText(string text)
        {
        const int maxLength = 20;
            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);

        }
    }

}
