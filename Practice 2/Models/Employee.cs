using Practice_2.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2.Models
{
    class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
        public Employee()
        {
            _id++;
            Id = _id;
        }
        public void Leave(int id)
        {
            Project project = Projects.Find(project => project.Id == id);
            if (project != null)
            {
                Projects.Remove(project);
                Employee employee = project.Employees.Find(employee => employee.Id == this.Id);
                project.Employees.Remove(employee);
            }
            else
            {
                throw new NotFoundException("The given project couldn't be found");
            }
            
        }
        public override string ToString()
        {
            return $"FullName: {FullName}\nEmployeeId: {Id}\n";
        }
    }
}
