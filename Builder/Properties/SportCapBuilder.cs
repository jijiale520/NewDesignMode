﻿using System;

namespace Builder.Properties
{
    public class SportCapBuilder : Builder
    {
        public override void BuildCap(string _cap)
        {
            cap.SetCap(_cap);
            Console.WriteLine("生产运动水杯盖");
        }

        public override void BuildCapBody(string _capBody)
        {
            cap.SetCapBody(_capBody);
            Console.WriteLine("生产运动水杯杯体");
        }

        public override void BuildString(string _string)
        {
            cap.SetString(_string);
            Console.WriteLine("生产运动水杯绳子");
        }
    }
}