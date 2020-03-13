using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    public class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        public int Allowance { get; private set; }

        public Manager(string name): base (name,managerHourlyRate)  //passing name and rate to base class
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay(); //call method in Staff base

            Allowance = 1000;

            if (base.HoursWorked > 160) TotalPay += 1000;
            else TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return
                "Name of Staff: " + NameOfStaff +
                ", Manager Hourly Rate: " + managerHourlyRate +
                ", Allowance: " + Allowance+
                ", Total Pay: " + TotalPay;
        }
    }            
}
