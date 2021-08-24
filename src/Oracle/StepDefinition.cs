using System;
using System.Collections.Generic;
using System.Linq;
using Flurl.Http;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace Oracle
{
    [Binding]
    public sealed class StepDefinition
    {
       private IEnumerable<Hero> heroes;
        private IFlurlResponse registrationResult;
        private readonly Driver driver;

        public StepDefinition()
        {
            driver = new Driver(Environment.GetEnvironmentVariable("ExperimentURI") ?? "https://localhost:5001");
        }


        [Given(@"these heroes may register")]
        public void GivenThisHeroesMayRegister(Table table)
        {
            heroes = table.CreateSet<Hero>();
        }

        [Given(@"these heroes registrations")]
        public async void GivenTheseHeroesRegistrations(Table table)
        {
            var registrations = table.Rows.Select(r =>
            {
                var name = r["Name"];
                var secret = heroes.First(h => h.Name == name).Secret;
                return new Registration(name, secret);

            });
            foreach (var registration in registrations)
            {
                await driver.RegisterHero(registration);
            }
        }


        [Then(@"the intervention plan should be")]
        public async void ThenTheInterventionPlanShouldBe(Table table)
        {
            var result = await driver.GetInterventionPlan();
            var plan = await result.GetJsonAsync<PlanAction[]>();
            table.CompareToSet(plan);
        }

        [When(@"these events occur")]
        public async void WhenTheseEventsOccur(Table table)
        {
            var events = table.CreateSet<Event>();
            foreach (var @event in events)
            {
                await driver.RegisterEvent(@event);
            }
        }

        [Then(@"the intervention plan should be empty")]
        public async void ThenTheInterventionPlanShouldBeEmpty()
        {
            var result = await driver.GetInterventionPlan();
            Assert.Equal(203,result.StatusCode);
        }



        [When(@"a hero called ""(.*)"" tries to register with the key ""(.*)""")]
        public async void WhenAHeroCalledTriesToRegisterWithTheKey(string name, string secret)
        {
            registrationResult =  await driver.RegisterHero(new Registration(name, secret));
        }

        [Then(@"the registration is a success")]
        public void ThenTheRegistrationIsASuccess()
        {
            Assert.Equal(200,registrationResult.StatusCode);
        }

        [Then(@"the registration is forbidden")]
        public void ThenTheRegistrationIsForbidden()
        {
            Assert.Equal(403, registrationResult.StatusCode);
        }
    }
}