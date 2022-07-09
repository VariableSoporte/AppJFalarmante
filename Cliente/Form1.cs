using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        int lx, ly;
        int sw, sh;

        private const int tamañoGrid = 10;
        private const int areaMouse = 132;
        private const int botonIzquierdo = 17;
        private Rectangle rectanguloGrid;

        protected override void OnSizeChanged (EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            rectanguloGrid = new Rectangle(ClientRectangle.Width - tamañoGrid, ClientRectangle.Height - tamañoGrid, tamañoGrid, tamañoGrid);
            region.Exclude(rectanguloGrid);
            panel1.Region = region;
            Invalidate();   
        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areaMouse:
                    base.WndProc(ref sms);
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    if ( !rectanguloGrid.Contains(RefPoint))
                    {
                        break;
                    }
                    sms.Result = new IntPtr(botonIzquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }


        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnMaxMin.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaxMin.Visible = true;
            btnMaximizar.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();

        }

    }
}
