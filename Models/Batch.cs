using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BatchCoreWithSwagger.Models
{
    public class Batch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int BatchId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string BusinessUnit { get; set; }

        public DateTime BatchPublishedDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }

    public class ResponseBatch
    {
        //public int BatchId { get; set; }
        //public string Status { get; set; }
        public string BusinessUnit { get; set; }

        public DateTime BatchPublishedDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
