namespace BlazorTemps.Models
{
    public sealed class FarmDTO
    {
        public int FarmID { get; set; }
        public required string Name { get; set; }
    }

    public sealed class SensorDTO
    {
        public int SensorID { get; set; }
        public required string Name { get; set; }
        public double CalibrationValueF { get; set; } = 0;
        public double? LastTempF { get; set; }
        public DateTime? LastTimeStamp { get; set; }
        public DateTime? LastHeartbeat { get; set; }
        public double? MinTempF { get; set; }
        public double? MaxTempF { get; set; }
    }
}
