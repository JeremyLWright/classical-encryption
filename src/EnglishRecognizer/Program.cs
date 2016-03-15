using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishRecodnizer
{
    class ngram_score
    {
        class ngram_datum
        {
            public int Frequency { get; set; }
            public double Weight { get; set; }
        }

        Dictionary<string, ngram_datum> ngrams;
        double floor;
        Int64 l;
        Int64 n = 0;

        public ngram_score(StreamReader source)
        {
            string line;
            while ((line = source.ReadLine()) != null)
            {
                var delimited = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
                var working_ngram = ngrams[delimited[0]];
                working_ngram.Frequency = int.Parse(delimited[1]);
                n += working_ngram.Frequency;
            }

            foreach(var i in ngrams)
            {
                i.Value.Weight = Math.Log10((double)i.Value.Frequency / n);
            }

            floor = Math.Log10(0.01 / n);
            l = 4; //for quadgrams
        }

        double score

    }                                                                                         


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
