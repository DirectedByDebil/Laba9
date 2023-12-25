using System;

namespace Visual9
{
    public class Matrix
    {
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int[,] Points { get; private set; }

        private Random random;

        public Matrix(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;

            Points = new int[Columns, Rows];
        }
        public void RandomizeMatrix()
        {
            random = new Random();

            for(int i = 0; i < Rows; i++)
                for(int j = 0; j < Columns; j++)
                {
                    Points[j, i] = random.Next(100);
                }
        }

        
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(b.Columns, a.Rows);

            for (int i = 0; i < c.Rows; i++)
            {
                for (int j = 0; j < c.Columns; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < c.Columns; k++)
                    {
                        //sum += a.Points[k,i]*b.Points[j, ]
                    }

                    c.Points[j, i] = sum;
                }
            }

            return c;
        }
        public override string ToString()
        {
            string result = "";

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    result += Points[j, i] + "\t";
                }
                result += "\r\n";
            }

            return result;
        }
    }
}
