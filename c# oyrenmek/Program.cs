﻿Console.Write("Riyaziyyat balini daxil et: ");
int x = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Fizika balini daxil et:  ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingilis dili balini daxil et:  ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Riyaziyyat baliniz> " + x);
Console.WriteLine("Fizika baliniz> " + y);
Console.WriteLine("Ingilis dili baliniz> " + z);
Console.WriteLine("Ortalama bal: " + ((x+y+z)/3));