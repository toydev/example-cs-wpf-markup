using System;
using System.Windows.Markup;

namespace Parameters
{
    public class PlusExtension : MarkupExtension
    {
        private int m_value1;
        private int m_value2;

        public PlusExtension(int value1, int value2)
        {
            m_value1 = value1;
            m_value2 = value2;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return (m_value1 + m_value2).ToString();
        }
    }
}
