using Antlr4.Runtime;
using JsonParser;

bool salir = false;
string input = string.Empty;
string inputJson = string.Empty;

Console.WriteLine("Ingrese el JSON: ");
input = Console.ReadLine() ?? "";

do
{
    Console.Clear();

    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("Seleccione una acción para realizar\n" +
                          "1. Mostrar elemento actual\n" +
                          "2. Buscar un elemento\n" +
                          "ESCAPE para terminar\n");
    ConsoleKeyInfo key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.D1:
            break;
        case ConsoleKey.D2:
            Console.Write("¿Cuál elemento quiere?");
            input = Console.ReadLine() ?? "";
            break;
        case ConsoleKey.Escape:
            Console.WriteLine("El programa sera cerrado en breve...");
            return;
        default:
            continue;
    }

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Utilice una de las demas opciones antes de utilizar esta.");
        Console.ReadKey(true);
        continue;
    }
    var inputStream = CharStreams.fromString(input);
    var lexer = new JSONSearcherLexer(inputStream);
    var tokenStream = new CommonTokenStream(lexer);
    var parser = new JSONSearcherParser(tokenStream);
    var tree = parser.parse();
    var searcher = new JSONVisitors(inputJson);

    Console.WriteLine(Environment.NewLine);

    searcher.Visit(tree);

    Console.ReadKey(true);
} while (!salir);