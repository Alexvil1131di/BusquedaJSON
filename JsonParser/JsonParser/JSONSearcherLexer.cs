//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\olial\OneDrive\Escritorio\json\JsonParser\JsonParser\JSONSearcher by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class JSONSearcherLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FIRST=1, LAST=2, ID=3, DOT=4, LBRACK=5, RBRACK=6, INT=7, WS=8;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"FIRST", "LAST", "ID", "DOT", "LBRACK", "RBRACK", "INT", "WS"
	};


	public JSONSearcherLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public JSONSearcherLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'first'", "'last'", null, "'.'", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FIRST", "LAST", "ID", "DOT", "LBRACK", "RBRACK", "INT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "JSONSearcher"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static JSONSearcherLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\n', '\x37', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\a', '\x4', '!', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '$', 
		'\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x6', '\b', '-', '\n', '\b', '\r', '\b', 
		'\xE', '\b', '.', '\x3', '\t', '\x6', '\t', '\x32', '\n', '\t', '\r', 
		'\t', '\xE', '\t', '\x33', '\x3', '\t', '\x3', '\t', '\x2', '\x2', '\n', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x3', '\x2', '\x6', '\x5', '\x2', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x3', '\x2', '\x32', ';', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x39', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x13', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\a', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\t', '%', '\x3', '\x2', '\x2', '\x2', '\v', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\r', ')', '\x3', '\x2', '\x2', '\x2', '\xF', ',', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x31', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x14', '\a', 'h', '\x2', '\x2', '\x14', '\x15', '\a', 'k', '\x2', '\x2', 
		'\x15', '\x16', '\a', 't', '\x2', '\x2', '\x16', '\x17', '\a', 'u', '\x2', 
		'\x2', '\x17', '\x18', '\a', 'v', '\x2', '\x2', '\x18', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1A', '\a', 'n', '\x2', '\x2', '\x1A', 
		'\x1B', '\a', '\x63', '\x2', '\x2', '\x1B', '\x1C', '\a', 'u', '\x2', 
		'\x2', '\x1C', '\x1D', '\a', 'v', '\x2', '\x2', '\x1D', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', '\"', '\t', '\x2', '\x2', '\x2', '\x1F', 
		'!', '\t', '\x3', '\x2', '\x2', ' ', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'!', '$', '\x3', '\x2', '\x2', '\x2', '\"', ' ', '\x3', '\x2', '\x2', 
		'\x2', '\"', '#', '\x3', '\x2', '\x2', '\x2', '#', '\b', '\x3', '\x2', 
		'\x2', '\x2', '$', '\"', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', '\x30', 
		'\x2', '\x2', '&', '\n', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 
		']', '\x2', '\x2', '(', '\f', '\x3', '\x2', '\x2', '\x2', ')', '*', '\a', 
		'_', '\x2', '\x2', '*', '\xE', '\x3', '\x2', '\x2', '\x2', '+', '-', '\t', 
		'\x4', '\x2', '\x2', ',', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', 
		'\x2', '\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x10', '\x3', '\x2', '\x2', '\x2', '\x30', 
		'\x32', '\t', '\x5', '\x2', '\x2', '\x31', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x32', '\x33', '\x3', '\x2', '\x2', '\x2', '\x33', '\x31', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', '\x2', '\x2', '\x34', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\b', '\t', '\x2', 
		'\x2', '\x36', '\x12', '\x3', '\x2', '\x2', '\x2', '\x6', '\x2', '\"', 
		'.', '\x33', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
