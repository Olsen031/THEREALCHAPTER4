using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            enum Day
            {
                Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
            }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
           
        
        string special;
        int day = Convert.ToInt32(txtDayInput.Text);

            switch((Day)day)
            {
                case Day.Sunday:
                    special = "Fried chicken";
                    break;
                case Day.Monday:
                    special = "Sorry - closed";
                    break;
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                    special = "meat loaf";
                    break;
                case Day.Friday:
                    special = "fish fry";
                    break;
                case Day.Saturday:
                    special = "liver and onions";
                    break;
                default:
                    special = "Invalid day";
                    break;
            }
            lblSpecialOutput.Visible = true;
            lblSpecialOutput.Text = "Today's special is " + special;

        }

    }
}
