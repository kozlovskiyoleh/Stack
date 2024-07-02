// See https://aka.ms/new-console-template for more information
namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pattern = "((()))";
            Console.WriteLine(IsCorrect(pattern));
            
        }

        public static bool IsCorrect(string str)
        {
            var stack = new Stack<char>();
            foreach(var symbol in str)
            {
                switch(symbol)
                {
                    case '(':
                        stack.Push(symbol);
                        break;
                    case ')':
                        if(stack.Count == 0) return false;
                        if (stack.Pop() != '(') return false;
                        break;
                    default:
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
