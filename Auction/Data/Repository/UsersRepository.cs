﻿using Auction.Data.Interfaces;
using Auction.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auction.Data.DB;

namespace Auction.Data.Repository
{
    public class UsersRepository : IUsers
    {
        private readonly ApplicationContext applicationContext;

        public UsersRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<User> Users => applicationContext.Users.Include(u=>u.lots).Include(u => u.bids);

        public User getUser(string userId) => applicationContext.Users.Include(u => u.lots).Include(u => u.bids).FirstOrDefault(u => u.Id == userId);
    }
}
