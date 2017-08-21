using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes, they're equivalent." : "No, they're not equivalent.";
            resultLabel.Text = (oldCheckBox.Checked) ?
            "I'm teaching an old dog new tricks!" :
            "Young whippershapper! Get off my lawn!";
        }
    }
}