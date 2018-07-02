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
    /// Test of Flow.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FlowTestsBase
    {
        protected abstract double CentilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicDecimetersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double DecilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double KilolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double MicrolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double MillilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double MillionUsGallonsPerDayInOneCubicMeterPerSecond { get; }
        protected abstract double NanolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double OilBarrelsPerDayInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerSecondInOneCubicMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicDecimetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double LitersPerHourTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double LitersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double MillilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double MillionUsGallonsPerDayTolerance { get { return 1e-5; } }
        protected virtual double NanolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerDayTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerHourTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CubicMeterPerSecondToFlowUnits()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CentilitersPerMinute, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicDecimetersPerMinute, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerHour, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerMinute, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerHour, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerMinute, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerHour, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerMinute, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.DecilitersPerMinute, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.KilolitersPerMinute, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerHour, LitersPerHourTolerance);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerMinute, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.MicrolitersPerMinute, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.MillilitersPerMinute, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.MillionUsGallonsPerDay, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.NanolitersPerMinute, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.OilBarrelsPerDay, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerHour, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerMinute, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CentilitersPerMinute).CentilitersPerMinute, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicDecimeterPerMinute).CubicDecimetersPerMinute, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicFootPerHour).CubicFeetPerHour, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicFootPerMinute).CubicFeetPerMinute, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicFootPerSecond).CubicFeetPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicMeterPerHour).CubicMetersPerHour, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicMeterPerMinute).CubicMetersPerMinute, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicMeterPerSecond).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicYardPerHour).CubicYardsPerHour, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicYardPerMinute).CubicYardsPerMinute, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.CubicYardPerSecond).CubicYardsPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.DecilitersPerMinute).DecilitersPerMinute, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.KilolitersPerMinute).KilolitersPerMinute, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.LitersPerHour).LitersPerHour, LitersPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.LitersPerMinute).LitersPerMinute, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.LitersPerSecond).LitersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.MicrolitersPerMinute).MicrolitersPerMinute, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.MillilitersPerMinute).MillilitersPerMinute, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.MillionUsGallonsPerDay).MillionUsGallonsPerDay, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.NanolitersPerMinute).NanolitersPerMinute, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.OilBarrelsPerDay).OilBarrelsPerDay, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.UsGallonsPerHour).UsGallonsPerHour, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.UsGallonsPerMinute).UsGallonsPerMinute, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.From(1, FlowUnit.UsGallonsPerSecond).UsGallonsPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CentilitersPerMinute), CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicDecimeterPerMinute), CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicFootPerHour), CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicFootPerMinute), CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicFootPerSecond), CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicMeterPerHour), CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicMeterPerMinute), CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicMeterPerSecond), CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicYardPerHour), CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicYardPerMinute), CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.CubicYardPerSecond), CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.DecilitersPerMinute), DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.KilolitersPerMinute), KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.LitersPerHour), LitersPerHourTolerance);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.LitersPerMinute), LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.LitersPerSecond), LitersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.MicrolitersPerMinute), MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.MillilitersPerMinute), MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.MillionUsGallonsPerDay), MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.NanolitersPerMinute), NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.OilBarrelsPerDay), OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.UsGallonsPerHour), UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.UsGallonsPerMinute), UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(FlowUnit.UsGallonsPerSecond), UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);

            var centilitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CentilitersPerMinute);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, (double)centilitersperminuteQuantity.Value, CentilitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.CentilitersPerMinute, centilitersperminuteQuantity.Unit);

            var cubicdecimeterperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicDecimeterPerMinute);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, (double)cubicdecimeterperminuteQuantity.Value, CubicDecimetersPerMinuteTolerance);
            Assert.Equal(FlowUnit.CubicDecimeterPerMinute, cubicdecimeterperminuteQuantity.Unit);

            var cubicfootperhourQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicFootPerHour);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, (double)cubicfootperhourQuantity.Value, CubicFeetPerHourTolerance);
            Assert.Equal(FlowUnit.CubicFootPerHour, cubicfootperhourQuantity.Unit);

            var cubicfootperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicFootPerMinute);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, (double)cubicfootperminuteQuantity.Value, CubicFeetPerMinuteTolerance);
            Assert.Equal(FlowUnit.CubicFootPerMinute, cubicfootperminuteQuantity.Unit);

            var cubicfootpersecondQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicFootPerSecond);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, (double)cubicfootpersecondQuantity.Value, CubicFeetPerSecondTolerance);
            Assert.Equal(FlowUnit.CubicFootPerSecond, cubicfootpersecondQuantity.Unit);

            var cubicmeterperhourQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicMeterPerHour);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, (double)cubicmeterperhourQuantity.Value, CubicMetersPerHourTolerance);
            Assert.Equal(FlowUnit.CubicMeterPerHour, cubicmeterperhourQuantity.Unit);

            var cubicmeterperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicMeterPerMinute);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, (double)cubicmeterperminuteQuantity.Value, CubicMetersPerMinuteTolerance);
            Assert.Equal(FlowUnit.CubicMeterPerMinute, cubicmeterperminuteQuantity.Unit);

            var cubicmeterpersecondQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicMeterPerSecond);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, (double)cubicmeterpersecondQuantity.Value, CubicMetersPerSecondTolerance);
            Assert.Equal(FlowUnit.CubicMeterPerSecond, cubicmeterpersecondQuantity.Unit);

            var cubicyardperhourQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicYardPerHour);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, (double)cubicyardperhourQuantity.Value, CubicYardsPerHourTolerance);
            Assert.Equal(FlowUnit.CubicYardPerHour, cubicyardperhourQuantity.Unit);

            var cubicyardperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicYardPerMinute);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, (double)cubicyardperminuteQuantity.Value, CubicYardsPerMinuteTolerance);
            Assert.Equal(FlowUnit.CubicYardPerMinute, cubicyardperminuteQuantity.Unit);

            var cubicyardpersecondQuantity = cubicmeterpersecond.ToUnit(FlowUnit.CubicYardPerSecond);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, (double)cubicyardpersecondQuantity.Value, CubicYardsPerSecondTolerance);
            Assert.Equal(FlowUnit.CubicYardPerSecond, cubicyardpersecondQuantity.Unit);

            var decilitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.DecilitersPerMinute);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, (double)decilitersperminuteQuantity.Value, DecilitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.DecilitersPerMinute, decilitersperminuteQuantity.Unit);

            var kilolitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.KilolitersPerMinute);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, (double)kilolitersperminuteQuantity.Value, KilolitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.KilolitersPerMinute, kilolitersperminuteQuantity.Unit);

            var litersperhourQuantity = cubicmeterpersecond.ToUnit(FlowUnit.LitersPerHour);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, (double)litersperhourQuantity.Value, LitersPerHourTolerance);
            Assert.Equal(FlowUnit.LitersPerHour, litersperhourQuantity.Unit);

            var litersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.LitersPerMinute);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, (double)litersperminuteQuantity.Value, LitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.LitersPerMinute, litersperminuteQuantity.Unit);

            var literspersecondQuantity = cubicmeterpersecond.ToUnit(FlowUnit.LitersPerSecond);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, (double)literspersecondQuantity.Value, LitersPerSecondTolerance);
            Assert.Equal(FlowUnit.LitersPerSecond, literspersecondQuantity.Unit);

            var microlitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.MicrolitersPerMinute);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, (double)microlitersperminuteQuantity.Value, MicrolitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.MicrolitersPerMinute, microlitersperminuteQuantity.Unit);

            var millilitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.MillilitersPerMinute);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, (double)millilitersperminuteQuantity.Value, MillilitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.MillilitersPerMinute, millilitersperminuteQuantity.Unit);

            var millionusgallonsperdayQuantity = cubicmeterpersecond.ToUnit(FlowUnit.MillionUsGallonsPerDay);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, (double)millionusgallonsperdayQuantity.Value, MillionUsGallonsPerDayTolerance);
            Assert.Equal(FlowUnit.MillionUsGallonsPerDay, millionusgallonsperdayQuantity.Unit);

            var nanolitersperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.NanolitersPerMinute);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, (double)nanolitersperminuteQuantity.Value, NanolitersPerMinuteTolerance);
            Assert.Equal(FlowUnit.NanolitersPerMinute, nanolitersperminuteQuantity.Unit);

            var oilbarrelsperdayQuantity = cubicmeterpersecond.ToUnit(FlowUnit.OilBarrelsPerDay);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, (double)oilbarrelsperdayQuantity.Value, OilBarrelsPerDayTolerance);
            Assert.Equal(FlowUnit.OilBarrelsPerDay, oilbarrelsperdayQuantity.Unit);

            var usgallonsperhourQuantity = cubicmeterpersecond.ToUnit(FlowUnit.UsGallonsPerHour);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, (double)usgallonsperhourQuantity.Value, UsGallonsPerHourTolerance);
            Assert.Equal(FlowUnit.UsGallonsPerHour, usgallonsperhourQuantity.Unit);

            var usgallonsperminuteQuantity = cubicmeterpersecond.ToUnit(FlowUnit.UsGallonsPerMinute);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, (double)usgallonsperminuteQuantity.Value, UsGallonsPerMinuteTolerance);
            Assert.Equal(FlowUnit.UsGallonsPerMinute, usgallonsperminuteQuantity.Unit);

            var usgallonspersecondQuantity = cubicmeterpersecond.ToUnit(FlowUnit.UsGallonsPerSecond);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, (double)usgallonspersecondQuantity.Value, UsGallonsPerSecondTolerance);
            Assert.Equal(FlowUnit.UsGallonsPerSecond, usgallonspersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(1, Flow.FromCentilitersPerMinute(cubicmeterpersecond.CentilitersPerMinute).CubicMetersPerSecond, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicDecimetersPerMinute(cubicmeterpersecond.CubicDecimetersPerMinute).CubicMetersPerSecond, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicFeetPerHour(cubicmeterpersecond.CubicFeetPerHour).CubicMetersPerSecond, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicFeetPerMinute(cubicmeterpersecond.CubicFeetPerMinute).CubicMetersPerSecond, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicFeetPerSecond(cubicmeterpersecond.CubicFeetPerSecond).CubicMetersPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicMetersPerHour(cubicmeterpersecond.CubicMetersPerHour).CubicMetersPerSecond, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicMetersPerMinute(cubicmeterpersecond.CubicMetersPerMinute).CubicMetersPerSecond, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicMetersPerSecond(cubicmeterpersecond.CubicMetersPerSecond).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicYardsPerHour(cubicmeterpersecond.CubicYardsPerHour).CubicMetersPerSecond, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicYardsPerMinute(cubicmeterpersecond.CubicYardsPerMinute).CubicMetersPerSecond, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromCubicYardsPerSecond(cubicmeterpersecond.CubicYardsPerSecond).CubicMetersPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.FromDecilitersPerMinute(cubicmeterpersecond.DecilitersPerMinute).CubicMetersPerSecond, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromKilolitersPerMinute(cubicmeterpersecond.KilolitersPerMinute).CubicMetersPerSecond, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromLitersPerHour(cubicmeterpersecond.LitersPerHour).CubicMetersPerSecond, LitersPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.FromLitersPerMinute(cubicmeterpersecond.LitersPerMinute).CubicMetersPerSecond, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromLitersPerSecond(cubicmeterpersecond.LitersPerSecond).CubicMetersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Flow.FromMicrolitersPerMinute(cubicmeterpersecond.MicrolitersPerMinute).CubicMetersPerSecond, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromMillilitersPerMinute(cubicmeterpersecond.MillilitersPerMinute).CubicMetersPerSecond, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromMillionUsGallonsPerDay(cubicmeterpersecond.MillionUsGallonsPerDay).CubicMetersPerSecond, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(1, Flow.FromNanolitersPerMinute(cubicmeterpersecond.NanolitersPerMinute).CubicMetersPerSecond, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromOilBarrelsPerDay(cubicmeterpersecond.OilBarrelsPerDay).CubicMetersPerSecond, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(1, Flow.FromUsGallonsPerHour(cubicmeterpersecond.UsGallonsPerHour).CubicMetersPerSecond, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(1, Flow.FromUsGallonsPerMinute(cubicmeterpersecond.UsGallonsPerMinute).CubicMetersPerSecond, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Flow.FromUsGallonsPerSecond(cubicmeterpersecond.UsGallonsPerSecond).CubicMetersPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Flow v = Flow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (Flow.FromCubicMetersPerSecond(3)-v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (Flow.FromCubicMetersPerSecond(10)/5).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, Flow.FromCubicMetersPerSecond(10)/Flow.FromCubicMetersPerSecond(5), CubicMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Flow oneCubicMeterPerSecond = Flow.FromCubicMetersPerSecond(1);
            Flow twoCubicMetersPerSecond = Flow.FromCubicMetersPerSecond(2);

            Assert.True(oneCubicMeterPerSecond < twoCubicMetersPerSecond);
            Assert.True(oneCubicMeterPerSecond <= twoCubicMetersPerSecond);
            Assert.True(twoCubicMetersPerSecond > oneCubicMeterPerSecond);
            Assert.True(twoCubicMetersPerSecond >= oneCubicMeterPerSecond);

            Assert.False(oneCubicMeterPerSecond > twoCubicMetersPerSecond);
            Assert.False(oneCubicMeterPerSecond >= twoCubicMetersPerSecond);
            Assert.False(twoCubicMetersPerSecond < oneCubicMeterPerSecond);
            Assert.False(twoCubicMetersPerSecond <= oneCubicMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            Assert.Equal(0, cubicmeterpersecond.CompareTo(cubicmeterpersecond));
            Assert.True(cubicmeterpersecond.CompareTo(Flow.Zero) > 0);
            Assert.True(Flow.Zero.CompareTo(cubicmeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => cubicmeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterpersecond.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Flow a = Flow.FromCubicMetersPerSecond(1);
            Flow b = Flow.FromCubicMetersPerSecond(2);

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
            Flow v = Flow.FromCubicMetersPerSecond(1);
            Assert.True(v.Equals(Flow.FromCubicMetersPerSecond(1), Flow.FromCubicMetersPerSecond(CubicMetersPerSecondTolerance)));
            Assert.False(v.Equals(Flow.Zero, Flow.FromCubicMetersPerSecond(CubicMetersPerSecondTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            Assert.False(cubicmeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Flow cubicmeterpersecond = Flow.FromCubicMetersPerSecond(1);
            Assert.False(cubicmeterpersecond.Equals(null));
        }
    }
}
