using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_Project_1
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void modStoreItems_btn_Click(object sender, EventArgs e)
        {
          this.Close();
            new Items().Show();
        }

    }
}
