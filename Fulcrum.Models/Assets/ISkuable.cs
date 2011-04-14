//----------------------------------------------------------------------
// <copyright file="ISkuable.cs" company="Stephen Jennings">
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
    /// Represents a SKUable item; that is, a class of items identified by a SKU.
    /// </summary>
    public interface ISkuable
    {
        /// <summary>
        /// Gets the SKU for the asset.
        /// </summary>
        string Sku { get; }
    }
}
