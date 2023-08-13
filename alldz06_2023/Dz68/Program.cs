int M = 3, N = 2;
int A(int m, int n)
{
    int v;
    if (m == 0) 
    {
        v = n+1;
        return v;
    }
    else if ((m > 0) && (n == 0)) 
    {
        v = A((m-1), 1);
        return v;
    }
    else if ((m > 0) && (n > 0)) 
    {
        v = A(m-1, A(m, n-1));
        return v;
    }
    else return 0;
}
Console.Write(A(M, N));
