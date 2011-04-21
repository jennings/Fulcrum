//----------------------------------------------------------------------
// <copyright file="IFulcrumRepository.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A repository for Fulcrum entities.
    /// </summary>
    public interface IFulcrumRepository
    {
        /// <summary>
        /// Finds a company by the given Id, or null if it does not exist.
        /// </summary>
        /// <param name="id">The Id to find.</param>
        /// <returns>The company to find, if any.</returns>
        Company FindCompanyById(int id);
    }
}
