using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    abstract class ExpressionSyntax : SyntaxNode
    {
    }

    sealed class NumberExpressionSyntax : ExpressionSyntax
    {
        public NumberExpressionSyntax(SyntaxToken numberToken)
        {
            NumberToken = numberToken;
        }

        public override SyntaxKind Kind => SyntaxKind.NumberExpression;

        public SyntaxToken NumberToken { get; }
    }

    sealed class BinaryExpressionSyntax : ExpressionSyntax
    {
        public BinaryExpressionSyntax(ExpressionSyntax left, SyntaxToken opertorToken, ExpressionSyntax right)
        {
            Left = left;
            OperatorToken = opertorToken;
            Right = right; 
        }
        public ExpressionSyntax Left { get; }
        public SyntaxNode OperatorToken { get; }
        public ExpressionSyntax Right { get; }
        

        public override SyntaxKind Kind => SyntaxKind.BinaryExpression;
    
    }
}
