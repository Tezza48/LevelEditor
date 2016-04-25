namespace LevelEditor
{
    partial class MainWindow
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
            this.locationDisplayBox = new System.Windows.Forms.ListBox();
            this.refreshLocationDisplay = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxLocName = new System.Windows.Forms.TextBox();
            this.txtbxLocDescription = new System.Windows.Forms.TextBox();
            this.btnSaveLoc = new System.Windows.Forms.Button();
            this.btnNewLoc = new System.Windows.Forms.Button();
            this.btnRemoveLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationDisplayBox
            // 
            this.locationDisplayBox.FormattingEnabled = true;
            this.locationDisplayBox.Location = new System.Drawing.Point(12, 27);
            this.locationDisplayBox.Name = "locationDisplayBox";
            this.locationDisplayBox.Size = new System.Drawing.Size(156, 277);
            this.locationDisplayBox.TabIndex = 5;
            this.locationDisplayBox.SelectedIndexChanged += new System.EventHandler(this.locationDisplayBox_SelectedIndexChanged);
            // 
            // refreshLocationDisplay
            // 
            this.refreshLocationDisplay.Location = new System.Drawing.Point(53, 272);
            this.refreshLocationDisplay.Name = "refreshLocationDisplay";
            this.refreshLocationDisplay.Size = new System.Drawing.Size(75, 23);
            this.refreshLocationDisplay.TabIndex = 6;
            this.refreshLocationDisplay.Text = "Refresh";
            this.refreshLocationDisplay.UseVisualStyleBackColor = true;
            this.refreshLocationDisplay.Click += new System.EventHandler(this.refreshLocationDisplay_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakLocationsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // breakLocationsToolStripMenuItem
            // 
            this.breakLocationsToolStripMenuItem.Name = "breakLocationsToolStripMenuItem";
            this.breakLocationsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.breakLocationsToolStripMenuItem.Text = "Break Locations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locNameLabel
            // 
            this.locNameLabel.AutoSize = true;
            this.locNameLabel.Location = new System.Drawing.Point(174, 27);
            this.locNameLabel.Name = "locNameLabel";
            this.locNameLabel.Size = new System.Drawing.Size(35, 13);
            this.locNameLabel.TabIndex = 9;
            this.locNameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // txtbxLocName
            // 
            this.txtbxLocName.Location = new System.Drawing.Point(177, 44);
            this.txtbxLocName.Name = "txtbxLocName";
            this.txtbxLocName.Size = new System.Drawing.Size(287, 20);
            this.txtbxLocName.TabIndex = 11;
            // 
            // txtbxLocDescription
            // 
            this.txtbxLocDescription.Location = new System.Drawing.Point(177, 84);
            this.txtbxLocDescription.Multiline = true;
            this.txtbxLocDescription.Name = "txtbxLocDescription";
            this.txtbxLocDescription.Size = new System.Drawing.Size(287, 84);
            this.txtbxLocDescription.TabIndex = 12;
            // 
            // btnSaveLoc
            // 
            this.btnSaveLoc.Location = new System.Drawing.Point(177, 310);
            this.btnSaveLoc.Name = "btnSaveLoc";
            this.btnSaveLoc.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLoc.TabIndex = 13;
            this.btnSaveLoc.Text = "Set Location";
            this.btnSaveLoc.UseVisualStyleBackColor = true;
            this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
            // 
            // btnNewLoc
            // 
            this.btnNewLoc.Location = new System.Drawing.Point(12, 310);
            this.btnNewLoc.Name = "btnNewLoc";
            this.btnNewLoc.Size = new System.Drawing.Size(75, 23);
            this.btnNewLoc.TabIndex = 14;
            this.btnNewLoc.Text = "Add";
            this.btnNewLoc.UseVisualStyleBackColor = true;
            this.btnNewLoc.Click += new System.EventHandler(this.btnNewLoc_Click);
            // 
            // btnRemoveLoc
            // 
            this.btnRemoveLoc.Location = new System.Drawing.Point(93, 310);
            this.btnRemoveLoc.Name = "btnRemoveLoc";
            this.btnRemoveLoc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLoc.TabIndex = 15;
            this.btnRemoveLoc.Text = "Remove";
            this.btnRemoveLoc.UseVisualStyleBackColor = true;
            this.btnRemoveLoc.Click += new System.EventHandler(this.btnRemoveLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exits";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveLoc);
            this.Controls.Add(this.btnNewLoc);
            this.Controls.Add(this.btnSaveLoc);
            this.Controls.Add(this.txtbxLocDescription);
            this.Controls.Add(this.txtbxLocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locNameLabel);
            this.Controls.Add(this.refreshLocationDisplay);
            this.Controls.Add(this.locationDisplayBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Level Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox locationDisplayBox;
        private System.Windows.Forms.Button refreshLocationDisplay;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakLocationsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label locNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxLocName;
        private System.Windows.Forms.TextBox txtbxLocDescription;
        private System.Windows.Forms.Button btnSaveLoc;
        private System.Windows.Forms.Button btnNewLoc;
        private System.Windows.Forms.Button btnRemoveLoc;
        private System.Windows.Forms.Label label2;
    }
}

