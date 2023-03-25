using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace JsonParser;

public class JSONVisitors : JSONSearcherBaseVisitor<dynamic>
{
    public readonly dynamic jsonObj = new Dictionary<string, object>();
    public string json = string.Empty;

    public JSONVisitors()
    {
        try
        {
            string jsonFilePath = @"..\..\..\file.json";
            json = File.ReadAllText(jsonFilePath);
            jsonObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(json)!;
        }
        catch (Exception ex)
        {
            string str = ex switch
            {
                FileNotFoundException => "El archivo no ha sido encontrado en la ruta espericifada, por favor asegurese de que el archivo exista.\nRuta correcta del archivo: BusquedaJSON\\JsonParser\\JsonParser",
                JsonSerializationException => "El json ingresado esta incorrecto, por favor verifique que no hayan caracteres faltantes o mal colocados.",
                _ => "Error en servicio"
            };
            Console.WriteLine(str);
        }
    }

    public override dynamic VisitChild([NotNull] JSONSearcherParser.ChildContext context)
    {
        try
        {
            dynamic value;
            var identificador = context.ID().GetText();

            var expresion = Visit(context.expr());
            if (expresion is string)
            {
                value = jsonObj[expresion][identificador];
                Console.WriteLine($"Valor de {expresion}.{identificador}: {value}");
            }
            else
            {
                value = expresion[identificador];
                Console.WriteLine($"Valor de {identificador}: {value}");
            }

            return value;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public override dynamic VisitChildAttribute([NotNull] JSONSearcherParser.ChildAttributeContext context)
    {
        try
        {
            dynamic value;
            var expresion = Visit(context.expr());

            if (expresion is string)
            {
                int index = context.op.Type == JSONSearcherLexer.INT ? int.Parse(context.op.Text) :
                            context.op.Type == JSONSearcherLexer.FIRST ? 0 :
                            context.op.Type == JSONSearcherLexer.LAST ? jsonObj[expresion].Count - 1 :
                            jsonObj[-1].Count - 1;
                value = jsonObj[expresion][index];
                Console.WriteLine($"Valor de {expresion}[{index}]: {value}");
            }
            else
            {
                int index = context.op.Type == JSONSearcherLexer.INT ? int.Parse(context.op.Text) :
                            context.op.Type == JSONSearcherLexer.FIRST ? 0 :
                            context.op.Type == JSONSearcherLexer.LAST ? expresion.Count - 1 :
                            expresion.Count - 1;
                value = expresion[index];
                Console.WriteLine($"Valor de {index}: {value}");
            }

            return value;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public override dynamic VisitParent([NotNull] JSONSearcherParser.ParentContext context)
    {
        try
        {
            var identificador = context.ID().GetText();

            var value = jsonObj[identificador];

            Console.WriteLine($"Valor de {identificador}: {value}");

            return identificador;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public override dynamic VisitParse([NotNull] JSONSearcherParser.ParseContext context)
    {
        try
        {
            return base.VisitParse(context);
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}