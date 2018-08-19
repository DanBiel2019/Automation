using OpenQA.Selenium;
using System;

namespace Automation.Page
{
    public static class WebElementExtensions
    {
        public static string GetName(this IWebElement webElement)
        {
            return webElement.GetProperty("name");
        }

        public static string GetId(this IWebElement webElement)
        {
            return webElement.GetProperty("id");
        }

        public static string GetClass(this IWebElement webElement)
        {
            return webElement.GetProperty("class");
        }

        public static string GetStyle(this IWebElement webElement)
        {
            return webElement.GetProperty("style");
        }

        public static string GetHref(this IWebElement webElement)
        {
            return webElement.GetProperty("href");
        }

        public static string GetValue(this IWebElement webElement)
        {
            return webElement.GetProperty("vaue");
        }

        public static string GetType(this IWebElement webElement)
        {
            return webElement.GetProperty("type");
        }

        public static string GetText(this IWebElement webElement)
        {
            return webElement.Text;
        }

        public static void SetText(this IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public static bool IsVisible(this IWebElement webElement)
        {
            bool result;
            try
            {
                result = webElement.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static bool IsSelected(this IWebElement webElement)
        {
            return webElement.Selected;
        }

        public static bool IsEnabled(this IWebElement webElement)
        {
            return webElement.Enabled;
        }

        public static bool IsTypeButton(this IWebElement webElement)
        {
            return GetType(webElement).Equals("button", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeCheckbox(this IWebElement webElement)
        {
            return GetType(webElement).Equals("checkbox", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeColor(this IWebElement webElement)
        {
            return GetType(webElement).Equals("color", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeDate(this IWebElement webElement)
        {
            return GetType(webElement).Equals("date", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeDateTimeLocal(this IWebElement webElement)
        {
            return GetType(webElement).Equals("datetime-local", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeEmail(this IWebElement webElement)
        {
            return GetType(webElement).Equals("email", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeFile(this IWebElement webElement)
        {
            return GetType(webElement).Equals("file", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeHidden(this IWebElement webElement)
        {
            return GetType(webElement).Equals("hidden", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeImage(this IWebElement webElement)
        {
            return GetType(webElement).Equals("image", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeMonth(this IWebElement webElement)
        {
            return GetType(webElement).Equals("month", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeNumber(this IWebElement webElement)
        {
            return GetType(webElement).Equals("number", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypePassword(this IWebElement webElement)
        {
            return GetType(webElement).Equals("password", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeRadio(this IWebElement webElement)
        {
            return GetType(webElement).Equals("radio", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeRang(this IWebElement webElement)
        {
            return GetType(webElement).Equals("range", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeReset(this IWebElement webElement)
        {
            return GetType(webElement).Equals("reset", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeSearch(this IWebElement webElement)
        {
            return GetType(webElement).Equals("search", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeSubmit(this IWebElement webElement)
        {
            return GetType(webElement).Equals("submit", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeText(this IWebElement webElement)
        {
            return GetType(webElement).Equals("text", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeTel(this IWebElement webElement)
        {
            return GetType(webElement).Equals("tel", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeTime(this IWebElement webElement)
        {
            return GetType(webElement).Equals("time", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeUrl(this IWebElement webElement)
        {
            return GetType(webElement).Equals("url", StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeWeek(this IWebElement webElement)
        {
            return GetType(webElement).Equals("week", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}