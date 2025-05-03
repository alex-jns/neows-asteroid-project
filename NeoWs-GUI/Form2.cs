using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoWs_GUI
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Form2Search_Click(object sender, EventArgs e)
        {
            mainForm.UpdateList();
            mainForm.AdvancedSearch();
            this.Close();
        }

        private void Form2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
