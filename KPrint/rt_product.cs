//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPrint
{
    using System;
    using System.Collections.Generic;
    
    public partial class rt_product
    {
        public System.Guid id { get; set; }
        public string part_No { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int capacity { get; set; }
        public Nullable<System.Guid> img_id { get; set; }
        public string remark { get; set; }
        public int deleted { get; set; }
        public System.DateTime modify_time { get; set; }
        public byte[] img { get; set; }
    }
}
