// Challenge 01: Combate por turnos

// Crea un juego en el que un jugador se enfrente a un enemigo en un combate por turnos,
// cumpliendo con las siguientes condiciones:
//   - Participantes: Ambos personajes tienen puntos de vida (con un máximo definido) y
//     ataque.
//   - Inicio: Elige de forma aleatoria quién hace el primer movimiento.
//   - Acciones del jugador: En su turno, el jugador puede elegir entre atacar o curarse
//   - Daño y combate: El daño provocado puede variar en cada golpe. La pelea continúa
//     turno a turno hasta que uno sea derrotado.

// Reglas del juego:
//   - Valida todas las entradas de datos que ingrese el usuario, pidiéndolas nuevamente
//     si son inválidas.
//   - La vida nunca puede ser menor a 0 ni superar su valor máximo.
//   - Si un personaje es derrotado, pierde la oportunidad de seguir atacando.

var random = new Random();
var Start = random.Next(0, 1 + 1);
if (Start == 0)
{
    Console.WriteLine("Player Starts!");
    int PlayerHealth = 20;
    int PlayerDamage = random.Next(3, 6);
    int PlayerHeal = random.Next(1, 4);
    int EnemyHealth = 25;
    int EnemyDamage = random.Next(3, 6);
    Console.WriteLine("Player HP : " + PlayerHealth);
    Console.WriteLine("Enemy HP: " + EnemyHealth);
    Console.WriteLine("-------------------------");
    do
    {
        Console.WriteLine("Player´s Turn! Attack (1) or Heal (2)?");
        int Attack = 1;
        int Heal = 2;
        string PlayerTurn = Console.ReadLine(); 
        if (PlayerTurn == "1")
        {
            
        }
    } while (expression);
}
else
{
    Console.WriteLine("Enemy Starts!");
    int PlayerHealth = 20;
    int PlayerDamage = random.Next(3, 6);
    int PlayerHeal = random.Next(1, 4);
    int EnemyHealth = 25;
    int EnemyDamage = random.Next(3, 6);
    Console.WriteLine("Player HP : " + PlayerHealth);
    Console.WriteLine("Enemy HP: " + EnemyHealth);
}