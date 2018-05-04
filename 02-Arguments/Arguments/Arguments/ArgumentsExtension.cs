using System;
using System.Windows.Markup;

namespace Arguments
{
    public class ArgumentsExtension : MarkupExtension
    {
        private string m_name;

        public ArgumentsExtension(string name)
        {
            m_name = name;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return string.Format("Hello {0}", m_name);
        }
    }
}
