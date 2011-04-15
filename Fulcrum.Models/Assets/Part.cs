//----------------------------------------------------------------------
// <copyright file="Part.cs" company="Stephen Jennings">
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
    /// Reprents a type of part. For example, "104-K-123 oil drip pan", "IGK2930 steering wheel", "394K stick shift knob".
    /// </summary>
    public class Part
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the SKU.
        /// </summary>
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
