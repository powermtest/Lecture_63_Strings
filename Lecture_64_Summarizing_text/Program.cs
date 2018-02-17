using System;
using System.Collections.Generic;

namespace Lecture_64_Summarizing_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "to bedzie naprawde zajebiscie zajebiscie ale to naprawde zajebiscie dlugi String. Co prawda to nie jest prawda, ale na potrzeby tego cwiczenia uznajmy, ze jest tak jak tutaj jest napisane";
            var summary = StringUtility.SummarizeText(sentence, 31);
            Console.WriteLine(summary);
        }

        
    }

}
