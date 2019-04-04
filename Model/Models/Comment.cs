using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comment
    {
        public Guid CommentId { get; set; }

        //[ForeignKey("Game")]
        public Guid GameId { get; set; }
        public Game game { get; set; }

        public Guid Commenter { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }
    }
}
