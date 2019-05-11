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
            foreach (UserControl2 us in biomeUCs)
            {
                EditorBiome biome = new EditorBiome();
                biome.name = us.textBox.Text;
                biome.forColor = us.comboBox2.SelectedItem.ToString();
                biome.backColor = us.comboBox3.SelectedItem.ToString();
                AddBiomes.Add(biome);
            }
        }

        private void fill_MobsList ()
        {
            foreach (UserControl3 us in mobUCs)
            {
                if (us.comboBox3.SelectedItem != null)
                {
                    EditorMob mob = new EditorMob();
                    mob.name = us.textBox.Text;
                    mob.color = us.comboBox3.SelectedItem.ToString();
                    mob.sym = us.textBox1.Text.First();
                    int.TryParse(userControl31.textBox2.Text, out int x);
                    mob.Damage = x;
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

            /*XmlDocument xD = new XmlDocument();
            xD.CreateElement("biomes");
            xD.Save(FileName);
            */
            
            XmlSerializer ser = new XmlSerializer(typeof(List<Biome>));
            FileStream fs = new FileStream(directory + saveFileDialog1.FileName + ".xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, AddBiomes);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fill_MobsList();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string directory = saveFileDialog1.InitialDirectory;
            string FileName = directory + saveFileDialog1.FileName + ".xml";

            XmlSerializer ser = new XmlSerializer(typeof(List<Mob>));
            FileStream fs = new FileStream(directory + saveFileDialog1.FileName + ".xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, AddMobs);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userControl21.comboBox3.SelectedItem != null || userControl21.comboBox2.SelectedItem != null)
            {
                EditorBiome biome = new EditorBiome();
                biome.name = userControl21.textBox.Text;
                biome.forColor = userControl21.comboBox2.SelectedItem.ToString();
                biome.backColor = userControl21.comboBox3.SelectedItem.ToString();
                AddBiomes.Add(biome);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userControl31.comboBox3.SelectedItem != null)
            {
                EditorMob mob = new EditorMob();
                mob.name = userControl31.textBox.Text;
                mob.color = userControl31.comboBox3.SelectedItem.ToString();
                mob.sym = userControl31.textBox1.Text.First();
                int.TryParse(userControl31.textBox2.Text, out int x);
                mob.Damage = x;
                AddMobs.Add(mob);
            }
        }
    }
}
