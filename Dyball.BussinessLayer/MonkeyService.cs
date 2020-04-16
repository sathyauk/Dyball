using Dyball.Domain;


namespace Dyball.ServiceLayer
{
    public class MonkeyService : BaseAnimalService
    {

        public Monkey[] _monkeys = new Monkey[5] { new Monkey(), new Monkey(), new Monkey(), new Monkey(), new Monkey() };

        public Monkey[] Monkeys => _monkeys;

        const int LifeValue = 30;


        public MonkeyService()
        {
            InitializeMonkey();
        }

        private void InitializeMonkey()
        {
            Initialize(Monkeys);
            IsLive();
        }

        public void Feed()
        {
            InitializeMonkey();
            IsLive();
        }

        public void ReduceMonkeyLife()
        {
            ReduceLifes(Monkeys);
            IsLive();
        }

        public void IsLive()
        {
            for (int i = 0; i < Monkeys.Length; i++)
            {
                if (Monkeys[i].FeedValue < LifeValue)
                {
                    Monkeys[i].IsLive = false;
                }
            }
        }
    }
}
