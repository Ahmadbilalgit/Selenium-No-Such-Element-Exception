using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace No_Such_Element_Exception_Handle
{
    class Entrypoint
    {
        static void Main()
        {


            IWebDriver driver = new ChromeDriver("./");
            //NuGet package which will copy the driver to the bin folder.
            //Then you can provide path to the current folder to driver ctor to run your tests:
            driver.Navigate().GoToUrl("http://116.203.214.214/");


            IWebElement Userid = driver.FindElement(By.Name("email"));
            Userid.Click();
            Userid.SendKeys("test@abc.com");
            // Thread.Sleep(3000);

            IWebElement password = driver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("abc");
            //Thread.Sleep(3000);



            IWebElement Button;
            try
            {
                Button = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/button"));
                // Change the above element address path , then you ll be able to witness the result. Test 

                if (Button.Displayed)

                {

                    Messages.Greenmsg("The element found");

                }

                Button.Click();
            }

            catch (NoSuchElementException)
            {

                Messages.Redmsg("The element not found");

            }
            // Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }


    }
}
