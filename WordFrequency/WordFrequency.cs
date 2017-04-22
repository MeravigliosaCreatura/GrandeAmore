using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordFrequency
{
    class WordFrequency
    {
        private List<Word> frequency_words;
        private  const int MAX = 5;
        private string[] words;

        public WordFrequency(string source)
        {
            words = source.Split(' ');
            frequency_words = new List<Word>();
            foreach (var e in words) 
            {
                Word word = new Word();
                word.Value = e;
                frequency_words.Add(word);
            }
        }

        private int countFrequency(Word word)
        {
            int count = 0;
            foreach (var w in frequency_words)
            { 
                if(w.Value.Equals(word.Value))
                {
                    count++;
                }
            }
            word.Count = count;
            return count;
        }

        public List<Word> countToPoint()
        {
            HashSet<string> hs = new HashSet<string>();
            List<Word> uniqList = new List<Word>();
            foreach(var e in frequency_words)
            {
                if (e.Value != string.Empty)
                {
                    countFrequency(e);
                    if (hs.Add(e.Value))
                    {
                        uniqList.Add(e);
                    }
                }
            }
            int max = uniqList.Max(x => x.Count);
            foreach (var item in uniqList)
            {
                int v = (int)Math.Round((double)item.Count * MAX / max);
                item.Point = new string('★',v);
            }
            return uniqList;
        }
      
    }
}
