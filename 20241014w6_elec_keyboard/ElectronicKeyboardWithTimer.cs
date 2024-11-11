using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241014w6_elec_keyboard
{
    public partial class formElecKb : Form
    {
        private const int A4_FREQUENCY = 440;
        private const int NOTE_DURATION = 500;

        private static int Note_Ferq(float steps_from_A4, int A4_ferq = 440)
        {
            // ferquency = A440 * 2^(steps/6)
            double ferquency = A4_ferq * Math.Pow(2, steps_from_A4 / 6);
            int rounded_ferquency = (int)Math.Round(ferquency);
            return rounded_ferquency;
        }

        public formElecKb()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Current Time:" + DateTime.Now.ToString("HH:mm:ss.f");
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(-5, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(-4, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(-3, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(-2, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(-1, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            Console.Beep(A4_FREQUENCY, NOTE_DURATION);
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(1, A4_FREQUENCY), NOTE_DURATION);
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            Console.Beep(Note_Ferq(2, A4_FREQUENCY), NOTE_DURATION);
        }

        private void formElecKb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: // Digital 1, the 1 on NumPad wouldn't work!
                    Console.Beep(Note_Ferq(-5, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D2:
                    Console.Beep(Note_Ferq(-4, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D3:
                    Console.Beep(Note_Ferq(-3, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D4:
                    Console.Beep(Note_Ferq(-2, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D5:
                    Console.Beep(Note_Ferq(-1, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D6:
                    Console.Beep(A4_FREQUENCY, NOTE_DURATION);
                    break;
                case Keys.D7:
                    Console.Beep(Note_Ferq(1, A4_FREQUENCY), NOTE_DURATION);
                    break;
                case Keys.D8:
                    Console.Beep(Note_Ferq(2, A4_FREQUENCY), NOTE_DURATION);
                    break;
            }
        }
    }
}
