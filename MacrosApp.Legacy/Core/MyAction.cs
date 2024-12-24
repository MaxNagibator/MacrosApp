using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacrosApp.Core
{
    public abstract class MyAction
    {
        public double Delay { get; set; }
        public int Count { get; set; }
        public abstract string TypeText { get; }
    }

    public class MouseAction : MyAction
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MouseButtons Button { get; set; }
        public override string TypeText => "M";
    }

    public class KeyboardAction : MyAction
    {
        public Keys Key { get; internal set; }
        public int KeyValue { get; internal set; }
        public override string TypeText => "K";
    }
}
