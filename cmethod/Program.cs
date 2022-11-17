namespace cmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculator(12, 4, '*')); 

        }

        static int Calculator(int num1,int num2, char opr)
        {
            int result = 404;

            if (opr == '+')
            {
                result = num1 + num2;
            }
            else if (opr == '-')
            {
                result = num1 - num2;
            }
            else if (opr == '/')
            {
                result = num1 / num2;
            }
            else if (opr == '*')
            {
                result = num1 * num2;
            }
            else
            {
                Console.Write("opr olaraq bunlardan istifade et: + , - , / , * , Error");
            }

            return result;
        }
    }
}