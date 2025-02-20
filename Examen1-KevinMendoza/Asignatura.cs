

using System.Security.Cryptography.X509Certificates;

namespace Examen1_KevinMendoza
{
    public class Asignatura : Alumno , IAsignatura
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string? NombreAsignatura;
        public string? Horario;
        public string? NombreDocente;
        public double NotaFinal;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double CalcularNotaFinal(double Nota1, double Nota2, double Nota3)
        {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre del estudiante : {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta : {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico : {Email}");
            Console.WriteLine($"Nombre de la clase : {NombreAsignatura}");
            Console.WriteLine($"Horario : {Horario}");
            Console.WriteLine($"Nombre del docente : {NombreDocente}");
            Console.WriteLine($"Nota Final :  {CalcularNotaFinal()}-{MensajeNotaFinal(NotaFinal)}");
            Console.WriteLine($"Nota Final : {CalcularNotaFinal()}-{MensajeNotaFinal(NotaFinal)}");

        }

        public string MensajeNotaFinal(double NotaFinal)
        {
            if (NotaFinal >= 89)
            {
                return "Excelente";
            }
            else if (NotaFinal > 80)
            {
                return "Muy Bueno";
            }
            else if (NotaFinal < 60)
            {
                return "Bueno";
            }
            else
                return "Reprobado";
        }
    }
}
