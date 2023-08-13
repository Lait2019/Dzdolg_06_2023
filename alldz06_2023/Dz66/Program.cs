int M = 4, N = 8, sum = 0;
void Summer(int a, int b, int summ)
{
   summ +=a;
   if ( a < b ) Summer(a+1, b, summ);
   else Console.Write(summ);
}
Summer(M, N, sum);
