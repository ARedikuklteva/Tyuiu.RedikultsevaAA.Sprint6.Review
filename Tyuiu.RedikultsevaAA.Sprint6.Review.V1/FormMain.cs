using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RedikultsevaAA.Sprint6.Review.V1.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Review.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonIn_RAA_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxN_RAA.Text);
            int M = Convert.ToInt32(textBoxM_RAA.Text);
            int n1 = Convert.ToInt32(textBoxN1_RAA.Text);
            int n2 = Convert.ToInt32(textBoxN2_RAA.Text);

            int[,] matrix = ds.RndMatrix(N, M, n1, n2);

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewIn_RAA.ColumnCount = columns; 
            dataGridViewIn_RAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_RAA.Columns[i].Width = 35; 

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewIn_RAA.Rows[i].Height = 35; 

                for (int j = 0; j < columns; j++) 
                {
                    dataGridViewIn_RAA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridViewIn_RAA.Rows[i].Cells[j].Value);
                }
            }

            int K = Convert.ToInt32(textBoxK_RAA.Text);
            int L = Convert.ToInt32(textBoxL_RAA.Text);
            int C = Convert.ToInt32(textBoxC_RAA.Text);

            int res = ds.Result(matrix, K, L, C);

            textBoxResult_RAA.Text = Convert.ToString(res);
        }

    }
}
