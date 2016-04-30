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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetLoc = new System.Windows.Forms.Button();
            this.txtbxLocDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxLocTitle = new System.Windows.Forms.TextBox();
            this.btnSetItem = new System.Windows.Forms.Button();
            this.txtbxItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addKey = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combxItems = new System.Windows.Forms.ComboBox();
            this.groupbxLocEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.Location = new System.Drawing.Point(12, 12);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(120, 186);
            this.lstbxLocation.TabIndex = 0;
            this.lstbxLocation.SelectedIndexChanged += new System.EventHandler(this.lstbxLocation_SelectedIndexChanged);
            // 
            // addLoc
            // 
            this.addLoc.Location = new System.Drawing.Point(12, 201);
            this.addLoc.Name = "addLoc";
            this.addLoc.Size = new System.Drawing.Size(120, 23);
            this.addLoc.TabIndex = 1;
            this.addLoc.Text = "Add";
            this.addLoc.UseVisualStyleBackColor = true;
            this.addLoc.Click += new System.EventHandler(this.addLoc_Click);
            // 
            // removeLoc
            // 
            this.removeLoc.Location = new System.Drawing.Point(12, 230);
            this.removeLoc.Name = "removeLoc";
            this.removeLoc.Size = new System.Drawing.Size(120, 23);
            this.removeLoc.TabIndex = 2;
            this.removeLoc.Text = "Remove";
            this.removeLoc.UseVisualStyleBackColor = true;
            this.removeLoc.Click += new System.EventHandler(this.removeLoc_Click);
            // 
            // groupbxLocEdit
            // 
            this.groupbxLocEdit.Controls.Add(this.btnSetItem);
            this.groupbxLocEdit.Controls.Add(this.txtbxItemDescription);
            this.groupbxLocEdit.Controls.Add(this.label4);
            this.groupbxLocEdit.Controls.Add(this.txtbxItemName);
            this.groupbxLocEdit.Controls.Add(this.label1);
            this.groupbxLocEdit.Controls.Add(this.label5);
            this.groupbxLocEdit.Controls.Add(this.combxItems);
            this.groupbxLocEdit.Controls.Add(this.addKey);
            this.groupbxLocEdit.Controls.Add(this.removeItem);
            this.groupbxLocEdit.Controls.Add(this.addItem);
            this.groupbxLocEdit.Controls.Add(this.label3);
            this.groupbxLocEdit.Controls.Add(this.btnSetLoc);
            this.groupbxLocEdit.Controls.Add(this.txtbxLocDescription);
            this.groupbxLocEdit.Controls.Add(this.label2);
            this.groupbxLocEdit.Controls.Add(this.txtbxLocTitle);
            this.groupbxLocEdit.Location = new System.Drawing.Point(139, 13);
            this.groupbxLocEdit.Name = "groupbxLocEdit";
            this.groupbxLocEdit.Size = new System.Drawing.Size(262, 240);
            this.groupbxLocEdit.TabIndex = 3;
            this.groupbxLocEdit.TabStop = false;
            this.groupbxLocEdit.Text = "Edit Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // btnSetLoc
            // 
            this.btnSetLoc.Location = new System.Drawing.Point(6, 211);
            this.btnSetLoc.Name = "btnSetLoc";
            this.btnSetLoc.Size = new System.Drawing.Size(120, 23);
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
            this.txtbxLocDescription.Size = new System.Drawing.Size(120, 134);
            this.txtbxLocDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtbxLocTitle
            // 
            this.txtbxLocTitle.Location = new System.Drawing.Point(6, 32);
            this.txtbxLocTitle.Name = "txtbxLocTitle";
            this.txtbxLocTitle.Size = new System.Drawing.Size(120, 20);
            this.txtbxLocTitle.TabIndex = 1;
            // 
            // btnSetItem
            // 
            this.btnSetItem.Location = new System.Drawing.Point(132, 211);
            this.btnSetItem.Name = "btnSetItem";
            this.btnSetItem.Size = new System.Drawing.Size(120, 23);
            this.btnSetItem.TabIndex = 18;
            this.btnSetItem.Text = "Save Changes";
            this.btnSetItem.UseVisualStyleBackColor = true;
            this.btnSetItem.Click += new System.EventHandler(this.btnSetItem_Click);
            // 
            // txtbxItemDescription
            // 
            this.txtbxItemDescription.Location = new System.Drawing.Point(132, 168);
            this.txtbxItemDescription.Multiline = true;
            this.txtbxItemDescription.Name = "txtbxItemDescription";
            this.txtbxItemDescription.Size = new System.Drawing.Size(119, 37);
            this.txtbxItemDescription.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description";
            // 
            // txtbxItemName
            // 
            this.txtbxItemName.Location = new System.Drawing.Point(132, 129);
            this.txtbxItemName.Name = "txtbxItemName";
            this.txtbxItemName.Size = new System.Drawing.Size(120, 20);
            this.txtbxItemName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Title";
            // 
            // addKey
            // 
            this.addKey.Location = new System.Drawing.Point(198, 58);
            this.addKey.Name = "addKey";
            this.addKey.Size = new System.Drawing.Size(57, 23);
            this.addKey.TabIndex = 12;
            this.addKey.Text = "Add Key";
            this.addKey.UseVisualStyleBackColor = true;
            this.addKey.Click += new System.EventHandler(this.addKey_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(132, 87);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(123, 23);
            this.removeItem.TabIndex = 4;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(132, 58);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(57, 23);
            this.addItem.TabIndex = 11;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Items";
            // 
            // combxItems
            // 
            this.combxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxItems.FormattingEnabled = true;
            this.combxItems.Location = new System.Drawing.Point(132, 31);
            this.combxItems.Name = "combxItems";
            this.combxItems.Size = new System.Drawing.Size(123, 21);
            this.combxItems.TabIndex = 13;
            this.combxItems.SelectedIndexChanged += new System.EventHandler(this.combxItems_SelectedIndexChanged);
            // 
            // LocationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
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
        private System.Windows.Forms.Button btnSetItem;
        private System.Windows.Forms.TextBox txtbxItemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combxItems;
        private System.Windows.Forms.Button addKey;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label3;
    }
}