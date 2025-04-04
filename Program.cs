using System.Reflection;

double anguloG, AnguloR, CE, a;
Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("------Escada------\n");
Console.WriteLine("comprimento da escada é");
CE = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("ANGULO EM GRAUS da posição é\n");
anguloG = Convert.ToDouble(Console.ReadLine()!);

AnguloR = Math.PI * anguloG / 180;
a = CE * Math.Sin(AnguloR);

Console.WriteLine($@"uma escada de {CE} e {anguloG} alcança {a:N2}");