namespace Jesture
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.folderButton = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.preferencesButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.stretchCheckBox = new System.Windows.Forms.CheckBox();
            this.flipCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.preferencesButton);
            this.flowLayoutPanel1.Controls.Add(this.folderButton);
            this.flowLayoutPanel1.Controls.Add(this.classButton);
            this.flowLayoutPanel1.Controls.Add(this.customButton);
            this.flowLayoutPanel1.Controls.Add(this.pauseButton);
            this.flowLayoutPanel1.Controls.Add(this.startButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 385);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(3, 32);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(84, 3);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(75, 23);
            this.classButton.TabIndex = 1;
            this.classButton.Text = "Class";
            this.classButton.UseVisualStyleBackColor = true;
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(84, 32);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(75, 23);
            this.customButton.TabIndex = 2;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(165, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(165, 3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // preferencesButton
            // 
            this.preferencesButton.Location = new System.Drawing.Point(3, 3);
            this.preferencesButton.Name = "preferencesButton";
            this.preferencesButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesButton.TabIndex = 5;
            this.preferencesButton.Text = "Preferences";
            this.preferencesButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.stretchCheckBox);
            this.flowLayoutPanel2.Controls.Add(this.flipCheckBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 385);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 62);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // stretchCheckBox
            // 
            this.stretchCheckBox.AutoSize = true;
            this.stretchCheckBox.Location = new System.Drawing.Point(3, 3);
            this.stretchCheckBox.Name = "stretchCheckBox";
            this.stretchCheckBox.Size = new System.Drawing.Size(60, 17);
            this.stretchCheckBox.TabIndex = 0;
            this.stretchCheckBox.Text = "Stretch";
            this.stretchCheckBox.UseVisualStyleBackColor = true;
            // 
            // flipCheckBox
            // 
            this.flipCheckBox.AutoSize = true;
            this.flipCheckBox.Location = new System.Drawing.Point(3, 26);
            this.flipCheckBox.Name = "flipCheckBox";
            this.flipCheckBox.Size = new System.Drawing.Size(42, 17);
            this.flipCheckBox.TabIndex = 1;
            this.flipCheckBox.Text = "Flip";
            this.flipCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button preferencesButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox stretchCheckBox;
        private System.Windows.Forms.CheckBox flipCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

