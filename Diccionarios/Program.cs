Dictionary<string, int> items = new()
{
    {"Espada", 25},
    {"Arco", 15},
    {"Hacha", 35},
};

Console.WriteLine(items["Espada"]);
Console.WriteLine(items["Hacha"]);

// 1) Arco
items["Arco"] = 20;
Console.WriteLine(items["Arco"]);

if (items.ContainsKey("Arco") == false)
{
    items.Add("Arco", 20);
}


// 2) Cuchillo
if (items.TryGetValue("Cuchillo", out int dmgCuchillo) == false)
{
    Console.WriteLine($"DMG Cuchillo: {dmgCuchillo}");
}


// 3) Modifica a TryGetValue
if (items.ContainsKey("Hoz"))
{
    Console.WriteLine("DMG Hoz: " + items["Hoz"]);
}

if (items.TryGetValue("Hoz", out int dmghoz))
{
    Console.WriteLine($"DMG Hoz: {dmghoz}");
}

// 4) Modifica a ContainsKey
if (items.TryGetValue("Hacha", out int dmg))
{
    Console.WriteLine($"DMG Hacha:+ {dmg}");
}

if (items.ContainsKey("Hacha"))
{
    Console.WriteLine("DMG Hacha: " + items["Hacha"]);
}

// 5) Vaciar Diccionario e Intenta Agregar "Espada".
Console.WriteLine(items.Count);
Console.Clear();
items.TryAdd("Espada", 25);

foreach (var VARIABLE in items)
{
    Console.WriteLine(VARIABLE.Key);
}