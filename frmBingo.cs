using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class frmBingo : Form
    {
        public frmBingo()
        {
            InitializeComponent();
        }

        bingo objBingo = new bingo();

        private void frmBingo_Load(object sender, EventArgs e)
        {
            txtNuevaBola.Text = "";

        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            txtNuevaBola.Text = "";

            txtBola1.ForeColor = Color.DimGray;
            txtBola2.ForeColor = Color.DimGray;
            txtBola3.ForeColor = Color.DimGray;
            txtBola4.ForeColor = Color.DimGray;
            txtBola5.ForeColor = Color.DimGray;
            txtBola6.ForeColor = Color.DimGray;
            txtBola7.ForeColor = Color.DimGray;
            txtBola8.ForeColor = Color.DimGray;
            txtBola9.ForeColor = Color.DimGray;
            txtBola10.ForeColor = Color.DimGray;
            txtBola11.ForeColor = Color.DimGray;
            txtBola12.ForeColor = Color.DimGray;
            txtBola13.ForeColor = Color.DimGray;
            txtBola14.ForeColor = Color.DimGray;
            txtBola15.ForeColor = Color.DimGray;
            txtBola16.ForeColor = Color.DimGray;
            txtBola17.ForeColor = Color.DimGray;
            txtBola18.ForeColor = Color.DimGray;
            txtBola19.ForeColor = Color.DimGray;
            txtBola20.ForeColor = Color.DimGray;
            txtBola21.ForeColor = Color.DimGray;
            txtBola22.ForeColor = Color.DimGray;
            txtBola23.ForeColor = Color.DimGray;
            txtBola24.ForeColor = Color.DimGray;
            txtBola25.ForeColor = Color.DimGray;
            txtBola26.ForeColor = Color.DimGray;
            txtBola27.ForeColor = Color.DimGray;
            txtBola28.ForeColor = Color.DimGray;
            txtBola29.ForeColor = Color.DimGray;
            txtBola30.ForeColor = Color.DimGray;
            txtBola31.ForeColor = Color.DimGray;
            txtBola32.ForeColor = Color.DimGray;
            txtBola33.ForeColor = Color.DimGray;
            txtBola34.ForeColor = Color.DimGray;
            txtBola35.ForeColor = Color.DimGray;
            txtBola36.ForeColor = Color.DimGray;
            txtBola37.ForeColor = Color.DimGray;
            txtBola38.ForeColor = Color.DimGray;
            txtBola39.ForeColor = Color.DimGray;
            txtBola40.ForeColor = Color.DimGray;
            txtBola41.ForeColor = Color.DimGray;
            txtBola42.ForeColor = Color.DimGray;
            txtBola43.ForeColor = Color.DimGray;
            txtBola44.ForeColor = Color.DimGray;
            txtBola45.ForeColor = Color.DimGray;
            txtBola46.ForeColor = Color.DimGray;
            txtBola47.ForeColor = Color.DimGray;
            txtBola48.ForeColor = Color.DimGray;
            txtBola49.ForeColor = Color.DimGray;
            txtBola50.ForeColor = Color.DimGray;
            txtBola51.ForeColor = Color.DimGray;
            txtBola52.ForeColor = Color.DimGray;
            txtBola53.ForeColor = Color.DimGray;
            txtBola54.ForeColor = Color.DimGray;
            txtBola55.ForeColor = Color.DimGray;
            txtBola56.ForeColor = Color.DimGray;
            txtBola57.ForeColor = Color.DimGray;
            txtBola58.ForeColor = Color.DimGray;
            txtBola59.ForeColor = Color.DimGray;
            txtBola60.ForeColor = Color.DimGray;
            txtBola61.ForeColor = Color.DimGray;
            txtBola62.ForeColor = Color.DimGray;
            txtBola63.ForeColor = Color.DimGray;
            txtBola64.ForeColor = Color.DimGray;
            txtBola65.ForeColor = Color.DimGray;
            txtBola66.ForeColor = Color.DimGray;
            txtBola67.ForeColor = Color.DimGray;
            txtBola68.ForeColor = Color.DimGray;
            txtBola69.ForeColor = Color.DimGray;
            txtBola70.ForeColor = Color.DimGray;
            txtBola71.ForeColor = Color.DimGray;
            txtBola72.ForeColor = Color.DimGray;
            txtBola73.ForeColor = Color.DimGray;
            txtBola74.ForeColor = Color.DimGray;
            txtBola75.ForeColor = Color.DimGray;
            txtBola76.ForeColor = Color.DimGray;
            txtBola77.ForeColor = Color.DimGray;
            txtBola78.ForeColor = Color.DimGray;
            txtBola79.ForeColor = Color.DimGray;
            txtBola80.ForeColor = Color.DimGray;
            txtBola81.ForeColor = Color.DimGray;
            txtBola82.ForeColor = Color.DimGray;
            txtBola83.ForeColor = Color.DimGray;
            txtBola84.ForeColor = Color.DimGray;
            txtBola85.ForeColor = Color.DimGray;
            txtBola86.ForeColor = Color.DimGray;
            txtBola87.ForeColor = Color.DimGray;
            txtBola88.ForeColor = Color.DimGray;
            txtBola89.ForeColor = Color.DimGray;
            txtBola90.ForeColor = Color.DimGray;

            picBola.Image = null;

        }

        private void btnNuevaBola_Click(object sender, EventArgs e)
        {
            objBingo.generarNumAleatorio();
        }
    }
}
