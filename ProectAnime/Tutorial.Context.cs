﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProectAnime
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TutorialEntities1 : DbContext
    {
        public TutorialEntities1()
            : base("name=TutorialEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgentSet> AgentSet { get; set; }
        public virtual DbSet<ClientSet> ClientSet { get; set; }
        public virtual DbSet<ProviderSet> ProviderSet { get; set; }
        public virtual DbSet<sdelkaSet> sdelkaSet { get; set; }
    }
}
