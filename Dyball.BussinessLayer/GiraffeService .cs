using Dyball.Domain;

namespace Dyball.ServiceLayer
{
    public class GiraffeService : BaseAnimalService
    {

        public Giraffe[] _giraffes = new Giraffe[5] { new Giraffe(), new Giraffe(), new Giraffe(), new Giraffe(), new Giraffe() };

        public Giraffe[] Giraffes => _giraffes;

        const int LifeValue = 50;

        public GiraffeService()
        {
            InitializeGiraffe();
        }

        private void InitializeGiraffe()
        {
            Initialize(Giraffes);
            IsLive();
        }

        public void Feed()
        {
            InitializeGiraffe();
            IsLive();
        }

        public void ReduceGiraffeLife()
        {
            ReduceLifes(Giraffes);
            IsLive();
        }

        public void IsLive()
        {
            for (int i = 0; i < Giraffes.Length; i++)
            {
                if (Giraffes[i].FeedValue < LifeValue)
                {
                    Giraffes[i].IsLive = false;
                }
            }
        }
    }
}
