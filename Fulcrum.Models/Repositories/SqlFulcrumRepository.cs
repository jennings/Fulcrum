//----------------------------------------------------------------------
// <copyright file="SqlFulcrumRepository.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fulcrum.Models.DataContexts;

    /// <summary>
    /// A Fulcrum repository that persists back to a Microsoft SQL Server.
    /// </summary>
    public class SqlFulcrumRepository : IFulcrumRepository
    {
        public SqlFulcrumRepository(FulcrumContext context)
        {
        }

        public IEnumerable<Company> FindCompanyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
