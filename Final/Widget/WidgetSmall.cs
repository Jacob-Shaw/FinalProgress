using System;

namespace Widget
{
    public class WidgetSmall : WidgetAbstract
    {
        public override string Name { get; } = "Small Widget";
        public override int NumOfGears { get; set; } = 2;
        public override int NumOfSprings { get; set; } = 3;
        public override int NumOfLevers { get; set; } = 1;
    }
}
