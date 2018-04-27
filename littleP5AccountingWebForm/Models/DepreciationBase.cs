using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace littleP5AccountingWebForm.Models
{
    public abstract class DepreciationBase
    {
        private int age;
        private int liftime;
        private decimal salvageValue;      
        private decimal startingValue;

        public DepreciationBase()
        {
            //initialize vars
            age = 1;
            LifeTime = 1;
            salvageValue = 1.00m;
            startingValue = 2.0m;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        

        public int LifeTime
        {
            get { return liftime; }
            set { liftime = value; }
        }



        public decimal SalvageValue
        {
            get { return salvageValue; }
            set { salvageValue = value; }
        }

        

        public decimal StartingValue
        {
            get { return startingValue; }
            set { startingValue = value; }
        }

        public decimal CurrentValue { get; set; }

        public abstract void Calc();



        public override string ToString()
        {
            string resultString = String.Format("Starting Value: {0:C2}\n"
                + "Salvage Value: {1:C2}\n"
                + "Lifetime: " + LifeTime + "\n"
                + "Age: " + Age + "\n"
                + "Your investment's current value: {2:C2}" , StartingValue, SalvageValue, CurrentValue);
            return resultString;
        }


    }
}