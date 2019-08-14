using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFramework.ConfigElement
{
    class TestConfiguration : ConfigurationSection
    {

        public static TestConfiguration Configuration =>
            (TestConfiguration)ConfigurationManager.GetSection("TestConfiguration");

        [ConfigurationProperty("testSettings")]
        public FrameworkElementCollection TestSettings => (FrameworkElementCollection)base["testSettings"];

    }
}
