using System;
using System.IO;
using System.Collections.Generic;
using AeroVM.lib;

namespace AeroVM.bytecode
{
    class Lexer
    {
        public byte[] byte_code = { };
        private static byte[] byte_code_st = { };
        private List<Registers.Registerts> regs = new List<Registers.Registerts>();
        public Lexer(byte[] byte_code)
        {
            this.byte_code = byte_code;
            byte_code_st = byte_code;
            analize();
        }
        public byte[] getByteCode()
        {
            return byte_code;
        }
        public void setByteCode(byte[] bytes)
        {
            byte_code = bytes;
            byte_code_st = bytes;
        }
        public List<Registers.Registerts> getRegisters()
        {
            return regs;
        }
        public void setRegisters(List<Registers.Registerts> regs_1)
        {
            regs = regs_1;
        }
        public static byte[] readBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
        private static void analize()
        {
            if (byte_code_st.Length != 0)
            {
                for (int i = 0; i < byte_code_st.Length; i++)
                {
                    byte current = byte_code_st[i];
                    tokenize(current);
                }
            }
        }
        private static void tokenize(byte cByte)
        {
            char aChar = (char)cByte;
            if (char.IsLetter(aChar)) tokenizeWord(aChar);
            else if (lib.memory.Token.lastToken == TokenType.WORD) lib.memory.Token.addToken(TokenType.WORD, lib.memory.Buffers.StringBuffer.ToString());
        }
        private static void tokenizeWord(char aChar)
        {
            lib.memory.Buffers.StringBuffer.Append(aChar);
            lib.memory.Token.lastToken = TokenType.WORD;
        }
    }
}
