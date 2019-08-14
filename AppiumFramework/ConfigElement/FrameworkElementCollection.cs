using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFramework.ConfigElement
{

    [ConfigurationCollection(typeof(ConfigElement), AddItemName = "testSetting", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    class FrameworkElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as ConfigElement).Name;
        }

        public new ConfigElement this[string type] => (ConfigElement)base.BaseGet(type);
    }
}
