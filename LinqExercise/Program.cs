using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            // DONE -- Print the Sum and Average of numbers
            int sum = numbers.Sum();
            double avg = numbers.Average();
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine("--------------------");

            // DONE -- Order numbers in ascending order and decsending order. Print each to console.
            var numbersAscending = numbers.OrderBy(num => num);
            var numbersDescending = numbers.OrderByDescending(num => num);

            foreach(int num in numbersAscending)
            {
                Console.WriteLine(num);
            }

            foreach(int num in numbersDescending)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------------------");

            // DONE -- Print to the console only the numbers greater than 6
            var largeNumbers = numbers.Where(num => num > 6);
            foreach(int num in largeNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------------------");

            // DONE -- Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var ascendingList = new List<int>();
            ascendingList = numbersAscending.ToList();

            Console.WriteLine(ascendingList[0]);
            Console.WriteLine(ascendingList[1]);
            Console.WriteLine(ascendingList[2]);
            Console.WriteLine(ascendingList[3]);
            Console.WriteLine("--------------------");

            // DONE -- Change the value at index 4 to your age, then print the numbers in decsending order
            ascendingList[4] = 31;
            foreach (int num in ascendingList.OrderByDescending(num => num))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------------------");

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            // DONE -- Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            // DONE -- Order this in acesnding order by FirstName.
            foreach (Employee employee in employees.Where(name => name.FirstName.ToLower().StartsWith('c') || 
                                                                  name.FirstName.ToLower().StartsWith('s'))
                                                                  .OrderBy(name => name.FirstName))
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine("--------------------");

            // DONE -- Print all the employees' FullName and Age who are over the age 26 to the console.
            // DONE -- Order this by Age first and then by FirstName in the same result.
            foreach(var employee in employees.Where(name => name.Age > 26).OrderBy(name => name.FirstName).OrderBy(name => name.Age))
            {
                Console.WriteLine($"{employee.FullName}, {employee.Age}");
            }
            Console.WriteLine("--------------------");

            // DONE -- Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            double sumYears = 0;
            int count = 0;
            foreach (var employee in employees.Where(name => name.YearsOfExperience <= 10 && name.Age > 35))
            {
                sumYears += employee.YearsOfExperience;
                count++;
            }
            Console.WriteLine(sumYears);
            Console.WriteLine(sumYears / count);
            Console.WriteLine("--------------------");

            // DONE -- Add an employee to the end of the list without using employees.Add()
            employees.Insert(employees.Count, new Employee("Brian", "Chan", 31, 0));
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
