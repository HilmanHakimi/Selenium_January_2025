using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;

class EntryPoint
{
    static void Main()
    {
        //Initialize the driver for the browser that you want to use
        IWebDriver driver = new ChromeDriver();

        //Go to the URL thaat you want to open/test
        driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/");

        //What element that you want to test
        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes, I can see the element, it's right there");

            /*You can alo change the text colour to any colour that you want by creating a new method like this
              or you can just use (Console.WriteLine)
            */
        }
        else
        {
            RedMessage("Well, something went wrong, I couldn't see the element");
            /*You can alo change the text colour to any colour that you want by creating a new method like this
              or you can just use(Console.WriteLine)
            */
        }


        //Pause for 3 second
        Thread.Sleep(3000);

        driver.Quit();

    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
