using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class ValidAnagram
    {
        public ValidAnagram() { }
        public bool IsAnagram(string source, string target)
        {
          
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target) 
                    || source.Length != target.Length)
                return false;
            Dictionary<char, int> sourceByCharMap = new Dictionary<char, int>();
            for(int i=0; i < source.Length; i++)
            {
                var key = source.Substring(i, 1).ToLower().ToCharArray()[0];
                if (key == ' ')
                    continue;
                if (sourceByCharMap.Keys.Contains(key))
                {
                    sourceByCharMap[key]++;

                }
                else
                {
                    sourceByCharMap.Add(key, 1);

                }
            }
            for(int i=0; i < target.Length; i++)
            {
                var key = target.Substring(i, 1).ToLower().ToCharArray()[0];
                if (key == ' ')
                    continue;
                if (sourceByCharMap.Keys.Contains(key) && sourceByCharMap[key] > 0)
                {
                    sourceByCharMap[key]--;
                }
                else
                {
                    return false;
                }

            }

            return !sourceByCharMap.Where(x=>x.Value>0).Any();
        }
    }
}
