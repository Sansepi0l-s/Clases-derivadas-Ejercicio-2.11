using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Participante
    {
        private string nombre;
        private string apellido;
        private char sexo;
        private string paisResidencia;
        private long telefono;
        private string email;
        public Participante()
        {

        }
        public Participante(string nombre, string apellido, char sexo, string paisResidencia, long telefono, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.paisResidencia = paisResidencia;
            this.telefono = telefono;
            this.email = email;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public char Sexo
        {
            set
            {
                sexo = value;
            }
            get
            {
                return sexo;
            }
        }
        public string PaisResidencia
        {
            get
            {
                return paisResidencia;
            }
            set
            {
                paisResidencia = value;
            }
        }
        public long Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0}\nApellido: {1}\nSexo: {2}\nPais de Residencia: {3}\nTeléfono: {4}\nEmail: {5}", Nombre, Apellido, Sexo, PaisResidencia, Telefono, Email);
        }
    }
}
