using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp
{
    public partial class Form1 : Form
    {
        const int dias=5;
        const int sucursales = 2;
        private int fc,cr;
        private double acuTotal;
        Producto[,] aProductos = new Producto[sucursales,dias];
        public Form1()
        {

            fc = 0;
            cr = 0;
            InitializeComponent();
            btnMostrar.Enabled = false;
            for(int f = 0; f<sucursales; f++)
            {
                for(int c=0; c<dias; c++)
                {
                    aProductos[f, c] = null;
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            Producto p = new Producto();
            p.pNombre = txtNombre.Text;
            p.pPrecio = double.Parse(txtPrecio.Text);
            p.pCantidad = int.Parse(txtCantidad.Text);
            aProductos[fc,cr] = p;
            
            //lstNombre.Items.Add(aProductos[fc,cr].pNombre);
            //lstPrecio.Items.Add((aProductos[fc,cr].pPrecio).ToString());
            //lstCantidad.Items.Add((aProductos[fc,cr].pCantidad).ToString());
            cr++;
            if (cr == dias) {

                fc++;
                cr = 0;
                MessageBox.Show("Se completo la sucursal" + cr);

                if (fc == sucursales ) {
                    
                    MessageBox.Show("No se puede cargar mas");
                    btnCargar.Enabled = false;
                    btnMostrar.Enabled = true;
                }
            }


            

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < sucursales; f++)
            {
                for (int c = 0; c < dias; c++)
                {



                        lstImporte.Items.Add(aProductos[f,c].calcularImporte().ToString());
                        acuTotal = acuTotal + aProductos[f,c].calcularImporte(); 



                }
            }
                        txtTotal.Text = acuTotal.ToString();
                        lblPromGeneral.Text += (acuTotal / (sucursales * dias)).ToString();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for(int f=0; f<sucursales; f++)
            {
                for (int c = 0; c < dias; c++)
                {
                    
                    lstNombre.Items.Add(aProductos[f, c].pNombre);
                    lstPrecio.Items.Add((aProductos[f, c].pPrecio).ToString());
                    lstCantidad.Items.Add((aProductos[f,c].pCantidad).ToString());
                    

                }
            }
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            double Total= 0;
            for (int f=0; f<sucursales; f++)
            {
                double acuTotalSuc = 0; ;
                for(int c = 0; c<dias; c++)
                {
                   
                    
                    acuTotalSuc = acuTotalSuc + aProductos[f, c].calcularImporte();
                   
                    
                        
                }

                lstSucursal.Items.Add(acuTotalSuc.ToString());
                Total = Total + acuTotalSuc;
                txtPromSucu.Text = (Total / sucursales).ToString();
            }




        }

        private void btnDIa_Click(object sender, EventArgs e)
        {
            double totDia, Total;
            Total = 0;
            for(int c =0; c < dias; c++)
            {
                totDia = 0;
                for(int f =0; f<sucursales; f++)
                {
                    totDia = totDia + aProductos[f, c].calcularImporte();
                }
                Total = Total + totDia;
                lstDia.Items.Add(totDia.ToString());

            }
            txtPromDia.Text = (Total / dias).ToString();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
