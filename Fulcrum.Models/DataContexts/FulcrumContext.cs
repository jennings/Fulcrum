//----------------------------------------------------------------------
// <copyright file="FulcrumContext.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.DataContexts
{
    using System.Data.Entity;

    /// <summary>
    /// A data context for Fulcrum entities.
    /// </summary>
    public class FulcrumContext : DbContext
    {
        /// <summary>
        /// Gets or sets companies in this data context.
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets contacts in this data context.
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets corporations in this data context.
        /// </summary>
        public DbSet<Corporation> Corporations { get; set; }

        /// <summary>
        /// Gets or sets incidents in this data context.
        /// </summary>
        public DbSet<Incident> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the parts in this data context.
        /// </summary>
        public DbSet<Part> Parts { get; set; }

        /// <summary>
        /// Gets or sets the products in this data context.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the product assets in this data context.
        /// </summary>
        public DbSet<ProductAsset> ProductAssets { get; set; }
    }
}
