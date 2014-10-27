using System;

namespace _15ReplaceInHtml
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            // Predefined input
            string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a>" + 
                " to choose a training course." + 
                " Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            // Replace tags
            text = text.Replace("<a href", "[URL");
            text = text.Replace("</a>", "[/URL]");
            text = text.Replace(">", "]");
            text = text.Replace("<p]", "<p>");
            text = text.Replace("</p]", "</p>");
            text = text.Replace("\"", string.Empty);
            
            // Print
            Console.WriteLine(text);
        }
    }
}
