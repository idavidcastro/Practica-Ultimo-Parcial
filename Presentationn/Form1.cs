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
    }
}
