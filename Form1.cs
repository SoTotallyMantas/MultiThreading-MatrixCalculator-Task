using DebugTools.Tools;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            Inspector inspect = new Inspector();
            
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
            if(!IsFirstMatrix1Valid())
            {
                MessageBox.Show("Please enter a valid number for the first matrix");
                return;
            }
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;
            
            
            if(!IsSecondMatrixValid())
            {
                MessageBox.Show("Please enter a valid number for the second matrix");
                return;
            }
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;
            
            if(!IsMatrixMultiplicationValid())
            {
                MessageBox.Show("The matrices cannot be multiplied");
                return;
            }
            
            //First Matrix
            flowLayoutPanelFirstMatrix.Controls.Clear();
            for (int i = 0; i < x1; i++)
            {
                TextBox a = new TextBox();
                a.Size = new Size(33, 23);
                a.ReadOnly = true;
                a.BorderStyle = BorderStyle.None;
                a.TextAlign = HorizontalAlignment.Center;
                a.Text = "A" + (i + 1).ToString();
                flowLayoutPanelFirstMatrix.Controls.Add(a);
               
                if (i + 1 == x1)
                {
                    flowLayoutPanelFirstMatrix.SetFlowBreak(a, true);
                }

            }
            for (int i = 0; i < y1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    int name_text = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(33, 23);
                    a.Name = name_text.ToString();
                    flowLayoutPanelFirstMatrix.Controls.Add(a);
                   
                    if (j + 1 == x1)
                    {
                        flowLayoutPanelFirstMatrix.SetFlowBreak(a, true);
                    }
                }
            }
            // Second Matrix
           

            flowLayoutPanelSecondMatrix.Controls.Clear();
            for (int i = 0; i < x2; i++)
            {
                TextBox a = new TextBox();
                a.Size = new Size(33, 23);
                a.ReadOnly = true;
                a.BorderStyle = BorderStyle.None;
                a.TextAlign = HorizontalAlignment.Center;
                a.Text = "B" + (i + 1).ToString();
                flowLayoutPanelSecondMatrix.Controls.Add(a);
                if (i + 1 == x2)
                {
                    flowLayoutPanelSecondMatrix.SetFlowBreak(a, true);
                }

            }
            for (int i = 0; i < y2; i++)
            {
                for (int j = 0; j < x2; j++)
                {
                    int name_text = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(33, 23);
                    a.Name = name_text.ToString();
                    flowLayoutPanelSecondMatrix.Controls.Add(a);
               
                    if (j + 1 == x2)
                    {
                        flowLayoutPanelSecondMatrix.SetFlowBreak(a, true);
                    }
                }
            }
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

            
            // First Matrix Converting to 2D Array
            for (int i = 0; i < y1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    string controlName = ((i  +1) * 10 + j + 1).ToString();
                    Control[] foundControls = flowLayoutPanelFirstMatrix.Controls.Find(controlName, true);
                    if (foundControls.Length > 0)
                    {
                        FirstMatrix[i , j] = int.Parse(foundControls[0].Text);
                    }
                }
            }
            // Second Matrix Converting to 2D Array
            for (int i = 0; i < y2; i++)
            {
                for (int j = 0; j < x2; j++)
                {
                    string controlName = ((i + 1) * 10 + j + 1).ToString();
                    Control[] foundControls = flowLayoutPanelSecondMatrix.Controls.Find(controlName, true);
                    if (foundControls.Length > 0)
                    {
                        SecondMatrix[i, j] = int.Parse(foundControls[0].Text);
                    }
                }
            }
            // Multiplying the two matrices
            int[,] ResultMatrix = new int[x1, y2];
            MatrixCalculations calculator = new MatrixCalculations();
            ResultMatrix = calculator.MultiplyMatrices(FirstMatrix, SecondMatrix);
            DisplayResult(ResultMatrix);
        }
        private void DisplayResult(int[,] ResultMatrix)
        {
            flowLayoutPanelResult.Controls.Clear();
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                TextBox a = new TextBox();
                a.Size = new Size(33, 23);
                a.ReadOnly = true;
                a.BorderStyle = BorderStyle.None;
                a.TextAlign = HorizontalAlignment.Center;
                a.Text = "C" + (i + 1).ToString();
                flowLayoutPanelResult.Controls.Add(a);
                if (i + 1 == ResultMatrix.GetLength(0))
                {
                    flowLayoutPanelResult.SetFlowBreak(a, true);
                }

            }
            for (int i = 0; i < ResultMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(0); j++)
                {
                    int name_text = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(33, 23);
                    a.Name = name_text.ToString();
                    a.Text = ResultMatrix[i, j].ToString();
                    a.ReadOnly = true;
                    flowLayoutPanelResult.Controls.Add(a);
                    if (j + 1 == ResultMatrix.GetLength(0))
                    {
                        flowLayoutPanelResult.SetFlowBreak(a, true);
                    }
                }
            }
        }
    }
}
