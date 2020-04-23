﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
        static class Validations
        {
            public static bool ValidatePageByUrl(this IWebDriver driver, String screenUrl)
            {
                return (driver.Url == screenUrl);
            }

            public static bool ValidateIsPresent(this IWebElement element)
            {
                return element.Displayed;
            }

            //public void validatetextinelement(iwebdriver driver, by element, string text)
            //{
            //    string findelement = driver.findelement(element).text;
            //    assert.istrue(findelement.equals(text));
            //}
        }

}
