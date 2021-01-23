using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DisplayText
    {
        public string _Text { get; private set; }

        public DisplayText(string text) 
        {
            _Text = text; 
        }

        

        public string Add(int pos, string textToAdd)
        {
            String newText = _Text.Insert(pos, textToAdd);
            _Text = newText;
            return newText;
        }
        public string Replace(string from, string to)
        {
            String newText = _Text.Replace(from, to);
            _Text = newText;
            return newText;
        }
        public string Remove(int from, int to)
        {
            String newText = _Text.Remove(from, to - from);
            _Text = newText;
            return newText;
        }

        public IMemento Restore(IMemento memento)
        {
            string oldText = _Text;
            _Text = memento.getText();
            return new MyMemento(oldText);
        }

        public IMemento CreateMemento()
        {
            return new MyMemento(_Text);
        }
    }


}
