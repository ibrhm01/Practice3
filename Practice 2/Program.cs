using Practice_2.Models;
using System;
using System.Collections.Generic;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime1 = new DateTime(2002, 2, 3);
            DateTime DeadLine1 = new DateTime(2002, 3, 3);

            Employee employee1 = new Employee();
            employee1.FullName = "Ibrahim";
            Employee employee2 = new Employee();
            employee2.FullName = "Resul";
            Employee employee3 = new Employee();
            employee3.FullName = "Ceyhun";
            Employee employee4 = new Employee();
            employee4.FullName = "Ahmad";
            Employee employee5 = new Employee();
            employee5.FullName = "Taleh";
            

            Project project1 = new Project(new DateTime(2022, 8, 25), new DateTime(2022, 8, 30));
            project1.AssignEmployee(employee1);
            project1.AssignEmployee(employee3);
            project1.AssignEmployee(employee5);
            Project project2 = new Project(new DateTime(2022, 7, 13), new DateTime(2022, 8, 13));
            project2.AssignEmployee(employee2);
            project2.AssignEmployee(employee4);
            project1.Finish();
            project2.Finish();

            Console.WriteLine(project1);
            project1.Employees.ForEach(employee => Console.WriteLine(employee + "\n"));
            Console.WriteLine(project2);
            project2.Employees.ForEach(employee => Console.WriteLine(employee + "\n"));

            //employee1.Projects.ForEach(project => Console.WriteLine(project + "\n"));
            //employee2.Projects.ForEach(project => Console.WriteLine(project + "\n"));
        }
    }
}
