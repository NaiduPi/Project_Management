﻿using Project_Management.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Infrastructure.Data
{
   public class ProjectManagementDataInMemory
    {

        // Assignment Data

        public static List<Assignment> assignments = new()
        {
            new() { ProjectId = 1000, EmployeeNumber = 111, HoursWorked = 50 },
            new() { ProjectId = 1000, EmployeeNumber = 112, HoursWorked = 100 },
            new() { ProjectId = 1000, EmployeeNumber = 113, HoursWorked = 50 },
            new() { ProjectId = 1001, EmployeeNumber = 114, HoursWorked = 150 },
            new() { ProjectId = 1001, EmployeeNumber = 112, HoursWorked = 100 },
            new() { ProjectId = 1001, EmployeeNumber = 111, HoursWorked = 140 },
            new() { ProjectId = 1002, EmployeeNumber = 113, HoursWorked = 95 },
            new() { ProjectId = 1002, EmployeeNumber = 112, HoursWorked = 85 },
            new() { ProjectId = 1002, EmployeeNumber = 111, HoursWorked = 78 },
            new() { ProjectId = 1003, EmployeeNumber = 112, HoursWorked = 250 },
            new() { ProjectId = 1003, EmployeeNumber = 114, HoursWorked = 125 },
            new() { ProjectId = 1003, EmployeeNumber = 111, HoursWorked = 150 },
            new() { ProjectId = 1004, EmployeeNumber = 115, HoursWorked = 80 },
            new() { ProjectId = 1004, EmployeeNumber = 116, HoursWorked = 70 },
            new() { ProjectId = 1004, EmployeeNumber = 117, HoursWorked = 90 },
            new() { ProjectId = 1004, EmployeeNumber = 118, HoursWorked = 90 },
            new() { ProjectId = 1005, EmployeeNumber = 115, HoursWorked = 50 },
            new() { ProjectId = 1005, EmployeeNumber = 116, HoursWorked = 300 },
            new() { ProjectId = 1005, EmployeeNumber = 117, HoursWorked = 100 },
            new() { ProjectId = 1005, EmployeeNumber = 115, HoursWorked = 140 },
            new() { ProjectId = 1006, EmployeeNumber = 116, HoursWorked = 85 },
            new() { ProjectId = 1006, EmployeeNumber = 118, HoursWorked = 95 },
            new() { ProjectId = 1006, EmployeeNumber = 117, HoursWorked = 78 },
            new() { ProjectId = 1006, EmployeeNumber = 116, HoursWorked = 250 },
            new() { ProjectId = 1007, EmployeeNumber = 119, HoursWorked = 125 },
            new() { ProjectId = 1007, EmployeeNumber = 120, HoursWorked = 150 },
            new() { ProjectId = 1007, EmployeeNumber = 121, HoursWorked = 80 },
            new() { ProjectId = 1007, EmployeeNumber = 122, HoursWorked = 140 },
            new() { ProjectId = 1008, EmployeeNumber = 119, HoursWorked = 85 },
            new() { ProjectId = 1008, EmployeeNumber = 120, HoursWorked = 95 },
            new() { ProjectId = 1008, EmployeeNumber = 121, HoursWorked = 78 },
            new() { ProjectId = 1009, EmployeeNumber = 119, HoursWorked = 250 },
            new() { ProjectId = 1009, EmployeeNumber = 120, HoursWorked = 125 },
            new() { ProjectId = 1009, EmployeeNumber = 121, HoursWorked = 150 },
            new() { ProjectId = 1010, EmployeeNumber = 119, HoursWorked = 80 },
            new() { ProjectId = 1010, EmployeeNumber = 120, HoursWorked = 60 },
            new() { ProjectId = 1011, EmployeeNumber = 121, HoursWorked = 80 }
        };


        // Department Data

        public static List<Department> departments = new()
        {
            new() { DepartmentId = 1, DepartmentName = "Marketing", PhoneNumber = 9292929292 },
            new() { DepartmentId = 2, DepartmentName = "Finance", PhoneNumber = 9292929293 },
            new() { DepartmentId = 3, DepartmentName = "Accounting", PhoneNumber = 9292929294 }
        };


        // Employee Data

        public static List<Employee> employees = new()
        {
            new() { EmployeeNumber = 111, EmployeeName = "RahulKumar", FirstName = "Rahul", LastName = "Kumar", DepartmentId = 1, Phone = 123456789, Email = "test@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 112, EmployeeName = "SunilKumar", FirstName = "Sunil", LastName = "Kumar", DepartmentId = 1, Phone = 223456789, Email = "test@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 113, EmployeeName = "ManiBupal", FirstName = "Mani", LastName = "Bupal", DepartmentId = 1, Phone = 323456789, Email = "test2@gmail.com", Salary = 20000 },
            new() { EmployeeNumber = 114, EmployeeName = "RaviKrishna", FirstName = "Ravi", LastName = "Krishna", DepartmentId = 1, Phone = 423456789, Email = "test3@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 115, EmployeeName = "SirishKarri", FirstName = "Sirish", LastName = "Karri", DepartmentId = 2, Phone = 823456789, Email = "test4@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 116, EmployeeName = "Raju", FirstName = "Raju", LastName = "Karri", DepartmentId = 2, Phone = 623456789, Email = "test5@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 117, EmployeeName = "Naidu", FirstName = "Naidu", LastName = "Karri", DepartmentId = 2, Phone = 723456789, Email = "test6@gmail.com", Salary = 20000 },
            new() { EmployeeNumber = 118, EmployeeName = "Siva", FirstName = "Siva", LastName = "Karri", DepartmentId = 2, Phone = 923456789, Email = "test7@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 119, EmployeeName = "Hemanth", FirstName = "Hemanth", LastName = "Pilla", DepartmentId = 3, Phone = 133456789, Email = "test8@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 120, EmployeeName = "Venkat", FirstName = "Venkat", LastName = "Pilla", DepartmentId = 3, Phone = 243456789, Email = "test9@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 121, EmployeeName = "Vanakar", FirstName = "Vanakar", LastName = "Pilla", DepartmentId = 3, Phone = 353456789, Email = "test71@gmail.com", Salary = 20000 },
            new() { EmployeeNumber = 122, EmployeeName = "Chinna", FirstName = "Chinna", LastName = "Pilla", DepartmentId = 3, Phone = 463456789, Email = "test72@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 123, EmployeeName = "Kishore", FirstName = "Kishore", LastName = "Karri", DepartmentId = 3, Phone = 873456789, Email = "test73@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 124, EmployeeName = "Harish", FirstName = "Harish", LastName = "Karri", DepartmentId = 3, Phone = 683456789, Email = "test74@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 125, EmployeeName = "Thusanth", FirstName = "Thusanth", LastName = "Pilla", DepartmentId = 1, Phone = 729456789, Email = "test75@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 126, EmployeeName = "Hanvika", FirstName = "Hanvika", LastName = "Pilla", DepartmentId = 2, Phone = 928456789, Email = "test76@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 127, EmployeeName = "Shanvi", FirstName = "Shanvi", LastName = "Pilla", DepartmentId = 3, Phone = 127456789, Email = "test77@gmail.com", Salary = 10000 },
            new() { EmployeeNumber = 128, EmployeeName = "Vedha", FirstName = "Vedha", LastName = "Pilla", DepartmentId = 1, Phone = 226456789, Email = "test78@gmail.com", Salary = 15000 },
            new() { EmployeeNumber = 129, EmployeeName = "Jeshna", FirstName = "Jeshna", LastName = "Polimera", DepartmentId = 2, Phone = 325456789, Email = "test99@gmail.com", Salary = 20000 },
            new() { EmployeeNumber = 130, EmployeeName = "Rama", FirstName = "Rama", LastName = "Polimera", DepartmentId = 3, Phone = 424456789, Email = "test79@gmail.com", Salary = 15000 }
        };

        //Project Data

        public static List<Project> projects = new()
        {
            new() { ProjectId = 1000, ProjectName = "2022 Q1 Product Plan", DepartmentId = 1, MaxHours = 500, StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 3, 31) },
            new() { ProjectId = 1001, ProjectName = "2022 Q2 Product Plan", DepartmentId = 1, MaxHours = 600, StartDate = new DateTime(2022, 1, 4), EndDate = new DateTime(2022, 7, 31) },
            new() { ProjectId = 1002, ProjectName = "2022 Q3 Product Plan", DepartmentId = 1, MaxHours = 700, StartDate = new DateTime(2022, 1, 7), EndDate = new DateTime(2022, 10, 31) },
            new() { ProjectId = 1003, ProjectName = "2022 Q4 Product Plan", DepartmentId = 1, MaxHours = 800, StartDate = new DateTime(2022, 1, 10), EndDate = new DateTime(2022, 12, 31) },
            new() { ProjectId = 1004, ProjectName = "2022 Q1 Portfolio Analysis", DepartmentId = 2, MaxHours = 300, StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 3, 31) },
            new() { ProjectId = 1005, ProjectName = "2022 Q2 Portfolio Analysis", DepartmentId = 2, MaxHours = 400, StartDate = new DateTime(2022, 1, 4), EndDate = new DateTime(2022, 7, 31) },
            new() { ProjectId = 1006, ProjectName = "2022 Q3 Portfolio Analysis", DepartmentId = 2, MaxHours = 900, StartDate = new DateTime(2022, 1, 7), EndDate = new DateTime(2022, 10, 31) },
            new() { ProjectId = 1007, ProjectName = "2022 Q4 Portfolio Analysis", DepartmentId = 2, MaxHours = 800, StartDate = new DateTime(2022, 1, 10), EndDate = new DateTime(2022, 12, 31) },
            new() { ProjectId = 1008, ProjectName = "2022 Q1 Tax Preparation", DepartmentId = 3, MaxHours = 700, StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 3, 31) },
            new() { ProjectId = 1009, ProjectName = "2022 Q2 Tax Preparation", DepartmentId = 3, MaxHours = 850, StartDate = new DateTime(2022, 1, 4), EndDate = new DateTime(2022, 7, 31) },
            new() { ProjectId = 1010, ProjectName = "2022 Q3 Tax Preparation", DepartmentId = 3, MaxHours = 900, StartDate = new DateTime(2022, 1, 7), EndDate = new DateTime(2022, 10, 31) },
            new() { ProjectId = 1011, ProjectName = "2022 Q4 Tax Preparation", DepartmentId = 3, MaxHours = 800, StartDate = new DateTime(2022, 1, 10), EndDate = new DateTime(2022, 12, 31) }
        };
    }
}
