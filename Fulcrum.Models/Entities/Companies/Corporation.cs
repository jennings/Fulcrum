//----------------------------------------------------------------------
// <copyright file="Corporation.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// A corporation which is composed of many companies.
    /// </summary>
    public class Corporation
    {
        /// <summary>
        /// Gets or sets the corporation's id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the corporation's companies.
        /// </summary>
        public ICollection<Company> Companies { get; set; }
    }
}
