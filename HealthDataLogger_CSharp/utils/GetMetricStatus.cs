namespace HealthDataLogger_CSharp.utils
{
    internal class GetMetricStatus
    {
        public static string GetStatus(HealthMetricData metric)
        {
            switch (metric.MetricName)
            {
                case "Blood Pressure":
                var bloodPressure = metric.Value; // Example: "120/80"
                var pressureValues = bloodPressure.Split('/');
                    if (pressureValues.Length == 2)
                    {
                        // Parsing systolic and diastolic values
                        if (double.TryParse(pressureValues[0], out double systolic) &&
                            double.TryParse(pressureValues[1], out double diastolic))
                        {
                            // Based on systolic and diastolic values return Text
                            if (systolic < 120 && diastolic < 80)
                                return "Normal";
                            else if (systolic < 140 || diastolic < 90)
                                return "Elevated";
                            else
                                return "High";
                        }
                        else
                        {
                            return "Unknown";
                        }
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Body Temperature":
                    if (double.TryParse(metric.Value, out double bodyTemperature))
                    {
                        if (bodyTemperature < 37.2)
                            return "Normal";
                        else if (bodyTemperature < 38)
                            return "Elevated";
                        else
                            return "High";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Vital Capacity":
                    if (double.TryParse(metric.Value, out double vitalCapacity))
                    {
                        if (vitalCapacity > 3.0)
                            return "Normal";
                        else
                            return "Low";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Respiratory Rate":
                    if (int.TryParse(metric.Value, out int respiratoryRate))
                    {
                        if (respiratoryRate < 20)
                            return "Normal";
                        else if (respiratoryRate < 25)
                            return "Elevated";
                        else
                            return "High";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Coronary Artery Calcium (CAC) Score":
                    if (int.TryParse(metric.Value, out int cacScore))
                    {
                        if (cacScore == 0)
                            return "Normal";
                        else
                            return "Elevated";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Cholesterol Level":
                    if (int.TryParse(metric.Value, out int cholesterolLevel))
                    {
                        if (cholesterolLevel < 200)
                            return "Normal";
                        else if (cholesterolLevel < 240)
                            return "Elevated";
                        else
                            return "High";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Heart Rate":
                    if (int.TryParse(metric.Value, out int heartRate))
                    {
                        if (heartRate < 100)
                            return "Normal";
                        else if (heartRate < 120)
                            return "Elevated";
                        else
                            return "High";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Erythrocyte Count":
                    if (double.TryParse(metric.Value, out double erythrocyteCount))
                    {
                        if (erythrocyteCount > 4.2 && erythrocyteCount < 5.4)
                            return "Normal";
                        else
                            return "Abnormal";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Leucocyte Count":
                    if (double.TryParse(metric.Value, out double leucocyteCount))
                    {
                        if (leucocyteCount > 4.5 && leucocyteCount < 11)
                            return "Normal";
                        else
                            return "Abnormal";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Blood Oxygen Saturation":
                    if (double.TryParse(metric.Value, out double bloodOxygenSaturation))
                    {
                        if (bloodOxygenSaturation > 95)
                            return "Normal";
                        else
                            return "Low";
                    }
                    else
                    {
                        return "Unknown";
                    }
                case "Blood Glucose":
                    if (int.TryParse(metric.Value, out int bloodGlucose))
                    {
                        if (bloodGlucose < 140)
                            return "Normal";
                        else if (bloodGlucose < 200)
                            return "Elevated";
                        else
                            return "High";
                    }
                    else
                    {
                        return "Unknown";
                    }
                default:
                    return "Unknown";
            }
        }
    }
}
