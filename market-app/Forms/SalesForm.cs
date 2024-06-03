using samet_market_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace samet_market_app.Forms
{
    public partial class SalesForm : Form
    {
        AppDbContext db = new();
        public SalesForm()
        {
            InitializeComponent();
            List<Product> prodList = db.Product.ToList();
            ListProducts(prodList);
        }


        public void ListProducts(List<Product> prodList)
        {
            List<string> colmnNames = new() { "Ürün ID", "Ürün İsmi", "Ürün Adedi", "Ürün Birim Fiyatı" };
            foreach (string colmName in colmnNames)
            {
                DataGridViewTextBoxColumn newColmn = new DataGridViewTextBoxColumn();
                newColmn.HeaderText = colmName;
                prodListView.Columns.Add(newColmn);
            }
            //Sütunları tek tek tanımladığımız değerler ile doldurduk
            foreach (Product prod in prodList)
            {
                

                DataGridViewRow newRow = new DataGridViewRow();
                // Emlak bilgilerini ilgili hücrelere yerleştirdik
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.ProductId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.Name });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.StockQuantity });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.Price });

                prodListView.Rows.Add(newRow);


            }


        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            List<Product> prodList = db.Product.ToList();
            List<Sale> saleList = db.Sale.ToList();
            if(int.TryParse(prodCountSaleInput.Text, out _) && prodCountSaleInput.Text.Length != 0 &&Convert.ToInt32( prodCountSaleInput.Text) != 0&& int.TryParse(prodIdSaleInput.Text, out _) && prodIdSaleInput.Text.Length != 0 && Convert.ToInt32(prodIdSaleInput.Text) != 0&& int.TryParse(prodPriceSaleInput.Text, out _) && prodPriceSaleInput.Text.Length != 0 && Convert.ToInt32(prodPriceSaleInput.Text) != 0)
            {
                var product = prodList.FirstOrDefault(p => p.ProductId == Convert.ToInt32(prodIdSaleInput.Text));
                if (product != null)
                {
                    if (Convert.ToInt32(prodCountSaleInput.Text) > product.StockQuantity)
                    {
                        MessageBox.Show("Ürün adedinden fazla satış adedi girilemez");
                    }
                    else
                    {
                        var sale = new Sale()
                        {
                            ProductId = Convert.ToInt32(prodIdSaleInput.Text),
                            ProductName = product.Name,
                            ProductPrice = product.Price,
                            Quantity = Convert.ToInt32(prodCountSaleInput.Text),
                            TotalPrice = Convert.ToInt32(prodPriceSaleInput.Text),
                            SaleDate = DateTime.UtcNow,



                        };
                        db.Sale.Add(sale);
                        db.SaveChanges();
                        product.StockQuantity -= sale.Quantity;

                        
                        if (product.StockQuantity == 0)
                        {
                            db.Product.Remove(product);
                        }
                        else
                        {
                            db.Product.Update(product);
                        }


                        db.SaveChanges();
                        prodListView.Rows.Clear();
                        prodListView.Columns.Clear();
                        ListProducts(db.Product.ToList());
                        MessageBox.Show("Satış başarıyla kaydedildi.");
                        salesLogBox.Text = salesLogBox.Text = $"{sale.ProductId} Sayılı Id'ye sahip {sale.ProductName} adlı üründen {sale.SaleDate} tarihinde {sale.TotalPrice} TL'ye {sale.Quantity} adet satıldı.";
                    }

                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Girdiler doğru fortmatta olmalı ve boş olmamalı.");
            }
            
            
        }
    }
}
