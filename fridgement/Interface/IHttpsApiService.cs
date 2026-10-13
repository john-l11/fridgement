using System.Net.Http.Json;

namespace fridgement.Interface
{
    // this is going to be the interface where all the API calls are going to be defined
    interface IHttpsApiService
    {
        public Task<List<Product>> GetProducts();
        public void PostProduct();
        public void PutProduct(Product product);
        public void DeleteProduct(Product product);
    }

    // this is where we actually make the functions for the API calls
    class HttpsApiService: IHttpsApiService
    {
        private readonly HttpClient _httpClient;

        public HttpsApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("")
            };
        }

        /// <summary>
        /// This function will be used to delete a selected product from the database
        /// </summary>
        /// <param name="product">This is the product to be deleted from the database</param>
        /// <exception cref="NotImplementedException">Currently being developed</exception>
        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function will be used to make a call to the API to get all the products
        /// that are stored in the database/cache.
        /// </summary>
        /// <returns>The list of products that are stored</returns>
        /// <exception cref="NotImplementedException">Currently being developed</exception>
        public async Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function will be used to create products and store it on the database
        /// </summary>
        /// <exception cref="NotImplementedException">Currently being developed</exception>
        public async void PostProduct()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function will be used to update a product that is stored on the database
        /// </summary>
        /// <param name="product">This is the product that is to be updated in the database</param>
        /// <exception cref="NotImplementedException">Currently being developed</exception>
        public void PutProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
