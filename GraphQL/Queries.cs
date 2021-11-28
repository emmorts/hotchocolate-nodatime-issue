using System.Collections.Generic;
using Data;
using HotChocolate.Data;
using NodaTime;

namespace GraphQL
{
    public class Queries
    {
        [UseFiltering] // Comment this out to see everything working as intended
        public IList<Model> GetModels()
        {
            return new List<Model>
            {
                new()
                {
                    AnotherModel = new InnerModel
                    {
                        CreatedOn = SystemClock.Instance.GetCurrentInstant(),
                        AnotherDate = SystemClock.Instance.GetCurrentInstant()
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
