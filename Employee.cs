using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD07
{
    public class Employee:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gen {  get; set; }
        public SecurrityLevel SCL { get; set; }
        public HiringDate HD { get; set; }

        public Employee()
        {
            Id = 0;
            Name = "ahmed";
            Salary = 1234;
            Gen = Gender.Female;
            HD = default;
            SCL = SecurrityLevel.Guest;
            
        }
        public Employee(int _id, string _name, int _age, decimal _salary, Gender _gen,  HiringDate _hd, SecurrityLevel _SCL)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
            Gen = _gen;
            HD = _hd;
            SCL = _SCL;
        }


        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Salary: {string.Format("{0: 0.00}", Salary)}, {Gen}, {HD}" ;
        }

        public int CompareTo(object? obj)
        {
            Employee employee = obj as Employee;
            return this.HD.Year.CompareTo(employee.HD.Year);
        }
    }
}
