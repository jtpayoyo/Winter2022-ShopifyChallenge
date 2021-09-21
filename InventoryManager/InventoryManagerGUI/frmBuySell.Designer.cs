
namespace InventoryManagerGUI
{
    partial class frmBuySell
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBuySell = new System.Windows.Forms.GroupBox();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuySell = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCostSale = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBuySell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 325);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gbBuySell
            // 
            this.gbBuySell.Controls.Add(this.nupQuantity);
            this.gbBuySell.Controls.Add(this.label4);
            this.gbBuySell.Controls.Add(this.btnCancel);
            this.gbBuySell.Controls.Add(this.btnBuySell);
            this.gbBuySell.Controls.Add(this.txtTotal);
            this.gbBuySell.Controls.Add(this.label1);
            this.gbBuySell.Controls.Add(this.label2);
            this.gbBuySell.Controls.Add(this.lblTotalCostSale);
            this.gbBuySell.Controls.Add(this.txtPrice);
            this.gbBuySell.Controls.Add(this.txtDiscount);
            this.gbBuySell.Location = new System.Drawing.Point(435, 36);
            this.gbBuySell.Name = "gbBuySell";
            this.gbBuySell.Size = new System.Drawing.Size(380, 405);
            this.gbBuySell.TabIndex = 21;
            this.gbBuySell.TabStop = false;
            this.gbBuySell.Text = "BuySell Items";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(186, 176);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(125, 34);
            this.nupQuantity.TabIndex = 12;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuySell
            // 
            this.btnBuySell.Location = new System.Drawing.Point(77, 325);
            this.btnBuySell.Name = "btnBuySell";
            this.btnBuySell.Size = new System.Drawing.Size(94, 43);
            this.btnBuySell.TabIndex = 9;
            this.btnBuySell.Text = "BuySell";
            this.btnBuySell.UseVisualStyleBackColor = true;
            this.btnBuySell.Click += new System.EventHandler(this.btnBuySell_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(186, 240);
            this.txtTotal.MaxLength = 100;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 34);
            this.txtTotal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount";
            // 
            // lblTotalCostSale
            // 
            this.lblTotalCostSale.AutoSize = true;
            this.lblTotalCostSale.Location = new System.Drawing.Point(31, 243);
            this.lblTotalCostSale.Name = "lblTotalCostSale";
            this.lblTotalCostSale.Size = new System.Drawing.Size(129, 28);
            this.lblTotalCostSale.TabIndex = 3;
            this.lblTotalCostSale.Text = "TotalCostSale";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(186, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 34);
            this.txtPrice.TabIndex = 6;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(186, 113);
            this.txtDiscount.MaxLength = 50;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(125, 34);
            this.txtDiscount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Item ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Name";
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(148, 385);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(125, 34);
            this.txtItemId.TabIndex = 24;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(148, 440);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(214, 34);
            this.txtItemName.TabIndex = 25;
            // 
            // frmBuySell
            // 
            this.AcceptButton = this.btnBuySell;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbBuySell);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuySell";
            this.Text = "frmBuySell";
            this.Load += new System.EventHandler(this.frmBuySell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBuySell.ResumeLayout(false);
            this.gbBuySell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbBuySell;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCostSale;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBuySell;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
    }
}