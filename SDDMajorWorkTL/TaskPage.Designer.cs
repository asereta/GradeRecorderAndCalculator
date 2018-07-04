namespace SDDMajorWorkTL
{
    partial class Task_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.TaskPageBackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblWeightingTask = new System.Windows.Forms.Label();
            this.LblMarksTask = new System.Windows.Forms.Label();
            this.TaskPageNextBtn = new System.Windows.Forms.Button();
            this.pnltaskpage = new System.Windows.Forms.Panel();
            this.NumOfTasks = new System.Windows.Forms.ComboBox();
            this.pnltaskpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Page";
            // 
            // TaskPageBackBtn
            // 
            this.TaskPageBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TaskPageBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskPageBackBtn.BackgroundImage")));
            this.TaskPageBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TaskPageBackBtn.FlatAppearance.BorderSize = 0;
            this.TaskPageBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskPageBackBtn.Location = new System.Drawing.Point(35, 28);
            this.TaskPageBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TaskPageBackBtn.Name = "TaskPageBackBtn";
            this.TaskPageBackBtn.Size = new System.Drawing.Size(89, 85);
            this.TaskPageBackBtn.TabIndex = 3;
            this.TaskPageBackBtn.UseVisualStyleBackColor = false;
            this.TaskPageBackBtn.Click += new System.EventHandler(this.TaskPageBackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many tasks do you do for all your subjects? [2-6]";
            // 
            // LblWeightingTask
            // 
            this.LblWeightingTask.AutoSize = true;
            this.LblWeightingTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeightingTask.Location = new System.Drawing.Point(220, 234);
            this.LblWeightingTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWeightingTask.Name = "LblWeightingTask";
            this.LblWeightingTask.Size = new System.Drawing.Size(588, 25);
            this.LblWeightingTask.TabIndex = 7;
            this.LblWeightingTask.Text = "Please list the weightings of your tasks in order (from top to bottom)";
            this.LblWeightingTask.Visible = false;
            // 
            // LblMarksTask
            // 
            this.LblMarksTask.AutoSize = true;
            this.LblMarksTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarksTask.Location = new System.Drawing.Point(220, 717);
            this.LblMarksTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarksTask.Name = "LblMarksTask";
            this.LblMarksTask.Size = new System.Drawing.Size(549, 25);
            this.LblMarksTask.TabIndex = 8;
            this.LblMarksTask.Text = "Please list the marks of your tasks in order (from top to bottom)";
            this.LblMarksTask.Visible = false;
            // 
            // TaskPageNextBtn
            // 
            this.TaskPageNextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskPageNextBtn.BackgroundImage")));
            this.TaskPageNextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TaskPageNextBtn.FlatAppearance.BorderSize = 0;
            this.TaskPageNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskPageNextBtn.Location = new System.Drawing.Point(911, 1359);
            this.TaskPageNextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TaskPageNextBtn.Name = "TaskPageNextBtn";
            this.TaskPageNextBtn.Size = new System.Drawing.Size(95, 87);
            this.TaskPageNextBtn.TabIndex = 92;
            this.TaskPageNextBtn.UseVisualStyleBackColor = true;
            this.TaskPageNextBtn.Click += new System.EventHandler(this.TaskPageNextBtn_Click);
            // 
            // pnltaskpage
            // 
            this.pnltaskpage.Controls.Add(this.TaskPageNextBtn);
            this.pnltaskpage.Controls.Add(this.LblMarksTask);
            this.pnltaskpage.Location = new System.Drawing.Point(0, 0);
            this.pnltaskpage.Margin = new System.Windows.Forms.Padding(4);
            this.pnltaskpage.Name = "pnltaskpage";
            this.pnltaskpage.Size = new System.Drawing.Size(1064, 1481);
            this.pnltaskpage.TabIndex = 51;
            // 
            // NumOfTasks
            // 
            this.NumOfTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfTasks.FormattingEnabled = true;
            this.NumOfTasks.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumOfTasks.Location = new System.Drawing.Point(629, 169);
            this.NumOfTasks.Margin = new System.Windows.Forms.Padding(4);
            this.NumOfTasks.Name = "NumOfTasks";
            this.NumOfTasks.Size = new System.Drawing.Size(339, 28);
            this.NumOfTasks.TabIndex = 50;
            this.NumOfTasks.SelectedIndexChanged += new System.EventHandler(this.NumOfTasks_SelectedIndexChanged);
            // 
            // Task_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 902);
            this.Controls.Add(this.NumOfTasks);
            this.Controls.Add(this.LblWeightingTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskPageBackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnltaskpage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Task_Page";
            this.Text = "Grade Recorder and Calculator";
            this.pnltaskpage.ResumeLayout(false);
            this.pnltaskpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TaskPageBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblWeightingTask;
        private System.Windows.Forms.Label LblMarksTask;
        private System.Windows.Forms.Button TaskPageNextBtn;
        private System.Windows.Forms.Panel pnltaskpage;
        private System.Windows.Forms.ComboBox NumOfTasks;
    }
}