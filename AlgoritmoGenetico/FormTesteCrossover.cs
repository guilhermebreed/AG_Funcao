using AlgoritmoGenetico.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico
{
    public partial class FormTesteCrossover : Form
    {
        Populacao pop = new Populacao();
        Class.AlgoritmoGenetico ag = new Class.AlgoritmoGenetico(0.8f, 0.01f);

        public FormTesteCrossover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Individuo pai = new Individuo();
            Individuo mae = new Individuo();

            textPai.Text = pai.printIndividuo();
            textMae.Text = mae.printIndividuo();

            Individuo[] filhos = ag.Crossover(pai, mae);

            textFilho1.Text = filhos[0].printIndividuo();
            textFilho2.Text = filhos[1].printIndividuo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInteirar_Click(object sender, EventArgs e)
        {
            pop = ag.executaAG(pop);
            textPop.Text = pop.printPop();
            lblMedia.Text = pop.getMediaPopulacao().ToString();

        }
    }
}
