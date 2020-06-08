using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind { get; }

        public static implicit operator SyntaxNode(SyntaxToken v)
        {
            throw new NotImplementedException();
        }
    }
}
