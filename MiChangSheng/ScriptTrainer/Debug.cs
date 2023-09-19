using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptTrainer
{
    public static class Debug
    {
        public static void Tip(string msg)
        {
            UIPopTip.Inst.Pop(msg, PopTipIconType.叹号);
        }
        public static void Add(string msg)
        {
            UIPopTip.Inst.Pop(msg, PopTipIconType.上箭头);
        }
        public static void Success(string msg)
        {
            UIPopTip.Inst.Pop(msg, PopTipIconType.任务完成);
        }
        public static void Package(string msg)
        {
            UIPopTip.Inst.Pop(msg, PopTipIconType.包裹);
        }
    }
}
