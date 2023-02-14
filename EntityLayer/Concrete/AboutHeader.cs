using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutHeader
    {
        [Key]
        public int AboutHeaderId { get; set; }
        public string Title { get; set; }
        public string HeaderDescription { get; set; }
        public string HeaderImage { get; set; }
        public string H2Title { get; set; }
        public string Description { get; set; }     
        public bool Status { get; set; }

    }
}
