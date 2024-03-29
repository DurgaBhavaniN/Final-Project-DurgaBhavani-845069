﻿using System;
using System.Collections.Generic;
using System.Text;
using Emart.BuyerService.Models;
using Emart.BuyerService.Repositories;
using NUnit.Framework;
namespace Emart.Test
{
    [TestFixture]
    public class TestBuyerService
    {
        BuyerRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new BuyerRepository(new EmartDBContext());
        }
        [Test]
        [Description("Test GetProfile()")]
        public void TestGetProfile()
        {
            var result = _repo.GetProfile("B4");
            Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test EditProfile()")]
        public void TestEditProfile()
        {
            Buyer b = _repo.GetProfile("B4");
            b.Password = "sai12";
            Buyer b1 = _repo.GetProfile("B4");
            Assert.AreSame(b, b1);
        }
        [Test]
        [Description("Test SearchItems()")]
        public void TestSearchItems()
        {
            var result = _repo.SearchItems("LG");
            Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test ")]
        public void TestBuyItem()
        {
            _repo.BuyItem(new TransactionHistory()
                {
                     Id="T548",
                     BuyerId="3",
                SellerId = "1",
                TransactionId = "T548",
                ItemId = "I89",
                NumberOfItems = "2",
                DateTime = DateTime.Now,
                Remarks = "NTNG",
                TransactionType = "Credit"
            });
            var result = _repo.TransactionHistory("3");
            Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test TransactionHistory()")]
        public void TestTransactionHistory()
        {
            var result = _repo.TransactionHistory("3");
            Assert.NotNull(result);

        }
        [Test]
        [Description("Test AddToCart()")]
        public void TestAddtoCart()
        {
            _repo.AddtoCart(new Cart()
            {
Id="C256",
CategoryId="C63",
SubcategoryId="SC26",
SellerId="2",
ItemId="I89",
Itemname="LG",
Price="14000",
Description="High Battery",
StockNumber="3",
Remarks="1",
Image="headset.jpg",
BuyerId="B4"
            });
            var result = _repo.ViewCart("B4","I98");
            Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test DeleteCartItems()")]
        public void TestDeleteCartItems()
        {
            _repo.DeleteCartItems("C308");
            var result = _repo.GetCartItem("C308");

            Assert.Null(result);
        }
        [Test]
        [Description("Test GetCartItems()")]
        public void TestGetCartItems()
        {
            var result = _repo.GetCartItems("B4");
            Assert.IsNotNull(result);
        }
    }
}
