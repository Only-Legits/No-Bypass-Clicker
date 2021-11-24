using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBypass.Commands
{
    public abstract class Command
    {
        public string InternalName, DisplayName;
        public int ID;

        public Command(string internalName, string displayName, int id)
        {
            InternalName = internalName;
            DisplayName = displayName;
            ID = id;
        }

        public abstract void Execute();
    }
}
