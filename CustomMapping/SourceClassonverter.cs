using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMapping
{
    public class SourceClassonverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(TargetClass);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            var concreteValue = (SourceClass)value;
            var result = new TargetClass
            {
              FullName = string.Format("{0} {1}", concreteValue.FirstName, concreteValue.LastName)
            };
            return result;
        }
    }
}
