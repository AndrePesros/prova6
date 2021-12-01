using OpenXmlPowerTools;
using Questao2.ConfigBD;
using Questao2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Questao2
{
    public partial class Form1 : Form
    {
        Usuario usuario = new Usuario();



        private BBHContext Dbontext;
        public Form1()
        {
            InitializeComponent();

            Dbontext = new BBHContext();


            var Usuario = Dbontext.Usuarios.ToList();
           
        }

        

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

                usuario.Nome = textNome.Text;
                usuario.Email = textEmail.Text;
                usuario.Idade = int.Parse(textIdade.Text);
                usuario.Sexo = textSexo.Text;
                usuario.Peso = double.Parse(textPeso.Text);
                usuario.Altura = double.Parse(textAltura.Text);
                textIMC.Text = CalcIMC().ToString();
            
            dataGridView1.Rows.Add(usuario.ID, usuario.Nome, usuario.Email, usuario.Sexo, usuario.Idade, usuario.Peso, usuario.Altura, textIMC.Text);



            textNome.Text = " ";
            textEmail.Text = " ";
            textIdade.Text = " ";
            textSexo.Text = " ";
            textPeso.Text = " ";
            textAltura.Text = " ";
            textIMC.Text = " ";
        } 
        
        double CalcIMC()

        {
            var a = usuario.Altura;
            var p = usuario.Peso;            
            var calc = (usuario.IMC = p / Math.Pow(a, 2)).ToString("F2");
            return double.Parse(calc);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textSexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textIdade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textPeso.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textAltura.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }
       
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
           


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textNome.Text = " ";
            textEmail.Text = " ";
            textIdade.Text = " ";
            textSexo.Text = " ";
            textPeso.Text = " ";
            textAltura.Text = " ";
            textIMC.Text = " ";
        }
    }
}
