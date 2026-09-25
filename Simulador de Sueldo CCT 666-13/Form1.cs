using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Sueldo_CCT_666_13
{
    public partial class Form1 : Form
    {
        // Encargado y/o Encargado de Turno
        decimal encargadoTurno_Inicial = 1382639m;
        decimal encargadoTurno_Anio = 1413125m;

        // Operario de Playa
        decimal operarioPlaya_Inicial = 1336835m;
        decimal operarioPlaya_Anio = 1364021m;

        // Operario de Servicio Lavador
        decimal operarioLavador_Inicial = 1351545m;
        decimal operarioLavador_Anio = 1382639m;

        // Operario de Servicio Engrasador
        decimal operarioEngrasador_Inicial = 1370136m;
        decimal operarioEngrasador_Anio = 1404620m;

        // Sereno
        decimal sereno_Inicial = 1382639m;
        decimal sereno_Anio = 1413125m;

        // Administrativo
        decimal administrativo_Inicial = 1367304m;
        decimal administrativo_Anio = 1399905m;

        // Encargado de Minishop-Bar
        decimal encargadoMinishop_Inicial = 1382639m;
        decimal encargadoMinishop_Anio = 1413125m;

        // Operario de Servicio Minishop-Bar e Interior
        decimal operarioMinishopInterior_Inicial = 1370136m;
        decimal operarioMinishopInterior_Anio = 1404620m;

        // Administrativo Mecánico de Surtidores
        decimal administrativoMecanicoSurtidores_Inicial = 1368612m;
        decimal administrativoMecanicoSurtidores_Anio = 1399919m;

        // Mecánico de Surtidores
        decimal mecanicoSurtidores_Inicial = 1382639m;
        decimal mecanicoSurtidores_Anio = 1413125m;

        // Mecánico Principal de Surtidores
        decimal mecanicoPrincipalSurtidores_Inicial = 1536669m;
        decimal mecanicoPrincipalSurtidores_Anio = 1585174m;

        decimal PorcentajePresentismo = 0.6m;
        decimal PorcentajeJubilacion = 0.11m;
        decimal PorcentajePAMI = 0.3m;
        decimal PorcentajeOSPeCor = 0.3m;
        decimal PorcentajeSinPeCor = 0.33m;

        public Form1()
        {
            InitializeComponent();

            // Control de los txtBox
            txtPorcenAntiguedad.Enabled = false;
            txtPorcenPresentismo.Enabled = false;
            txtPorcenJubi.Enabled = false;
            txtPorcenPAMI.Enabled = false;
            txtPorcenOS.Enabled = false;
            txtPorcenSinPeCor.Enabled = false;
            txtTotalHaberes.Enabled = false;
            txtTotalDeducciones.Enabled = false;
            txtTotalAdicionales.Enabled = false;
            txtAdicionalNoRemunerativo.Enabled = false;
            txtAdicionalesNoRemAcuerdo.Enabled = false;
            



        }

        // Se agregan las diferentes categorias correspondientes al CCT 666/13
        // Se agregan los valores inmutables o que no varian (presentismo, jubilacion, pami, obra social, sindicato)
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("ENCARGADO Y/O ENCARGADO DE TURNO");
            cmbCategoria.Items.Add("OPERARIO DE PLAYA");
            cmbCategoria.Items.Add("OPERARIO DE SERVICIO LAVADOR");
            cmbCategoria.Items.Add("OPERARIO DE SERVICIO ENGRASADOR");
            cmbCategoria.Items.Add("SERENO");
            cmbCategoria.Items.Add("ADMINISTRATIVO");
            cmbCategoria.Items.Add("ENCARGADO DE MINISHOP-BAR");
            cmbCategoria.Items.Add("OPERARIO DE SERVICIO MINISHOP-BAR E INTERIOR");
            cmbCategoria.Items.Add("ADMINISTRATIVO MECÁNICO DE SURTIDORES");
            cmbCategoria.Items.Add("MECÁNICO DE SURTIODORES");
            cmbCategoria.Items.Add("MECÁNICO PRINCIPAL DE SURTIDORES");
            txtPorcenPresentismo.Text = "6.00%";
            txtPorcenJubi.Text = "11.00%";
            txtPorcenPAMI.Text = "3.00%";
            txtPorcenOS.Text = "3.00%";
            txtPorcenSinPeCor.Text = "3.30%";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
