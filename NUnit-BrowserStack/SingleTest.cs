using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using SingleTest;

namespace BrowserStack
{
  //[TestFixture("single", "chrome")]
  public class SingleTest
  {
    public SingleTest() { }

    [Test]
    
    public void SearchGoogle()
    {
         
         
            bsoptions capabilities = new bsoptions
            { BrowserVersion = "latest",
              PlatformName = "Android"
            };
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            browserstackOptions.Add("buildName", "Nunit W3C debug");
            browserstackOptions.Add("realMobile", "true");
            browserstackOptions.Add("local", "false");
            
            capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
            // AddAdditionalAppiumOption prefixes appium: 
			capabilities.AddAdditionalAppiumOption("appium:app", "app_url");
			capabilities.AddAdditionalAppiumOption("appium:deviceName", "Samsung Galaxy S20");

			AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new System.Uri("https://<username>:<access_key>@hub-cloud.browserstack.com/wd/hub"),capabilities, TimeSpan.FromSeconds(600));

    }
  }
}
