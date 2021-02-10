using System;

namespace GroepEen
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            if (inputs.Length < 3) return;

            float som1;
            if (!float.TryParse(inputs[0], out som1)) return;

            float som2;
            if (!float.TryParse(inputs[2], out som2)) return;

            float ans;
            switch (inputs[1])
            {
                case "+":
                    ans = som1 + som2;
                    Console.WriteLine(ans.ToString());
                    break;
                case "-":
                    ans = som1 - som2;
                    Console.WriteLine(ans.ToString());
                    break;
                case "*":
                case "x":
                    ans = som1 * som2;
                    Console.WriteLine(ans.ToString());
                    break;
                case ":":
                case "/":
                    ans = som1 / som2;
                    Console.WriteLine(ans.ToString());
                    break;
                default:
                    Console.WriteLine("Math method not supported");
                    break;
            }
        }
    }
}
