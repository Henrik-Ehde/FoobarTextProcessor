using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.RegularExpressions;


namespace FoobarTextProcessor.Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TextFileController : ControllerBase
    {

        // POST api/<TextFileController>
        [HttpPost]
        public ActionResult<string> Post(IFormFile file)
        {
            //Create a stream reader to access the text in the file
            var reader = new StreamReader(file.OpenReadStream());

            // Read the stream as a string.
            string text = reader.ReadToEnd();

            //Seperate the text into words. Only substrings with letters are considered words. 
            var words = Regex.Matches(text.ToLowerInvariant(), @"('*[a-z]'*)+").Select(match => match.Value);

            //Create a dictionary.
            Dictionary<string, int> dict = new();

            //Count how often each word occurs and record it in the dictionary.
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;

                else dict.Add(word, 1);
            }

            //Get the word with the highest occurence from the dictionary
            string mostCommonWord = dict.FirstOrDefault(x => x.Value == dict.Max(x => x.Value)).Key;

            //Find each instance of the most common word and replace it with the word surround by foo+bar
            string pattern = @"\b"+mostCommonWord+@"\b";
            string replace = "FOO" + mostCommonWord + "BAR";
            //text = Regex.Replace(text, pattern, replace, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, pattern, "foo$&bar", RegexOptions.IgnoreCase);


            return text;
        }

 
    }
}
