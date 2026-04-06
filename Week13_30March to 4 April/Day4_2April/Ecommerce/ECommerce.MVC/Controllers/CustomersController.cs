using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IHttpClientFactory _factory;

        public CustomersController(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        private void SetAuthHeader(HttpClient client)
        {
            var token = HttpContext.Session.GetString("AccessToken");
            if (!string.IsNullOrEmpty(token))
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<IActionResult> Index()
        {
            var client = _factory.CreateClient("API");
            SetAuthHeader(client);

            var customers = await client.GetFromJsonAsync<List<Customer>>("api/customers");
            return View(customers ?? new List<Customer>());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (!ModelState.IsValid)
                return View(customer);

            var client = _factory.CreateClient("API");
            SetAuthHeader(client);

            var response = await client.PostAsJsonAsync("api/customers", customer);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            ViewBag.Error = "Unable to create customer.";
            return View(customer);
        }
    }
}