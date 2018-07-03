namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { private get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}