
namespace PartaMod
{
    partial class PsychBuilder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PsychBuilder));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Scripts");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ProjectName", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFnFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FnF_Script_Editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Project_Explorer = new System.Windows.Forms.TreeView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FnF_Script_Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventToolStripMenuItem,
            this.emptyScriptToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.stageToolStripMenuItem,
            this.noteTypeToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFnFToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::PartaMod.Properties.Resources._1;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PartaMod.Properties.Resources._308;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::PartaMod.Properties.Resources._5;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Image = global::PartaMod.Properties.Resources._14;
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.eventToolStripMenuItem.Text = "Event";
            this.eventToolStripMenuItem.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // emptyScriptToolStripMenuItem
            // 
            this.emptyScriptToolStripMenuItem.Image = global::PartaMod.Properties.Resources._151;
            this.emptyScriptToolStripMenuItem.Name = "emptyScriptToolStripMenuItem";
            this.emptyScriptToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.emptyScriptToolStripMenuItem.Text = "EmptyScript";
            this.emptyScriptToolStripMenuItem.Click += new System.EventHandler(this.emptyScriptToolStripMenuItem_Click);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bFToolStripMenuItem,
            this.dadToolStripMenuItem,
            this.gfToolStripMenuItem});
            this.characterToolStripMenuItem.Image = global::PartaMod.Properties.Resources._269;
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.characterToolStripMenuItem.Text = "Character";
            this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
            // 
            // bFToolStripMenuItem
            // 
            this.bFToolStripMenuItem.Name = "bFToolStripMenuItem";
            this.bFToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.bFToolStripMenuItem.Text = "bf";
            this.bFToolStripMenuItem.Click += new System.EventHandler(this.bFToolStripMenuItem_Click);
            // 
            // dadToolStripMenuItem
            // 
            this.dadToolStripMenuItem.Name = "dadToolStripMenuItem";
            this.dadToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.dadToolStripMenuItem.Text = "dad";
            // 
            // gfToolStripMenuItem
            // 
            this.gfToolStripMenuItem.Name = "gfToolStripMenuItem";
            this.gfToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.gfToolStripMenuItem.Text = "gf";
            // 
            // stageToolStripMenuItem
            // 
            this.stageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyStageToolStripMenuItem,
            this.stageWizardToolStripMenuItem});
            this.stageToolStripMenuItem.Image = global::PartaMod.Properties.Resources._226;
            this.stageToolStripMenuItem.Name = "stageToolStripMenuItem";
            this.stageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stageToolStripMenuItem.Text = "Stage";
            // 
            // emptyStageToolStripMenuItem
            // 
            this.emptyStageToolStripMenuItem.Image = global::PartaMod.Properties.Resources._3;
            this.emptyStageToolStripMenuItem.Name = "emptyStageToolStripMenuItem";
            this.emptyStageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.emptyStageToolStripMenuItem.Text = "EmptyStage";
            // 
            // stageWizardToolStripMenuItem
            // 
            this.stageWizardToolStripMenuItem.Image = global::PartaMod.Properties.Resources._44;
            this.stageWizardToolStripMenuItem.Name = "stageWizardToolStripMenuItem";
            this.stageWizardToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.stageWizardToolStripMenuItem.Text = "Stage Wizard";
            // 
            // noteTypeToolStripMenuItem
            // 
            this.noteTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem,
            this.noteWizardToolStripMenuItem});
            this.noteTypeToolStripMenuItem.Image = global::PartaMod.Properties.Resources._225;
            this.noteTypeToolStripMenuItem.Name = "noteTypeToolStripMenuItem";
            this.noteTypeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.noteTypeToolStripMenuItem.Text = "Note Type";
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Image = global::PartaMod.Properties.Resources._11;
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // noteWizardToolStripMenuItem
            // 
            this.noteWizardToolStripMenuItem.Image = global::PartaMod.Properties.Resources._441;
            this.noteWizardToolStripMenuItem.Name = "noteWizardToolStripMenuItem";
            this.noteWizardToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.noteWizardToolStripMenuItem.Text = "Note Wizard";
            // 
            // exportToFnFToolStripMenuItem
            // 
            this.exportToFnFToolStripMenuItem.Image = global::PartaMod.Properties.Resources._146;
            this.exportToFnFToolStripMenuItem.Name = "exportToFnFToolStripMenuItem";
            this.exportToFnFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToFnFToolStripMenuItem.Text = "Export To FnF";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FnF_Script_Editor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Project_Explorer);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 598;
            this.splitContainer1.TabIndex = 1;
            // 
            // FnF_Script_Editor
            // 
            this.FnF_Script_Editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FnF_Script_Editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.FnF_Script_Editor.AutoScrollMinSize = new System.Drawing.Size(235, 14);
            this.FnF_Script_Editor.BackBrush = null;
            this.FnF_Script_Editor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FnF_Script_Editor.CharHeight = 14;
            this.FnF_Script_Editor.CharWidth = 8;
            this.FnF_Script_Editor.CommentPrefix = "--";
            this.FnF_Script_Editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnF_Script_Editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FnF_Script_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FnF_Script_Editor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.FnF_Script_Editor.IsReplaceMode = false;
            this.FnF_Script_Editor.Language = FastColoredTextBoxNS.Language.Lua;
            this.FnF_Script_Editor.LeftBracket = '(';
            this.FnF_Script_Editor.LeftBracket2 = '{';
            this.FnF_Script_Editor.Location = new System.Drawing.Point(0, 0);
            this.FnF_Script_Editor.Name = "FnF_Script_Editor";
            this.FnF_Script_Editor.Paddings = new System.Windows.Forms.Padding(0);
            this.FnF_Script_Editor.RightBracket = ')';
            this.FnF_Script_Editor.RightBracket2 = '}';
            this.FnF_Script_Editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FnF_Script_Editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FnF_Script_Editor.ServiceColors")));
            this.FnF_Script_Editor.Size = new System.Drawing.Size(598, 426);
            this.FnF_Script_Editor.TabIndex = 0;
            this.FnF_Script_Editor.Text = "-- Insert Your Script here";
            this.FnF_Script_Editor.Zoom = 100;
            // 
            // Project_Explorer
            // 
            this.Project_Explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Project_Explorer.Location = new System.Drawing.Point(0, 0);
            this.Project_Explorer.Name = "Project_Explorer";
            treeNode1.Name = "scripts";
            treeNode1.Text = "Scripts";
            treeNode2.Name = "Project_Root";
            treeNode2.Text = "ProjectName";
            this.Project_Explorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.Project_Explorer.Size = new System.Drawing.Size(198, 426);
            this.Project_Explorer.TabIndex = 0;
            this.Project_Explorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Project_Explorer_AfterSelect);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // PsychBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PsychBuilder";
            this.Text = "Psych Modder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FnF_Script_Editor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stageWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToFnFToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox FnF_Script_Editor;
        private System.Windows.Forms.TreeView Project_Explorer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}