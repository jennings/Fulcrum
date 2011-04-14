//----------------------------------------------------------------------
// <copyright file="ProductAsset.cs" company="Stephen Jennings">
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
    /// A specific, uniquely-identifiable product asset.
    /// </summary>
    public class ProductAsset : IUniquelyIdentifiable
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the serial number.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the license plate.
        /// </summary>
        public string LicensePlate { get; set; }
    }
}
