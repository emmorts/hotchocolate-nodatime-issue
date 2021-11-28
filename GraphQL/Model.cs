using Data;
using NodaTime;

namespace GraphQL
{
    public class Model
    {
        public InnerModel? AnotherModel { get; set; }
        
        public Instant CreatedOn { get; set; }
    }
}
