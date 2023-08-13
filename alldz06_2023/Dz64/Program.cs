int N = 8;
void WriteNature(int g)
{
    Console.Write(g + " ");
    if (g != 1) 
    {
        WriteNature(g-1);
    }
}
WriteNature(N);
