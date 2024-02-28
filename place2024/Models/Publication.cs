using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace place2024.Models
{
    public class Publication
    {
        public int PublicationId { get; set; }
        
        [Display(Name = "Titre")]
        public string PublicationTitle { get; set; }

        [Display(Name = "Description")]
        public string PublicationDescription { get; set; }

        [Display(Name = "Date de publication")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        [Display(Name = "Categorie")]
        public string Categorie { get; set; }
        
    }
}
