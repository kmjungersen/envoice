using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Envoice.Data.Models;

namespace Envoice.Data
{
    public class EnvoiceDataContext : DbContext
    {

        public EnvoiceDataContext(DbContextOptions<EnvoiceDataContext> options) : base(options)
        {
        }

        public DbSet<InvoiceModel> Invoices { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EventModel>()
        //        .Map(m => m.Requires("IsDeleted").HasValue(false))
        //        .Ignore(m => m.IsDeleted);

        //    modelBuilder.Entity<EventInstanceModel>()
        //        .Map(m => m.Requires("IsDeleted").HasValue(false))
        //        .Ignore(m => m.IsDeleted);

        //    modelBuilder.Entity<EntityModel>()
        //        .Map(m => m.Requires("IsDeleted").HasValue(false))
        //        .Ignore(m => m.IsDeleted);

        //    modelBuilder.Entity<VipModel>()
        //        .Map(m => m.Requires("IsDeleted").HasValue(false))
        //        .Ignore(m => m.IsDeleted);
        //}

        //private readonly static Dictionary<Type, EntitySetBase> _mappingCache =
        //    new Dictionary<Type, EntitySetBase>();

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries()
        //              .Where(p => p.State == EntityState.Deleted))
        //        SoftDelete(entry);

        //    return base.SaveChanges();
        //}

        //private void SoftDelete(DbEntityEntry entry)
        //{
        //    Type entryEntityType = entry.Entity.GetType();

        //    string tableName = GetTableName(entryEntityType);
        //    string primaryKeyName = GetPrimaryKeyName(entryEntityType);

        //    string sql =
        //        string.Format(
        //            "UPDATE {0} SET IsDeleted = 1 WHERE {1} = @id",
        //                tableName, primaryKeyName);

        //    Database.ExecuteSqlCommand(
        //        sql,
        //        new SqlParameter("@id", entry.OriginalValues[primaryKeyName]));

        //    // prevent hard delete            
        //    entry.State = EntityState.Detached;
        //}

        //private string GetTableName(Type type)
        //{
        //    EntitySetBase es = GetEntitySet(type);

        //    return string.Format("[{0}].[{1}]",
        //        es.MetadataProperties["Schema"].Value,
        //        es.MetadataProperties["Table"].Value);
        //}

        //private string GetPrimaryKeyName(Type type)
        //{
        //    EntitySetBase es = GetEntitySet(type);

        //    return es.ElementType.KeyMembers[0].Name;
        //}

        //private EntitySetBase GetEntitySet(Type type)
        //{
        //    if (!_mappingCache.ContainsKey(type))
        //    {
        //        ObjectContext octx = ((IObjectContextAdapter)this).ObjectContext;

        //        string typeName = ObjectContext.GetObjectType(type).Name;

        //        var es = octx.MetadataWorkspace
        //            .GetItemCollection(DataSpace.SSpace)
        //            .GetItems<EntityContainer>()
        //            .SelectMany(c => c.BaseEntitySets
        //            .Where(e => e.Name == typeName))
        //            .FirstOrDefault();

        //        if (es == null)
        //            throw new ArgumentException("Entity type not found in GetTableName", typeName);

        //        _mappingCache.Add(type, es);
        //    }

        //    return _mappingCache[type];
        //}
    }
}
