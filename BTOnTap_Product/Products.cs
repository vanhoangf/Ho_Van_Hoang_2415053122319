namespace BTONTAP
{
    internal class Products
    {
        public string Product {  get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category {  get; set; }

        public Products() { }
        public Products(string product, int id, string name, double price, string category)
        {
            this.Product = product;
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }

        public override string ToString()
        {
            return $"Product: {this.Product}\nId: {this.Id}\nName: {this.Name}\nPrice: {this.Price}\nCategory: {this.Category}\n";
        }
    }
}
