namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome , let's count words in a string");
            string paragraph = "To be or not to be";
            Console.WriteLine(paragraph);
            CountWords(paragraph);
            Console.ReadLine();
        }
        /// Counts the words.
        public static void CountWords(string paragraph)
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (myMapNode.Exists(word))
                    myMapNode.Add(word.ToLower(), myMapNode.Get(word) + 1);
                else
                    myMapNode.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Display after Add operation");
            myMapNode.Display();
        }
    }
}
