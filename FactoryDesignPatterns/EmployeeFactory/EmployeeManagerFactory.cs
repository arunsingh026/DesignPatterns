using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns.EmployeeFactory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager returnValue = null;
            if(employeeTypeId == 1)
            {
                returnValue = new PermanentEmployee();
            }
            else if(employeeTypeId == 2)
            {
                returnValue = new TemporaryEmployee();
            }
            return returnValue;
        } 
    }
}
