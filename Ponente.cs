using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ponente : Participante
    {
        private string tituloPonecia;
        private string tematica;
        public Ponente()
        {

        }
        public Ponente(string nombre, string apellido, char sexo, string paisResidencia, long telefono, string email, string tiltuloPonencia, string tematica) : base(nombre, apellido, sexo, paisResidencia, telefono, email)
        {
            this.tematica = tematica;
            this.tituloPonecia = tiltuloPonencia;
        }
        public string TituloPonencia
        {
            set
            {
                tituloPonecia = value;
            }
            get
            {
                return tituloPonecia; 
            }
        }
        public string Tematica
        {
            set
            {
                tematica = value;
            }
            get
            {
                return tematica;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}\n{3} {4}", base.ToString(), "Título de ponencia: ", TituloPonencia, "Temática: ", Tematica);
        }
    }
}
