namespace WebApplication1.Models.ProductServices
{
    public class ProductServuce : IproductService
    {
        #region Feilds
        private readonly List<Product> _products;
        #endregion

        #region Constractor
        public ProductServuce()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = "10.00" },
                new Product { Id = 2, Name = "Product 2", Price = "20.00" },
                new Product { Id = 3, Name = "Product 3", Price = "30.00" }
            };
        }
        #endregion

        #region Functions
        public List<Product> GetAllProducts()
        {
            return _products;
        }
        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }
        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }

        }
        #endregion

    }
}
