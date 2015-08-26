using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KPrint
{
    public static class PublicDB
    {

        //todo 后期可以用存储过程实现


        /// <summary>
        /// 取得指定日期的流水号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static int GetDailyCount(DateTime dt)
        {
            var formatdt = dt.ToString("yyMM");
            int r = 0;
            using (var db = PublicDB.getDB())
            {
                var q = (from a in db.rt_daily_count
                         where a.formatdt == formatdt
                         select a.count).FirstOrDefault();
                r = q;
            }
            return r;
        }

        public static int GetDailyCount(DateTime dt,Guid guid)
        {
            var formatdt = dt.ToString("yyMM")+guid.ToString();
            int r = 0;
            using (var db = PublicDB.getDB())
            {
                var q = (from a in db.rt_daily_count
                         where a.formatdt == formatdt
                         select a.count).FirstOrDefault();
                r = q;
            }
            return r;
        }
        /// <summary>
        /// 为指定日期的流水号增加1
        /// </summary>
        /// <param name="dt"></param>
        public static void AddDailyCount(DateTime dt)
        {
            var formatdt = dt.ToString("yyMM");
            using (var db = PublicDB.getDB())
            {
                rt_daily_count dc = new rt_daily_count();
                var q = (from a in db.rt_daily_count
                         where a.formatdt == formatdt
                         select a).FirstOrDefault();
                if (q == null)
                {
                    dc.count_date = dt;
                    dc.id = Guid.NewGuid();
                    dc.count = 1;
                    dc.formatdt = dt.ToString("yyMM");
                    db.rt_daily_count.Add(dc);
                    db.Entry(dc).State = System.Data.Entity.EntityState.Added;
                }
                else
                {

                    q.count++;
                    q.count_date = dt;
                    q.formatdt = dt.ToString("yyMM");
                    db.Entry(q).State = System.Data.Entity.EntityState.Modified;

                }
                db.SaveChanges();
            }
        }

        public static void AddDailyCount(DateTime dt,Guid guid)
        {
            var formatdt = dt.ToString("yyMM") + guid.ToString();
            using (var db = PublicDB.getDB())
            {
                rt_daily_count dc = new rt_daily_count();
                var q = (from a in db.rt_daily_count
                         where a.formatdt == formatdt
                         select a).FirstOrDefault();
                if (q == null)
                {
                    dc.count_date = dt;
                    dc.id = Guid.NewGuid();
                    dc.count = 1;
                    dc.formatdt = formatdt;
                    db.rt_daily_count.Add(dc);
                    db.Entry(dc).State = System.Data.Entity.EntityState.Added;
                }
                else
                {

                    q.count++;
                    q.count_date = dt;
                    q.formatdt = formatdt;
                    db.Entry(q).State = System.Data.Entity.EntityState.Modified;

                }
                db.SaveChanges();
            }
        }

        public static DB getDB(int timeOut)
        {
            /*
            if (!System.IO.File.Exists("config.ini"))
            {
                FDatabase m = new FDatabase();
                m.ShowDialog();
            }*/

            var db = new DB();
            db.Database.Connection.ConnectionString = getIniConn("config.ini", timeOut);
            db.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
            return db;
        }

        public static DB getDB()
        {
          return  getDB(60);
        }

        public static bool TestDB(string connString)
        {
            bool r = false;
            using (var db = new  DB())
            {
                db.Database.Connection.ConnectionString = connString;
                try
                {
                    db.Database.Connection.Open();
                    r = (db.Database.Connection.State == ConnectionState.Open);
                }
                catch(Exception ee)
                {
                    System.Windows.Forms.MessageBox.Show(ee.Message);
                    r = false;
                }
            }
            return r;
        }

        public static string getIniConn(string iniPath,int timeOut)
        {
            INIClass iniClass = new INIClass( iniPath);
            string connString = "";
            if (iniClass.ExistINIFile())
            {

                string Server = EncAndDec.Decode(iniClass.IniReadValue("Database", "server"));
                string dataBase = EncAndDec.Decode(iniClass.IniReadValue("Database", "database"));
                string user = EncAndDec.Decode(iniClass.IniReadValue("Database", "user"));
                string pwd = EncAndDec.Decode(iniClass.IniReadValue("Database", "password"));
                connString = string.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework;Connection Timeout={4};", Server, dataBase, user, pwd,timeOut);

            }
            return connString;
        }

        public static string getIniConnInfo(string iniPath)
        {
            INIClass iniClass = new INIClass(iniPath);
            string coninfo = "";
            if (iniClass.ExistINIFile())
            {

                string Server = EncAndDec.Decode(iniClass.IniReadValue("Database", "server"));
                string dataBase = EncAndDec.Decode(iniClass.IniReadValue("Database", "database"));
                coninfo = string.Format("{0} {1}", Server, dataBase, Server, dataBase);

            }
            return coninfo;
        }

        
    }
}
