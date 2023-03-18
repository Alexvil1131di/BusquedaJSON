using Antlr4.Runtime;
using JsonParser;

bool salir = false;
string input = string.Empty;

do
{
    Console.Clear();

    Console.WriteLine(JSONVisitors.json + Environment.NewLine);

    Console.WriteLine("Seleccione una acción para realizar\n" +
                          "1. Mostrar elemento actual\n" +
                          "2. Buscar child por nombre y/o posicion\n" +
                          "3. Primer child\n" +
                          "4. Último child\n" +
                          "ESCAPE para terminar\n");
    ConsoleKeyInfo key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.D1:
            break;
        case ConsoleKey.D2:
            Console.Write("¿Cuál elemento quiere? (use un punto '.' para buscar sub-elementos): ");
            input = Console.ReadLine() ?? "";
            break;
        case ConsoleKey.D3:
            Console.Write("¿Cuál elemento quiere? (Indique una pocisión iniciando con 1 segun el número de elementos): ");
            int indice = Convert.ToInt32(Console.ReadLine());
            input += $"[{--indice}]";
            break;
        case ConsoleKey.D4:
            Console.Write("Especifique el elemento padre (use un punto '.' para buscar sub-elementos): ");
            input = Console.ReadLine() ?? "";
            input += "[last]";
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
    var searcher = new JSONVisitors();

    Console.WriteLine(Environment.NewLine);

    searcher.Visit(tree);

    Console.ReadKey(true);
} while (!salir);