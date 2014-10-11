using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (chbCreateBackup.Checked)
            {
                File.Copy(txbSelectSubtitle.Text, txbSelectSubtitle.Text + ".bak", true);
            }

            string subtitle = File.ReadAllText(txbSelectSubtitle.Text, Encoding.Default);
            subtitle = subtitle.Replace((Char)230, 'c'); //c'
            subtitle = subtitle.Replace((Char)232, 'c'); //c"
            subtitle = subtitle.Replace((Char)158, 'z'); //z"
            subtitle = subtitle.Replace((Char)154, 's'); //s"
            subtitle = subtitle.Replace(new String((Char)240, 1), "dj"); //dj
            subtitle = subtitle.Replace((Char)198, 'C'); //C'
            subtitle = subtitle.Replace((Char)200, 'C'); //C"
            subtitle = subtitle.Replace((Char)142, 'Z'); //Z"
            subtitle = subtitle.Replace((Char)138, 'S'); //S"
            subtitle = subtitle.Replace(new String((Char)208, 1), "DJ"); //DJ
            File.WriteAllText(txbSelectSubtitle.Text, subtitle, Encoding.Default);

            MessageBox.Show("Job done.", "Success", MessageBoxButtons.OK);
        }
    }
}
