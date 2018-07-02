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
    /// Test of Ratio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioTestsBase
    {
        protected abstract double DecimalFractionsInOneDecimalFraction { get; }
        protected abstract double PartsPerBillionInOneDecimalFraction { get; }
        protected abstract double PartsPerMillionInOneDecimalFraction { get; }
        protected abstract double PartsPerThousandInOneDecimalFraction { get; }
        protected abstract double PartsPerTrillionInOneDecimalFraction { get; }
        protected abstract double PercentInOneDecimalFraction { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsTolerance { get { return 1e-5; } }
        protected virtual double PartsPerBillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerMillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerThousandTolerance { get { return 1e-5; } }
        protected virtual double PartsPerTrillionTolerance { get { return 1e-5; } }
        protected virtual double PercentTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void DecimalFractionToRatioUnits()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.Percent, PercentTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.DecimalFraction).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.PartPerBillion).PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.PartPerMillion).PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.PartPerThousand).PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.PartPerTrillion).PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.From(1, RatioUnit.Percent).Percent, PercentTolerance);
        }

        [Fact]
        public void As()
        {
            var decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.As(RatioUnit.DecimalFraction), DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerBillion), PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerMillion), PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerThousand), PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerTrillion), PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.As(RatioUnit.Percent), PercentTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decimalfraction = Ratio.FromDecimalFractions(1);

            var decimalfractionQuantity = decimalfraction.ToUnit(RatioUnit.DecimalFraction);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, (double)decimalfractionQuantity.Value, DecimalFractionsTolerance);
            Assert.Equal(RatioUnit.DecimalFraction, decimalfractionQuantity.Unit);

            var partperbillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerBillion);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, (double)partperbillionQuantity.Value, PartsPerBillionTolerance);
            Assert.Equal(RatioUnit.PartPerBillion, partperbillionQuantity.Unit);

            var partpermillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerMillion);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, (double)partpermillionQuantity.Value, PartsPerMillionTolerance);
            Assert.Equal(RatioUnit.PartPerMillion, partpermillionQuantity.Unit);

            var partperthousandQuantity = decimalfraction.ToUnit(RatioUnit.PartPerThousand);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, (double)partperthousandQuantity.Value, PartsPerThousandTolerance);
            Assert.Equal(RatioUnit.PartPerThousand, partperthousandQuantity.Unit);

            var partpertrillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerTrillion);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, (double)partpertrillionQuantity.Value, PartsPerTrillionTolerance);
            Assert.Equal(RatioUnit.PartPerTrillion, partpertrillionQuantity.Unit);

            var percentQuantity = decimalfraction.ToUnit(RatioUnit.Percent);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, (double)percentQuantity.Value, PercentTolerance);
            Assert.Equal(RatioUnit.Percent, percentQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(1, Ratio.FromDecimalFractions(decimalfraction.DecimalFractions).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerBillion(decimalfraction.PartsPerBillion).DecimalFractions, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerMillion(decimalfraction.PartsPerMillion).DecimalFractions, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerThousand(decimalfraction.PartsPerThousand).DecimalFractions, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerTrillion(decimalfraction.PartsPerTrillion).DecimalFractions, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPercent(decimalfraction.Percent).DecimalFractions, PercentTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Ratio v = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(3)-v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(10)/5).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, Ratio.FromDecimalFractions(10)/Ratio.FromDecimalFractions(5), DecimalFractionsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Ratio oneDecimalFraction = Ratio.FromDecimalFractions(1);
            Ratio twoDecimalFractions = Ratio.FromDecimalFractions(2);

            Assert.True(oneDecimalFraction < twoDecimalFractions);
            Assert.True(oneDecimalFraction <= twoDecimalFractions);
            Assert.True(twoDecimalFractions > oneDecimalFraction);
            Assert.True(twoDecimalFractions >= oneDecimalFraction);

            Assert.False(oneDecimalFraction > twoDecimalFractions);
            Assert.False(oneDecimalFraction >= twoDecimalFractions);
            Assert.False(twoDecimalFractions < oneDecimalFraction);
            Assert.False(twoDecimalFractions <= oneDecimalFraction);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Equal(0, decimalfraction.CompareTo(decimalfraction));
            Assert.True(decimalfraction.CompareTo(Ratio.Zero) > 0);
            Assert.True(Ratio.Zero.CompareTo(decimalfraction) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentException>(() => decimalfraction.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentNullException>(() => decimalfraction.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Ratio a = Ratio.FromDecimalFractions(1);
            Ratio b = Ratio.FromDecimalFractions(2);

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
            Ratio v = Ratio.FromDecimalFractions(1);
            Assert.True(v.Equals(Ratio.FromDecimalFractions(1), Ratio.FromDecimalFractions(DecimalFractionsTolerance)));
            Assert.False(v.Equals(Ratio.Zero, Ratio.FromDecimalFractions(DecimalFractionsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(null));
        }
    }
}
