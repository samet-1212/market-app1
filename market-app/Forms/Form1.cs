using samet_market_app.Forms;
using samet_market_app.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace samet_market_app
{
    public partial class Form1 : Form
    {
        AppDbContext db = new();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            if(prodCountSaveInput.Text.Length!=0&& int.TryParse(prodCountSaveInput.Text, out _)&& prodNameSaveInput.Text.Length != 0 && prodPriceSaveInput.Text.Length != 0 && int.TryParse(prodPriceSaveInput.Text, out _))
            {
                var prod = new Product()
                {

                    Name = prodNameSaveInput.Text,
                    StockQuantity = Convert.ToInt32(prodCountSaveInput.Text),
                    Price = Convert.ToInt32(prodPriceSaveInput.Text),



                };
                db.Product.Add(prod);
                db.SaveChanges();
                var item = new Inventory()
                {

                    ItemName = prodNameSaveInput.Text,
                    ItemStock = Convert.ToInt32(prodCountSaveInput.Text),
                    ItemPrice = Convert.ToInt32(prodPriceSaveInput.Text),
                    ProductId = prod.ProductId,




                };
                db.Inventory.Add(item);
                db.SaveChanges();
                MessageBox.Show("�r�n ba�ar�yla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Girdiler do�ru fortmatta olmal� ve bo� olmamal�.");
            }
            
        }

        private void salesPanel_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();

            mainPanel.Controls.Clear();
            salesForm.TopLevel = false;
            mainPanel.Controls.Add(salesForm);
            salesForm.WindowState = FormWindowState.Maximized;
            salesForm.FormBorderStyle = FormBorderStyle.None;
            salesForm.Show();

        }

        private void openProductPanelBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void openEnvanterPanelBtn_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            mainPanel.Controls.Clear();
            inventoryForm.TopLevel = false;
            mainPanel.Controls.Add(inventoryForm);
            inventoryForm.WindowState = FormWindowState.Maximized;
            inventoryForm.FormBorderStyle = FormBorderStyle.None;
            inventoryForm.Show();
        }

        private void updateProdBtn_Click(object sender, EventArgs e)
        {
            if (prodIdUpdateInput.Text.Length != 0)
            {
                var product = db.Product.FirstOrDefault(p => p.ProductId == Convert.ToInt32(prodIdUpdateInput.Text));

                if (product != null)
                {
                    if (prodCountUpdateInput.Text.Length != 0)
                    {   if(int.TryParse(prodCountUpdateInput.Text, out _))
                        {
                            if (Convert.ToInt32(prodCountUpdateInput.Text) == 0)
                            {
                                db.Product.Remove(product);
                                db.SaveChanges();
                                MessageBox.Show("�r�n Ba�ar�yla Silindi");
                            }
                            else
                            {
                                product.StockQuantity = Convert.ToInt32(prodCountUpdateInput.Text);
                                db.SaveChanges();
                                MessageBox.Show("�r�n Adedi Ba�ar�yla G�ncellendi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("�r�n Adedi Say� Format�nda Olmal�");
                        }
                        


                    }
                    if (prodPriceUpdateInput.Text.Length != 0)
                    {
                        if (int.TryParse(prodPriceUpdateInput.Text, out _))
                        {
                            if (Convert.ToInt32(prodPriceUpdateInput.Text) == 0)
                            {

                                MessageBox.Show("�r�n fiyat� 0 yap�lamaz.");
                            }
                            else
                            {
                                product.Price = Convert.ToInt32(prodPriceUpdateInput.Text);
                                db.SaveChanges();
                                MessageBox.Show("�r�n Fiyat� Ba�ar�yla G�ncellendi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("�r�n Fiyat� Say� Format�nda Olmal�");
                        }
                        


                    }
                    
                    if (prodNameUpdateInput.Text.Length != 0)
                    {



                        product.Name = prodNameUpdateInput.Text;
                        db.SaveChanges();
                        MessageBox.Show("�r�n �smi Ba�ar�yla G�ncellendi");



                    }
                }
                else
                {
                    MessageBox.Show("�r�n Bulunamad�");
                }
            }
            else
            {
                MessageBox.Show("G�ncelleme yapmak istiyorsan�z �R�N ID alan� bo� b�rak�lamaz");
            }
            
            
        }
    }
}