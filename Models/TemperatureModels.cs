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

    public sealed class SensorUpdateDTO
    {
        public int SensorID { get; set; }
        public required string Name { get; set; }
        public double CalibrationValueF { get; set; } = 0;
        public double? MinTempF { get; set; }
        public double? MaxTempF { get; set; }
    }

    public sealed class FarmLoginDTO
    {
        public int FarmID { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }
    }

    public sealed class TokenResponseDTO
    {
        public string? Token { get; set; }
        public string? AccessToken { get; set; }
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
