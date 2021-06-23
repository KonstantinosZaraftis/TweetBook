using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TweetBook.Data
{
    public class DataContex : IdentityDbContext
    {
        public DataContex(DbContextOptions<DataContex> options)
            : base(options)
        {
        }
    }
}
