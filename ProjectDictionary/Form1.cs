using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDictionary
{
    public partial class Form1 : Form
    {
        DictionaryManage dictionary;
        SpeakWord speak;
        string path = "https://text-to-speech.imtranslator.net/speech.asp";
        public Form1()
        {
            InitializeComponent();
            cbWord.DisplayMember = "Key";
            WebBrowser wb = new WebBrowser();
            wb.Width = 900;
            wb.Height = 500;
            wb.Visible = false;
            wb.ScriptErrorsSuppressed = true; 
            wb.Navigate(path);

            this.Controls.Add(wb);
            panel1.Visible = true;
            //panel2.Visible = false;

            speak = new SpeakWord(wb);
            dictionary = new DictionaryManage();
            dictionary.LoadDataToComboBox(cbWord);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            dictionary.Serialize();
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
            {
                return;
            }
            Dictionary data = cb.SelectedItem as Dictionary;
            txtMeaning.Text = data.Meaning;
            txtExplaination.Text = data.Explaination;
        }

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            //Dictionary word = cbWord.SelectedItem as Dictionary;
            //string str = word.Key;
            speak.Speak((cbWord.SelectedItem as Dictionary).Key);
        }
    }
}
