﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentaCars.EN
{
    public class Vehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display (Name = "id")]
        public int VehiculoID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Usuario id")]
        public int UsuarioID { get; set; }
        [RegularExpression("^[A-Za-z-0-9]+$", ErrorMessage = "Solo letras y numeros ")]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Solo letras")]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Solo letras")]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "fecha")]
        public DateTime Year { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo numeros ")]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Numero puertas")]
        public int Npuertas { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Pago por Alquiler")]
        public decimal PrecioDiario { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode =true)]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Total a pagar")]
        public decimal PagoTotal { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Estado id")]
        public int EstadoID { get; set; }
        public string imagen { get; set; }


        public virtual Estado Estado { get; set; }
        public virtual ICollection<Reserva> Reserva { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
