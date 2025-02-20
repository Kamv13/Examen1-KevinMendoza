
namespace Examen1_KevinMendoza
{
    public interface IAsignatura
    {
       public double CalcularNotaFinal();
       public double CalcularNotaFinal(double Nota1, double Nota2,double Nota3);
       public String MensajeNotaFinal(double NotaFinal);
        public void Imprimir();
 
    }
}
