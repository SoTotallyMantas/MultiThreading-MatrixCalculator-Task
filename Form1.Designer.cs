namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Create = new Button();
            X1Input = new TextBox();
            Y1Input = new TextBox();
            XYInputBox = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            X2Input = new TextBox();
            Y2Input = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Calculate = new Button();
            FirstMatrixGrid = new DataGridView();
            SecondMatrixGrid = new DataGridView();
            ResultMatrixGrid = new DataGridView();
            XYInputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstMatrixGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondMatrixGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultMatrixGrid).BeginInit();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(0, 419);
            Create.Name = "Create";
            Create.Size = new Size(184, 23);
            Create.TabIndex = 1;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += button1_Click;
            // 
            // X1Input
            // 
            X1Input.Location = new Point(0, 27);
            X1Input.Name = "X1Input";
            X1Input.Size = new Size(46, 23);
            X1Input.TabIndex = 2;
            // 
            // Y1Input
            // 
            Y1Input.Location = new Point(52, 27);
            Y1Input.Name = "Y1Input";
            Y1Input.Size = new Size(43, 23);
            Y1Input.TabIndex = 3;
            // 
            // XYInputBox
            // 
            XYInputBox.Controls.Add(label4);
            XYInputBox.Controls.Add(label5);
            XYInputBox.Controls.Add(X2Input);
            XYInputBox.Controls.Add(Y2Input);
            XYInputBox.Controls.Add(label2);
            XYInputBox.Controls.Add(label1);
            XYInputBox.Controls.Add(X1Input);
            XYInputBox.Controls.Add(Y1Input);
            XYInputBox.Location = new Point(0, 363);
            XYInputBox.Name = "XYInputBox";
            XYInputBox.Size = new Size(1264, 55);
            XYInputBox.TabIndex = 4;
            XYInputBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 9);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 9;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 9);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 8;
            label5.Text = "X";
            // 
            // X2Input
            // 
            X2Input.Location = new Point(443, 27);
            X2Input.Name = "X2Input";
            X2Input.Size = new Size(46, 23);
            X2Input.TabIndex = 6;
            // 
            // Y2Input
            // 
            Y2Input.Location = new Point(495, 27);
            Y2Input.Name = "Y2Input";
            Y2Input.Size = new Size(43, 23);
            Y2Input.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 9);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // button1
            // 
            button1.Location = new Point(354, 419);
            button1.Name = "button1";
            button1.Size = new Size(152, 23);
            button1.TabIndex = 10;
            button1.Text = "Generate Values";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 9);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "First Matrix";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 11);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 6;
            label6.Text = "Second Matrix";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(403, 162);
            label7.Name = "label7";
            label7.Size = new Size(41, 45);
            label7.TabIndex = 7;
            label7.Text = "X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(823, 162);
            label8.Name = "label8";
            label8.Size = new Size(36, 37);
            label8.TabIndex = 8;
            label8.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(852, 9);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 9;
            label9.Text = "Result Matrix";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(190, 419);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(158, 23);
            Calculate.TabIndex = 10;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // FirstMatrixGrid
            // 
            FirstMatrixGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FirstMatrixGrid.Location = new Point(12, 49);
            FirstMatrixGrid.Name = "FirstMatrixGrid";
            FirstMatrixGrid.RowHeadersWidth = 20;
            FirstMatrixGrid.RowTemplate.Height = 25;
            FirstMatrixGrid.Size = new Size(385, 308);
            FirstMatrixGrid.TabIndex = 11;
            // 
            // SecondMatrixGrid
            // 
            SecondMatrixGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SecondMatrixGrid.Location = new Point(450, 49);
            SecondMatrixGrid.Name = "SecondMatrixGrid";
            SecondMatrixGrid.RowTemplate.Height = 25;
            SecondMatrixGrid.Size = new Size(376, 308);
            SecondMatrixGrid.TabIndex = 12;
            // 
            // ResultMatrixGrid
            // 
            ResultMatrixGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultMatrixGrid.Location = new Point(865, 49);
            ResultMatrixGrid.Name = "ResultMatrixGrid";
            ResultMatrixGrid.RowTemplate.Height = 25;
            ResultMatrixGrid.Size = new Size(387, 308);
            ResultMatrixGrid.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 467);
            Controls.Add(ResultMatrixGrid);
            Controls.Add(SecondMatrixGrid);
            Controls.Add(FirstMatrixGrid);
            Controls.Add(button1);
            Controls.Add(Calculate);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(XYInputBox);
            Controls.Add(Create);
            Controls.Add(label8);
            Controls.Add(label7);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1024, 480);
            Name = "Form1";
            Text = "Form1";
            XYInputBox.ResumeLayout(false);
            XYInputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FirstMatrixGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondMatrixGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultMatrixGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Create;
        private TextBox X1Input;
        private TextBox Y1Input;
        private GroupBox XYInputBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox X2Input;
        private TextBox Y2Input;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button Calculate;
        private Button button1;
        private DataGridView FirstMatrixGrid;
        private DataGridView SecondMatrixGrid;
        private DataGridView ResultMatrixGrid;
    }
}