using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class Deaprtment1 : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnProprertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnProprertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnProprertyChanged("Description");
            }
        }

        private void OnProprertyChanged(string parameter)
        {
            var eventHandler = PropertyChanged;
            if(eventHandler!= null)
            eventHandler(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
