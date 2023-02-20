using Microsoft.CodeAnalysis;


namespace CSharp.SourceGen.Extensions;


internal static class SymbolExtensions
{
    public static string SuggestedFileName(this ITypeSymbol symbol)
    {
        return symbol.ToDisplayString()
            .Replace('<', '[')
            .Replace('>', ']') + ".g.cs";
    }
}