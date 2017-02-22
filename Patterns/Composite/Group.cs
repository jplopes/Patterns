namespace Composite
{
    using System.Collections.Generic;

    public class Group : IParticipant
    {
        public Group()
        {
            this.Members = new List<IParticipant>();
        }

        public string Name { get; set; }

        public List<IParticipant> Members { get; set; }

        public double Gold
        {
            get
            {
                double totalGold = 0;
                foreach (IParticipant member in this.Members)
                {
                    totalGold += member.Gold;
                }

                return totalGold;
            }

            set
            {
                double eachSplit = value / this.Members.Count;
                double leftOver = value % this.Members.Count;
                foreach (IParticipant member in this.Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (IParticipant member in this.Members)
            {
                member.Stats();
            }
        }
    }
}