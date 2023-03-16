using Antlr4.Runtime;
using JSONSearcher;

Console.WriteLine("Escribe el objeto al que desea acceder");

string input;

input = Console.ReadLine() ?? string.Empty;

var inputStream = CharStreams.fromString(input);
var lexer = new JSONSearcherLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new JSONSearcherParser(tokenStream);
var tree = parser.parse();
var searcher = new JSONVisitors();

searcher.Visit(tree);