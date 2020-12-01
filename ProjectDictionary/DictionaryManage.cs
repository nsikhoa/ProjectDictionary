using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjectDictionary
{
    public class DictionaryManage
    {
        private string filePath = "data.xml"; //
        private DictionaryItem items;

        public DictionaryItem Items { get => items; set => items = value; }
        
        public DictionaryManage()
        {
            items = (DictionaryItem)DeserializeFormXML(filePath);
        }

        /// <summary>
        /// Load dữ liệu vào comboBox
        /// </summary>
        /// <param name="combo"></param>
        public void LoadDataToComboBox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }

        public void Serialize()
        {
            SerializeToXML(items, filePath); 
        }

        /// <summary>
        /// Lưu dữ liệu xuống file XML 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer srlXML = new XmlSerializer(typeof(DictionaryItem));

            srlXML.Serialize(fs, data);
            fs.Close();
        }

        /// <summary>
        /// Lấy dữ liệu từ file XML lên form
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public object DeserializeFormXML(string filePath)
        {
            // mở file data 
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            // lấy dữ liệu và biến dữ liệu có kiểu dữ liệu là DictionaryItem
            XmlSerializer srlXML = new XmlSerializer(typeof(DictionaryItem));

            object obj = srlXML.Deserialize(fileStream);

            fileStream.Close();

            return obj; 
        }
    }
}
