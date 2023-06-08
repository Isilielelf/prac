using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Информация о всех сотрудниках");
                Console.WriteLine("2. Вся зарплата сотрудников и средняя зарплата");
                Console.WriteLine("3. Имена сотрудников");
                Console.WriteLine("4. Минимальная зарплата среди сотрудников");
                Console.WriteLine("5. Максимальная зарплата среди сотрудников");
                Console.WriteLine("6. Индексирование зарплаты сотрудников");
                Console.WriteLine("7. Минимальная зарплата сотрудников в отдном из отделов");
                Console.WriteLine("8. Максимальная зарплата сотрудников в отдном из отделов");
                Console.WriteLine("9. Средняя зарплата сотрудников в отдном из отделов");
                Console.WriteLine("10. Индексированная зарплата сотрудников в отдном из отделов");
                Console.WriteLine("11. Информация о сотрудниках одного из отделов");
                Console.WriteLine("12.Добавить нового сотрудника");
                Console.WriteLine("13.Удалить сотрудника");
                Console.WriteLine();


                Console.WriteLine("Введите номер задания");
                int ex = Convert.ToInt32(Console.ReadLine());
                EmployeeBook emp = new EmployeeBook();
                switch (ex)
                {
                    case 1:
                        emp.List();
                        Console.WriteLine();
                        break;
                    case 2:
                        emp.GetTotalSalary();
                        Console.WriteLine();
                        break;
                    case 3:
                        emp.AllFullName();
                        Console.WriteLine();
                        break;
                    case 4:
                        emp.MinSalary();
                        Console.WriteLine();
                        break;
                    case 5:
                        emp.MaxSalary();
                        Console.WriteLine();
                        break;
                    case 6:
                        emp.IndexSalary();
                        Console.WriteLine();
                        break;
                    case 7:
                        emp.MinSalaryDepart();
                        Console.WriteLine();
                        break;
                    case 8:
                        emp.MaxSalaryDepart();
                        Console.WriteLine();
                        break;
                    case 9:
                        emp.AvgSalDep();
                        Console.WriteLine();
                        break;
                    case 10:
                        emp.IndexSalaryDepart();
                        Console.WriteLine();
                        break;
                    case 11:
                        emp.AllInfoDep();
                        Console.WriteLine();
                        break;
                    case 12:
                        emp.AddNew();
                        Console.WriteLine();
                        break;
                    case 13:
                        emp.Delete();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Нет такого задания. Введите другое значение.");
                        Console.WriteLine();
                        break;





                }

                Console.WriteLine("(Y)es/(N)o");
                string choiseEx = Console.ReadLine();
                if (choiseEx == "Y" || choiseEx == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (choiseEx == "N" || choiseEx == "n")
                {
                    break;
                }
            }
            Console.ReadKey();
        }


    }
}
