using System;

namespace EmployeeCrudApi.Employees.Dto;

public class CreateEmployeeRequest
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double Salary { get; set; }
}
