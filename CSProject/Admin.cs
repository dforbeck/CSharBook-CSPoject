using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    public class Admin : Staff
    {
        private const float overtimeRate = 15.5F;
        private const float adminHourlyRate = 30;

        public float Overtime {get; private set;}

        public Admin (string name) : base(name, adminHourlyRate)  //passing name and rate to base class
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            Overtime = overtimeRate * (HoursWorked - 160);

            if (base.HoursWorked > 160) TotalPay += Overtime;
            else TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return
                "Name of Staff: " + NameOfStaff +
                ", Admin Hourly Rate: " + adminHourlyRate +
                ", Overtime Rate: " + overtimeRate +
                 ", Overtime Amount: " + Overtime +
                ", Total Pay: " + TotalPay;
        }

    }
}
