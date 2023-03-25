using Antlr4.Runtime;

namespace JsonParser;

internal class ImmediateErrorListener : BaseErrorListener
{
    static readonly Lazy<ImmediateErrorListener> instance = new(() => new ImmediateErrorListener());
    public static ImmediateErrorListener Instance
    {
        get
        {
            return instance.Value;
        }
    }
    public override void SyntaxError(
        TextWriter output,
        IRecognizer recognizer,
        IToken offendingSymbol,
        int line,
        int charPositionInLine,
        string msg,
        RecognitionException e)
    {
        throw new Antlr4.Runtime.Misc.ParseCanceledException($"Error en la línea {line} columna {charPositionInLine}: {msg}");
    }
}
