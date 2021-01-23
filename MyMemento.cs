using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MyMemento: IMemento
    {
        private string _Text;
        public MyMemento(string text)
        {
            _Text = text;
        }
        public string getText()
        {
            return _Text;
        }




    }
}
