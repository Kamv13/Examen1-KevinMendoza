using Examen1_KevinMendoza;

Asignatura Asignatura = new Asignatura();

Console.WriteLine("Porfavor introduzca el nombre del alumno");
Asignatura.NombreAlumno = Console.ReadLine();

Console.WriteLine("Porfavor ingrese el numero de cuenta");
Asignatura.NumeroCuenta = Console.ReadLine();

Console.WriteLine("Porfavor ingrese el correo electronico");
Asignatura.Email = Console.ReadLine();

Console.WriteLine("Porfavor introduzca el horario de clase");
Asignatura.Horario = Console.ReadLine();

Console.WriteLine("Porfavor ingrese el Nombre de la asignatura");
Asignatura.NombreAsignatura = Console.ReadLine();

Console.WriteLine("Porfavor ingrese el nombre del docente");
Asignatura.NombreDocente = Console.ReadLine(); 

Console.WriteLine("Porfavor introduzca la nota del primer parical");
 Asignatura.Nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Porfavor introduzca la nota del segundo parcial");
 Asignatura.Nota2 = Convert.ToInt32(Console.ReadLine());

if (Asignatura.Nota1 > 30 || Asignatura.Nota2 > 30) {

    throw new FormatException("La suma de notas del primer y segundo parcial no puede ser mayor a 60");

}
Console.WriteLine("Porfavor introduzca la tercera nota");
Asignatura.Nota3 = Convert.ToInt32(Console.ReadLine());

if (Asignatura.Nota3 > 40)
{
    throw new FormatException("La nota del tercer parcial no puede ser mayor a 40");
}

Asignatura.CalcularNotaFinal();
Asignatura.CalcularNotaFinal(Asignatura.Nota1, Asignatura.Nota2, Asignatura.Nota3);

Asignatura.Imprimir();