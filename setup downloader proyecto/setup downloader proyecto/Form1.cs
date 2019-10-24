using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace setup_downloader_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCuenta.Items.Add("Pure Driving School");
            cbBlapCuenta.Checked = true;
        }

        private void cbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategoria.Items.Clear();
            if (cbCuenta.SelectedIndex.Equals(0))//obtener categorias
            {
                List<string> pureCategorias = new List<string>();
                HtmlWeb pureWeb = new HtmlWeb();
                HtmlDocument doc = pureWeb.Load("https://puredrivingschool.com/membersite/");

                foreach (var Nodo in doc.DocumentNode.CssSelect(".av-inner-tab-title"))
                {
                    var NodoSpanCategoria = Nodo.CssSelect("span");
                    pureCategorias.Add(Nodo.InnerHtml);
                }
                for (int i = 1; i < pureCategorias.Count; i++)
                {
                    cbCategoria.Items.Add(pureCategorias[i]);
                }
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
 
        private void btnDescargarCuenta_Click(object sender, EventArgs e)
        {
            if (cbBlapCuenta.Checked == false && cbOlapCuenta.Checked == false && cbTelemetriaCuenta.Checked == false && cbSetupCuenta.Checked == false) //validar checkbox vacias
            {
                MessageBox.Show("Debe seleccionar al menos un archivo a descargar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbBlapCuenta.Checked == true || cbOlapCuenta.Checked == true || cbTelemetriaCuenta.Checked == true || cbSetupCuenta.Checked == true) //valiar que el usuario quiera descargar y luego descarga
            {
                if(MessageBox.Show("Está seguro que quiere descargar los archivos seleccionados?","Descargar",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                {
                    //ODIGO DE DESCARGA
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e) //boton agregar categoria
        {

            string valor = cbCategoria.Text;
            if (lstCategoria.Items.Contains(valor))
            {
                MessageBox.Show("Ya ha elegido esta categoría...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//validar valores duplicados
            }

            
            else
            {
                if (cbCategoria.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Debe seleccionar una categoría...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//validar que no se agregue nada vacio
                }

                else
                {
                    lstCategoria.Items.Add(cbCategoria.SelectedItem); //agregar categoria
                }
            }
        }

        private void btnDescargarCategoria_Click(object sender, EventArgs e)
        {
            if (cbBlapCategoria.Checked == false && cbOlapCategoria.Checked == false && cbTelemetriaCategoria.Checked == false && cbSetupCategoria.Checked == false) //validar checkbox vacias
            {
                MessageBox.Show("Debe seleccionar al menos un archivo a descargar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbBlapCategoria.Checked == true || cbOlapCategoria.Checked == true || cbTelemetriaCategoria.Checked == true || cbSetupCategoria.Checked == true) //valiar que el usuario quiera descargar y luego descarga
            {
                if (MessageBox.Show("Está seguro que quiere descargar los archivos seleccionados?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    // CODIGO DE DESCARGA
                }
            }
        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e) //boton borrar categoria
        {
            lstCategoria.Items.Remove(lstCategoria.SelectedItem); 
        }

        private void btnAgregarCoche_Click(object sender, EventArgs e) //boton agregar coche
        {
            string valor = cbCoche.Text;
            if (lstCoche.Items.Contains(valor))
            {
                MessageBox.Show("Ya ha elegido este coche...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//validar valores duplicados
            }


            else
            {
                if (cbCoche.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Debe seleccionar un coche...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//validar que no se agregue nada vacio
                }

                else
                {
                    lstCoche.Items.Add(cbCoche.SelectedItem); //agregar categoria
                }
            }
        }

        private void btnBorrarCoche_Click(object sender, EventArgs e) //boton borrar coche
        {
            lstCoche.Items.Remove(lstCoche.SelectedItem); 
        }

        private void btnDescargarCoche_Click(object sender, EventArgs e)
        {
            if (cbBlapCoche.Checked == false && cbOlapCoche.Checked == false && cbTelemetriaCoche.Checked == false && cbSetupCoche.Checked == false) //validar checkbox vacias
            {
                MessageBox.Show("Debe seleccionar al menos un archivo a descargar...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (cbBlapCoche.Checked == true || cbOlapCoche.Checked == true || cbTelemetriaCoche.Checked == true || cbSetupCoche.Checked == true) //valiar que el usuario quiera descargar y luego descarga
            {
                if (MessageBox.Show("Está seguro que quiere descargar los archivos seleccionados?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    // CODIGO DE DESCARGA
                }
            }
        }

        private void gbCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
