using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    class PaySlip
    {
        private int month;
        private int year;

        enum MonthsOfYear
        {
            JAN =1, FEB =2, MAR =3, APR =4, MAY =5, JUN =6,
            JUL = 7, AUG =8, SEP =9, OCT =10, NOV =11, DEC =12
        }

        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + ".txt";  //file name of slip for each person
               
                using (StreamWriter sw = new StreamWriter(path)) //write to the new file for each person
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                    sw.WriteLine("=================================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hours worked: {0}", f.HoursWorked);
                    sw.WriteLine("");
                    sw.WriteLine("Basic Pay: {0}", f.BasicPay);
                    if (f[0].GetType() == typeof(Manager))
                        sw.WriteLine("Allowance: {0:C}", );
                



                    sw.Close();
                }

            }



        }

    }
}
