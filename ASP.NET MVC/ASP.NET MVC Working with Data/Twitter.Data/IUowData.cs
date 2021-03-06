﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Models;

namespace Twitter.Data
{
    public interface IUowData : IDisposable
    {
        IRepository<Tweet> Tweets { get; }

        int SaveChanges();
    }
}
