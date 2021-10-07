namespace FischerP3
{
    partial class Form1
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
            this.lblNumItems = new System.Windows.Forms.Label();
            this.tbNumItems = new System.Windows.Forms.TextBox();
            this.gbxItemType = new System.Windows.Forms.GroupBox();
            this.tbUserItem = new System.Windows.Forms.TextBox();
            this.lbUserItem = new System.Windows.Forms.Label();
            this.lblTxtToPrint = new System.Windows.Forms.Label();
            this.tbTextToPrint = new System.Windows.Forms.TextBox();
            this.ckbxLogo = new System.Windows.Forms.CheckBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.tbNumColors = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbOrderSummary = new System.Windows.Forms.TextBox();
            this.gbxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Location = new System.Drawing.Point(36, 173);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(84, 13);
            this.lblNumItems.TabIndex = 1;
            this.lblNumItems.Text = "Number of Items";
            // 
            // tbNumItems
            // 
            this.tbNumItems.Location = new System.Drawing.Point(133, 170);
            this.tbNumItems.Name = "tbNumItems";
            this.tbNumItems.Size = new System.Drawing.Size(126, 20);
            this.tbNumItems.TabIndex = 2;
            // 
            // gbxItemType
            // 
            this.gbxItemType.Controls.Add(this.tbUserItem);
            this.gbxItemType.Controls.Add(this.lbUserItem);
            this.gbxItemType.Location = new System.Drawing.Point(35, 36);
            this.gbxItemType.Name = "gbxItemType";
            this.gbxItemType.Size = new System.Drawing.Size(224, 100);
            this.gbxItemType.TabIndex = 4;
            this.gbxItemType.TabStop = false;
            this.gbxItemType.Text = "Item Type";
            // 
            // tbUserItem
            // 
            this.tbUserItem.Location = new System.Drawing.Point(54, 56);
            this.tbUserItem.Name = "tbUserItem";
            this.tbUserItem.Size = new System.Drawing.Size(100, 20);
            this.tbUserItem.TabIndex = 1;
            // 
            // lbUserItem
            // 
            this.lbUserItem.AutoSize = true;
            this.lbUserItem.Location = new System.Drawing.Point(42, 27);
            this.lbUserItem.Name = "lbUserItem";
            this.lbUserItem.Size = new System.Drawing.Size(121, 26);
            this.lbUserItem.TabIndex = 0;
            this.lbUserItem.Text = "Enter USB, Pen, or Mug\r\n\r\n";
            // 
            // lblTxtToPrint
            // 
            this.lblTxtToPrint.AutoSize = true;
            this.lblTxtToPrint.Location = new System.Drawing.Point(36, 213);
            this.lblTxtToPrint.Name = "lblTxtToPrint";
            this.lblTxtToPrint.Size = new System.Drawing.Size(66, 13);
            this.lblTxtToPrint.TabIndex = 5;
            this.lblTxtToPrint.Text = "Text to print:";
            // 
            // tbTextToPrint
            // 
            this.tbTextToPrint.Location = new System.Drawing.Point(35, 229);
            this.tbTextToPrint.Multiline = true;
            this.tbTextToPrint.Name = "tbTextToPrint";
            this.tbTextToPrint.Size = new System.Drawing.Size(224, 66);
            this.tbTextToPrint.TabIndex = 6;
            // 
            // ckbxLogo
            // 
            this.ckbxLogo.AutoSize = true;
            this.ckbxLogo.Location = new System.Drawing.Point(89, 310);
            this.ckbxLogo.Name = "ckbxLogo";
            this.ckbxLogo.Size = new System.Drawing.Size(96, 17);
            this.ckbxLogo.TabIndex = 7;
            this.ckbxLogo.Text = "Graphic Logo?";
            this.ckbxLogo.UseVisualStyleBackColor = true;
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(37, 347);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(91, 13);
            this.lblNumColors.TabIndex = 8;
            this.lblNumColors.Text = "Number of Colors:";
            // 
            // tbNumColors
            // 
            this.tbNumColors.Location = new System.Drawing.Point(133, 344);
            this.tbNumColors.Name = "tbNumColors";
            this.tbNumColors.Size = new System.Drawing.Size(126, 20);
            this.tbNumColors.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(35, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbOrderSummary
            // 
            this.tbOrderSummary.Location = new System.Drawing.Point(35, 431);
            this.tbOrderSummary.Multiline = true;
            this.tbOrderSummary.Name = "tbOrderSummary";
            this.tbOrderSummary.Size = new System.Drawing.Size(224, 63);
            this.tbOrderSummary.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 511);
            this.Controls.Add(this.tbOrderSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.ckbxLogo);
            this.Controls.Add(this.tbTextToPrint);
            this.Controls.Add(this.lblTxtToPrint);
            this.Controls.Add(this.gbxItemType);
            this.Controls.Add(this.tbNumItems);
            this.Controls.Add(this.lblNumItems);
            this.Name = "Form1";
            this.Text = "Logo Items Ordered";
            this.gbxItemType.ResumeLayout(false);
            this.gbxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.TextBox tbNumItems;
        private System.Windows.Forms.GroupBox gbxItemType;
        private System.Windows.Forms.Label lblTxtToPrint;
        private System.Windows.Forms.TextBox tbTextToPrint;
        private System.Windows.Forms.CheckBox ckbxLogo;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox tbNumColors;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbOrderSummary;
        private System.Windows.Forms.TextBox tbUserItem;
        private System.Windows.Forms.Label lbUserItem;
    }
}

