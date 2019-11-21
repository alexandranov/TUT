using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationTut.by
{
    [TestFixture]
    public class Locators
    {

       //private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            
         //   driver = new ChromeDriver(@"/Users/aleksandra/Documents/chromedrivers/");
            

        }


        public Locators()
        {
            //var login_button = driver.FindElement(By.XPath("//a[@data-target-popup ='authorize-form']"));
            //var login_field = driver.FindElement(By.XPath("//input[@name='login']"));
            //var password_field = driver.FindElement(By.XPath("//input[@type='password']"));
            //var enter_button = driver.FindElement(By.XPath("//input[@class ='button auth__enter']"));
            //var name_button = driver.FindElement(By.XPath("//span[@class ='uname']"));
            //var mail_button = driver.FindElement(By.XPath("//div[@id='authorize']/div/div/div/div/ul/li[2]/a"));
            //var write_button = driver.FindElement(By.XPath("//span[@class = 'mail-ComposeButton-Text']"));
        }
    }
}
