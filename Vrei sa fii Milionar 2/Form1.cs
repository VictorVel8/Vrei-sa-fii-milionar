using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vrei_sa_fii_Milionar_2
{
   

    public partial class Form1 : Form
    {
        public clasa_joc joc = new clasa_joc();
        public int indice_intrebare;
        public int nr_bune, nr_gresite;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            raspuns1.Visible = false;
            raspuns2.Visible = false;
            raspuns3.Visible = false;
            raspuns4.Visible = false;
            intrebare.Text = "Bine ai venit la VREI SA FII MILIONAR";
            joc.creare_joc();

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            
            startbtn.Visible = false;
            raspuns1.Visible = true;
            raspuns2.Visible = true;
            raspuns3.Visible = true;
            raspuns4.Visible = true;
            nr_bune = 0;
            nr_gresite = 0;
            indice_intrebare = 0;
            punere_intrebare(0);
           
        }

        private void sfarsit_joc()
        {
            raspuns1.Visible = false;
            raspuns2.Visible = false;
            raspuns3.Visible = false;
            raspuns4.Visible = false;

            if (nr_gresite > nr_bune)
            {
                intrebare.Text = "Din pacate ai gresit destul de mult.... Mai invata";
            }
            else
                intrebare.Text = "Felicitari... Te descurci de minune";

        }

        private void punere_intrebare(int ind)
        {
            if (ind == 9)
                sfarsit_joc();
            else
            {
                joc.incepere_joc(ind);
                bune.Text = nr_bune.ToString();
                gresite.Text = nr_gresite.ToString();
            }
        }

        private void raspuns2_Click(object sender, EventArgs e)
        {
            if (joc.intrebari[indice_intrebare].raspuns_bun == 2)
                nr_bune = nr_bune + 1;
            else
                nr_gresite = nr_gresite + 1;

            indice_intrebare = indice_intrebare + 1;
            punere_intrebare(indice_intrebare);
        }

        private void raspuns3_Click(object sender, EventArgs e)
        {
            if (joc.intrebari[indice_intrebare].raspuns_bun == 3)
                nr_bune = nr_bune + 1;
            else
                nr_gresite = nr_gresite + 1;

            indice_intrebare = indice_intrebare + 1;
            punere_intrebare(indice_intrebare);
        }

        private void raspuns4_Click(object sender, EventArgs e)
        {
            if (joc.intrebari[indice_intrebare].raspuns_bun == 4)
                nr_bune = nr_bune + 1;
            else
                nr_gresite = nr_gresite + 1;

            indice_intrebare = indice_intrebare + 1;
            punere_intrebare(indice_intrebare);
        }

        private void raspuns1_Click(object sender, EventArgs e)
        {
            if (joc.intrebari[indice_intrebare].raspuns_bun == 1)
                nr_bune = nr_bune + 1;
            else
                nr_gresite = nr_gresite + 1;

            indice_intrebare=indice_intrebare+1;
            punere_intrebare(indice_intrebare);


        }
    }

    public class clasa_intrebare
    {

        public clasa_intrebare(string intreb, string r1, string r2, string r3, string r4, int rb)
        {
            intrebare = intreb;
            raspuns1 = r1;
            raspuns2 = r2;
            raspuns3 = r3;
            raspuns4 = r4;
            raspuns_bun = rb;
        }

        public string intrebare;
        public string raspuns1, raspuns2, raspuns3, raspuns4;
        public int raspuns_bun;
    }

    public class clasa_joc
    {
        public  clasa_intrebare[] intrebari= new clasa_intrebare[10];


        public void incepere_joc(int i)
        {
                Form1.ActiveForm.Controls["intrebare"].Text = intrebari[i].intrebare;
                Form1.ActiveForm.Controls["raspuns1"].Text = intrebari[i].raspuns1;
                Form1.ActiveForm.Controls["raspuns2"].Text = intrebari[i].raspuns2;
                Form1.ActiveForm.Controls["raspuns3"].Text = intrebari[i].raspuns3;
                Form1.ActiveForm.Controls["raspuns4"].Text = intrebari[i].raspuns4;
      
        }
        
        private void amestecare_intrebari()
        {
            Random rnd = new Random();
            int ind;
            clasa_intrebare aux;

            for (int i=0; i<9; ++i)
            {
                ind = rnd.Next(0, 9);
                aux = intrebari[ind];
                intrebari[ind] = intrebari[i];
                intrebari[i] = aux;
            }
        }

        public void creare_joc()
        {
            intrebari[0] = new clasa_intrebare("Din ce fruct se face cidrul?", "Mar", "Capsune", "Strugure", "Para", 1);
            intrebari[1] = new clasa_intrebare("Ce studiaza etimologia?", "Originea omului", "Originea universului", "Originea religilor", "Originea cuvintelor", 4);
            intrebari[2] = new clasa_intrebare("Care este valoarea lui PI", "3.1412", "3.1415", "3.1425", "3,1465", 2);
            intrebari[3] = new clasa_intrebare("Care este vecinul Romaniei din Nord-Est", "Republica Moldova", "Ukraina", "Bulgaria", "Ungaria", 1);
            intrebari[4] = new clasa_intrebare("Care este capitala Indiei", "Mumbai", "Bollywood", "New Delhi", "Faridabad", 3);
            intrebari[5] = new clasa_intrebare("In ce an a avut loc Marea Unire", "1919", "1917", "1920", "1918", 4);
            intrebari[6] = new clasa_intrebare("Cate calorii are un McPuisor", "240", "320", "180", "400", 1);
            intrebari[7] = new clasa_intrebare("Care este cel mai popular limbaj de programare", "C++", "C#", "Python", "Java", 4);
            intrebari[8] = new clasa_intrebare("Ce inaltime are Lebron James", "2.00m", "1.98m", "2.06m", "2.15m", 3);

            amestecare_intrebari();



        }
    }
}
