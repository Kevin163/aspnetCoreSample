using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldPage.Pages
{
    public class HelloWorld:PageModel
    {
        public string Msg => "Hello World from pageModel";
        public string DateTimeNow => DateTime.Now.ToString();
    }
}
