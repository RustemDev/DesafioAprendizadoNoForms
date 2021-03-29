using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioMatematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Aqui criamos uma operação de SOMA no forms
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(label1.Text);
                int num2 = Convert.ToInt32(label2.Text);
                int result = 0;

                result = Convert.ToInt32(textBox1.Text);



                if (num1 + num2 == result)
                {
                    MessageBox.Show("Parabéns precioso vc acertou ");

                }
                else
                {
                    MessageBox.Show("Errou precioso kkkk, tente novamente");
                }

                button3.Visible = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Este campo só aceita numeros Precioso");
            }
        }
      


        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = new Random().Next(1, 20).ToString();
            label2.Text = new Random().Next(21, 50).ToString();

            textBox1.Text = "";

        }



        //Aqui a classe RANDOM juntamente com o NEXT é usado para gerar numeros aleatórios
        // Aqui o método Form1_Load é ativado toda vez que o usuario abrir o formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            //Aqui está o sistema aleatório dos numeros para soma
            label1.Text = new Random().Next(1, 20).ToString();
            label2.Text = new Random().Next(21, 50).ToString();
            //Aqui está o sistema aleatório dos numeros para subtração 
            label5.Text = new Random().Next(1, 20).ToString();
            label7.Text = new Random().Next(21, 50).ToString();
            //Aqui está o sistema aleatório dos numeros para divisão
            label9.Text = new Random().Next(1, 20).ToString();
            label11.Text = new Random().Next(21, 50).ToString();
            //Aqui está o sistema aleatório dos numeros para multiplicação
            label13.Text = new Random().Next(1, 20).ToString();
            label15.Text = new Random().Next(21, 50).ToString();

        }








        //Aqui criamos uma operação de SUBTRAÇÃO no forms
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(label5.Text);
                int num2 = Convert.ToInt32(label7.Text);
                int result = 0;

                result = Convert.ToInt32(textBox2.Text);

                if (num1 - num2 == result)
                {
                    MessageBox.Show("Parabéns precioso vc acertou ");

                }
                else
                {
                    MessageBox.Show("Errou precioso kkkk, tente novamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Este campo só aceita numeros Precioso");
            }

            button4.Visible = true;
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = new Random().Next(21, 200).ToString();
            label7.Text = new Random().Next(21, 50).ToString();

            textBox2.Text = "";

        }



        //Aqui criamos uma operação de DIVISÃO no forms
        private void Resultado_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(label9.Text);
                int num2 = Convert.ToInt32(label11.Text);
                int result = 0;

                result = Convert.ToInt32(textBox3.Text);

                if (num1 / num2 == result)
                {
                    MessageBox.Show("Parabéns precioso vc acertou ");

                }
                else
                {
                    MessageBox.Show("Errou precioso kkkk, tente novamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Este campo só aceita numeros Precioso");
            }

            button6.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = new Random().Next(50, 200).ToString();
            label11.Text = new Random().Next(21, 50).ToString();
            textBox3.Text = "";


        }


        //Aqui criamos uma operação de MULTIPLICAÇÃO no forms
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(label13.Text);
                int num2 = Convert.ToInt32(label15.Text);
                int result = 0;

                result = Convert.ToInt32(textBox4.Text);

                if (num1 * num2 == result)
                {
                    MessageBox.Show("Parabéns precioso vc acertou ");

                }
                else
                {
                    MessageBox.Show("Errou precioso kkkk, tente novamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Este campo só aceita numeros Precioso");
            }

            button8.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label13.Text = new Random().Next(1, 20).ToString();
            label15.Text = new Random().Next(21, 50).ToString();
            textBox4.Text = "";

        }
    }
}
