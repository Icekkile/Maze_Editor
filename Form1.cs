using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Labirint_Editor
{
    public partial class Form1 : Form
    {
        public static List<Panel> BiomePanels = new List<Panel>();
        public static List<TextBox> BiomeTextBoxes = new List<TextBox>();
        public static List<ComboBox> BiomeForBoxes = new List<ComboBox>();
        public static List<ComboBox> BiomeBackBoxes = new List<ComboBox>();

        public static List<Panel> MobsPanels = new List<Panel>();
        public static List<TextBox> MobsNameBoxes = new List<TextBox>();
        public static List<ComboBox> MobsForBoxes = new List<ComboBox>();
        public static List<TextBox> MobsSymBoxes = new List<TextBox>();
        public static List<TextBox> MobsDamageBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            #region BiomePanels Initialize
            BiomePanels.Add(BiomePanel1);
            BiomePanels.Add(BiomePanel2);
            BiomePanels.Add(BiomePanel3);
            BiomePanels.Add(BiomePanel4);
            BiomePanels.Add(BiomePanel5);
            BiomePanels.Add(BiomePanel6);
            BiomePanels.Add(BiomePanel7);
            BiomePanels.Add(BiomePanel8);
            BiomePanels.Add(BiomePanel9);
            BiomePanels.Add(BiomePanel10);
            #endregion
            #region BiomeTextBoxes Initialize
            BiomeTextBoxes.Add(textBox);
            BiomeTextBoxes.Add(textBox6);
            BiomeTextBoxes.Add(textBox7);
            BiomeTextBoxes.Add(textBox8);
            BiomeTextBoxes.Add(textBox9);
            BiomeTextBoxes.Add(textBox13);
            BiomeTextBoxes.Add(textBox14);
            BiomeTextBoxes.Add(textBox12);
            BiomeTextBoxes.Add(textBox11);
            BiomeTextBoxes.Add(textBox10);
            #endregion
            #region BiomeForBoxes init
            BiomeForBoxes.Add(comboBox3);
            BiomeForBoxes.Add(comboBox5);
            BiomeForBoxes.Add(comboBox7);
            BiomeForBoxes.Add(comboBox9);
            BiomeForBoxes.Add(comboBox11);
            BiomeForBoxes.Add(comboBox19);
            BiomeForBoxes.Add(comboBox21);
            BiomeForBoxes.Add(comboBox17);
            BiomeForBoxes.Add(comboBox15);
            BiomeForBoxes.Add(comboBox13);
            #endregion
            #region BiomeBackBoxes init
            BiomeBackBoxes.Add(comboBox2);
            BiomeBackBoxes.Add(comboBox4);
            BiomeBackBoxes.Add(comboBox6);
            BiomeBackBoxes.Add(comboBox8);
            BiomeBackBoxes.Add(comboBox10);
            BiomeBackBoxes.Add(comboBox18);
            BiomeBackBoxes.Add(comboBox20);
            BiomeBackBoxes.Add(comboBox16);
            BiomeBackBoxes.Add(comboBox14);
            BiomeBackBoxes.Add(comboBox12);
            #endregion

            # region MobPanels init
            MobsPanels.Add(panel12);
            MobsPanels.Add(panel13);
            MobsPanels.Add(panel9);
            MobsPanels.Add(panel7);
            MobsPanels.Add(panel4);
            MobsPanels.Add(panel10);
            MobsPanels.Add(panel11);
            MobsPanels.Add(panel8);
            MobsPanels.Add(panel5);
            MobsPanels.Add(panel3);
            #endregion
            #region MobsNameBoxes init
            MobsNameBoxes.Add(textBox20);
            MobsNameBoxes.Add(textBox21);
            MobsNameBoxes.Add(textBox17);
            MobsNameBoxes.Add(textBox15);
            MobsNameBoxes.Add(textBox2);
            MobsNameBoxes.Add(textBox18);
            MobsNameBoxes.Add(textBox19);
            MobsNameBoxes.Add(textBox16);
            MobsNameBoxes.Add(textBox5);
            MobsNameBoxes.Add(textBox1);
            #endregion
            #region MobsSymBoxes init
            MobsSymBoxes.Add(textBox24);
            MobsSymBoxes.Add(textBox27);
            MobsSymBoxes.Add(textBox29);
            MobsSymBoxes.Add(textBox31);
            MobsSymBoxes.Add(textBox33);
            MobsSymBoxes.Add(textBox35);
            MobsSymBoxes.Add(textBox37);
            MobsSymBoxes.Add(textBox39);
            MobsSymBoxes.Add(textBox41);
            MobsSymBoxes.Add(textBox43);
            #endregion
            #region MobsForBoxes init
            MobsForBoxes.Add(comboBox38);
            MobsForBoxes.Add(comboBox40);
            MobsForBoxes.Add(comboBox32);
            MobsForBoxes.Add(comboBox28);
            MobsForBoxes.Add(comboBox24);
            MobsForBoxes.Add(comboBox34);
            MobsForBoxes.Add(comboBox36);
            MobsForBoxes.Add(comboBox30);
            MobsForBoxes.Add(comboBox26);
            MobsForBoxes.Add(comboBox24);
            #endregion
            #region MobsDamageBoxes init
            MobsDamageBoxes.Add(textBox25);
            MobsDamageBoxes.Add(textBox26);
            MobsDamageBoxes.Add(textBox28);
            MobsDamageBoxes.Add(textBox30);
            MobsDamageBoxes.Add(textBox32);
            MobsDamageBoxes.Add(textBox34);
            MobsDamageBoxes.Add(textBox36);
            MobsDamageBoxes.Add(textBox38);
            MobsDamageBoxes.Add(textBox40);
            MobsDamageBoxes.Add(textBox42);
            #endregion
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= trackBar1.Value - 1; i++)
            {
                BiomePanels[i].Enabled = true;
            }
            for (int i = BiomePanels.Count - 1; i > trackBar1.Value - 1; i--)
            {
                BiomePanels[i].Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xD = new XmlDocument();
            xD.Load("E:/MyCode/kirill_strong/Labirint_Game/Labirint_Game/bin/Debug/biomes.xml");
            XmlElement xMain = xD.DocumentElement;
            for (int i = 0; i < BiomePanels.Count; i++)
            {
                if (!BiomePanels[i].Enabled) break;
                XmlElement biomeEl = xD.CreateElement("biome");
                XmlAttribute nameAttr = xD.CreateAttribute("name");
                XmlElement forcolEl = xD.CreateElement("ForColor");
                XmlElement backcolEl = xD.CreateElement("BackColor");
                XmlText name = xD.CreateTextNode(BiomeTextBoxes[i].Text);

                if (BiomeForBoxes[i].SelectedItem == null || BiomeBackBoxes[i].SelectedItem == null) continue;

                XmlText forcol = xD.CreateTextNode(BiomeForBoxes[i].SelectedItem.ToString());
                XmlText backcol = xD.CreateTextNode(BiomeBackBoxes[i].SelectedItem.ToString());

                nameAttr.AppendChild(name);
                forcolEl.AppendChild(forcol);
                backcolEl.AppendChild(backcol);
                biomeEl.Attributes.Append(nameAttr);
                biomeEl.AppendChild(forcolEl);
                biomeEl.AppendChild(backcolEl);
                xMain.AppendChild(biomeEl);
                //xD.AppendChild(xMain);
                xD.Save("E:/MyCode/kirill_strong/Labirint_Game/Labirint_Game/bin/Debug/biomes.xml");
            }

            /*string s = "";
            foreach (Control x in BiomePanel2.Controls)
                s += x.Name + '\n';
            //MessageBox.Show(s);
            Console.WriteLine(s);
            //Console.Beep(1000, 1000);
            //BiomePanel1.Controls[0].Visible = false;*/
        }
        #region textBoxes events
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox)] = textBox;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox6)] = textBox6;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox7)] = textBox7;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox8)] = textBox8;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox9)] = textBox9;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox13)] = textBox13;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox14)] = textBox14;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox12)] = textBox12;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox10)] = textBox11;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            BiomeTextBoxes[BiomeTextBoxes.IndexOf(textBox10)] = textBox10;
        }
        #endregion
        #region for comboBoxes events
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox3)] = comboBox3;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox5)] = comboBox5;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox7)] = comboBox7;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox9)] = comboBox9;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox11)] = comboBox11;
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox19)] = comboBox19;
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox21)] = comboBox21;
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox17)] = comboBox17;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox15)] = comboBox15;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeForBoxes[BiomeForBoxes.IndexOf(comboBox13)] = comboBox13;
        }
        #endregion
        #region back ComboBoxes events

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox2)] = comboBox2;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox4)] = comboBox4;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox6)] = comboBox6;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox8)] = comboBox8;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox10)] = comboBox10;
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox18)] = comboBox18;
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox20)] = comboBox20;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox16)] = comboBox16;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox16)] = comboBox16;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiomeBackBoxes[BiomeBackBoxes.IndexOf(comboBox12)] = comboBox12;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i <= trackBar2.Value - 1; i++)
            {
                MobsPanels[i].Enabled = true;
            }
            for (int i = BiomePanels.Count - 1; i > trackBar2.Value - 1; i--)
            {
                MobsPanels[i].Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlDocument xD = new XmlDocument();
            xD.Load("E:/MyCode/kirill_strong/Labirint_Game/Labirint_Game/bin/Debug/mobs.xml");
            XmlElement xMain = xD.DocumentElement;
            for (int i = 0; i < MobsPanels.Count; i++)
            {
                if (!MobsPanels[i].Enabled) break;
                XmlElement mobEl = xD.CreateElement("mob");
                XmlAttribute nameAttr = xD.CreateAttribute("name");
                XmlElement forcolEl = xD.CreateElement("ForColor");
                XmlElement symEl = xD.CreateElement("Sym");
                XmlElement damageEl = xD.CreateElement("Damage");
                XmlText name = xD.CreateTextNode(MobsNameBoxes[i].Text);
                if (MobsForBoxes[i].SelectedItem == null) continue;
                XmlText forcol = xD.CreateTextNode(MobsForBoxes[i].SelectedItem.ToString());
                XmlText sym = xD.CreateTextNode( MobsSymBoxes[i].Text);
                //int x;
                int.TryParse(MobsDamageBoxes[i].Text, out int x);
                XmlText damage = xD.CreateTextNode(x.ToString());

                nameAttr.AppendChild(name);
                forcolEl.AppendChild(forcol);
                symEl.AppendChild(sym);
                damageEl.AppendChild(damage);
                mobEl.Attributes.Append(nameAttr);
                mobEl.AppendChild(forcolEl);
                mobEl.AppendChild(symEl);
                mobEl.AppendChild(damageEl);
                xMain.AppendChild(mobEl);
                //xD.AppendChild(xMain);
                xD.Save("E:/MyCode/kirill_strong/Labirint_Game/Labirint_Game/bin/Debug/mobs.xml");
            }
        }

        #region textBoxes events
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox20)] = textBox20;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox21)] = textBox21;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox17)] = textBox17;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox15)] = textBox15;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox2)] = textBox2;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox18)] = textBox18;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox19)] = textBox19;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox16)] = textBox16;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox5)] = textBox5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MobsNameBoxes[MobsNameBoxes.IndexOf(textBox1)] = textBox1;
        }
        #endregion
        #region for comboBoxes events
        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox38)] = comboBox38;
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox40)] = comboBox40;
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox32)] = comboBox32;
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox28)] = comboBox28;
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox24)] = comboBox24;
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox34)] = comboBox34;
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox36)] = comboBox36;
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox30)] = comboBox30;
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox26)] = comboBox26;
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobsForBoxes[MobsForBoxes.IndexOf(comboBox22)] = comboBox22;
        }
        #endregion
        #region sym tB events
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox24)] = textBox24;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox27)] = textBox27;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox29)] = textBox29;
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox31)] = textBox31;
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox33)] = textBox33;
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox35)] = textBox35;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox37)] = textBox37;
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox39)] = textBox39;
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox41)] = textBox41;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            MobsSymBoxes[MobsSymBoxes.IndexOf(textBox43)] = textBox43;
        }
        #endregion
        #region damage tB events
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox25)] = textBox25;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox26)] = textBox26;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox28)] = textBox28;
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox30)] = textBox30;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox32)] = textBox32;
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox34)] = textBox34;
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox36)] = textBox36;
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox38)] = textBox38;
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox40)] = textBox40;
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            MobsDamageBoxes[MobsDamageBoxes.IndexOf(textBox42)] = textBox42;
        }
        #endregion
    }
}
