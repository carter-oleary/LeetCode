int[][] mat = [[1, 2], [3, 4]];
int[][] res = Reshape(mat, 2, 2);

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
    return reshaped; ;
}