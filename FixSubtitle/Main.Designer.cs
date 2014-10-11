namespace FixSubtitle
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectSubtitle = new System.Windows.Forms.Label();
            this.txbSelectSubtitle = new System.Windows.Forms.TextBox();
            this.btnSelectSubtitle = new System.Windows.Forms.Button();
            this.btnRemoveSerbianLetters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectSubtitle
            // 
            this.lblSelectSubtitle.AutoSize = true;
            this.lblSelectSubtitle.Location = new System.Drawing.Point(28, 34);
            this.lblSelectSubtitle.Name = "lblSelectSubtitle";
            this.lblSelectSubtitle.Size = new System.Drawing.Size(73, 13);
            this.lblSelectSubtitle.TabIndex = 0;
            this.lblSelectSubtitle.Text = "Select subtitle";
            // 
            // txbSelectSubtitle
            // 
            this.txbSelectSubtitle.Location = new System.Drawing.Point(107, 31);
            this.txbSelectSubtitle.Name = "txbSelectSubtitle";
            this.txbSelectSubtitle.Size = new System.Drawing.Size(326, 20);
            this.txbSelectSubtitle.TabIndex = 1;
            // 
            // btnSelectSubtitle
            // 
            this.btnSelectSubtitle.Location = new System.Drawing.Point(439, 29);
            this.btnSelectSubtitle.Name = "btnSelectSubtitle";
            this.btnSelectSubtitle.Size = new System.Drawing.Size(35, 23);
            this.btnSelectSubtitle.TabIndex = 2;
            this.btnSelectSubtitle.Text = "...";
            this.btnSelectSubtitle.UseVisualStyleBackColor = true;
            this.btnSelectSubtitle.Click += new System.EventHandler(this.btnSelectSubtitle_Click);
            // 
            // btnRemoveSerbianLetters
            // 
            this.btnRemoveSerbianLetters.Location = new System.Drawing.Point(339, 77);
            this.btnRemoveSerbianLetters.Name = "btnRemoveSerbianLetters";
            this.btnRemoveSerbianLetters.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveSerbianLetters.TabIndex = 3;
            this.btnRemoveSerbianLetters.Text = "Remove Serbian letters";
            this.btnRemoveSerbianLetters.UseVisualStyleBackColor = true;
            this.btnRemoveSerbianLetters.Click += new System.EventHandler(this.btnRemoveSerbianLetters_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 117);
            this.Controls.Add(this.btnRemoveSerbianLetters);
            this.Controls.Add(this.btnSelectSubtitle);
            this.Controls.Add(this.txbSelectSubtitle);
            this.Controls.Add(this.lblSelectSubtitle);
            this.Name = "frmMain";
            this.Text = "Fix subtitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSubtitle;
        private System.Windows.Forms.TextBox txbSelectSubtitle;
        private System.Windows.Forms.Button btnSelectSubtitle;
        private System.Windows.Forms.Button btnRemoveSerbianLetters;
    }
}

