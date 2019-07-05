using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSheetPDF
{
    class ClassInstrument
    {
        public String ShortName { get; set; }       // 略称
        public String FullName { get; set; }        // 正式名称
        public bool SheetWriteFlg { get; set; }     // 帳票表示フラグ
        public int Order { get; set; }              // 表示順
    }
}
