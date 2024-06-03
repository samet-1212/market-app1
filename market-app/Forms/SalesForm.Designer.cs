namespace samet_market_app.Forms
{
    partial class SalesForm
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
            this.salesMainPanel = new System.Windows.Forms.Panel();
            this.salesLogBox = new System.Windows.Forms.RichTextBox();
            this.addSalesPanel = new System.Windows.Forms.Panel();
            this.addSaleBtn = new System.Windows.Forms.Button();
            this.prodCountSaleInput = new System.Windows.Forms.TextBox();
            this.prodPriceSaleInput = new System.Windows.Forms.TextBox();
            this.prodIdSaleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodListView = new System.Windows.Forms.DataGridView();
            this.salesMainPanel.SuspendLayout();
            this.addSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesMainPanel
            // 
            this.salesMainPanel.Controls.Add(this.salesLogBox);
            this.salesMainPanel.Controls.Add(this.addSalesPanel);
            this.salesMainPanel.Controls.Add(this.label1);
            this.salesMainPanel.Controls.Add(this.prodListView);
            this.salesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesMainPanel.Location = new System.Drawing.Point(0, 0);
            this.salesMainPanel.Name = "salesMainPanel";
            this.salesMainPanel.Size = new System.Drawing.Size(1158, 565);
            this.salesMainPanel.TabIndex = 0;
            // 
            // salesLogBox
            // 
            this.salesLogBox.Font = new System.Drawing.Font("Uni Sans  ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesLogBox.Location = new System.Drawing.Point(12, 470);
            this.salesLogBox.Name = "salesLogBox";
            this.salesLogBox.ReadOnly = true;
            this.salesLogBox.Size = new System.Drawing.Size(1134, 174);
            this.salesLogBox.TabIndex = 16;
            this.salesLogBox.Text = "";
            // 
            // addSalesPanel
            // 
            this.addSalesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addSalesPanel.Controls.Add(this.addSaleBtn);
            this.addSalesPanel.Controls.Add(this.prodCountSaleInput);
            this.addSalesPanel.Controls.Add(this.prodPriceSaleInput);
            this.addSalesPanel.Controls.Add(this.prodIdSaleInput);
            this.addSalesPanel.Location = new System.Drawing.Point(605, 117);
            this.addSalesPanel.Name = "addSalesPanel";
            this.addSalesPanel.Size = new System.Drawing.Size(541, 244);
            this.addSalesPanel.TabIndex = 15;
            // 
            // addSaleBtn
            // 
            this.addSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSaleBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSaleBtn.Location = new System.Drawing.Point(196, 157);
            this.addSaleBtn.Name = "addSaleBtn";
            this.addSaleBtn.Size = new System.Drawing.Size(153, 64);
            this.addSaleBtn.TabIndex = 16;
            this.addSaleBtn.Text = "Satış Ekle";
            this.addSaleBtn.UseVisualStyleBackColor = true;
            this.addSaleBtn.Click += new System.EventHandler(this.addSaleBtn_Click);
            // 
            // prodCountSaleInput
            // 
            this.prodCountSaleInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodCountSaleInput.Location = new System.Drawing.Point(196, 35);
            this.prodCountSaleInput.Multiline = true;
            this.prodCountSaleInput.Name = "prodCountSaleInput";
            this.prodCountSaleInput.PlaceholderText = "Satış Adedi";
            this.prodCountSaleInput.Size = new System.Drawing.Size(153, 50);
            this.prodCountSaleInput.TabIndex = 18;
            // 
            // prodPriceSaleInput
            // 
            this.prodPriceSaleInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodPriceSaleInput.Location = new System.Drawing.Point(355, 35);
            this.prodPriceSaleInput.Multiline = true;
            this.prodPriceSaleInput.Name = "prodPriceSaleInput";
            this.prodPriceSaleInput.PlaceholderText = "Satış Fiyatı";
            this.prodPriceSaleInput.Size = new System.Drawing.Size(153, 50);
            this.prodPriceSaleInput.TabIndex = 17;
            // 
            // prodIdSaleInput
            // 
            this.prodIdSaleInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodIdSaleInput.Location = new System.Drawing.Point(37, 35);
            this.prodIdSaleInput.Multiline = true;
            this.prodIdSaleInput.Name = "prodIdSaleInput";
            this.prodIdSaleInput.PlaceholderText = "Ürün Id";
            this.prodIdSaleInput.Size = new System.Drawing.Size(153, 50);
            this.prodIdSaleInput.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans  ", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Listesi";
            // 
            // prodListView
            // 
            this.prodListView.AllowUserToAddRows = false;
            this.prodListView.AllowUserToDeleteRows = false;
            this.prodListView.AllowUserToResizeColumns = false;
            this.prodListView.AllowUserToResizeRows = false;
            this.prodListView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.prodListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodListView.Location = new System.Drawing.Point(12, 117);
            this.prodListView.Name = "prodListView";
            this.prodListView.ReadOnly = true;
            this.prodListView.RowHeadersWidth = 10;
            this.prodListView.RowTemplate.Height = 29;
            this.prodListView.Size = new System.Drawing.Size(534, 244);
            this.prodListView.TabIndex = 13;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1158, 565);
            this.Controls.Add(this.salesMainPanel);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.salesMainPanel.ResumeLayout(false);
            this.salesMainPanel.PerformLayout();
            this.addSalesPanel.ResumeLayout(false);
            this.addSalesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salesMainPanel;
        public DataGridView prodListView;
        private Label label1;
        private Panel addSalesPanel;
        private TextBox prodIdSaleInput;
        private TextBox prodCountSaleInput;
        private TextBox prodPriceSaleInput;
        private Button addSaleBtn;
        private RichTextBox salesLogBox;
    }
}