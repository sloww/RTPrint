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
    public partial class FPrintLIst : Form
    {
        public FPrintLIst()
        {
            InitializeComponent();
        }

        private void PrintLIst_Load(object sender, EventArgs e)
        {

            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, KPrint.Properties.Settings.Default.productDatagridview);


        }

        private void FPrintLIst_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, KPrint.Properties.Settings.Default.productDatagridview);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string partno = txbPartNo.Text.Trim();
            string name = txbName.Text.Trim();
            string model = txbModel.Text.Trim();
            
            using (var db = new DB())
            {
                var q = from a in db.rt_print_log
                        where a.deleted == 0 && a.part_No.Contains(partno) && a.name.Contains(name) && a.model.Contains(model)
                        orderby a.create_time
                        select a;
                if (q != null)
                {
                    bindingSource1.DataSource = q.ToList();
                }

            }
            PublicTools.RecountRowsNum(dataGridView1);

        }
    }
}
