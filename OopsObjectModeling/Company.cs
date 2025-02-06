﻿using System;
using System.Collections.Generic;

namespace OOPSConcept
{
    internal class Company
    {
        public string Name;
        private List<Department> departments;  // Composition: Company owns Departments

        public Company(string Name)
        {
            this.Name = Name;
            departments = new List<Department>(); // Initialize empty list

            // Composition: Creating Departments inside Company constructor
            departments.Add(new Department("IT"));
            departments.Add(new Department("HR"));
        }

        public void Display()
        {
            Console.WriteLine($"Company: {Name}");
            foreach (var dept in departments)
            {
                dept.DisplayInfo();
            }
        }

        // Destructor to ensure composition behavior
        ~Company()
        {
            Console.WriteLine($"\nDeleting company {Name} and all associated departments and employees...");
            departments.Clear();  // Clearing all departments
        }
    }

    class Department
    {
        public string Name;
        private List<Employees> employees;  // Employees exist inside Department

        public Department(string Name)
        {
            this.Name = Name;
            employees = new List<Employees>();  // Initialize empty list

            // Composition: Employees created inside Department
            if (Name == "IT")
            {
                employees.Add(new Employees("Saloni", "Software Engineer"));
                employees.Add(new Employees("Amit", "System Analyst"));
            }
            else if (Name == "HR")
            {
                employees.Add(new Employees("Priya", "HR Manager"));
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"    Department: {Name}");
            foreach (var emp in employees)
            {
                emp.DisplayEmployee();
            }
        }
    }

    class Employees
    {
        public string Name;
        public string Position;

        public Employees(string Name, string Position)
        {
            this.Name = Name;
            this.Position = Position;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"        - {Name}, {Position}");
        }
    }
}