using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registro.DAL;
using Registro.Entidades;

namespace Registro.UI.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuario = new List<Usuarios>();
            var us = new UsuarioDb();
            usuario = us.user.ToList();
            CuadrodataGridView1.DataSource = usuario;
        }
    }
}
