namespace LevelEditor
{
    partial class LocationEditor
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
            this.lstbxLocation = new System.Windows.Forms.ListBox();
            this.addLoc = new System.Windows.Forms.Button();
            this.removeLoc = new System.Windows.Forms.Button();
            this.groupbxLocEdit = new System.Windows.Forms.GroupBox();
            this.btnSetLoc = new System.Windows.Forms.Button();
            this.txtbxLocDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxLocTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbxLocEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.Location = new System.Drawing.Point(12, 12);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(120, 212);
            this.lstbxLocation.TabIndex = 0;
            this.lstbxLocation.SelectedIndexChanged += new System.EventHandler(this.lstbxLocation_SelectedIndexChanged);
            // 
            // addLoc
            // 
            this.addLoc.Location = new System.Drawing.Point(12, 230);
            this.addLoc.Name = "addLoc";
            this.addLoc.Size = new System.Drawing.Size(57, 23);
            this.addLoc.TabIndex = 1;
            this.addLoc.Text = "Add";
            this.addLoc.UseVisualStyleBackColor = true;
            this.addLoc.Click += new System.EventHandler(this.addLoc_Click);
            // 
            // removeLoc
            // 
            this.removeLoc.Location = new System.Drawing.Point(75, 230);
            this.removeLoc.Name = "removeLoc";
            this.removeLoc.Size = new System.Drawing.Size(57, 23);
            this.removeLoc.TabIndex = 2;
            this.removeLoc.Text = "Remove";
            this.removeLoc.UseVisualStyleBackColor = true;
            this.removeLoc.Click += new System.EventHandler(this.removeLoc_Click);
            // 
            // groupbxLocEdit
            // 
            this.groupbxLocEdit.Controls.Add(this.btnSetLoc);
            this.groupbxLocEdit.Controls.Add(this.txtbxLocDescription);
            this.groupbxLocEdit.Controls.Add(this.label2);
            this.groupbxLocEdit.Controls.Add(this.txtbxLocTitle);
            this.groupbxLocEdit.Controls.Add(this.label1);
            this.groupbxLocEdit.Location = new System.Drawing.Point(139, 13);
            this.groupbxLocEdit.Name = "groupbxLocEdit";
            this.groupbxLocEdit.Size = new System.Drawing.Size(133, 236);
            this.groupbxLocEdit.TabIndex = 3;
            this.groupbxLocEdit.TabStop = false;
            this.groupbxLocEdit.Text = "Edit Area";
            // 
            // btnSetLoc
            // 
            this.btnSetLoc.Location = new System.Drawing.Point(6, 207);
            this.btnSetLoc.Name = "btnSetLoc";
            this.btnSetLoc.Size = new System.Drawing.Size(121, 23);
            this.btnSetLoc.TabIndex = 4;
            this.btnSetLoc.Text = "Save Changes";
            this.btnSetLoc.UseVisualStyleBackColor = true;
            this.btnSetLoc.Click += new System.EventHandler(this.btnSetLoc_Click);
            // 
            // txtbxLocDescription
            // 
            this.txtbxLocDescription.Location = new System.Drawing.Point(6, 71);
            this.txtbxLocDescription.Multiline = true;
            this.txtbxLocDescription.Name = "txtbxLocDescription";
            this.txtbxLocDescription.Size = new System.Drawing.Size(121, 130);
            this.txtbxLocDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtbxLocTitle
            // 
            this.txtbxLocTitle.Location = new System.Drawing.Point(6, 32);
            this.txtbxLocTitle.Name = "txtbxLocTitle";
            this.txtbxLocTitle.Size = new System.Drawing.Size(121, 20);
            this.txtbxLocTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // LocationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupbxLocEdit);
            this.Controls.Add(this.removeLoc);
            this.Controls.Add(this.addLoc);
            this.Controls.Add(this.lstbxLocation);
            this.Name = "LocationEditor";
            this.Text = "Location Editor";
            this.Load += new System.EventHandler(this.LocationEditor_Load);
            this.groupbxLocEdit.ResumeLayout(false);
            this.groupbxLocEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLocation;
        private System.Windows.Forms.Button addLoc;
        private System.Windows.Forms.Button removeLoc;
        private System.Windows.Forms.GroupBox groupbxLocEdit;
        private System.Windows.Forms.Button btnSetLoc;
        private System.Windows.Forms.TextBox txtbxLocDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxLocTitle;
        private System.Windows.Forms.Label label1;
    }
}