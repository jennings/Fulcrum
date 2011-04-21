//----------------------------------------------------------------------
// <copyright file="SqlFulcrumRepositoryTests.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.Tests.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using Fulcrum.Models.DataContexts;
    using Fulcrum.Models.Repositories;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class SqlFulcrumRepositoryTests
    {
        [Test]
        public void FindCompanyById_returns_no_companies_if_id_does_not_exist()
        {
            var contextMock = new Mock<FulcrumContext>();
            contextMock.SetupAllProperties();

            var context = contextMock.Object;
            context.Companies.Add(new Company() { Id = 1, Name = "Alpha" });
            context.Companies.Add(new Company() { Id = 2, Name = "Bravo" });
            context.Companies.Add(new Company() { Id = 3, Name = "Charlie" });
            context.Companies.Add(new Company() { Id = 4, Name = "Delta" });

            var repo = new SqlFulcrumRepository(context);
            var company = repo.FindCompanyById(5);
            Assert.IsNull(company);
        }
    }
}
