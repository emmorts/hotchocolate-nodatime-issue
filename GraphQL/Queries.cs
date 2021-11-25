using System.Collections.Generic;
using Data;
using NodaTime;

namespace GraphQL
{
    public class Queries
    {
        public IList<Model> GetModels()
        {
            return new List<Model>
            {
                new()
                {
                    AnotherModel = new InnerModel
                    {
                        CreatedOn = SystemClock.Instance.GetCurrentInstant() 
                    },
                    CreatedOn = SystemClock.Instance.GetCurrentInstant()
                },
                new()
                {
                    AnotherModel = new InnerModel(),
                    CreatedOn = SystemClock.Instance.GetCurrentInstant()
                }
            };
        }
    }
}