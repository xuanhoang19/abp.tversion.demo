﻿using System;
using System.Collections.Generic;
using TVersion.Entities;
using TVersion.Models;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace TVersion.Users
{
    /* This entity shares the same table/collection ("AbpUsers" by default) with the
     * IdentityUser entity of the Identity module.
     *
     * - You can define your custom properties into this class.
     * - You never create or delete this entity, because it is Identity module's job.
     * - You can query users from database with this entity.
     * - You can update values of your custom properties.
     */
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser, ICreatedEntity, IUpdatedEntity
    {
        #region Base properties

        /* These properties are shared with the IdentityUser entity of the Identity module.
         * Do not change these properties through this class. Instead, use Identity module
         * services (like IdentityUserManager) to change them.
         * So, this properties are designed as read only!
         */

        public Guid? TenantId { get; private set; }

        public string UserName { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Email { get; private set; }

        public bool EmailConfirmed { get; private set; }

        public string PhoneNumber { get; private set; }

        public bool PhoneNumberConfirmed { get; private set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;

        public Guid CreatedById { get; set; }

        public DateTime? DateUpdated { get; set; }

        public Guid UpdatedById { get; set; }

        //public virtual ICollection<Entity> CreatedByEntities { get; set; }
        //public virtual ICollection<Entity> UpdatedByEntities { get; set; }

        #endregion

        /* Add your own properties here. Example:
         *
         * public string MyProperty { get; set; }
         *
         * If you add a property and using the EF Core, remember these;
         *
         * 1. Update TVersionDbContext.OnModelCreating
         * to configure the mapping for your new property
         * 2. Update TVersionEfCoreEntityExtensionMappings to extend the IdentityUser entity
         * and add your new property to the migration.
         * 3. Use the Add-Migration to add a new database migration.
         * 4. Run the .DbMigrator project (or use the Update-Database command) to apply
         * schema change to the database.
         */

        private AppUser()
        {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            //CreatedByEntities = new HashSet<Entity>();
            //UpdatedByEntities = new HashSet<Entity>();
        }
    }
}
