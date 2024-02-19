/*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura*/

Console.WriteLine("Introduceti numarul");
int Numar = Convert.ToInt32(Console.ReadLine());
int Ultima_cifra = Numar % 10;
Console.WriteLine("Ultima cifra este "+Ultima_cifra);
