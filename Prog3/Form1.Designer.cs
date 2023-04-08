
namespace Prog3
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.itemNumLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.initialLabel = new System.Windows.Forms.Label();
            this.adjustedLabel = new System.Windows.Forms.Label();
            this.shipmentLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.itemNumTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.adjustedTextBox = new System.Windows.Forms.TextBox();
            this.shipmentTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.itemNumErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(129, 43);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(30, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City :";
            // 
            // itemNumLabel
            // 
            this.itemNumLabel.AutoSize = true;
            this.itemNumLabel.Location = new System.Drawing.Point(50, 70);
            this.itemNumLabel.Name = "itemNumLabel";
            this.itemNumLabel.Size = new System.Drawing.Size(109, 13);
            this.itemNumLabel.TabIndex = 1;
            this.itemNumLabel.Text = "Entree/Item Number :";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(57, 96);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(102, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity (Servings) :";
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Location = new System.Drawing.Point(98, 171);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(61, 13);
            this.initialLabel.TabIndex = 3;
            this.initialLabel.Text = "Initial Cost :";
            // 
            // adjustedLabel
            // 
            this.adjustedLabel.AutoSize = true;
            this.adjustedLabel.Location = new System.Drawing.Point(81, 197);
            this.adjustedLabel.Name = "adjustedLabel";
            this.adjustedLabel.Size = new System.Drawing.Size(78, 13);
            this.adjustedLabel.TabIndex = 4;
            this.adjustedLabel.Text = "Adjusted Cost :";
            // 
            // shipmentLabel
            // 
            this.shipmentLabel.AutoSize = true;
            this.shipmentLabel.Location = new System.Drawing.Point(78, 223);
            this.shipmentLabel.Name = "shipmentLabel";
            this.shipmentLabel.Size = new System.Drawing.Size(81, 13);
            this.shipmentLabel.TabIndex = 5;
            this.shipmentLabel.Text = "Shipment Cost :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(95, 249);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(64, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total Price :";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Louisville",
            "Lexington",
            "Indianapolis",
            "Nashville"});
            this.cityComboBox.Location = new System.Drawing.Point(165, 40);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 7;
            // 
            // itemNumTextBox
            // 
            this.itemNumTextBox.Location = new System.Drawing.Point(165, 67);
            this.itemNumTextBox.Name = "itemNumTextBox";
            this.itemNumTextBox.Size = new System.Drawing.Size(121, 20);
            this.itemNumTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(165, 93);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // initialTextBox
            // 
            this.initialTextBox.Enabled = false;
            this.initialTextBox.Location = new System.Drawing.Point(165, 168);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(121, 20);
            this.initialTextBox.TabIndex = 10;
            // 
            // adjustedTextBox
            // 
            this.adjustedTextBox.Enabled = false;
            this.adjustedTextBox.Location = new System.Drawing.Point(165, 194);
            this.adjustedTextBox.Name = "adjustedTextBox";
            this.adjustedTextBox.Size = new System.Drawing.Size(121, 20);
            this.adjustedTextBox.TabIndex = 11;
            // 
            // shipmentTextBox
            // 
            this.shipmentTextBox.Enabled = false;
            this.shipmentTextBox.Location = new System.Drawing.Point(165, 220);
            this.shipmentTextBox.Name = "shipmentTextBox";
            this.shipmentTextBox.Size = new System.Drawing.Size(121, 20);
            this.shipmentTextBox.TabIndex = 12;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(165, 246);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalTextBox.TabIndex = 13;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(188, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // itemNumErrorLabel
            // 
            this.itemNumErrorLabel.AutoSize = true;
            this.itemNumErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.itemNumErrorLabel.Location = new System.Drawing.Point(292, 70);
            this.itemNumErrorLabel.Name = "itemNumErrorLabel";
            this.itemNumErrorLabel.Size = new System.Drawing.Size(140, 13);
            this.itemNumErrorLabel.TabIndex = 15;
            this.itemNumErrorLabel.Text = "Invalid Entree/Item Number.";
            this.itemNumErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(292, 96);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(158, 13);
            this.quantityErrorLabel.TabIndex = 16;
            this.quantityErrorLabel.Text = "Quantity must be greater than 0.";
            this.quantityErrorLabel.Visible = false;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.cityErrorLabel.Location = new System.Drawing.Point(292, 43);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(97, 13);
            this.cityErrorLabel.TabIndex = 17;
            this.cityErrorLabel.Text = "Please enter a city.";
            this.cityErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 332);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.quantityErrorLabel);
            this.Controls.Add(this.itemNumErrorLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.shipmentTextBox);
            this.Controls.Add(this.adjustedTextBox);
            this.Controls.Add(this.initialTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemNumTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.shipmentLabel);
            this.Controls.Add(this.adjustedLabel);
            this.Controls.Add(this.initialLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemNumLabel);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Text = "uThankItWeMakeIt Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label itemNumLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.Label adjustedLabel;
        private System.Windows.Forms.Label shipmentLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox itemNumTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.TextBox adjustedTextBox;
        private System.Windows.Forms.TextBox shipmentTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label itemNumErrorLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
    }
}

