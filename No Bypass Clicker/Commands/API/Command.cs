namespace NoBypass.Commands
{
    public abstract class Command
    {
        public bool Enabled;
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