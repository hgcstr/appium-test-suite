using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AppiumFramework.Base
{
    public class Base
    {

        public AppiumDriver<IWebElement> AppiumContext
        {
            get => (AppiumDriver<IWebElement>)ScenarioContext.Current.GetBindingInstance(
                typeof(AppiumDriver<IWebElement>));
            set => ScenarioContext.Current.ScenarioContainer.RegisterInstanceAs<AppiumDriver<IWebElement>>(value);
        }


        



    }
}
