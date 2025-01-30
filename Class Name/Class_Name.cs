using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



class EntryPoint
    {
        static void Main()
        {
            string url = "https://testing.todorvachev.com/class-name/";
            string classname = "testClass";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(classname));

        Console.WriteLine(element.Text);

        driver.Quit();
        }
    
}

