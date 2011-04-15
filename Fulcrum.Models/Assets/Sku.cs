//----------------------------------------------------------------------
// <copyright file="Sku.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// An identifier for a class of assets.
    /// </summary>
    public class Sku
    {
        /// <summary>
        /// Gets or sets the SKU identifier.
        /// </summary>
        [Key]
        public virtual string SkuId { get; set; }

        /// <summary>
        /// Gets or sets the product this SKU represents, if applicable.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the part this SKU represents, if applicable.
        /// </summary>
        public virtual Part Part { get; set; }
    }
}
