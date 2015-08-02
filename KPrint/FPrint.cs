using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            PrintDocument pd = new PrintDocument();
            rt_print_log printObj = new rt_print_log();
            printObj.model = this.product.model;
            printObj.part_No = this.product.part_No;
            pd.PrintPage += (sender2, args) => DrawPaper(printObj, args.Graphics);
            pd.Print();
        }



        private void DrawPaper(rt_print_log printObj,Graphics g)
        {
            Point location = new Point(10, 10);
            g.PageUnit = GraphicsUnit.Millimeter;
            Pen p = new Pen(Brushes.Black, 0.3f);
            g.DrawRectangle(p, new Rectangle(location, new Size(190, 84)));
            g.DrawLine(p,new Point(location.X,location.Y+38),new Point(location.X+162,location.Y+38));
            g.DrawLine(p,new Point(location.X+32,location.Y),new Point(location.X+32,location.Y+38));
            g.DrawLine(p,new Point(location.X+32,location.Y),new Point(location.X+32,location.Y+38));
            g.DrawLine(p,new Point(location.X+162,location.Y),new Point(location.X+162,location.Y+38));
            g.DrawLine(p,new Point(location.X+162,location.Y),new Point(location.X+162,location.Y+84));
            g.DrawLine(p,new Point(location.X+162,location.Y+21),new Point(location.X+190,location.Y+21));
            g.DrawLine(p,new Point(location.X+48,location.Y+38),new Point(location.X+48,location.Y+84));
            g.DrawLine(p,new Point(location.X+88,location.Y+38),new Point(location.X+88,location.Y+84));

            g.DrawLine(p,new Point(location.X,location.Y+56),new Point(location.X+88,location.Y+56));
            g.DrawLine(p,new Point(location.X,location.Y+66),new Point(location.X+48,location.Y+66));
            g.DrawLine(p,new Point(location.X,location.Y+76),new Point(location.X+48,location.Y+76));

            g.DrawLine(p,new Point(location.X+88,location.Y+48),new Point(location.X+162,location.Y+48));

            g.DrawLine(p,new Point(location.X+162,location.Y+21),new Point(location.X+190,location.Y+21));
            g.DrawLine(p,new Point(location.X+162,location.Y+42),new Point(location.X+190,location.Y+42));
            g.DrawLine(p,new Point(location.X+162,location.Y+63),new Point(location.X+190,location.Y+63));

            //font set
            Font smallFont = new Font("SimSun", 8);
            Font largeFont = new Font("Arial", 36);

            //draw model cell

            Point cursor = location;
            g.DrawString("车型", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString(printObj.model, largeFont, Brushes.Black,new Point(cursor.X+5,cursor.Y+10));

            //draw part No. cell
            cursor = new Point(location.X + 32, location.Y);
            g.DrawString("零件编号", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            g.DrawString("武汉日特固特防音配件有限公司 产品标示卡", smallFont, Brushes.Black, new Point(cursor.X + 32, cursor.Y+1));
            g.DrawString(printObj.part_No, largeFont, Brushes.Black, new Point(cursor.X + 8, cursor.Y + 10));

            //draw operator cell
            cursor = new Point(location.X + 162, location.Y);
            g.DrawString("作业者", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
            //draw check cell
            cursor = new Point(location.X + 162, location.Y+21);
            g.DrawString("一次检验", smallFont, Brushes.Black, new Point(cursor.X + 1, cursor.Y + 1));
        }



        private void FPrint_Load(object sender, EventArgs e)
        {

        }

    }
}
