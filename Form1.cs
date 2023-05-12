using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static Gestionnaire_de_tache_pour_chris.Form1;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestionnaire_de_tache_pour_chris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.Load += Form1_Load;


        }
        public class TexteEnregistre
        {
            public string Texte { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            DisplayNotification(8);
            DisplayNotification(9);
            DisplayNotification(10);
            DisplayNotification(11);
            DisplayNotification(12);
            DisplayNotification(13);
            DisplayNotification(14);
            ReadTextFileAndUpdateTextBoxes();
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Button bouton = sender as Button;

            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    // Si la fenêtre est déjà maximisée, rétablissez-la à la taille normale
            //    this.WindowState = FormWindowState.Normal;

            //    // Changez la taille de la fenêtre à 400x600
            //    this.Size = new Size(921, 450);

            //    // Modifiez le texte du bouton pour indiquer la prochaine action
            //    bouton.Text = "Agrandir";
            //}
            //else
            //{
            //    // Si la fenêtre n'est pas maximisée, maximisez-la
            //    this.WindowState = FormWindowState.Maximized;

            //    // Modifiez le texte du bouton pour indiquer la prochaine action
            //    bouton.Text = "Réduire";
            //}

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Close();

        }
        private void ReadTextFileAndUpdateTextBoxes()
        {
            // Chemin d'accès du fichier contenant les chemins à traiter
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\liste chemins.txt";

            // Lire chaque ligne du fichier
            string[] lines = File.ReadAllLines(filePath);

            // Boucler sur chaque ligne et traiter le contenu
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // Vérifier si le fichier existe déjà pour cette ligne
                if (File.Exists(line))
                {
                    // Si le fichier existe, lire le contenu
                    string content = File.ReadAllText(line);

                    // Mettre à jour le contenu des textBox en fonction du numéro de ligne
                    switch (i)
                    {
                        case 0:
                            textBox2.Text = content;
                            break;
                        case 1:
                            textBox3.Text = content;
                            break;
                        case 2:
                            textBox4.Text = content;
                            break;
                        case 3:
                            textBox5.Text = content;
                            break;
                        case 4:
                            textBox6.Text = content;
                            break;
                        case 5:
                            textBox7.Text = content;
                            break;
                        case 6:
                            textBox8.Text = content;
                            break;
                        case 7:
                            textBox9.Text = content;
                            break;
                        case 8:
                            textBox10.Text = content;
                            break;
                        case 9:
                            textBox11.Text = content;
                            break;
                        case 10:
                            textBox12.Text = content;
                            break;
                        case 11:
                            textBox13.Text = content;
                            break;
                        case 12:
                            textBox14.Text = content;
                            break;
                        case 13:
                            textBox15.Text = content;
                            break;
                        case 14:
                            textBox16.Text = content;
                            break;
                        case 15:
                            textBox17.Text = content;
                            break;
                        case 16:
                            textBox18.Text = content;
                            break;
                        case 17:
                            textBox19.Text = content;
                            break;
                        case 18:
                            textBox20.Text = content;
                            break;
                        case 19:
                            textBox21.Text = content;
                            break;
                        case 20:
                            textBox22.Text = content;
                            break;
                        case 21:
                            textBox23.Text = content;
                            break;
                        case 22:
                            textBox24.Text = content;
                            break;
                        case 23:
                            textBox25.Text = content;
                            break;
                        case 24:
                            textBox26.Text = content;
                            break;
                        case 25:
                            textBox27.Text = content;
                            break;
                        case 26:
                            textBox28.Text = content;
                            break;
                        case 27:
                            textBox29.Text = content;
                            break;
                        case 28:
                            textBox30.Text = content;
                            break;
                        case 29:
                            textBox31.Text = content;
                            break;
                        case 30:
                            textBox32.Text = content;
                            break;
                        case 31:
                            textBox33.Text = content;
                            break;
                        case 32:
                            textBox34.Text = content;
                            break;
                        case 33:
                            textBox35.Text = content;
                            break;
                        case 34:
                            textBox36.Text = content;
                            break;
                        case 35:
                            textBox37.Text = content;
                            break;
                        case 36:
                            textBox38.Text = content;
                            break;
                        case 37:
                            textBox39.Text = content;
                            break;
                        case 38:
                            textBox40.Text = content;
                            break;
                        case 39:
                            textBox41.Text = content;
                            break;
                        case 40:
                            textBox42.Text = content;
                            break;
                        case 41:
                            textBox43.Text = content;
                            break;
                        case 42:
                            textBox44.Text = content;
                            break;
                        case 43:
                            textBox45.Text = content;
                            break;
                        case 44:
                            textBox46.Text = content;
                            break;
                        case 45:
                            textBox47.Text = content;
                            break;
                        case 46:
                            textBox48.Text = content;
                            break;
                        case 47:
                            textBox49.Text = content;
                            break;
                        case 48:
                            textBox50.Text = content;
                            break;
                    }
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_10h_12h.txt";
            string content = textBox2.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_10h_12h.txt";
            string content = textBox3.Text;

            File.WriteAllText(filePath, content);

            //MessageBox.Show("Contenu du TextBox");
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_10h_12h.txt";
            string content = textBox4.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_10h_12h.txt";
            string content = textBox5.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_10h_12h.txt";
            string content = textBox6.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_10h_12h.txt";
            string content = textBox7.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_10h_12h.txt";
            string content = textBox8.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_12h_14h.txt";
            string content = textBox9.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_12h_14h.txt";
            string content = textBox10.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_12h_14h.txt";
            string content = textBox11.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_12h_14h.txt";
            string content = textBox12.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_12h_14h.txt";
            string content = textBox13.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_12h_14h.txt";
            string content = textBox14.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_12h_14h.txt";
            string content = textBox15.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_14h_16h.txt";
            string content = textBox16.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_14h_16h.txt";
            string content = textBox17.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_14h_16h.txt";
            string content = textBox18.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_14h_16h.txt";
            string content = textBox19.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_14h_16h.txt";
            string content = textBox20.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_14h_16h.txt";
            string content = textBox21.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_14h_16h.txt";
            string content = textBox22.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_16h_18h.txt";
            string content = textBox23.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_16h_18h.txt";
            string content = textBox24.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_16h_18h.txt";
            string content = textBox25.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_16h_18h.txt";
            string content = textBox26.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_16h_18h.txt";
            string content = textBox27.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_16h_18h.txt";
            string content = textBox28.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_16h_18h.txt";
            string content = textBox29.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_18h_20h.txt";
            string content = textBox30.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_18h_20h.txt";
            string content = textBox31.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_18h_20h.txt";
            string content = textBox32.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_18h_20h.txt";
            string content = textBox33.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_18h_20h.txt";
            string content = textBox34.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_18h_20h.txt";
            string content = textBox35.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_18h_20h.txt";
            string content = textBox36.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_20h_22h.txt";
            string content = textBox37.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_20h_22h.txt";
            string content = textBox38.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_20h_22h.txt";
            string content = textBox39.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_20h_22h.txt";
            string content = textBox40.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_20h_22h.txt";
            string content = textBox41.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_20h_22h.txt";
            string content = textBox42.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_20h_22h.txt";
            string content = textBox43.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_22h_24h.txt";
            string content = textBox44.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_22h_24h.txt";
            string content = textBox45.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_22h_24h.txt";
            string content = textBox46.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_22h_24h.txt";
            string content = textBox47.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_22h_24h.txt";
            string content = textBox48.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_22h_24h.txt";
            string content = textBox49.Text;

            File.WriteAllText(filePath, content);
        }
        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_22h_24h.txt";
            string content = textBox50.Text;

            File.WriteAllText(filePath, content);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("ok");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        //private void textBox10_TextChanged(object sender, EventArgs e)
        //{
        //    textBox5.Text = "ok";
        //    textBox5.AppendText(Environment.NewLine);
        //    textBox5.AppendText(DateTime.Now.ToString("HH:mm:ss"));
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
            notifyIcon1.Text = "Some Text";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "MESSAGE DE CHRIS";
            notifyIcon1.BalloonTipText = "Coucou barbara";
            notifyIcon1.ShowBalloonTip(100);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var timeText = DateTime.Now.ToString("HH:mm:ss");
            label15.Text = timeText;
        }
        private bool alreadyNotified8 = false;
        private bool alreadyNotified9 = false;
        private bool alreadyNotified10 = false;
        private bool alreadyNotified11 = false;
        private bool alreadyNotified12 = false;
        private bool alreadyNotified13 = false;
        private bool alreadyNotified14 = false;
        private bool alreadyNotified15 = false;
        private bool alreadyNotified16 = false;
        private bool alreadyNotified17 = false;
        private bool alreadyNotified18 = false;
        private bool alreadyNotified19 = false;
        private bool alreadyNotified20 = false;
        private bool alreadyNotified21 = false;
        private bool alreadyNotified22 = false;
        private void DisplayNotification(int labelNumber)
        {
            DateTime now = DateTime.Now; // obtenir l'heure actuelle
            bool shouldDisplayNotification = false;
            string customText = "";

            // Vérifier si aujourd'hui c'est lundi
            bool isMonday = now.DayOfWeek == DayOfWeek.Monday;

            // Vérifier si aujourd'hui c'est mardi
            bool isTuesday = now.DayOfWeek == DayOfWeek.Tuesday;

            // Vérifier si aujourd'hui c'est mercredi
            bool isWednesday = now.DayOfWeek == DayOfWeek.Wednesday;

            // Vérifier si aujourd'hui c'est jeudi
            bool isThursday = now.DayOfWeek == DayOfWeek.Thursday;

            // Vérifier si aujourd'hui c'est vendredi
            bool isFriday = now.DayOfWeek == DayOfWeek.Friday;

            // Vérifier si aujourd'hui c'est samedi
            bool isSaturday = now.DayOfWeek == DayOfWeek.Saturday;

            // Vérifier si aujourd'hui c'est dimanche
            bool isSunday = now.DayOfWeek == DayOfWeek.Sunday;

            if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified8)
            {
                alreadyNotified8 = true;
                shouldDisplayNotification = true;
            }
            else if (labelNumber == 9 && now.Hour >= 12 && now.Hour < 14 && !alreadyNotified9)
            {
                alreadyNotified9 = true;
                shouldDisplayNotification = true;
            }
            else if (labelNumber == 10 && now.Hour >= 14 && now.Hour < 16 && !alreadyNotified10)
            {
                alreadyNotified10 = true;
                shouldDisplayNotification = true;
                customText = textBox2.Text;
            }
            else if (labelNumber == 11 && now.Hour >= 16 && now.Hour < 18 && !alreadyNotified11)
            {
                alreadyNotified11 = true;
                shouldDisplayNotification = true;
            }
            else if (labelNumber == 12 && now.Hour >= 18 && now.Hour < 20 && !alreadyNotified12)
            {
                alreadyNotified12 = true;
                shouldDisplayNotification = true;
            }
            else if (labelNumber == 13 && now.Hour >= 20 && now.Hour < 22 && !alreadyNotified13)
            {
                alreadyNotified13 = true;
                shouldDisplayNotification = true;
            }
            else if (labelNumber == 14 && ((now.Hour >= 22 && now.Minute >= 0) || (now.Hour >= 0 && now.Hour < 2 && !alreadyNotified14)))
            {
                alreadyNotified14 = true;
                shouldDisplayNotification = true;
            }

            if (shouldDisplayNotification)
            {
                // Lire le contenu du fichier texte lorsque nous sommes mardi
                if (isMonday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified15)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified15 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified16 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified17 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified18 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified19 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified20 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_lundi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified21 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                if (isTuesday)
                {
                    

                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified8)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified8 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 9 && now.Hour >= 12 && now.Hour < 14 && !alreadyNotified9)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified9 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 10 && now.Hour >= 14 && now.Hour < 16 && !alreadyNotified10)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified10 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 11 && now.Hour >= 16 && now.Hour < 18 && !alreadyNotified11)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified11 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 12 && now.Hour >= 18 && now.Hour < 20 && !alreadyNotified12)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified12 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 13 && now.Hour >= 20 && now.Hour < 22 && !alreadyNotified13)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified13 = true;
                        shouldDisplayNotification = true;
                    }
                    else if (labelNumber == 14 && ((now.Hour >= 22 && now.Minute >= 0) || (now.Hour >= 0 && now.Hour < 2 && !alreadyNotified14)))
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mardi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified14 = true;
                        shouldDisplayNotification = true;
                    }
                }
                if (isWednesday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified8)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified8 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified9 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified10 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified11 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified12 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified13 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_mercredi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified14 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                if (isThursday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified15)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified15 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified16 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified17 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified18 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified19 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified20 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_jeudi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified21 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                if (isFriday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified15)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified15 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified16 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified17 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified18 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified19 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified20 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_vendredi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified21 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                if (isSaturday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified15)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified15 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified16 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified17 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified18 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified19 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified20 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_samedi_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified21 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                if (isSunday)
                {
                    if (labelNumber == 8 && now.Hour >= 10 && now.Hour < 12 && !alreadyNotified15)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_10h_12h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified15 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 12 && now.Hour < 14)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_12h_14h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified16 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 14 && now.Hour < 16)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_14h_16h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified17 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 16 && now.Hour < 18)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_16h_18h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified18 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 18 && now.Hour < 20)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_18h_20h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified19 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 20 && now.Hour < 22)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_20h_22h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified20 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                    else if (now.Hour >= 22 && now.Hour < 24)
                    {
                        string filePath = @"C:\Users\shoot\OneDrive\Bureau\C++\Tache_date\Tache_dimanche_22h_24h.txt";
                        customText = File.ReadAllText(filePath);
                        alreadyNotified21 = true;
                        shouldDisplayNotification = true;
                        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\shoot\Downloads\son.ico"));
                        notifyIcon1.Text = "InfobulleActivité";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = customText;
                        notifyIcon1.BalloonTipText = DateTime.Now.ToString("HH:mm:ss") + DateTime.Now.ToString("dddd dd MMMM yyyy") + ". Tu dois faire :" + customText;
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }

            }
                }


        private void textBox2_Leave(object sender, EventArgs e)
        {

        }
    }
}