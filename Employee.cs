
/*******************************************************************
 * Name: Anthony Seldon
 * Date: October 11, 2026
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Employee class.
 * This class stores an employee's first name, last name, and
 * monthly salary. It includes a constructor to initialize employee
 * information and a method to update the monthly salary. Salaries
 * below $1000 are not accepted.
 *******************************************************************/

public class Employee
{
    // Employee first name can be read and updated.
    public string FirstName { get; set; }

    // Employee last name can be read and updated.
    public string LastName { get; set; }

    // Monthly salary can be read but can only be changed inside the class.
    public double MonthlySalary { get; private set; }

    // Create an employee with a name and an initial monthly salary.
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;

        // Only accept an initial salary of at least $1000.
        if (monthlySalary >= 1000.0)
        {
            MonthlySalary = monthlySalary;
        }
    }

    // Update the monthly salary only when it is at least $1000.
    public void UpdateSalary(double monthlySalary)
    {
        if (monthlySalary >= 1000.0)
        {
            MonthlySalary = monthlySalary;
        }
    }
}
