using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PartaMod
{
    public partial class ModMenu : Form
    {
        public ModMenu()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuildModButton_Click(object sender, EventArgs e)
        {
            if(ModTypePsychOption.Checked == true)
            {
                PsychBuilder psychWindow = new PsychBuilder();
                psychWindow.Show();
            }
        }
    }
}
