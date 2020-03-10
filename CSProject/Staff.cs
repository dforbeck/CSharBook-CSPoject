﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    public class Staff
    {
        private float hourlyRate;
        private int hWorked;

        public float TotalPay {get; protected set;}
        public float BasicPay {get; private set;}
        public string NameOfStaff{get; private set;}

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0) hWorked = value;
                else hWorked = 0;
            }
        }

        public Staff(string name, float rate)
        {
            string NameOfStaff = name;
            float hourlyRate = rate;
        }

        public virtual void CalculatePay() // virtual- may be overwritten and no return value
        {
            Console.WriteLine("Calculating pay ...");

            float BasicPay = hWorked * hourlyRate;

            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return
                "Name of Staff: " + NameOfStaff +
                ", Hourly Rate: " + hourlyRate +
                ", Hours Worked: " + HoursWorked +
                ", Total Pay: " + TotalPay;
        }        
    }
}
