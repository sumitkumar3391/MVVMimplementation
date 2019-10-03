using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApp8.Model;
using WpfApp8.ViewModel;

namespace WpfApp8.ViewModel
{
     public class DepartmentViewModel :  INotifyPropertyChanged
    {
        private ObservableCollection<Department> _department;

        private int _deptid;
        private string _deptname;
        private int _salary;
        public DepartmentViewModel()
        {
            _department = new ObservableCollection<Department>();
        }

        //public void  add1(Deaprtment1  Department )
        //{
        //    _department.Add(Department);


        //}
        public ObservableCollection<Department> Department
        {
            get { return _department; }
            set
            {
                _department = value; ONPropertChanged("Department");
            }
        }
        public int Deptid
        {
            get { return _deptid; }
            set { _deptid = value; ONPropertChanged("Deptid"); }
        }
        public string DeptName
        {
            get { return _deptname; }
            set { _deptname = value; ONPropertChanged("DeptName"); }
        }
        public int Salary1
        {
            get { return _salary; }
            set { _salary = value; ONPropertChanged("Salary1"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void ONPropertChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }

    }
}
