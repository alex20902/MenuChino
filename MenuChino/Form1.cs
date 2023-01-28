using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MenuChino
{

    public partial class Form1 : Form
    {
        string[] baseDescripcion;
        string[] toppingDescripcion;
        
       
        int baseTotal = 0;
        bool b_se = false;
        int toppingTotal = 0;
        bool topping = false;
        int totalProteina = 0;
        bool proteina = false;
        int totalCrujiente = 0;
        int totalAderezo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (arandano.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (agridulce.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void arroz_CheckedChanged(object sender, EventArgs e)
        {
            if(arroz.CheckState == CheckState.Checked)
            {
                baseTotal ++ ;
               

            }
            else
            {
                baseTotal--;
            }

        }

        private void tallarinesBase_CheckedChanged(object sender, EventArgs e)
        {
            if (tallarines.CheckState == CheckState.Checked)
            {
                baseTotal++;
                


            }
            else
            {
                baseTotal--;
            }
            
           

            
        }

        private void fideosPepino_CheckedChanged(object sender, EventArgs e)
        {
            if(fideosPepino.CheckState == CheckState.Checked)
            {
                baseTotal ++ ;

            }
            else
            {
                baseTotal--;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (lechuga.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }

        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            if (baseTotal == 1)
            {
                avisoBase.Text = "OK";
                b_se = true;
                
            }
            else if (baseTotal == 0)
            {
                avisoBase.Text = " Tienes que elegir una base";

            }
            else
            {
                avisoBase.Text = "Solo puede elegir una base";
            }
            if (toppingTotal >= 1 && toppingTotal <= 3)
            {
                avisoTopping.Text = "Ok";
                topping = true;
            }
            else if (toppingTotal == 0)
            {
                avisoTopping.Text = " Tienes que elegir al menos un topping";

            }
            else
            {
                avisoTopping.Text = "solo puedes elegir 3 toppings";

            }
            if (b_se == true && topping == false)

            if (baseTotal == 1)
            {
                    avisoProteina.Text = " OK";
                    b_se = true;

            }
            else if (baseTotal == 1)
            {
                    avisoBase.Text = " Tienes que elegir una base";

            }
            else
            {
                    avisoBase.Text = "Solo puede elegir una base";
            }

            if (baseTotal == 1)
            {
                avisoCrujiente.Text = " OK";
                b_se = true;

            }

            if (baseTotal == 1)
            {
                avisoAderezo.Text = " OK";
                b_se = true;

            }
            
            if (baseTotal == 1)

            {
                avisoBebidas.Text = " OK";
                b_se = true;

            }



            {
                MessageBox.Show("Tu orden sera generada");
                //tu orden sera generada
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mango_CheckedChanged(object sender, EventArgs e)
        {
            if (mango.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void durazno_CheckedChanged(object sender, EventArgs e)
        {
            if (durazno.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void tomate_CheckedChanged(object sender, EventArgs e)
        {
            if (tomate.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void avisoTopping_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void edamame_CheckedChanged(object sender, EventArgs e)
        {
            if (edamame.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void champinon_CheckedChanged(object sender, EventArgs e)
        {
            if (champinon.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void pollo_CheckedChanged(object sender, EventArgs e)
        {
            if (pollo.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void cerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (cerdo.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void polloPrimavera_CheckedChanged(object sender, EventArgs e)
        {
            if (polloPrimavera.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void sushi_CheckedChanged(object sender, EventArgs e)
        {
            if (sushi.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void amaranto_CheckedChanged(object sender, EventArgs e)
        {
            if (amaranto.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void cacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (cacahuate.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void semilladeGirasol_CheckedChanged(object sender, EventArgs e)
        {
            if (semilladeGirasol.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void aderezohke_CheckedChanged(object sender, EventArgs e)
        {
            if (aderezohke.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void soya_CheckedChanged(object sender, EventArgs e)
        {
            if (soya.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void bbq_CheckedChanged(object sender, EventArgs e)
        {
            if (bbq.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void refrescos_CheckedChanged(object sender, EventArgs e)
        {
            if (refrescos.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void naranja_CheckedChanged(object sender, EventArgs e)
        {
            if (naranja.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void limon_CheckedChanged(object sender, EventArgs e)
        {
            if (limon.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        private void jamaica_CheckedChanged(object sender, EventArgs e)
        {
            if (jamaica.CheckState == CheckState.Checked)
            {
                baseTotal++;

            }
            else
            {
                baseTotal--;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            // cierra el formulario
            this.Close();
        }
    }
}
