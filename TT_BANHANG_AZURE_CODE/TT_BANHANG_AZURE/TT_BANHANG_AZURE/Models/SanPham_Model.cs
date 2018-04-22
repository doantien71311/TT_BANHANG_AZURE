using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TT_BANHANG_AZURE.Models
{
    public class SanPham_Model
    {
        public System.Guid SP_ID { get; set; }
        public Nullable<System.Guid> MN_ID { get; set; }
        public string SP_MA { get; set; }
        public string SP_TEN { get; set; }
        public string SP_TENTM { get; set; }
        public string SP_DVT { get; set; }
        public string SP_URLANH { get; set; }
        public Nullable<decimal> SP_GIABAN { get; set; }
        public Nullable<int> SP_LUOTXEM { get; set; }
        public string SP_MOTA { get; set; }
        public string SP_DTKT { get; set; }
        public Nullable<System.DateTime> SP_NGAYTAO { get; set; }
        public string SP_NHACC { get; set; }
        public string SP_MAUSAC { get; set; }
        public string SP_URLANH1 { get; set; }
        public string SP_URLANH2 { get; set; }
        public string SP_URLANH3 { get; set; }
        public Nullable<int> SP_STT { get; set; }


    }
}