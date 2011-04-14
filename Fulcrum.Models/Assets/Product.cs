//----------------------------------------------------------------------
// <copyright file="Product.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Reprents a type of product. For example, "Toyota Camry", "Honda Civic", "Volkswagen GTI".
    /// </summary>
    public class Product : ISkuable
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the SKU.
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
