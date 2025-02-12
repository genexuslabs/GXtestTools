﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GeneXus.GXtest.Tools.TestConvert.BL.v3
{
    public class ControlValue : ParameterValue
    {
        public ControlValue()
            : base(ParmType.Control)
        {
        }

        [XmlElement("GXControlGUID")]
        public string ControlId { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}[{ControlId}]";
        }

        private ParameterControlData controlData = null;

        public ParameterControlData Data => controlData;


        public void AddControlData(IReadOnlyDictionary<string, ParameterControlData> dataStore)
        {
            if (controlData != null)
                throw new Exception($"Trying to add control data for value '{this}' over existing data '{controlData}'");

            ParameterControlData data = dataStore[ControlId];
            controlData = data ?? throw new Exception($"Trying to add null control data for value '{this}'");
        }
    }
}
