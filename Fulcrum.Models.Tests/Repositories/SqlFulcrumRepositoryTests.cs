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
        private Mock<IFulcrumContext> contextMock;

        [SetUp]
        public void SetUp()
        {
            var companyDbSet = new ListDbSet<Company>();
            companyDbSet.Add(new Company() { Id = 1, Name = "Alpha Corporation" });
            companyDbSet.Add(new Company() { Id = 2, Name = "Bravo Corporation" });
            companyDbSet.Add(new Company() { Id = 3, Name = "Charlie Corporation" });
            companyDbSet.Add(new Company() { Id = 4, Name = "Delta Corporation" });

            var repo = new MockRepository(MockBehavior.Loose) { DefaultValue = Moq.DefaultValue.Mock };

            this.contextMock = repo.Create<IFulcrumContext>();
            this.contextMock.SetupGet(d => d.Companies).Returns(companyDbSet);
        }

        [Test]
        public void FindCompanyById_returns_null_if_id_does_not_exist()
        {
            var repo = new SqlFulcrumRepository(this.contextMock.Object);
            var company = repo.FindCompanyById(5);
            Assert.IsNull(company);
        }

        [Test]
        public void FindCompanyById_returns_the_right_company_if_it_exists()
        {
            var repo = new SqlFulcrumRepository(this.contextMock.Object);
            var returnedCompany = repo.FindCompanyById(3);
            Assert.AreEqual(3, returnedCompany.Id);
            Assert.AreEqual("Charlie Corporation", returnedCompany.Name);
        }
    }
}
