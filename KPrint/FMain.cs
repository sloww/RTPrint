using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.UserModel;
using System.IO;

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

            using (var db = PublicDB.getDB())
            {
                db.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
                rt_product s = new rt_product();
                s.part_No = txbPartNoForSearch.Text;
                s.name = txbNameForSearch.Text;
                s.model = txbModelForSearch.Text;
                var query = from q in db.rt_product
                            where q.deleted == 0 && (q.part_No.Contains(s.part_No) && q.name.Contains(s.name) && q.model.Contains(s.model))
                            orderby q.modify_time descending
                            select q;
                if (query != null && query.Count()>0)
                {
                    bdsProduct.DataSource = query.ToArray();
                    PublicTools.RecountRowsNum(dataGridView1);
                }
                else
                {
                    bdsProduct.DataSource = new List<rt_product>();

                    MessageBox.Show("没有查到相关记录");
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            btnClear_Click(null, null);
            txbPart_No.Enabled = true;
            txbPart_No.SelectAll();

        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "Image Files(*.JPG;*JPEG;|*.JPG;*JPEG;)";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Image img = Image.FromFile(ofd.FileName);

                if (PublicTools.imageToByteArray(img).Length < 300000)
                {
                    pictureBox1.Image = img;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("图片大小超过300k，不允许保存到数据库");
                }
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, "FMainDGV.config");
            this.LabelDB.Text =string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, "FMainDGV.config");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (bdsProduct.Current != null)
            {
                FPrint fp = new FPrint((rt_product)bdsProduct.Current);
                fp.ShowDialog();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.btnPrint_Click(null, null);
            }
            else
            {
                this.btnEdit_Click(null, null);
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            FPrintLIst m = new FPrintLIst();
            m.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xls file|*.xls";
            ofd.DefaultExt = ".xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImportExcel(ofd.FileName);
            }
            btnSearch_Click(null, null);
        }

        private void ImportExcel(string excelPath)
        {
            try
            {
                IWorkbook wb = WorkbookFactory.Create(excelPath);

                int count = 0;
                ISheet ist = wb.GetSheetAt(0);
                int rowofPage = ist.LastRowNum + 1;
                using (var db = PublicDB.getDB())
                {
                    for (int j = 1; j < rowofPage; j++)
                    {
                        count++;
                        IRow irow = ist.GetRow(j);

                        if (irow == null) continue;

                        string partNo = irow.GetCell(0).StringCellValue;
                        if (partNo.Length < 4) continue;

                        var result = (from a in db.rt_product
                                      where a.part_No.Equals(partNo) && a.deleted == 0
                                      select a).FirstOrDefault();
                        if (result == null)
                        {
                            rt_product p = new rt_product();
                            p.id = Guid.NewGuid();
                            p.part_No = irow.GetCell(0).StringCellValue;
                            p.name = irow.GetCell(1).StringCellValue;
                            p.model = irow.GetCell(2).StringCellValue;
                            p.capacity = (int)irow.GetCell(3).NumericCellValue;
                            p.deleted = 0;
                            p.remark = "";
                            p.modify_time = DateTime.Now;
                            db.rt_product.Add(p);
                        }
                        else
                        {
                            result.name = irow.GetCell(1).StringCellValue;
                            result.name = irow.GetCell(1).StringCellValue;
                            result.model = irow.GetCell(2).StringCellValue;
                            try
                            {
                                result.capacity = (int)irow.GetCell(3).NumericCellValue;
                            }
                            catch
                            {
                                result.capacity = int.Parse(irow.GetCell(3).StringCellValue);
                            }
                            result.deleted = 0;
                            result.remark = "";
                            result.modify_time = DateTime.Now;
                            db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                        }

                    }
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("导入失败");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbPart_No.Text = "";
            txbName.Text = "";
            txbModel.Text = "";
            txbCapacity.Text = "";
            pictureBox1.Image = null;
            txbPart_No.Enabled = false;

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btnClear_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbPart_No.Text.Trim().Length == 0)
            {
                MessageBox.Show("零件编号字段不可为空");
                txbPart_No.Focus();
                txbPart_No.SelectAll();
                return;
            }
            if (txbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品名称字段不可为空");
                txbName.Focus();
                txbName.SelectAll();
                return;
            }

            if (txbModel.Text.Trim().Length == 0)
            {
                MessageBox.Show("车型字段不可为空");
                txbModel.Focus();
                txbModel.SelectAll();
                return;
            }
            if (txbCapacity.Text.Trim().Length ==0)
            {
                MessageBox.Show("收容数字段不可为空");
                txbCapacity.SelectAll();
                txbCapacity.Focus();
                return;
            }

            using (var db = PublicDB.getDB())
            {

                rt_product p = new rt_product();
                p.part_No = txbPart_No.Text;
                p.model = txbModel.Text;
                p.name = txbName.Text;
                p.capacity = int.Parse(txbCapacity.Text);
                p.modify_time = DateTime.Now;
                p.deleted = 0;

                if (pictureBox1.Image != null)
                {

                    p.img = PublicTools.imageToByteArray(pictureBox1.Image);

                }

                var q = (from a in db.rt_product
                         where a.part_No == p.part_No && a.deleted == 0
                         select a).FirstOrDefault();
                if (q == null)
                {
                    p.id = System.Guid.NewGuid();
                    p.remark = "量产";
                    db.rt_product.Add(p);
                }
                else
                {

                    q.part_No = txbPart_No.Text;
                    q.model = p.model;
                    q.name = p.name;
                    q.capacity = p.capacity;
                    q.modify_time = DateTime.Now;
                    q.deleted = 0;
                    q.remark = p.remark;
                    q.img = p.img;
                    db.Entry(q).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
            btnClear_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.bdsProduct.DataSource != null && this.bdsProduct.Current != null)
            {
                using (var db = PublicDB.getDB())
                {
                    rt_product p = (rt_product)this.bdsProduct.Current;
                    p.deleted = 1;
                    db.rt_product.Attach(p);
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                this.btnClear_Click(null, null);
                btnSearch_Click(null, null);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rt_product product = (rt_product)bdsProduct.Current;
            if (product != null)
            {
                txbPart_No.Text = product.part_No;
                txbName.Text = product.name;
                txbModel.Text = product.model;
                txbCapacity.Text = product.capacity.ToString();
                if (product.img != null)
                {
                    pictureBox1.Image = PublicTools.byteArrayToImage(product.img);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<rt_product> q = new List<rt_product>();
            using (var db = PublicDB.getDB())
            {

                rt_product s = new rt_product();
                s.part_No = txbPartNoForSearch.Text;
                s.name = txbNameForSearch.Text;
                s.model = txbModelForSearch.Text;
                var query = from item in db.rt_product
                            where item.deleted == 0 && (item.part_No.Contains(s.part_No) && item.name.Contains(s.name) && item.model.Contains(s.model))
                            select item;
                if (query != null)
                {
                    q= query.ToList();
                }


            }


            string excelPath = Application.StartupPath + @"\\导出模板.xls";
            string copedExcelPath = string.Format("{0}\\{1}{2}", Application.StartupPath, DateTime.Now.ToString("MMddHHmmss"), ".xls");
            if (File.Exists(excelPath))
            {
                File.Copy(excelPath, copedExcelPath, true);
            }
            if (File.Exists(copedExcelPath) == false)
            {
                return;
            }

            IWorkbook wb = WorkbookFactory.Create(copedExcelPath);

            //第1页
            ISheet ist = wb.GetSheetAt(0);

            for (int i = 0; i < q.Count; i++)
            {
                IRow irow = ist.CreateRow(i + 1);
                ICell icell0 = irow.CreateCell(0);
                icell0.SetCellValue(q[i].part_No);
                ICell icell1 = irow.CreateCell(1);
                icell1.SetCellValue(q[i].name);
                ICell icell2 = irow.CreateCell(2);
                icell2.SetCellValue(q[i].model);
                ICell icell3 = irow.CreateCell(3);
                icell3.SetCellValue(q[i].capacity.ToString());

            }
            foreach (var item in q)
            {

                using (FileStream fs = new FileStream(copedExcelPath, FileMode.Open))
                {

                    wb.Write(fs);
                }
            }

            System.Diagnostics.Process.Start(copedExcelPath);
        }

        private void LabelDB_Click(object sender, EventArgs e)
        {
            FDatabase m = new FDatabase();
            m.ShowDialog();
            this.LabelDB.Text = string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));

        }

        private void txbModelForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( Char.IsLetterOrDigit(e.KeyChar) ||Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbModelForSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

    }
}
