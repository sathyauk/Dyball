using System;

namespace Dyball.ServiceLayer
{
    public class BaseAnimalService
    {
        internal void Initialize(dynamic[] animalObject)
        {
            if (animalObject.Length > 0)
            {
                var random = new System.Random();
                var feedValue = random.Next(10, 25);
                try
                {
                    for (int i = 0; i < animalObject.Length; i++)
                    {
                        if (animalObject[i].FeedValue <= 100 && animalObject[i].FeedValue > 0 && animalObject[i].IsLive)
                        {
                            animalObject[i].FeedValue = animalObject[i].FeedValue + feedValue;
                        }
                        if (animalObject[i].FeedValue > 100)
                        {
                            animalObject[i].FeedValue = 100;
                        }
                    }
                }
                catch(Exception ex)
                {
                    //Log exception
                    throw ex;
                }
            }
        }

        internal void ReduceLifes(dynamic[] animalObject)
        {
            var random = new System.Random();
            var feedValue = 0;

            try
            {
                if (animalObject.Length > 0)
                {
                    for (int i = 0; i < animalObject.Length; i++)
                    {
                        feedValue = random.Next(0, 20);

                        if (animalObject[i].FeedValue <= 100 && animalObject[i].FeedValue > 0 && animalObject[i].IsLive)
                        {
                            animalObject[i].FeedValue = animalObject[i].FeedValue - feedValue;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                //Log exception
                throw ex;
            }


        }

    }
}
