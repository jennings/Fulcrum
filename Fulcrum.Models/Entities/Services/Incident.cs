//----------------------------------------------------------------------
// <copyright file="Incident.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// A support incident which may or may not result in changing of assets.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Gets or sets the incident id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the incident's company.
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the incident's contact.
        /// </summary>
        public virtual Contact Contact { get; set; }
    }
}
