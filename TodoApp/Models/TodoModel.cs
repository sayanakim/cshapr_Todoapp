using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        // присвоение текущей даты и времени в поле CreationDate
        public DateTime CreationDate { get; set; } = DateTime.Now;
        
        public bool isDone
        {
            get { return _isDone; }
            set 
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("isDone");
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        // событие изменение элемента в списке

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
