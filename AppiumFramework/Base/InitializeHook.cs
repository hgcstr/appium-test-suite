using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumFramework.Extensions;
using AppiumFramework.ConfigElement;

namespace AppiumFramework.Base
{
    public class InitializeHook
    {

        public AppiumExtension AppiumExtension =>  new AppiumExtension();


        public static void InitializeSettings()
        {
            Settings.PlatformName = TestConfiguration.Configuration.TestSettings["staging"].PlatformName;
            Settings.AUTPath = TestConfiguration.Configuration.TestSettings["staging"].AUTPath;
            Settings.ChromeDriverPath = TestConfiguration.Configuration.TestSettings["staging"].ChromeDriverPath;
            Settings.DeviceName = TestConfiguration.Configuration.TestSettings["staging"].DeviceName;
            Settings.AppPackage = TestConfiguration.Configuration.TestSettings["staging"].AppPackage;
            Settings.NodePath = TestConfiguration.Configuration.TestSettings["staging"].NodePath;
            Settings.AppiumJSPath = TestConfiguration.Configuration.TestSettings["staging"].AppiumJSPath;



        }


    }

}
