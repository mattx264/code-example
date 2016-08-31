using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Controllers;
using Entiry.Entities;

namespace API.Tests.Controllers
{
    [TestClass]
    public class MessageControllerTest
    {
        private MessageController _controller;
        [TestInitialize]
        public void Setup()
        {
            _controller = new MessageController();
        }
        [TestMethod]
        public void Get()
        {
            Message result = _controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result.Msg);
            
        }
        [TestMethod]
        public void Post()
        {
            Message msg = new Message()
            {
                Msg="Hello API"
            };
            _controller.Post(msg);

         

        }
    }
}
