using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class Form_Nomain : Form
    {
        public Form_Nomain()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            
        }

        private void buttonchick_Click(object sender, EventArgs e)
        {
            if(checkBox.Checked == false)
            {
                checkBox.Checked = true;
            }
            else if(checkBox.Checked == true)
            {
                checkBox.Checked = false;
            }
        }
    }
}
