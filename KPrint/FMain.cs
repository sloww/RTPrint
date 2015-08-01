using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPrint
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                var query = from q in db.rt_product
                            where q.deleted == 0
                            select q;
                if (query != null)
                {
                    bdsProduct.DataSource = query.ToArray();
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                rt_product p = new rt_product();
                p.id = System.Guid.NewGuid();
                p.part_No = txbPart_No.Text;
                p.model = txbModel.Text;
                p.name = txbName.Text;
                p.capacity = int.Parse(txbCapacity.Text);
                p.modify_time = DateTime.Now;
                p.deleted = 0;
                p.remark = "量产";
                db.rt_product.Add(p);
                db.SaveChanges();
            }

        }
    }
}
