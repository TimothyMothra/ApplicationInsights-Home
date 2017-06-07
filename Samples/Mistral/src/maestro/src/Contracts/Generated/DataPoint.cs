
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.9.0.0
//   File : DataPoint_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Ingestion.Maestro.Contracts
{
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.9.0.0")]
    public partial class DataPoint
    {
        public string name { get; set; }

        public DataPointType kind { get; set; }

        public double value { get; set; }

        public int? count { get; set; }

        public double? min { get; set; }

        public double? max { get; set; }

        public double? stdDev { get; set; }

        public DataPoint()
            : this("AI.DataPoint", "DataPoint")
        {}

        protected DataPoint(string fullName, string name)
        {
            this.name = "";
            kind = DataPointType.Measurement;
        }
    }
} // AI
