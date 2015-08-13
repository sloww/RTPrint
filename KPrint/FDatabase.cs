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
    public partial class FDatabase : Form
    {
        public FDatabase()
        {
            InitializeComponent();
        }

        private void FDatabase_Load(object sender, EventArgs e)
        {
            INIClass iniClass = new INIClass("config.ini");
            if (iniClass.ExistINIFile())
            {
                txbDBIP.Text = EncAndDec.Decode(iniClass.IniReadValue("Database", "server"));
                txbDBName.Text = EncAndDec.Decode(iniClass.IniReadValue("Database", "database"));
                txbUserName.Text = EncAndDec.Decode(iniClass.IniReadValue("Database", "user"));
                txbPassword.Text = EncAndDec.Decode(iniClass.IniReadValue("Database", "password"));
            }


            txbDBIP_TextChanged(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string server = txbDBIP.Text.Trim();
            string db = txbDBName.Text.Trim();
            string user = txbUserName.Text.Trim();
            string pwd = txbPassword.Text.Trim();

            if (server.Length > 0 && db.Length > 0 && user.Length > 0 && pwd.Length > 0)
            {
                INIClass iniClass = new INIClass("config.ini");
                iniClass.IniWriteValue("Database", "server", EncAndDec.Encode(server));
                iniClass.IniWriteValue("Database", "database", EncAndDec.Encode(db));
                iniClass.IniWriteValue("Database", "user", EncAndDec.Encode(user));
                iniClass.IniWriteValue("Database", "password", EncAndDec.Encode(pwd));
                this.Close();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connString = string.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework;Connection Timeout=5;", txbDBIP.Text, txbDBName.Text, txbUserName.Text, txbPassword.Text);

            if (PublicDB.TestDB(connString))
            {
                MessageBox.Show("连接数据库成功");
            }
            else
            {
                MessageBox.Show("连接数据失败");

            }
        }

        private void txbDBIP_TextChanged(object sender, EventArgs e)
        {

            if (txbDBIP.Text.Trim().Length > 0 && txbDBName.Text.Trim().Length > 0 && txbPassword.Text.Trim().Length > 0 && txbUserName.Text.Trim().Length > 0)
            {
                btnTest.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                btnTest.Enabled = false;
                btnSave.Enabled = false;
            }
        }
    }
}
