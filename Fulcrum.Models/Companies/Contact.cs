//----------------------------------------------------------------------
// <copyright file="Contact.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a person who is associated with one or many companies.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the contact's id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the contact's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the contact's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the contact's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the companies associated with the contact.
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; }
    }
}
