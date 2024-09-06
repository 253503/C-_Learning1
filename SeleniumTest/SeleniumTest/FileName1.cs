
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class FileName1
    {
        public static void Main2()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.whatismyip.com/");
           // IWebElement ipElement = driver.FindElement(By.XPath("//div/a[@id='ipv4']"));
           // string ipAddress = ipElement.Text;
           // Console.WriteLine(ipAddress);
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            IWebElement Name = driver.FindElement(By.Id("et_pb_contact_name_0"));
            Name.SendKeys("Gayathri");
            Console.WriteLine(Name);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            IWebElement Message = driver.FindElement(By.Id("et_pb_contact_message_0"));
            Message.SendKeys("HI!!!");
            Console.WriteLine(Message);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement Submit = driver.FindElement(By.Name("et_builder_submit_button"));
            Submit.SendKeys(Keys.Enter);
            //Console.WriteLine(Submit);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement Name1 = driver.FindElement(By.Id("et_pb_contact_name_1"));
            Name1.SendKeys("Gayathri22");
            Console.WriteLine(Name);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement Message1 = driver.FindElement(By.Id("et_pb_contact_message_1"));
            Message1.SendKeys("HI!!!");
            Console.WriteLine(Message);
           IWebElement captcha = driver.FindElement(By.Name("et_pb_contact_captcha_1"));
           captcha.SendKeys("27");
           Console.WriteLine(captcha);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //IWebElement Submit1 = driver.FindElement(By.Name("et_builder_submit_button"));
           IWebElement Submit1 = driver.FindElement(By.XPath("*[@id=\"et_pb_contact_form_1\"]/div[2]/form/div/button]"));
            Submit1.Click();
            driver.Quit();
            //Submit1.SendKeys(Keys.Enter);
            //Console.WriteLine(Submit);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}
