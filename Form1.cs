using DebugTools.Tools;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }
        private bool IsFirstMatrix1Valid()
        {
            return int.TryParse(X1Input.Text, out int x1) && int.TryParse(Y1Input.Text, out int y1) && x1 > 0 && y1 > 0;
        }
        private bool IsSecondMatrixValid()
        {
            return int.TryParse(X2Input.Text, out int x2) && int.TryParse(Y2Input.Text, out int y2) && x2 > 0 && y2 > 0;
        }
        private bool IsMatrixMultiplicationValid()
        {
            return int.TryParse(X1Input.Text, out int x1) && int.TryParse(Y1Input.Text, out int y1) && int.TryParse(X2Input.Text, out int x2) && int.TryParse(Y2Input.Text, out int y2) && x1 > 0 && y1 > 0 && x2 > 0 && y2 > 0 && x1 == y2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if the inputs are valid
            if (!IsFirstMatrix1Valid())
            {
                MessageBox.Show("Please enter a valid number for the first matrix");
                return;
            }
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;


            if (!IsSecondMatrixValid())
            {
                MessageBox.Show("Please enter a valid number for the second matrix");
                return;
            }
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;

            if (!IsMatrixMultiplicationValid())
            {
                MessageBox.Show("The matrices cannot be multiplied");
                return;
            }
            // DataGrid for the first matrix
            AddColumnsToDataGrid(x1, y1, FirstMatrixGrid);
            AddRowsToDataGrid(x1, y1, FirstMatrixGrid);
            Resize(FirstMatrixGrid);
            // DataGrid for the second matrix
            AddColumnsToDataGrid(x2, y2, SecondMatrixGrid);
            AddRowsToDataGrid(x2, y2, SecondMatrixGrid);
            Resize(SecondMatrixGrid);

            

        }
        private void AddColumnsToDataGrid(int x, int y, DataGridView grid)
        {
            grid.Columns.Clear();
            for (int i = 0; i < x; i++)
            {
                grid.Columns.Add((i+1).ToString(),(i+1).ToString());
            }
        }
        private void AddRowsToDataGrid(int x , int y,DataGridView grid)
        {
            grid.Rows.Clear();
            for (int i = 0; i < y; i++)
            {
                grid.Rows.Add();
            }
        }
        private void Resize(DataGridView grid)
        {
           

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            // Check if the inputs are valid
            if (!IsFirstMatrix1Valid())
            {
                MessageBox.Show("Please enter a valid number for the first matrix");
                return;
            }
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;


            if (!IsSecondMatrixValid())
            {
                MessageBox.Show("Please enter a valid number for the second matrix");
                return;
            }
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;

            if (!IsMatrixMultiplicationValid())
            {
                MessageBox.Show("The matrices cannot be multiplied");
                return;
            }
            // Initializing 2D Arrays
            int[,] FirstMatrix = new int[int.Parse(Y1Input.Text), int.Parse(X1Input.Text)];
            int[,] SecondMatrix = new int[int.Parse(Y2Input.Text), int.Parse(X2Input.Text)];

            FirstMatrix = GetMatrixValues(FirstMatrix, FirstMatrixGrid);
            SecondMatrix = GetMatrixValues(SecondMatrix, SecondMatrixGrid);




            // Multiplying the two matrices
            int[,] ResultMatrix = new int[x1, y2];
            MatrixCalculations calculator = new MatrixCalculations();
            ResultMatrix = calculator.MultiplyMatrices(FirstMatrix, SecondMatrix);
            DisplayResult(ResultMatrix);
        }

        private int[,] GetMatrixValues(int[,] Matrix, DataGridView MatrixGrid)
        {
        for (int i = 0; i < MatrixGrid.Rows.Count-1; i++)
            {
                for (int j = 0; j < MatrixGrid.Columns.Count; j++)
                {
                    Matrix[i, j] = Convert.ToInt32(MatrixGrid.Rows[i].Cells[j].Value);
                }
            }
            return Matrix;
           
        }

        private void DisplayResult(int[,] ResultMatrix)
        {
            AddColumnsToDataGrid(ResultMatrix.GetLength(1), ResultMatrix.GetLength(0), ResultMatrixGrid);
            AddRowsToDataGrid(ResultMatrix.GetLength(1), ResultMatrix.GetLength(0), ResultMatrixGrid);
            Resize(ResultMatrixGrid);
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                {
                    ResultMatrixGrid.Rows[i].Cells[j].Value = ResultMatrix[i, j];
                }
            }


           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;
            
            if(FirstMatrixGrid.Rows.Count != y1+1 || FirstMatrixGrid.Columns.Count != x1)
            {
                MessageBox.Show("Please enter a valid number for the first matrix");
                return;
            }
            if (SecondMatrixGrid.Rows.Count != y2 + 1 || SecondMatrixGrid.Columns.Count != x2)
            {
                MessageBox.Show("Please enter a valid number for the second matrix");
                return;
            }
            Random rand = new Random();
           
            for (int i = 0; i < y1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    FirstMatrixGrid.Rows[i].Cells[j].Value = rand.Next(1, 50).ToString();
                }
            }
                   
                   
            Random rand2 = new Random();
            
            for (int i = 0; i < y2; i++)
            {
                for (int j = 0; j < x2; j++)
                {
                    SecondMatrixGrid.Rows[i].Cells[j].Value = rand2.Next(1, 50).ToString();
                }
            }
             

        }

        
    }
}
