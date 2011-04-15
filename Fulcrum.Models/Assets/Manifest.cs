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
        private Dictionary<string, int> skuCounts = new Dictionary<string, int>();

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Returns the count of an item on this manifest.
        /// </summary>
        /// <param name="sku">The SKU to check</param>
        /// <returns>The count of the SKU on this manifest.</returns>
        public virtual int this[Sku sku]
        {
            get
            {
                if (this.skuCounts.ContainsKey(sku.SkuId))
                {
                    return this.skuCounts[sku.SkuId];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (this.skuCounts.ContainsKey(sku.SkuId))
                {
                    this.skuCounts[sku.SkuId]++;
                }
                else
                {
                    this.skuCounts[sku.SkuId] = 1;
                }
            }
        }

        /// <summary>
        /// Adds a nonspecific skuable item to the manifest.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public virtual void Add(Sku item)
        {
            if (this[item] > 0)
            {
                this.skuCounts[item.SkuId]++;
            }
            else
            {
                this.skuCounts[item.SkuId] = 1;
            }
        }

        /// <summary>
        /// Removes a nonspecific skuable item from the manifest.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public virtual void Remove(Sku item)
        {
            if (this[item] > 0)
            {
                this.skuCounts[item.SkuId]--;
            }
            else
            {
                throw new InvalidOperationException("Cannot decrease count of SKU '" + item.SkuId + "' below zero.");
            }
        }
    }
}
