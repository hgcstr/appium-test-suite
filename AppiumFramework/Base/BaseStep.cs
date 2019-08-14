using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AppiumFramework.Base
{
    public class BaseStep : BasePage
    {

        public BasePage CurrentMobilePage
        {
            get => (BasePage)ScenarioContext.Current["currentMobilePage"];
            set => ScenarioContext.Current["currentMobilePage"] = value;
        }
    }
}
