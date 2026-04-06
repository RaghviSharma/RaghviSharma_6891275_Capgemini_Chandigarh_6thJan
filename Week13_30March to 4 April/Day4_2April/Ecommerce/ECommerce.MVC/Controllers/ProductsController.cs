using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{
    private readonly IHttpClientFactory _factory;

    public ProductsController(IHttpClientFactory factory)
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

        var products = await client.GetFromJsonAsync<List<Product>>("api/products");
        return View(products ?? new List<Product>());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        if (!ModelState.IsValid)
            return View(product);

        var client = _factory.CreateClient("API");
        SetAuthHeader(client);

        var response = await client.PostAsJsonAsync("api/products", product);
        if (response.IsSuccessStatusCode)
            return RedirectToAction("Index");

        ViewBag.Error = "Unable to create product.";
        return View(product);
    }
}