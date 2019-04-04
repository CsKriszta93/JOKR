using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Developer { get; set; }
        public string CoverArt { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }

        public Guid? MinSysReqId { get; set; }
        public Guid? RecSysReqId { get; set; }

        /*[InverseProperty("game")]
        public ICollection<Comment> Comments { get; set; }*/
    }
}
