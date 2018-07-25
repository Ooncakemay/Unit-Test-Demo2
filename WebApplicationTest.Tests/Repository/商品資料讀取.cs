﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using WebApplicationTest.Models;
using WebApplicationTest.Repository;

namespace WebApplicationTest.Tests.Repository
{
    [TestClass]
    public class 商品資料讀取
    {
        [TestMethod]
        public void 首頁_商品_讀取全部資料()
        {
            //Arrange
            var ProductRepository = Substitute.For<IRepository>();
            List<Product> ProductList = new List<Product>()
            {
                 new Product{ Id=1, Name="商品1", IsEnable=true, Price=100 },
                 new Product{ Id=1, Name="商品2", IsEnable=true, Price=100 },
                 new Product{ Id=1, Name="商品3", IsEnable=true, Price=100 }
            };
            ProductRepository.GetAllProduct().Returns(ProductList);
            //Act
            var Result = ProductRepository.GetAllProduct();
            //Assert
            Assert.AreEqual(ProductList, Result);
        }
        [TestMethod]
        public void 首頁_商品_讀取單筆資料()
        {

        }
    }
}
