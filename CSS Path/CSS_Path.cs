﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class CSS_Path
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/css-path/";
        string cssPath = "#post-108 > div > figure >  img";

        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see the CSS Path Element!");

            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see the CSS Path element!");
        }





        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the X Path Element!");
        }
        else
        {
            RedMessage("I can't see the X Path element!");
        }


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

