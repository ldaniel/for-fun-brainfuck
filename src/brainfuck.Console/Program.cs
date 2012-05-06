namespace brainfuck.Console
{
    class Program
    {
        static void Main()
        {
            Run(BFSamples.HelloWorld);
            System.Console.ReadLine();
        }

        static void Run(string bfcode)
        {
            var brainfuck = new Core.brainfuck(bfcode);
            brainfuck.Run();
            System.Console.WriteLine(brainfuck.Out);
        }
    }
}
