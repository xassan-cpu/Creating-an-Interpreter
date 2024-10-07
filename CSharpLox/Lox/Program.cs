﻿using System;

namespace Lox
{
    class Lox
    {
        public static bool hadError = false;

        public static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Usage: cslox [script]");
                Environment.Exit(64);
            }
            else if (args.Length == 1)
            {
                RunFile(args[0]);
            }
            else
            {
                RunPrompt();
            }
        }

        private static void RunFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string contents = sr.ReadToEnd();
                Run(contents);

                if (hadError) Environment.Exit(65);
            }
            
        }

        private static void RunPrompt()
        {
            while (true) 
            {
                Console.Write("> ");
                var line = Console.ReadLine();
                if (line == null) break;
                Run(line);
                hadError = false;
            }
        }

        private static void Run(string source)
        {
            Scanner scanner = new Scanner(source);
            List<Token> tokens = scanner.ScanTokens();

            foreach (Token token in tokens)
            {
                Console.WriteLine(token);
            }
        }

        public static void Error(int line, string message) 
        {
            Report(line, "", message);
        }

        private static void Report(int line, string where, string message) 
        {
            Console.Error.WriteLine($"[line {line}] Error{where}: {message}");
            hadError = true;
        }
    }
}