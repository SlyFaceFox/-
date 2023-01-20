using Работа_с_классами;

Random rand = new Random();
Triangle[] triangles = new Triangle[5];
for (int i = 0; i < triangles.Length; i++)
{
    triangles[i] = new Triangle(rand.Next(1, 90), rand.Next(1, 90));
    Console.WriteLine(triangles[i]);
}

