using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public class TemporaryEmployee : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }
    }
}
