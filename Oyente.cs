using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Oyente : Participante
    {
        private string gradoAcademico;
        public Oyente()
        {

        }
        public Oyente(string nombre, string apellido, char sexo, string paisResidencia, long telefono, string email, string gradoAcademico) : base(nombre, apellido, sexo, paisResidencia, telefono, email)
        {
            this.gradoAcademico = gradoAcademico;
        }
        public string GradoAcademico
        {
            get
            {
                return gradoAcademico;
            }
            set
            {
                gradoAcademico = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}", base.ToString(), "Grado Académico: ", GradoAcademico);
        }
    }
}
