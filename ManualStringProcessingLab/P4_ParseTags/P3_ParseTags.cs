using System;

namespace P4_ParseTags
{
    public class P3_ParseTarget
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";
            int startIndex = inputText.IndexOf(openTag);
            while (startIndex != -1)
            {
                int endIndex = inputText.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }
                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                var replaced = toBeReplaced.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();
                inputText = inputText.Replace(toBeReplaced, replaced);
                startIndex = inputText.IndexOf(openTag);

            }
            Console.WriteLine(inputText);
        }
    }
}
