
namespace PartaMod
{
    partial class ModMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainMenu = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.ModTypePsychOption = new System.Windows.Forms.RadioButton();
            this.MineCraftRSP = new System.Windows.Forms.RadioButton();
            this.BuildModButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.maskedTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.BuildModButton);
            this.splitContainer1.Panel2.Controls.Add(this.MineCraftRSP);
            this.splitContainer1.Panel2.Controls.Add(this.ModTypePsychOption);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(828, 360);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainMenu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.webBrowser1);
            this.MainMenu.Location = new System.Drawing.Point(4, 22);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenu.Size = new System.Drawing.Size(538, 334);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "News";
            this.MainMenu.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(532, 328);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://bloodmoondsfanclub.blogspot.com/", System.UriKind.Absolute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mod Type:";
            // 
            // ModTypePsychOption
            // 
            this.ModTypePsychOption.AutoSize = true;
            this.ModTypePsychOption.Checked = true;
            this.ModTypePsychOption.Location = new System.Drawing.Point(18, 108);
            this.ModTypePsychOption.Name = "ModTypePsychOption";
            this.ModTypePsychOption.Size = new System.Drawing.Size(135, 17);
            this.ModTypePsychOption.TabIndex = 1;
            this.ModTypePsychOption.TabStop = true;
            this.ModTypePsychOption.Text = "FNF Psych engine mod";
            this.ModTypePsychOption.UseVisualStyleBackColor = true;
            // 
            // MineCraftRSP
            // 
            this.MineCraftRSP.AutoSize = true;
            this.MineCraftRSP.Location = new System.Drawing.Point(18, 131);
            this.MineCraftRSP.Name = "MineCraftRSP";
            this.MineCraftRSP.Size = new System.Drawing.Size(152, 17);
            this.MineCraftRSP.TabIndex = 2;
            this.MineCraftRSP.Text = "Minecraft Rescource Pack";
            this.MineCraftRSP.UseVisualStyleBackColor = true;
            // 
            // BuildModButton
            // 
            this.BuildModButton.Location = new System.Drawing.Point(185, 324);
            this.BuildModButton.Name = "BuildModButton";
            this.BuildModButton.Size = new System.Drawing.Size(81, 24);
            this.BuildModButton.TabIndex = 3;
            this.BuildModButton.Text = "Start";
            this.BuildModButton.UseVisualStyleBackColor = true;
            this.BuildModButton.Click += new System.EventHandler(this.BuildModButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mod Name:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 35);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(183, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // ModMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(828, 360);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModMenu";
            this.Text = "PartaMod V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainMenu;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RadioButton MineCraftRSP;
        private System.Windows.Forms.RadioButton ModTypePsychOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuildModButton;
    }
}

