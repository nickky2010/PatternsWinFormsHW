namespace HWPatterns4_Bridge
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectProduct = new System.Windows.Forms.ComboBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPointOfDelivery = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPickup = new System.Windows.Forms.RadioButton();
            this.radioButtonToBeDelivered = new System.Windows.Forms.RadioButton();
            this.buttonCostOfPurchase = new System.Windows.Forms.Button();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select product";
            // 
            // comboBoxSelectProduct
            // 
            this.comboBoxSelectProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectProduct.FormattingEnabled = true;
            this.comboBoxSelectProduct.Location = new System.Drawing.Point(13, 34);
            this.comboBoxSelectProduct.Name = "comboBoxSelectProduct";
            this.comboBoxSelectProduct.Size = new System.Drawing.Size(155, 27);
            this.comboBoxSelectProduct.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.Location = new System.Drawing.Point(257, 13);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(115, 45);
            this.buttonAddToCart.TabIndex = 3;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Point of delivery";
            // 
            // comboBoxPointOfDelivery
            // 
            this.comboBoxPointOfDelivery.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPointOfDelivery.FormattingEnabled = true;
            this.comboBoxPointOfDelivery.Location = new System.Drawing.Point(13, 94);
            this.comboBoxPointOfDelivery.Name = "comboBoxPointOfDelivery";
            this.comboBoxPointOfDelivery.Size = new System.Drawing.Size(155, 27);
            this.comboBoxPointOfDelivery.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery method";
            // 
            // radioButtonPickup
            // 
            this.radioButtonPickup.AutoSize = true;
            this.radioButtonPickup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPickup.Location = new System.Drawing.Point(12, 164);
            this.radioButtonPickup.Name = "radioButtonPickup";
            this.radioButtonPickup.Size = new System.Drawing.Size(80, 23);
            this.radioButtonPickup.TabIndex = 8;
            this.radioButtonPickup.Text = "Pickup";
            this.radioButtonPickup.UseVisualStyleBackColor = true;
            // 
            // radioButtonToBeDelivered
            // 
            this.radioButtonToBeDelivered.AutoSize = true;
            this.radioButtonToBeDelivered.Checked = true;
            this.radioButtonToBeDelivered.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonToBeDelivered.Location = new System.Drawing.Point(12, 192);
            this.radioButtonToBeDelivered.Name = "radioButtonToBeDelivered";
            this.radioButtonToBeDelivered.Size = new System.Drawing.Size(139, 23);
            this.radioButtonToBeDelivered.TabIndex = 9;
            this.radioButtonToBeDelivered.TabStop = true;
            this.radioButtonToBeDelivered.Text = "To be delivered";
            this.radioButtonToBeDelivered.UseVisualStyleBackColor = true;
            // 
            // buttonCostOfPurchase
            // 
            this.buttonCostOfPurchase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCostOfPurchase.Location = new System.Drawing.Point(257, 170);
            this.buttonCostOfPurchase.Name = "buttonCostOfPurchase";
            this.buttonCostOfPurchase.Size = new System.Drawing.Size(115, 45);
            this.buttonCostOfPurchase.TabIndex = 10;
            this.buttonCostOfPurchase.Text = "Cost of purchase";
            this.buttonCostOfPurchase.UseVisualStyleBackColor = true;
            this.buttonCostOfPurchase.Click += new System.EventHandler(this.buttonCostOfPurchase_Click);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.Location = new System.Drawing.Point(391, 188);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(97, 27);
            this.textBoxCost.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(190, 34);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 27);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(387, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cost";
            // 
            // listBoxCart
            // 
            this.listBoxCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 20;
            this.listBoxCart.Location = new System.Drawing.Point(391, 13);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(244, 144);
            this.listBoxCart.TabIndex = 14;
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearCart.Location = new System.Drawing.Point(257, 115);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(115, 45);
            this.buttonClearCart.TabIndex = 15;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(257, 64);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(115, 45);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Remove from Cart";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 226);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonClearCart);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.buttonCostOfPurchase);
            this.Controls.Add(this.radioButtonToBeDelivered);
            this.Controls.Add(this.radioButtonPickup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPointOfDelivery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.comboBoxSelectProduct);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bridge";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectProduct;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPointOfDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPickup;
        private System.Windows.Forms.RadioButton radioButtonToBeDelivered;
        private System.Windows.Forms.Button buttonCostOfPurchase;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonRemove;
    }
}

