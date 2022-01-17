namespace WebApplication1.Models
{
    public class Product
    {
        public Product(int Id, String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
