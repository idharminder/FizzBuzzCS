namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int n)
        {
            List<string> msgList = new();

            if (IsDivisibleBy(n, 3))
            {
                msgList.Add("Fizz");
            }
            if (IsDivisibleBy(n, 5))
            {
                msgList.Add("Buzz");
            }
            if (IsDivisibleBy(n, 7))
            {
                msgList.Add("Bang");
            }
            if (IsDivisibleBy(n, 11))
            {
                msgList.Clear();
                msgList.Add("Bong");
            }
            if (IsDivisibleBy(n, 13))
            {
                Fezzer(msgList);
            }
            if (IsDivisibleBy(n, 17))
            {
                msgList.Reverse();
            }
            if (msgList.Count == 0)
            {
                msgList.Add(n.ToString());
            }
            return String.Join("", msgList);
        }
        private static bool IsDivisibleBy(int num, int denom)
        {
            return num % denom == 0;
        }

        private static void Fezzer(List<string> msgList)
        {
            if (msgList.Exists(item => item.Contains('B')))
            {
                msgList.Insert(msgList.FindIndex(item => item.Contains('B')), "Fezz");
            }
            else
            {
                msgList.Add("Fezz");
            }
        }
    }
}