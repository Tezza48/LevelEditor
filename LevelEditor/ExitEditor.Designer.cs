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
            this.combobxExits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combobxExitLeads = new System.Windows.Forms.ComboBox();
            this.btnSetExit = new System.Windows.Forms.Button();
            this.btnClearExit = new System.Windows.Forms.Button();
            this.groupbxEditor.SuspendLayout();
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
            // combobxExits
            // 
            this.combobxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxExits.FormattingEnabled = true;
            this.combobxExits.Location = new System.Drawing.Point(6, 36);
            this.combobxExits.Name = "combobxExits";
            this.combobxExits.Size = new System.Drawing.Size(121, 21);
            this.combobxExits.TabIndex = 0;
            this.combobxExits.SelectedIndexChanged += new System.EventHandler(this.combobxExits_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leads To";
            // 
            // combobxExitLeads
            // 
            this.combobxExitLeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxExitLeads.FormattingEnabled = true;
            this.combobxExitLeads.Location = new System.Drawing.Point(7, 81);
            this.combobxExitLeads.Name = "combobxExitLeads";
            this.combobxExitLeads.Size = new System.Drawing.Size(120, 21);
            this.combobxExitLeads.TabIndex = 3;
            // 
            // btnSetExit
            // 
            this.btnSetExit.Location = new System.Drawing.Point(6, 178);
            this.btnSetExit.Name = "btnSetExit";
            this.btnSetExit.Size = new System.Drawing.Size(75, 23);
            this.btnSetExit.TabIndex = 4;
            this.btnSetExit.Text = "Set";
            this.btnSetExit.UseVisualStyleBackColor = true;
            this.btnSetExit.Click += new System.EventHandler(this.btnSetExit_Click);
            // 
            // btnClearExit
            // 
            this.btnClearExit.Location = new System.Drawing.Point(6, 207);
            this.btnClearExit.Name = "btnClearExit";
            this.btnClearExit.Size = new System.Drawing.Size(75, 23);
            this.btnClearExit.TabIndex = 5;
            this.btnClearExit.Text = "Clear";
            this.btnClearExit.UseVisualStyleBackColor = true;
            this.btnClearExit.Click += new System.EventHandler(this.btnClearExit_Click);
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
    }
}