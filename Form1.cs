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

        public static List<EditorMob> AddMobs = new List<EditorMob>();
        public static List<EditorBiome> AddBiomes = new List<EditorBiome>();

        public static List<UserControl2> biomeUCs = new List<UserControl2>();
        public static List<UserControl3> mobUCs = new List<UserControl3>();


        public Form1()
        {
            InitializeComponent();
            #region fill biomeUCs
            biomeUCs.Add(userControl21);
            biomeUCs.Add(userControl22);
            biomeUCs.Add(userControl23);
            biomeUCs.Add(userControl24);
            biomeUCs.Add(userControl25);
            biomeUCs.Add(userControl26);
            biomeUCs.Add(userControl27);
            biomeUCs.Add(userControl28);
            biomeUCs.Add(userControl29);
            biomeUCs.Add(userControl210);
            #endregion
            #region fill mobUCs
            mobUCs.Add(userControl31);
            mobUCs.Add(userControl32);
            mobUCs.Add(userControl33);
            mobUCs.Add(userControl34);
            mobUCs.Add(userControl35);
            mobUCs.Add(userControl36);
            mobUCs.Add(userControl37);
            mobUCs.Add(userControl38);
            mobUCs.Add(userControl39);
            mobUCs.Add(userControl310);
            #endregion
        }


        private void fill_BiomesList ()
        {
            for (int i = 0; i <= trackBar1.Value; i++)
            {
                EditorBiome biome = new EditorBiome();
                biome.name = biomeUCs[i].textBox.Text;
                biome.forColor = biomeUCs[i].comboBox3.SelectedIndex;
                biome.backColor = biomeUCs[i].comboBox1.SelectedIndex;
                AddBiomes.Add(biome);
            }
        }

        private void fill_MobsList ()
        {
            for (int i = 0; i <= trackBar2.Value; i++)
            {
                if (mobUCs[i].comboBox3.SelectedItem != null)
                {
                    EditorMob mob = new EditorMob();
                    mob.name = mobUCs[i].textBox.Text;
                    mob.color = mobUCs[i].comboBox3.SelectedIndex;
                    mob.sym = mobUCs[i].textBox1.Text.First();
                    int.TryParse(mobUCs[i].textBox2.Text, out int x);
                    mob.Damage = x;
                    mob.biome = mobUCs[i].textBox3.Text;
                    AddMobs.Add(mob);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_BiomesList();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string directory = saveFileDialog1.InitialDirectory;
            string FileName = directory + saveFileDialog1.FileName + ".xml";

            XmlDocument xD = new XmlDocument();
            xD.CreateElement("biomes");
            //xD.Save(FileName);


            XmlSerializer ser = new XmlSerializer(typeof(List<Biome>));
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);

            List<Biome> biomes = new List<Biome>();
            for (int i = 0; i < AddBiomes.Count; i++)
            {
                Biome biome = new Biome();
                biome.name = AddBiomes[i].name;
                biome.forColor = (ConsoleColor)AddBiomes[i].forColor;
                biome.backColor = (ConsoleColor)AddBiomes[i].backColor;
                biomes.Add(biome);
            }
            ser.Serialize(fs, biomes);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fill_MobsList();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlDocument xD = new XmlDocument();
            string directory = saveFileDialog1.InitialDirectory;
            string FileName = directory + saveFileDialog1.FileName + ".xml";

            XmlSerializer ser = new XmlSerializer(typeof(List<Mob>));
            FileStream fs = new FileStream(directory + saveFileDialog1.FileName + ".xml", FileMode.OpenOrCreate);

            List<Mob> mobs = new List<Mob>();

            for (int i = 0; i < AddMobs.Count; i++)
            {
                Mob mob = new Mob();
                mob.name = AddMobs[i].name;
                mob.color = (ConsoleColor)AddMobs[i].color;
                mob.sym = AddMobs[i].sym;
                mob.Damage = AddMobs[i].Damage;
                mob.biome = AddMobs[i].biome;
                mobs.Add(mob);
            }

            
            ser.Serialize(fs, mobs);
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < biomeUCs.Count; i++)
            {
                biomeUCs[i].Enabled = i <= trackBar1.Value;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < mobUCs.Count; i++)
            {
                mobUCs[i].Enabled = i <= trackBar2.Value;
            }
        }
    }
}
