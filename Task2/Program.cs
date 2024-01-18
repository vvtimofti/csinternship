namespace Task2
{
    internal class Program
    {
        static string GetSubsequence(string sequence)
        {
            int end = sequence.Length - 1;
            int start = end - 1;
            List<string> subseq = [];
            while (end > 0)
            {
                if (start > -1 && sequence[start + 1] != sequence[start])
                {
                    subseq.Add(sequence.Substring(start, end - start + 1));
                    start--;
                }
                else
                {
                    end--;
                    start = end - 1;
                }
            }
            return String.Join(", ", subseq.ToArray());
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a sequence: ");
            string userInput = Console.ReadLine();
            string res = GetSubsequence(userInput);
            Console.WriteLine(res);
        }
    }
}
