using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    class Employee : Person, IComparable
    {
        private decimal _salary;
        public decimal _Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                    throw new SalaryException("Неправильно введена зарплатня", value);
            }
        }
        private string _post;
        public string _Post
        {
            get
            {
                return _post;
            }
            set
            {
                if (value == "Бібліотекар" || value == "Охоронець" || value == "Прибиральник")
                {
                    _post = value;
                }
                else
                {
                    throw new PostException("Неправильно введна посада", value);
                }
            }
        }
        public Employee(string name, string surname, decimal salary, string post) : base(name, surname)
        {
            _Post = post;
            _Salary = salary;
        }

        public int CompareTo(object obj)
        {
            Employee o = obj as Employee;
            if (o != null)
            {
                return _Salary.CompareTo(o._Salary);
            }
            else
            {
                throw new Exception("Неможливо порівняти два об'єкта");
            }
        }
    }
}
