using Aspose.Cells;
using DataReader.ENTIDADES;
using Microsoft.VisualBasic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;



namespace DataReader
{
    public partial class Form1 : Form
    {
        List<ClienteEnt> clientListExcel = new List<ClienteEnt>();
        List<ClienteEnt> clientListTxt = new List<ClienteEnt>();
        List<ClienteEnt> finalList = new List<ClienteEnt>();


        FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            String ruta = String.Empty;
            textBox1.Text = String.Empty;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                ruta = choofdlog.FileNames[0].ToString().Trim().ToUpper();
                textBox1.Text = ruta;

                if (ruta == String.Empty)
                {
                    MessageBox.Show("Favor de colocar una ruta", "Caja de texto vacia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                }
            }
            if (ruta != String.Empty)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea continuar?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        textBox1.Text = ruta;
                        readTxt(ruta, 1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar cargar el Excel: " + ex.Message.ToString().ToUpper().Trim(),
                        "Errro de cargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            String ruta = String.Empty;
            textBox2.Text = String.Empty;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                ruta = choofdlog.FileNames[0].ToString().Trim().ToUpper();
                textBox2.Text = ruta;

                if (ruta == String.Empty)
                {
                    MessageBox.Show("Favor de colocar una ruta", "Caja de texto vacia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button2.Focus();
                }
                if (ruta != String.Empty)
                {
                    try
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea continuar?",
                            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            textBox2.Text = ruta;
                            readTxt(ruta, 2);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar cargar el TXT: " + ex.Message.ToString().ToUpper().Trim(),
                            "Errror de cargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void readExcel(String path)
        {

            progressBar2.Value = 0;
            //Cargado de archivo de excel
            Workbook workbook = new Workbook(path);
            //Obtiene todas las hojas de trabajo
            List<ClienteEnt> clienteList = new List<ClienteEnt>();
            WorksheetCollection collection = workbook.Worksheets;
            int contador = 0;
            //Cantidad de renglones
            int maxrows = 0;
            int maxcolumnscols = 0;
            int progresoAnterio = -1;
            int indice = 0;

            for (int wsi = 0; wsi < collection.Count; wsi++)
            {
                //Recorrido por hoja de trabajo
                Worksheet worksheet = collection[wsi];
                //Imprimimos el nombre de la hoja de trabajo
                Console.WriteLine("Nombre de la hoja: " + worksheet.Name);
                maxrows = maxrows + worksheet.Cells.MaxDataRow;
                maxcolumnscols = worksheet.Cells.MaxDataColumn;
            }
             
            
            for (int wsi = 0; wsi < collection.Count; wsi++)
            {                
                Worksheet worksheet = collection[wsi];                
                Console.WriteLine("Nombre de la hoja: " + worksheet.Name);
                int rows = worksheet.Cells.MaxDataRow;
                int cols = worksheet.Cells.MaxDataColumn;

                //Bucle a tra vez de filas
                for (int i = 0; i <= rows; i++)
                {
                    contador++;
                    ClienteEnt cliente = new ClienteEnt();

                    ////////////////////////////////////////////////////
                    int progresoActual = (int)(contador * 100.00 / maxrows);
                    if (progresoActual != progresoAnterio)
                    {                     
                        progressBar2.Value = progresoActual;                        
                        progresoAnterio = progresoActual;
                    }
                    ////////////////////////////////////////////////////

                    //Recorrido de la columna
                    for (int j = 0; j <= cols; j++)
                    {
                        if (i == 0)
                        {
                            if (worksheet.Cells[i, j].Value.ToString().ToUpper() == "CLIENTE")
                            {
                                indice = j;
                            }
                        }

                            Console.WriteLine(worksheet.Cells[i, j].Value + " | ");
                        if (i != 0)
                        {                                                       
                            if (j == 0)
                            {
                                cliente.id = contador; //= (int)worksheet.Cells[i, j].Value;
                            }
                            if (j == 1)
                            {
                                cliente.nombre = "UNKNOW";//worksheet.Cells[i, j].Value.ToString();
                            }
                            if (j == indice)
                            {
                                cliente.cliente = worksheet.Cells[i, j].Value.ToString();
                                clienteList.Add(cliente);
                            }
                        }
                    }
                    Console.WriteLine(" ");
                }                
            }
            labelTxtExcel.Text = contador.ToString();
            dataGridView1.DataSource = clienteList;
            clientListExcel = clienteList;

            //EDICION DE DATA GREED 
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "CLIENTE";
            dataGridView1.Columns[0].Width = 55;
            dataGridView1.DataSource = clienteList;
        }

        public void readTxt(String path, int opcion)
        {
            List<ClienteEnt> clientList = new List<ClienteEnt>();
            List<List<string>> datos = new List<List<string>>();
            int contador = 0;
            int progresoAnterio = -1;
            int indice = 0;
            TimeSpan diferencia;
            try
            {
                var lines = File.ReadLines(path);
                double cantLines = lines.Count();

                DateTime momento1 = DateTime.Now;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        contador++;
                        int progresoActual = (int)(contador * 100.00 / cantLines);
                        if (progresoActual != progresoAnterio)
                        {
                            if (opcion == 2)
                            {
                                progressBar1.Value = progresoActual;
                            }
                            else
                            {
                                progressBar2.Value = progresoActual;
                            }
                            progresoAnterio = progresoActual;
                        }

                        ClienteEnt ent = new ClienteEnt();
                        string[] campos = line.Split('|');

                        if (contador == 1)
                        {
                            string[] arregloMayusculas = campos.Select(cadena => cadena.ToUpper()).ToArray();
                            indice = Array.IndexOf(arregloMayusculas, "CLIENTE");
                        }
                        if (opcion == 2)
                        {
                            ent.cliente = campos[indice].ToString().Trim();
                            ent.nombre = "UNKNOWN";
                            ent.id = contador;
                        }
                        else if (opcion == 1)
                        {
                            ent.cliente = campos[indice].ToString().Trim();
                            ent.nombre = "UNKNOWN";
                            ent.id = contador;
                        }
                        clientList.Add(ent);
                    }
                    DateTime momento2 = DateTime.Now;
                    diferencia = momento2 - momento1;

                    // progressBar1.Value = 100;
                    clientList.RemoveAt(0);

                    if (opcion == 2)
                    {
                        labelTxtResult.Text = contador.ToString();
                        dataGridView2.DataSource = clientList;
                        clientListTxt = clientList;
                        //EDICION DE DATA GREED 
                        //dataGridView2.Columns[0].Visible = false;
                        dataGridView2.Columns[1].Visible = false;
                        dataGridView2.Columns[0].HeaderText = "ID";
                        dataGridView2.Columns[2].HeaderText = "CLIENTE";
                        dataGridView2.Columns[0].Width = 55;                        
                        label15.Text = diferencia.TotalSeconds.ToString("F2") +" s";


                    }
                    if (opcion == 1)
                    {
                        labelTxtExcel.Text = contador.ToString();
                        dataGridView1.DataSource = clientList;
                        clientListExcel = clientList;
                        //EDICION DE DATA GREED 
                        //dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[2].HeaderText = "CLIENTE";
                        dataGridView1.Columns[0].Width = 55;
                        String.Format("");
                        label14.Text = diferencia.TotalSeconds.ToString("F2") +" s";

                    }
                }              
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no fue encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

            //dataGridView2.DataSource = clientList;
            //labelTxtResult.Text = contador.ToString();
        }

        public void readTxtThread(String path)
        {
            // Lista para almacenar los datos procesados
            List<string[]> data = new List<string[]>();

            // Leer todas las líneas del archivo
            string[] lines = File.ReadAllLines(path);

            // Usar hilos para procesar cada línea
            Task[] tasks = new Task[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    // Dividir la línea por el separador "|"
                    string[] fields = lines[index].Split('|');

                    // Agregar los campos a la lista
                    data.Add(fields);

                    // Puedes agregar lógica adicional aquí para procesar los campos
                    // o guardarlos en una base de datos, etc.
                });
            }

            // Esperar a que todos los hilos terminen
            Task.WaitAll(tasks);

            // Procesar los datos (por ejemplo, imprimir)
            foreach (string[] lineData in data)
            {
                foreach (string field in lineData)
                {
                    Console.Write(field + " ");
                }
                Console.WriteLine();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientListExcel.Count != 0 && clientListTxt.Count != 0)
                {
                    finalList = clientListExcel.Intersect(clientListTxt, new MiObjetoComparer()).ToList();
                    label6.Text = finalList.Count.ToString();
                    dataGridView3.DataSource = finalList;

                    //EDICION DE DATAGRID
                    dataGridView3.Columns[0].HeaderText = "ID";
                    dataGridView3.Columns[1].HeaderText = "NOMBRE";
                    dataGridView3.Columns[2].HeaderText = "CLIENTE";
                }
                else
                {
                    MessageBox.Show("Cargar los dos documentos requeridos para la comparación: ",
                   "Cargado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro con el cargado de las listas" + ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                //MessageBox.Show("Carpeta seleccionada: " + selectedPath);
                textBox3.Text = selectedPath;
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea continuar?",
                             "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string[] formattedStrings = new string[finalList.Count];
                    for (int i = 0; i < finalList.Count; i++)
                    {
                        formattedStrings[i] = finalList[i].cliente + " | ";
                    }

                    try
                    {
                        // Convierto la lista en una cadena con los elementos separados por "|"
                        // string linea = string.Join("|", finalList.Select(x => x.cliente).ToList());
                        // Escribo la línea en el archivo
                        File.WriteAllLines(selectedPath + "\\resultado.txt", formattedStrings, Encoding.UTF8);
                        MessageBox.Show("Se ah creado el arcivho : " + " resultado.txt " + " En la ruta " + selectedPath,
                            "Tarea terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al crear el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            label12.Text = ahora.ToString("HH:mm:ss");
            label12.Width = 300;
            label12.Height = 300;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            String ruta = String.Empty;
            textBox1.Text = String.Empty;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                ruta = choofdlog.FileNames[0].ToString().Trim().ToUpper();
                textBox1.Text = ruta;

                if (ruta == String.Empty)
                {
                    MessageBox.Show("Favor de colocar una ruta", "Caja de texto vacia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                }
            }
            if (ruta != String.Empty)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea continuar?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        textBox1.Text = ruta;
                        readExcel(ruta);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar cargar el Excel: " + ex.Message.ToString().ToUpper().Trim(),
                        "Errro de cargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
