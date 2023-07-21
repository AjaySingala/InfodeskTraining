namespace ActionFilterDemo.Models
{
    public class InvalidPerson      // Does not implement IEntity.
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
