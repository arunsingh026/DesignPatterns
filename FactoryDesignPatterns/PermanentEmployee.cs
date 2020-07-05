using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public class PermanentEmployee : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}
