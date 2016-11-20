﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ServiceBus.EntityModels
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class ServiceBusDatabaseEntities : DbContext
{
    public ServiceBusDatabaseEntities()
        : base("name=ServiceBusDatabaseEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Basket> Baskets { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<BasketItem> BasketItems { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<BillingInformation> BillingInformations { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<StorageItem> StorageItems { get; set; }

    public virtual DbSet<CampaignItem> CampaignItems { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<OrderStatus> OrderStatus { get; set; }

}

}
