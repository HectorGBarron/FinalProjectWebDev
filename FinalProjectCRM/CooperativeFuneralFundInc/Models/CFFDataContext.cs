﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using CooperativeFuneralFundInc.Models.TasksManagement;
using CooperativeFuneralFundInc.Models.UserManagement;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class CFFDataContext:IdentityDbContext<User>
    {

        public CFFDataContext(DbContextOptions<CFFDataContext> options) : base(options) { }
        public DbSet<SupplyRequest> SupplyRequests { get; set; }
        public DbSet<ClientSupplier> ClientSuppliers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Owner> OwnerNames { get; set; }
        public DbSet<RequestType> SupplyRequestTypes { get; set; }
        public DbSet<RequestOrigin> RequestOrigins { get; set; }

        public DbSet<TaskManagement> TaskManagements { get; set; }

        public DbSet<PhoneNumberType> NumberTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TaskManagement>().HasData(
                new TaskManagement
                {
                    TaskManagementId=1,
                    StatusID=1,
                    OwnerID=1,
                    RelatedTo="Test",
                    RelatedToName="Test",
                    RequestTypeID=1,
                    Priority=1,
                    CreateBy="Test",
                    UpdatedBy="Test"
                }
                );

            modelBuilder.Entity<SupplyRequest>().HasData
         (
               new SupplyRequest
               {
                   SupplyRequestId=1,
                   StatusID = 1,
                   StatusComments = "test",
                   OrderItemsID = 1,
                   RequestOriginId = 1,
                   RequestTypeID = 1,
                   ClientSupplierID = 1,
                   OwnerID = 1,
                   CreatedBy = "Test",
                   CreateTime = "Test",
                   UpdatedBy = "Test"
               }
               );


        modelBuilder.Entity<Status>().HasData(

               new Status
               {
                   StatusID = 1,
                   StatusDescription = "New"
               },
               new Status
               {
                   StatusID = 2,
                   StatusDescription = "In-Process"
               },
               new Status
               {
                   StatusID = 3,
                   StatusDescription = "Completed"
               },
               new Status
               {
                   StatusID = 4,
                   StatusDescription = "On hold"
               },
               new Status
               {
                   StatusID = 5,
                   StatusDescription = "Cancelled"
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
            modelBuilder.Entity<RequestOrigin>().HasData(

                    new RequestOrigin
                    {
                        RequestOriginId = 1,
                        RequestOriginDescription = "Phone"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = 2,
                        RequestOriginDescription = "Fax"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = 3,
                        RequestOriginDescription = "Email"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = 4,
                        RequestOriginDescription = "Mail"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = 5,
                        RequestOriginDescription = "Regional manager"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = 6,
                        RequestOriginDescription = "Other"
                    }
                );
            modelBuilder.Entity<RequestType>().HasData(
                new RequestType { RequestTypeID = 1, RequestTypeDescription = "Vendor" },
                new RequestType { RequestTypeID = 2, RequestTypeDescription = "Client" }
                );

            modelBuilder.Entity<ClientSupplier>().HasData(
                new ClientSupplier { ClientSupplierID = 1, ClientSupplierName = "Client 1" },
                new ClientSupplier { ClientSupplierID = 2, ClientSupplierName = "Client 2" }
                );

            modelBuilder.Entity<Owner>().HasData(
                
                new Owner { OwnerID=1,OwnerName="Person 1"}
                
                
                );

            modelBuilder.Entity<NotesSection>().HasData(
                new NotesSection {NotesSectionId=1, RequestOriginId = 1, Note = "Test note", CreatedBy = "Developer" }
                );


            modelBuilder.Entity<PhoneNumberType>().HasData(
                new PhoneNumberType { Id = "home", Name = "Home" },
                new PhoneNumberType { Id = "mobile", Name = "Mobile" },
                new PhoneNumberType { Id = "work", Name = "work" },
                new PhoneNumberType { Id = "other", Name = "Other" }

  );

        }





        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "Admin";
            string password = "Sesame";
            string roleName = "Admin";
            string fName = "Admin";
            string lName = "Admin";
            string numberType = "Other";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username, firstName=fName,lastName=lName,numberType=numberType };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}