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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var ent =new KPrint.Entities()){
             var chanpins = from cp in  ent.chanpin
                            select cp;
             dataGridView1.DataSource = chanpins.ToList();

             }
            addno(dataGridView1);

        }

        private void addno(DataGridView dgv)
        {
            int rows = dgv.RowCount;

            for (int i = 0; i < rows; i++)
            {
                dgv[0, i].Value = i+1;
                dgv[7, i].Value = "编辑";
                dgv[8, i].Value = "删除";

            }
        }
    }
}
