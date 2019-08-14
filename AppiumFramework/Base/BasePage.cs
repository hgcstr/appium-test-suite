using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace AppiumFramework.Base
{
    public class BasePage : Base
    {

        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {   
            var T = Activator.CreateInstance(typeof(TPage));

            PageFactory.InitElements((AndroidDriver<IWebElement>)ScenarioContext.Current.GetBindingInstance(typeof(AndroidDriver<IWebElement>)), T);

            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage) this;
        }


    }
}
