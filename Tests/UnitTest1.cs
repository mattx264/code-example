//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Entiry.Entities;
//using TypeMock.ArrangeActAssert;
//using System.Net.Http;

//namespace Tests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        private Message message;
//        [TestInitialize]
//        public void SetUp()
//        {
//            message = Isolate.Fake.Instance<Message>();
//        }
//        [TestMethod]
//        public void GetMessage()
//        {
//            // Arrange
//            var controller = new ProductsController(repository);
//            controller.Request = new HttpRequestMessage();
//            controller.Configuration = new HttpConfiguration();

//            // Act
//            var response = controller.Get(10);

//            // Assert
//            Product product;
//            Assert.IsTrue(response.TryGetContentValue<Product>(out product));
//            Assert.AreEqual(10, product.Id);
//        }
//        [TestMethod]
//        public void PostMessage()
//        {

//        }
//    }
//}
