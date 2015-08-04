using System;
using System.Collections.Generic;
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
            var formatdt = dt.ToString("yyyyMMdd");
            int r = 0;
            using (var db = new DB())
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
            var formatdt = dt.ToString("yyyyMMdd");
            using (var db = new DB())
            {
                rt_daily_count dc = new rt_daily_count();
                dc.formatdt = DateTime.Now.ToString("yyyyMMdd");
                var q = (from a in db.rt_daily_count
                         where a.formatdt == formatdt
                         select a).FirstOrDefault();
                if (q == null)
                {
                    dc.count_date = DateTime.Now;
                    dc.id = Guid.NewGuid();
                    dc.count = 1;
                    db.rt_daily_count.Add(dc);
                    db.Entry(dc).State = System.Data.Entity.EntityState.Added;
                }
                else
                {

                    q.count++;
                    q.count_date = DateTime.Now;
                    //db.rt_daily_count.Attach(q);
                    db.Entry(q).State = System.Data.Entity.EntityState.Modified;

                }
                db.SaveChanges();
            }
        }
    }
}
