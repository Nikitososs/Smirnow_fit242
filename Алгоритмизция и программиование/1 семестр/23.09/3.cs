Console.WriteLine(Poliv(5,3,3,4));

    static int Poliv(int p, int l, int m, int n)
    {
        int len = (2*p*n) + (l*2*(n-1)*n/2) + (2*(l+m)*n);
        return len;
    }
