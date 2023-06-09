﻿using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeliveryServiceDomain.Tests
{
    public class AdditionalServiceShipmentTests
    {
        private readonly AdditionalServiceShipment _sut;
        public AdditionalServiceShipmentTests()
        {
            _sut = new AdditionalServiceShipment();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(200, 200)]
        public void SetAdditionalServiceId_PositiveInt_Theory(int expected, int id)
        {
            _sut.SetAdditionalServiceId(id);
            Assert.Equal(expected, _sut.GetAdditionalServiceId());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-199)]
        public void SetAdditionalServiceId_NegativeIntOrZero_Theory(int id)
        {
            Assert.Throws<ArgumentException>(() => _sut.SetAdditionalServiceId(id));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(200, 200)]
        public void SetShipmentId_PositiveInt_Theory(int expected, int id)
        {
            _sut.SetShipmentId(id);
            Assert.Equal(expected, _sut.GetShipmentId());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-199)]
        public void SetShipmentId_NegativeIntOrZeroTheory(int id)
        {
            Assert.Throws<ArgumentException>(() => _sut.SetShipmentId(id));
        }

        [Fact]
        public void SetAdditionalService_NullObject_Fact()
        {
            Assert.Throws<ArgumentNullException>(() => _sut.SetAdditionalService(null));
        }

        [Fact]
        public void SetAdditionalService_Fact()
        {
            var adss = A.Fake<AdditionalService>();
            _sut.SetAdditionalService(adss);

            Assert.Equal(adss, _sut.GetAdditionalService());
        }

        [Fact]
        public void SetShipment_NullObject_Fact()
        {
            Assert.Throws<ArgumentNullException>(() => _sut.SetShipment(null));
        }

        [Fact]
        public void SetShipment_Fact()
        {
            var shp = A.Fake<Shipment>();
            _sut.SetShipment(shp);

            Assert.Equal(shp, _sut.GetShipment());
        }


    }
}
