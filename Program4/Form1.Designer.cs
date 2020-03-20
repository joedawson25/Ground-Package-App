namespace Program4
{
    partial class groundPackageForm
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
            this.originZipTextBox = new System.Windows.Forms.TextBox();
            this.destinationZipTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destinationZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bpsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originZipTextBox
            // 
            this.originZipTextBox.Location = new System.Drawing.Point(116, 48);
            this.originZipTextBox.Name = "originZipTextBox";
            this.originZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.originZipTextBox.TabIndex = 0;
            // 
            // destinationZipTextBox
            // 
            this.destinationZipTextBox.Location = new System.Drawing.Point(116, 76);
            this.destinationZipTextBox.Name = "destinationZipTextBox";
            this.destinationZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationZipTextBox.TabIndex = 1;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(116, 101);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 2;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(117, 129);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 3;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(117, 156);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(223, 43);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(81, 160);
            this.packageListBox.TabIndex = 8;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(311, 43);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(89, 23);
            this.detailsButton.TabIndex = 9;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(310, 113);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(90, 23);
            this.sendToButton.TabIndex = 10;
            this.sendToButton.Text = "Send to UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(311, 180);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(89, 23);
            this.sendFromButton.TabIndex = 11;
            this.sendFromButton.Text = "Send from UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(48, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Ground Package";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.Location = new System.Drawing.Point(27, 51);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(83, 13);
            this.originZipLabel.TabIndex = 10;
            this.originZipLabel.Text = "Origin Zip Code:";
            // 
            // destinationZipLabel
            // 
            this.destinationZipLabel.AutoSize = true;
            this.destinationZipLabel.Location = new System.Drawing.Point(1, 79);
            this.destinationZipLabel.Name = "destinationZipLabel";
            this.destinationZipLabel.Size = new System.Drawing.Size(109, 13);
            this.destinationZipLabel.TabIndex = 11;
            this.destinationZipLabel.Text = "Destination Zip Code:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(27, 104);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(83, 13);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "Length (inches):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(32, 132);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(78, 13);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "Width (inches):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(29, 161);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 13);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Height (inches):";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(117, 183);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(22, 186);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 13);
            this.weightLabel.TabIndex = 16;
            this.weightLabel.Text = "Weight (pounds):";
            // 
            // bpsLabel
            // 
            this.bpsLabel.AutoSize = true;
            this.bpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpsLabel.Location = new System.Drawing.Point(95, 9);
            this.bpsLabel.Name = "bpsLabel";
            this.bpsLabel.Size = new System.Drawing.Size(234, 20);
            this.bpsLabel.TabIndex = 17;
            this.bpsLabel.Text = "BROWN PARCEL SERVICE";
            // 
            // groundPackageForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 243);
            this.Controls.Add(this.bpsLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationZipLabel);
            this.Controls.Add(this.originZipLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destinationZipTextBox);
            this.Controls.Add(this.originZipTextBox);
            this.Name = "groundPackageForm";
            this.Text = "Ground Package Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originZipTextBox;
        private System.Windows.Forms.TextBox destinationZipTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destinationZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label bpsLabel;
    }
}

