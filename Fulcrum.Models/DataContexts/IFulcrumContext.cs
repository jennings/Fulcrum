//----------------------------------------------------------------------
// <copyright file="IFulcrumContext.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.DataContexts
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// An interface for the FulcrumContext for mocking purposes.
    /// </summary>
    public interface IFulcrumContext
    {
        /// <summary>
        /// Gets or sets companies in this data context.
        /// </summary>
        IDbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets contacts in this data context.
        /// </summary>
        IDbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets corporations in this data context.
        /// </summary>
       IDbSet<Corporation> Corporations { get; set; }

        /// <summary>
        /// Gets or sets incidents in this data context.
        /// </summary>
        IDbSet<Incident> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the parts in this data context.
        /// </summary>
        IDbSet<Part> Parts { get; set; }

        /// <summary>
        /// Gets or sets the products in this data context.
        /// </summary>
        IDbSet<Product> Products { get; set; }
    }
}
