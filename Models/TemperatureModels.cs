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

    public sealed class ReadingsResponseDTO
    {
        public required List<ReadingDTO> Readings { get; set; }
    }

    public sealed class ReadingDTO
    {
        public int ReadingID { get; set; }
        public double TempF { get; set; }
        public double Humidity { get; set; }
        public DateTime TimeStamp { get; set; }
        public int SensorID { get; set; }
    }
}
