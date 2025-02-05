﻿using backend_api.Domains.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace backend_api.Domains.Entities;

[Table("Employees")]
public class Employee : Person
{
    [StringLength(20)] public string Title { get; set; }

    [Display(Name = "Hire Date")] public DateTime HireDate { get; set; }

    [Display(Name = "Supervisor")] public int? ReportsToId { get; set; }

    [ForeignKey("ReportsToId")] public Employee ReportsTo { get; set; }

    public virtual IList<Employee> Subordinates { get; set; }
}