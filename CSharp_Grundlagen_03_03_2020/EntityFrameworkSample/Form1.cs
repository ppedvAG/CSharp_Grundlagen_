using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdventureWorks2017Context context = new AdventureWorks2017Context();
            dataGridView1.AutoGenerateColumns = true;
            List<Product> resultList = context.Product.Where(n => n.ListPrice > 5).ToList();

            bindingSource1.DataSource = resultList;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                Product selektiertesProduct = (Product)bindingSource1.Current;

                AdventureWorks2017Context context = new AdventureWorks2017Context();
                List<BillOfMaterials> billOfMaterialsList = context.BillOfMaterials.Where(n => n.Product.ProductID == selektiertesProduct.ProductID).ToList();

                if (billOfMaterialsList.Count > 0)
                {
                    bindingSource2.DataSource = billOfMaterialsList;
                    dataGridView2.DataSource = bindingSource2;
                }
                else
                {
                    dataGridView2.DataSource = null;
                }


            }
        }
    }
}
