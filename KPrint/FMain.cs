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
                rt_product s = new rt_product();
                s.part_No =txbPartNoForSearch.Text;
                s.name = txbNameForSearch.Text;
                s.model = txbModelForSearch.Text;
                var query = from q in db.rt_product
                            where q.deleted == 0 &&(q.part_No.Contains(s.part_No) && q.name.Contains(s.name) && q.model.Contains(s.model))
                            select q;
                if (query != null)
                {
                    bdsProduct.DataSource = query.ToArray();
                    PublicTools.RecountRowsNum(dataGridView1);
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                rt_img img = new rt_img();
                img.id = Guid.NewGuid();
                img.img = PublicTools.imageToByteArray(pictureBox1.Image);
                img.deleted = 0;
                img.modify_time = DateTime.Now;
                db.rt_img.Add(img);

                db.SaveChanges();


                rt_product p = new rt_product();
                p.id = System.Guid.NewGuid();
                p.part_No = txbPart_No.Text;
                p.model = txbModel.Text;
                p.name = txbName.Text;
                p.capacity = int.Parse(txbCapacity.Text);
                p.modify_time = DateTime.Now;
                p.deleted = 0;
                p.remark = "量产";
                p.img_id = img.id;
                db.rt_product.Add(p);

                db.SaveChanges();
            }

        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "Image Files(*.JPG;*JPEG;|*.JPG;*JPEG;)";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                using (System.IO.FileStream fs = new System.IO.FileStream(ofd.FileName, System.IO.FileMode.Open))
                {
                    int filelength = 0;
                    filelength = (int)fs.Length; //获得文件长度 
                    Byte[] image = new Byte[filelength]; //建立一个字节数组 
                    fs.Read(image, 0, filelength); //按字节流读取 
                    pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, KPrint.Properties.Settings.Default.productDatagridview);
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, KPrint.Properties.Settings.Default.productDatagridview);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (bdsProduct.Current != null)
            {
                FPrint fp = new FPrint((rt_product)bdsProduct.Current);
                fp.ShowDialog();
            }
        }
    }
}
