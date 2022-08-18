using Guia4_NSB.Registros;
using Guia4_NSB.Tarea_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4_NSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server= LAPTOP-TN73JHLV\\SQLEXPRESS; Database = master; Integrated Security = yes");
            
            string createdb = "CREATE DATABASE DB_Avanzada";

            string tCliente = "USE DB_Avanzada\n"+
                "CREATE TABLE CLIENTES" +
                "(" +
                "id_Cliente int identity(1,1)," +
                "NombreCliente varchar(40)," +
                "CONSTRAINT pk_cliente primary key(id_Cliente)" +
                ")";

            string tPedido = "USE DB_Avanzada\n" 
                + "CREATE TABLE PEDIDOS" 
                + "(" 
                + "id_Pedido int identity(1,1)," 
                + "id_Cliente int not null," 
                + "CantidaPedido int," 
                + "FechaPedido varchar(70)," 
                + "CONSTRAINT pk_pedido primary key(id_Pedido)," 
                +"CONSTRAINT fk_Cliente foreign key(id_Cliente)" +
                "REFERENCES CLIENTES(id_Cliente)"+
                ")";
            SqlCommand cmd = new SqlCommand(createdb, cnn);
            SqlCommand cmd1 = new SqlCommand(tCliente, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedido, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Base de Datos creada correctamente");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
            this.Hide();
        }

        private void PedidosButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void gTareaButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server= LAPTOP-TN73JHLV\\SQLEXPRESS; Database = master; Integrated Security = yes");


            string tUsuario = "USE DB_Avanzada\n" +
                "CREATE TABLE USUARIOS" +
                "(" +
                "id_Usuario int identity(1,1)," +
                "NombreUsuario varchar(40)," +
                "user varchar(50)," +
                "contrasena varchar(100)," +
                "activo bool," +
                "id_Ciudad int" +
                "CONSTRAINT pk_ciudad primary key(id_Ciudad)" +
                ")";

            string tCiudad = "USE DB_Avanzada\n" +
                "CREATE TABLE CIUDADES" +
                "(" +
                "id_Ciudad int identity(1,1)," +
                "NombreCiudad varchar(100)," +
                ")";

            SqlCommand cmd = new SqlCommand(tCiudad, cnn);
            SqlCommand cmd1 = new SqlCommand(tUsuario, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Tablas CIUDADES y USUARIOS creadas exitosamente", 
                    "Exito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosButton_Click(object sender, EventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
            this.Hide();
        }
    }
}
