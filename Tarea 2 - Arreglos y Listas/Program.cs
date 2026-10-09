// Micro-Ejercicio #1 - Genera un log de batalla de forma manual y muestra el resultado:
// 1. Player ataca por 5.
// 2. Enemy ataca por 6.
// 3. Player ataca por 7 (crit).
// 4. ¡Enemy aturdido!
// 5. Player ataca por 5.
// 6. ¡Enemy ha muerto!
// ¿Arreglo o lista?

Console.WriteLine("Micro-Ejercicio #1: Es un Arreglo.");
string[] log =
[
    "1. Player ataca por 5.",
    "2. Enemy ataca por 6.",
    "3. Player ataca por 7 (crit).",
    "4. ¡Enemy aturdido!",
    "5. Player ataca por 5.",
    "6. ¡Enemy ha muerto!"
];
Console.WriteLine(log[0]);
Console.WriteLine(log[1]);
Console.WriteLine(log[2]);
Console.WriteLine(log[3]);
Console.WriteLine(log[4]);
Console.WriteLine(log[5]);

Console.WriteLine("----------------------------------");
// Micro-Ejercicio #2 - Genera un programa que administre los enemigos activos de una zona. Muestra el estado en cada paso:
// 1. Slime, Goblin, Skeleton.
// 2. Aparece Orc.
// 3. Muere un Slime.
// 4. Aparece Orc.
// 5. Muere Orc.
// ¿Arreglo o lista?
Console.WriteLine("Micro-Ejercicio #2: Es una Lista.");
List<string> enemies = new List<string>();

Console.WriteLine("-");

Console.WriteLine("1) Slime, Goblin, Skeleton.");
enemies.Add("Slime");
enemies.Add("Goblin");
enemies.Add("Skeleton");
Console.WriteLine($"Capacity: {enemies.Capacity}");
Console.WriteLine($"Count: {enemies.Count}");

Console.WriteLine("-");

Console.WriteLine("2) Aparece Orc.");
enemies.Add("Orc");
Console.WriteLine($"Capacity: {enemies.Capacity}");
Console.WriteLine($"Count: {enemies.Count}");

Console.WriteLine("-");

Console.WriteLine("3) Muere un Slime.");
enemies.Remove("Slime");
Console.WriteLine($"Capacity: {enemies.Capacity}");
Console.WriteLine($"Count: {enemies.Count}");

Console.WriteLine("-");

Console.WriteLine("4) Aparece un Orc.");
enemies.Add("Orc");
Console.WriteLine($"Capacity: {enemies.Capacity}");
Console.WriteLine($"Count: {enemies.Count}");

Console.WriteLine("-");

Console.WriteLine("5) Muere Orc.");
enemies.RemoveAt(2);
Console.WriteLine($"Capacity: {enemies.Capacity}");
Console.WriteLine($"Count: {enemies.Count}");