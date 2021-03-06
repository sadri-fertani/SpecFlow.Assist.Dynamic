﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Conversions of values")]
    public partial class ConversionsOfValuesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValueConversions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Conversions of values", "\tIn order to easier compare values of the most common types\r\n\tAs a user of SpecFl" +
                    "ow Dynamic\r\n\tI want SpecFlow Dynamic to translate strings into the closest resse" +
                    "mbling real type", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to string")]
        public virtual void StringsShouldBeTranslatedToString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to string", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "Marcus"});
#line 8
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table1, "When ");
#line 11
 testRunner.Then("the Name property should equal \'Marcus\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated from strings")]
        public virtual void IntegersShouldBeTranslatedFromStrings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated from strings", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table2.AddRow(new string[] {
                        "39"});
#line 14
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table2, "When ");
#line 17
 testRunner.Then("the Age property should equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated from strings")]
        public virtual void DoublesShouldBeTranslatedFromStrings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated from strings", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table3.AddRow(new string[] {
                        "1.96"});
#line 20
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table3, "When ");
#line 23
 testRunner.Then("the LengthInMeters property should equal \'1.96\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated from strings")]
        public virtual void DecimalsShouldBeTranslatedFromStrings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated from strings", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table4.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 26
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table4, "When ");
#line 29
 testRunner.Then("the MolecularWeight property should equal \'1000000000.1111991111\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated from strings")]
        public virtual void DatesShouldBeTranslatedFromStrings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated from strings", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table5.AddRow(new string[] {
                        "1972-10-09"});
#line 32
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table5, "When ");
#line 35
 testRunner.Then("the BirthDate property should equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated from strings")]
        public virtual void BoolsShouldBeTranslatedFromStrings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated from strings", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table6.AddRow(new string[] {
                        "false"});
#line 38
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table6, "When ");
#line 41
 testRunner.Then("the IsDeveloper property should equal \'false\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should not be translated into a date")]
        public virtual void AStrangeDoubleShouldNotBeTranslatedIntoADate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should not be translated into a date", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table7.AddRow(new string[] {
                        "4.567"});
#line 44
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table7, "When ");
#line 47
 testRunner.Then("the LengthInMeters property should equal \'4.567\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There\'s ways to disable type conversion for instance creation")]
        public virtual void ThereSWaysToDisableTypeConversionForInstanceCreation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There\'s ways to disable type conversion for instance creation", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table8.AddRow(new string[] {
                        "012345",
                        "044",
                        "1972-13-09",
                        "1,96"});
#line 50
 testRunner.When("I create a dynamic instance from this table using no type conversion", ((string)(null)), table8, "When ");
#line 53
 testRunner.Then("the Name value should still be \'012345\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("the Age value should still be \'044\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("the birth date should stil be \'1972-13-09\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("length in meter should still be \'1,96\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There\'s ways to disable type conversion for instance creation with key/value tabl" +
            "es")]
        public virtual void ThereSWaysToDisableTypeConversionForInstanceCreationWithKeyValueTables()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There\'s ways to disable type conversion for instance creation with key/value tabl" +
                    "es", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table9.AddRow(new string[] {
                        "Name",
                        "012345"});
            table9.AddRow(new string[] {
                        "Age",
                        "044"});
            table9.AddRow(new string[] {
                        "Birth date",
                        "1972-13-09"});
            table9.AddRow(new string[] {
                        "Length in meters",
                        "1,96"});
#line 59
 testRunner.When("I create a dynamic instance from this table using no type conversion", ((string)(null)), table9, "When ");
#line 65
 testRunner.Then("the Name value should still be \'012345\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.And("the Age value should still be \'044\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("the birth date should stil be \'1972-13-09\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("length in meter should still be \'1,96\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There\'s ways to disable type conversion for set creation")]
        public virtual void ThereSWaysToDisableTypeConversionForSetCreation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There\'s ways to disable type conversion for set creation", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table10.AddRow(new string[] {
                        "012345",
                        "044"});
            table10.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 71
 testRunner.When("I create a set of dynamic instances from this table using no type conversion", ((string)(null)), table10, "When ");
#line 75
 testRunner.Then("I should have a list of 2 dynamic objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
  testRunner.And("the 1 item should still Name equal \'012345\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
  testRunner.And("the 1 item should still Age equal \'044\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There\'s ways to disable type conversion for matching a dynamic instance against a" +
            " table")]
        public virtual void ThereSWaysToDisableTypeConversionForMatchingADynamicInstanceAgainstATable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There\'s ways to disable type conversion for matching a dynamic instance against a" +
                    " table", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table11.AddRow(new string[] {
                        "012345",
                        "039"});
#line 80
 testRunner.Given("I create a dynamic instance from this table using no type conversion", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table12.AddRow(new string[] {
                        "012345",
                        "039"});
#line 83
 testRunner.When("I compare it to this table using no type conversion", ((string)(null)), table12, "When ");
#line 86
 testRunner.Then("no instance comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Comparing against an identical table should match")]
        public virtual void ComparingAgainstAnIdenticalTableShouldMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Comparing against an identical table should match", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table13.AddRow(new string[] {
                        "012345",
                        "039"});
            table13.AddRow(new string[] {
                        "065484",
                        "003"});
#line 89
 testRunner.Given("I create a set of dynamic instances from this table using no type conversion", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table14.AddRow(new string[] {
                        "012345",
                        "039"});
            table14.AddRow(new string[] {
                        "065484",
                        "003"});
#line 93
 testRunner.When("I compare the set to this table using no type conversion", ((string)(null)), table14, "When ");
#line 97
 testRunner.Then("no set comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
