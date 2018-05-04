using System;
using System.Windows.Markup;

namespace HelloWorld
{
    public class HelloWorldExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return "Hello Markup World.";
        }
    }
}
