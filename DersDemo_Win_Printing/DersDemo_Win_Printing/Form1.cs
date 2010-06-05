using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using DersDemo_Win_Printing.DataLayer.NWDataSetTableAdapters;
using DersDemo_Win_Printing.Resources.Classes;

namespace DersDemo_Win_Printing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sayfaYapısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();

        }

        private void baskıÖnİzlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        protected double sayfaNo = 1, toplamSayfa = 10;
        private List<ProductClass> Veriler { get; set; }
        private Dictionary<string, float> KolonGenislikleri =
            new Dictionary<string, float>();
        private float satirYuksekligi;
        private readonly Font f = new Font("Verdana", 10f);

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            sayfaNo = 1;
            printLabel.Text = string.Empty;
            printLabel.Visible = true;
            printProgress.Value = int.Parse(sayfaNo.ToString());
            printProgress.Maximum = int.Parse(toplamSayfa.ToString());
            printProgress.Minimum = printProgress.Value;
            printProgress.Visible = true;


            //Veriler = new List<ProductClass>();

            using (ProductsTableAdapter ta =
                new ProductsTableAdapter())
            {
                var dt = ta.GetData();

                //Veriler = dt.Select(x => new ProductClass()
                //{
                //    ProductID = x.ProductID.ToString(),
                //    ProductName = x.ProductName,
                //    UnitPrice = x.UnitPrice.ToString(),
                //    UnitsInStock = x.UnitsInStock.ToString(),
                //    TotalPrice = x.TotalPrice.ToString()
                //}).ToList();


                Bitmap bm = new Bitmap(100, 100);
                Graphics g = Graphics.FromImage(bm);



                Veriler = (from x in dt
                           select new ProductClass()
                             {
                                 ProductID = x.ProductID.ToString(),
                                 ProductIDWidth = g.MeasureString(x.ProductID.ToString(), f).Width + 5,
                                 ProductName = x.ProductName,
                                 ProductNameWidth = g.MeasureString(x.ProductName, f).Width + 5,
                                 UnitPrice = x.UnitPrice.ToString("N2"),
                                 UnitPriceWidth = g.MeasureString(x.UnitPrice.ToString("N2"), f).Width + 5,
                                 UnitsInStock = x.UnitsInStock.ToString(),
                                 UnitsInStockWidth = g.MeasureString(x.UnitsInStock.ToString(), f).Width + 5,
                                 TotalPrice = x.TotalPrice.ToString("N2"),
                                 TotalPriceWidth = g.MeasureString(x.TotalPrice.ToString("N2"), f).Width + 5,
                             }).ToList();

                KolonGenislikleri.Clear();
                KolonGenislikleri.Add("ProductID",
                    g.MeasureString("Product ID ", f).Width + 5);

                KolonGenislikleri.Add("ProductName",
                    g.MeasureString("Product Name ", f).Width + 5);

                KolonGenislikleri.Add("UnitPrice",
                    g.MeasureString("Unit Price ", f).Width + 5);

                KolonGenislikleri.Add("UnitsInStock",
                    g.MeasureString("Units In Stock ", f).Width + 5);

                KolonGenislikleri.Add("TotalPrice",
                    g.MeasureString("Total Price ", f).Width + 5);

                float ff = Veriler.Max(x => x.ProductIDWidth);
                if (KolonGenislikleri["ProductID"] < ff)
                    KolonGenislikleri["ProductID"] = ff;

                ff = Veriler.Max(x => x.ProductNameWidth);
                if (KolonGenislikleri["ProductName"] < ff)
                    KolonGenislikleri["ProductName"] = ff;

                ff = Veriler.Max(x => x.UnitPriceWidth);
                if (KolonGenislikleri["UnitPrice"] < ff)
                    KolonGenislikleri["UnitPrice"] = ff;

                ff = Veriler.Max(x => x.UnitsInStockWidth);
                if (KolonGenislikleri["UnitsInStock"] < ff)
                    KolonGenislikleri["UnitsInStock"] = ff;

                ff = Veriler.Max(x => x.TotalPriceWidth);
                if (KolonGenislikleri["TotalPrice"] < ff)
                    KolonGenislikleri["TotalPrice"] = ff;

                satirYuksekligi =
                    g.MeasureString("ĞÖİçşŞÇygğ", f).Height;
            }

        }

        private void printDocument1_QueryPageSettings(
            object sender,
            QueryPageSettingsEventArgs e)
        {

        }

        private double sayfaSatirSayisi;
        private void printDocument1_PrintPage(
            object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            if (sayfaNo == 1)
            {
                sayfaSatirSayisi =
                   Math.Floor((e.MarginBounds.Height - g.MeasureString("1 / 10", f).Height - 6) / (satirYuksekligi + 2));

                sayfaSatirSayisi--;

                toplamSayfa = Math.Ceiling((double)Veriler.Count / sayfaSatirSayisi);
                printProgress.Maximum = int.Parse(toplamSayfa.ToString());

            }
            printLabel.Text =
                string.Format("{0}. sayfa hazırlanıyor.", sayfaNo);
            printProgress.Value = int.Parse(sayfaNo.ToString());
            Application.DoEvents();



            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Far;

            Font f2 = new Font(
                "Verdana", 10f, FontStyle.Italic);

            RectangleF rf = new RectangleF(
                e.MarginBounds.X, e.MarginBounds.Y,
                e.MarginBounds.Width, e.MarginBounds.Height);

            g.DrawString(
                string.Format("{0} / {1}", sayfaNo, toplamSayfa),
                f2,
                Brushes.Black,
                rf,
                sf);



            int baslangicno = int.Parse((sayfaSatirSayisi * (sayfaNo - 1)).ToString());
            int bitisno = int.Parse((baslangicno + sayfaSatirSayisi - 1).ToString());
            if (bitisno >= Veriler.Count)
            {
                bitisno = Veriler.Count - 1;
            }

            g.DrawRectangle(Pens.Gray, e.MarginBounds);

            Rectangle rc = new Rectangle();
            rc.X = e.MarginBounds.X;
            rc.Y = e.MarginBounds.Y;

            rc.Width = (int)Math.Ceiling(
                KolonGenislikleri.Sum(x => x.Value)) + 6;

            rc.X += (e.MarginBounds.Width - rc.Width) / 2;

            rc.Height = (int)Math.Ceiling(
                (bitisno - baslangicno + 2) * (satirYuksekligi + 2) + 1);

            g.DrawRectangle(Pens.Black, rc);

            PointF p1 = new PointF(), p2 = new PointF();

            p2.X = p1.X = rc.X + KolonGenislikleri["ProductID"];
            p1.Y = rc.Y;
            p2.Y = rc.Y + rc.Height;
            g.DrawLine(Pens.Black, p1, p2);

            p2.X = p1.X = p1.X + 1 + KolonGenislikleri["ProductName"];
            g.DrawLine(Pens.Black, p1, p2);

            p2.X = p1.X = p1.X + 1 + KolonGenislikleri["UnitPrice"];
            g.DrawLine(Pens.Black, p1, p2);

            p2.X = p1.X = p1.X + 1 + KolonGenislikleri["UnitsInStock"];
            g.DrawLine(Pens.Black, p1, p2);

            //p2.X = p1.X = p1.X + 1 + KolonGenislikleri["TotalPrice"];
            //g.DrawLine(Pens.Black, p1, p2);

            RectangleF rc1 = new RectangleF(),
                rc2 = new RectangleF(),
                rc3 = new RectangleF(),
                rc4 = new RectangleF(),
                rc5 = new RectangleF();

            rc1.X = rc.X + 1;
            rc1.Y = rc.Y + 1;
            rc1.Width = KolonGenislikleri["ProductID"];
            rc1.Height = satirYuksekligi;

            rc2.X = rc1.X + 1 + rc1.Width;
            rc2.Y = rc.Y + 1;
            rc2.Width = KolonGenislikleri["ProductName"];
            rc2.Height = satirYuksekligi;

            rc3.X = rc2.X + 1 + rc2.Width;
            rc3.Y = rc.Y + 1;
            rc3.Width = KolonGenislikleri["UnitPrice"];
            rc3.Height = satirYuksekligi;

            rc4.X = rc3.X + 1 + rc3.Width;
            rc4.Y = rc.Y + 1;
            rc4.Width = KolonGenislikleri["UnitsInStock"];
            rc4.Height = satirYuksekligi;

            rc5.X = rc4.X + 1 + rc4.Width;
            rc5.Y = rc.Y + 1;
            rc5.Width = KolonGenislikleri["TotalPrice"];
            rc5.Height = satirYuksekligi;

            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString("Product ID", f, Brushes.Black, rc1, sf);
            g.DrawString("Product Name", f, Brushes.Black, rc2, sf);
            g.DrawString("Unit Price", f, Brushes.Black, rc3, sf);
            g.DrawString("Units In Stock", f, Brushes.Black, rc4, sf);
            g.DrawString("Total Price", f, Brushes.Black, rc5, sf);

            p1.X = rc.X;
            p2.Y = p1.Y = rc1.Y + rc1.Height + 1;
            p2.X = rc.X + rc.Width;
            g.DrawLine(Pens.Black, p1, p2);

            for (int i = baslangicno; i <= bitisno; i++)
            {
                rc1.Y = rc2.Y = rc3.Y = rc4.Y = rc5.Y = p1.Y + 1;
                sf.Alignment = StringAlignment.Center;
                g.DrawString(Veriler[i].ProductID, f, Brushes.Black, rc1, sf);
                sf.Alignment = StringAlignment.Near;
                g.DrawString(Veriler[i].ProductName, f, Brushes.Black, rc2, sf);
                sf.Alignment = StringAlignment.Far;
                g.DrawString(Veriler[i].UnitPrice, f, Brushes.Black, rc3, sf);
                sf.Alignment = StringAlignment.Center;
                g.DrawString(Veriler[i].UnitsInStock, f, Brushes.Black, rc4, sf);
                sf.Alignment = StringAlignment.Far;
                g.DrawString(Veriler[i].TotalPrice, f, Brushes.Black, rc5, sf);

                if (i != bitisno)
                {
                    p2.Y = p1.Y = rc1.Y + rc1.Height + 1;
                    g.DrawLine(Pens.Black, p1, p2);
                }
            }

            sayfaNo++;
            e.HasMorePages = sayfaNo <= toplamSayfa;
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            printProgress.Visible =
                printLabel.Visible = false;
        }
    }
}
