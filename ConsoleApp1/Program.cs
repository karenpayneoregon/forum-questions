using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<string>
            {
                "<a href=\"http://web/sub/index.aspx?articleid=9999\">", 
                "<a href=\"http://web/sub/index.aspx?articleid=1\">", 
                "<a href=\"http://web/sub/index.aspx?articleid=123\">"
            };

            foreach (var item in list)
            {
                var results = DumpHRefs(item);
                Console.WriteLine(item);
                if (results.Count == 1)
                {
                    Console.WriteLine($"\t{results.FirstOrDefault()}");
                }

            }


            Console.ReadLine();
        }
        static List<string> DumpHRefs(string inputString)
        {
            var resultList = new List<string>();
            
            var HRefPattern = @"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>\S+))";

            try
            {
                var match = Regex.Match(inputString, HRefPattern, 
                    RegexOptions.IgnoreCase | 
                    RegexOptions.Compiled, 
                    TimeSpan.FromSeconds(1));

                while (match.Success)
                {

                    var myUri = new Uri(match.Groups[1].Value);
                    var articleIdValue = HttpUtility.ParseQueryString(myUri.Query).Get("articleid");
                    
                    if (!string.IsNullOrWhiteSpace(articleIdValue))
                    {
                        resultList.Add($"{articleIdValue}.html");
                    }
                    
                    match = match.NextMatch();
                }
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("The matching operation timed out.");
            }

            return resultList;
        }
    }
}
