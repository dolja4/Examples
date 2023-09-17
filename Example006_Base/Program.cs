int A = 3;
int B = 10;
int C = 6;
int D = 8;
int E = 4;

int max = A;

if (B > max) max = B;
if (C > max) max = C;
if (D > max) max = D;
if (E > max) max = E;

Console.Write("max =");
Console.WriteLine(max);