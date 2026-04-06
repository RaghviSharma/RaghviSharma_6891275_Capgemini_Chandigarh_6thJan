using Microsoft.AspNetCore.Mvc;

public class OrdersController : Controller
{
    private readonly IHttpClientFactory _factory;

    public OrdersController(IHttpClientFactory factory)
    {
        _factory = factory;
    }

    private void SetAuthHeader(System.Net.Http.HttpClient client)
    {
        var token = HttpContext.Session.GetString("AccessToken");
        if (!string.IsNullOrEmpty(token))
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
    }

    public async Task<IActionResult> Index()
    {
        var client = _factory.CreateClient("API");
        SetAuthHeader(client);

        var orders = await client.GetFromJsonAsync<List<Order>>("api/orders");
        return View(orders);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Order order)
    {
        var client = _factory.CreateClient("API");
        SetAuthHeader(client);

        var response = await client.PostAsJsonAsync("api/orders", order);

        if (response.IsSuccessStatusCode)
            return RedirectToAction("Success");

        ViewBag.Error = "Failed to place order. Please login again.";
        return View();
    }

    public IActionResult Success()
    {
        return View();
    }
}