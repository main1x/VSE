using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSE
{
    public partial class Form3 : Form
    {
        int opened_counter;
        int[] pairs;
        int[] opened;
        int[] game_pairs;
        public Form3(Form1 f)
        {
            opened_counter = 0;
            InitializeComponent();
            pairs = new int[12];
            opened = new int[2];
            game_pairs = new int[25];

        }

        public void hide()
        {
            pictureBox1.BackgroundImage = imageList1.Images[13];
            pictureBox25.BackgroundImage = imageList1.Images[13];
            pictureBox3.BackgroundImage = imageList1.Images[13];
            pictureBox4.BackgroundImage = imageList1.Images[13];
            pictureBox5.BackgroundImage = imageList1.Images[13];
            pictureBox6.BackgroundImage = imageList1.Images[13];
            pictureBox7.BackgroundImage = imageList1.Images[13];
            pictureBox8.BackgroundImage = imageList1.Images[13];
            pictureBox9.BackgroundImage = imageList1.Images[13];
            pictureBox10.BackgroundImage = imageList1.Images[13];
            pictureBox11.BackgroundImage = imageList1.Images[13];
            pictureBox12.BackgroundImage = imageList1.Images[13];
            pictureBox13.BackgroundImage = imageList1.Images[13];
            pictureBox14.BackgroundImage = imageList1.Images[13];
            pictureBox15.BackgroundImage = imageList1.Images[13];
            pictureBox16.BackgroundImage = imageList1.Images[13];
            pictureBox17.BackgroundImage = imageList1.Images[13];
            pictureBox18.BackgroundImage = imageList1.Images[13];
            pictureBox19.BackgroundImage = imageList1.Images[13];
            pictureBox20.BackgroundImage = imageList1.Images[13];
            pictureBox21.BackgroundImage = imageList1.Images[13];
            pictureBox22.BackgroundImage = imageList1.Images[13];
            pictureBox23.BackgroundImage = imageList1.Images[13];
            pictureBox24.BackgroundImage = imageList1.Images[13];
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            hide();
            //-----------------------------------------------------------------------
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = panel1.Width / 4;
            pictureBox1.Height = panel1.Height / 4;

            pictureBox25.Top = 0;
            pictureBox25.Left = 0;
            pictureBox25.Width = panel1.Width / 4;
            pictureBox25.Height = panel1.Height / 4;

            pictureBox3.Top = 0;
            pictureBox3.Left = panel1.Width / 2;
            pictureBox3.Width = panel1.Width / 4;
            pictureBox3.Height = panel1.Height / 4;

            pictureBox4.Top = 0;
            pictureBox4.Left = panel1.Width * 3 / 4;
            pictureBox4.Width = panel1.Width / 4;
            pictureBox4.Height = panel1.Height / 4;

            pictureBox5.Top = 0;
            pictureBox5.Left = panel1.Width * 4 / 4;
            pictureBox5.Width = panel1.Width / 4;
            pictureBox5.Height = panel1.Height / 4;

            pictureBox6.Top = 0;
            pictureBox6.Left = panel1.Width * 5 / 4;
            pictureBox6.Width = panel1.Width / 4;
            pictureBox6.Height = panel1.Height / 4;

            //-----------------------------------------------------------------------
            pictureBox7.Top = panel1.Width / 4;
            pictureBox7.Left = 0;
            pictureBox7.Width = panel1.Width / 4;
            pictureBox7.Height = panel1.Height / 4;

            pictureBox8.Top = panel1.Width / 4;
            pictureBox8.Left = panel1.Width / 4;
            pictureBox8.Width = panel1.Width / 4;
            pictureBox8.Height = panel1.Height / 4;

            pictureBox9.Top = panel1.Width / 4;
            pictureBox9.Left = panel1.Width / 2;
            pictureBox9.Width = panel1.Width / 4;
            pictureBox9.Height = panel1.Height / 4;

            pictureBox10.Top = panel1.Width / 4;
            pictureBox10.Left = panel1.Width * 3 / 4;
            pictureBox10.Width = panel1.Width / 4;
            pictureBox10.Height = panel1.Height / 4;

            pictureBox11.Top = panel1.Width / 4;
            pictureBox11.Left = panel1.Width * 4 / 4;
            pictureBox11.Width = panel1.Width / 4;
            pictureBox11.Height = panel1.Height / 4;

            pictureBox12.Top = panel1.Width / 4;
            pictureBox12.Left = panel1.Width * 5 / 4;
            pictureBox12.Width = panel1.Width / 4;
            pictureBox12.Height = panel1.Height / 4;



            //-----------------------------------------------------------------------
            pictureBox13.Top = panel1.Width / 2;
            pictureBox13.Left = 0;
            pictureBox13.Width = panel1.Width / 4;
            pictureBox13.Height = panel1.Height / 4;

            pictureBox14.Top = panel1.Width / 2;
            pictureBox14.Left = panel1.Width / 4;
            pictureBox14.Width = panel1.Width / 4;
            pictureBox14.Height = panel1.Height / 4;

            pictureBox15.Top = panel1.Width / 2;
            pictureBox15.Left = panel1.Width / 2;
            pictureBox15.Width = panel1.Width / 4;
            pictureBox15.Height = panel1.Height / 4;

            pictureBox16.Top = panel1.Width / 2;
            pictureBox16.Left = panel1.Width * 3 / 4;
            pictureBox16.Width = panel1.Width / 4;
            pictureBox16.Height = panel1.Height / 4;

            pictureBox17.Top = panel1.Width / 2;
            pictureBox17.Left = panel1.Width * 4 / 4;
            pictureBox17.Width = panel1.Width / 4;
            pictureBox17.Height = panel1.Height / 4;

            pictureBox18.Top = panel1.Width / 2;
            pictureBox18.Left = panel1.Width * 5 / 4;
            pictureBox18.Width = panel1.Width / 4;
            pictureBox18.Height = panel1.Height / 4;


            //-----------------------------------------------------------------------
            pictureBox19.Top = panel1.Width * 3 / 4;
            pictureBox19.Left = 0;
            pictureBox19.Width = panel1.Width / 4;
            pictureBox19.Height = panel1.Height / 4;

            pictureBox20.Top = panel1.Width * 3 / 4;
            pictureBox20.Left = panel1.Width / 4;
            pictureBox20.Width = panel1.Width / 4;
            pictureBox20.Height = panel1.Height / 4;

            pictureBox20.Top = panel1.Width * 3 / 4;
            pictureBox20.Left = panel1.Width / 2;
            pictureBox20.Width = panel1.Width / 4;
            pictureBox20.Height = panel1.Height / 4;

            pictureBox21.Top = panel1.Width * 3 / 4;
            pictureBox21.Left = panel1.Width * 3 / 4;
            pictureBox21.Width = panel1.Width / 4;
            pictureBox21.Height = panel1.Height / 4;

            pictureBox22.Top = panel1.Width * 3 / 4;
            pictureBox22.Left = panel1.Width * 4 / 4;
            pictureBox22.Width = panel1.Width / 4;
            pictureBox22.Height = panel1.Height / 4;

            pictureBox23.Top = panel1.Width * 3 / 4;
            pictureBox23.Left = panel1.Width * 5 / 4;
            pictureBox23.Width = panel1.Width / 4;
            pictureBox23.Height = panel1.Height / 4;


            pictureBox24.Top = panel1.Width * 3 / 4;
            pictureBox24.Left = panel1.Width * 5 / 4;
            pictureBox24.Width = panel1.Width / 4;
            pictureBox24.Height = panel1.Height / 4;

            новаяToolStripMenuItem_Click(null, e);

        }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random R;
            R = new Random();
            for (int i = 0; i < 12; i++)
            {
                pairs[i] = R.Next(12);
            }
            for (int i = 0; i < 25; i++)
            {
                game_pairs[i] = -1;
            }
            int used = 0;
            while (used != 12)
            {
                int n1 = R.Next(25);
                int n2 = R.Next(25);
                if (n2 == n1 && n1 == n2) continue;
                if (game_pairs[n1] == -1 && game_pairs[n2] == -1)
                {
                    game_pairs[n1] = game_pairs[n2] = pairs[used];
                    used++;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void pictureBox25_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);
            if (opened_counter == 2)
            {
                hide();
                opened_counter = 0;
            }
            opened[opened_counter] = index;
            opened_counter++;
            p.BackgroundImage = imageList1.Images[game_pairs[index]];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Привет! Чтобы поиграть в это дерьмо, надо сделать его на весь экран и скролить вверх/вниз, вправо/влево, потому что я идиот напутал что то с размерами текстбоксов в рамках панели :). А в целом эта игра где ты угадываешь две одинаковые картинки! .", "Сорямбус", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Привет! Я обманул)))))).", "против наркотиков", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }


        /*
pictureBox1.Image = imageList1.Images[game_pairs[0]];
pictureBox25.Image = imageList1.Images[game_pairs[1]];
pictureBox3.Image = imageList1.Images[game_pairs[2]];
pictureBox4.Image = imageList1.Images[game_pairs[3]];
pictureBox5.Image = imageList1.Images[game_pairs[4]];
pictureBox6.Image = imageList1.Images[game_pairs[5]];
pictureBox7.Image = imageList1.Images[game_pairs[6]];
pictureBox8.Image = imageList1.Images[game_pairs[7]];
pictureBox9.Image = imageList1.Images[game_pairs[8]];
pictureBox10.Image = imageList1.Images[game_pairs[9]];
pictureBox11.Image = imageList1.Images[game_pairs[10]];
pictureBox12.Image = imageList1.Images[game_pairs[11]];
pictureBox13.Image = imageList1.Images[game_pairs[12]];
pictureBox14.Image = imageList1.Images[game_pairs[13]];
pictureBox15.Image = imageList1.Images[game_pairs[14]];
pictureBox16.Image = imageList1.Images[game_pairs[15]];
pictureBox17.Image = imageList1.Images[game_pairs[16]];
pictureBox18.Image = imageList1.Images[game_pairs[17]];
pictureBox19.Image = imageList1.Images[game_pairs[18]];
pictureBox20.Image = imageList1.Images[game_pairs[19]];
pictureBox21.Image = imageList1.Images[game_pairs[20]];
pictureBox22.Image = imageList1.Images[game_pairs[21]];
pictureBox23.Image = imageList1.Images[game_pairs[22]];
pictureBox24.Image = imageList1.Images[game_pairs[23]];
*/

        /*
pictureBox1.Image = imageList1.Images[game_pairs[0]];
pictureBox25.Image = imageList1.Images[game_pairs[1]];
pictureBox3.Image = imageList1.Images[game_pairs[2]];
pictureBox4.Image = imageList1.Images[game_pairs[3]];
pictureBox5.Image = imageList1.Images[game_pairs[4]];
pictureBox6.Image = imageList1.Images[game_pairs[5]];
pictureBox7.Image = imageList1.Images[game_pairs[6]];
pictureBox8.Image = imageList1.Images[game_pairs[7]];
pictureBox9.Image = imageList1.Images[game_pairs[8]];
pictureBox10.Image = imageList1.Images[game_pairs[9]];
pictureBox11.Image = imageList1.Images[game_pairs[10]];
pictureBox12.Image = imageList1.Images[game_pairs[11]];
pictureBox13.Image = imageList1.Images[game_pairs[12]];
pictureBox14.Image = imageList1.Images[game_pairs[13]];
pictureBox15.Image = imageList1.Images[game_pairs[14]];
pictureBox16.Image = imageList1.Images[game_pairs[15]];
pictureBox17.Image = imageList1.Images[game_pairs[16]];
pictureBox18.Image = imageList1.Images[game_pairs[17]];
pictureBox19.Image = imageList1.Images[game_pairs[18]];
pictureBox20.Image = imageList1.Images[game_pairs[19]];
pictureBox21.Image = imageList1.Images[game_pairs[20]];
pictureBox22.Image = imageList1.Images[game_pairs[21]];
pictureBox23.Image = imageList1.Images[game_pairs[22]];
pictureBox24.Image = imageList1.Images[game_pairs[23]];
*/
    }
}

