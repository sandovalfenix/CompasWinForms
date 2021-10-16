using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compas
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static HttpClient client = new HttpClient();

        [STAThread]
        static void Main()
        {
            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "webApi/product", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<Product> GetProductAsync(string path)
        {

            Product product = null;

            HttpResponseMessage response = client.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return product;
        }

        public static async Task<List<Product>> GetProductsAsync(string path)
        {

            List<Product> listProducts = null;
            
            HttpResponseMessage response = client.GetAsync(path).Result;
            
            if (response.IsSuccessStatusCode)
            {
                listProducts = await response.Content.ReadAsAsync<List<Product>>();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return listProducts;
        }
        public static async Task<string> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"webApi/product", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"webApi/product/{id}");
            return response.StatusCode;
        }
    }
}
