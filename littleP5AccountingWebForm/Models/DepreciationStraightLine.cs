using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace littleP5AccountingWebForm.Models
{
    public class DepreciationStraightLine: DepreciationBase
    {
        public override void Calc()
        {

            //straight line formula: 
            //depreciable asset cost = purchase cost - estimated salvage value
            //depreciation rate = 1 / Lifetime
            //annual depreciation = depreciation rate * depreciable asset cost 
            
            decimal rate = Convert.ToDecimal(1.0) / Convert.ToDecimal(LifeTime);
            decimal depreciableCost = StartingValue - SalvageValue;
            CurrentValue = StartingValue - ((rate * depreciableCost) * Convert.ToDecimal(Age));
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result = "--Straight Line--\n" + base.ToString();
            return result;
        }
    }
}