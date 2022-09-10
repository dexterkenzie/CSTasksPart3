using System;

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A (x y z): ");
string xyzA = Console.ReadLine();
string[] partsA = xyzA.Split(' ');
int xa = int.Parse(partsA[0]);
int ya = int.Parse(partsA[1]);
int za = int.Parse(partsA[2]);

Console.WriteLine("Введите координаты точки B (x y z): ");
string xyzB = Console.ReadLine();
string[] partsB = xyzB.Split(' ');
int xb = int.Parse(partsB[0]);
int yb = int.Parse(partsB[1]);
int zb = int.Parse(partsB[2]);

Console.WriteLine(); // пустая строка

Console.WriteLine("Вы задали координаты:");
Console.WriteLine($"A ({xa}, {ya}, {za})");
Console.WriteLine($"B ({xb}, {yb}, {zb})");

Console.WriteLine(); // пустая строка

var distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine($"Расстояние между точками A и B равно: {distance:F2} единиц.");

Console.WriteLine(); // пустая строка


