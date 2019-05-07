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
using System.Xml.Serialization;
using System.IO;
using BaseData;

namespace Labirint_Editor
{
    public class EditorMob : Mob
    {

    }

    public class EditorBiome : Biome
    {

    }

    public partial class Form1 : Form
    { 
        /*public static List<Panel> BiomePanels = new List<Panel>();
        public static List<TextBox> BiomeTextBoxes = new List<TextBox>();
        public static List<ComboBox> BiomeForBoxes = new List<ComboBox>();
        public static List<ComboBox> BiomeBackBoxes = new List<ComboBox>();*/
        public static int addBiomesCount;

        public static List<EditorMob> AddMobs = new List<EditorMob>();
        public static List<EditorBiome> AddBiomes = new List<EditorBiome>();
        //public static List<Panel> MobsPanels = new List<Panel>();
        //public static List<TextBox> MobsNameBoxes = new List<TextBox>();
        //public static List<ComboBox> MobsForBoxes = new List<ComboBox>();
        //public static List<TextBox> MobsSymBoxes = new List<TextBox>();
        //public static List<TextBox> MobsDamageBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            /*# region MobPanels init
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
            #endregion*/
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            addBiomesCount = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string directory = saveFileDialog1.InitialDirectory;
            XmlDocument xD = new XmlDocument();
            xD.Load(directory + saveFileDialog1.FileName + ".xml");

            
            if (userControl21.comboBox3.SelectedItem != null || userControl21.comboBox2.SelectedItem != null)
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Biome>));
                FileStream fs = new FileStream(directory + saveFileDialog1.FileName + ".xml", FileMode.OpenOrCreate);
                ser.Serialize(fs, AddBiomes);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
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
            */
        }
        
        #region textBoxes events
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region for comboBoxes events
        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion
        #region sym tB events
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion
        #region damage tB events
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
