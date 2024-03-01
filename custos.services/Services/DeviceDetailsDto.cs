﻿namespace custos.services.Services
{
    public class DeviceDetailsDto
    {
        public string entity_type { get; set; }
        public Property properties { get; set; } = new Property();
    }
    public class Property
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string? SubType { get; set; }
        public long LastUpdateTime { get; set; }
        public string? DisplayLabel { get; set; }
        public string? MfDeviceId { get; set; }
        public string? IpAddress { get; set; }
        public string? MacAddress { get; set; }
        public string? AgentVersion { get; set; }
    }
}
