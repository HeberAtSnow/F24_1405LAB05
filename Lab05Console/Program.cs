namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example method call:
            int[] answer=SortInts(new int[]{4,3,1,2});
            Console.WriteLine("I sorted something :)");
        }

        // Methods go here
        public static string ReverseString(string incoming)
        {
            string answer = "";
           // ADD CODE HERE
            return answer;
        }
        public static int[] SortInts(int[] incoming)
        {
           // ADD CODE HERE
            return incoming;
        }
        public static string SortString(string incoming)
        {
            char[] sentIn = incoming.ToCharArray();
           // ADD CODE HERE
            return new string(sentIn);
        }
    }
}
