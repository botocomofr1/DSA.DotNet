using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class WordSplit
    {
        private int index;
        private HashSet<string> wordsMap = new HashSet<string>();
        public WordSplit()
        {
      


        }

        public bool IsSplitable(List<char> splitableword, HashSet<string> wordsMap)
        {
            this.wordsMap = wordsMap;
            if (splitableword.Count <= 0)
                return false;

     
            return IsSplitable(0, splitableword.Count - 1, splitableword);

        }

        protected bool IsSplitable(int i, int j, List<char> splitableWord)
        {
            if (i < 0  || i>j || j > splitableWord.Count - 1)
                return false;
         
            StringBuilder sb = new StringBuilder();
      
            for (int index = i; index <= j; index++)
            {
                sb.Append(splitableWord[index]);
            }
         
            var isSplitable = false;
     
            if (wordsMap.Contains(sb.ToString().ToUpper())) 
                return true;
            else
            {
                for (int k = i; k < j; k++)
                {
                    
                    isSplitable= isSplitable || (IsSplitable(i, k, splitableWord) && IsSplitable(k + 1, j, splitableWord));
                }
            }
          
            if (isSplitable)
                wordsMap.Add(sb.ToString().ToUpper());
            return isSplitable;
        }
    }
}
