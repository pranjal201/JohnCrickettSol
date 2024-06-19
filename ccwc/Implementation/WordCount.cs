using ccwc.Contracts;
using System.Text;

namespace ccwc.Implementation
{
    public class WordCount : IWordCount
    {
        public int CountBytes(string path)
        {
            byte[] buffer =File.ReadAllBytes(path);
            
            return buffer.Length;
        }

        public int CountLines(string path)
        {
            byte[] buffer = File.ReadAllBytes(path);
            string txt = Encoding.UTF8.GetString(buffer);
            return txt.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountWords(string path)
        {
            byte[] buffer = File.ReadAllBytes(path);
            string txt = Encoding.UTF8.GetString(buffer);
            return txt.Split(new char[] {' ','\n','\r','\t'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}