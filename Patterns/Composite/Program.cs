namespace Composite
{
    using System;
    using System.Collections.Generic;

    using Composite.Problem;

    public class Program
    {
        private static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Monster and gained {0} coins!", goldForKill);

            IParticipant andy = new Player { Name = "Andy" };
            IParticipant jane = new Player { Name = "Jane" };
            IParticipant eve = new Player { Name = "Eve" };
            IParticipant ann = new Player { Name = "Ann" };
            IParticipant edith = new Player { Name = "Edith" };
            IParticipant oldBob = new Player { Name = "Old Bob" };
            IParticipant newBob = new Player { Name = "New Bob" };
            IParticipant bobs = new Group { Members = { oldBob, newBob } };
            IParticipant developers = new Group { Name = "Developers", Members = { andy, jane, eve, bobs } };

            IParticipant participants = new Group { Members = { developers, ann, edith } };
            participants.Gold += goldForKill;
            participants.Stats();

            Console.ReadKey();
        }
    }
}