//----------------------------------------------------------------------
// <copyright file="ManifestTests.cs" company="Stephen Jennings">
//   Copyright (c) 2011 Stephen Jennings
// </copyright>
//----------------------------------------------------------------------

namespace Fulcrum.Models.Tests.Assets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ManifestTests
    {
        [Test]
        public void Add_skuable_item_increase_count_by_one()
        {
            var skuId = "12345";
            var skuableMock = new Mock<Sku>();
            skuableMock.SetupProperty(item => item.SkuId, skuId);
            var sku = skuableMock.Object;

            var manifest = new Fulcrum.Models.Manifest();

            Assert.AreEqual(0, manifest[sku]);
            manifest.Add(sku);
            Assert.AreEqual(1, manifest[sku]);
        }

        [Test]
        public void Add_skuable_item_twice_increases_count_by_two()
        {
            var skuId = "12345";
            var skuableMock = new Mock<Sku>();
            skuableMock.Setup(item => item.SkuId).Returns(skuId);
            var sku = skuableMock.Object;

            var manifest = new Fulcrum.Models.Manifest();

            manifest.Add(sku);
            Assert.AreEqual(1, manifest[sku]);
            manifest.Add(sku);
            Assert.AreEqual(2, manifest[sku]);
        }

        [Test]
        public void Add_distinct_sku_objects_increases_count_by_two()
        {
            var skuId = "12345";
            var skuableMock1 = new Mock<Sku>();
            var skuableMock2 = new Mock<Sku>();
            skuableMock1.Setup(item => item.SkuId).Returns(skuId);
            skuableMock2.Setup(item => item.SkuId).Returns(skuId);
            var sku1 = skuableMock1.Object;
            var sku2 = skuableMock2.Object;
            Assert.AreNotSame(sku1, sku2);

            var manifest = new Fulcrum.Models.Manifest();

            manifest.Add(sku1);
            manifest.Add(sku2);
            Assert.AreEqual(2, manifest[sku1]);
            Assert.AreEqual(2, manifest[sku2]);
        }

        [Test]
        public void Remove_skuable_item_decreases_count_by_one()
        {
            var skuId = "12345";
            var skuableMock = new Mock<Sku>();
            skuableMock.SetupProperty(item => item.SkuId, skuId);
            var sku = skuableMock.Object;

            var manifest = new Fulcrum.Models.Manifest();
            manifest.Add(sku);

            Assert.AreEqual(1, manifest[sku]);
            manifest.Remove(sku);
            Assert.AreEqual(0, manifest[sku]);
        }

        [Test]
        public void Remove_skuable_item_twice_decreases_count_by_two()
        {
            var skuId = "12345";
            var skuableMock = new Mock<Sku>();
            skuableMock.Setup(item => item.SkuId).Returns(skuId);
            var sku = skuableMock.Object;

            var manifest = new Fulcrum.Models.Manifest();
            manifest.Add(sku);
            manifest.Add(sku);
            manifest.Add(sku);

            Assert.AreEqual(3, manifest[sku]);
            manifest.Remove(sku);
            manifest.Remove(sku);
            Assert.AreEqual(1, manifest[sku]);
        }

        [Test]
        public void Remove_distinct_sku_objects_decreases_count_by_two()
        {
            var skuId = "12345";
            var skuableMock1 = new Mock<Sku>();
            var skuableMock2 = new Mock<Sku>();
            skuableMock1.Setup(item => item.SkuId).Returns(skuId);
            skuableMock2.Setup(item => item.SkuId).Returns(skuId);
            var sku1 = skuableMock1.Object;
            var sku2 = skuableMock2.Object;
            Assert.AreNotSame(sku1, sku2);

            var manifest = new Fulcrum.Models.Manifest();
            manifest.Add(sku1);
            manifest.Add(sku1);
            manifest.Add(sku1);

            Assert.AreEqual(3, manifest[sku1]);
            Assert.AreEqual(3, manifest[sku2]);
            manifest.Remove(sku1);
            manifest.Remove(sku2);
            Assert.AreEqual(1, manifest[sku1]);
            Assert.AreEqual(1, manifest[sku2]);
        }
    }
}
