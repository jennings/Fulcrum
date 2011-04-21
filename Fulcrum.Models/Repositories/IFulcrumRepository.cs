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
        IEnumerable<Company> FindCompanyById(int id);
    }
}
