using System;

namespace _25ExtractFromHTML
{
    class ExtractNonHTMLText
    {
        static void Main(string[] args)
        {
            // Predefined input
            string html = "<html><head><title>News</title></head><body><p>" + 
                "<a href=\"http://academy.telerik.com\">Telerik Academy</a>" + 
                "aims to provide free real-world practical training for young people who" + 
                " want to turn into skillful .NET software engineers.</p></body></html>";

            // Boolean to remember if the program is inside or outside of a tag
            bool tagIsClosed = false;
            string text = string.Empty;

            // Loop through HTML document and exctract everything that is not a text
            for (int i = 0; i < html.Length; i++)
            {
                if (html[i] == '<')
                {
                    tagIsClosed = false;
                }
                else if (html[i] == '>')
                {
                    tagIsClosed = true;
                }
                else if (tagIsClosed)
                {
                    text += html[i];
                }
                // Append extra whitespace that is not present in the document. Without this check for example 
                // "<a href=\"http://academy.telerik.com\">Telerik Academy</a>aims" - will result in Telerik Academyaims
                if (i < html.Length - 1 && html[i] == '<' && html[i + 1] == '/' && text[text.Length - 1 ] != ' ')
                {
                    text += " ";
                }
            }

            // Print result
            Console.WriteLine(text);
        }
    }
}
