using ExercicioListas;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Slary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int num = int.Parse(Console.ReadLine());
            Employee s1 = list.Find(x => x.Id == num);

            if (s1 != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                s1.increaseSalary(percentage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine();
            }


            Console.WriteLine("Update list of employees: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
