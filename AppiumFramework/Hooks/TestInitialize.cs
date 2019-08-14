using AppiumFramework.Base;
using AppiumFramework.Extensions;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AppiumFramework.Hooks
{
    [Binding]
    public class TestInitialize : InitializeHook
    {

        private readonly IObjectContainer _objectContainer;

        public TestInitialize(IObjectContainer iObjectContainer)
        {
            _objectContainer = iObjectContainer;
        }


        [BeforeScenario]
        public void InitializeTest()
        {
            InitializeSettings();
            var androidContext = AppiumExtension.InitializeAppiumDriver<AndroidDriver<IWebElement>>(MobileType.Native);

            _objectContainer.RegisterInstanceAs(androidContext);
        }

        [TearDown]
        public void CleanUp()
        {
            AppiumExtension.CloseApp();
        }


    }
}
