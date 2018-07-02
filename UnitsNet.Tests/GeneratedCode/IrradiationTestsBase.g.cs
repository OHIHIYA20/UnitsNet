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
    /// Test of Irradiation.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class IrradiationTestsBase
    {
        protected abstract double JoulesPerSquareMeterInOneJoulePerSquareMeter { get; }
        protected abstract double KilowattHoursPerSquareMeterInOneJoulePerSquareMeter { get; }
        protected abstract double WattHoursPerSquareMeterInOneJoulePerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulesPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilowattHoursPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double WattHoursPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void JoulePerSquareMeterToIrradiationUnits()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.KilowattHoursPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.WattHoursPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.JoulePerSquareMeter).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.KilowattHourPerSquareMeter).KilowattHoursPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.WattHourPerSquareMeter).WattHoursPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.JoulePerSquareMeter), JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.KilowattHourPerSquareMeter), KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.WattHourPerSquareMeter), WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);

            var joulepersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.JoulePerSquareMeter);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, (double)joulepersquaremeterQuantity.Value, JoulesPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareMeter, joulepersquaremeterQuantity.Unit);

            var kilowatthourpersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.KilowattHourPerSquareMeter);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, (double)kilowatthourpersquaremeterQuantity.Value, KilowattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.KilowattHourPerSquareMeter, kilowatthourpersquaremeterQuantity.Unit);

            var watthourpersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.WattHourPerSquareMeter);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, (double)watthourpersquaremeterQuantity.Value, WattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.WattHourPerSquareMeter, watthourpersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(1, Irradiation.FromJoulesPerSquareMeter(joulepersquaremeter.JoulesPerSquareMeter).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromKilowattHoursPerSquareMeter(joulepersquaremeter.KilowattHoursPerSquareMeter).JoulesPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromWattHoursPerSquareMeter(joulepersquaremeter.WattHoursPerSquareMeter).JoulesPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Irradiation v = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiation.FromJoulesPerSquareMeter(3)-v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiation.FromJoulesPerSquareMeter(10)/5).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, Irradiation.FromJoulesPerSquareMeter(10)/Irradiation.FromJoulesPerSquareMeter(5), JoulesPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Irradiation oneJoulePerSquareMeter = Irradiation.FromJoulesPerSquareMeter(1);
            Irradiation twoJoulesPerSquareMeter = Irradiation.FromJoulesPerSquareMeter(2);

            Assert.True(oneJoulePerSquareMeter < twoJoulesPerSquareMeter);
            Assert.True(oneJoulePerSquareMeter <= twoJoulesPerSquareMeter);
            Assert.True(twoJoulesPerSquareMeter > oneJoulePerSquareMeter);
            Assert.True(twoJoulesPerSquareMeter >= oneJoulePerSquareMeter);

            Assert.False(oneJoulePerSquareMeter > twoJoulesPerSquareMeter);
            Assert.False(oneJoulePerSquareMeter >= twoJoulesPerSquareMeter);
            Assert.False(twoJoulesPerSquareMeter < oneJoulePerSquareMeter);
            Assert.False(twoJoulesPerSquareMeter <= oneJoulePerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Equal(0, joulepersquaremeter.CompareTo(joulepersquaremeter));
            Assert.True(joulepersquaremeter.CompareTo(Irradiation.Zero) > 0);
            Assert.True(Irradiation.Zero.CompareTo(joulepersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => joulepersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => joulepersquaremeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Irradiation a = Irradiation.FromJoulesPerSquareMeter(1);
            Irradiation b = Irradiation.FromJoulesPerSquareMeter(2);

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
            Irradiation v = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.True(v.Equals(Irradiation.FromJoulesPerSquareMeter(1), Irradiation.FromJoulesPerSquareMeter(JoulesPerSquareMeterTolerance)));
            Assert.False(v.Equals(Irradiation.Zero, Irradiation.FromJoulesPerSquareMeter(JoulesPerSquareMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.False(joulepersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.False(joulepersquaremeter.Equals(null));
        }
    }
}
