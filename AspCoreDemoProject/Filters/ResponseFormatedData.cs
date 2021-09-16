using AspCoreDemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Filters
{
    public class ResponseFormatedData : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                int statusCode = (int)objectResult.StatusCode;
                if (statusCode == 200)
                {
                    objectResult.Value = new ResponseFormatData() { Message = "Success", Data = objectResult.Value, Status = (int)objectResult.StatusCode };
                }
                else
                {
                    objectResult.Value = new ResponseFormatData() { Message = "Failed", Error = objectResult.Value, Status = (int)objectResult.StatusCode };
                }
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                int statusCode = (int)objectResult.StatusCode;
                if (statusCode == 200)
                {
                    objectResult.Value = new ResponseFormatData() { Message = "Success", Data = objectResult.Value, Status = (int)objectResult.StatusCode };
                }
                else
                {
                    objectResult.Value = new ResponseFormatData() { Message = "Failed", Error = objectResult.Value, Status = (int)objectResult.StatusCode };
                }
            }
        }
    }
}
