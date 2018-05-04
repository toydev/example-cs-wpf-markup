using System;
using System.Windows.Markup;

namespace NamedParameters
{
    public class NamedParametersExtension : MarkupExtension
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return (Value1 + Value2).ToString();
        }
    }
}
