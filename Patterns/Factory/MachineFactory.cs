namespace Factory
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class MachineFactory
    {
        private Dictionary<string, Type> machines;

        public MachineFactory()
        {
            this.LoadTypesICanReturn();
        }

        // public static IMachine CreateInstance(string description)
        public IMachine CreateInstance(string description)
        {
            Type t = this.GetTypeToCreate(description);

            if (t == null)
            {
                return new UnknownMachine();
            }

            return Activator.CreateInstance(t) as IMachine;
        }

        private Type GetTypeToCreate(string machineName)
        {
            foreach (var machine in this.machines)
            {
                if (machine.Key.Contains(machineName))
                {
                    return this.machines[machine.Key];
                }
            }

            return null;
        }

        private void LoadTypesICanReturn()
        {
            this.machines = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IMachine).ToString()) != null)
                {
                    this.machines.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}