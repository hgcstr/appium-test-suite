using System;
using System.Linq;
using AppiumFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;

namespace AppiumFramework.Extensions
{
    public enum MobileType
    {
        Native,
        Hybrid
    }

    public class AppiumExtension : Base.Base
    {
        private AppiumLocalService _appiumLocalService;

        public T InitializeAppiumDriver<T>(MobileType mobileType) where T : AppiumDriver<IWebElement>
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability(MobileCapabilityType.PlatformName, Settings.PlatformName);
            desiredCapabilities.SetCapability("deviceName", Settings.DeviceName);
            desiredCapabilities.SetCapability("app", Settings.AUTPath);
            desiredCapabilities.SetCapability("appPackage", Settings.AppPackage);

            //Creation of the instance 
            var driver = (T)Activator.CreateInstance(typeof(T), StartAppiumLocalService(), desiredCapabilities);

            switch (mobileType)
            {
                case MobileType.Native:
                    return driver;
                case MobileType.Hybrid:
                {
                    desiredCapabilities.SetCapability("chromedriverExecutable",
                        Settings.ChromeDriverPath);
                    AppiumContext = driver;

                    AppiumContext.Context = AppiumContext.Contexts.First(x => x.Contains("WEBVIEW_"));

                    return (T)AppiumContext;
                }
                default:
                    return (T)AppiumContext;
            }
        }

 
        private AppiumLocalService StartAppiumLocalService()
        {
            _appiumLocalService = new AppiumServiceBuilder()
                .UsingDriverExecutable(new System.IO.FileInfo(Settings.NodePath))
                .WithAppiumJS(new System.IO.FileInfo(Settings.AppiumJSPath))
                .UsingAnyFreePort().Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        private AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }


        public void CloseApp()
        {
            AppiumContext.CloseApp();
        }

    }
}
