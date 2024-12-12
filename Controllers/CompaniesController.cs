using Microsoft.AspNetCore.Mvc;

namespace dotnet_oa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ControllerBase
{
    private static readonly List<Company> Companies =
    [
        new Company
        {
            Name = "TechCorp",
            Departments =
            [
                new Department
                {
                    Name = "Engineering",
                    Employees =
                    [
                        new Employee { Name = "Alice", Age = 30, Skills = ["C#", "SQL", "Azure"] },
                        new Employee { Name = "Bob", Age = 25, Skills = ["Java", "Spring", "AWS"] },
                        new Employee { Name = "John", Age = 30, Skills = ["C#"] },

                    ]
                },

                new Department
                {
                    Name = "HR",
                    Employees =
                    [
                        new Employee
                        {
                            Name = "Charlie", Age = 35,
                            Skills = ["Recruitment", "Employee Relations"]
                        }
                    ]
                }
            ]
        },

        new Company
        {
            Name = "BizGroup",
            Departments =
            [
                new Department
                {
                    Name = "Sales",
                    Employees =
                    [
                        new Employee { Name = "Dave", Age = 40, Skills = ["Negotiation", "CRM"] },
                        new Employee { Name = "Eve", Age = 28, Skills = ["Marketing", "Analytics"] }
                    ]
                }
            ]
        }
    ];
    
    
    
    // Create an API that will return company, department, employee details of employees having "C#" as their skills
    
    // [
    //      {
    //          "department": "Engineering",
    //          "company": "Alice"
    //      },
    //      {
    //          "department": "Engineering",
    //          "company": "John"
    //      }
    
}