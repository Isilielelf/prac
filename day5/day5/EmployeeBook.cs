using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class EmployeeBook
    {
        private List<Employee> employees = new List<Employee>()
            {
            new Employee("one", 1,10000),
            new Employee("two", 1,30000),
            new Employee("three", 2,80000),
            new Employee("four", 2,20000),
            new Employee("five", 3, 10000),
            new Employee("six", 3, 50000),
            new Employee("seven", 4,70000),
            new Employee("eight", 4,20000),
            new Employee("nine", 5, 1000),
            new Employee("ten", 5, 30000),

            };

     

       public void List()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Имя: {emp.Fullname}, " +
                 $"Отдел: {emp.Department}," +
                 $"Зарплата: {emp.Salary}");
                Console.WriteLine();
            }

        }


        public void GetTotalSalary()
        {
            double totalSalary = 0;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    totalSalary += employee.Salary;
                }
            }
            AvgSalary();
            void AvgSalary()
            {
                Console.WriteLine("Средняя зарплата сотрудников:" + totalSalary / 10);
                Console.WriteLine();


            }

            Console.WriteLine("Ежемесячные затраты на зарплату сотрудникам:" + totalSalary * 28);
            Console.WriteLine();
        }



        public void AllFullName()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine("ФИО: {0}", emp.Fullname);
                Console.WriteLine();
            }
        }



        public void MinSalary()
        {
            Console.WriteLine($"Минимальная зарплата: {employees.Min(emp => emp.Salary + "  " + emp.Fullname)}");
        }


   
        public void MaxSalary()
        {
            Console.WriteLine($"Мнимальная зарплата: {employees.Max(emp => emp.Salary + "  " + emp.Fullname)}");
        }


        public void IndexSalary()
        {
            Console.WriteLine("Введите процент: ");
            double index = Convert.ToDouble(Console.ReadLine());
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ФИО: {0}", emp.Fullname);
                Console.Write("Индексированная зарплата сотрудников: ");
                Console.WriteLine(emp.Salary *= index);
                Console.WriteLine();

            }

        }

        public void MinSalaryDepart()
        {
            Console.WriteLine("Миимальная зарплата отдела");
            Console.WriteLine("введите номер отдела:");

            double minDepSal = double.Parse(Console.ReadLine());
            var empDepMin = employees.Where(emp => emp.Department == minDepSal);
            if (empDepMin.Any())
            {
                var depMinSalary = empDepMin.OrderBy(emp => emp.Salary).First();
                Console.WriteLine($"Человек с самой минимальной зарплатой в отделе {minDepSal}: {depMinSalary.Fullname} - {depMinSalary.Salary} рублей");
            }
            else
            {
                Console.WriteLine($"Отдел {minDepSal} не найден или в нем сотрудников.");
            }
        }


        public void MaxSalaryDepart()
        {
            Console.WriteLine("введите номер отдела:");
            double maxDepSal = double.Parse(Console.ReadLine());
            var empDepMax = employees.Where(emp => emp.Department == maxDepSal);
            if (empDepMax.Any())
            {
                var depMaxSalary = empDepMax.OrderBy(emp => emp.Salary).Last();
                Console.WriteLine($"Человек с максимальной зарплатой в отделе {maxDepSal}: {depMaxSalary.Fullname} - {depMaxSalary.Salary} рублей");
            }
            else
            {
                Console.WriteLine($"Отдел {maxDepSal} не найден или в нем сотрудников.");
            }
        }


        public void AvgSalDep()
        {
            int count = 0;
            double avgSal = 0;
            Console.WriteLine("введите номер отдела:");
            int depNum = int.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                count++;
                avgSal += emp.Salary;
            }
            avgSal /= count;
            Console.WriteLine($"Средняя зарплата по отделу: {avgSal}");
        }


        public void IndexSalaryDepart()
        {
            Console.WriteLine("введите номер отдела:");
            int depNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент: ");
            double indDep = double.Parse(Console.ReadLine());

            foreach (var emp in employees)
            {
                if (emp.Department == depNum2)
                {
                    indDep *= emp.Department;
                    Console.WriteLine($"Зарплата отдела {depNum2} равна: {depNum2}");
                }
            }

        }



        public void AllInfoDep()
        {
            Console.WriteLine("введите номер отдела:");
            int depInfo = int.Parse(Console.ReadLine());
            foreach (Employee emp in employees)
            {
                if (emp.Department == depInfo)
                {
                    Console.WriteLine("ФИО: {0}", emp.Fullname);
                    Console.WriteLine("Зарплата: {0}", emp.Salary);
                    Console.WriteLine();
                }
            }
        }

        public void AddNew()
        {
            Console.WriteLine("Введите ФИО сотрудника:");
            string newName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите отдел сотрудника");
            int newDepartment = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите зарплату");
            double newSalary = double.Parse(Console.ReadLine());

            employees.Add(new Employee(fullname: newName, department: newDepartment, salary: newSalary));
            Console.WriteLine("Сотрудник добавлен");
        }

        public void Delete()
        {
            Console.WriteLine("Выберите сотрудника, которого хотите удалить из списка");
            int deleteEmp = int.Parse(Console.ReadLine());

            foreach (var emp in employees)
            {
                if (emp.Id == deleteEmp)
                {
                    employees.Remove(emp);
                    break;
                }
            }
            Console.WriteLine("Новый список сотрудников:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Fullname);
            }
        }

    }
}
