using littleP5AccountingWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleP5AccountingWebForm
{
    public partial class DepreciationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            DepreciationBase investment;
            if(rbStraight.Checked)
            {
                investment = new DepreciationStraightLine();

            }
            else
            {
                investment = new DepreciationDoubleDeclining();

            }

            investment.StartingValue = decimal.Parse(txtStartingV.Text);
            investment.SalvageValue = decimal.Parse(txtSalvageV.Text);
            investment.LifeTime = int.Parse(txtLifetime.Text);
            investment.Age = int.Parse(txtAge.Text);
            
            investment.Calc();
            txtResult.Text = investment.ToString();
           
            
        }
    }
}