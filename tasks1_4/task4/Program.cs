﻿Console.WriteLine("Введите, пожалуйста, число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number) {
if (count % 2 == 0) Console.Write(count + " ");
count = count + 2;}
