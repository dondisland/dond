using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        List<User> users = new List<User>() { new User { email = "bayirhalil@gmail.com", nickName = "HB", password = "2wes4443" } };

        public IHttpActionResult Login(User user)
        {
            var ifUser = users.FirstOrDefault(x => x.email.Equals(user.email) && x.nickName.Equals(user.nickName) && x.password.Equals(user.password));
            if (ifUser == null)
            {
                return Ok("bb");
            }
            return Ok("Giris Tamam");
        }


    }
}
