using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using org.mariuszgromada.math.mxparser;
namespace nov_30
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void printInner (string x)
        {

            Session[x] = x;
            TextBox1.Text += Session[x].ToString();
           
 


        }
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
            printInner(Button4.Text);
        }

        //equals
        protected void Button5_Click(object sender, EventArgs e)
        {
            Expression res = new Expression(TextBox1.Text);

            TextBox1.Text = res.calculate().ToString();
          
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            printInner(Button6.Text);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            printInner(Button10.Text);
        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            printInner(Button11.Text);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            printInner(Button7.Text);
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            printInner(Button14.Text);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            printInner(Button12.Text);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            printInner(Button8.Text);
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            printInner(Button15.Text);
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            printInner(Button13.Text);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            printInner(Button9.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            printInner(Button1.Text);
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            printInner(Button2.Text);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            printInner(Button3.Text);

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            printInner(Button16.Text);
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }
    }

}