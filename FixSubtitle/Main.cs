using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixSubtitle
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectSubtitle_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt, .sub, .srt)|*.txt;*.sub;*.srt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            bool userClickedOK = openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK;

            // Process input if the user clicked OK.
            if (userClickedOK == true)
            {
                txbSelectSubtitle.Text = openFileDialog.FileName;
            }
        }

        private void btnRemoveSerbianLetters_Click(object sender, EventArgs e)
        {

        }
    }
}
