namespace SDDMajorWorkTL
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.helpinfo = new System.Windows.Forms.Label();
            this.pnlhelp = new System.Windows.Forms.Panel();
            this.pnlhelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Help";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenu.BackgroundImage")));
            this.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Location = new System.Drawing.Point(31, 30);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(89, 85);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // helpinfo
            // 
            this.helpinfo.BackColor = System.Drawing.Color.LightGreen;
            this.helpinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpinfo.Location = new System.Drawing.Point(57, 155);
            this.helpinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helpinfo.Name = "helpinfo";
            this.helpinfo.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.helpinfo.Size = new System.Drawing.Size(965, 1161);
            this.helpinfo.TabIndex = 3;
            this.helpinfo.Text = resources.GetString("helpinfo.Text");
            this.helpinfo.Click += new System.EventHandler(this.helpinfo_Click);
            // 
            // pnlhelp
            // 
            this.pnlhelp.Controls.Add(this.helpinfo);
            this.pnlhelp.Location = new System.Drawing.Point(0, 0);
            this.pnlhelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlhelp.Name = "pnlhelp";
            this.pnlhelp.Size = new System.Drawing.Size(1067, 1344);
            this.pnlhelp.TabIndex = 4;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 896);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlhelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Grade Recorder and Calculator";
            this.pnlhelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label helpinfo;
        private System.Windows.Forms.Panel pnlhelp;
    }
}