// 1. Genera un programa que muestre un log de combate, donde el jugador realiza 5 puntos de daño al enemigo en cada turno.
// Prueba con diferentes valores iniciales de vida: 50, 5, 0

int Damage = 5;
int Health = 50;
int Round = 1;

Console.WriteLine("¡El enemigo tiene: " + Health + " de Vida!");
while (Health > 0)
{
    Health -= Damage;
    Console.WriteLine("¡Turno " + Round + "! Infligiste " + Damage + " puntos de daño.");
    Console.WriteLine("¡Le quedan " + Health + " puntos de vida al enemigo!");
    Round++;
}
Console.WriteLine("¡El enemigo ha sido derrotado!");
Console.WriteLine("Te tomo " + Round + " turnos derrotarlo.");

Console.WriteLine();
Console.WriteLine("------------------------------------");
Console.WriteLine();

// 2. Genera un programa que le pida al usuario un número entero. 
// Sigue pidiendo valores hasta que ingrese un valor correcto,
// mostrando un mensaje de error o éxito según el caso.
// Intenta con los siguientes valores para comprobar:
//  9.5 = Error
//  H = Error
//  5 = Correcto

bool EnteroValido;
do
{
    Console.WriteLine("Inserta un Número Entero:");
    var EnteroStr= Console.ReadLine();
    EnteroValido = int.TryParse(EnteroStr, out int Entero);
    
    if (EnteroValido != true)
    {
        Console.WriteLine("Valor Incorrecto, intentalo otra vez.");
    }
    else
    {
        Console.WriteLine("Valor Correcto.");
    }
    
} while (EnteroValido != true);

Console.WriteLine();
Console.WriteLine("------------------------------------");
Console.WriteLine();

// 3) Genera un programa que muestre la tabla del 7 del 0 al 100 en forma ordenada.
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine("7 x " + i + " = " + (7 * i));
}