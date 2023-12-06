using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_test
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        // IWebDriver ege = new EdgeDriver(); 
        //[TestCase]
        //public void mainTitle()
        //{
        //    driver.Url = "https://code-basics.com/ru";
        //    Assert.That(driver.Title, Is.EqualTo("Îáðàçîâàòåëüíàÿ ïëàòôîðìà Êàëèíèíãðàäñêîãî áèçíåñ-êîëëåäæà"));
        //    ege.Url = "https://code-basics.com/ru";
        //    Assert.That(ege.Title, Is.EqualTo("Îáðàçîâàòåëüíàÿ ïëàòôîðìà Êàëèíèíãðàäñêîãî áèçíåñ-êîëëåäæà"));
        //}

        [TestCase]
        public void TC_UI_1()
        {
            driver.Url = "https://code-basics.com/ru/session/new";
            IWebElement tc1 = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[4]/input"));
            tc1.Click();
        }
        [TestCase]
        public void TC_UI_2()
        {
            driver.Url = "https://code-basics.com/ru/session/new";
            IWebElement email = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[1]/input"));
            email.SendKeys("FunnerP");
            IWebElement button = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[4]/input"));
            button.Click();
        }
        [TestCase]
        public void TC_UI_3()
        {
            driver.Url = "https://code-basics.com/ru/session/new";
            IWebElement email = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[1]/input"));
            email.SendKeys("test@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[2]/input"));
            password.SendKeys("123456");
            IWebElement button = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/div/div/form/div[4]/input"));
            button.Click();
        }
        [TestCase]
        public void TC_UI_4()
        {
            driver.Url = "https://code-basics.com/ru";
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/div/div/div/div/ul[2]/li[3]/ul/li/a"));
            button.Click();
        }
        [TestCase]
        public void TC_UI_5()
        {
            driver.Url = "https://code-basics.com/ru";
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/div/div/div/div/ul[1]/li[3]/ul/li[1]/a"));
            button.Click();
        }
    }
}
