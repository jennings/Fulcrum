﻿//----------------------------------------------------------------------
// <copyright file="FulcrumContext.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.DataContexts
{
    using System;
    using System.Data.Entity;

    /// <summary>
    /// A data context for Fulcrum entities.
    /// </summary>
    internal class FulcrumContext : DbContext, IFulcrumContext
    {
        /// <summary>
        /// Initializes a new instance of the FulcrumContext class.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        internal FulcrumContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Gets or sets companies in this data context.
        /// </summary>
        public IDbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets contacts in this data context.
        /// </summary>
        public IDbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets corporations in this data context.
        /// </summary>
        public IDbSet<Corporation> Corporations { get; set; }

        /// <summary>
        /// Gets or sets incidents in this data context.
        /// </summary>
        public IDbSet<Incident> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the parts in this data context.
        /// </summary>
        public IDbSet<Part> Parts { get; set; }

        /// <summary>
        /// Gets or sets the products in this data context.
        /// </summary>
        public IDbSet<Product> Products { get; set; }
    }
}
