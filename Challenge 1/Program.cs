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
//   - Válida todas las entradas de datos que ingrese el usuario, pidiéndolas nuevamente
//     si son inválidas.
//   - La vida nunca puede ser menor a 0 ni superar su valor máximo.
//   - Si un personaje es derrotado, pierde la oportunidad de seguir atacando.

var random = new Random();
int PlayerHealth = 20;
int PlayerDamage = random.Next(3, 6);
int PlayerHeal = random.Next(3, 8);
int EnemyHealth = 20;
int EnemyDamage = random.Next(3, 6);
var Start = random.Next(0, 1 + 1);
string PlayerTurn = "";

if (Start == 0)
{
    Console.WriteLine("Player Starts!");
    Console.WriteLine("Player HP : " + PlayerHealth);
    Console.WriteLine("Enemy HP: " + EnemyHealth);
    Console.WriteLine("-------------------------");
    do
    {
        do
        {
            Console.WriteLine("Player´s Turn! Attack (1) or Heal (2)?");
            PlayerTurn = Console.ReadLine();
            if (PlayerTurn == "1")
            {
                Console.WriteLine("Player Attacks!");
                EnemyHealth = EnemyHealth - PlayerDamage;
                if (EnemyHealth < 0)
                {
                    EnemyHealth = 0;
                }
                Console.WriteLine("---------------");
                Console.WriteLine("Enemy Lost " + PlayerDamage + " Points of Health!");
                Console.WriteLine("Enemy Health Remaining: " + EnemyHealth);
                Console.WriteLine("--------------------------------------");
            }
            else if (PlayerTurn == "2")
            {
                Console.WriteLine("Player Heals!");
                PlayerHealth = PlayerHealth + PlayerHeal;
                Console.WriteLine("-------------");
                if (PlayerHealth > 20)
                {
                    Console.WriteLine("Health Limit Reached! It has NO Effect!");
                    PlayerHealth = 20;
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.WriteLine("Player Healed!");
                    Console.WriteLine("Player HP : " + PlayerHealth);
                    Console.WriteLine("---------------------------------------");
                }
            }
            else    
            {
                Console.WriteLine("Invalid Input! Try Again.");
                Console.WriteLine("-------------------------");
            }    
        
        } while (PlayerTurn != "1" && PlayerTurn != "2");
        if (EnemyHealth > 0)
        {
            Console.WriteLine("Enemy´s Turn!");
            PlayerHealth = PlayerHealth - EnemyDamage;
            Console.WriteLine("-------------");
            Console.WriteLine("Player Lost " + EnemyDamage + " Points of Health!");
            Console.WriteLine("Player Health Remaining: " + PlayerHealth);
            Console.WriteLine("--------------------------------------");
        }
        
    } while (PlayerHealth > 0 && EnemyHealth > 0);

    if (PlayerHealth <= 0)
    {
        Console.WriteLine("GAME OVER! Try Again...");
    }
    else
    {
        Console.WriteLine("ENEMY DEFEATED! YOU WON!");
    }
}
else
{
    Console.WriteLine("Enemy Starts!");
    Console.WriteLine("Player HP : " + PlayerHealth);
    Console.WriteLine("Enemy HP: " + EnemyHealth);
    Console.WriteLine("-------------------------");
    do
    {
        Console.WriteLine("Enemy´s Turn!");
        PlayerHealth = PlayerHealth - EnemyDamage;
        if (PlayerHealth < 0)
        {
            PlayerHealth = 0;
        }
        Console.WriteLine("-------------");
        Console.WriteLine("Player Lost " + EnemyDamage + " Points of Health!");
        Console.WriteLine("Player Health Remaining: " + PlayerHealth);
        Console.WriteLine("--------------------------------------");

        if (PlayerHealth > 0)
        {
            do
            {
                Console.WriteLine("Player´s Turn! Attack (1) or Heal (2)?");
                PlayerTurn = Console.ReadLine();
                if (PlayerTurn == "1")
                {
                    Console.WriteLine("Player Attacks!");
                    EnemyHealth = EnemyHealth - PlayerDamage;
                    Console.WriteLine("---------------");
                    Console.WriteLine("Enemy Lost " + PlayerDamage + " Points of Health!");
                    Console.WriteLine("Enemy Health Remaining: " + EnemyHealth);
                    Console.WriteLine("--------------------------------------");
                }
                else if (PlayerTurn == "2")
                {
                    Console.WriteLine("Player Heals!");
                    PlayerHealth = PlayerHealth + PlayerHeal;
                    Console.WriteLine("-------------");
                    if (PlayerHealth > 20)
                    {
                        Console.WriteLine("Health Limit Reached! It has NO Effect!");
                        PlayerHealth = 20;
                        Console.WriteLine("---------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Player Healed!");
                        Console.WriteLine("Player HP : " + PlayerHealth);
                        Console.WriteLine("---------------------------------------");
                    }
                }
                else    
                {
                    Console.WriteLine("Invalid Input! Try Again.");
                    Console.WriteLine("-------------------------");
                }      
            } while (PlayerTurn != "1" && PlayerTurn != "2");
        }

    } while (PlayerHealth > 0 && EnemyHealth > 0);

    if (PlayerHealth <= 0)
    {
        Console.WriteLine("GAME OVER! Try Again...");
    }
    else
    {
        Console.WriteLine("ENEMY DEFEATED! YOU WON!");
    }
}