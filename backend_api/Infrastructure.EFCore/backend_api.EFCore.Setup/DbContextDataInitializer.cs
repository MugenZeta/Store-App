﻿using backend_api.DataServices.EFCore.DataContext;
using backend_api.Domains.Entities;
using backend_api.Domains.TestData;
using System.Collections.Generic;
using System.Linq;

namespace backend_api.EFCore.Setup;

public static class DbContextDataInitializer
{
    public static void Initialize(AppDbContext context)
    {
        context.Database.EnsureDeleted();

        context.Database.EnsureCreated();

        // Look for any data available.
        if (context.Employees.Any())
        {
            return; // DB has been seeded
        }

        var employeeDataFactory = new EmployeeDataFactory();
        var testEmployees = new List<Employee>();

        for (int i = 0; i < 10; i++)
            testEmployees.Add(employeeDataFactory.Factory_Entity());

        context.Employees.AddRange(testEmployees);
        context.SaveChanges();
    }
}