using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind { get; }
    }
}
