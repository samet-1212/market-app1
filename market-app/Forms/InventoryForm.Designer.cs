namespace samet_market_app.Forms
{
    partial class InventoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodListView = new System.Windows.Forms.DataGridView();
            this.salesListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans  ", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Uni Sans  ", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 51);
            this.label2.TabIndex = 16;
            this.label2.Text = "Satış Listesi";
            // 
            // prodListView
            // 
            this.prodListView.AllowUserToAddRows = false;
            this.prodListView.AllowUserToDeleteRows = false;
            this.prodListView.AllowUserToResizeColumns = false;
            this.prodListView.AllowUserToResizeRows = false;
            this.prodListView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.prodListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodListView.Location = new System.Drawing.Point(12, 63);
            this.prodListView.Name = "prodListView";
            this.prodListView.ReadOnly = true;
            this.prodListView.RowHeadersWidth = 10;
            this.prodListView.RowTemplate.Height = 29;
            this.prodListView.Size = new System.Drawing.Size(1134, 199);
            this.prodListView.TabIndex = 17;
            // 
            // salesListView
            // 
            this.salesListView.AllowUserToAddRows = false;
            this.salesListView.AllowUserToDeleteRows = false;
            this.salesListView.AllowUserToResizeColumns = false;
            this.salesListView.AllowUserToResizeRows = false;
            this.salesListView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.salesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesListView.Location = new System.Drawing.Point(12, 346);
            this.salesListView.Name = "salesListView";
            this.salesListView.ReadOnly = true;
            this.salesListView.RowHeadersWidth = 10;
            this.salesListView.RowTemplate.Height = 29;
            this.salesListView.Size = new System.Drawing.Size(1134, 207);
            this.salesListView.TabIndex = 18;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1158, 565);
            this.Controls.Add(this.salesListView);
            this.Controls.Add(this.prodListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        public DataGridView prodListView;
        public DataGridView salesListView;
    }
}