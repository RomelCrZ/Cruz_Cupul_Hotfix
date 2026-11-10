using PersonajesApp;

Personaje personaje = new()
{
    Nombre = "Aria",
    Clase = "Maga",
    Nivel = 12,
    Vida = 100,
    Arma = "Bastón de cristal"
};

Console.WriteLine("Datos del personaje");
Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Clase: {personaje.Clase}");
Console.WriteLine($"Nivel: {personaje.Nivel}");
Console.WriteLine($"Vida: {personaje.Vida}");
Console.WriteLine($"Arma: {personaje.Arma}");
