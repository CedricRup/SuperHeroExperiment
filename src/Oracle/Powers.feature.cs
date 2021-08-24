﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Oracle
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SuperHeroPowersFeature : object, Xunit.IClassFixture<SuperHeroPowersFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Powers.feature"
#line hidden
        
        public SuperHeroPowersFeature(SuperHeroPowersFeature.FixtureData fixtureData, Oracle_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Super Hero Powers", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
  #line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Eye",
                        "Alive",
                        "Appearances",
                        "First Appearance",
                        "Hair",
                        "Sex",
                        "Align",
                        "Id",
                        "Secret"});
            table38.AddRow(new string[] {
                        "Iceman",
                        "",
                        "Living Characters",
                        "5",
                        "Jan-11",
                        "Blond Hair",
                        "Male Characters",
                        "Neutral Characters",
                        "Secret Identity",
                        "b364bbc2-261c-4da6-8a15-1dda2c92c9bb"});
            table38.AddRow(new string[] {
                        "Charles Blackwater",
                        "",
                        "Living Characters",
                        "4",
                        "Oct-91",
                        "",
                        "Male Characters",
                        "Good Characters",
                        "Secret Identity",
                        "a92b57f0-e6eb-43c6-ac53-2efcbec811e8"});
            table38.AddRow(new string[] {
                        "Aquaria Neptunia",
                        "Blue Eyes",
                        "Living Characters",
                        "139",
                        "May-47",
                        "Blond Hair",
                        "Female Characters",
                        "Good Characters",
                        "Secret Identity",
                        "ccefd65a-0f7e-4a98-bffe-c6f9cc12ddd1"});
            table38.AddRow(new string[] {
                        "Cornfed",
                        "Red Eyes",
                        "Living Characters",
                        "6",
                        "Apr-05",
                        "Blond Hair",
                        "Male Characters",
                        "Good Characters",
                        "Secret Identity",
                        "07fc91d5-8d83-4ff4-8ad0-f5c1f81e421e"});
            table38.AddRow(new string[] {
                        "Illich Lavrov",
                        "Yellow Eyes",
                        "Living Characters",
                        "5",
                        "Oct-86",
                        "Blond Hair",
                        "Male Characters",
                        "Good Characters",
                        "Secret Identity",
                        "d3db560c-49b2-4ea3-b996-86d9dce0998f"});
            table38.AddRow(new string[] {
                        "Tricephalous",
                        "Red Eyes",
                        "Living Characters",
                        "13",
                        "Nov-61",
                        "No Hair",
                        "Male Characters",
                        "",
                        "Secret Identity",
                        "9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826"});
            table38.AddRow(new string[] {
                        "Joseph Wilson",
                        "Green Eyes",
                        "Living Characters",
                        "229",
                        "1984, May",
                        "Blond Hair",
                        "Male Characters",
                        "Neutral Characters",
                        "Secret Identity",
                        "c886982a-85de-4221-a28f-6616b32edadc"});
            table38.AddRow(new string[] {
                        "Aleister Hook",
                        "Red Eyes",
                        "Living Characters",
                        "7",
                        "1988, March",
                        "White Hair",
                        "Male Characters",
                        "Bad Characters",
                        "Secret Identity",
                        "a534d762-0777-41d0-9571-eb8e5e021e29"});
            table38.AddRow(new string[] {
                        "Lasher",
                        "White Eyes",
                        "Living Characters",
                        "14",
                        "May-93",
                        "Bald",
                        "Agender Characters",
                        "Neutral Characters",
                        "Secret Identity",
                        "37632ead-13a7-45e4-aea3-495562265699"});
