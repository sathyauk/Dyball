using Dyball.Domain;

namespace Dyball.ServiceLayer
{
    public class ElephantService : BaseAnimalService
    {
        
        public Elephant[] _elephants = new Elephant[5] { new Elephant(), new Elephant(), new Elephant(), new Elephant(), new Elephant() };

        public Elephant[] Elephants => _elephants;

        const int LifeValue = 70;

        public ElephantService()
        {
            InitializeElephant();
        }

        private void InitializeElephant()
        {
            Initialize(Elephants);
            IsLive();
        }

        public void CanWalk()
        {
            for (int i = 0; i < Elephants.Length; i++)
            {
                if (Elephants[i].FeedValue <= LifeValue)
                {
                    Elephants[i].CanWalk = false;
                }
            }
        }


        public void IsLive()
        {
            for(int i = 0; i < Elephants.Length; i++)
            {
                if(Elephants[i].FeedValue <= LifeValue && Elephants[i].CanWalk == false)
                {
                    Elephants[i].IsLive = false;
                }
            }
        }

        public void ReduceElephantLife()
        {
            ReduceLifes(Elephants);
            IsLive();
            CanWalk();
        }
        
        public void Feed()
        {
            InitializeElephant();
            CanWalk();
        }
    }
}
