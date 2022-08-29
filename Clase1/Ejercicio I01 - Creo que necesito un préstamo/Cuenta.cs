using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    public class Cuenta
    {
        //ATRIBUTOS
        public string titular;
        public float cantidad;

        //CONSTRUCTOR
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Mostrar()
        {
            return $"Razón social:{titular}\nMonto actual de dinero en la cuenta:{cantidad}$";
        }


        public void Ingresar(float montoParaAcreditar)
        {
            if(montoParaAcreditar >= 0)
            {
                cantidad+=montoParaAcreditar;
            }
        }

        public void Retirar(float montoParaDebitar)
        {
            cantidad-=montoParaDebitar; 
        }



    }
}
