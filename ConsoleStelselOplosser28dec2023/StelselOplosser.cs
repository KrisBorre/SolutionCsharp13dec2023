namespace ConsoleStelselOplosser28dec2023
{
    internal class StelselOplosser
    {
        // Linear equation solution by Gauss-Jordan elimination, equation 2.1.1 above.
        // The input matrix is a[0..n-1,0..n-1].
        // b[0..n-1,0..m-1] is input containing the m right-hand side vectors.
        // Numerical Recipes in C++
        public void Gaussj(double[,] a, double[,] b)
        {
            int icol = 0, irow = 0;
            int n = a.GetLength(0);
            int m = b.GetLength(1);

            double big, dum, pivinv;
            int[] indxc = new int[n];
            int[] indxr = new int[n];
            int[] ipiv = new int[n];

            for (int j = 0; j < n; j++) { ipiv[j] = 0; }

            for (int i = 0; i < n; i++)
            {
                big = 0.0;
                for (int j = 0; j < n; j++)
                {
                    if (ipiv[j] != 1)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (ipiv[k] == 0)
                            {
                                if (Math.Abs(a[j, k]) >= big)
                                {
                                    big = Math.Abs(a[j, k]);
                                    irow = j;
                                    icol = k;
                                }
                            }
                        }
                    }
                }

                ++(ipiv[icol]);
                if (irow != icol)
                {
                    for (int l = 0; l < n; l++) SWAP(a, irow, l, a, icol, l);
                    for (int l = 0; l < m; l++) SWAP(b, irow, l, b, icol, l);
                }
                indxr[i] = irow;
                indxc[i] = icol;
                if (a[icol, icol] == 0.0) throw new Exception("Gaussj: Singular Matrix");
                pivinv = 1.0 / a[icol, icol];
                a[icol, icol] = 1.0;
                for (int l = 0; l < n; l++) a[icol, l] *= pivinv;
                for (int l = 0; l < m; l++) b[icol, l] *= pivinv;
                for (int ll = 0; ll < n; ll++)
                {
                    if (ll != icol)
                    {
                        dum = a[ll, icol];
                        a[ll, icol] = 0.0;
                        for (int l = 0; l < n; l++) a[ll, l] -= a[icol, l] * dum;
                        for (int l = 0; l < m; l++) b[ll, l] -= b[icol, l] * dum;
                    }
                }
            }

            for (int l = n - 1; l >= 0; l--)
            {
                if (indxr[l] != indxc[l])
                {
                    for (int k = 0; k < n; k++)
                    {
                        SWAP(a, k, indxr[l], a, k, indxc[l]);
                    }
                }
            }
        }

        public void Gaussj(double[,] a)
        {
            double[,] b = new double[a.GetLength(0), 0];
            Gaussj(a, b);
        }

        private void SWAP(double[,] a, int i, int j, double[,] b, int k, int l)
        {
            double item1 = a[i, j];
            double item2 = b[k, l];
            a[i, j] = item2;
            b[k, l] = item1;
        }

    }
}
