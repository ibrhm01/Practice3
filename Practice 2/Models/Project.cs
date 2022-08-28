using Practice_2.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2.Models
{
    class Project
    {
        private static int _id;
        public int Id { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public DateTime StartTime { get; set; }
        public DateTime DeadLine { get; set; }
        public bool isSuccessful { get; set; }
        public Project(DateTime StartTime, DateTime DeadLine)
        {
            _id++;
            Id = _id;
            isSuccessful = false;
            this.StartTime = StartTime;
            this.DeadLine = DeadLine;
        }
        public void AssignEmployee(Employee employee)
        {
            if (Employees.Find(item => item == employee) == null)
            {
                Employees.Add(employee);
                employee.Projects.Add(this);
                return;
            }
            return;

        }
        public void RemoveEmployee(int employeeId)
        {
            Employee employee = Employees.Find(employee => employee.Id == employeeId);
            if (employee != null)
            {
                Employees.Remove(employee);
                Project project = employee.Projects.Find(project => project.Id == this.Id);
                employee.Projects.Remove(project);
            }
            else 
            {
                throw new NotFoundException("The given employee couldn't be found");
            }
            
        }
        DateTime date = DateTime.Now;
        public void Finish()
        {
            if (date > StartTime && date < DeadLine) isSuccessful = true;
        }
        public void Print()
        {
            Console.WriteLine($"Id: {Id}\nStartTime: {StartTime}\nDeadLine: {DeadLine}\n");
        }

        public override string ToString()
        {
            return $"ProjectId: {Id}\nStartTime: {StartTime}\nDeadLine: {DeadLine}\nCurrentTime: {date}\nIsSuccessful: {isSuccessful}\n";
        }


    }
}
