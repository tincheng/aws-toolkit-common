﻿namespace ToolkitTelemetryGenerator.Models
{
    public class MetricType
    {
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string[] allowedValues { get; set; }
    }
}