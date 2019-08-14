using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFramework.ConfigElement
{
    class ConfigElement : ConfigurationElement
    {

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("autPath", IsRequired = true)]
        public string AUTPath => (string)base["autPath"];

        [ConfigurationProperty("platformName", IsRequired = true)]
        public string PlatformName => (string)base["platformName"];

        [ConfigurationProperty("deviceName", IsRequired = true)]
        public string DeviceName => (string)base["deviceName"];

        [ConfigurationProperty("chromeDriverPath", IsRequired = true)]
        public string ChromeDriverPath => (string)base["chromeDriverPath"];

        [ConfigurationProperty("appPackage", IsRequired = true)]
        public string AppPackage => (string)base["appPackage"];

        [ConfigurationProperty("nodePath", IsRequired = true)]
        public string NodePath => (string)base["nodePath"];

        [ConfigurationProperty("appiumJSPath", IsRequired = true)]
        public string AppiumJSPath => (string)base["appiumJSPath"];

    }
}
