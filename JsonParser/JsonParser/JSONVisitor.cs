﻿using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace JSONSearcher
{
    public class JSONVisitors : JSONSearcherBaseVisitor<string>
    {
        static string json = @"{
            ""firstName"": ""John"",
            ""lastName"": ""doe"",
            ""age"": 26,
            ""address"": {
                ""streetAddress"": ""naist street"",
                ""city"": ""Nara"",
                ""postalCode"": ""630-0192""
            },
            ""phoneNumbers"": [32,12,45]
        }";

        dynamic jsonObj = JsonConvert.DeserializeObject(json);

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
            var index = context.op.Type == JSONSearcherLexer.INT ? int.Parse(context.op.Text) :
                        context.op.Type == JSONSearcherLexer.FIRST ? 0 :
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
}