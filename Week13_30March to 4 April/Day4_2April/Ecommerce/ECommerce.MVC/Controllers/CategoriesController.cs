using Microsoft.AspNetCore.Mvc;

public class CategoriesController : Controller
{
    private readonly IHttpClientFactory _factory;

    public CategoriesController(IHttpClientFactory factory)
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

        var categories = await client.GetFromJsonAsync<List<Category>>("api/categories");
        return View(categories ?? new List<Category>());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        if (!ModelState.IsValid)
            return View(category);

        var client = _factory.CreateClient("API");
        SetAuthHeader(client);

        var response = await client.PostAsJsonAsync("api/categories", category);
        if (response.IsSuccessStatusCode)
            return RedirectToAction("Index");

        ViewBag.Error = "Unable to create category.";
        return View(category);
    }
}