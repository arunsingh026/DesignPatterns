using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
