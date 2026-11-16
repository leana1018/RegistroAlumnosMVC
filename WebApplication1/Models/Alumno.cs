using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Alumno
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double pension { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool activo { get; set; }

        public Alumno(int p_codigo, string p_nombre, double p_pension, DateTime p_fechaNacimiento)
        {
            codigo = p_codigo;
            nombre = p_nombre;
            pension = p_pension;
            fechaNacimiento = p_fechaNacimiento;
            activo = true;
        }
    }

}