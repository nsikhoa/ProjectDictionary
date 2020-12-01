using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDictionary
{
    [Serializable] // thuộc tính để lưu class xuống file XML
    public class DictionaryItem
    {
        private List<Dictionary> items;

        public List<Dictionary> Items { get => items; set => items = value; }
    }
}
