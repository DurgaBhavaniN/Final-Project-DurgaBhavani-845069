﻿using Emart.BuyerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.BuyerService.Repositories
{
    public interface IBuyerRepository
    {
        List<Items> SearchItems(string name);
        void BuyItem(TransactionHistory item);
        void EditProfile(Buyer obj);
        List<Items> GetAllItems();
        void AddtoCart(Cart cart);
        List<Cart> GetCartItems(string bid);
        void DeleteCartItems(string Id);
        Buyer GetProfile(string bid);
        List<TransactionHistory> TransactionHistory(string bid);
        bool ViewCart(string bid,string itemid);
        Cart GetCartItem(string cartid);
        List<Category> GetCategory();
        List<SubCategory> SubCategory(string catid);
        int GetCount(string bid);
    }
}
