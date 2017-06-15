using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    class EtMenu:Besin
    {
        private double _fiyat;
        public double Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                if (value >= 0)
                {
                    _fiyat = value;
                }

            }
        }

        //comboboxa menü ekleyebilmek için class tipinde metot
        public EtMenu etMenuUret(string ad, double fiyat)
        {
            EtMenu menu = new EtMenu();
            menu.Ad = ad;
            menu.Fiyat = fiyat;
            return menu;

        }

        //comboboxta menunun sadece isminin gözükmesi için tostringi ezdim
        public override string ToString()
        {
            return this.Ad;
        }

        // et menüye ait extralar
        public void Extralar(GroupBox grp) {
            int uzunluk = 10;
            int i = 0;
            int x = 25*(i+1);
            int y1 = 15;
            int y2 = 15;
            double[] extraFiyat = new double[10] { 1, 0.5, 0.5, 0.5, 1, 0.5, 0.5, 0.5, 1, 1 };
            string[] extraAd = new string[10] {"Kekik","Nane","Biber", "Soğan", "Barbekü", "Hardal", "Ketcap", "Mayonez", "Patates","Marul" };
            CheckBox[] chb=new CheckBox[uzunluk];

            for (i = 0; i < 10; i++) //checkboxları yukarıdaki dizilerdeki ad ve fiyata göre groupboxa ekledim
            {
                
                chb[i] = new CheckBox();
                chb[i].Name = "chb" + i.ToString();
                chb[i].Text = extraAd[i];
                chb[i].Tag = extraFiyat[i];


                if (i<5) // extraları yan yana sıralamak için location ayarlamalarını yaptım
                {
                    chb[i].Location = new System.Drawing.Point(x, y1);
                    y1 += 45;
                }
                if(i>=5)
                {
                    
                    chb[i].Location = new System.Drawing.Point(180, y2);
                    y2 += 45;
                }
                
                grp.Controls.Add(chb[i]);

            } 


        }
    }
}
