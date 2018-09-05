using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // DateTime.Now.Year - Pega a data do meu sistema operacional
            // dateTimePicker1 - é o meu elemento
            // .Value - eu indico para o sistema o valor que eu quero
            // .Year - eu pego o valor ANO
            int idade = DateTime.Now.Year - dateTimePicker1.Value.Year;
            MessageBox.Show("Tem " + idade + " anos de idade!");

            if (DateTime.Now.Year < dateTimePicker1.Value.DayOfYear) idade--;
            MessageBox.Show("Tem " + idade + " Anos de Idade!");

            if (idade < 18)
            {
                MessageBox.Show("Você é Menor de Idade!");
            }
            else if (idade > 18 && idade < 55)
            {
                MessageBox.Show("Você é Adulto!");
            }
            else {
                MessageBox.Show("Você está na Melhor Idade! ");
            }







                if (idade < 18)
            {
                MessageBox.Show("Você é Menor de idade");
            }
            else if (idade > 18 && idade < 55)
            {
                MessageBox.Show("Você é Adulto!");
            }
            else { 

                MessageBox.Show("Você está na Melhor Idade!");
            }

        }
    }
}
