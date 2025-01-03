using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataLogger_CSharp.utils
{
    internal class HealthMetricData
    {
        public string RecordID { get; set; }
        public string PatientID { get; set; }
        public string MetricName { get; set; }
        public string Value { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}