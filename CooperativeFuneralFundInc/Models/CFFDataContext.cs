﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class CFFDataContext:DbContext
    {

        public CFFDataContext(DbContextOptions<CFFDataContext> options) : base(options) { }
        public DbSet<SupplyRequest> SupplyRequests { get; set; }
        public DbSet<ClientSupplier> ClientSuppliers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<OwnerName> OwnerNames { get; set; }
        public DbSet<SupplyRequestType> SupplyRequestTypes { get; set; }
        public DbSet<SuppyRequestOrigin> SuppyRequestOrigins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyRequest>().HasData
         (
               new SupplyRequest
               {
                   SupplyRequestId=1,
                   SupplyRequestStatusID = 1,
                   StatusComments = "test",
                   OrderItemsID = 1,
                   SuppyRequestOriginId = 1,
                   SupplyRequestTypeID = 1,
                   ClientSupplierID = 1,
                   OwnerNameID = 1,
                   CreatedBy = "Test",
                   CreateTime = "Test",
                   UpdatedBy = "Test"
               }
               );


        modelBuilder.Entity<SupplyRequestStatus>().HasData(

               new SupplyRequestStatus
               {
                   SupplyRequestStatusID = 1,
                   SupplyRequestStatusName = "New"
               },
               new SupplyRequestStatus
               {
                   SupplyRequestStatusID = 2,
                   SupplyRequestStatusName = "In-Process"
               },
               new SupplyRequestStatus
               {
                   SupplyRequestStatusID = 3,
                   SupplyRequestStatusName = "Completed"
               },
               new SupplyRequestStatus
               {
                   SupplyRequestStatusID = 4,
                   SupplyRequestStatusName = "On hold"
               },
               new SupplyRequestStatus
               {
                   SupplyRequestStatusID = 5,
                   SupplyRequestStatusName = "Cancelled"
               }
         );

            modelBuilder.Entity<OrderItems>().HasData
                (
                    new OrderItems
                    {
                        OrderItemsID = 1,
                        OrderItemsName = "Preneed agreement"
                    },
                    new OrderItems
                       {
                        OrderItemsID = 2,
                        OrderItemsName = "Account update/Claim form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 3,
                        OrderItemsName = "Itemizations form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 4,
                        OrderItemsName = "Return envelopes."
                    },
                    new OrderItems
                    {
                        OrderItemsID = 5,
                        OrderItemsName = "Postage paid envelopes."
                    },
                    new OrderItems
                    {
                        OrderItemsID = 6,
                        OrderItemsName = "Deposit tickets"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 7,
                        OrderItemsName = "Planning guides"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 8,
                        OrderItemsName = "Funding your funeral in advance brochure"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 9,
                        OrderItemsName = "Monthly monitors"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 10,
                        OrderItemsName = "Service and merchandise forms"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 11,
                        OrderItemsName = "Investment election form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = 12,
                        OrderItemsName = "Other"
                    }
                );
            modelBuilder.Entity<SuppyRequestOrigin>().HasData(

                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 1,
                        SuppyRequestOriginName = "Phone"
                    },
                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 2,
                        SuppyRequestOriginName = "Fax"
                    },
                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 3,
                        SuppyRequestOriginName = "Email"
                    },
                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 4,
                        SuppyRequestOriginName = "Mail"
                    },
                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 5,
                        SuppyRequestOriginName = "Regional manager"
                    },
                    new SuppyRequestOrigin
                    {
                        SuppyRequestOriginId = 6,
                        SuppyRequestOriginName = "Other"
                    }
                );
            modelBuilder.Entity<SupplyRequestType>().HasData(
                new SupplyRequestType { SupplyRequestTypeID = 1, SupplyRequestTypeName = "Vendor" },
                new SupplyRequestType { SupplyRequestTypeID = 2, SupplyRequestTypeName = "Client" }
                );

            modelBuilder.Entity<ClientSupplier>().HasData(
                new ClientSupplier { ClientSupplierID = 1, ClientSupplierName = "Client 1" },
                new ClientSupplier { ClientSupplierID = 2, ClientSupplierName = "Client 2" }
                );

            modelBuilder.Entity<OwnerName>().HasData(
                
                new OwnerName { OwnerNameID=1,OwnerNameName="Person 1"}
                
                
                );

            modelBuilder.Entity<NotesSection>().HasData(
                new NotesSection {NotesSectionId=1, SupplyRequestId = 1, Note = "Test note", CreatedBy = "Developer" }
                );
            
        }
    }
}