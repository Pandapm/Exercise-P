//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMLib.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int readerID { get; set; }
        public int bookID { get; set; }
        public System.DateTime lendTime { get; set; }
        public Nullable<System.DateTime> wellTime { get; set; }
        public Nullable<System.DateTime> returnTime { get; set; }
    
        public virtual Reader Reader { get; set; }
    }
}
