﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteControl.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RCContext : DbContext
    {
        public RCContext()
            : base("name=RCContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Camera> Camera { get; set; }
        public virtual DbSet<LANController> LANController { get; set; }
        public virtual DbSet<UserCamera> UserCamera { get; set; }
        public virtual DbSet<Button> ButtonSet { get; set; }
        public virtual DbSet<Queue> QueueSet { get; set; }
    }
}
