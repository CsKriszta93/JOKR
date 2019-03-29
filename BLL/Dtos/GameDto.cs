using System;

namespace BLL.Dtos
{
    public class GameDto
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }
    }
}
