using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class EditorStateGraph
    {
        public Dictionary<string, State> States = new Dictionary<string, State>();
        public Dictionary<string, Transition> Transitions = new Dictionary<string, Transition>();
    }
}
