namespace lab48_49
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Label[,] Matrix1Labels = new Label[5, 5];
        private Label[,] Matrix2Labels = new Label[5, 5];
        private Label[,] Matrix3Labels = new Label[5, 5];
        private int[,] Matrix1 = new int[5, 5];
        private int[,] Matrix2 = new int[5, 5];
        private int[,] Matrix3 = new int[5, 5];

        public Form1()
        {
            InitializeComponent();
            InitMatrix();
        }

        private void InitMatrix()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix1[i, j] = 0;
                    Matrix1Labels[i, j] = new Label();
                    Matrix1Labels[i, j].Text = "0";
                    tableLayoutPanel1.Controls.Add(Matrix1Labels[i, j], i, j);
                    Matrix1Labels[i, j].TextAlign = ContentAlignment.TopCenter;

                    Matrix2[i, j] = 0;
                    Matrix2Labels[i, j] = new Label();
                    Matrix2Labels[i, j].Text = "";
                    tableLayoutPanel2.Controls.Add(Matrix2Labels[i, j], i, j);
                    Matrix2Labels[i, j].TextAlign = ContentAlignment.TopCenter;

                    Matrix3[i, j] = 0;
                    Matrix3Labels[i, j] = new Label();
                    Matrix3Labels[i, j].Text = "";
                    tableLayoutPanel3.Controls.Add(Matrix3Labels[i, j], i, j);
                    Matrix3Labels[i, j].TextAlign = ContentAlignment.TopCenter;
                    tableLayoutPanel3.Visible = false;
                }
            }
        }

        private void UpdateLabels1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix1Labels[i, j].Text = Matrix1[i, j].ToString();
                }

            }
        }

        private void UpdateLabels2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix2Labels[i, j].Text = Matrix2[i, j].ToString();
                }

            }
        }

        private void UpdateLabels3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3Labels[i, j].Text = Matrix3[i, j].ToString();
                }

            }
            tableLayoutPanel3.Visible = true;
        }

        private void ClearLabels2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix2[i, j] = 0;
                    Matrix2Labels[i, j].Text = "";
                }
            }
        }

        private void ClearLabels3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = 0;
                    Matrix3Labels[i, j].Text = "";
                }
            }
            tableLayoutPanel3.Visible = false;
        }

        private void gen1button_Click(object sender, EventArgs e)
        {
            ClearLabels3();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix1[i, j] = rnd.Next(-9, 9);
                }

            }
            UpdateLabels1();
            label1.Text = "Тут будет результат.";
        }

        private void gen2button_Click(object sender, EventArgs e)
        {
            ClearLabels3();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix2[i, j] = rnd.Next(-9, 9);
                }

            }
            UpdateLabels2();
            label1.Text = "Тут будет результат.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[j, i];
                }
            }
            label1.Text = "1.\tТранспонирование матрицы 1:";
            UpdateLabels3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            int posSum = 0;
            int negSum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = Matrix1[i, j];
                    if (el > 0)
                    {
                        posSum += el;
                    }
                    else
                    {
                        negSum += el;
                    }
                }
            }
            label1.Text = "2.\tВычисление сумм положительных и " +
                "отрицательных элементов матрицы 1 отдельно:\n\n" +
                $"сумма положительных: {posSum}\n" +
                $"сумма отрицательных: {negSum}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        el += Matrix1[k, j] * Matrix2[i, k];
                    }
                    Matrix3[i, j] = el;
                }
            }
            UpdateLabels3();
            label1.Text = "3.\tПеремножение матриц:";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            int posSum = 0;
            int negCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = Matrix1[i, j];
                    if (el >= 0)
                    {
                        posSum += el;
                    }
                    else
                    {
                        negCount++;
                    }
                }
            }
            label1.Text = "4.\tВычисление суммы положительных элементов и " +
                "количества отрицательных элементов матрицы:\n\n" +
                $"сумма положительных: {posSum}\n" +
                $"количество отрицательных: {negCount}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = Matrix1[i, j];
                    if (el < 0)
                    {
                        Matrix3[i, j] = 0;
                    }
                    else
                    {
                        Matrix3[i, j] = el;
                    }
                }
            }
            UpdateLabels3();
            label1.Text = "5.\tЗамена отрицательных элементов матрицы нулями:";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] + Matrix2[i, j];
                }
            }
            UpdateLabels3();
            label1.Text = "6.\tСложение двух матриц:";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            int scalar = rnd.Next(-9, 9);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] * scalar;
                }
            }
            UpdateLabels3();
            label1.Text = "7.\tУмножение матрицы на скаляр:\n\n" +
                $"случайный скаляр: {scalar}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = Matrix1[i, j];
                    if (el > 0)
                    {
                        Matrix3[i, j] = 0;
                    }
                    else
                    {
                        Matrix3[i, j] = el;
                    }
                }
            }
            UpdateLabels3();
            label1.Text = "8.\tЗамена всех положительных элементов матрицы нулями:";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            int count = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = j + 1; i < 5; i++)
                {
                    Matrix3[i, j] = Matrix1[i, j];
                    count++;
                }
            }
            UpdateLabels3();
            label1.Text = "9.\tВычисление сумм элементов " +
                "верхнего правого треугольника матрицы и количества элементов в нем:\n\n" +
                $"количество элементов: {count}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            int posCount = 0;
            int negCount = 0;
            int nilCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int el = Matrix1[i, j];
                    if (el > 0)
                    {
                        posCount++;
                    }
                    else if (el < 0)
                    {
                        negCount++;
                    }
                    else
                    {
                        nilCount++;
                    }
                }
            }
            label1.Text = "10.\tВычисление отдельно количества нулевых, " +
                "положительных и отрицательных элементов матрицы:\n\n" +
                $"количество положительных: {posCount}\n" +
                $"количество отрицательных: {negCount}\n" +
                $"количество нулевых: {nilCount}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[0, j] += Matrix1[i, j];
                }
            }
            string txt = "11.\tВычисление сумм элементов каждой строки матрицы:\n\n";
            for (int i = 0; i < 5; i++)
            {
                txt += $"сумма строки {i + 1}: {Matrix3[0, i]}\n";
            }
            label1.Text = txt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Matrix1[i, j] > 0)
                    {
                        Matrix3[i, j] = Matrix1[i, j] * 2;
                    }
                    else
                    {
                        Matrix3[i, j] = Matrix1[i, j];
                    }
                }
            }
            UpdateLabels3();
            label1.Text = "12.\tУдвоение всех положительных элементов матрицы:";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Matrix1[i, j] % 2 == 0)
                    {
                        Matrix3[i, j] = 0;
                    }
                    else
                    {
                        Matrix3[i, j] = Matrix1[i, j];
                    }
                }
            }
            UpdateLabels3();
            label1.Text = "13.\tЗамена нулями всех четных элементов матрицы:";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Matrix1[i, j] < 0)
                    {
                        Matrix3[0, i]++;
                    }
                }
            }
            string txt = "14.\tВычисление количеств отрицательных " +
                "элементов в каждом столбце матрицы:\n\n";
            for (int j = 0; j < 5; j++)
            {
                txt += $"отрицательных в столбце {j + 1}: {Matrix3[0, j]}\n";
            }
            label1.Text = txt;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            ClearLabels3();
            int primSum = 0;
            int secSum = 0;
            for (int i = 0; i < 5; i++)
            {
                primSum += Matrix1[i, i];
                secSum += Matrix1[i, 4 - i];
            }
            label1.Text = "15.\tВычисление отдельно сумм элементов главной " +
                "и побочной диагоналей:\n\n" +
                $"сумма главной диагонали: {primSum}\n" +
                $"сумма побочной диагонали: {secSum}";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] - (j + 1);
                }
            }
            UpdateLabels3();
            label1.Text = "16.\tВычитание из значения каждого " +
                "элемента матрицы номера строки данного элемента:";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] - (i + j + 2);
                }
            }
            UpdateLabels3();
            label1.Text = "17.\tВычитание из значения каждого элемента матрицы " +
                "суммы значений номеров строки и столбца этого элемента:";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClearLabels2();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] * 2;
                }
            }
            UpdateLabels3();
            label1.Text = "18.\tУдвоение всех значений исходной матрицы:";
        }
    }
}
