using System;
using System.Collections.Generic;
using System.Text;

namespace LearningViaCS.Domain.Model
{
    public class Announmt
    {
        //"ANNOUNMTID": 3175577,
        //            "ANNOUNMT2": "关于N沪环境（601200）盘中临时停牌的公告",
        //            "PUBLISHDATE":
        public int AnnounmtId { get; set; }

        public string Announmt2 { get; set; }

        public PublishDate PublishDate { get; set; }
    }
}
