using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/text-input-field/";

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        //This is to insert the text that you want inside the text textbox
        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        //This is if you want to show it in the console
        //If you change textBox.GetAttribute("value") -> textBox.GetAttribute("maxlength") you can get the max length for the text box displayed in console
        Console.WriteLine(textBox.GetAttribute("maxlength"));


        //textBox.Clear();  *This is if you want to clear the text that you have input

        Thread.Sleep(3000);

        driver.Quit();

    }
}

