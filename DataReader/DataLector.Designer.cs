namespace DataReader
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelTxtResult = new Label();
            labelTxtExcel = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button3 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            button5 = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            textBox3 = new TextBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar2 = new ProgressBar();
            label11 = new Label();
            label12 = new Label();
            label16 = new Label();
            LABEL6400 = new Label();
            LABEL6001 = new Label();
            LABEL6500 = new Label();
            LABEL6800 = new Label();
            label13 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            LABEL9300 = new Label();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            btnscript = new Button();
            label21 = new Label();
            txbscripts = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(53, 94);
            button1.Name = "button1";
            button1.Size = new Size(147, 34);
            button1.TabIndex = 0;
            button1.Text = "TXT FILTRADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 17);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 1;
            label1.Text = "RUTA DE EXCEL:";
            // 
            // button2
            // 
            button2.Location = new Point(40, 87);
            button2.Name = "button2";
            button2.Size = new Size(147, 34);
            button2.TabIndex = 2;
            button2.Text = "CARGAR TXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(706, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(705, 31);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 22);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 4;
            label2.Text = "RUTA DE TXT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 128);
            label3.Name = "label3";
            label3.Size = new Size(308, 25);
            label3.TabIndex = 6;
            label3.Text = "CANTIDAD DE REGISTROS EXCEL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 134);
            label4.Name = "label4";
            label4.Size = new Size(289, 25);
            label4.TabIndex = 7;
            label4.Text = "CANTIDAD DE REGISTROS TXT:";
            // 
            // labelTxtResult
            // 
            labelTxtResult.AutoSize = true;
            labelTxtResult.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTxtResult.ForeColor = SystemColors.MenuHighlight;
            labelTxtResult.Location = new Point(342, 127);
            labelTxtResult.Name = "labelTxtResult";
            labelTxtResult.Size = new Size(31, 34);
            labelTxtResult.TabIndex = 8;
            labelTxtResult.Text = "0";
            // 
            // labelTxtExcel
            // 
            labelTxtExcel.AutoSize = true;
            labelTxtExcel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTxtExcel.ForeColor = SystemColors.MenuHighlight;
            labelTxtExcel.Location = new Point(342, 123);
            labelTxtExcel.Name = "labelTxtExcel";
            labelTxtExcel.Size = new Size(31, 34);
            labelTxtExcel.TabIndex = 9;
            labelTxtExcel.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(752, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(454, 192);
            dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(752, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(454, 192);
            dataGridView2.TabIndex = 11;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(9, 93);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(537, 319);
            dataGridView3.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(38, 54);
            button3.Name = "button3";
            button3.Size = new Size(147, 31);
            button3.TabIndex = 13;
            button3.Text = "COMPARAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 27);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 14;
            label5.Text = "CLIENTE UNION";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(labelTxtExcel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1218, 259);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.YellowGreen;
            label14.Location = new Point(1177, 225);
            label14.Name = "label14";
            label14.Size = new Size(24, 25);
            label14.TabIndex = 15;
            label14.Text = "0";
            // 
            // button5
            // 
            button5.Location = new Point(194, 82);
            button5.Name = "button5";
            button5.Size = new Size(147, 34);
            button5.TabIndex = 19;
            button5.Text = "CARGAR EXCEL";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.ForeColor = Color.YellowGreen;
            label8.Location = new Point(9, 81);
            label8.Name = "label8";
            label8.Size = new Size(31, 32);
            label8.TabIndex = 12;
            label8.Text = "1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(labelTxtResult);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1218, 262);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.YellowGreen;
            label15.Location = new Point(1175, 224);
            label15.Name = "label15";
            label15.Size = new Size(24, 25);
            label15.TabIndex = 20;
            label15.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label9.ForeColor = Color.YellowGreen;
            label9.Location = new Point(9, 89);
            label9.Name = "label9";
            label9.Size = new Size(31, 32);
            label9.TabIndex = 13;
            label9.Text = "2";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(dataGridView3);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(button3);
            groupBox4.Location = new Point(12, 536);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(558, 418);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label10.ForeColor = Color.YellowGreen;
            label10.Location = new Point(6, 52);
            label10.Name = "label10";
            label10.Size = new Size(31, 32);
            label10.TabIndex = 14;
            label10.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(443, 52);
            label6.Name = "label6";
            label6.Size = new Size(31, 34);
            label6.TabIndex = 13;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(185, 57);
            label7.Name = "label7";
            label7.Size = new Size(267, 25);
            label7.TabIndex = 12;
            label7.Text = "CLIENTES EN INTRESECCIÓN:";
            // 
            // button4
            // 
            button4.Location = new Point(619, 552);
            button4.Name = "button4";
            button4.Size = new Size(145, 35);
            button4.TabIndex = 15;
            button4.Text = "GENERAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(588, 593);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 31);
            textBox3.TabIndex = 12;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(764, 483);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(419, 34);
            progressBar1.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(762, 228);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(421, 34);
            progressBar2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label11.ForeColor = Color.YellowGreen;
            label11.Location = new Point(588, 553);
            label11.Name = "label11";
            label11.Size = new Size(31, 32);
            label11.TabIndex = 15;
            label11.Text = "4";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(876, 552);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(588, 643);
            label16.Name = "label16";
            label16.Size = new Size(226, 25);
            label16.TabIndex = 19;
            label16.Text = "TASAS POR PRODUCTO:";
            label16.Click += label16_Click;
            // 
            // LABEL6400
            // 
            LABEL6400.AutoSize = true;
            LABEL6400.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL6400.Location = new Point(600, 710);
            LABEL6400.Name = "LABEL6400";
            LABEL6400.Size = new Size(23, 25);
            LABEL6400.TabIndex = 20;
            LABEL6400.Text = "0";
            // 
            // LABEL6001
            // 
            LABEL6001.AutoSize = true;
            LABEL6001.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL6001.Location = new Point(600, 764);
            LABEL6001.Name = "LABEL6001";
            LABEL6001.Size = new Size(23, 25);
            LABEL6001.TabIndex = 21;
            LABEL6001.Text = "0";
            // 
            // LABEL6500
            // 
            LABEL6500.AutoSize = true;
            LABEL6500.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL6500.Location = new Point(600, 814);
            LABEL6500.Name = "LABEL6500";
            LABEL6500.Size = new Size(23, 25);
            LABEL6500.TabIndex = 22;
            LABEL6500.Text = "0";
            // 
            // LABEL6800
            // 
            LABEL6800.AutoSize = true;
            LABEL6800.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL6800.Location = new Point(600, 864);
            LABEL6800.Name = "LABEL6800";
            LABEL6800.Size = new Size(23, 25);
            LABEL6800.TabIndex = 23;
            LABEL6800.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(598, 839);
            label13.Name = "label13";
            label13.Size = new Size(168, 25);
            label13.TabIndex = 27;
            label13.Text = "PRODUCTO 6800:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(600, 789);
            label17.Name = "label17";
            label17.Size = new Size(168, 25);
            label17.TabIndex = 26;
            label17.Text = "PRODUCTO 6500:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(600, 739);
            label18.Name = "label18";
            label18.Size = new Size(166, 25);
            label18.TabIndex = 25;
            label18.Text = "PRODUCTO 6001:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(598, 685);
            label19.Name = "label19";
            label19.Size = new Size(168, 25);
            label19.TabIndex = 24;
            label19.Text = "PRODUCTO 6400:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(598, 894);
            label20.Name = "label20";
            label20.Size = new Size(168, 25);
            label20.TabIndex = 29;
            label20.Text = "PRODUCTO 9300:";
            // 
            // LABEL9300
            // 
            LABEL9300.AutoSize = true;
            LABEL9300.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL9300.Location = new Point(600, 919);
            LABEL9300.Name = "LABEL9300";
            LABEL9300.Size = new Size(23, 25);
            LABEL9300.TabIndex = 28;
            LABEL9300.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(576, 536);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(937, 418);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnscript);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(txbscripts);
            groupBox5.Location = new Point(1236, 29);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(277, 501);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "GENRACION DE SCRIPTS";
            // 
            // btnscript
            // 
            btnscript.Location = new Point(10, 111);
            btnscript.Name = "btnscript";
            btnscript.Size = new Size(147, 34);
            btnscript.TabIndex = 20;
            btnscript.Text = "SCRIPTS";
            btnscript.UseVisualStyleBackColor = true;
            btnscript.Click += btnscript_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(6, 31);
            label21.Name = "label21";
            label21.Size = new Size(149, 25);
            label21.TabIndex = 4;
            label21.Text = "RUTA DE DATA";
            // 
            // txbscripts
            // 
            txbscripts.Location = new Point(10, 71);
            txbscripts.Name = "txbscripts";
            txbscripts.Size = new Size(253, 31);
            txbscripts.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 965);
            Controls.Add(groupBox5);
            Controls.Add(label20);
            Controls.Add(LABEL9300);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(LABEL6800);
            Controls.Add(LABEL6500);
            Controls.Add(LABEL6001);
            Controls.Add(LABEL6400);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "LECTOR DE DATOS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTxtResult;
        private Label labelTxtExcel;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button3;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Label label6;
        private Label label7;
        private Button button4;
        private TextBox textBox3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar2;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button5;
        private Label label14;
        private Label LABEL6400;
        private Label label15;
        private Label label16;
        private Label LABEL6001;
        private Label LABEL6500;
        private Label LABEL6800;
        private Label label13;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label LABEL9300;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Button btnscript;
        private Label label21;
        private TextBox txbscripts;
    }
}
