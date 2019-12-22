using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        int index=-1;
        public Form1()
        {

            InitializeComponent();
            init_label();
        }
        String contain;
        private void init_label() {
            int counter = 0;
            string line;
            string filename = "label.txt";
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    labellist.Items.Add(line);
                    counter++;
                }

                file.Close();
            }
            else {
                MessageBox.Show("label not exit");
                File.Create(filename);
            }
        }
        private void update_label() {
            string filename = "label.txt";
            StreamWriter file = new StreamWriter(filename);
            foreach (string item in labellist.Items) {
                //MessageBox.Show(item.ToString());
                file.WriteLine(item.ToString());
            }
            file.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String stFilter = "JPG(*.jpg)|*.jpg";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFileDialog1.FileName;
            }
        }
        private void open_dir_Click(object sender, EventArgs e)
        {
            index = -1;
            //DialogResult result = folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files=Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                for (int i = 0; i < files.Length; i++) {
                    listBox1.Items.Add(files[i]);
                }
                label3.Text = files.Length.ToString();
                index = 0;
                label1.Text = (index+1).ToString();
                try
                {
                    listBox1.SetSelected(index, true);
                    pictureBox1.BackgroundImage = Image.FromFile(files[0]);
                }
                catch {
                    MessageBox.Show("File not found");
                }
                
            }
        }
        string previous_img=null;
        string now_img = null;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            if (previous_img == null)
            {
                previous_img = listBox1.GetItemText(listBox1.SelectedItem).ToString().Split('.')[0];
                now_img = previous_img;
            }
            else {
                previous_img = now_img;
                now_img =listBox1.GetItemText(listBox1.SelectedItem).ToString().Split('.')[0];
            }
            if (autosave.Checked)
            {
                if (voccb.Checked)
                {
                    save_xml_bbox(previous_img);
                }
                if (yolocb.Checked)
                {
                    save_yolo_bbox(previous_img);
                }
            }
            clear_box();
            label1.Text = (index + 1).ToString();
            string curItem = listBox1.SelectedItem.ToString();
            pictureBox1.BackgroundImage = Image.FromFile(listBox1.GetItemText(listBox1.SelectedItem));
            clear_box();
            if (autoload.Checked)
            {
                if (yolocb.Checked)
                {
                    load_yolo_box();
                }
                else if (voccb.Checked)
                {
                    //load_xml_box();
                }
            }
        }

        private void next_img_Click(object sender, EventArgs e)
        {
            try
            {
                index++;
                listBox1.SetSelected(index, true);
            }
            catch {
                index--;
                MessageBox.Show("end of list");
            }
        }

        private void pre_img_Click(object sender, EventArgs e)
        {
            try
            {
                index--;
                listBox1.SetSelected(index, true);
            }
            catch
            {
                index++;
                MessageBox.Show("head of list");
            }
        }

        private void addlabel_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (string.IsNullOrEmpty(a) == true)
            {
                MessageBox.Show("Null");
            }
            else if (labellist.FindString(a)!=-1) {
                MessageBox.Show("Already exit");
                textBox1.Clear();
            }
            else {
                labellist.Items.Add(a);
                textBox1.Clear();
            }
            update_label();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.D)
            {
                try
                {
                    index++;
                    listBox1.SetSelected(index, true);
                }
                catch
                {
                    index--;
                    MessageBox.Show("end of list");
                }
            }
            else if ( e.KeyCode == Keys.A )
            {
                try
                {
                    index--;
                    listBox1.SetSelected(index, true);
                }
                catch
                {
                    index++;
                    MessageBox.Show("head of list");
                }
            }
        }

        private void labellist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = labellist.SelectedItem.ToString();
            textBox1.Text = curItem;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int n = labellist.SelectedIndex;
            labellist.Items.RemoveAt(n);
            update_label();
        }
        int x, y;
        bool first_click = false;
        List<Label> bboxes = new List<Label>();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Select();
            first_click = !first_click;
            if (Int32.Parse(label1.Text) < 1) {
                MessageBox.Show("please select image");
                first_click = !first_click;
                return;
            }
            else if (first_click)
            {
                x = e.X;
                y = e.Y;
                Label bbox = new Label();
                bboxes.Add(bbox);
                bbox.Show();
                bbox.BringToFront();
                bbox.BackColor = Color.FromArgb(30, 255, 0, 100); ;
                pictureBox1.Controls.Add(bbox);
                bbox.SetBounds(x, y, 0, 0);
            }
            else {
                try
                {
                    bboxes.Last().Text = labellist.SelectedItem.ToString();
                }
                catch {
                    MessageBox.Show("please select label");
                    bboxes.Last().Dispose();
                    bboxes.Remove(bboxes.Last());
                }
                
            }
        }

        private void bbox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (first_click)
            {
                int w = e.X - x;
                int h = e.Y - y;
                bboxes.Last().SetBounds(x, y, w, h);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            save_yolo_bbox(listBox1.SelectedItem.ToString().Split('.')[0]);
            save_xml_bbox(listBox1.SelectedItem.ToString().Split('.')[0]);
        }
        private void clear_box() {
            foreach (Label bbox in bboxes)
            {
                bbox.Dispose();
            }
            bboxes.Clear();
        }
        private void load_yolo_box() {
            if (File.Exists(listBox1.SelectedItem.ToString().Split('.')[0]+".txt")) {
                //MessageBox.Show("file exits");
                int counter = 0;
                string line;
                StreamReader file =new StreamReader(listBox1.SelectedItem.ToString().Split('.')[0] + ".txt");
                while ((line = file.ReadLine()) != null)
                {
                    //MessageBox.Show(line);
                    Label bbox = new Label();
                    bboxes.Add(bbox);
                    bbox.Show();
                    bbox.BringToFront();
                    bbox.BackColor = Color.FromArgb(30, 255, 0, 100); ;
                    pictureBox1.Controls.Add(bbox);
                    string label = labellist.Items[int.Parse(line.Split(' ')[0])].ToString();
                    bbox.Text = label;
                    double w = double.Parse(line.Split(' ')[3])*pictureBox1.Width;
                    double h = double.Parse(line.Split(' ')[4]) * pictureBox1.Height;
                    double x = double.Parse(line.Split(' ')[1]) * pictureBox1.Width - w / 2;
                    double y = double.Parse(line.Split(' ')[2]) * pictureBox1.Height - h / 2;
                    bbox.SetBounds((int)x, (int)y, (int)w, (int)h);
                    counter++;
                }

                file.Close();
            }
        }
        private void save_yolo_bbox(string savename) {
            //string filename = listBox1.SelectedItem.ToString().Split('.')[0]+".txt";
            StreamWriter file = new StreamWriter(savename + ".txt");
            foreach (Label bbox in bboxes)
            {
                //MessageBox.Show(item.ToString());
                double xc = ((double)bbox.Location.X + (double)bbox.Width/ (double)2) / (double)pictureBox1.Width;
                double yc = ((double)bbox.Location.Y + (double)bbox.Height / (double)2) / (double)pictureBox1.Height;
                double w = (double)bbox.Width / (double)pictureBox1.Width;
                double h = (double)bbox.Height / (double)pictureBox1.Height;
                file.Write(labellist.Items.IndexOf(bbox.Text));
                file.Write(" ");
                file.Write(xc);
                file.Write(" ");
                file.Write(yc);
                file.Write(" ");
                file.Write(w);
                file.Write(" ");
                file.WriteLine(h);
            }
            file.Close();
            //MessageBox.Show("Save YOLO file");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            load_yolo_box();
        }

        private void save_xml_bbox(string savename) {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("annotation");
            document.AppendChild(root);
            XmlElement filename = document.CreateElement("filename");
            Image img = System.Drawing.Image.FromFile(listBox1.SelectedItem.ToString());
            filename.InnerText = listBox1.SelectedItem.ToString().Split('\\').Last();
            root.AppendChild(filename);
            XmlElement size = document.CreateElement("size");
            root.AppendChild(size);
            XmlElement width = document.CreateElement("width");
            width.InnerText = img.Width.ToString();
            size.AppendChild(width);
            XmlElement height = document.CreateElement("height");
            height.InnerText = img.Height.ToString();
            size.AppendChild(height);
            XmlElement depth = document.CreateElement("depth");
            depth.InnerText = "3";
            size.AppendChild(depth);
            double x_factor = (double)img.Width / (double)pictureBox1.Width;
            double y_factor = (double)img.Height / (double)pictureBox1.Height;
            foreach (Label bbox in bboxes) {
                XmlElement obj = document.CreateElement("object");
                root.AppendChild(obj);
                XmlElement name = document.CreateElement("name");
                name.InnerText=bbox.Text;
                obj.AppendChild(name);
                XmlElement bndbox = document.CreateElement("bndbox");
                obj.AppendChild(bndbox);
                XmlElement xmin = document.CreateElement("xmin");
                xmin.InnerText = Math.Round(bbox.Location.X*x_factor).ToString();
                bndbox.AppendChild(xmin);
                XmlElement ymin = document.CreateElement("ymin");
                ymin.InnerText = Math.Round(bbox.Location.Y*y_factor).ToString();
                bndbox.AppendChild(ymin);
                XmlElement xmax= document.CreateElement("xmax");
                xmax.InnerText = Math.Round((bbox.Location.X + bbox.Width)*x_factor).ToString();
                bndbox.AppendChild(xmax);
                XmlElement ymax =document.CreateElement("max");
                ymax.InnerText = Math.Round((bbox.Location.Y + bbox.Height)*y_factor).ToString();
                bndbox.AppendChild(ymax);
            }
            //MessageBox.Show("Save VOC file");
            document.Save(savename+ ".xml");

        }
    }
}
