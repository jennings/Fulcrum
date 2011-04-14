//----------------------------------------------------------------------
// <copyright file="IUniquelyIdentifiable.cs" company="Stephen Jennings">
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
    /// Represents an item which can be uniquely identified, either with a license plate, serial number, or both.
    /// </summary>
    public interface IUniquelyIdentifiable
    {
        /// <summary>
        /// Gets or sets the serial number, a vendor-provided unique identifier.
        /// </summary>
        string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the license plate, a self-selected unique identifier.
        /// </summary>
        string LicensePlate { get; set; }
    }
}
