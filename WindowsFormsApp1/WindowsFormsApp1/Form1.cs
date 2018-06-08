using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] i1 = new string[] { " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ч", "ц", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", ",", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", ".", "?", "!", ";", ":", "[", "]", "{", "}", "(", ")", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "_", "=", "+", "-", "/", "*", "", "'", "&", "^", "%", "$", "#", "@", "№", "~", "`", " " };
        int[] R = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] G = new int[] { 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 200, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 202, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 203, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 206, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 207, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 208, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 209, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 210, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 211, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 212, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 213, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 214, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215, 215};
        int[] B = new int[] { 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215};
        
        private void Form1_Load(object sender, EventArgs e)
        {
             }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        Bitmap image1;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            image1 = new Bitmap(100, 100);
            int x2, y2;
            Random rnd = new Random();
            //Color pixelColor = image1.GetPixel(x2, y2);
            
            for (x2 = 0; x2 < 100; x2++)
            
            {
                for (y2 = 0; y2 < 100; y2++)
                {
                    Color newColor = Color.FromArgb(255, 1, rnd.Next(200, 215), rnd.Next(200, 215));
                    image1.SetPixel(x2, y2, newColor);
                }
            }
            pictureBox1.Image = image1;
            
            string shifr = textBox2.Text;
            string x11 = shifr.Substring(0, 2);
            string y11 = shifr.Substring(2, 2);
            string np1 = shifr.Substring(4, 2);
            string ds1 = shifr.Substring(6, 2);

            int x1 = Convert.ToInt32(x11);
            int y1 = Convert.ToInt32(y11);
            int np = Convert.ToInt32(np1);
            int ds = Convert.ToInt32(ds1);

            string text = textBox1.Text;
            int dt = text.Length;
            int xz;
            int q = 0;
            //textBox1.Text = x1;

            

            try
            {
            if (np == 23)
            {
                xz = x1;
                while (q<dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j <= 158; j++)
                        {
                            if (Convert.ToString(text[i])==Convert.ToString(i1[j]))
                            {
                                Color nwColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, nwColor);
                                x1++;
                                if (x1 >= ds + xz)
                                {
                                    x1 = xz;
                                    y1++;
                                }
                                q++;
                            }
                        }
                    }
                }
            }

            if (np == 32)
            {
                xz = y1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                y1++;
                                if (y1 >= ds + xz)
                                {
                                    y1 = xz;
                                    x1++;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 34)
            {
                xz = y1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                y1++;
                                if (y1 >= ds + xz)
                                {
                                    y1 = xz;
                                    x1--;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 43)
            {
                xz = x1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                x1--;
                                if (x1 <= xz - ds)
                                {
                                    x1 = xz;
                                    y1++;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 41)
            {
                xz = x1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                x1--;
                                if (x1 <= xz - ds)
                                {
                                    x1 = xz;
                                    y1--;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 14)
            {
                xz = y1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                y1--;
                                if (y1 <= xz - ds)
                                {
                                    y1 = xz;
                                    x1--;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 12)
            {
                xz = y1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                y1--;
                                if (y1 <= xz - ds)
                                {
                                    y1 = xz;
                                    x1++;
                                }
                                q++;
                            }
                        }
                    }
                }

            }

            if (np == 21)
            {
                xz = x1;
                while (q < dt)
                {
                    for (int i = 0; i < dt; i++)
                    {
                        for (int j = 0; j < 158; j++)
                        {
                            if (Convert.ToString(text[i]) == Convert.ToString((i1[j])))
                            {
                                Color newColor = Color.FromArgb(255, R[j], G[j], B[j]);
                                image1.SetPixel(x1, y1, newColor);
                                x1++;
                                if (x1 >= ds + xz)
                                {
                                    x1 = xz;
                                    y1--;
                                }
                                q++;
                            }
                        }
                    }
                }

            } 
                
            }
            catch (Exception)
            {
               // MessageBox.Show("Введены не верные данные");
               
            }

           pictureBox1.Image = image1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap imga = new Bitmap(pictureBox1.Image);
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //int width = Convert.ToInt32(pictureBox1.Image.Width);
                //int height = Convert.ToInt32(pictureBox1.Image.Height);
               // Bitmap bmp = new Bitmap(width, height);
                //DrawToBitmap(image1, new Rectangle(0, 0, width, height));
                imga.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }






            /*  SaveFileDialog saveFileDialog1 = new SaveFileDialog();

              saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
              saveFileDialog1.FilterIndex = 2;
              saveFileDialog1.RestoreDirectory = true;

              if (saveFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  if ((pictureBox1.Image = saveFileDialog1.OpenFile()) != null)
                  {
                      // Code to write the stream goes here.
                      myStream.Close();
                  }
              } */
        }

        

         private void button6_Click(object sender, EventArgs e)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureBox1.Image = img;
                    }
                }

        private void button7_Click(object sender, EventArgs e)
        {
            string shifr = textBox2.Text;
            string x11 = shifr.Substring(0, 2);
            string y11 = shifr.Substring(2, 2);
            string np1 = shifr.Substring(4, 2);
            string ds1 = shifr.Substring(6, 2);

            int x1 = Convert.ToInt32(x11);
            int y1 = Convert.ToInt32(y11);
            int np = Convert.ToInt32(np1);
            int ds = Convert.ToInt32(ds1);

            string text = "";
            //int dt = text.Length;
            int xz;
            int q = 0;
            //textBox1.Text = x1;
            int i = 0;

            Bitmap img = new Bitmap(pictureBox1.Image);

            try
            {
                if (np == 23)
                {
                    xz = x1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }
                        x1++;
                        if (x1 >= ds + xz)
                        {
                            x1 = xz;
                            y1++;
                        }
                        i++;
                    }
                }

                if (np == 32)
                {
                    xz = y1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }

                        y1++;
                        if (x1 >= ds + xz)
                        {
                            y1 = xz;
                            x1++;
                        }
                        i++;
                    }
                }

                if (np == 34)
                {
                    xz = y1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }

                        y1++;
                        if (x1 >= ds + xz)
                        {
                            y1 = xz;
                            x1--;
                        }
                        i++;
                    }
                }

                if (np == 43)
                {
                    xz = x1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }

                        x1--;
                        if (x1 <= xz - ds)
                        {
                            x1 = xz;
                            y1++;
                        }
                        i++;
                    }
                }

                if (np == 41)
                {
                    xz = x1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }

                        x1--;
                        if (x1 <= xz - ds)
                        {
                            x1 = xz;
                            y1--;
                        }
                        i++;
                    }
                }

                if (np == 14)
                {
                    xz = y1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                        }

                        y1--;
                        if (x1 >= xz - ds)
                        {
                            y1 = xz;
                            x1--;
                        }
                        i++;
                    }
                }

                if (np == 12)
                {
                    xz = y1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                            x1++;
                        }

                        y1--;
                        if (x1 >= xz - ds)
                        {
                            x1 = xz;
                            y1++;
                        }
                        i++;
                    }
                }

                if (np == 21)
                {
                    xz = x1;
                    while (i <= 126)
                    {
                        Color nColor = img.GetPixel(x1, y1);
                        byte r1 = nColor.R;
                        byte g1 = nColor.G;
                        byte b1 = nColor.B;
                        for (int j = 1; j <= 158; j++)
                        {
                            if ((r1 == R[j]) && (g1 == G[j]) && (b1 == B[j]))
                            {
                                text = text + i1[j];
                            }
                            x1++;
                        }

                        x1++;
                        if (x1 >= ds + xz)
                        {
                            x1 = xz;
                            y1--;
                        }
                        i++;
                    }
                }















                textBox1.Text = text;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
           
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button7.Visible = true;
            button5.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button5.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Image = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
