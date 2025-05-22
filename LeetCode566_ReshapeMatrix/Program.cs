using System.Text;

int[][] mat = [[1, 2, 3], [4, 5, 6]];
int[][] res = Reshape(mat, 3, 2);
Console.Write($"Initial Matrix:\n{PrintMatrix(mat)}");
Console.Write($"Reshaped Matrix:\n{PrintMatrix(res)}");

mat = [[1,2,3], [4, 5, 6], [7, 8, 9], [0,1,2]];
res = Reshape(mat, 2, 6);
Console.Write($"Initial Matrix:\n{PrintMatrix(mat)}");
Console.Write($"Reshaped Matrix:\n{PrintMatrix(res)}");

string PrintMatrix(int[][] mat)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < mat.Length; i++)
    {
        sb.Append("| ");
        for (int j = 0; j < mat[i].Length; j++)
        {
            sb.Append($"{mat[i][j]} ");  
        }
        sb.Append("|\n");
    }
    return sb.ToString();
}

int[][] Reshape(int[][] mat, int r, int c)
{
    int m = mat.Length;
    int n = mat[0].Length;
    if (m * n != r * c) return mat; //Check edge case
    int[][] reshaped = new int[r][];
    for (int i = 0; i < r; i++) { reshaped[i] = new int[c]; } //Initializes new matrix
                                                              //Tracks reshaped row and column
    int rowPointer = 0;
    int colPointer = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            reshaped[rowPointer][colPointer] = mat[i][j];
            colPointer++;
            if (colPointer == c)
            { //Reset to beginning of next row
                colPointer = 0;
                rowPointer++;
            }
        }
    }
    return reshaped; 
}