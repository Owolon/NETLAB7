namespace NET_LAB7W
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
            taskSelector = new ComboBox();
            button1 = new Button();
            panelTask1 = new Panel();
            button7 = new Button();
            label5 = new Label();
            outputBox3 = new TextBox();
            label4 = new Label();
            matrixInput = new DataGridView();
            Столбец = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panelTask3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            panelTask2 = new Panel();
            Output2 = new Label();
            Output = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            panelTask5 = new Panel();
            label23 = new Label();
            textBox20 = new TextBox();
            label22 = new Label();
            textBox19 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            button5 = new Button();
            panelTask6 = new Panel();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            button6 = new Button();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            panelTask4 = new Panel();
            label15 = new Label();
            button4 = new Button();
            textBox9 = new TextBox();
            label14 = new Label();
            panelTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrixInput).BeginInit();
            panelTask3.SuspendLayout();
            panelTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTask5.SuspendLayout();
            panelTask6.SuspendLayout();
            panelTask4.SuspendLayout();
            SuspendLayout();
            // 
            // taskSelector
            // 
            taskSelector.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskSelector.FormattingEnabled = true;
            taskSelector.Items.AddRange(new object[] { "1. Найти возрастaющие строки матрицы", "2. Вычисление формул a и b", "3. Обработка строки", "4. Поиск максимума/проверка числа", "5. Числа с заданной суммой цифр", "6. Площадь треугольника" });
            taskSelector.Location = new Point(10, 12);
            taskSelector.Name = "taskSelector";
            taskSelector.Size = new Size(399, 33);
            taskSelector.TabIndex = 0;
            taskSelector.Text = "Выберите задание";
            taskSelector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(14, 477);
            button1.Name = "button1";
            button1.Size = new Size(189, 34);
            button1.TabIndex = 1;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelTask1
            // 
            panelTask1.Controls.Add(button7);
            panelTask1.Controls.Add(label5);
            panelTask1.Controls.Add(outputBox3);
            panelTask1.Controls.Add(label4);
            panelTask1.Controls.Add(matrixInput);
            panelTask1.Controls.Add(button1);
            panelTask1.Controls.Add(label3);
            panelTask1.Controls.Add(label2);
            panelTask1.Controls.Add(textBox2);
            panelTask1.Controls.Add(textBox1);
            panelTask1.Controls.Add(label1);
            panelTask1.Location = new Point(11, 59);
            panelTask1.Name = "panelTask1";
            panelTask1.Size = new Size(399, 516);
            panelTask1.TabIndex = 2;
            panelTask1.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(226, 106);
            button7.Name = "button7";
            button7.Size = new Size(159, 34);
            button7.TabIndex = 9;
            button7.Text = "Создать матрицу";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(14, 309);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 8;
            label5.Text = "Результат проверки:";
            // 
            // outputBox3
            // 
            outputBox3.BackColor = SystemColors.Info;
            outputBox3.BorderStyle = BorderStyle.FixedSingle;
            outputBox3.Location = new Point(14, 333);
            outputBox3.Multiline = true;
            outputBox3.Name = "outputBox3";
            outputBox3.ReadOnly = true;
            outputBox3.Size = new Size(371, 138);
            outputBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(14, 110);
            label4.Name = "label4";
            label4.Size = new Size(206, 21);
            label4.TabIndex = 6;
            label4.Text = "Введите элементы массива:";
            // 
            // matrixInput
            // 
            matrixInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixInput.Columns.AddRange(new DataGridViewColumn[] { Столбец });
            matrixInput.Location = new Point(14, 145);
            matrixInput.Name = "matrixInput";
            matrixInput.Size = new Size(371, 157);
            matrixInput.TabIndex = 5;
            // 
            // Столбец
            // 
            Столбец.HeaderText = "Столбец";
            Столбец.Name = "Столбец";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 73);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 4;
            label3.Text = "Строки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 3;
            label2.Text = "Столбцы";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(94, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(82, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите размер массива:";
            // 
            // panelTask3
            // 
            panelTask3.Controls.Add(label13);
            panelTask3.Controls.Add(label12);
            panelTask3.Controls.Add(label11);
            panelTask3.Controls.Add(label10);
            panelTask3.Controls.Add(textBox8);
            panelTask3.Controls.Add(textBox7);
            panelTask3.Controls.Add(textBox6);
            panelTask3.Controls.Add(button3);
            panelTask3.Location = new Point(37, 109);
            panelTask3.Name = "panelTask3";
            panelTask3.Size = new Size(343, 426);
            panelTask3.TabIndex = 4;
            panelTask3.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(26, 153);
            label13.Name = "label13";
            label13.Size = new Size(174, 21);
            label13.TabIndex = 19;
            label13.Text = "Результат вычислений:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(9, 22);
            label12.Name = "label12";
            label12.Size = new Size(229, 21);
            label12.TabIndex = 19;
            label12.Text = "Введите следующие значения:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(9, 103);
            label11.Name = "label11";
            label11.Size = new Size(81, 21);
            label11.TabIndex = 24;
            label11.Text = "Введите В";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(9, 64);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 23;
            label10.Text = "Введите А";
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Info;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(26, 186);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(294, 152);
            textBox8.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Info;
            textBox7.Location = new Point(94, 105);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(178, 23);
            textBox7.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(93, 64);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(179, 23);
            textBox6.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(83, 368);
            button3.Name = "button3";
            button3.Size = new Size(189, 34);
            button3.TabIndex = 19;
            button3.Text = "Вычислить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panelTask2
            // 
            panelTask2.BackColor = Color.Transparent;
            panelTask2.Controls.Add(Output2);
            panelTask2.Controls.Add(Output);
            panelTask2.Controls.Add(pictureBox2);
            panelTask2.Controls.Add(pictureBox1);
            panelTask2.Controls.Add(button2);
            panelTask2.Controls.Add(label9);
            panelTask2.Controls.Add(textBox5);
            panelTask2.Controls.Add(label8);
            panelTask2.Controls.Add(label6);
            panelTask2.Controls.Add(textBox3);
            panelTask2.Controls.Add(label7);
            panelTask2.Controls.Add(textBox4);
            panelTask2.Location = new Point(10, 110);
            panelTask2.Name = "panelTask2";
            panelTask2.Size = new Size(399, 365);
            panelTask2.TabIndex = 3;
            panelTask2.Visible = false;
            // 
            // Output2
            // 
            Output2.AutoSize = true;
            Output2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Output2.Location = new Point(14, 281);
            Output2.Name = "Output2";
            Output2.Size = new Size(93, 21);
            Output2.TabIndex = 18;
            Output2.Text = "Результат B";
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Output.Location = new Point(14, 228);
            Output.Name = "Output";
            Output.Size = new Size(94, 21);
            Output.TabIndex = 17;
            Output.Text = "Результат А";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Снимок_экрана_2025_11_28_183841;
            pictureBox2.Location = new Point(199, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2025_11_28_183810;
            pictureBox1.Location = new Point(199, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(110, 309);
            button2.Name = "button2";
            button2.Size = new Size(189, 34);
            button2.TabIndex = 9;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(8, 116);
            label9.Name = "label9";
            label9.Size = new Size(19, 21);
            label9.TabIndex = 14;
            label9.Text = "Z";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Info;
            textBox5.Location = new Point(33, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(8, 11);
            label8.Name = "label8";
            label8.Size = new Size(229, 21);
            label8.TabIndex = 9;
            label8.Text = "Введите следующие значения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(8, 87);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 12;
            label6.Text = "Y";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(33, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(8, 58);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 11;
            label7.Text = "X";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(33, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // panelTask5
            // 
            panelTask5.Controls.Add(label23);
            panelTask5.Controls.Add(textBox20);
            panelTask5.Controls.Add(label22);
            panelTask5.Controls.Add(textBox19);
            panelTask5.Controls.Add(label20);
            panelTask5.Controls.Add(label21);
            panelTask5.Controls.Add(textBox17);
            panelTask5.Controls.Add(textBox18);
            panelTask5.Controls.Add(button5);
            panelTask5.Location = new Point(12, 116);
            panelTask5.Name = "panelTask5";
            panelTask5.Size = new Size(401, 363);
            panelTask5.TabIndex = 4;
            panelTask5.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label23.Location = new Point(14, 14);
            label23.Name = "label23";
            label23.Size = new Size(229, 21);
            label23.TabIndex = 25;
            label23.Text = "Введите следующие значения:";
            // 
            // textBox20
            // 
            textBox20.BackColor = SystemColors.Info;
            textBox20.Location = new Point(23, 170);
            textBox20.Multiline = true;
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(347, 116);
            textBox20.TabIndex = 32;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label22.Location = new Point(23, 128);
            label22.Name = "label22";
            label22.Size = new Size(117, 21);
            label22.TabIndex = 31;
            label22.Text = "Введите сумму";
            // 
            // textBox19
            // 
            textBox19.BackColor = SystemColors.Info;
            textBox19.Location = new Point(146, 128);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(178, 23);
            textBox19.TabIndex = 30;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label20.Location = new Point(23, 86);
            label20.Name = "label20";
            label20.Size = new Size(81, 21);
            label20.TabIndex = 29;
            label20.Text = "Введите В";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label21.Location = new Point(23, 47);
            label21.Name = "label21";
            label21.Size = new Size(82, 21);
            label21.TabIndex = 28;
            label21.Text = "Введите А";
            // 
            // textBox17
            // 
            textBox17.BackColor = SystemColors.Info;
            textBox17.Location = new Point(108, 88);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(178, 23);
            textBox17.TabIndex = 27;
            // 
            // textBox18
            // 
            textBox18.BackColor = SystemColors.Info;
            textBox18.Location = new Point(107, 47);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(179, 23);
            textBox18.TabIndex = 26;
            // 
            // button5
            // 
            button5.Location = new Point(108, 310);
            button5.Name = "button5";
            button5.Size = new Size(189, 34);
            button5.TabIndex = 25;
            button5.Text = "Вычислить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panelTask6
            // 
            panelTask6.Controls.Add(textBox16);
            panelTask6.Controls.Add(textBox15);
            panelTask6.Controls.Add(textBox14);
            panelTask6.Controls.Add(textBox13);
            panelTask6.Controls.Add(label19);
            panelTask6.Controls.Add(label18);
            panelTask6.Controls.Add(label17);
            panelTask6.Controls.Add(label16);
            panelTask6.Controls.Add(button6);
            panelTask6.Controls.Add(textBox12);
            panelTask6.Controls.Add(textBox11);
            panelTask6.Controls.Add(textBox10);
            panelTask6.Location = new Point(65, 74);
            panelTask6.Name = "panelTask6";
            panelTask6.Size = new Size(280, 373);
            panelTask6.TabIndex = 4;
            panelTask6.Visible = false;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(19, 176);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(242, 128);
            textBox16.TabIndex = 12;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(165, 138);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(78, 23);
            textBox15.TabIndex = 11;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(165, 94);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(78, 23);
            textBox14.TabIndex = 10;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(165, 48);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(78, 23);
            textBox13.TabIndex = 9;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label19.Location = new Point(21, 136);
            label19.Name = "label19";
            label19.Size = new Size(56, 21);
            label19.TabIndex = 8;
            label19.Text = "(x3,y3)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(19, 93);
            label18.Name = "label18";
            label18.Size = new Size(56, 21);
            label18.TabIndex = 7;
            label18.Text = "(x2,y2)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(19, 46);
            label17.Name = "label17";
            label17.Size = new Size(56, 21);
            label17.TabIndex = 6;
            label17.Text = "(x1,y1)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(19, 12);
            label16.Name = "label16";
            label16.Size = new Size(242, 21);
            label16.TabIndex = 5;
            label16.Text = "Задайте треугольник 3 точками:";
            // 
            // button6
            // 
            button6.Location = new Point(46, 325);
            button6.Name = "button6";
            button6.Size = new Size(189, 34);
            button6.TabIndex = 4;
            button6.Text = "Вычислить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(81, 138);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(78, 23);
            textBox12.TabIndex = 2;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(81, 94);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(78, 23);
            textBox11.TabIndex = 1;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(81, 48);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(78, 23);
            textBox10.TabIndex = 0;
            // 
            // panelTask4
            // 
            panelTask4.Controls.Add(label15);
            panelTask4.Controls.Add(button4);
            panelTask4.Controls.Add(textBox9);
            panelTask4.Controls.Add(label14);
            panelTask4.Location = new Point(2, 58);
            panelTask4.Name = "panelTask4";
            panelTask4.Size = new Size(401, 281);
            panelTask4.TabIndex = 4;
            panelTask4.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(14, 190);
            label15.Name = "label15";
            label15.Size = new Size(198, 21);
            label15.TabIndex = 26;
            label15.Text = "Минимальное значение =";
            // 
            // button4
            // 
            button4.Location = new Point(106, 227);
            button4.Name = "button4";
            button4.Size = new Size(189, 34);
            button4.TabIndex = 25;
            button4.Text = "Найти минимальный элемент";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(29, 39);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(338, 141);
            textBox9.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(14, 15);
            label14.Name = "label14";
            label14.Size = new Size(226, 21);
            label14.TabIndex = 0;
            label14.Text = "Введите массив через пробел:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(419, 629);
            Controls.Add(panelTask5);
            Controls.Add(panelTask3);
            Controls.Add(panelTask6);
            Controls.Add(panelTask2);
            Controls.Add(panelTask4);
            Controls.Add(panelTask1);
            Controls.Add(taskSelector);
            Name = "Form1";
            Text = "Лабораторная работа 7";
            Load += Form1_Load_1;
            panelTask1.ResumeLayout(false);
            panelTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrixInput).EndInit();
            panelTask3.ResumeLayout(false);
            panelTask3.PerformLayout();
            panelTask2.ResumeLayout(false);
            panelTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTask5.ResumeLayout(false);
            panelTask5.PerformLayout();
            panelTask6.ResumeLayout(false);
            panelTask6.PerformLayout();
            panelTask4.ResumeLayout(false);
            panelTask4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox taskSelector;
        private Button button1;
        private Panel panelTask1;
        private Panel panelTask2;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panelTask5;
        private Panel panelTask3;
        private Panel panelTask4;
        private Panel panelTask6;
        private DataGridView matrixInput;
        private Label label4;
        private Label label5;
        private TextBox outputBox3;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label Output;
        private Label Output2;
        private Button button3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button4;
        private TextBox textBox9;
        private Label label14;
        private Label label15;
        private Button button5;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button button6;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label23;
        private TextBox textBox20;
        private Label label22;
        private TextBox textBox19;
        private Label label20;
        private Label label21;
        private TextBox textBox17;
        private TextBox textBox18;
        private DataGridViewTextBoxColumn Столбец;
        private Button button7;
    }
}
