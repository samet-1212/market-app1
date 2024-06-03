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

namespace samet_market_app.Forms
{
    public partial class InventoryForm : Form
    {
        AppDbContext db = new();
        public InventoryForm()
        {
            InitializeComponent();
            List<Inventory> inventoryList = db.Inventory.ToList();
            ListProducts(inventoryList);
            List<Sale> saleList = db.Sale.ToList();
            ListSales(saleList);

        }

        public void ListProducts(List<Inventory> inventoryList)
        {
            List<string> colmnNames = new() { "Ürün ID", "Ürün İsmi", "Ürün Adedi", "Ürün Birim Fiyatı" };
            foreach (string colmName in colmnNames)
            {
                DataGridViewTextBoxColumn newColmn = new DataGridViewTextBoxColumn();
                newColmn.HeaderText = colmName;
                prodListView.Columns.Add(newColmn);
            }
            //Sütunları tek tek tanımladığımız değerler ile doldurduk
            foreach (Inventory item in inventoryList)
            {


                DataGridViewRow newRow = new DataGridViewRow();
                // Emlak bilgilerini ilgili hücrelere yerleştirdik
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.ProductId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.ItemName });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.ItemPrice });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.ItemStock });

                prodListView.Rows.Add(newRow);


            }


        }

        public void ListSales(List<Sale> saleList)
        {
            List<string> colmnNames = new() { "Satış ID", "Ürün ID", "Ürün İsmi", "Ürün Birim Fiyatı", "Satılan Adet", "Satış Fiyatı", "Satış Tarihi" };
            foreach (string colmName in colmnNames)
            {
                DataGridViewTextBoxColumn newColmn = new DataGridViewTextBoxColumn();
                newColmn.HeaderText = colmName;
                salesListView.Columns.Add(newColmn);
            }
            //Sütunları tek tek tanımladığımız değerler ile doldurduk
            foreach (Sale sale in saleList)
            {


                DataGridViewRow newRow = new DataGridViewRow();
                // Emlak bilgilerini ilgili hücrelere yerleştirdik
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.SaleId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductName });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductPrice });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.Quantity });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.TotalPrice });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.SaleDate }).ToString("yyyy-MM-dd HH:mm:ss");

                salesListView.Rows.Add(newRow);


            }


        }
    }
}
