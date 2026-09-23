// 1) Fase de Elevación 
// 2) Llegar Al Espacio
// 3) Ascender o Esperar

const int Distancia_Al_Espacio_KM = 100;
const int Combustible_Maximo = 105;
const int Escudo_Maximo = 50;
const int Escudo_Por_Turno = 5;
const int Perdida_de_Distancia_Por_Esperar = 4; 
const int Combustible_Por_Turno = 5;
const int Ascenso_Por_Turno = 10;

var Distancia_Recorrida = 0;
var Combustible_Actual = Combustible_Maximo;
var Escudo_Actual = Escudo_Maximo;

Console.WriteLine($"Distancia: {Distancia_Recorrida}");
Console.WriteLine($"Combustible: {Combustible_Actual}");
Console.WriteLine($"Escudo: {Escudo_Actual}");

while (Distancia_Recorrida < Distancia_Al_Espacio_KM && Combustible_Actual > 0)
{
    var esZonadeEscombros = false;
    var esZonadeCalma = false;
    var esZonaNeutral = !esZonadeEscombros  && !esZonadeCalma;
    string Decision;
    
    do
    {
        if (esZonadeEscombros)
        {
            Console.WriteLine("Estás en una Zona de Escombros...");
        }
        else if (esZonadeCalma)
        {
            Console.WriteLine("Estás en una Zona de Calma...");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("Estás en Una Zona de Neutral...");
        }
        
        Console.WriteLine("¿Que Acción Quieres Realizar?");
        Console.WriteLine("1. Ascender | 2. Esperar");
        Decision = Console.ReadLine() ?? "";

        if (Decision != "1" && Decision != "2")
        {
            Console.WriteLine("¡Opcion Inválida! Intenta de Nuevo...");
        }
    } while (Decision != "1" && Decision != "2");
    
    
    if (Decision == "1")
    {
        Console.WriteLine("Ascendiendo...");
        Distancia_Recorrida += Ascenso_Por_Turno;
        Combustible_Actual -= Combustible_Por_Turno;
    }
    else if (Decision == "2")
    {
       Console.WriteLine("Esperando...");
       Escudo_Actual = Math.Min(Escudo_Maximo, Escudo_Actual + Escudo_Por_Turno);
       Distancia_Recorrida = Math.Max(0, Distancia_Recorrida - Perdida_de_Distancia_Por_Esperar);
    }
    
    Console.WriteLine($"Distancia: {Distancia_Recorrida}");
    Console.WriteLine($"Combustible: {Combustible_Actual}");
    Console.WriteLine($"Escudo: {Escudo_Actual}");
}

if (Distancia_Recorrida >= Distancia_Al_Espacio_KM)
{
    Console.WriteLine("¡Llegaste al Espacio!");
}
else
{
    Console.WriteLine("No Llegaste al Espacio...");
}