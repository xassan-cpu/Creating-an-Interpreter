﻿namespace Lox
{
    public class Token(TokenType type, string lexeme, object literal, int line)
    {
        readonly TokenType type = type;
        readonly string lexeme = lexeme;
        readonly object literal = literal;
        readonly int line = line;

        public override string ToString()
        { return $"{type} {lexeme} {literal}"; }
    }
}