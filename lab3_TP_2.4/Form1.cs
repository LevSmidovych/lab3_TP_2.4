using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace lab3_TP_2._4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Размер массива.
        /// </summary>
        private int arraySize;
        /// <summary>
        /// Массив. 
        /// </summary>
        int[] array = new int[1000];
        /// <summary>
        /// Условное недостижимое значение.
        /// </summary>
        readonly int INF = 999999999;
        /// <summary>
        /// Экземпляр класса.
        /// </summary>
        workWithArray arrayClass = new workWithArray();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выполняет первую операцию.
        /// </summary>
        private void firstOp_Click(object sender, EventArgs e)
        {
            output.Text = arrayClass.firstOp(numC.Text);
        }
        /// <summary>
        /// Выполняет вторую операцию.
        /// </summary>
        private void secondOp_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            array = arrayClass.secondOp();
            arraySize = Convert.ToInt32(arrSize.Text);
            getGridView();
            output.Text = getArrayInString();
        }
        /// <summary>
        /// Выполняет третью операцию.
        /// </summary>
        private void thirdOp_Click(object sender, EventArgs e)
        {
            output.Text = arrayClass.thirdOp(numC.Text);
        }
        /// <summary>
        /// Выполняет четвертую операцию.
        /// </summary>
        private void foursOp_Click(object sender, EventArgs e)
        {
            output.Text = arrayClass.foursOp();
        }
        /// <summary>
        /// Выводит массив в dataGridView1.
        /// </summary>
        private void getGridView()
        {
            for (int i = 0; i < arraySize; i++)
            {
                dataGridView1.Rows.Add(new object[] { i, array[i] });
            }

        }
        /// <summary>
        /// Выводит массив в textBox.
        /// </summary>
        public string getArrayInString()
        {
            if (arraySize == 0)
            {
                return "";
            }
            string arr_str = "";
            for (int i = 0; i < arraySize; i++)
            {
                arr_str += array[i] + " ";
            }
            return arr_str;
        }
        /// <summary>
        /// Генерирует массив.
        /// </summary>
        private void getArr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (arrayClass.getArr(arrSize.Text, lowerBorder.Text, upperBorder.Text)[0] == INF)
            {
                switch (arrayClass.getArr(arrSize.Text, lowerBorder.Text, upperBorder.Text)[1])
                {
                    case 0:
                        MessageBox.Show("Размер не соответсвует формату!", "Ошибка!");
                        break;
                    case 1:
                        MessageBox.Show("Максимальный допустимый размер 1000!", "Ошибка!");
                        break;
                    case 2:
                        MessageBox.Show("Нижняя граница не соответсвует формату!", "Ошибка!");
                        break;
                    case 3:
                        MessageBox.Show("Нижняя граница выходит за допустимые рамки (0, 10000)!", "Ошибка!");
                        break;
                    case 4:
                        MessageBox.Show("Верхняя граница не соответсвует формату!", "Ошибка!");
                        break;
                    case 5:
                        MessageBox.Show("Верхняя граница выходит за допустимые рамки (0, 10000)!", "Ошибка!");
                        break;
                    case 6:
                        MessageBox.Show("Нижняя граница больше верхней", "Ошибка!");
                        break;

                }
            }
            else
            {
                arraySize = Convert.ToInt32(arrSize.Text);
                array = arrayClass.getArr(arrSize.Text, lowerBorder.Text, upperBorder.Text);
            }
            getGridView();
            output.Text = getArrayInString();
        }
        /// <summary>
        /// Выводит диалог открытия файла.
        /// </summary>
        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            {
                string[] s = new string[1000];
                string fname = "";
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Title = "Открыть файл";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fname = openFileDialog1.FileName;
                }
                try
                {
                    s = File.ReadAllLines(fname);
                    arraySize = s.Length;
                    for (int i = 0; i < arraySize; ++i)
                    {
                        array[i] = Convert.ToInt32(s[i]);
                    }
                    arrayClass.array = array;
                    getGridView();
                    output.Text = getArrayInString();
                }
                catch (Exception )
                { MessageBox.Show("Ошибка при сохранении", "Сообщение"); }
            }
        }
        /// <summary>
        /// Выводит диалог сохранения файла.
        /// </summary>
        private void save_Click(object sender, EventArgs e)
        {
            string Fname = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Title = "Сохранить файл как";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fname = saveFileDialog1.FileName;
                FileStream fs = new FileStream(Fname, FileMode.Create, FileAccess.Write);
                if (fs != null)
                {
                    StreamWriter wr = new StreamWriter(fs);
                    for (int i = 0; i < arraySize; ++i)
                    {
                        wr.WriteLine(array[i]);
                    }
                    wr.Flush();
                    wr.Close();
                    fs.Close();
                }
            }
        }

    }
}


