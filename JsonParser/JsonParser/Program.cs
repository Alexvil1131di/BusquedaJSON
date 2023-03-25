using Antlr4.Runtime;
using JsonParser;

try
{
    string input = string.Empty;
    var searcher = new JSONVisitors();

    while (searcher.jsonObj.Count > 0)
    {
        Console.Clear();
        Console.WriteLine(searcher.json);
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Seleccione una acción para realizar\n" +
                                "1. Mostrar elemento buscado anteriormente\n" +
                                "2. Buscar un elemento\n" +
                                "ESCAPE para terminar\n");
        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                Console.Write("Inserte la busqueda que desea realizar: ");
                input = Console.ReadLine() ?? string.Empty;
                break;
            case ConsoleKey.Escape:
                Console.Clear();
                return;
            default:
                continue;
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Intente denuevo con una operacion valida. \nPresione cualquier tecla para continuar...");
            Console.ReadKey(true);
            continue;
        }
        var inputStream = CharStreams.fromString(input);
        var lexer = new JSONSearcherLexer(inputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new JSONSearcherParser(tokenStream);
        var tree = parser.parse();

        Console.WriteLine(Environment.NewLine);

        searcher.Visit(tree);

        Console.ReadKey(true);
    }
}
catch (Exception ex)
{
    Console.Write(ex.Message);
}
finally
{
    Console.Write("Presione cualquier tecla para continuar...");
    Console.ReadKey(true);
}