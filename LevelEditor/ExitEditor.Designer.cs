namespace LevelEditor
{
    partial class ExitEditor
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
            this.lstbxLocations = new System.Windows.Forms.ListBox();
            this.groupbxEditor = new System.Windows.Forms.GroupBox();
            this.groupbxKey = new System.Windows.Forms.GroupBox();
            this.combobxKey = new System.Windows.Forms.ComboBox();
            this.combobxKeyLoc = new System.Windows.Forms.ComboBox();
            this.chbxIsLocked = new System.Windows.Forms.CheckBox();
            this.btnClearExit = new System.Windows.Forms.Button();
            this.btnSetExit = new System.Windows.Forms.Button();
            this.combobxExitLeads = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combobxExits = new System.Windows.Forms.ComboBox();
            this.groupbxEditor.SuspendLayout();
            this.groupbxKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxLocations
            // 
            this.lstbxLocations.FormattingEnabled = true;
            this.lstbxLocations.Location = new System.Drawing.Point(13, 13);
            this.lstbxLocations.Name = "lstbxLocations";
            this.lstbxLocations.Size = new System.Drawing.Size(120, 238);
            this.lstbxLocations.TabIndex = 0;
            this.lstbxLocations.SelectedIndexChanged += new System.EventHandler(this.lstbxLocations_SelectedIndexChanged);
            // 
            // groupbxEditor
            // 
            this.groupbxEditor.Controls.Add(this.groupbxKey);
            this.groupbxEditor.Controls.Add(this.chbxIsLocked);
            this.groupbxEditor.Controls.Add(this.btnClearExit);
            this.groupbxEditor.Controls.Add(this.btnSetExit);
            this.groupbxEditor.Controls.Add(this.combobxExitLeads);
            this.groupbxEditor.Controls.Add(this.label2);
            this.groupbxEditor.Controls.Add(this.label1);
            this.groupbxEditor.Controls.Add(this.combobxExits);
            this.groupbxEditor.Location = new System.Drawing.Point(140, 13);
            this.groupbxEditor.Name = "groupbxEditor";
            this.groupbxEditor.Size = new System.Drawing.Size(132, 236);
            this.groupbxEditor.TabIndex = 1;
            this.groupbxEditor.TabStop = false;
            this.groupbxEditor.Text = "Location";
            // 
            // groupbxKey
            // 
            this.groupbxKey.Controls.Add(this.combobxKey);
            this.groupbxKey.Controls.Add(this.combobxKeyLoc);
            this.groupbxKey.Location = new System.Drawing.Point(7, 126);
            this.groupbxKey.Name = "groupbxKey";
            this.groupbxKey.Size = new System.Drawing.Size(119, 75);
            this.groupbxKey.TabIndex = 7;
            this.groupbxKey.TabStop = false;
            this.groupbxKey.Text = "Key";
            this.groupbxKey.Visible = false;
            // 
            // combobxKey
            // 
            this.combobxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxKey.FormattingEnabled = true;
            this.combobxKey.Location = new System.Drawing.Point(7, 48);
            this.combobxKey.Name = "combobxKey";
            this.combobxKey.Size = new System.Drawing.Size(106, 21);
            this.combobxKey.TabIndex = 1;
            // 
            // combobxKeyLoc
            // 
            this.combobxKeyLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxKeyLoc.FormattingEnabled = true;
            this.combobxKeyLoc.Location = new System.Drawing.Point(7, 20);
            this.combobxKeyLoc.Name = "combobxKeyLoc";
            this.combobxKeyLoc.Size = new System.Drawing.Size(106, 21);
            this.combobxKeyLoc.TabIndex = 0;
            this.combobxKeyLoc.SelectedIndexChanged += new System.EventHandler(this.combobxKeyLoc_SelectedIndexChanged);
            // 
            // chbxIsLocked
            // 
            this.chbxIsLocked.AutoSize = true;
            this.chbxIsLocked.Location = new System.Drawing.Point(6, 103);
            this.chbxIsLocked.Name = "chbxIsLocked";
            this.chbxIsLocked.Size = new System.Drawing.Size(78, 17);
            this.chbxIsLocked.TabIndex = 6;
            this.chbxIsLocked.Text = "is Locked?";
            this.chbxIsLocked.UseVisualStyleBackColor = true;
            this.chbxIsLocked.CheckedChanged += new System.EventHandler(this.chbxIsLocked_CheckedChanged);
            // 
            // btnClearExit
            // 
            this.btnClearExit.Location = new System.Drawing.Point(72, 207);
            this.btnClearExit.Name = "btnClearExit";
            this.btnClearExit.Size = new System.Drawing.Size(54, 23);
            this.btnClearExit.TabIndex = 5;
            this.btnClearExit.Text = "Clear";
            this.btnClearExit.UseVisualStyleBackColor = true;
            this.btnClearExit.Click += new System.EventHandler(this.btnClearExit_Click);
            // 
            // btnSetExit
            // 
            this.btnSetExit.Location = new System.Drawing.Point(6, 207);
            this.btnSetExit.Name = "btnSetExit";
            this.btnSetExit.Size = new System.Drawing.Size(54, 23);
            this.btnSetExit.TabIndex = 4;
            this.btnSetExit.Text = "Set";
            this.btnSetExit.UseVisualStyleBackColor = true;
            this.btnSetExit.Click += new System.EventHandler(this.btnSetExit_Click);
            // 
            // combobxExitLeads
            // 
            this.combobxExitLeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxExitLeads.FormattingEnabled = true;
            this.combobxExitLeads.Location = new System.Drawing.Point(6, 76);
            this.combobxExitLeads.Name = "combobxExitLeads";
            this.combobxExitLeads.Size = new System.Drawing.Size(120, 21);
            this.combobxExitLeads.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leads To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direction";
            // 
            // combobxExits
            // 
            this.combobxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxExits.FormattingEnabled = true;
            this.combobxExits.Location = new System.Drawing.Point(5, 36);
            this.combobxExits.Name = "combobxExits";
            this.combobxExits.Size = new System.Drawing.Size(121, 21);
            this.combobxExits.TabIndex = 0;
            this.combobxExits.SelectedIndexChanged += new System.EventHandler(this.combobxExits_SelectedIndexChanged);
            // 
            // ExitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupbxEditor);
            this.Controls.Add(this.lstbxLocations);
            this.Name = "ExitEditor";
            this.Text = "ExitEditor";
            this.Load += new System.EventHandler(this.ExitEditor_Load);
            this.groupbxEditor.ResumeLayout(false);
            this.groupbxEditor.PerformLayout();
            this.groupbxKey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLocations;
        private System.Windows.Forms.GroupBox groupbxEditor;
        private System.Windows.Forms.ComboBox combobxExits;
        private System.Windows.Forms.Button btnClearExit;
        private System.Windows.Forms.Button btnSetExit;
        private System.Windows.Forms.ComboBox combobxExitLeads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbxKey;
        private System.Windows.Forms.ComboBox combobxKey;
        private System.Windows.Forms.ComboBox combobxKeyLoc;
        private System.Windows.Forms.CheckBox chbxIsLocked;
    }
}