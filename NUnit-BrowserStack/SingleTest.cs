using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
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
            browserstackOptions.Add("osVersion", "7.0");
            //browserstackOptions.Add("PlatformName", "Android");
            browserstackOptions.Add("deviceName", "Samsung Galaxy S8");
            browserstackOptions.Add("realMobile", "true");
            browserstackOptions.Add("local", "false");
            browserstackOptions.Add("userName", "username");
            browserstackOptions.Add("accessKey", "accesskey");
          
            

            capabilities.AddAdditionalOption("bstack:options", browserstackOptions);

            //capabilities.AddAdditionalAppiumOption("app", "bs://f096917b186b9a98eb4bce8d532cc23f22593171");
            capabilities.AddAdditionalOption("app", "bs://f096917b186b9a98eb4bce8d532cc23f22593171");

            capabilities.AddAdditionalOption("browserstack.use_w3c", "true");


            //commented ones are for older selenium version
            //capabilities.AddAdditionalCapability("bstack:options", browserstackOptions);

            //capabilities.AddAdditionalCapability("app", "bs://f096917b186b9a98eb4bce8d532cc23f22593171");
            //capabilities.AddAdditionalCapability("browserstack.use_w3c", "true");


            AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new System.Uri("https://mudassarsyed2:8ZezGR6GyZjP2ZqrXphh@hub-cloud.browserstack.com/wd/hub"),capabilities, TimeSpan.FromSeconds(600));


    }
  }
}
