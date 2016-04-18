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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.locationNameBox = new System.Windows.Forms.TextBox();
            this.locationDescriptionBox = new System.Windows.Forms.TextBox();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationDisplayBox = new System.Windows.Forms.ListBox();
            this.refreshLocationDisplay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.locationKeyBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
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
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.breakLocationsToolStripMenuItem.Click += new System.EventHandler(this.breakLocationsToolStripMenuItem_Click);
            // 
            // locationNameBox
            // 
            this.locationNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.locationNameBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.locationNameBox.Location = new System.Drawing.Point(12, 80);
            this.locationNameBox.Name = "locationNameBox";
            this.locationNameBox.Size = new System.Drawing.Size(119, 20);
            this.locationNameBox.TabIndex = 1;
            this.locationNameBox.UseWaitCursor = true;
            this.locationNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // locationDescriptionBox
            // 
            this.locationDescriptionBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.locationDescriptionBox.Location = new System.Drawing.Point(12, 119);
            this.locationDescriptionBox.Name = "locationDescriptionBox";
            this.locationDescriptionBox.Size = new System.Drawing.Size(197, 20);
            this.locationDescriptionBox.TabIndex = 2;
            this.locationDescriptionBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addLocationButton
            // 
            this.addLocationButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addLocationButton.Location = new System.Drawing.Point(12, 145);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(84, 23);
            this.addLocationButton.TabIndex = 3;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // locationDisplayBox
            // 
            this.locationDisplayBox.FormattingEnabled = true;
            this.locationDisplayBox.Location = new System.Drawing.Point(396, 27);
            this.locationDisplayBox.Name = "locationDisplayBox";
            this.locationDisplayBox.Size = new System.Drawing.Size(171, 342);
            this.locationDisplayBox.TabIndex = 5;
            this.locationDisplayBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // refreshLocationDisplay
            // 
            this.refreshLocationDisplay.Location = new System.Drawing.Point(315, 341);
            this.refreshLocationDisplay.Name = "refreshLocationDisplay";
            this.refreshLocationDisplay.Size = new System.Drawing.Size(75, 23);
            this.refreshLocationDisplay.TabIndex = 6;
            this.refreshLocationDisplay.Text = "Refresh";
            this.refreshLocationDisplay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // locationKeyBox
            // 
            this.locationKeyBox.Location = new System.Drawing.Point(13, 41);
            this.locationKeyBox.Name = "locationKeyBox";
            this.locationKeyBox.Size = new System.Drawing.Size(100, 20);
            this.locationKeyBox.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 376);
            this.Controls.Add(this.locationKeyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addLocationButton);
            this.Controls.Add(this.locationNameBox);
            this.Controls.Add(this.locationDescriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox locationNameBox;
        private System.Windows.Forms.TextBox locationDescriptionBox;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox locationDisplayBox;
        private System.Windows.Forms.Button refreshLocationDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationKeyBox;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakLocationsToolStripMenuItem;
    }
}

