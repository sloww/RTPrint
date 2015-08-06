using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            PublicTools.RecoverColumnWidth(dataGridView1, "FPrintDGV.config");


        }

        private void FPrintLIst_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, "FPrintDGV.config");
        }


        private List<rt_print_log> GetPintObjs()
        {
            List<rt_print_log> pintObjs = new List<rt_print_log>();
            string partno = txbPartNo.Text.Trim();
            string name = txbName.Text.Trim();
            string model = txbModel.Text.Trim();
            string remark = cbbRemark.Text.Trim();
            string pDate = txbDT.Text.Trim();
            DateTime dt = DateTime.Now;
            if (DateTime.TryParse(pDate, out dt))
            {
                pDate = dt.ToString("yyyyMMdd");
            }
            else
            {
                pDate = "";
            }

            using (var db = PublicDB.getDB())
            {
                var q = from a in db.rt_print_log
                        where a.deleted == 0 && a.part_No.Contains(partno) && a.name.Contains(name) && a.model.Contains(model) && a.remark.Contains(remark) &&a.formatPDate.Contains(pDate)
                        orderby a.create_time
                        select a;
                if (q != null)
                {
                    pintObjs = q.ToList();
                }

            }
            return pintObjs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetPintObjs();
            PublicTools.RecountRowsNum(dataGridView1);

        }


            private void btnExport_Click(object sender, EventArgs e)
        {
            List<rt_print_log> q = GetPintObjs();

            if (q.Count == 0) return;

            string excelPath = Application.StartupPath + @"\\记录导出模板.xls";
            string copedExcelPath = string.Format("{0}\\{1}{2}", Application.StartupPath, DateTime.Now.ToString("MMddHHmmss"), ".xls");
            if (File.Exists(excelPath))
            {
                File.Copy(excelPath, copedExcelPath, true);
            }
            else
            {
                MessageBox.Show("未发现程序目录下面的记录导出模板，请手工添加");
            }

            if (File.Exists(copedExcelPath) == false)
            {
                MessageBox.Show("拷贝记录导出模板失败，导出作业中断");

                return;
            }


            IWorkbook wb = WorkbookFactory.Create(copedExcelPath);

            //第1页
            ISheet ist = wb.GetSheetAt(0);

            for (int i = 0; i < q.Count; i++)
            {
                IRow irow = ist.CreateRow(i + 1);
                ICell icell0 = irow.CreateCell(0);
                icell0.SetCellValue((i+1).ToString());
                ICell icell1 = irow.CreateCell(1);
                icell1.SetCellValue(q[i].create_time.ToString("yyyy-MM-dd HH:mm:ss"));
                ICell icell2 = irow.CreateCell(2);
                icell2.SetCellValue(q[i].part_No);
                ICell icell3 = irow.CreateCell(3);
                icell3.SetCellValue(q[i].name);
                ICell icell4 = irow.CreateCell(4);
                icell4.SetCellValue(q[i].model);
                ICell icell5 = irow.CreateCell(5);
                icell5.SetCellValue(q[i].capacity.ToString());
                ICell icell6 = irow.CreateCell(6);
                icell6.SetCellValue(q[i].container_No);
                ICell icell7 = irow.CreateCell(7);
                icell7.SetCellValue(q[i].remark);
                ICell icell8 = irow.CreateCell(8);
                icell8.SetCellValue(q[i].production_date.ToShortDateString());
                ICell icell9 = irow.CreateCell(9);
                icell9.SetCellValue(q[i].printCount.ToString());
                ICell icell10 = irow.CreateCell(10);
                icell10.SetCellValue(q[i].formatSN);

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

            private void txbDT_Click(object sender, EventArgs e)
            {
                FDateTime FDT = new FDateTime();

                FDT.Location = PublicTools.local(txbDT);
                FDT.ShowDialog();
                txbDT.Text = FDateTime.DateTimeSelect.ToShortDateString();
            }
        
    }
}
