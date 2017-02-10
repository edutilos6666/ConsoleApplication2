using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LinqExample
    {
        public void Example1()
        {
            String[] names = { "foo", "bar", "bim", "pako", "edutilos", "ronaldo" };
            var res = from name in names
                      where name.Length == 3
                      select name;

            Console.WriteLine("Names: "); 
            foreach(var n in res)
            {
                Console.Write("{0} , ", n); 
            }
            Console.WriteLine(); 
        }
  
        public void Example2()
        {
            List<Department> departments = new List<Department>();
            List<Employee> employees = new List<Employee>();
            departments.Add(new Department("dep one", 1));
            departments.Add(new Department("dep two", 2));

            employees.Add(new Employee("foo", 1, 1));
            employees.Add(new Employee("bar", 2, 1));
            employees.Add(new Employee("bim", 3, 2));
            employees.Add(new Employee("pako", 4, 2));

            var res = from employee in employees
                      join d in departments on employee.DepartmentId equals d.Id
                      where employee.DepartmentId == 1 
                      select new {
                          EmployeeName = employee.Name,
                          DepartmentName =  d.Name }; 



            foreach(var v in res)
            {
                Console.WriteLine("employee = {0}, department = {1}", v.EmployeeName, v.DepartmentName); 
            }

        }

       

    }

    class Department
    {
        public String Name { get; set; }
        public int Id { get; set;  }
         
        public Department(String name, int id)
        {
            this.Name = name; 
            this.Id = id; 
        }

        public Department()
        {

        }
    }


    class Employee
    {
        public String Name { get; set;  }
        public int Id { get; set;  }
        public int DepartmentId { get; set;  }

        public Employee(String name,int id , int departmentId)
        {
            this.Name = name;
            this.Id = id;
            this.DepartmentId = departmentId; 
        }

        public Employee()
        {

        }
    }



}
