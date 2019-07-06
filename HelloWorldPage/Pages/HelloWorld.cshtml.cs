using Microsoft.AspNetCore.Mvc;
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
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Result => $"服务器于{DateTime.Now.ToString()}接收到用户{UserName}使用密码{Password}进行登录,登录结果：{LoginResult}";
        public string LoginResult { get; set; }
        public Task OnPost()
        {
            if(UserName == "superadmin" && Password == "123456")
            {
                LoginResult = "登录成功";
            }
            else
            {
                LoginResult = "密码错误";
            }
            return Task.CompletedTask;
        }
    }
}
