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
namespace Rnn.Specs.Api.Features.INSZ
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GeneratingINSZ_ListFeature : object, Xunit.IClassFixture<GeneratingINSZ_ListFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "GeneratingINSZList.feature"
#line hidden
        
        public GeneratingINSZ_ListFeature(GeneratingINSZ_ListFeature.FixtureData fixtureData, Rnn_Specs_Api_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/INSZ", "Generating INSZ-list", "![RNN](https://your-image-url.com/rnn.png)\r\nThis feature validates the generation" +
                    " of Belgian social security numbers (INSZ/RRN).\r\n\r\nLink to feature: [RNN](Rnn.Sp" +
                    "ecs.Api/Features/GeneratingINSZList.feature)", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User tries to generate a list of random INSZ-numbers without providing any input")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User tries to generate a list of random INSZ-numbers without providing any input")]
        public virtual void UserTriesToGenerateAListOfRandomINSZ_NumbersWithoutProvidingAnyInput()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User tries to generate a list of random INSZ-numbers without providing any input", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
#line 10
 testRunner.When("the users asks for an INSZ generation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 3 random INSZ-numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 3 random INSZ-numbers")]
        public virtual void UserAttemptsToGenerateAnListOf3RandomINSZ_Numbers()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 3 random INSZ-numbers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
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
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "amount"});
                table4.AddRow(new string[] {
                            "3"});
#line 14
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table4, "When ");
#line hidden
#line 17
 testRunner.Then("the INSZ list should contain 3 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of -3 random INSZ-numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of -3 random INSZ-numbers")]
        public virtual void UserAttemptsToGenerateAnListOf_3RandomINSZ_Numbers()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of -3 random INSZ-numbers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 19
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
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "amount"});
                table5.AddRow(new string[] {
                            "-3"});
#line 20
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table5, "When ");
#line hidden
#line 23
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 0 random INSZ-numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 0 random INSZ-numbers")]
        public virtual void UserAttemptsToGenerateAnListOf0RandomINSZ_Numbers()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 0 random INSZ-numbers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
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
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "amount"});
                table6.AddRow(new string[] {
                            "0"});
#line 26
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table6, "When ");
#line hidden
#line 29
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of random INSZ-numbers exceeding the allowed ap" +
            "i-limit")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of random INSZ-numbers exceeding the allowed ap" +
            "i-limit")]
        [Xunit.TraitAttribute("Category", "technical")]
        public virtual void UserAttemptsToGenerateAnListOfRandomINSZ_NumbersExceedingTheAllowedApi_Limit()
        {
            string[] tagsOfScenario = new string[] {
                    "technical"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of random INSZ-numbers exceeding the allowed ap" +
                    "i-limit", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
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
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "amount"});
                table7.AddRow(new string[] {
                            "123456789"});
#line 33
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table7, "When ");
#line hidden
#line 36
 testRunner.Then("the ask attempt should fail with error \"Internal server error\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 1 random INSZ-number that include age and se" +
            "x information")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 1 random INSZ-number that include age and se" +
            "x information")]
        public virtual void UserAttemptsToGenerateAnListOf1RandomINSZ_NumberThatIncludeAgeAndSexInformation()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 1 random INSZ-number that include age and se" +
                    "x information", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "info"});
                table8.AddRow(new string[] {
                            "true"});
#line 41
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table8, "When ");
#line hidden
#line 44
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s) with associated " +
                        "age and sex", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 1 random INSZ-number for an adult")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 1 random INSZ-number for an adult")]
        public virtual void UserAttemptsToGenerateAnListOf1RandomINSZ_NumberForAnAdult()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 1 random INSZ-number for an adult", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
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
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "adult"});
                table9.AddRow(new string[] {
                            "true"});
#line 49
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table9, "When ");
#line hidden
#line 52
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.And("the INSZ-number(s) should be that of an adult", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 1 random INSZ-number with the birthdate of 2" +
            "022-10-30")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 1 random INSZ-number with the birthdate of 2" +
            "022-10-30")]
        public virtual void UserAttemptsToGenerateAnListOf1RandomINSZ_NumberWithTheBirthdateOf2022_10_30()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 1 random INSZ-number with the birthdate of 2" +
                    "022-10-30", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 57
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
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "date"});
                table10.AddRow(new string[] {
                            "2022-10-30"});
#line 58
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table10, "When ");
#line hidden
#line 61
 testRunner.Then("the INSZ list should contain 1 randomly generated INSZ-number(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.And("the INSZ-number(s) should start with 221030.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User attempts to generate an list of 1 random INSZ-number, with an incomplete bir" +
            "thdate")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an list of 1 random INSZ-number, with an incomplete bir" +
            "thdate")]
        public virtual void UserAttemptsToGenerateAnListOf1RandomINSZ_NumberWithAnIncompleteBirthdate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an list of 1 random INSZ-number, with an incomplete bir" +
                    "thdate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 64
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
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "date"});
                table11.AddRow(new string[] {
                            "2022"});
#line 65
 testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table11, "When ");
#line hidden
#line 68
 testRunner.Then("the ask attempt should fail with error \"Internal server error\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="User attempts to generate an INSZ-number with specific options")]
        [Xunit.TraitAttribute("FeatureTitle", "Generating INSZ-list")]
        [Xunit.TraitAttribute("Description", "User attempts to generate an INSZ-number with specific options")]
        [Xunit.InlineDataAttribute("1", "1990-01-01", "true", "true", new string[0])]
        [Xunit.InlineDataAttribute("3", "1990-01-01", "true", "true", new string[0])]
        [Xunit.InlineDataAttribute("1", "2000-03-15", "true", "false", new string[0])]
        [Xunit.InlineDataAttribute("3", "2000-03-15", "true", "false", new string[0])]
        [Xunit.InlineDataAttribute("1", "1985-11-30", "false", "true", new string[0])]
        [Xunit.InlineDataAttribute("3", "1985-11-30", "false", "true", new string[0])]
        public virtual void UserAttemptsToGenerateAnINSZ_NumberWithSpecificOptions(string amount, string birthdate, string info, string adult, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("amount", amount);
            argumentsOfScenario.Add("birthdate", birthdate);
            argumentsOfScenario.Add("info", info);
            argumentsOfScenario.Add("adult", adult);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User attempts to generate an INSZ-number with specific options", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "amount",
                            "date",
                            "info",
                            "adult"});
                table12.AddRow(new string[] {
                            string.Format("{0}", amount),
                            string.Format("{0}", birthdate),
                            string.Format("{0}", info),
                            string.Format("{0}", adult)});
#line 74
  testRunner.When("the users asks for an INSZ generation as", ((string)(null)), table12, "When ");
#line hidden
#line 78
  testRunner.Then(string.Format("the INSZ list should contain {0} randomly generated INSZ-number(s)", amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                GeneratingINSZ_ListFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GeneratingINSZ_ListFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
