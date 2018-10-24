using System;
using System.Collections.Generic;
using System.Text;

namespace Widget
{
    public class WidgetLarge : WidgetAbstract
    {
        public override string Name { get; } = "Large Widget";
        public override int NumOfGears { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers { get; set; } = 2;
    }
}
