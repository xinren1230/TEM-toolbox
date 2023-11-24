using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace TEM_wavelength_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Constants
            double h = 6.626e-34;      // Planck's constant (J·s)
            double m = 9.109e-31;      // Mass of the electron (kg)
            double ec = 1.602e-19;      // Elementary charge (C)

            // Input: Accelerating voltage (KV)
            double V = Double.Parse(textBox1.Text);

            // Calculate de Broglie wavelength
            double lambda = 1e9*CalculateDeBroglieWavelength(h, m, ec, 1000*V);

            // Display the result

        textBox2.Text=lambda.ToString();


        }

        static double CalculateDeBroglieWavelength(double h, double m, double e, double V)
        {
            // Calculate velocity
            double v = Math.Sqrt((2 * e * V) / m);

            // Calculate de Broglie wavelength
            double lambda = h / Math.Sqrt(2 * m * e * V);

            return lambda;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lamda = Double.Parse(textBox2.Text);
            double d = Double.Parse(textBox3.Text);
            double theta = 180*Math.Asin(lamda / 2 / d)/3.1415926; //lamda=2dsin(theta)
            textBox4.Text = theta.ToString();
        }



        static double AngleBetweenVectors(double[] vector1, double[] vector2)
        {
            double dotProduct = 0;
            double magnitude1 = 0;
            double magnitude2 = 0;

            // 计算点积
            for (int i = 0; i < vector1.Length; i++)
            {
                dotProduct += vector1[i] * vector2[i];
                magnitude1 += Math.Pow(vector1[i], 2);
                magnitude2 += Math.Pow(vector2[i], 2);
            }

            // 计算模
            magnitude1 = Math.Sqrt(magnitude1);
            magnitude2 = Math.Sqrt(magnitude2);

            // 计算夹角（弧度）
            double angleRadians = Math.Acos(dotProduct / (magnitude1 * magnitude2));

            return angleRadians;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 定义两个向量
            double[] vector1 = { 1, 1, 1 };
            double[] vector2 = { 11, 9, 14 };

            // 计算夹角（弧度）
            double angleRadians = AngleBetweenVectors(vector1, vector2);

            // 将弧度转换为角度
            double angleDegrees = angleRadians * (180.0 / Math.PI);

            textBox5.Text = angleDegrees.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
