using Microsoft.VisualBasic;
using System;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    public class Persona
    {
        public string nombre;
        public string fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            DateTime auxiliar = Convert.ToDateTime(fechaDeNacimiento);//convierte de la cadena el año, mes y dia a tipo de dato 'int'
            DateTime nacimiento = new DateTime(auxiliar.Year, auxiliar.Month, auxiliar.Day);
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            
            return edad;
        }

        public string EsMayorDeEdad()
        {
           int edad = CalcularEdad();
            if(edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }

        public string Mostrar()
        {
            return $"Nombre: {nombre}\n" +
                   $"Fecha de nacimiento: {fechaDeNacimiento}\n" +
                   $"DNI: {dni}\n" +
                   $"Edad actual: {CalcularEdad()}";
        }


    }
}