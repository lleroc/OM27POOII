using System;
using System.Collections.Generic;
using System.Text;

namespace Floricola.Recursos
{
    public class Validaciones
    {
        public void SoloNumeros(TextBox cajatexxto, int longitud = 0) {
            if (longitud > 0)
            {
                cajatexxto.MaxLength = longitud;
            }
            //control para evitar escribir dos veces el mismo evento
            cajatexxto.KeyPress += SoloNumeros_KeyPress;
            cajatexxto.KeyPress -= SoloNumeros_KeyPress;

        }

        public void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        public bool ValidarCedulaEcuatoriana(string cedula)
        {
            // Validar longitud y que solo contenga números
            if (string.IsNullOrWhiteSpace(cedula) ||
                cedula.Length != 10 ||
                !cedula.All(c => c >= '0' && c <= '9'))
            {
                return false;
            }

            // Validar código de provincia (01 a 24)
            int provincia = int.Parse(cedula.Substring(0, 2));

            if (provincia < 1 || provincia > 24)
                return false;

            // Tercer dígito para personas naturales: 0 a 5
            int tercerDigito = cedula[2] - '0';

            if (tercerDigito > 5)
                return false;

            // Coeficientes del algoritmo Módulo 10
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = cedula[i] - '0';
                int resultado = digito * coeficientes[i];

                if (resultado >= 10)
                    resultado -= 9;

                suma += resultado;
            }

            // Calcular el dígito verificador
            int digitoVerificador = (10 - (suma % 10)) % 10;

            // Comparar con el último dígito
            return digitoVerificador == (cedula[9] - '0');
        }
    }
}
