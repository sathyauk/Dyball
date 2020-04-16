
using Dyball.Domain;

namespace Dyball.ServiceLayer
{
    public class AnimalService : IAnimalService
    {

        private readonly ElephantService _elephantService;
        private readonly GiraffeService _giraffeService;
        private readonly MonkeyService _monkeyService;

        public Elephant[] Elephants { get; set; }
        public Giraffe[] Giraffes { get; set; }
        public Monkey[] Monkeys { get; set; }


        public AnimalService()
        {
            _elephantService = new ElephantService();
            _giraffeService = new GiraffeService();
            _monkeyService = new MonkeyService();

            Initialize();
        }


        private void Initialize()
        {
            Elephants = _elephantService.Elephants;
            Giraffes = _giraffeService.Giraffes;
            Monkeys = _monkeyService.Monkeys;
        }

        public void ReduceLife()
        {
            _monkeyService.ReduceMonkeyLife();
            _elephantService.ReduceElephantLife();
            _giraffeService.ReduceGiraffeLife();

            Initialize();
        }

        public void Feed()
        {
            _elephantService.Feed();

            _giraffeService.Feed();

            _monkeyService.Feed();

            Initialize();
        }
    }
}
