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
        private readonly FulcrumContext context;

        /// <summary>
        /// Initializes a new instance of the SqlFulcrumRepository class.
        /// </summary>
        /// <param name="connectionString">Connection string to the database.</param>
        public SqlFulcrumRepository(string connectionString)
        {
            this.context = new FulcrumContext(connectionString);
        }

        /// <summary>
        /// Initializes a new instance of the SqlFulcrumRepository class.
        /// </summary>
        /// <param name="context">The data context to use.</param>
        internal SqlFulcrumRepository(FulcrumContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Finds a company with the given Id, or null if it does not exist.
        /// </summary>
        /// <param name="id">The Id to find.</param>
        /// <returns>The company found, if any.</returns>
        public Company FindCompanyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
