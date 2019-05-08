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
