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
    public partial class Form1 : Form
    {
        public static int addBiomesCount;

        public static List<Mob> AddMobs = new List<Mob>();
        public static List<Biome> AddBiomes = new List<Biome>();

        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string directory = saveFileDialog1.InitialDirectory;
            XmlDocument xD = new XmlDocument();
            xD.Load(directory + saveFileDialog1.FileName + ".xml");

            if (userControl31.comboBox3.SelectedItem != null)
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Mob>));
                FileStream fs = new FileStream(directory + saveFileDialog1.FileName + ".xml", FileMode.OpenOrCreate);
                ser.Serialize(fs, AddMobs);
            }
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
            }*/
        }
    }
}
