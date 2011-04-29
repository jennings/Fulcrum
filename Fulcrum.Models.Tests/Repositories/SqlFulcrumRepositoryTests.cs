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

        #region SetUp

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

        #endregion

        #region FindCompany Tests

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

            var returnedCompany2 = repo.FindCompanyById(4);
            Assert.AreEqual(4, returnedCompany2.Id);
            Assert.AreEqual("Delta Corporation", returnedCompany2.Name);
        }

        #endregion

        #region AddCompany Tests

        [Test]
        public void AddCompany_throws_on_null_input()
        {
            var repo = new SqlFulcrumRepository(this.contextMock.Object);
            Assert.Throws<ArgumentNullException>(() => repo.AddCompany(null));
        }

        [Test]
        public void AddCompany_throws_on_null_or_empty_name()
        {
            var companyWithNullName = new Company() { Name = null };
            var companyWithEmptyName = new Company() { Name = String.Empty };
            var repo = new SqlFulcrumRepository(this.contextMock.Object);

            Assert.Throws<ArgumentException>(() => repo.AddCompany(companyWithNullName));
            Assert.Throws<ArgumentException>(() => repo.AddCompany(companyWithEmptyName));
        }

        [Test]
        public void AddCompany_passes_valid_company_to_dbcontext()
        {
            var company = new Company() { Id = 5, Name = "Echo Corporation" };

            this.contextMock.Setup(c => c.Companies.Add(It.IsAny<Company>())).Verifiable();

            var repo = new SqlFulcrumRepository(this.contextMock.Object);
            repo.AddCompany(company);

            this.contextMock.Verify(c => c.Companies.Add(company));
        }

        [Test]
        public void AddCompany_passes_valid_company_with_default_id_to_dbcontext()
        {
            var company = new Company() { Name = "Echo Corporation" };

            this.contextMock.Setup(c => c.Companies.Add(It.IsAny<Company>())).Verifiable();

            var repo = new SqlFulcrumRepository(this.contextMock.Object);
            repo.AddCompany(company);

            this.contextMock.Verify(c => c.Companies.Add(company));
        }

        #endregion
    }
}
