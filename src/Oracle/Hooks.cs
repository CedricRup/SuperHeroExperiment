using System;
using TechTalk.SpecFlow;

namespace Oracle
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public async void BeforeScenario()
        {
            var driver = new Driver(Environment.GetEnvironmentVariable("ExperimentURI")??"https://localhost:5001");
            await driver.RegisterEvent(new Event("End Of Mission", "Secret",0));
        }
    }
}
