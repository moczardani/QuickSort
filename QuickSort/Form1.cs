using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        private List<int> lista = new List<int>();
        private List<Tuple<int, int>> cserék = new List<Tuple<int, int>>();
        int csindex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            // sorbarendezendő lista
            lista.Clear();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(r.Next(1, 100));
            }
 
            // lista-nak megfelelő rajzelemek
            Golyo.lista.Clear();
            for (int i = 0; i < lista.Count(); i++)
            {
                Golyo.lista.Add(new Golyo(lista[i], (i + 1) * palya.Width / 12, palya.Height / 2, palya));
            }
            Golyo.Rajzold_le_mind_ide(palya);

        }

        private void StartBn_Click(object sender, EventArgs e)
        {
            NewBn.Enabled = false;
            StartBn.Enabled = false;

            cserék.Clear();
            csindex = 0;
            quicksort(lista, 0, lista.Count() - 1, cserék);

            Metronom.Start();
        }

        private void Metronom_Tick(object sender, EventArgs e)
        {
            bool moving = Golyo.Rajzold_le_mind_ide(palya);
            if (!moving)
            {
                if (csindex < cserék.Count())
                {
                    Tuple<int, int> csere = cserék[csindex];
                    // cseréljük le targetpost
                    Point p = Golyo.lista[csere.Item1].targetpos;
                    Golyo.lista[csere.Item1].targetpos = Golyo.lista[csere.Item2].targetpos;
                    Golyo.lista[csere.Item2].targetpos = p;
                    // cseréljük meg a golyókat
                    Golyo g = Golyo.lista[csere.Item1];
                    Golyo.lista[csere.Item1] = Golyo.lista[csere.Item2];
                    Golyo.lista[csere.Item2] = g;

                    csindex++;
                }
                else 
                {   // Kész
                    Metronom.Stop();
                    NewBn.Enabled = true;
                    StartBn.Enabled = true;
                }
            }
        }

        // https://www.tutorialspoint.com/explain-the-quick-sort-technique-in-c-language
        private void quicksort(List<int> number, int first, int last, List<Tuple<int, int>> cserék)
        {
            int i, j, pivot, temp;
            if (first < last)
            {
                pivot = first;
                i = first;
                j = last;
                while (i < j)
                {
                    while (number[i] <= number[pivot] && i < last)
                        i++;
                    while (number[j] > number[pivot])
                        j--;
                    if (i < j)
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                        cserék.Add(new Tuple<int,int>(i, j));
                    }
                }
                temp = number[pivot];
                number[pivot] = number[j];
                number[j] = temp;
                cserék.Add(new Tuple<int, int>(pivot, j));
                quicksort(number, first, j - 1, cserék);
                quicksort(number, j + 1, last, cserék);
            }
        }
    }
}
