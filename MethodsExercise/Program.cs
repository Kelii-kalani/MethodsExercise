namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FirstExercise.Story();

            Console.WriteLine();

            int sum = SecondExercise.Add(5, 6);
            Console.WriteLine(sum);

            int difference = SecondExercise.Subtract(10, 4);
            Console.WriteLine(difference);

            int product = SecondExercise.Multiply(6, 9);
            Console.WriteLine(product);

            int quotient = SecondExercise.Divide(40, 5);
            Console.WriteLine(quotient);

            Console.WriteLine();

            int y = Extracredit.Add(10, 12, 13, 5, 16);
            Console.WriteLine(y);
        }
    }
}
