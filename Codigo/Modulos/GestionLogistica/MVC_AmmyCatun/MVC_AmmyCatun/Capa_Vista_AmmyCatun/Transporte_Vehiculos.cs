﻿using Capa_Controlador_AmmyCatun;
using Capa_Modelo_AmmyCatun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_AmmyCatun
{
    public partial class Transporte_Vehiculos : Form
    {
        Capa_Controlador_AmmyCatun.ControladorPedido controlador = new ControladorPedido();
        private Conexion conn = new Conexion();

        public Transporte_Vehiculos()
        {
                InitializeComponent();
                CargarComboBoxForma();
                CargarDatosGrid();
                 CargarClientes();
                getId();
            }
            void getId()
            {
                Txt_IdGuia.Text = controlador.getNextId().ToString();
            }



            private void Btn_Ingresar_Click(object sender, EventArgs e)
            {
                string sDireccionPartida = Txt_Partida.Text;
                string sDireccionLlegada = Txt_LLegada.Text;
                string sNumeroOrdenRecojo = Txt_Recojo.Text;
                ComboBox cmbFormaPago = Cbo_Forma;
                string sDestino = Txt_Destino.Text;
                DateTime dFechaEmision = dtp_Fecha_Emision.Value;
                DateTime dFechaTraslado = dtp_Fecha_Emision.Value;
                int iIdvehiculo = Convert.ToInt32(Txt_id_Vehiculo.Text);

                // 🚨 NUEVO: Obtener el ID del cliente desde el ComboBox
                if (Cmb_Clientes.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }

                int iIdcliente = Convert.ToInt32(Cmb_Clientes.SelectedValue);

                // Llamar al controlador con todos los datos
                ControladorPedido controlador = new ControladorPedido();
                controlador.guardarPedido(
                    sDireccionPartida,
                    sDireccionLlegada,
                    sNumeroOrdenRecojo,
                    cmbFormaPago,
                    sDestino,
                    dFechaEmision,
                    dFechaTraslado,
                    iIdvehiculo,
                    iIdcliente  // 👈 AÑADIDO ESTE PARÁMETRO
                );

                CargarDatosGrid();
            }



            private void CargarDatosGrid()
            {
                ControladorPedido controlador = new ControladorPedido();
                DataTable dtPedidos = controlador.CargarPedidos();

                Dgv_Cliente.DataSource = dtPedidos;
            }


            private void CargarComboBoxForma()
            {
                // Agregar opciones de forma de pago
                Cbo_Forma.Items.Add("Efectivo");
                Cbo_Forma.Items.Add("Tarjeta de Crédito");
                Cbo_Forma.Items.Add("Tarjeta de Débito");
                Cbo_Forma.Items.Add("Transferencia Bancaria");
                Cbo_Forma.Items.Add("Cheque");

                // Establecer la selección predeterminada a nulo
                Cbo_Forma.SelectedIndex = -1;

                // Cargar los datos en el DataGridView
                CargarDatosGrid();
            }



            private void Btn_Eliminar_Click(object sender, EventArgs e)
            {
                {
                    string sIdGuia = Txt_Guia.Text;

                    if (string.IsNullOrWhiteSpace(sIdGuia))
                    {
                        MessageBox.Show("Por favor, ingrese un ID de pedido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el pedido con ID " + sIdGuia + "?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        controlador.eliminarPedido(sIdGuia);
                        getId(); // Actualiza el ID después de eliminar
                        CargarDatosGrid(); // Reload data in the DataGridView
                    }
                }
            }

            private void Btn_Actualizar_Click(object sender, EventArgs e)
            {
                CargarDatosGrid(); // Reload data in the DataGridView
            }

            private void Btn_Modificar_Click(object sender, EventArgs e)
            {
                string sDireccionPartida = Txt_Partida.Text;
                string sDireccionLlegada = Txt_LLegada.Text;
                string sNumeroOrdenRecojo = Txt_Recojo.Text;
                ComboBox cmbFormaPago = Cbo_Forma;
                string sDestino = Txt_Destino.Text;
                DateTime dFechaEmision = dtp_Fecha_Emision.Value;
                DateTime dFechaTraslado = dtp_Fecha_Emision.Value;
                int iIdvehiculo = Convert.ToInt32(Txt_id_Vehiculo.Text);
                int iIdGuia = Convert.ToInt32(Txt_Guia.Text);

                ControladorPedido controlador = new ControladorPedido();
                controlador.modificarPedido(sDireccionPartida, sDireccionLlegada, sNumeroOrdenRecojo, cmbFormaPago, sDestino, dFechaEmision, dFechaTraslado, iIdvehiculo, iIdGuia);

                CargarDatosGrid();
            }

        private void CargarClientes()
        {
            try
            {
                OdbcConnection connection = conn.conexion();
                string query = "SELECT Pk_id_cliente, Clientes_nombre FROM Tbl_clientes";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cmb_Clientes.DataSource = dt;
                Cmb_Clientes.DisplayMember = "Clientes_nombre"; // Lo que se ve
                Cmb_Clientes.ValueMember = "Pk_id_cliente";       // Lo que se usa internamente

                Cmb_Clientes.DropDownStyle = ComboBoxStyle.DropDownList;

                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }


        private void Btn_Reporte_Click(object sender, EventArgs e)
            {
                //Abrir Formulario

                /*nombre del formulario*/
                Reporte_Pedidos reporte = new Reporte_Pedidos();
                reporte.Show();
            }

        

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string idayuda = "2";
            string Ruta = controlador.sMRuta(idayuda);
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
            string AsRuta = Path.Combine(sRutaProyecto, "Ayuda", "AyudaPedidos", Ruta);
            string AsIndice = controlador.sMIndice(idayuda);

            // Validar que la ruta y el índice no estén vacíos
            if (!string.IsNullOrEmpty(AsRuta) && !string.IsNullOrEmpty(AsIndice))
            {
                // Mostrar la ayuda automáticamente cuando se llama a asignarAyuda
                Help.ShowHelp(this, AsRuta, AsIndice);
            }
            else
            {
                MessageBox.Show("La Ruta o el índice de la ayuda están vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }


        
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            CargarDatosGrid(); // Reload data in the DataGridView
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Dgv_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

  






