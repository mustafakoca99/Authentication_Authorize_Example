using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorize.Filters
{
    public class TimeTakenFilter : IActionFilter
    {

        private Stopwatch timer;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context != null)
            {
                timer = Stopwatch.StartNew();
            }

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context != null)
            {

                if (timer != null)
                {
                    timer.Stop();


                    string result = "geçen zaman: " + $"{timer.Elapsed.TotalMilliseconds}";

                    if (result != null)
                    {
                        Debug.WriteLine(result, "acction logged!!!");
                    }
                }


            }

        }
    }
}
