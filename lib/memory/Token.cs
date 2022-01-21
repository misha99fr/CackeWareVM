using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroVM.lib.memory
{
    class Token
    {
        public static TokenType lastToken;
        public static List<TokenType> Tokens = new List<TokenType>();
        public static List<string> TokensValues = new List<string>();

        public static void addToken(TokenType tk, string value)
        {
            Tokens.Add(tk);
            TokensValues.Add(value);
        }
    }
}
