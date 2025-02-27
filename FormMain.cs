using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTypesProducts_Click(object sender, EventArgs e)
        {
            InfoProducts formTypesProducts = new InfoProducts();
            formTypesProducts.ShowDialog();
        }

        private void buttonTypes_Click(object sender, EventArgs e)
        {
            Form1 formTypesPartners = new Form1();
            formTypesPartners.ShowDialog();
        }
    }
}
