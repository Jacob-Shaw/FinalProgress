using System;
using System.Collections.Generic;
using System.Text;
using FINAL;

namespace Widget
{
    public class WidgetMedium : WidgetAbstract
    {
        public override string Name { get; } = "Medium Widget";
        public override int NumOfGears { get; set; } = 4;
        public override int NumOfSprings { get; set; } = 5;
        public override int NumOfLevers { get; set; } = 3;
    }
}
