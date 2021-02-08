using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace apicorreios.Models
{
    public class EnderecosModel
    {

        [Key]
        [Required]
        
        public int id{ get; set; }

        [Required]
        [StringLength(9)]
        public string endereco { get; set; }      
        
        
    }
}