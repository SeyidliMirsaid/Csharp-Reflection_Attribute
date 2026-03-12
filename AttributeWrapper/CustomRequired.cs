using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Attribute_06_16_25.AttributeWrapper
{
    [AttributeUsage
        (AttributeTargets.Class| AttributeTargets.Property | AttributeTargets.Method, 
        AllowMultiple = true , Inherited = true) ]
    public class CustomRequired : Attribute
    {
        public string _color { get; set; }
        public CustomRequired(string color)
        {
            this._color = _color;
        }

        public CustomRequired() {}
    }
}
