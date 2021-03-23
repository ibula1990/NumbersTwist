using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersTwist
{
    public partial class numberTwist : Form
    {
        int a, s;
        public numberTwist()
        {
            InitializeComponent();
        }

        private void numberTwist_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {



                this.txtnumber.Text = i.ToString();   
            }



           

            
        }
    }
}
