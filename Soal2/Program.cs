// Soal 2
var X = 1;
var Y = 15;
var Z = 3;

Console.WriteLine(Mod_Z(X, Y, Z));

static int Mod_Z(int X, int Y, int Z)
{
    int jumlah = 0;

    for (int i = X; i <= Y; i++)
        if (i % Z == 0)
            jumlah++;

    return jumlah;
}