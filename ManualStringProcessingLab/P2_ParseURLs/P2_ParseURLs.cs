using System;

namespace P2_ParseURLs
{
    public class P2_ParseURLs
    {
        public static void Main()
        {
            string[] urlTokens = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            if (urlTokens.Length != 2 || urlTokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var protokol = urlTokens[0];
                var indexResource = urlTokens[1].IndexOf('/');
                var server = urlTokens[1].Substring(0, indexResource);
                var resource = urlTokens[1].Substring(indexResource + 1);

                Console.WriteLine($"Protocol = {protokol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resource}");
            }
        }
    }
}
