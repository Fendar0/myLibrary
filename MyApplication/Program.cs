using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrary;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle();
            circ.radius = 3.0f;
            circ.center = new Vec2(4.0f, 4.0f);
            circ.color = new RGB(1.0f, 0.0f, 0.0f);

            myLibrary.Rectangle rect = new myLibrary.Rectangle();
            rect.min = new Vec2(5.0f, 4.0f);
            rect.max = new Vec2(8.0f, 9.0f);
            rect.color = new RGB(0.25f, 0.75f, 0.0f);

            Triangle tri = new Triangle();
            tri.a = new Vec2(0.0f, 0.0f);
            tri.b = new Vec2(0.0f, 6.0f);
            tri.c = new Vec2(6.0f, 0.0f);
            tri.color = new RGB(0.0f, 0.5f, 1.0f);

            Figure[] fig = new Figure[3];
            fig[0] = circ;
            fig[1] = rect;
            fig[2] = tri;


            RGB bg = new RGB(0.75f, 0.75f, 0.75f);

            int width = 256;
            int height = 256;

            float x0 = -1.0f;
            float y0 = -1.0f;
            float x1 = 10.0f;
            float y1 = 10.0f;

            int samp = 1000;


            Bitmap bmp = new Bitmap(width, height);
            Random rnd = new Random();

            PictureBox pic = new PictureBox();
            pic.Location = new Point(0, 0);
            pic.Size = new Size(width, height);
            pic.Image = bmp;

            Form frm = new Form();
            frm.ClientSize = new Size(width, height);
            frm.Controls.Add(pic);

            Timer tim = new Timer();
            tim.Enabled = true;

            tim.Tick += (sender, e) =>
            {
                Vec2 v = new Vec2();
                for (int i = 0; i < samp; i++)
                {
                    v.x = Interpolation.map((float)rnd.NextDouble(), 0.0f, 1.0f, x0, x1);
                    v.x = Interpolation.map((float)rnd.NextDouble(), 0.0f, 1.0f, y0, y1);

                    Figure f = null;
                    for (int j = 0; j < fig.Length; j++)
                        if (fig[j].test(v) == true)
                        {
                            f = fig[j];
                            break;
                        }
                    int x = (int)Interpolation.map(v.x, x0, x1, 0.0f, width - 1);
                    int y = (int)Interpolation.map(v.y, y0, y1, height - 1, 0.0f);

                    int c;
                    if (f == null) c = bg.toColor();
                    else c = f.color.toColor();
                    bmp.SetPixel(x, y, Color.FromArgb(c));
                }
                pic.Invalidate();
            };
            Console.ReadKey();
        }
    }
}
