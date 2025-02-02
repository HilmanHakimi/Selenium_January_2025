using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
        string option = "1";

        driver.Navigate().GoToUrl(url);


        /*If you want to select the first checkbox copy the first CSS selector checkbox the insert it in the checkBox = driver.FindElement(By.CssSelector()) */
        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));

        /*If you want to select the second checkbox copy the second CSS selector checkbox the insert it in the checkBox = driver.FindElement(By.CssSelector()) */
        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(3)"));

        //Or you can also use this method
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        //This is to check if the selected option CheckBox  are checked or not
        /*if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked");
        }
        else
        {
            Console.WriteLine("The checkbox is not checked");
        }
        */

        //This is to get the value of both of the checkbox
       /* Console.WriteLine(checkBox.GetAttribute("Value"));

        option = "3";

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        Console.WriteLine(checkBox.GetAttribute("Value"));
       */


        //This is to tick both of the checkbox
        checkBox.Click();

        Thread.Sleep(5000);


        driver.Quit();
    }
}

