﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ThermalConductivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalConductivityTestsBase
    {
        protected abstract double BtusPerHourFootFahrenheitInOneWattPerMeterKelvin { get; }
        protected abstract double WattsPerMeterKelvinInOneWattPerMeterKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BtusPerHourFootFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double WattsPerMeterKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void WattPerMeterKelvinToThermalConductivityUnits()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ThermalConductivity.From(1, ThermalConductivityUnit.BtuPerHourFootFahrenheit).BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(1, ThermalConductivity.From(1, ThermalConductivityUnit.WattPerMeterKelvin).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void As()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.BtuPerHourFootFahrenheit), BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.WattPerMeterKelvin), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);

            var btuperhourfootfahrenheitQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.BtuPerHourFootFahrenheit);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, (double)btuperhourfootfahrenheitQuantity.Value, BtusPerHourFootFahrenheitTolerance);
            Assert.Equal(ThermalConductivityUnit.BtuPerHourFootFahrenheit, btuperhourfootfahrenheitQuantity.Unit);

            var wattpermeterkelvinQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.WattPerMeterKelvin);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, (double)wattpermeterkelvinQuantity.Value, WattsPerMeterKelvinTolerance);
            Assert.Equal(ThermalConductivityUnit.WattPerMeterKelvin, wattpermeterkelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(1, ThermalConductivity.FromBtusPerHourFootFahrenheit(wattpermeterkelvin.BtusPerHourFootFahrenheit).WattsPerMeterKelvin, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(1, ThermalConductivity.FromWattsPerMeterKelvin(wattpermeterkelvin.WattsPerMeterKelvin).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalConductivity v = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(-1, -v.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity.FromWattsPerMeterKelvin(3)-v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity.FromWattsPerMeterKelvin(10)/5).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, ThermalConductivity.FromWattsPerMeterKelvin(10)/ThermalConductivity.FromWattsPerMeterKelvin(5), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalConductivity oneWattPerMeterKelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            ThermalConductivity twoWattsPerMeterKelvin = ThermalConductivity.FromWattsPerMeterKelvin(2);

            Assert.True(oneWattPerMeterKelvin < twoWattsPerMeterKelvin);
            Assert.True(oneWattPerMeterKelvin <= twoWattsPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin > oneWattPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin >= oneWattPerMeterKelvin);

            Assert.False(oneWattPerMeterKelvin > twoWattsPerMeterKelvin);
            Assert.False(oneWattPerMeterKelvin >= twoWattsPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin < oneWattPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin <= oneWattPerMeterKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Equal(0, wattpermeterkelvin.CompareTo(wattpermeterkelvin));
            Assert.True(wattpermeterkelvin.CompareTo(ThermalConductivity.Zero) > 0);
            Assert.True(ThermalConductivity.Zero.CompareTo(wattpermeterkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentNullException>(() => wattpermeterkelvin.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ThermalConductivity a = ThermalConductivity.FromWattsPerMeterKelvin(1);
            ThermalConductivity b = ThermalConductivity.FromWattsPerMeterKelvin(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ThermalConductivity v = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.True(v.Equals(ThermalConductivity.FromWattsPerMeterKelvin(1), ThermalConductivity.FromWattsPerMeterKelvin(WattsPerMeterKelvinTolerance)));
            Assert.False(v.Equals(ThermalConductivity.Zero, ThermalConductivity.FromWattsPerMeterKelvin(WattsPerMeterKelvinTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(null));
        }
    }
}
