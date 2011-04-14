//----------------------------------------------------------------------
// <copyright file="Manifest.cs" company="Stephen Jennings">
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
    /// Represents a manifest of assets.
    /// </summary>
    public class Manifest
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Adds a uniquely identifiable item to the manifest.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IUniquelyIdentifiable item)
        {
        }

        /// <summary>
        /// Adds a nonspecific skuable item to the manifest.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(ISkuable item)
        {
        }

        /// <summary>
        /// Removes a uniquely identifiable item from the manifest.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(IUniquelyIdentifiable item)
        {
        }

        /// <summary>
        /// Removes a nonspecific skuable item from the manifest.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(ISkuable item)
        {
        }
    }
}