#line 4
    testRunner.Given("these heroes may register", ((string)(null)), table38, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A hero has Water power if her name has water, ice or Aqua in it", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "A hero has Water power if her name has water, ice or Aqua in it")]
        public virtual void AHeroHasWaterPowerIfHerNameHasWaterIceOrAquaInIt()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A hero has Water power if her name has water, ice or Aqua in it", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 18
    testRunner.When("powers are determined for \"Iceman\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
    testRunner.Then("this hero has \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
    testRunner.When("powers are determined for \"Charles Blackwater\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
    testRunner.Then("this hero has \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
    testRunner.When("powers are determined for \"Aquaria Neptunia\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
    testRunner.Then("this hero has \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
    testRunner.When("powers are determined for \"Fire Dragon\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
    testRunner.Then("this hero has no \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A hero has fire power if she has Red or Yellow eyes", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "A hero has fire power if she has Red or Yellow eyes")]
        public virtual void AHeroHasFirePowerIfSheHasRedOrYellowEyes()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A hero has fire power if she has Red or Yellow eyes", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 31
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 32
    testRunner.When("powers are determined for \"Cornfed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
    testRunner.Then("this hero has \"Fire\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
    testRunner.When("powers are determined for \"Illich Lavrov\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
    testRunner.Then("this hero has \"Fire\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A hero can\'t have water and fire power, water is dominant", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "A hero can\'t have water and fire power, water is dominant")]
        public virtual void AHeroCantHaveWaterAndFirePowerWaterIsDominant()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A hero can\'t have water and fire power, water is dominant", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 41
    testRunner.When("powers are determined for \"Tricephalous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
    testRunner.Then("this hero has \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
    testRunner.Then("this hero has no \"Fire\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Strenght is the number of appearence of a character divided by ten low rounded", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "Strenght is the number of appearence of a character divided by ten low rounded")]
        public virtual void StrenghtIsTheNumberOfAppearenceOfACharacterDividedByTenLowRounded()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strenght is the number of appearence of a character divided by ten low rounded", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 47
    testRunner.When("strenght is determined for \"Iceman\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
    testRunner.Then("strength is 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
    testRunner.When("strenght is determined for \"Joseph Wilson\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
    testRunner.Then("strength is 22", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A hero has earth power on a place if year of appearance + sum of ascii code of lo" +
            "cation is divisible by 17", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "A hero has earth power on a place if year of appearance + sum of ascii code of lo" +
            "cation is divisible by 17")]
        public virtual void AHeroHasEarthPowerOnAPlaceIfYearOfAppearanceSumOfAsciiCodeOfLocationIsDivisibleBy17()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A hero has earth power on a place if year of appearance + sum of ascii code of lo" +
                    "cation is divisible by 17", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 55
    testRunner.When("powers are determined for \"Aleister Hook\" in \"Paris\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
    testRunner.Then("this hero has \"Earth\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
    testRunner.When("powers are determined for \"Aleister Hook\" in \"Parit\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
    testRunner.Then("this hero has no \"Earth\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A hero has air power if he is bald and first appeared on a month withtout an \"r\" " +
            "in it", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "A hero has air power if he is bald and first appeared on a month withtout an \"r\" " +
            "in it")]
        public virtual void AHeroHasAirPowerIfHeIsBaldAndFirstAppearedOnAMonthWithtoutAnRInIt()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A hero has air power if he is bald and first appeared on a month withtout an \"r\" " +
                    "in it", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 62
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 63
    testRunner.When("powers are determined for \"Lasher\" in \"Paris\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
    testRunner.Then("this hero has \"Air\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Cannot have earth and air power, air in dominant", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "Cannot have earth and air power, air in dominant")]
        public virtual void CannotHaveEarthAndAirPowerAirInDominant()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cannot have earth and air power, air in dominant", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 67
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 68
    testRunner.When("powers are determined for \"Lasher\" in \"Q\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
    testRunner.Then("this hero has no \"Earth\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Aang has all powers everywhere ;o)", Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Super Hero Powers")]
        [Xunit.TraitAttribute("Description", "Aang has all powers everywhere ;o)")]
        public virtual void AangHasAllPowersEverywhereO()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aang has all powers everywhere ;o)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 72
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 73
    testRunner.When("powers are determined for \"Aang\" in \"Paris\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
    testRunner.Then("this hero has \"Air\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
    testRunner.Then("this hero has \"Earth\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
    testRunner.Then("this hero has \"Fire\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
    testRunner.Then("this hero has \"Water\" Power", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SuperHeroPowersFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SuperHeroPowersFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion