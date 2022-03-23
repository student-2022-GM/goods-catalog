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
        public Products()
        {
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

            db.SaveChanges();
            MessageBox.Show("Good initialization", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = db.Categories.ToList();
            listBox1.DisplayMember = "Name";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = (listBox1.SelectedItem as Category).Id;
            var res = db.Products.Where(p => p.Category.Id == cid).ToList();

            categoriesList.Items.Clear();
            foreach (Product p in res)
            {
                var item = categoriesList.Items.Add(p.Name);
                item.SubItems.Add(p.Producer);
                item.SubItems.Add(p.Price.ToString("F"));
                item.SubItems.Add(p.Quantity.ToString());
                item.SubItems.Add(p.Measures);
            }
        }
    }
}