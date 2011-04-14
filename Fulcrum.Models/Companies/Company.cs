//----------------------------------------------------------------------
// <copyright file="Company.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a company.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets the id of the company.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent corporation.
        /// </summary>
        public virtual Corporation Corporation { get; set; }

        /// <summary>
        /// Gets or sets the company's contacts.
        /// </summary>
        public virtual ICollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the company's incidents.
        /// </summary>
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
