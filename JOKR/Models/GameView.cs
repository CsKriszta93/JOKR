using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace JOKR.Models
{
    public class GameView
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Developer { get; set; }
        public string CoverArt { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
