using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProductManagement.Filters
{
	public class CustomExceptionFilter : IExceptionFilter
	{
		public void OnException(ExceptionContext context)
		{
			context.Result = new ContentResult
			{
				Content = "Something went wrong. Please try again later.",
				StatusCode = 500
			};

			context.ExceptionHandled = true;
		}
	}
}