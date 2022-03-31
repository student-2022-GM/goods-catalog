using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodsCatalog_M_20.Storage;
using GoodsCatalog_M_20.Models;

namespace GoodsCatalog_M_20
{
    public partial class Products : Form
    {
        Model1 db = new Model1();
        Form parent = null;
        public Products(Form Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void initDataButton_Click(object sender, EventArgs e)
        {
            db.Categories.Add(new Category() {
                Name = "Продукти харчування"
            });
            db.Categories.Add(new Category()
            {
                Name = "Одяг"
            });
            db.Categories.Add(new Category()
            {
                Name = "Взуття"
            });

            db.SaveChanges();

            db.Products.Add(new Product() { 
                Name = "Product-1",
                Producer = "Producer-1",
                Quantity = 10,
                Price = 12.45M,
                Measures = "штуки",
                CategoryId = 1
            });
            db.Products.Add(new Product()
            {
                Name = "Product-2",
                Producer = "Producer-2",
                Quantity = 20,
                Price = 112.45M,
                Measures = "кілограм",
                CategoryId = 1
            });
            db.Products.Add(new Product()
            {
                Name = "Product-3",
                Producer = "Producer-3",
                Quantity = 20,
                Price = 112.45M,
                Measures = "штук",
                CategoryId = 2
            });
            db.Products.Add(new Product()
            {
                Name = "Product-4",
                Producer = "Producer-4",
                Quantity = 20,
                Price = 112.45M,
                Measures = "штук",
                CategoryId = 3
            });
            db.Products.Add(new Product()
            {
                Name = "Product-5",
                Producer = "Producer-1",
                Quantity = 90,
                Price = 120.45M,
                Measures = "штуки",
                CategoryId = 1
            });

            db.SaveChanges();
            MessageBox.Show("Good initialization", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = db.Categories.ToList();
            listBox1.DisplayMember = "Name";

        }

        private List<String> producerName;
        private decimal productPriceMin;
        private decimal productPriceMax;
        private decimal filterMin;
        private decimal filterMax;

        private List<Product> productList;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = (listBox1.SelectedItem as Category).Id;
            productList = db.Products.Where(p => p.Category.Id == cid).ToList();

            producerName = productList.Select(p => p.Producer).Distinct().OrderBy(x => x).ToList();
            producerName.Insert(0, "");
            producerComboBox.DataSource = producerName;

            categoriesList.Items.Clear();
            productPriceMax = productPriceMin = productList[0].Price;
            foreach (Product p in productList)
            {
                var item = categoriesList.Items.Add(p.Name);
                item.SubItems.Add(p.Producer);
                item.SubItems.Add(p.Price.ToString("F"));
                item.SubItems.Add(p.Quantity.ToString());
                item.SubItems.Add(p.Measures);
                if (productPriceMax < p.Price) productPriceMax = p.Price;
                if (productPriceMin > p.Price) productPriceMin = p.Price;
            }

            filterMin = productPriceMin;
            filterMax = productPriceMax;
            minPriceTextBox.Text = productPriceMin.ToString();
            maxPriceTextBox.Text = productPriceMax.ToString();
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(parent != null)
            {
                parent.Show();
                this.Hide();
                e.Cancel = true;
            }
        }

        private void producerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showFilter();
        }

        private void setMinFilter()
        {
            if (minPriceTextBox.Text == "")
            {
                filterMin = productPriceMin;
            }
            else
            {
                decimal value = Convert.ToDecimal(minPriceTextBox.Text);
                if (value < productPriceMin)
                {
                    value = productPriceMin;
                }
                if (filterMax < value)
                {
                    value = filterMax;
                }
                filterMin = value;
            }
            showFilter();
            minPriceTextBox.Text = filterMin.ToString();
        }

        private void setMaxFilter()
        {
            if (maxPriceTextBox.Text == "")
            {
                filterMax = productPriceMax;
            }
            else
            {
                decimal value = Convert.ToDecimal(maxPriceTextBox.Text);
                if (value > productPriceMax)
                {
                    value = productPriceMax;
                }
                if (filterMin > value)
                {
                    value = filterMin;
                }
                filterMax = value;
            }
            showFilter();
            maxPriceTextBox.Text = filterMax.ToString();
        }

        private void showFilter()
        {
            if (producerComboBox.SelectedIndex > 0)
            {
                categoriesList.Items.Clear();
                foreach (Product p in productList.Where(x => x.Producer == producerComboBox.SelectedItem.ToString() && x.Price >= filterMin && x.Price <= filterMax))
                {
                    var item = categoriesList.Items.Add(p.Name);
                    item.SubItems.Add(p.Producer);
                    item.SubItems.Add(p.Price.ToString("F"));
                    item.SubItems.Add(p.Quantity.ToString());
                    item.SubItems.Add(p.Measures);
                }
            }
            else
            {
                categoriesList.Items.Clear();
                foreach (Product p in productList.Where(x => x.Price >= filterMin && x.Price <= filterMax))
                {
                    var item = categoriesList.Items.Add(p.Name);
                    item.SubItems.Add(p.Producer);
                    item.SubItems.Add(p.Price.ToString("F"));
                    item.SubItems.Add(p.Quantity.ToString());
                    item.SubItems.Add(p.Measures);
                }
            }
        }

        private void minPriceTextBox_Leave(object sender, EventArgs e)
        {
            setMinFilter();
        }

        private void maxPriceTextBox_Leave(object sender, EventArgs e)
        {
            setMaxFilter();
        }

        private void minPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                setMinFilter();
            }
        }

        private void maxPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                setMaxFilter();
            }
        }
    }
}