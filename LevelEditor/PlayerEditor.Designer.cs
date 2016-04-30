namespace LevelEditor
{
    partial class PlayerEditor
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
            this.combxItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.addKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxItemDescription = new System.Windows.Forms.TextBox();
            this.btnSetLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combxItems
            // 
            this.combxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxItems.FormattingEnabled = true;
            this.combxItems.Location = new System.Drawing.Point(12, 25);
            this.combxItems.Name = "combxItems";
            this.combxItems.Size = new System.Drawing.Size(120, 21);
            this.combxItems.TabIndex = 13;
            this.combxItems.SelectedIndexChanged += new System.EventHandler(this.combxItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Items";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(12, 52);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(57, 23);
            this.addItem.TabIndex = 11;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(12, 81);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(120, 23);
            this.removeItem.TabIndex = 4;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // addKey
            // 
            this.addKey.Location = new System.Drawing.Point(75, 52);
            this.addKey.Name = "addKey";
            this.addKey.Size = new System.Drawing.Size(57, 23);
            this.addKey.TabIndex = 12;
            this.addKey.Text = "Add Key";
            this.addKey.UseVisualStyleBackColor = true;
            this.addKey.Click += new System.EventHandler(this.addKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            // 
            // txtbxItemName
            // 
            this.txtbxItemName.Location = new System.Drawing.Point(12, 123);
            this.txtbxItemName.Name = "txtbxItemName";
            this.txtbxItemName.Size = new System.Drawing.Size(120, 20);
            this.txtbxItemName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // txtbxItemDescription
            // 
            this.txtbxItemDescription.Location = new System.Drawing.Point(12, 162);
            this.txtbxItemDescription.Multiline = true;
            this.txtbxItemDescription.Name = "txtbxItemDescription";
            this.txtbxItemDescription.Size = new System.Drawing.Size(120, 58);
            this.txtbxItemDescription.TabIndex = 17;
            // 
            // btnSetLoc
            // 
            this.btnSetLoc.Location = new System.Drawing.Point(12, 226);
            this.btnSetLoc.Name = "btnSetLoc";
            this.btnSetLoc.Size = new System.Drawing.Size(120, 23);
            this.btnSetLoc.TabIndex = 18;
            this.btnSetLoc.Text = "Save Changes";
            this.btnSetLoc.UseVisualStyleBackColor = true;
            this.btnSetLoc.Click += new System.EventHandler(this.btnSetLoc_Click);
            // 
            // PlayerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 261);
            this.Controls.Add(this.btnSetLoc);
            this.Controls.Add(this.combxItems);
            this.Controls.Add(this.txtbxItemDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.txtbxItemName);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addKey);
            this.Controls.Add(this.label2);
            this.Name = "PlayerEditor";
            this.Text = "PlayerEditor";
            this.Load += new System.EventHandler(this.PlayerEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button addKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxItemDescription;
        private System.Windows.Forms.Button btnSetLoc;
    }
}