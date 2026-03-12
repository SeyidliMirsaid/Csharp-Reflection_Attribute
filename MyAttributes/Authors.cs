using System;

namespace Reflection_Attribute_Homework_06_16_25.MyAttributes
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Method |
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = true)]
    public class Authors : Attribute
    {
        public string text { get; }
        public Authors() { }
        public Authors(string Text)
        {
            text = Text;
        }
    }
}
