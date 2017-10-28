using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Information;

namespace project3
{
    public partial class start_form : Form
    {
        public start_form()
        {
            InitializeComponent();
        }
      
        private void Login_Click_1(object sender, EventArgs e)
        {
            this.Close();   //幫你改成可以接畫面2的
        }
    }
}
