﻿using Microsoft.EntityFrameworkCore;
using Resume.DAL.Model;

namespace Resume.DAL.Context
{
    public class ResumeContext : DbContext
    {
        #region Constructor
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
        {
        }
        #endregion
        #region DbSets
        public DbSet<User> Users{ get; set; }
        #endregion
    }
}
