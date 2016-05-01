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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combobxExits = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxLocations
            // 
            this.lstbxLocations.FormattingEnabled = true;
            this.lstbxLocations.Location = new System.Drawing.Point(13, 13);
            this.lstbxLocations.Name = "lstbxLocations";
            this.lstbxLocations.Size = new System.Drawing.Size(120, 238);
            this.lstbxLocations.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combobxExits);
            this.groupBox1.Location = new System.Drawing.Point(140, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // combobxExits
            // 
            this.combobxExits.FormattingEnabled = true;
            this.combobxExits.Location = new System.Drawing.Point(7, 20);
            this.combobxExits.Name = "combobxExits";
            this.combobxExits.Size = new System.Drawing.Size(121, 21);
            this.combobxExits.TabIndex = 0;
            // 
            // ExitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstbxLocations);
            this.Name = "ExitEditor";
            this.Text = "ExitEditor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLocations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combobxExits;
    }
}