namespace ProgramThree
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
            this.gardenLabel = new System.Windows.Forms.Label();
            this.fnumberLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.flowerCost = new System.Windows.Forms.Label();
            this.baseCost = new System.Windows.Forms.Label();
            this.discountPercent = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.fnumberLabelinput = new System.Windows.Forms.TextBox();
            this.quantityLabelinput = new System.Windows.Forms.TextBox();
            this.flowerCostoutput = new System.Windows.Forms.TextBox();
            this.baseCostoutput = new System.Windows.Forms.TextBox();
            this.discountPercentoutput = new System.Windows.Forms.TextBox();
            this.totalPriceoutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gardenCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gardenLabel
            // 
            this.gardenLabel.AutoSize = true;
            this.gardenLabel.Location = new System.Drawing.Point(107, 46);
            this.gardenLabel.Name = "gardenLabel";
            this.gardenLabel.Size = new System.Drawing.Size(45, 13);
            this.gardenLabel.TabIndex = 0;
            this.gardenLabel.Text = "Garden:";
            // 
            // fnumberLabel
            // 
            this.fnumberLabel.AutoSize = true;
            this.fnumberLabel.Location = new System.Drawing.Point(107, 86);
            this.fnumberLabel.Name = "fnumberLabel";
            this.fnumberLabel.Size = new System.Drawing.Size(81, 13);
            this.fnumberLabel.TabIndex = 1;
            this.fnumberLabel.Text = "Flower Number:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(110, 127);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity:";
            // 
            // flowerCost
            // 
            this.flowerCost.AutoSize = true;
            this.flowerCost.Location = new System.Drawing.Point(154, 197);
            this.flowerCost.Name = "flowerCost";
            this.flowerCost.Size = new System.Drawing.Size(70, 13);
            this.flowerCost.TabIndex = 3;
            this.flowerCost.Text = "Flowers Cost:";
            // 
            // baseCost
            // 
            this.baseCost.AutoSize = true;
            this.baseCost.Location = new System.Drawing.Point(154, 227);
            this.baseCost.Name = "baseCost";
            this.baseCost.Size = new System.Drawing.Size(102, 13);
            this.baseCost.TabIndex = 4;
            this.baseCost.Text = "Base Adjusted Cost:";
            // 
            // discountPercent
            // 
            this.discountPercent.AutoSize = true;
            this.discountPercent.Location = new System.Drawing.Point(157, 261);
            this.discountPercent.Name = "discountPercent";
            this.discountPercent.Size = new System.Drawing.Size(92, 13);
            this.discountPercent.TabIndex = 5;
            this.discountPercent.Text = "Discount Percent:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(157, 293);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(61, 13);
            this.totalPrice.TabIndex = 6;
            this.totalPrice.Text = "Total Price:";
            // 
            // fnumberLabelinput
            // 
            this.fnumberLabelinput.Location = new System.Drawing.Point(226, 83);
            this.fnumberLabelinput.Name = "fnumberLabelinput";
            this.fnumberLabelinput.Size = new System.Drawing.Size(100, 20);
            this.fnumberLabelinput.TabIndex = 8;
            // 
            // quantityLabelinput
            // 
            this.quantityLabelinput.Location = new System.Drawing.Point(226, 127);
            this.quantityLabelinput.Name = "quantityLabelinput";
            this.quantityLabelinput.Size = new System.Drawing.Size(100, 20);
            this.quantityLabelinput.TabIndex = 9;
            // 
            // flowerCostoutput
            // 
            this.flowerCostoutput.Location = new System.Drawing.Point(271, 190);
            this.flowerCostoutput.Name = "flowerCostoutput";
            this.flowerCostoutput.Size = new System.Drawing.Size(100, 20);
            this.flowerCostoutput.TabIndex = 10;
            // 
            // baseCostoutput
            // 
            this.baseCostoutput.Location = new System.Drawing.Point(271, 227);
            this.baseCostoutput.Name = "baseCostoutput";
            this.baseCostoutput.Size = new System.Drawing.Size(100, 20);
            this.baseCostoutput.TabIndex = 11;
            // 
            // discountPercentoutput
            // 
            this.discountPercentoutput.Location = new System.Drawing.Point(271, 258);
            this.discountPercentoutput.Name = "discountPercentoutput";
            this.discountPercentoutput.Size = new System.Drawing.Size(100, 20);
            this.discountPercentoutput.TabIndex = 12;
            // 
            // totalPriceoutput
            // 
            this.totalPriceoutput.Location = new System.Drawing.Point(271, 293);
            this.totalPriceoutput.Name = "totalPriceoutput";
            this.totalPriceoutput.Size = new System.Drawing.Size(100, 20);
            this.totalPriceoutput.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gardenCombobox
            // 
            this.gardenCombobox.FormattingEnabled = true;
            this.gardenCombobox.Items.AddRange(new object[] {
            "Premium",
            "Standard",
            "Discount"});
            this.gardenCombobox.Location = new System.Drawing.Point(226, 46);
            this.gardenCombobox.Name = "gardenCombobox";
            this.gardenCombobox.Size = new System.Drawing.Size(121, 21);
            this.gardenCombobox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gardenCombobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPriceoutput);
            this.Controls.Add(this.discountPercentoutput);
            this.Controls.Add(this.baseCostoutput);
            this.Controls.Add(this.flowerCostoutput);
            this.Controls.Add(this.quantityLabelinput);
            this.Controls.Add(this.fnumberLabelinput);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.discountPercent);
            this.Controls.Add(this.baseCost);
            this.Controls.Add(this.flowerCost);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.fnumberLabel);
            this.Controls.Add(this.gardenLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gardenLabel;
        private System.Windows.Forms.Label fnumberLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label flowerCost;
        private System.Windows.Forms.Label baseCost;
        private System.Windows.Forms.Label discountPercent;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.TextBox fnumberLabelinput;
        private System.Windows.Forms.TextBox quantityLabelinput;
        private System.Windows.Forms.TextBox flowerCostoutput;
        private System.Windows.Forms.TextBox baseCostoutput;
        private System.Windows.Forms.TextBox discountPercentoutput;
        private System.Windows.Forms.TextBox totalPriceoutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gardenCombobox;
    }
}

