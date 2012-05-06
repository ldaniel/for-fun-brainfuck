namespace brainfuck.Core
{
    public class brainfuck
    {
        private readonly char[] _virtualMemory;
        private int _pointer;
        private readonly char[] _commands;
        private readonly int _length;
        private int _instructionPointer;
        public string Out { get; private set; }

        public brainfuck(string statement)
        {
            _virtualMemory = new char[30720];
            _pointer = 0;
            _commands = statement.ToCharArray();
            _length = _commands.Length;
        }

        public void Run()
        {
            while (_instructionPointer < _length)
            {
                var command = _commands[_instructionPointer];

                switch (command)
                {
                    case '>': _pointer++; break;
                    case '<': _pointer--; break;
                    case '+': _virtualMemory[_pointer]++; break;
                    case '-': _virtualMemory[_pointer]--; break;
                    case '.': 
                        Out += _virtualMemory[_pointer].ToString(); 
                        break;
                    case ',':
                        _virtualMemory[_pointer] = System.Console.ReadKey().KeyChar;
                        break;
                    case '[': 
                        if (_virtualMemory[_pointer] == 0)
                            while (_commands[_instructionPointer] != ']') 
                                _instructionPointer++;
                        break;

                    case ']': 
                        if (_virtualMemory[_pointer] != 0)
                            while (_commands[_instructionPointer] != '[') 
                                _instructionPointer--;
                        break;
                }
                _instructionPointer++;
            }
        }
    }
}