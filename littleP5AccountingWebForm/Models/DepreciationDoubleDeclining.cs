using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace littleP5AccountingWebForm.Models
{
    public class DepreciationDoubleDeclining: DepreciationBase
    {
        public override void Calc()
        {
            //Double Declining Formula:
            //2  ×  Straight-line depreciation rate  ×  Book value at the beginning of the year
            decimal currentVal = StartingValue;
            decimal depreciableCost;
            decimal rate = Convert.ToDecimal(1.0) / Convert.ToDecimal(LifeTime);
            for (int i = 0; i < Age; i++)
            {
                depreciableCost = currentVal - SalvageValue;
                rate = (Convert.ToDecimal(1.0) / Convert.ToDecimal(LifeTime)) * 2;
                currentVal -= (currentVal * rate);
            }
            CurrentValue = currentVal;
        }
        public override string ToString()
        { 
            string result = "--Double Declining--\n" + base.ToString();
            return result;
        }
    }
}