namespace brainfuck.Core
{
    public class brainfuck
    {
        private readonly char[] _virtualMemory;
        private int _pointer;
        private readonly char[] _commands;
        private readonly int _length;
        private int _instructionPointer;
        private int _bracket;
        public string Out { get; private set; }

        public brainfuck(string statement)
        {
            _virtualMemory = new char[30720];
            _pointer = 0;
            _commands = new char[statement.Length];
            for (int i = 0; i < statement.Length; i++)
            {
                if (statement[i] == '+' || statement[i] == '-' || statement[i] == '<' || statement[i] == '>' || statement[i] == '[' || statement[i] == ']' || statement[i] == '.' || statement[i] == ',')
                {
                    _commands[_length] = statement[i];
                    _length++;
                }
            }
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
                        {
                            _instructionPointer++;
                            while (_commands[_instructionPointer] != ']' || _bracket > 0)
                            {
                                if (_commands[_instructionPointer] == '[')
                                    _bracket++;
                                else if (_commands[_instructionPointer] == ']')
                                    _bracket--;
                                if (_instructionPointer < _commands.Length - 1)
                                    _instructionPointer++;
                            }
                        }
                        break;
                    case ']':
                        if (_virtualMemory[_pointer] != 0)
                        {
                            _instructionPointer--;
                            while (_commands[_instructionPointer] != '[' || _bracket > 0)
                            {
                                if (_commands[_instructionPointer] == ']')
                                    _bracket++;
                                else if (_commands[_instructionPointer] == '[')
                                    _bracket--;
                                if (_instructionPointer > 0)
                                    _instructionPointer--;
                            }
                        }
                        break;
                }
                _instructionPointer++;
            }
        }
    }
}