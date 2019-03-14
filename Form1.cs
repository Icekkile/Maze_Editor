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
    }
}
