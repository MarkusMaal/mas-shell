using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shell
{
    public partial class Form1 : Form
    {
        /* Projekt arbuus
         * Taaskirjutamise projekt C#'s
         */
        //bool dm = true;
        string hour;
        string month;
        string mood;
        string season;
        int lastrand = 0;
        int randomindex;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                Notelabel.Text = textBox1.Text;
                Notelabel.Visible = true;
                textBox1.Visible = false;
                textBox1.Text = "";
            }
            else
            {
                Notelabel.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.form2.ShowDialog() == DialogResult.OK)
            {
                if (Program.form2.textBox1.Text == "test")
                {

                }
                else
                {
                    Program.form2.textBox1.Text = "";
                    MessageBox.Show("Vale parool", "Ei saa töölauda käivitada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (Program.form2.ShowDialog() == DialogResult.Cancel)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo("cmd.exe", "/k shutdown /r /f");
            p.WindowStyle = ProcessWindowStyle.Hidden;
            p.CreateNoWindow = true;
            Process.Start(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ProcessStartInfo p = new ProcessStartInfo("cmd.exe", "/k shutdown /h /f");
            p.WindowStyle = ProcessWindowStyle.Hidden;
            p.CreateNoWindow = true;
            Process.Start(p);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            visicheck();
        }

        private void Notelabel_Click(object sender, EventArgs e)
        {
            visicheck();
        }

        void visicheck()
        {
            if (button1.Visible == true)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                TimeLabel.Visible = false;
                DateText.Visible = false;
                textBox1.Visible = false;
                DateText.Visible = false;
                button6.Visible = false;
                Notelabel.Visible = false;
                //PlayButton.Visible = false;
                //ForwardButton.Visible = false;
                //BackwardButton.Visible = false;
                //StopButton.Visible = false;
            }
            else if (button1.Visible == false)
            {

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                TimeLabel.Visible = true;
                DateText.Visible = true;
                textBox1.Visible = true;
                DateText.Visible = true;
                button6.Visible = true;
                Notelabel.Visible = true;
                //PlayButton.Visible = true;
                //ForwardButton.Visible = true;
                //BackwardButton.Visible = true;
                //StopButton.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomindex = rnd.Next(0, 5);
            hour = DateTime.Today.TimeOfDay.TotalHours.ToString();
            month = DateTime.Today.Month.ToString();
            if (hour == "1")
            {
                mood = "night";
            }
            else if (hour == "2")
            {
                mood = "night";
            }
            else if (hour == "3")
            {
                mood = "night";
            }
            else if (hour == "4")
            {
                mood = "night";
            }
            else if (hour == "5")
            {
                mood = "morning";
            }
            else if (hour == "6")
            {
                mood = "morning";
            }
            else if (hour == "7")
            {
                mood = "morning";
            }
            else if (hour == "8")
            {
                mood = "morning";
            }
            else if (hour == "9")
            {
                mood = "morning";
            }
            else if (hour == "10")
            {
                mood = "morning";
            }
            else if (hour == "11")
            {
                mood = "day";
            }
            else if (hour == "12")
            {
                mood = "day";
            }
            else if (hour == "13")
            {
                mood = "day";
            }
            else if (hour == "14")
            {
                mood = "day";
            }
            else if (hour == "15")
            {
                mood = "day";
            }
            else if (hour == "16")
            {
                mood = "day";
            }
            else if (hour == "17")
            {
                mood = "sunset";
            }
            else if (hour == "18")
            {
                mood = "sunset";
            }
            else if (hour == "19")
            {
                mood = "sunset";
            }
            else if (hour == "20")
            {
                mood = "sunset";
            }
            else if (hour == "21")
            {
                mood = "sunset";
            }
            else if (hour == "22")
            {
                mood = "sunset";
            }
            else if (hour == "23")
            {
                mood = "night";
            }
            else if (hour == "0")
            {
                mood = "night";
            }
            if (month == "1")
            {
                season = "winter";
            }
            else if (month == "2")
            {
                season = "winter";
            }
            else if (month == "3")
            {
                season = "spring";
            }
            else if (month == "4")
            {
                season = "spring";
            }
            else if (month == "5")
            {
                season = "spring";
            }
            else if (month == "6")
            {
                season = "summer";
            }
            else if (month == "7")
            {
                season = "summer";
            }
            else if (month == "8")
            {
                season = "summer";
            }
            else if (month == "9")
            {
                season = "autumn";
            }
            else if (month == "10")
            {
                season = "autumn";
            }
            else if (month == "11")
            {
                season = "autumn";
            }
            else if (month == "12")
            {
                season = "winter";
            }
            if (season == "spring")
                goto spring;
            if (season == "summer")
                goto summer;
            if (season == "autumn")
                goto autumn;
            if (season == "winter")
                goto winter;
            goto EsdIf;
            spring:
            if (mood == "night")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SPN1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SPN2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SPN3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SPN4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SPN5;
                    goto EsdIf;
                }
            }
            else if (mood == "morning")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SPM1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SPM2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SPM3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SPM4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SPM5;
                    goto EsdIf;
                }

            }
            else if (mood == "day")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SPD1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SPD2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SPD3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SPD4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SPD5;
                    goto EsdIf;
                }

            }
            else if (mood == "sunset")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SPS1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SPS2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SPS3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SPS4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SPS5;
                    goto EsdIf;
                }
            }
            else
            {
                goto EsdIf;
            }
            summer:
            if (mood == "night")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SN1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SN2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SN3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SN4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SN5;
                    goto EsdIf;
                }
            }
            else if (mood == "morning")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SM1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SM2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SM3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SM4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SM5;
                    goto EsdIf;
                }

            }
            else if (mood == "day")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SD1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SD2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SD3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SD2;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SD5;
                    goto EsdIf;
                }

            }
            else if (mood == "sunset")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.SS1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.SS2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.SS3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.SS4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.SS5;
                    goto EsdIf;
                }
            }
            autumn:
            if (mood == "night")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.AN1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.AN2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.AN3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.AN4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.AN5;
                    goto EsdIf;
                }
            }
            else if (mood == "morning")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.AM1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.AM2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.AM3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.AM4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.AM5;
                    goto EsdIf;
                }

            }
            else if (mood == "day")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.AD1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.AD2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.AD3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.AD4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.AD5;
                    goto EsdIf;
                }

            }
            else if (mood == "sunset")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.AS1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.AS2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.AS3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.AS4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.AS5;
                    goto EsdIf;
                }
            }
            winter:
            if (mood == "night")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.WN1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.WN2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.WN3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.WN4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.WN5;
                    goto EsdIf;
                }
            }
            else if (mood == "morning")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.WM1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.WM2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.WM3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.WM4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.WM5;
                    goto EsdIf;
                }

            }
            else if (mood == "day")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.WD1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.WD2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.WD3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.WD4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.WD5;
                    goto EsdIf;
                }

            }
            else if (mood == "sunset")
            {
                if (randomindex == 1)
                {
                    this.BackgroundImage = Properties.Resources.WS1;
                    goto EsdIf;
                }
                else if (randomindex == 2)
                {
                    this.BackgroundImage = Properties.Resources.WS2;
                    goto EsdIf;
                }
                else if (randomindex == 3)
                {
                    this.BackgroundImage = Properties.Resources.WS3;
                    goto EsdIf;
                }
                else if (randomindex == 4)
                {
                    this.BackgroundImage = Properties.Resources.WS4;
                    goto EsdIf;
                }
                else if (randomindex == 5)
                {
                    this.BackgroundImage = Properties.Resources.WS5;
                    goto EsdIf;
                }
            }
            EsdIf:
            DateText.Text = mood;
            string h = DateTime.Today.TimeOfDay.Hours.ToString();
            string m = DateTime.Today.TimeOfDay.Minutes.ToString();
            if (m.Length == 1)
                m = "0" + m;
            TimeLabel.Text = h + ":" + m;
            string mnth = DateTime.Today.Month.ToString();
            if (mnth == "1")
            {
                mnth = "jaanuar";
                goto fd;
            }
            if (mnth == "2")
            {
                mnth = "veebruar";
                goto fd;
            }
            if (mnth == "3")
            {
                mnth = "märts";
                goto fd;
            }
            if (mnth == "4")
            {
                mnth = "aprill";
                goto fd;
            }
            if (mnth == "5")
            {
                mnth = "mai";
                goto fd;
            }
            if (mnth == "6")
            {
                mnth = "juuni";
                goto fd;
            }
            if (mnth == "7")
            {
                mnth = "juuli";
                goto fd;
            }
            if (mnth == "8")
            {
                mnth = "august";
                goto fd;
            }
            if (mnth == "9")
            {
                mnth = "september";
                goto fd;
            }
            if (mnth == "10")
            {
                mnth = "oktoober";
                goto fd;
            }
            if (mnth == "11")
            {
                mnth = "november";
                goto fd;
            }
            if (mnth == "12")
            {
                mnth = "detsember";
                goto fd;
            }
            fd:
            DateText.Text = DateTime.Today.Day + ". " + mnth + " " + DateTime.Today.Year;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            double h = DateTime.Today.TimeOfDay.TotalHours;
            string m = DateTime.Today.TimeOfDay.TotalMinutes.ToString();
            if (m.Length == 1)
                m = "0" + m;
            string mnth = DateTime.Today.Month.ToString();
            if (mnth == "1")
            {
                mnth = "jaanuar";
                goto fd;
            }
            if (mnth == "2")
            {
                mnth = "veebruar";
                goto fd;
            }
            if (mnth == "3")
            {
                mnth = "märts";
                goto fd;
            }
            if (mnth == "4")
            {
                mnth = "aprill";
                goto fd;
            }
            if (mnth == "5")
            {
                mnth = "mai";
                goto fd;
            }
            if (mnth == "6")
            {
                mnth = "juuni";
                goto fd;
            }
            if (mnth == "7")
            {
                mnth = "juuli";
                goto fd;
            }
            if (mnth == "8")
            {
                mnth = "august";
                goto fd;
            }
            if (mnth == "9")
            {
                mnth = "september";
                goto fd;
            }
            if (mnth == "10")
            {
                mnth = "oktoober";
                goto fd;
            }
            if (mnth == "11")
            {
                mnth = "november";
                goto fd;
            }
            if (mnth == "12")
            {
                mnth = "detsember";
                goto fd;
            }
            fd:

            TimeLabel.Text = h + ":" + m;
            DateText.Text = DateTime.Today.Day + ". " + mnth + " " + DateTime.Today.Year;
        }
    }
}