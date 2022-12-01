using Microsoft.Win32;
using System.Globalization;

namespace PrevodSoustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NastavMasku()
        {
            //ipv4 255.255.255.255 1(8).1(8).1(8).1(8) ff.ff.ff.ff
            //ipv6 ffff::ffff::ffff::ffff::ffff::ffff::ffff::ffff
            //     65535.65535.65535.65535.65535.65535.65535.65535
            //     1(16)
            string maska = "";
            int poc = 2;
            int del = 1;
            char znak = '0';
            if (comboBoxIp.SelectedIndex == 1)
            {
                del = 2;
                poc = 3;
            }
            switch (comboBoxVstup.SelectedIndex)
            {
                case 0:
                    //decimální
                    del *= 3;
                    del = del - del / 5;
                    break;
                case 1:
                    //binární
                    del *= 8;
                    break;
                case 2:
                    //hexadecimální
                    del *= 2;
                    znak = '&';
                    break;
            }
            for (int i = 0; i < del; i++)
                maska += znak;
            for (int i = 0; i < poc; i++)
                maska += "."+maska;
            maskedTextBoxVstup.Mask = maska;
        }
        private string NaBinarni(int cislo)
        {
            int delitel = 1;
            string binarni = "";
            while (delitel < cislo)
                delitel *= 2;
            while(delitel > 1)
            {
                if(cislo / delitel == 1)
                {
                    cislo = cislo % delitel;
                    binarni += "1";
                }
                else
                {
                    binarni += "0";
                }
                delitel /= 2;
            }
            if (cislo == 1)
                binarni += "1";
            else
                binarni += "0";
            if (binarni[0] == '0')
                binarni = binarni.Remove(0, 1);
            return binarni;
        }
        private int NaInt(string binarni)
        {
            int cislo = 0;
            for(int i = 0;i< binarni.Length;i++)
            {
                if (binarni[i] == '1')
                    cislo += (int)Math.Pow(2, i);
            }
            return cislo;
        }
        private void comboBoxVstup_SelectedIndexChanged(object sender, EventArgs e)
        {
            NastavMasku();
        }

        private void comboBoxVystup_SelectedIndexChanged(object sender, EventArgs e)
        {      
                bool pokracovat = true;
                textBoxVystup.Clear();
                int[] cisla;
                string[] vstup = maskedTextBoxVstup.Text.Split(',');
                cisla = new int[vstup.Length];
                switch (comboBoxVstup.SelectedIndex)
                {
                    case 1:
                        //binární
                        try
                        {
                            for (int i = 0; i < vstup.Length; i++)
                                cisla[i] = NaInt(vstup[i]);
                        }
                        catch 
                        {
                            pokracovat = false;
                            textBoxVystup.Text = "Neplatný vstup";
                        }
                        break;
                    //decimální //hexa
                    case 0:
                        for (int i = 0; i < vstup.Length; i++)
                            cisla[i] = int.Parse(vstup[i]);
                        break;
                    case 2:
                        try
                        {
                            for (int i = 0; i < vstup.Length; i++)
                                cisla[i] = int.Parse(vstup[i], NumberStyles.HexNumber);
                        }
                        catch
                        {
                            pokracovat = false;
                            textBoxVystup.Text = "Neplatný vstup";
                        }
                        break;
                }
                if (pokracovat)
                    switch (comboBoxVystup.SelectedIndex)
                    {
                        case 1:
                            foreach (int i in cisla)
                                textBoxVystup.Text += NaBinarni(i) + ".";
                            textBoxVystup.Text = textBoxVystup.Text.Remove(textBoxVystup.Text.Length - 1);
                            break;
                        case 0:
                            foreach (int i in cisla)
                                textBoxVystup.Text += i + ".";
                            textBoxVystup.Text = textBoxVystup.Text.Remove(textBoxVystup.Text.Length - 1);
                            break;
                        case 2:
                            foreach (int i in cisla)
                                textBoxVystup.Text += i.ToString("X").ToLower() + "::";
                            textBoxVystup.Text = textBoxVystup.Text.Remove(textBoxVystup.Text.Length - 2);
                            break;
                    }                              
        }

        private void comboBoxIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            NastavMasku();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIp.SelectedIndex = 0;
            comboBoxVstup.SelectedIndex = 0;
        }
    }
}