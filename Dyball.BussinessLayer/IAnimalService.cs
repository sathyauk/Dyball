
using Dyball.Domain;

namespace Dyball.ServiceLayer
{
    public interface IAnimalService
    {
        void Feed();

        void ReduceLife();

        Elephant[] Elephants { get; set; }
        Giraffe[] Giraffes { get; set; }
        Monkey[] Monkeys { get; set; }
    }
}
