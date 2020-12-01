using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDictionary
{
    public class Dictionary
    {
        private string key;
        public string Key { get => key; set => key = value; }
        
        private string meaning;
        public string Meaning { get => meaning; set => meaning = value; }
        
        private string explaination;
        public string Explaination { get => explaination; set => explaination = value; }

    }
}
