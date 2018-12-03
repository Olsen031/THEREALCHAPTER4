using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionFahrenheitToCelcius
{
    public partial class FahrenheitToCelsiusForm : Form
    {
        public FahrenheitToCelsiusForm()
        {
            InitializeComponent();
        }

        private void btnTempConversion_Click(object sender, EventArgs e)
        {

            double fahrenheit;
            double num1, num2, num3;
            // celsius = (fahrenheit - 32) * (5 / 9);
            num1 = Convert.ToDouble(txtTemp1Input.Text);
            num2 = Convert.ToDouble(txtTemp2Input.Text);
            num3 = Convert.ToDouble(txtTemp3Input.Text);


            lblTemp1Output.Visible = true;
            lblTemp2Output.Visible = true;
            lblTemp3Output.Visible = true;

            // start of the first temperature
            fahrenheit = num1;
            if(fahrenheit < 32)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp1Output.Text = "It is a freezing " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }
            else if(fahrenheit > 100)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp1Output.Text = "It is a scorching " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";

            }
            else
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp1Output.Text = "It is " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }
            // start of the second temperature
            fahrenheit = num2;
            if (fahrenheit < 32)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp2Output.Text = "It is a freezing " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }
            else if (fahrenheit > 100)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp2Output.Text = "It is a scorching " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";

            }
            else
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp2Output.Text = "It is " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }

            // start of the third temperature
            fahrenheit = num3;
            if (fahrenheit < 32)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp3Output.Text = "It is a freezing " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }
            else if (fahrenheit > 100)
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp3Output.Text = "It is a scorching " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";

            }
            else
            {
                double celsius = (fahrenheit - 32) * (5 / 9);
                lblTemp3Output.Text = "It is " + fahrenheit + " degrees fahrenheit outside right now. That equates to about " +
                     celsius + " degrees celsius.";
            }

        }
    }
}
