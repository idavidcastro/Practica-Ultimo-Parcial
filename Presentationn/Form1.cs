using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationn
{
    public partial class Form1 : Form
    {
        SedeService sedeService;
        InventarioSedeService inventarioSedeService;
        public Form1()
        {
            InitializeComponent();
            sedeService = new SedeService(ConfigConnectionString.Cadena);

            MostrarSedes();
        }

        public void MostrarSedes()
        {
            List<Sede> sedes = new List<Sede>();

            sedes = sedeService.ConsultarListSedes();

            CmbSedes.DataSource = sedes;
            CmbSedes.DisplayMember = "Codigo";

            CmbConsultarSRegistroPorSede.DataSource = sedes;
            CmbConsultarSRegistroPorSede.DisplayMember = "Codigo";

        }

        private void BtnSeleccione_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            var respuetsa = openFile.ShowDialog();
            if (respuetsa == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;
                TxtRutaArchivo.Text = openFile.FileName;
            }
        }

        private void BtnCargarInventario_Click(object sender, EventArgs e)
        {
            inventarioSedeService = new InventarioSedeService();
            OpenFileDialog openFile = new OpenFileDialog();
            string file = openFile.FileName;
            TxtRutaArchivo.Text = openFile.FileName;
            var ruta = TxtRutaArchivo.Text;
            
            if (ruta != " ")
            {
                string mensaje = inventarioSedeService.GuardarArchivo(file); 
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Seleccione un Archivo para cargar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultarSRegistroPorSede_Click(object sender, EventArgs e)
        {
            BusquedaReponseInventario respuesta;
            respuesta = inventarioSedeService.ConsultarInventarioPorSedes(CmbConsultarSRegistroPorSede.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataGridView1.DataSource = respuesta.InventarioSedes;
            }

        }
    }
}
