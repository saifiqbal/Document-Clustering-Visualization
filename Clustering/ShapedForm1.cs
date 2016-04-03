using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Year_Project_2
{
    public partial class ShapedForm1 : Telerik.WinControls.UI.ShapedForm
    {
        public ShapedForm1()
        {
            InitializeComponent();
        }

        private void ShapedForm1_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadForm1 dOCEXPL = new RadForm1();
            dOCEXPL.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            RadForm1 dOCEXPL = new RadForm1();
            dOCEXPL.Show();

        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            ExtractedTextViewer ext = new ExtractedTextViewer();
            ext.Show();
        }
    }
}
