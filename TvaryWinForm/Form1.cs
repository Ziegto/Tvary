using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnihovnaTvar;

namespace TvaryWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NovyObjektClick(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(TB_x.Text);
                int y = int.Parse(TB_y.Text);
                int vyska = int.Parse(TB_vyska.Text);
                int sirka = int.Parse(TB_sirka.Text);
                Color barva = BackColor;
                if (BTN_dialog_barva.BackColor == BackColor)
                {
                    barva = Color.Black;
                }
                else
                {
                    barva = BTN_dialog_barva.BackColor;
                }
                

                Tvar novyTvar = null;

                Button zmacknutyButton = sender as Button;

                switch (zmacknutyButton.Name)
                {
                    case "BTN_novy_kruh":
                        novyTvar = new Kruh(sirka, x, y, barva);
                        break;

                    case "BTN_novy_obdelnik":
                        novyTvar = new Obdelnik(sirka, vyska, x, y, barva);
                        break;

                    case "BTN_novy_ctverec":
                        novyTvar = new Ctverec(sirka, x, y, barva);
                        break;
                }

                LB_seznam_tvaru.Items.Add(novyTvar);

                platno.Refresh();
            }
            catch
            {
                MessageBox.Show("Chyba na vstupu, objekt nemohl být vytvořen");
            }
        }

        private void BTN_dialog_barva_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                BTN_dialog_barva.BackColor = colorDialog1.Color;
        }

        private void platno_Paint(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;

            if (LB_seznam_tvaru.Items.Count > 0)
            {
                foreach (Tvar tvar in LB_seznam_tvaru.Items)
                {
                    tvar.Nakreslit(platno);
                }
            }
        }

        private void Posunout_Click(object sender, EventArgs e)
        {
            Button zmacknutyButton = sender as Button;
            Tvar tvar = LB_seznam_tvaru.SelectedItem as Tvar;
            try {
                switch (zmacknutyButton.Name)
                {
                    case "BTN_doprava":
                        tvar.PosunDoprava();
                        platno.Refresh();
                        break;

                    case "BTN_doleva":
                        tvar.PosunDoleva();
                        platno.Refresh();
                        break;

                    case "BTN_nahoru":
                        tvar.PosunNahoru();
                        platno.Refresh();
                        break;
                    case "BTN_dolu":
                        tvar.PosunDolu();
                        platno.Refresh();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Není vybrán žádný objekt");
            }
        }

        private void Velikost_Click(object sender, EventArgs e)
        {
            Button zmacknutyButton = sender as Button;
            Tvar tvar = LB_seznam_tvaru.SelectedItem as Tvar;
            try {
                switch (zmacknutyButton.Name)
                {
                    case "BTN_zvetsit":
                        tvar.Zvetsi();
                        platno.Refresh();
                        break;

                    case "BTN_zmensit":
                        tvar.Zmensi();
                        platno.Refresh();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Není vybrán žádný objekt");
            }
        }
        private void CHB_zpusob_ovladani_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_zpusob_ovladani.Checked)
            {
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
            }
        }

        private void Klavesnice(object sender, KeyEventArgs e)
        {
            Tvar tvar = LB_seznam_tvaru.SelectedItem as Tvar;

            if (CHB_zpusob_ovladani.Checked)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        tvar.PosunDolu();
                        platno.Refresh();
                        break;

                    case Keys.W:
                        tvar.PosunNahoru();
                        platno.Refresh();
                        break;

                    case Keys.D:
                        tvar.PosunDoprava();
                        platno.Refresh();
                        break;

                    case Keys.A:
                        tvar.PosunDoleva();
                        platno.Refresh();
                        break;

                    case Keys.Subtract:
                        tvar.Zmensi();
                        platno.Refresh();
                        break;

                    case Keys.Add:
                        tvar.Zvetsi();
                        platno.Refresh();
                        break;
                }
            }
        }

        private void Vypocitat(object sender, EventArgs e)
        {
            Button zmacknutyButton = sender as Button;
            Tvar tvar = LB_seznam_tvaru.SelectedItem as Tvar;
            try {
                switch (zmacknutyButton.Name)
                {
                    case "BTN_vypocitat_obvod":
                        TB_obvod.Text = tvar.VypocitatObvod().ToString();
                        break;

                    case "BTN_vypocitat_obsah":
                        TB_obsah.Text = tvar.VypocitatObsah().ToString();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Není vybrán žádný objekt");
            }

        }
    }
}