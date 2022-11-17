using System;
using Antlr4.Runtime;
using ParseadorAritmetica;

namespace ParseadorAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string operacion = "2+6/3+2*13";

            Console.WriteLine($"Input: {operacion} \n");
            ICharStream charStream = CharStreams.fromString(operacion);
            aritmeticaLexer lexer = new aritmeticaLexer(charStream);
            CommonTokenStream token = new CommonTokenStream(lexer);
            aritmeticaParser parser = new aritmeticaParser(token);
            var tree = parser.aritmetica();
            Aritmetica aritmetica = new Aritmetica();
            int res = aritmetica.Visit(tree);
            

        }
    }
}
