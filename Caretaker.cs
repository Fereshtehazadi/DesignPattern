using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Caretaker
    {
        private Stack<IMemento> _undoMementos= new Stack<IMemento>();
        private Stack<IMemento> _redoMementos = new Stack<IMemento>();
        private DisplayText _displayText = null;

        public Caretaker(DisplayText displayText)
        {
            _displayText = displayText;
        }
        public void Backup()
        {
            _undoMementos.Push(_displayText.CreateMemento());
            _redoMementos.Clear();
        }
        public void Undo()
        {
            if (_undoMementos.Count > 0)
            {
                var undoMemento = _undoMementos.Pop();
                var redoMemento = _displayText.Restore(undoMemento);
                _redoMementos.Push(redoMemento);
            }
        }
        public void Redo()
        {
            if (_redoMementos.Count > 0)
            {
                var redoMemento = _redoMementos.Pop();
                var undoMemento = _displayText.Restore(redoMemento);
                _undoMementos.Push(undoMemento);
            }
        }

        public bool EnableUndo()
        {
            return _undoMementos.Count > 0;
        }
        public bool EnableRedo()
        {
            return _redoMementos.Count > 0;
        }
    }
}
