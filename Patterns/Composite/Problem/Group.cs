namespace Composite.Problem
{
    using System.Collections.Generic;

    public class Group
    {
        public Group()
        {
            this.Members = new List<Player>();
        }

        public string Name { get; set; }

        public List<Player> Members { get; set; }
    }
}