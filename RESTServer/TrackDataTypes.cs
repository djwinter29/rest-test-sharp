namespace RESTServer
{
    public class SpeedInfo
    {
        public DateTime Date { get; set; }

        public float Speed { get; set; }
    }

    public class PositionInfo
    {
        public DateTime Date { get; set; }

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class RotationInfo
    {
        public DateTime Date { get; set; }

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }
}
