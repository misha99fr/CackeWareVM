using AeroVM.lib.memory;
using AeroVM.lib;
using System;

namespace AeroVM.bytecode
{
    class Parser
    {
        public static void parse()
        {
            Lexer lexer = new Lexer(Lexer.readBytes(@"TESTS\test.avm"));
            for (int i = 0; i < Token.Tokens.Count; i++)
            {
                TokenType current = Token.Tokens.ToArray()[i];
                string currentValue = Token.TokensValues.ToArray()[i];
                if (current == TokenType.WORD)
                {
                    if(currentValue == "HALT")
                    {
                        Console.WriteLine("halt");
                    }
                }
            }
        }
    }
}
