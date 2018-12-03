using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDegreesConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            double temp1, temp2, temp3;
            double conversion1, conversion2, conversion3;
            string feeling1, feeling2, feeling3;
        private void btnConvertToCelsius_Click(object sender, EventArgs e)
        {
            // C = 5/9 * (F -32)
           
            lblFahrenheit1.Visible = true;
            lblCelsius.Visible = true;
            conversion1 = Convert.ToDouble(txt8InMorning.Text);
            conversion2 = Convert.ToDouble(txtNoon.Text);
            conversion3 = Convert.ToDouble(txt5AtNight.Text);
            temp1 = (conversion1 - 32) * .5556;
            temp2 = (conversion2 - 32) * .5556;
            temp3 = (conversion3 - 32) * .5556;
            if (conversion1 < 32)
            {
                feeling1 = ", it is chilly outside today";

            }
            else if (conversion1 > 100)
            {
                feeling1 = ", it is scorching outside today";
            }
            else
            {
                feeling1 = "";
            }
            if (conversion2 < 32)
            {
                feeling2 = ", it is chilly outside today";

            }
            else if (conversion2 > 100)
            {
                feeling2 = ", it is scorching outside today";
            }
            else
            {
                feeling2 = "";
            }
            if (conversion3 < 32)
            {
                feeling3 = ", it is chilly outside today";

            }
            else if (conversion3 > 100)
            {
                feeling3 = ", it is scorching outside today";
            }
            else
            {
                feeling3 = "";
            }

           
            temp1 = Math.Round(temp1, 2);
            temp2 = Math.Round(temp2, 2);
            temp3 = Math.Round(temp3, 2);

            lblTempAt8.Visible = true;
            lblTempAt12.Visible = true;
            lblTempAt5.Visible = true;



            lblTempAt8.Text = temp1 + "°" + feeling1;
            lblTempAt12.Text = temp2 + "°" + feeling2;
            lblTempAt5.Text = temp3 + "°" + feeling3;
        }

           
        private void btnConvertToFahrenheit_Click(object sender, EventArgs e)
        {
            // F = ((9 / 5) * C) + 32
            lblFahrenheit1.Visible = false;
            lblCelsius.Visible = false;
            lblCelsius1.Visible = true;
            lblFahrenheit.Visible = true;
            conversion1 = Convert.ToDouble(txt8InMorning.Text);
            conversion2 = Convert.ToDouble(txtNoon.Text);
            conversion3 = Convert.ToDouble(txt5AtNight.Text);

            
            temp1 = (1.8 * conversion1) + 32;
            temp2 = (1.8 * conversion2) + 32;
            temp3 = (1.8 * conversion3) + 32;

            temp1 = Math.Round(temp1, 2);
            temp2 = Math.Round(temp2, 2);
            temp3 = Math.Round(temp3, 2);

            if (temp1 < 32)
            {
                feeling1 = ", it is chilly outside today";

            }
            else if (temp1 > 100)
            {
                feeling1 = ", it is scorching outside today";
            }
            else
            {
                feeling1 = "";
            }
            if (temp2 < 32)
            {
                feeling2 = ", it is chilly outside today";

            }
            else if (temp2 > 100)
            {
                feeling2 = ", it is scorching outside today";
            }
            else
            {
                feeling2 = "";
            }
            if (temp3 < 32)
            {
                feeling3 = ", it is chilly outside today";

            }
            else if (temp3 > 100)
            {
                feeling3 = ", it is scorching outside today";
            }
            else
            {
                feeling3 = "";
            }

            lblTempAt8.Visible = true;
            lblTempAt12.Visible = true;
            lblTempAt5.Visible = true;

            lblTempAt8.Text = temp1 + "°" + feeling1;
            lblTempAt12.Text = temp2 + "°" + feeling2;
            lblTempAt5.Text = temp3 + "°" + feeling3;

        }
    }
}
