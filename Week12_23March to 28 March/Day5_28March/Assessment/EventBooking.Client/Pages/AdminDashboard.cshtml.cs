using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventBooking.Client.Pages;

public class AdminDashboardModel : PageModel
{
    private readonly ILogger<AdminDashboardModel> _logger;

    public AdminDashboardModel(ILogger<AdminDashboardModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Dashboard is handled via JavaScript/client-side
        // This page just serves the Razor page
    }
}
