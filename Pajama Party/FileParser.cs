using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Pajama_Party
{
//    File Parser Class
//    Create a FileParser class that reads a text file, parses its contents, 
//    and performs some analysis.Implement methods for counting lines, words, and characters.Allow the user to specify the file path.
    internal class FileParser
    {
        public string text { get; set; }

        public FileParser(string _text)
        {
            text = _text;
        }
        //methods
        public int CountCharacters()
        {
            return text.Length;
        }

        public int CountWords()
        {
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Count lines method
        public int CountLines()
        {
            // Split the text into lines using newline characters as delimiters
            string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Length;
        }
    }
}
