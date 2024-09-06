
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class saucedemo
    {
        public static void Main5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            IWebElement Name = driver.FindElement(By.Id("user-name"));
            Name.SendKeys("standard_user");
            Console.WriteLine(Name);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");
            Console.WriteLine(password);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement Submit = driver.FindElement(By.Id("login-button"));
            Submit.SendKeys(Keys.Enter);
            //Console.WriteLine(Submit);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            IWebElement addcart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addcart.SendKeys(Keys.Enter);

            IWebElement clickcart = driver.FindElement(By.Id("shopping_cart_container"));
            clickcart.Click();
            //clickcart.SendKeys(Keys.Enter);

            IWebElement checkout = driver.FindElement(By.Id("checkout"));
            checkout.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement firstname = driver.FindElement(By.Id("first-name"));
            firstname.SendKeys("Gayathri");
            IWebElement lastname = driver.FindElement(By.Id("last-name"));
            lastname.SendKeys("Mohan");
            IWebElement pincode = driver.FindElement(By.Id("postal-code"));
            pincode.SendKeys("34344");
            IWebElement cntn = driver.FindElement(By.Id("continue"));
            cntn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement finish = driver.FindElement(By.Id("finish"));
            finish.Click();

            Console.WriteLine("Thank you for your order");







        }
    }
}
