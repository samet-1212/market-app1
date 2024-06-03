namespace samet_market_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.openEnvanterPanelBtn = new System.Windows.Forms.Button();
            this.openProductPanelBtn = new System.Windows.Forms.Button();
            this.openSalesFormBtn = new System.Windows.Forms.Button();
            this.saveProdBtn = new System.Windows.Forms.Button();
            this.prodNameSaveInput = new System.Windows.Forms.TextBox();
            this.prodUpdatePanel = new System.Windows.Forms.Panel();
            this.prodIdUpdateInput = new System.Windows.Forms.TextBox();
            this.prodCountUpdateInput = new System.Windows.Forms.TextBox();
            this.prodPriceUpdateInput = new System.Windows.Forms.TextBox();
            this.prodNameUpdateInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodSavePanel = new System.Windows.Forms.Panel();
            this.prodCountSaveInput = new System.Windows.Forms.TextBox();
            this.prodPriceSaveInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateProdBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.prodUpdatePanel.SuspendLayout();
            this.prodSavePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(235)))), ((int)(((byte)(180)))));
            this.menuPanel.Controls.Add(this.openEnvanterPanelBtn);
            this.menuPanel.Controls.Add(this.openProductPanelBtn);
            this.menuPanel.Controls.Add(this.openSalesFormBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(166, 721);
            this.menuPanel.TabIndex = 0;
            // 
            // openEnvanterPanelBtn
            // 
            this.openEnvanterPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openEnvanterPanelBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openEnvanterPanelBtn.Location = new System.Drawing.Point(12, 544);
            this.openEnvanterPanelBtn.Name = "openEnvanterPanelBtn";
            this.openEnvanterPanelBtn.Size = new System.Drawing.Size(139, 92);
            this.openEnvanterPanelBtn.TabIndex = 2;
            this.openEnvanterPanelBtn.Text = "Envanter Paneli";
            this.openEnvanterPanelBtn.UseVisualStyleBackColor = true;
            this.openEnvanterPanelBtn.Click += new System.EventHandler(this.openEnvanterPanelBtn_Click);
            // 
            // openProductPanelBtn
            // 
            this.openProductPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProductPanelBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openProductPanelBtn.Location = new System.Drawing.Point(12, 72);
            this.openProductPanelBtn.Name = "openProductPanelBtn";
            this.openProductPanelBtn.Size = new System.Drawing.Size(139, 92);
            this.openProductPanelBtn.TabIndex = 1;
            this.openProductPanelBtn.Text = "Ürün Paneli";
            this.openProductPanelBtn.UseVisualStyleBackColor = true;
            this.openProductPanelBtn.Click += new System.EventHandler(this.openProductPanelBtn_Click);
            // 
            // openSalesFormBtn
            // 
            this.openSalesFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSalesFormBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openSalesFormBtn.Location = new System.Drawing.Point(12, 292);
            this.openSalesFormBtn.Name = "openSalesFormBtn";
            this.openSalesFormBtn.Size = new System.Drawing.Size(139, 92);
            this.openSalesFormBtn.TabIndex = 0;
            this.openSalesFormBtn.Text = "Satış Paneli";
            this.openSalesFormBtn.UseVisualStyleBackColor = true;
            this.openSalesFormBtn.Click += new System.EventHandler(this.salesPanel_Click);
            // 
            // saveProdBtn
            // 
            this.saveProdBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveProdBtn.Location = new System.Drawing.Point(374, 498);
            this.saveProdBtn.Name = "saveProdBtn";
            this.saveProdBtn.Size = new System.Drawing.Size(154, 72);
            this.saveProdBtn.TabIndex = 1;
            this.saveProdBtn.Text = "Kaydet";
            this.saveProdBtn.UseVisualStyleBackColor = true;
            this.saveProdBtn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // prodNameSaveInput
            // 
            this.prodNameSaveInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodNameSaveInput.Location = new System.Drawing.Point(153, 108);
            this.prodNameSaveInput.Multiline = true;
            this.prodNameSaveInput.Name = "prodNameSaveInput";
            this.prodNameSaveInput.PlaceholderText = "Ürün İsmi";
            this.prodNameSaveInput.Size = new System.Drawing.Size(183, 50);
            this.prodNameSaveInput.TabIndex = 2;
            // 
            // prodUpdatePanel
            // 
            this.prodUpdatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodUpdatePanel.Controls.Add(this.prodIdUpdateInput);
            this.prodUpdatePanel.Controls.Add(this.prodCountUpdateInput);
            this.prodUpdatePanel.Controls.Add(this.prodPriceUpdateInput);
            this.prodUpdatePanel.Controls.Add(this.prodNameUpdateInput);
            this.prodUpdatePanel.Controls.Add(this.label2);
            this.prodUpdatePanel.Location = new System.Drawing.Point(648, 12);
            this.prodUpdatePanel.Name = "prodUpdatePanel";
            this.prodUpdatePanel.Size = new System.Drawing.Size(522, 461);
            this.prodUpdatePanel.TabIndex = 3;
            // 
            // prodIdUpdateInput
            // 
            this.prodIdUpdateInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodIdUpdateInput.Location = new System.Drawing.Point(172, 98);
            this.prodIdUpdateInput.Multiline = true;
            this.prodIdUpdateInput.Name = "prodIdUpdateInput";
            this.prodIdUpdateInput.PlaceholderText = "Ürün Id";
            this.prodIdUpdateInput.Size = new System.Drawing.Size(183, 50);
            this.prodIdUpdateInput.TabIndex = 7;
            // 
            // prodCountUpdateInput
            // 
            this.prodCountUpdateInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodCountUpdateInput.Location = new System.Drawing.Point(172, 333);
            this.prodCountUpdateInput.Multiline = true;
            this.prodCountUpdateInput.Name = "prodCountUpdateInput";
            this.prodCountUpdateInput.PlaceholderText = "Ürün Adedi";
            this.prodCountUpdateInput.Size = new System.Drawing.Size(183, 50);
            this.prodCountUpdateInput.TabIndex = 6;
            // 
            // prodPriceUpdateInput
            // 
            this.prodPriceUpdateInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodPriceUpdateInput.Location = new System.Drawing.Point(172, 252);
            this.prodPriceUpdateInput.Multiline = true;
            this.prodPriceUpdateInput.Name = "prodPriceUpdateInput";
            this.prodPriceUpdateInput.PlaceholderText = "Birim Fiyat";
            this.prodPriceUpdateInput.Size = new System.Drawing.Size(183, 50);
            this.prodPriceUpdateInput.TabIndex = 6;
            // 
            // prodNameUpdateInput
            // 
            this.prodNameUpdateInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodNameUpdateInput.Location = new System.Drawing.Point(172, 180);
            this.prodNameUpdateInput.Multiline = true;
            this.prodNameUpdateInput.Name = "prodNameUpdateInput";
            this.prodNameUpdateInput.PlaceholderText = "Ürün İsmi";
            this.prodNameUpdateInput.Size = new System.Drawing.Size(183, 50);
            this.prodNameUpdateInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Uni Sans  ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Güncelleme Alanı";
            // 
            // prodSavePanel
            // 
            this.prodSavePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodSavePanel.Controls.Add(this.prodCountSaveInput);
            this.prodSavePanel.Controls.Add(this.prodPriceSaveInput);
            this.prodSavePanel.Controls.Add(this.label1);
            this.prodSavePanel.Controls.Add(this.prodNameSaveInput);
            this.prodSavePanel.Location = new System.Drawing.Point(6, 12);
            this.prodSavePanel.Name = "prodSavePanel";
            this.prodSavePanel.Size = new System.Drawing.Size(522, 461);
            this.prodSavePanel.TabIndex = 4;
            // 
            // prodCountSaveInput
            // 
            this.prodCountSaveInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodCountSaveInput.Location = new System.Drawing.Point(153, 261);
            this.prodCountSaveInput.Multiline = true;
            this.prodCountSaveInput.Name = "prodCountSaveInput";
            this.prodCountSaveInput.PlaceholderText = "Ürün Adedi";
            this.prodCountSaveInput.Size = new System.Drawing.Size(183, 50);
            this.prodCountSaveInput.TabIndex = 5;
            // 
            // prodPriceSaveInput
            // 
            this.prodPriceSaveInput.Font = new System.Drawing.Font("Uni Sans  ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodPriceSaveInput.Location = new System.Drawing.Point(153, 180);
            this.prodPriceSaveInput.Multiline = true;
            this.prodPriceSaveInput.Name = "prodPriceSaveInput";
            this.prodPriceSaveInput.PlaceholderText = "Birim Fiyat";
            this.prodPriceSaveInput.Size = new System.Drawing.Size(183, 50);
            this.prodPriceSaveInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans  ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Kaydetme Alanı";
            // 
            // updateProdBtn
            // 
            this.updateProdBtn.Font = new System.Drawing.Font("Uni Sans  ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateProdBtn.Location = new System.Drawing.Point(648, 498);
            this.updateProdBtn.Name = "updateProdBtn";
            this.updateProdBtn.Size = new System.Drawing.Size(154, 72);
            this.updateProdBtn.TabIndex = 5;
            this.updateProdBtn.Text = "Güncelle";
            this.updateProdBtn.UseVisualStyleBackColor = true;
            this.updateProdBtn.Click += new System.EventHandler(this.updateProdBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.productPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(166, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1182, 721);
            this.mainPanel.TabIndex = 6;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.updateProdBtn);
            this.productPanel.Controls.Add(this.prodUpdatePanel);
            this.productPanel.Controls.Add(this.saveProdBtn);
            this.productPanel.Controls.Add(this.prodSavePanel);
            this.productPanel.Location = new System.Drawing.Point(3, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1176, 612);
            this.productPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.prodUpdatePanel.ResumeLayout(false);
            this.prodUpdatePanel.PerformLayout();
            this.prodSavePanel.ResumeLayout(false);
            this.prodSavePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button saveProdBtn;
        private TextBox prodNameSaveInput;
        private Panel prodUpdatePanel;
        private Panel prodSavePanel;
        private Button updateProdBtn;
        private Label label2;
        private Label label1;
        private TextBox prodCountSaveInput;
        private TextBox prodPriceSaveInput;
        private TextBox prodCountUpdateInput;
        private TextBox prodPriceUpdateInput;
        private TextBox prodNameUpdateInput;
        private TextBox prodIdUpdateInput;
        private Button openSalesFormBtn;
        private Panel mainPanel;
        private Button openEnvanterPanelBtn;
        private Button openProductPanelBtn;
        private Panel productPanel;
    }
}