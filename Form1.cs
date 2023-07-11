using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 22118080003 Aleyna Benzer BM102
namespace _22118080003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int sayı;
        private void Fhesap()       //faktoriyel hesaplayan metot
        {
            try
        {
                int kontrol = Convert.ToInt32(textBoxsayı.Text);    //girilen değerin uygun olup olmadığını kontrol edilen yer
                if (textBoxsayı.Text.Equals(""))
                {
                    MessageBox.Show("Lütfen bir sayı girin.", "Hata");
                }
                else if (kontrol <= 0 || !textBoxsayı.Text.Any(Char.IsDigit))
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir tam sayı girin.", "Hata");
                }
                else
                {
                    sayı = Convert.ToInt32(textBoxsayı.Text);   //sayı uygunsa değişkene atanır ve işlemler yapılır
                    if (sayı == 1 || sayı == 0)             //kontrol ve sayı değişkenleri farklı çünkü değişiklik olınca overflow oluyormuş
                    {
                        label_F.Text = "1";
                    }
                    else
                    {
                        int fa = sayı;
                        for (int i = 1; i < sayı; i++)
                        {
                            fa = fa * i;
                        }
                        label_F.Text = Convert.ToString(fa);    //işlem sonucu faktoriyeli gösteren labelın texti olarak atanır
                    }
                }
        }
        catch (Exception e)     //sorun olursa yakalamak ve hata mesajı görmek için try-catch yapısı
        {
            MessageBox.Show(e.Message);
        }
        }

        private void Asal()     //asal sayı kontrolü yapan metot
        {
            try
            {
                int kontrol = Convert.ToInt32(textBoxsayı.Text);    //girişin uygunluğuna bakılır
                if (kontrol.Equals(""))
                {
                    MessageBox.Show("Lütfen bir sayı girin.", "Hata");
                }
                else if (kontrol <= 0 || !textBoxsayı.Text.Any(Char.IsDigit))
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir tam sayı girin.", "Hata");
                }
                else
                {
                    sayı = Convert.ToInt32(textBoxsayı.Text);
                    if (sayı == 1)
                    {
                        label_A.Text = "hayır";
                    }
                    else
                    {
                        int i;
                        int f = 0;
                        for (i = 2; i < sayı/2; i++)
                        {
                            if (sayı % i == 0)
                            {
                                f++;
                                break;
                            }
                        }
                        if (f != 0)
                        {
                            label_A.Text = "hayır";
                        }
                                                //işlem sonucu asal sayı kontrolünü gösteren labelın texti olarak atanır
                        else
                        {
                            label_A.Text = "evet";
                        }
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }


        private void Öncekis()
        {
            try
            {
                int kontrol = Convert.ToInt32(textBoxsayı.Text);        //girişin uygunluğuna bakılır

                if (kontrol.Equals(""))
                {
                    MessageBox.Show("Lütfen bir sayı girin.", "Hata");
                }
                else if (kontrol <= 0 || !textBoxsayı.Text.Any(Char.IsDigit))
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir tam sayı girin.", "Hata");
                }
                else
                {
                    sayı = Convert.ToInt32(textBoxsayı.Text);
                    int[] ö = new int[sayı-1];
                    for (int i = 1; i < sayı; i++)
                    {
                        ö[i - 1] = i;
                    }

                    string basılacak = "";
                    if (sayı == 1)
                    {
                        basılacak = "yok";
                    }
                    else
                    {
                        for (int j = 0; j < sayı - 1; j++)
                        {
                            basılacak += Convert.ToString(ö[j]) + ",";
                        }
                    }
                    label_S.Text = basılacak;   //metodun sonucu ilgili labelın text özelliği olarak atanır
                }
            }
            catch (Exception n)     //sorun olursa yakalamak ve hata mesajı görmek için try-catch yapısı
            {
                MessageBox.Show(n.Message);
            }
        }

        private void buttonfakto_Click(object sender, EventArgs e)
        {
            Fhesap();       //Faktöriyel butonuna tıklandığında Fhesap metodu çağırılır
        }

        private void buttonasal_Click(object sender, EventArgs e)
        {
            Asal();         //Asal mı butonuna tıklandığında Asal metodu çağırılır
        }

        private void buttonkendisinekadar_Click(object sender, EventArgs e)
        {
           Öncekis();       //ilgili butona tıklandığında Öncekis metodu çağırılır
        }
    }

    
}
