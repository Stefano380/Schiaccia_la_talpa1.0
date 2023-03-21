using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schiaccia_la_talpa1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int diff = 0;
        int punti = 0;
        int combo = 0;

        Label labelCombo = new Label();

        Random random = new Random();

        int tempoGioco = 0;

        const int maxOgg = 5;

        PictureBox[] pictureBoxes1 = new PictureBox[maxOgg];
        PictureBox[] pictureBoxes2 = new PictureBox[maxOgg];

        Label score = new Label();
        Label scoreCombo = new Label();

        PictureBox[] vita = new PictureBox[3];
        int numVite = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < maxOgg; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(0, 0);
                pictureBox1.Name = "pictureBox1";
                if (i < 4)
                {
                    pictureBox1.Size = new System.Drawing.Size(210, 150);
                }
                else
                {
                    pictureBox1.Size = new System.Drawing.Size(330, 200);
                }
                pictureBox1.TabIndex = 2;
                pictureBox1.TabStop = false;
                pictureBox1.BackColor = Color.Transparent;
                if (i < 3)
                {
                    pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
                }
                else if (i == 3)
                {
                    pictureBox1.Click += new System.EventHandler(this.pictureBox12_Click);
                }
                pictureBoxes1[i] = pictureBox1;
            }
            pictureBoxes1[0].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.buco_talpa;
            pictureBoxes1[1].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa1_finale;
            pictureBoxes1[2].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa2_finale1;
            pictureBoxes1[3].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa_bomba_finale3;
            pictureBoxes1[4].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa_colpita;

            for (int i = 0; i < maxOgg; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(0, 0);
                pictureBox1.Name = "pictureBox1";
                if (i < 4)
                {
                    pictureBox1.Size = new System.Drawing.Size(210, 150);
                }
                else
                {
                    pictureBox1.Size = new System.Drawing.Size(330, 200);
                }
                pictureBox1.TabIndex = 2;
                pictureBox1.TabStop = false;
                pictureBox1.BackColor = Color.Transparent;
                if (i < 3)
                {
                    pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
                }
                else if (i == 3)
                {
                    pictureBox1.Click += new System.EventHandler(this.pictureBox22_Click);
                }
                pictureBoxes2[i] = pictureBox1;
            }
            pictureBoxes2[0].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.buco_talpa;
            pictureBoxes2[1].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa1_finale;
            pictureBoxes2[2].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa2_finale1;
            pictureBoxes2[3].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa_bomba_finale3;
            pictureBoxes2[4].BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.talpa_colpita;

            for (int i = 0; i < maxOgg; i++)
            {
                pictureBoxes1[i].BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxes2[i].BackgroundImageLayout = ImageLayout.Stretch;
            }

            this.Size = new System.Drawing.Size(1500, 800);
            this.BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.sfondo_talpe;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button1.Location = new System.Drawing.Point((this.Width / 2) - 40, (this.Height / 2) - 40);
            button2.Location = new System.Drawing.Point((this.Width / 2) - 40, (this.Height / 2) + 20);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            diff = 0;
            Button button1 = new Button();
            button1.Location = new System.Drawing.Point((this.Width / 2) - 40, (this.Height / 2) - 35);
            button1.Name = "button3";
            button1.Size = new System.Drawing.Size(100, 50);
            button1.TabIndex = 0;
            button1.Text = "INIZIA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button3_Click);
            this.Controls.Add(button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            diff = 2;
            Button button1 = new Button();
            button1.Location = new System.Drawing.Point((this.Width / 2) - 40, (this.Height / 2) - 35);
            button1.Name = "button3";
            button1.Size = new System.Drawing.Size(100, 50);
            button1.TabIndex = 0;
            button1.Text = "INIZIA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button3_Click);
            this.Controls.Add(button1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1375, 695 - 15 * (diff / 2));
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 16);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            label1.Font = label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.BackColor = Color.Transparent;
            this.Controls.Add(label1);

            score.AutoSize = true;
            score.Location = new System.Drawing.Point(1375, 714 - 15 * (diff / 2));
            score.Name = "label1";
            score.Size = new System.Drawing.Size(44, 16);
            score.TabIndex = 2;
            score.BackColor = Color.Transparent;
            score.Text = "0";
            score.Font = label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            scoreCombo.AutoSize = true;
            scoreCombo.Location = new System.Drawing.Point(1375, 735 - 15 * (diff / 2));
            scoreCombo.Name = "label1";
            scoreCombo.Size = new System.Drawing.Size(44, 16);
            scoreCombo.TabIndex = 2;
            scoreCombo.BackColor = Color.Transparent;
            scoreCombo.Text = "x0";
            scoreCombo.Font = label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Controls.Add(score);
            this.Controls.Add(scoreCombo);

            if (diff == 0)
            {
                this.BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.sfondo_talpe_giorno;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.sfondo_talpe_notte;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            for (int i = 0; i < 3; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = global::Schiaccia_la_talpa1._0.Properties.Resources.cuore_finale;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Location = new System.Drawing.Point(100 + 72 * i, 30);
                pictureBox1.Name = "pictureBox1";
                pictureBox1.Size = new System.Drawing.Size(51, 48);
                pictureBox1.TabIndex = 2;
                pictureBox1.TabStop = false;
                vita[i] = pictureBox1;
                this.Controls.Add(vita[i]);
            }

            timer1.Interval = 200;
            timer2.Interval = 200;
            timer3.Interval = 1000;

            timer1.Enabled = true;
            timer1.Start();
            timer3.Enabled = true;
            timer3.Start();

            if (diff == 2)
            {
                timer2.Enabled = true;
                timer2.Start();
            }
        }

        int tempo1 = 0;
        int tempo2 = 0;
        int pos1 = 0;
        int pos2 = 0;

        int x1 = 0;
        int y1 = 0;

        int x2 = 0;
        int y2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo1 == 3)
            {
                do
                {
                    x1 = random.Next(1200);
                    y1 = random.Next(130, 650);
                } while (!((x1 - x2 > 210 || x1 - x2 < -210) && (y1 - y2 > 150 || y1 - y2 < -150)));
                pos1 = 0;
                pictureBoxes1[pos1].Location = new System.Drawing.Point(x1, y1);
                this.Controls.Add(pictureBoxes1[pos1]);
                tempo1++;
            }
            else if (tempo1 == 4)
            {
                this.Controls.Remove(pictureBoxes1[pos1]);
                pos1 = 1;
                pictureBoxes1[pos1].Location = new System.Drawing.Point(x1, y1);
                this.Controls.Add(pictureBoxes1[pos1]);
                tempo1++;
            }
            else if (tempo1 == 5)
            {
                this.Controls.Remove(pictureBoxes1[pos1]);
                pos1 = tipotalpa();
                pictureBoxes1[pos1].Location = new System.Drawing.Point(x1, y1);
                this.Controls.Add(pictureBoxes1[pos1]);
                tempo1++;
            }
            else if (tempo1 == 11 - diff)
            {
                this.Controls.Remove(pictureBoxes1[pos1]);
                tempo1 = 0;
            }
            else if (tempo1 == 14)
            {
                this.Controls.Remove(pictureBoxes1[pos1]);
                tempo1 = 0;
            }
            else
            {
                tempo1++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tempo2 == 3)
            {
                do
                {
                    x2 = random.Next(1200);
                    y2 = random.Next(130, 650);
                } while (!((x2 - x1 > 210 || x2 - x1 < -210) && (y2 - y1 > 150 || y2 - y1 < -150)));
                pos2 = 0;
                pictureBoxes2[pos2].Location = new System.Drawing.Point(x2, y2);
                this.Controls.Add(pictureBoxes2[pos2]);
                tempo2++;
            }
            else if (tempo2 == 4)
            {
                this.Controls.Remove(pictureBoxes2[pos2]);
                pos2 = 1;
                pictureBoxes2[pos2].Location = new System.Drawing.Point(x2, y2);
                this.Controls.Add(pictureBoxes2[pos2]);
                tempo2++;
            }
            else if (tempo2 == 5)
            {
                this.Controls.Remove(pictureBoxes2[pos2]);
                pos2 = tipotalpa();
                pictureBoxes2[pos2].Location = new System.Drawing.Point(x2, y2);
                this.Controls.Add(pictureBoxes2[pos2]);
                tempo2++;
            }
            else if (tempo2 == 13 - diff)
            {
                this.Controls.Remove(pictureBoxes2[pos2]);
                tempo2 = 0;
            }
            else if (tempo2 == 16)
            {
                this.Controls.Remove(pictureBoxes2[pos2]);
                tempo2 = 0;
            }
            else
            {
                tempo2++;
            }
        }

        private int tipotalpa()
        {
            if (diff == 0)
            {
                int a = random.Next(5);
                if (a < 4)
                    return 2;
                else
                    return 3;
            }
            else if (diff == 1)
            {
                int a = random.Next(4);
                if (a < 3)
                    return 2;
                else
                    return 3;
            }
            else
            {
                int a = random.Next(3);
                if (a < 2)
                    return 2;
                else
                    return 3;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            calcoloPunti(1);
            this.Controls.Remove(pictureBoxes1[pos1]);
            pos1 = 4;
            pictureBoxes1[pos1].Location = new System.Drawing.Point(x1 - 55, y1 - 30);
            this.Controls.Add(pictureBoxes1[pos1]);
            tempo1 = 12;
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (numVite < 1)
            {
                finale();
            }
            else
            {
                this.Controls.Remove(vita[numVite]);
                numVite--;
            }
            combo = 0;
            scoreCombo.Text = String.Format("x{0}", combo);
            this.Controls.Remove(pictureBoxes1[pos1]);
            this.Controls.Remove(labelCombo);
            tempo1 = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            calcoloPunti(2);
            this.Controls.Remove(pictureBoxes2[pos2]);
            pos2 = 4;
            pictureBoxes2[pos2].Location = new System.Drawing.Point(x2 - 55, y2 - 30);
            this.Controls.Add(pictureBoxes2[pos2]);
            tempo2 = 14;
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (numVite < 1)
            {
                finale();
            }
            else
            {
                this.Controls.Remove(vita[numVite]);
                numVite--;
            }
            combo = 0;
            scoreCombo.Text = String.Format("x{0}", combo);
            this.Controls.Remove(pictureBoxes2[pos2]);
            this.Controls.Remove(labelCombo);
            tempo2 = 0;
        }

        private void calcoloPunti(int num)
        {
            if (combo < 10)
            {
                combo++;
            }
            punti += 100 * combo;
            score.Text = punti.ToString();
            scoreCombo.Text = String.Format("x{0}", combo);

            labelCombo.AutoSize = true;
            labelCombo.Location = Cursor.Position;
            labelCombo.Name = "label1";
            labelCombo.Size = new System.Drawing.Size(35, 16);
            labelCombo.TabIndex = 2;
            labelCombo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (combo == 10)
            {
                labelCombo.ForeColor = Color.Red;
                labelCombo.BackColor = Color.Yellow;
                labelCombo.Text = 1000.ToString();
            }
            else
            {
                labelCombo.ForeColor = Color.Blue;
                labelCombo.BackColor = Color.Transparent;
                labelCombo.Text = (combo * 100).ToString();
            }

            this.Controls.Add(labelCombo);
        }
        private void finale()
        {
            timer1.Stop();
            timer2.Stop();
            this.Controls.Clear();
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(620, 380);
            label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 16);
            label1.TabIndex = 2;
            label1.Text = string.Format("\nComplimenti,\nhai totalizzato {0} punti\n ", punti);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            this.Controls.Add(label1);

            for (int i = 0; i < 2; i++)
            {
                Button button1 = new Button();
                button1.Location = new System.Drawing.Point(620 + 110 * i, 450);
                button1.Name = "buttonRiprova";
                button1.Size = new System.Drawing.Size(100, 50);
                button1.TabIndex = 0;
                if (i == 0)
                {
                    button1.Text = "RIPROVA";
                    button1.Click += new System.EventHandler(this.buttonRiprova_Click);
                }
                else
                {
                    button1.Text = "ESCI";
                    button1.Click += new System.EventHandler(this.buttonEsci_Click);
                }
                button1.UseVisualStyleBackColor = true;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                this.Controls.Add(button1);
            }
        }

        private void buttonRiprova_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void buttonEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            combo = 0;
            scoreCombo.Text = String.Format("x{0}", combo);
            this.Controls.Remove(labelCombo);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (diff == 0 && tempoGioco == 15)
            {
                timer2.Enabled = true;
                timer2.Start();
            }
            if (tempoGioco == 30)
            {
                diff++;
            }
            else if (tempoGioco == 60)
            {
                diff++;
            }
            tempoGioco++;
        }
    }
}
