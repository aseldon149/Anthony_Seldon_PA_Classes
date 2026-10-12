
/*******************************************************************
 * Name: Anthony Seldon
 * Date: October 11, 2026
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Main application (program) class.
 * This program creates Employee objects, displays their information,
 * updates employee names and salaries, and displays the updated data.
 *******************************************************************/

using System;

public class Program
{
    static void Main(string[] args)
    {
        // Display the assignment header
        Console.WriteLine("Anthony Seldon - Week 1 PA Classes");
        Console.WriteLine();

        // Create two Employee objects.
        // John has an invalid initial salary, so his salary starts at $0.00.
        Employee employee1 = new Employee("John", "Jones", 500.00);
        Employee employee2 = new Employee("Jane", "Jamison", 2500.00);

        // Display the initial employee information
        Console.WriteLine("Initial information for each employee");

        Console.WriteLine("Name: {0} {1}",
            employee1.FirstName, employee1.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}",
            employee1.MonthlySalary);
        Console.WriteLine();

        Console.WriteLine("Name: {0} {1}",
            employee2.FirstName, employee2.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}",
            employee2.MonthlySalary);
        Console.WriteLine();

        // Update employee names and salaries
        employee1.LastName = "Smith";
        employee1.UpdateSalary(1500.00);

        employee2.FirstName = "Janey";
        employee2.UpdateSalary(2750.00);

        // Display the updated employee information
        Console.WriteLine("Updated information for each employee");

        Console.WriteLine("Name: {0} {1}",
            employee1.FirstName, employee1.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}",
            employee1.MonthlySalary);
        Console.WriteLine();

        Console.WriteLine("Name: {0} {1}",
            employee2.FirstName, employee2.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}",
            employee2.MonthlySalary);
    }
}
