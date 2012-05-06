Brainfuck (esolang)
===================

Urban Muller created brainfuck in 1993 with the intention of designing a language which could be implemented with the smallest possible compiler,[2] inspired by the 1024-byte compiler for the FALSE programming language.[3] Several brainfuck compilers have been made smaller than 200 bytes. The classic distribution is Muller's version 2, containing a compiler for the Amiga, an interpreter, example programs, and a readme document.

The language consists of eight commands, listed below. A brainfuck program is a sequence of these commands, possibly interspersed with other characters (which are ignored). The commands are executed sequentially, except as noted below; an instruction pointer begins at the first command, and each command it points to is executed, after which it normally moves forward to the next command. The program terminates when the instruction pointer moves past the last command.

The brainfuck language uses a simple machine model consisting of the program and instruction pointer, as well as an array of at least 30,000 byte cells initialized to zero; a movable data pointer (initialized to point to the leftmost byte of the array); and two streams of bytes for input and output (most often connected to a keyboard and a monitor respectively, and using the ASCII character encoding).

">"		increment the data pointer (to point to the next cell to the right).

"<"		decrement the data pointer (to point to the next cell to the left).

"+"		increment (increase by one) the byte at the data pointer.

"-"		decrement (decrease by one) the byte at the data pointer.

"."		output the byte at the data pointer as an ASCII encoded character.

","		accept one byte of input, storing its value in the byte at the data pointer.

"["		if the byte at the data pointer is zero, then instead of moving the instruction pointer forward to the next command, jump it forward to the command after the matching ] command*.

"]"		if the byte at the data pointer is nonzero, then instead of moving the instruction pointer forward to the next command, jump it back to the command after the matching [ command*.

http://en.wikipedia.org/wiki/Brainfuck