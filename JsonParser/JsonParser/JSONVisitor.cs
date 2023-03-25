using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace JsonParser;

public class JSONVisitors : JSONSearcherBaseVisitor<string>
{
    private readonly string jsonStr;
    private readonly dynamic jsonObj;

    public JSONVisitors(string jsonStr)
    {
        this.jsonStr = jsonStr;
        jsonObj = JsonConvert.DeserializeObject(jsonStr) ?? throw new Exception("Error en servicio");
    }

    public override string VisitChild([NotNull] JSONSearcherParser.ChildContext context)
    {
        var expresion = Visit(context.expr());
        var identificador = context.ID().GetText();

        var value = jsonObj[expresion][identificador];

        Console.WriteLine($"Valor de {expresion}.{identificador}: {value}");

        return value.ToString();
    }

    public override string VisitChildAttribute([NotNull] JSONSearcherParser.ChildAttributeContext context)
    {
        var expresion = Visit(context.expr());
        int index = context.op.Type == JSONSearcherLexer.INT ? int.Parse(context.op.Text) :
                    context.op.Type == JSONSearcherLexer.FIRST ? 0 :
                    context.op.Type == JSONSearcherLexer.LAST ? jsonObj[expresion].Count - 1 :
                    jsonObj[expresion].Count - 1;




        var value = jsonObj[expresion][index];

        Console.WriteLine($"Valor de {expresion}[{index}]: {value}");

        return value.ToString();
    }

    public override string VisitParent([NotNull] JSONSearcherParser.ParentContext context)
    {
        var identificador = context.ID().GetText();

        var value = jsonObj[identificador];

        Console.WriteLine($"Valor de {identificador}: {value}");

        return identificador;
    }

    public override string VisitParse([NotNull] JSONSearcherParser.ParseContext context)
    {
        return base.VisitParse(context);
    }
}