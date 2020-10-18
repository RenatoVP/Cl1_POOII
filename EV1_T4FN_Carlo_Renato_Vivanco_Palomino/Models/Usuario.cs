using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EV1_T4FN_Carlo_Renato_Vivanco_Palomino.Models
{
    public class Usuario
    {
        [Display(Name = "Dni del Usuario", Order = 0)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el DNI")]
        [RegularExpression("(^[0-9]{8})", ErrorMessage = "Dni solo recibe ocho digitos")]
        public int dni { get; set; }

        [Display(Name = "Nombre del Usuario", Order = 1)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Fecha de Nacimiento", Order = 2)]
        public DateTime fecNac { get; set; }

        [Display(Name = "Email del Usuario", Order = 3)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese Email del Usuario")]
        public string email { get; set; }

        [Display(Name = "Telefono del Usuario", Order = 4)]
        [RegularExpression("(^[0-9]{8,15})", ErrorMessage = "Fono recibe digitos de 8 a 15")]
        public int telefono { get; set; }
    }
}