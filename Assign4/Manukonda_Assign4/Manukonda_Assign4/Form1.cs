/* Assignment 4
 * Group Members : Kiranmayi manukonda, Sai Kiran Vunnam, Gopal Sai Uppalapati
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manukonda_Assign4
{

    public partial class Form1 : Form
    {
        private Stack<Image> _undoStack = new Stack<Image>(); //to store images of undo stack
        private Stack<Image> _redoStack = new Stack<Image>();  //to store images of redo stack
        // private object rect;
        private readonly object _undoRedoLocker = new object();
        Graphics g;  //graphics object
        Bitmap bmp;  //to store the image
        string f;  
        private int rc = 0, uc = 0;  
        bool down = false;  //default value for down
        Pen p = new Pen(Color.Black, 1);  //to set the pen object
        Point start = new Point(0, 0);   //starting point
        Point end = new Point(0, 0);    //ending point
        
        int k = 0;
        string drawtool;   //drawing tool
        public string Filename;
        
       // private object image;

        public Form1()
        {
            InitializeComponent();  //Initialize the form
            this.KeyPreview = true;
          
            bmp = new Bitmap(panel2.ClientRectangle.Width, panel2.ClientRectangle.Height);

            g = Graphics.FromImage(bmp);
            Rectangle r = panel2.RectangleToScreen(panel2.ClientRectangle);
            g.CopyFromScreen(r.Location, Point.Empty, panel2.Size);
            _undoStack.Push(bmp);
        }
      
        
        

       // public object Filename { get; private set; }

        //public string Filename { get; private set; }

            //function to undo
        private void Undo()
        {
            lock (_undoRedoLocker)
            {
                if (_undoStack.Count > 0)
                {

                    Image i = _undoStack.Pop();
                    _redoStack.Push(i);

                    //OnUndo();
                    panel2.BackgroundImage = _redoStack.Peek();
                   // canvas.Refresh();
                }
            }
        }


        //Function to redo
        private void Redo()
        {
            lock (_undoRedoLocker)
            {
                if (_redoStack.Count > 0)
                {
                    _undoStack.Push(_redoStack.Pop());

                    //OnRedo();
                    panel2.BackgroundImage = _undoStack.Peek();
                    //canvas.Refresh();
                }
            }
        }

        //Loading the dropdown for open recently
        private void loadDropDown()
        {
            using (StreamReader sr = new StreamReader("Filenames.txt"))
            {
                List<string> names = new List<string>();
                string name = sr.ReadLine();
                int i = 0;
                while (name != null)
                {
                    names.Add(name);
                    i++;
                    name = sr.ReadLine();
                }
              recent.DropDownItems.Clear();
                for(int j=names.Count-1;j>=names.Count-5;j--)
                {
                  recent.DropDownItems.Add(names[j]);
                }
            }
        }
        //And whenever image need to be modified, add it to the undo stack first and then modify it
    /*    private void UpdateImageData(Action updateImage)
        {
            lock (_undoRedoLocker)
            {
                _undoStack.Push(canvas.BackgroundImage);//image);

                try
                {
                    //manipulate the image here.
                    updateImage();
                }
                catch
                {
                    _undoStack.Pop();//because of exception remove the last added frame from stack
                    throw;
                }
            }
        }*/

        private void pen_Click_1(object sender, EventArgs e)
        {
            drawtool = "pen1";
        }
        private void eraser_Click(object sender, EventArgs e)
        {
            drawtool = "eraser1";
        }

        private void brush_Click(object sender, EventArgs e)
        {
            drawtool = "brush1";
        }

        private void drawline_Click(object sender, EventArgs e)
        {
            drawtool = "line";
        }

        private void black_Click(object sender, EventArgs e)
        {
            p.Color = ((PictureBox)sender).BackColor;
        }

        private void canvas_MouseDown_1(object sender, MouseEventArgs e)
        {
            start = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;
        }

        private void canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            switch (drawtool)
            {
                case "pen1":
                    if (k == 1)
                    {
                        end = e.Location;
                        g = panel2.CreateGraphics();
                        g.DrawLine(p, start, end);
                    }
                    start = end;
                    break;
                case "eraser1":
                    if (k == 1)
                    {
                        p = new Pen(Color.White, 8);
                        end = e.Location;
                        g = panel2.CreateGraphics();
                        g.DrawLine(p, start, end);
                    }
                    start = end;
                    break;
                case "brush1":
                    if (k == 1)
                    {
                        p.Width = 5;
                        end = e.Location;
                        g = panel2.CreateGraphics();
                        g.DrawLine(p, start, end);
                    }
                    start = end;
                    break;
              /*  case "line":
                    if (k == 1)
                    {
                        end = e.Location;
                        g = panel2.CreateGraphics();
                        g.DrawLine(p, start.X, start.Y, end.X, end.Y);
                    }
                    start = end;
                    break;*/
            }
        }

        private void canvas_MouseUp_1(object sender, MouseEventArgs e)
        {
            k = 0;
            down = false;
            end = e.Location;
            if(drawtool == "line")
            {
                g = panel2.CreateGraphics();
                g.DrawLine(p, start, end);
            }
            Bitmap bmp = new Bitmap(panel2.ClientRectangle.Width, panel2.ClientRectangle.Height);
            Graphics gm = Graphics.FromImage(bmp);
            Rectangle r = panel2.RectangleToScreen(panel2.ClientRectangle);
            gm.CopyFromScreen(r.Location, Point.Empty, panel2.Size);
            _undoStack.Push(bmp);

        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(Filename == null)
            {
                toolStripButton2_Click(sender, e);
            }
            else
            {
                Bitmap bmp = new Bitmap(panel2.ClientRectangle.Width, panel2.ClientRectangle.Height);
                Graphics G = Graphics.FromImage(bmp);
                Rectangle r = panel2.RectangleToScreen(panel2.ClientRectangle);
                G.CopyFromScreen(r.Location, Point.Empty, panel2.Size);

                bmp.Save(Filename, ImageFormat.Png);      
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saved = new SaveFileDialog()
            {
                Title = "Save File",
                Filter = "png files (*.png)|*.png"
            };
            if(saved.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panel2.ClientRectangle.Width, panel2.ClientRectangle.Height);
                Graphics G = Graphics.FromImage(bmp);
                Rectangle r = panel2.RectangleToScreen(panel2.ClientRectangle);
                G.CopyFromScreen(r.Location, Point.Empty, panel2.Size);
                Filename = saved.FileName;
               bmp.Save(Filename, ImageFormat.Png);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "Browse",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Png Files(*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image.GetThumbnailImageAbort myCallb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    Bitmap mb = new Bitmap(dlg.FileName);
                    Image myt = mb.GetThumbnailImage(300, 300, myCallb, IntPtr.Zero);
                    panel2.BackgroundImage = myt;
                    panel2.BackgroundImageLayout = ImageLayout.Stretch;
                    Filename = dlg.FileName;
                    f = Filename;
                    Console.WriteLine(dlg.FileName);
                    using (StreamWriter sr = new StreamWriter("Filenames.txt", true))
                    {
                        sr.WriteLine(dlg.FileName);
                    }
                    loadDropDown();
                    Filename = dlg.FileName;
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Undo();
            rc = 0;
            if(uc == 0)
            {
                Undo();
                uc++;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Redo();
            uc = 0;
            if (rc == 0)
            {
                Redo();
                rc++;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            Image.GetThumbnailImageAbort mycallb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Console.WriteLine(e.ClickedItem.Text);
            Bitmap myb = new Bitmap(e.ClickedItem.Text);
            Image myt = myb.GetThumbnailImage(300, 300, mycallb, IntPtr.Zero);
            panel2.BackgroundImage = myt;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            Filename = e.ClickedItem.Text;

        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            int check = 0;
           if(Filename == null)
            {
                const string message = "Are You Sure that you would like to quit without saving?";
                const string capt = "Save File Before Closing";
                var r = MessageBox.Show(message, capt, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.OK)
                {
                    toolStripButton2_Click(sender, e);
                }
            }
            else
            {
                const string message = "Are You Sure that you would like to quit without saving?";
                const string capt = "Save File Before Closing";
                var r = MessageBox.Show(message, capt, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.No)
                {
                    toolStripButton1_Click(sender, e);
                }
            }
            if(check ==1)
            {
                DialogResult dr = MessageBox.Show("File is Saved Successfully.", "Message", MessageBoxButtons.OK);
            }
            panel2.BackgroundImage = null;
            panel2.Refresh();
            _undoStack.Clear();
            _redoStack.Clear();
            this.Refresh();
            Application.DoEvents();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = null;
            panel2.Refresh();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if(r == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
            if(e.Control == true &&e.KeyCode == Keys.Z)
            {
                Undo();
                rc = 0;
                if(uc == 0)
                {
                    Undo();
                    uc++;
                }
            }
            else if(e.Control == true && e.KeyCode == Keys.X)
            {
                Redo();
                uc = 0;
                if(rc ==0)
                {
                    Redo();
                    rc++;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDropDown();
            drawtool = "pen1";
        }



        /*   private void pictureBox1_MouseClick(object sender, EventArgs e)
           {
               UpdateImageData(delegate ()
               {
                   rect.Width = 0;
                   rect.Height = 0;
                   pictureBox1.Invalidate();

                   int radius = 10; //Set the number of pixel you want to use here
                                    //Calculate the numbers based on radius
                   int x0 = Math.Max(e.X - (radius / 2), 0),
                       y0 = Math.Max(e.Y - (radius / 2), 0),
                       x1 = Math.Min(e.X + (radius / 2), pictureBox1.Width),
                       y1 = Math.Min(e.Y + (radius / 2), pictureBox1.Height);
                   Bitmap bm = pictureBox1.Image as Bitmap; //Get the bitmap (assuming it is stored that way)
                   for (int ix = x0; ix < x1; ix++)
                   {
                       for (int iy = y0; iy < y1; iy++)
                       {
                           bm.SetPixel(ix, iy, Color.Black); //Change the pixel color, maybe should be relative to bitmap
                       }
                   }
                   pictureBox1.Refresh(); //Force refresh
               }
           }
           */
    }
        }
 
