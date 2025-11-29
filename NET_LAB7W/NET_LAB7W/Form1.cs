namespace NET_LAB7W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            taskSelector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskSelector.Items.Add("1. Найти возрастaющие строки матрицы");
            taskSelector.Items.Add("2. Вычисление формул a и b");
            taskSelector.Items.Add("3. Обработка строки");
            taskSelector.Items.Add("4. Поиск максимума/проверка числа");
            taskSelector.Items.Add("5. Числа с заданной суммой цифр");
            taskSelector.Items.Add("6. Площадь треугольника");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllPanels();
            switch (taskSelector.SelectedIndex)
            {
                case 0: panelTask1.Visible = true; break;
                case 1: panelTask2.Visible = true; break;
                case 2: panelTask3.Visible = true; break;
                case 3: panelTask4.Visible = true; break;
                case 4: panelTask5.Visible = true; break;
                case 5: panelTask6.Visible = true; break;
            }
        }
        private void HideAllPanels()
        {
            panelTask1.Visible = false;
            panelTask2.Visible = false;
            panelTask3.Visible = false;
            panelTask4.Visible = false;
            panelTask5.Visible = false;
            panelTask6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) //ПЕРВОЕ ЗАДАНИЕ
        {
            try
            {
                int n = int.Parse(textBox2.Text);
                int m = int.Parse(textBox1.Text);

                int[,] arr = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = Convert.ToInt32(matrixInput[j, i].Value);
                    }
                }

                var rows = GetIncreasingRows(arr);

                outputBox3.Clear();
                outputBox3.AppendText($"Количество строк: {rows.Count}\r\n\r\n");

                foreach (int r in rows)
                {
                    outputBox3.AppendText($"Строка {r + 1}: ");
                    for (int j = 0; j < m; j++)
                        outputBox3.AppendText(arr[r, j] + " ");

                    outputBox3.AppendText("\r\n");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }

        }
        private List<int> GetIncreasingRows(int[,] arr)
        {
            List<int> rows = new List<int>();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                bool ok = true;
                for (int j = 1; j < arr.GetLength(1); j++)
                    if (arr[i, j] <= arr[i, j - 1])
                    {
                        ok = false;
                        break;
                    }
                if (ok) rows.Add(i);
            }

            return rows;
        }

        private void button2_Click(object sender, EventArgs e) //ВТОРОЕ ЗАДАНИЕ
        {
            try
            {
                double x = double.Parse(textBox3.Text);
                double y = double.Parse(textBox4.Text);
                double z = double.Parse(textBox5.Text);

                double a = CalculateA(x, y);
                double b = CalculateB(z);

                Output.Text = "a = " + a.ToString("F4");
                Output2.Text = "b = " + b.ToString("F4");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }

        }
        private double CalculateA(double x, double y)
        {
            return 2 * Math.Pow(Math.Cos(x - (Math.PI / 6)), 4)
                   / (0.5 + Math.Pow(Math.Sin(y), 2));
        }

        private double CalculateB(double z)
        {
            return 1 + Math.Pow(z, 2) / (3 + (Math.Pow(z, 2) / 5));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox6.Text);
                double b = double.Parse(textBox7.Text);

                double u = 0, v, k;

                ComputeUVK(in a, in b, ref u, out v, out k);

                textBox8.Text =
                    $"u = {u}\r\nv = {v}\r\nk = {k}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void ComputeUVK(in double a, in double b, ref double u, out double v, out double k)
        {
            u = Math.Max(a, b - a);
            v = Math.Min(a * b, a + b);
            k = Math.Min(u + v * 2, 3.14);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = textBox9.Text
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int pos = IndexOfMin(arr);

                label14.Text = $"Минимальное значение = {arr[pos]}, индекс = {pos}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private int IndexOfMin(int[] arr)
        {
            int min = arr[0];
            int pos = 0;

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    pos = i;
                }

            return pos;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox18.Text);
                int b = int.Parse(textBox17.Text);
                int sum = int.Parse(textBox19.Text);

                FindNumbersWithDigitSum(ref a, ref b, sum, out int[] result, out bool ok);

                textBox20.Clear();

                if (!ok)
                {
                    textBox20.Text = "NO";
                    return;
                }

                foreach (int x in result)
                    textBox20.AppendText(x + " ");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private int SumDigits(int x)
        {
            x = Math.Abs(x);
            int s = 0;
            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }
            return s;
        }

        private void FindNumbersWithDigitSum(ref int a, ref int b, int digitSum, out int[] result, out bool found)
        {
            if (a > b) (a, b) = (b, a);

            List<int> list = new List<int>();

            for (int x = b; x >= a; x--)
                if (SumDigits(x) == digitSum)
                    list.Add(x);

            result = list.ToArray();
            found = list.Count > 0;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(textBox10.Text);
                double y1 = double.Parse(textBox11.Text);
                double x2 = double.Parse(textBox12.Text);
                double y2 = double.Parse(textBox13.Text);
                double x3 = double.Parse(textBox14.Text);
                double y3 = double.Parse(textBox15.Text);

                double a = 0, b = 0, c = 0;

                RAST(x1, y1, x2, y2, ref a);
                RAST(x2, y2, x3, y3, ref b);
                RAST(x1, y1, x3, y3, ref c);

                double P = PERIMETR(x1, y1, x2, y2, x3, y3);

                double s = P / 2.0;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                textBox16.Text =
                    $"Сторона a = {a:F4}\r\n" +
                    $"Сторона b = {b:F4}\r\n" +
                    $"Сторона c = {c:F4}\r\n\r\n" +
                    $"Периметр = {P:F4}\r\n" +
                    $"Площадь = {area:F4}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private void RAST(double x1, double y1, double x2, double y2, ref double result)
        {
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private double PERIMETR(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = 0, b = 0, c = 0;

            RAST(x1, y1, x2, y2, ref a);
            RAST(x2, y2, x3, y3, ref b);
            RAST(x1, y1, x3, y3, ref c);

            return a + b + c;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox2.Text);
                int m = int.Parse(textBox1.Text);

                if (n <= 0 || m <= 0)
                {
                    MessageBox.Show("Размеры матрицы должны быть > 0");
                    return;
                }

                matrixInput.Columns.Clear();
                for (int j = 0; j < m; j++)
                {
                    matrixInput.Columns.Add($"col{j}", $"C{j + 1}");
                }
                matrixInput.Rows.Clear();
                matrixInput.Rows.Add(n);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода размера матрицы");
            }
        }
    }

}
