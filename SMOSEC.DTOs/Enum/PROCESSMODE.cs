using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.DTOs.Enum
{
    /// <summary>
    /// 枚举类，表示操作类型
    /// </summary>
    public enum PROCESSMODE
    {
        修改内容= 0,
        领用=1,
        退库=2,
        借用=3,
        归还=4,
        调拨=5,
        报修=6,
        清理报废=7,
        入库=8,
        出库=9,
        调拨确认=10,
        调拨取消=11,
        维修完毕=12,
        报废还原=13,
        使用人变更=14
    }
}
