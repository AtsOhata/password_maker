using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PasswordMaker
{
    public partial class MainForm : Form
    {
        static List<long> PrivateSeeds = new();

        public MainForm()
        {
            InitializeComponent();
            Utility.Initialize();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            // Read Private Seeds in Property File
            string privateSeedFilePath = Utility.AppPath + @"PrivateSeeds.txt";
            List<string> privateSeedsStr = new();
            try
            {
                privateSeedsStr = FileUtility.ReadFileAsList(privateSeedFilePath);
            } catch (FileNotFoundException)
            {
                MessageBox.Show("PrivateSeeds.txt is missing in the same folder of .exe file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            privateSeedsStr.ForEach(x =>
            {
                long.TryParse(x, out long n);
                if ( n < 1)
                {
                    MessageBox.Show("Private seeds should be between \n 1 ～ 9,223,372,036,854,775,807", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
                PrivateSeeds.Add(n);
            });
            if(PrivateSeeds.Count != 4)
            {
                MessageBox.Show("Put 4 numbers between in PrivateSeeds.txt", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            // Put values in Private Seed textboxes
            privateSeed1.PasswordChar = '*';
            privateSeed1.Text = PrivateSeeds[0].ToString();
            privateSeed2.PasswordChar = '*';
            privateSeed2.Text = PrivateSeeds[1].ToString();
            privateSeed3.PasswordChar = '*';
            privateSeed3.Text = PrivateSeeds[2].ToString();
            privateSeed4.PasswordChar = '*';
            privateSeed4.Text = PrivateSeeds[3].ToString();

            resultTextBox.PasswordChar = '*';
            passwordDigitComboBox.SelectedIndex = 0;
        }

        void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(passwordDigitComboBox.Text, out int passwordDigit);
            if (passwordDigit < 8)
            {
                passwordDigit = 8;
                passwordDigitComboBox.SelectedIndex = 0;
            }
            if (passwordDigit > 16)
            {
                passwordDigit = 16;
                passwordDigitComboBox.SelectedItem = "16";
            }

            long.TryParse(publicSeedTextBox.Text, out long seed);
            if (seed < 1)
            {
                MessageBox.Show("Put a numbers between \n 1 ～ 9,223,372,036,854,775,807 \n in Public Seed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitRand(seed);  // Intialize the seed
            long random = (long)URand();  // Get random number
            while (random.ToString().Length < 16 && random > 1) random *= random;

            // Get 2 digits and convert it to alphanumeric
            string str = random.ToString();
            string output = "";
            for (int i = 0; i < 8; i++)
            {
                int a = int.Parse(str.Substring(i * 2, 2));  // Get 2 digits like "12"345678...  12"34"5678...
                output += ConvertNumberAlphanumeric(a);
                a = int.Parse(str.Substring(i, 1) + str.Substring(14 - i * 2, 1));  // Get 2 digits like "1"234567"8"...  1"2"3456"7"8...
                output += ConvertNumberAlphanumeric(a);
            }

            resultTextBox.Text = output.Substring(0, passwordDigit);
        }

        /// <summary>Convert numbers to alphanumeric</summary>
        /// <param name="number">Number</param>
        /// <returns>Alphanumeric</returns>
        static string ConvertNumberAlphanumeric(int number)
        {
            // Converted to characters between AsciiMin～AsciiMax
            int AsciiMin = '!', AsciiMax = 'z';
            number %= (AsciiMax - AsciiMin);
            number += AsciiMin;
            char a = (char)number;
            return a.ToString();
        }

        /// <summary>Initialize the seed by private seeds</summary>
        /// <param name="seed">Seed</param>
        static void InitRand(long seed)
        {
            do
            {
                seed = seed * 1812433253 + 1; seed ^= seed << 13; seed ^= seed >> 17;
                PrivateSeeds[0] = 162364580 ^ seed;
                seed = seed * 1812433253 + 1; seed ^= seed << 13; seed ^= seed >> 17;
                PrivateSeeds[1] = 3247902351 ^ seed;
                seed = seed * 1812433253 + 1; seed ^= seed << 13; seed ^= seed >> 17;
                PrivateSeeds[2] = 2854490775 ^ seed;
                seed = seed * 1812433253 + 1; seed ^= seed << 13; seed ^= seed >> 17;
                PrivateSeeds[3] = 47628719 ^ seed;
            } while (PrivateSeeds[0] == 0 && PrivateSeeds[1] == 0 && PrivateSeeds[2] == 0 && PrivateSeeds[3] == 0);
        }

        static double URand()
        {
            long t;
            t = PrivateSeeds[0] ^ (PrivateSeeds[0] << 11);
            PrivateSeeds[0] = PrivateSeeds[1];
            PrivateSeeds[1] = PrivateSeeds[2];
            PrivateSeeds[2] = PrivateSeeds[3];
            PrivateSeeds[3] ^= t ^ (t >> 8) ^ (PrivateSeeds[3] >> 19);
            return ((PrivateSeeds[0] + 0.5) / 4294967296.0 + PrivateSeeds[3]) / 4294967296.0;
        }

        /// <summary>"Copy Password" button</summary>
        void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultTextBox.Text);
        }
    }
}
