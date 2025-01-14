﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Employee
{
        public int EmployeeId { get; set; }
        public string? Address { get; set; } 
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; } 
        public string? Country { get; set; } 
        public string? Extension { get; set; } 
        public string FirstName { get; set; }  = null!;
        public DateTime? HireDate { get; set; }
        public string? HomePhone { get; set; } 
        public string LastName { get; set; }  = null!;
        public string? Notes { get; set; } 
        public byte[]? Photo { get; set; } 
        public string? PhotoPath { get; set; } 
        public string? PostalCode { get; set; } 
        public string? Region { get; set; } 
        public int? ReportsTo { get; set; }
        public string? Title { get; set; } 
        public string? TitleOfCourtesy { get; set; } 
        public ICollection<Employee> InverseReportsToNavigation { get; } = new List<Employee>();
        public ICollection<Order> Orders { get; } = new List<Order>();
        public Employee? ReportsToNavigation { get; set; }
        public ICollection<Territory> Territories { get; } = new List<Territory>();
}
