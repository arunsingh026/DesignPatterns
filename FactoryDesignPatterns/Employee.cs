using FactoryDesignPatterns.EmployeeFactory;
using System;
/// <summary>
/// A factory method, for creating an object, and then using this factory method by calling it to create the object. 
/// This enables writing of subclasses that decide how a parent object is created and what type of objects the parent contains.
/// </summary>
namespace FactoryDesignPatterns
{
    public class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Employee Management System!!!-------------");
            Console.Write("Please enter employee type to get 'Bonus' & 'Pay' info!-> ");
            int employeeType = Convert.ToInt32(Console.ReadLine()); 
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployeeManager employeeManager = empFactory.GetEmployeeManager(employeeType);
            var bonus = employeeManager.GetBonus();
            var pay = employeeManager.GetPay();
            Console.WriteLine("Get Bonus : " + bonus);
            Console.WriteLine("Get Pay : " + pay);
            Console.Write("Press any key to exit!!!");
            Console.ReadLine();
        }
    }
}
