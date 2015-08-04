using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace KPrint
{
    public partial class FPrint : Form
    {
        private rt_product product = new rt_product();
        public FPrint()
        {
            InitializeComponent();
        }

        public FPrint(rt_product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int printCount = 0;
            if (int.TryParse(txbCount.Text, out printCount) && printCount > 0)
            {
                PrintDocument pd = new PrintDocument();
                List<rt_print_log> printObjs = new List<rt_print_log>();
                pd.PrintPage += (sender2, args) => DrawPaper(printObjs, args.Graphics);

                using (var db = new DB())
                {
                    var img = (from i in db.rt_img
                               where i.id == this.product.img_id
                               select i).FirstOrDefault();
                    if (img != null)
                    {
                        this.product.img = img.img;
                    }
                }

                for(int i=0;i<printCount;i++)
                {
                    rt_print_log printObj = new rt_print_log();
                    printObj.model = this.product.model;
                    printObj.part_No = this.product.part_No;
                    printObj.id = Guid.NewGuid();
                    printObj.name = this.product.name;
                    printObj.capacity = this.product.capacity;
                    printObj.img_id = this.product.img_id;
                    printObj.img = this.product.img;
                    printObj.production_date = dateTimePicker1.Value;
                    printObj.qr = product.part_No + "099" + "201508050000";
                    printObj.remark = "量产";
                    printObj.deleted = 0;
                    printObj.create_time = DateTime.Now;
                    printObj.container_No = i + 1;
                    printObjs.Add(printObj);

                    if (i + 1 == printCount || i%3==2)
                    {
                        pd.Print();
                        printObjs.Clear();
                    }
                    
                }
            }
        }





        private void DrawPaper(List<rt_print_log> printObjs, Graphics g)
        {
            for (int i = 0; i < printObjs.Count; i++)
            {
                this.DrawSingle(printObjs[i], g, i * 94);
            }

        }

        private void DrawSingle(rt_print_log printObj, Graphics g,int yoffset)
        {


            Point location = new Point(10, 10+yoffset);
            g.PageUnit = GraphicsUnit.Millimeter;
            Pen p = new Pen(Brushes.Black, 0.3f);
            g.DrawRectangle(p, new Rectangle(location, new Size(190, 84)));

            g.DrawLine(p, new Point(location.X, location.Y + 28), new Point(location.X + 162, location.Y + 28));

            g.DrawLine(p, new Point(location.X + 32, location.Y), new Point(location.X + 32, location.Y + 28));

            g.DrawLine(p, new Point(location.X + 162, location.Y), new Point(location.X + 162, location.Y + 84));

            g.DrawLine(p, new Point(location.X + 48, location.Y + 28), new Point(location.X + 48, location.Y + 84));
            g.DrawLine(p, new Point(location.X + 88, location.Y + 28), new Point(location.X + 88, location.Y + 84));

            g.DrawLine(p, new Point(location.X, location.Y + 46), new Point(location.X + 88, location.Y + 46));
            g.DrawLine(p, new Point(location.X, location.Y + 56), new Point(location.X + 48, location.Y + 56));
            g.DrawLine(p, new Point(location.X, location.Y + 66), new Point(location.X + 48, location.Y + 66));

            g.DrawLine(p, new Point(location.X + 88, location.Y + 38), new Point(location.X + 162, location.Y + 38));

            g.DrawLine(p, new Point(location.X + 162, location.Y + 21), new Point(location.X + 190, location.Y + 21));
            g.DrawLine(p, new Point(location.X + 162, location.Y + 42), new Point(location.X + 190, location.Y + 42));
            g.DrawLine(p, new Point(location.X + 162, location.Y + 63), new Point(location.X + 190, location.Y + 63));

            //font set
            Font smallFont = new Font("SimSun", 8);
            Font largeFont = new Font("Arial", 36);
            Font middleFont = new Font("SimHei", 14);

            //draw model cell
            Point cursor = location;
            g.DrawString("车型", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.model, largeFont, Brushes.Black, new Point(cursor.X + 3, cursor.Y + 10));

            //draw part No. cell
            cursor = new Point(location.X + 32, location.Y);
            g.DrawString("零件编号", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString("武汉日特固特防音配件有限公司 产品标示卡", smallFont, Brushes.Black, new Point(cursor.X + 32, cursor.Y + 1));
            g.DrawString(printObj.part_No, largeFont, Brushes.Black, new Point(cursor.X + 6, cursor.Y + 10));

            //draw operator cell
            cursor = new Point(location.X + 162, location.Y);
            g.DrawString("作业者", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));

            //draw first check cell
            cursor = new Point(location.X + 162, location.Y + 21);
            g.DrawString("一次检验", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString("合", middleFont, Brushes.Black, new Point(cursor.X + 2, cursor.Y + 5));
            g.DrawString("格", middleFont, Brushes.Black, new Point(cursor.X + 2, cursor.Y + 15));


            //draw  check cell
            cursor = new Point(location.X + 162, location.Y + 42);
            g.DrawString("最终检验", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString("合", middleFont, Brushes.Black, new Point(cursor.X + 2, cursor.Y + 5));
            g.DrawString("格", middleFont, Brushes.Black, new Point(cursor.X + 2, cursor.Y + 15));

            //draw Warehouse Manager cell
            cursor = new Point(location.X + 162, location.Y + 63);
            g.DrawString("仓库管理员", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));

            //draw SNP cell
            cursor = new Point(location.X + 1, location.Y + 28);
            g.DrawString("收容数(SNP)", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.capacity.ToString(), largeFont, Brushes.Black, new Point(cursor.X + 20, cursor.Y + 4));

            //draw production date cell
            cursor = new Point(location.X + 1, location.Y + 46);
            g.DrawString("生产日期", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.production_date.ToString(@"yyyy/MM/dd"), new Font("SimHei", 18), Brushes.Black, new Point(cursor.X + 11, cursor.Y + 4));

            //draw Production batch cell
            cursor = new Point(location.X + 1, location.Y + 56);
            g.DrawString("生产批号", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));

            //draw remark cell
            cursor = new Point(location.X + 1, location.Y + 66);
            g.DrawString("备注", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.remark, new Font ("SimSun",28), Brushes.Black, new Point(cursor.X + 9, cursor.Y + 4));

            //draw Container No. cell
            cursor = new Point(location.X + 48, location.Y + 28);
            g.DrawString("容器序号", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.container_No.ToString(), new Font("Arial", 28), Brushes.Black, new Point(cursor.X + 8, cursor.Y + 6));
            g.DrawArc(p, new Rectangle(new Point(cursor.X + 7, cursor.Y + 5), new Size(11, 11)), 0, 360);


            //draw QR cell
            cursor = new Point(location.X + 48, location.Y + 46);
            //g.DrawString("QR码占位符", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            Bitmap bimg = PublicTools.CreateQRCode(printObj.qr);
            g.DrawImage(bimg, new Point(cursor.X + 1, cursor.Y + 1));


            //draw production name cell
            cursor = new Point(location.X + 88, location.Y + 28);
            g.DrawString("产品名称", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.name, new Font("SimHei", 14), Brushes.Black, new Point(cursor.X + 6, cursor.Y + 5));

            //draw img cell
            cursor = new Point(location.X + 88, location.Y + 38);
            g.DrawString("简图", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));

            //get img 

            System.Drawing.Image img = PublicTools.byteArrayToImage(printObj.img);
            g.DrawImage(img, cursor.X + 1, cursor.Y + 10, 70, 36);

        }

        private void FPrint_Load(object sender, EventArgs e)
        {

        }

    }
}
