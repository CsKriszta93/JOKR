using System;

namespace Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }

        public Guid MinSysReqId { get; set; }
        public Guid RecSysReqId { get; set; }
    }
}
