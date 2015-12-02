using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    /// <summary>
    /// vedi
    /// http://www.asp.net/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api
    /// </summary>
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };


        // OK
        //var uri = 'api/products';
        // questo è di tipo GET
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return products;
        //}


        // OK
        //public Product[] GetAllProducts()
        //{
        //    return products;
        //}

        // OK
        //public Product[] GetProducts()
        //{
        //    return products;
        //}


        // OK
        //[HttpGet]
        //public Product[] Products()
        //{
        //    return products;
        //}

        // OK
        //[HttpGet]
        //[ActionName("Products")]
        //public Product[] RestituisciListProdotti()
        //{
        //    return products;
        //}

        //OK
        // questo dimostra che basta che contenga la parola "Products"
        //public IEnumerable<Product> GetQualsiasiStringaProducts()
        //{
        //    return products;
        //}

        // OK
        // funziona anche se non la contiene la parola "Preoducts".... non è chiaro
        //public IEnumerable<Product> GetQualsiasiStringaProd()
        //{
        //    return products;
        //}

        // OK
        //public IEnumerable<Product> GetXXXX()
        //{
        //    return products;
        //}


        // OK
        // dimostra che basta che ci sia scritto "Get"!
        //public Product[] GetXXXXXXX()
        //{
        //    return products;
        //}


        // OK
        // funziona di conseguenza al metodo sopra definito "public Product[] GetXXXXXXX()"
        //[HttpGet]
        //public Product[] XXXXXXX()
        //{
        //    return products;
        //}

        
        // se lascio due metodi GET allora NON funziona
        [HttpGet]
        public Product[] YYYYY()
        {
            return products;
        }


        //var uri = 'api/products/id';
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
