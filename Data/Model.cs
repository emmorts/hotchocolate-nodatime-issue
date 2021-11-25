using NodaTime;

namespace Data
{
    public class Model
    {
        public InnerModel AnotherModel { get; set; }
        
        public Instant CreatedOn { get; set; }
    }
}
