using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDictionary
{
    class SpeakWord
    {
        private WebBrowser webBrow;

        public SpeakWord(WebBrowser wb)
        {
            this.webBrow = wb;
        }

        public WebBrowser WebBrow { get => webBrow; set => webBrow = value; }

        private void setTextarea(string data)
        {
            HtmlElement element = WebBrow.Document.GetElementById("text");
            element.InnerHtml = data;
        }

        private void setButton()
        {
            HtmlElement element = WebBrow.Document.GetElementById("ttsgo");
            element.InvokeMember("click");
        }

        public void Speak(string word)
        {
            setTextarea(word);
            setButton();
        }
    }
}
