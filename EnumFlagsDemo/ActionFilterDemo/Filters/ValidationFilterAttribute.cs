using ActionFilterDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterDemo.Filters
{
    public class ValidationFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("ValidationFilterAttribute.OnActionExecuting...");
            Console.WriteLine($"Action {context.ActionDescriptor.DisplayName} executing...");
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is IEntity);
            if(param.Value == null)
            {
                context.Result = new BadRequestObjectResult("Only IEntity type can be used.");
                return;
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("ValidationFilterAttribute.OnActionExecuted...");
            Console.WriteLine($"Action {context.ActionDescriptor.DisplayName} executed...");
        }
    }
}
