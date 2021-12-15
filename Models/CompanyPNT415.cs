using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PhamNgocTrung415.Models
{
    [Table("CompanyPNT415")]
    public class CompanyPNT415
    {
        [Key]
        public string CompanyId { get; set; }
        [Display(Name = "Mã công ty")]
        public string CompanyName {get; set;}
        
    }
    
}