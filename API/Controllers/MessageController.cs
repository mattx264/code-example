using Entiry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class MessageController : ApiController
    {
        public Message Get()
        {
            return new Message(){
                Msg="Hello World"
            };
        }
        public void Post(Message message)
        {

        }
    }
}
