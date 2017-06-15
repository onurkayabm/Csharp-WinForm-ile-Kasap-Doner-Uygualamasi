using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FormAna : Form
    {
        /* Form açıldığın Hesapla butonu aktif olarak gelicek.Diğerleri pasif ve duruma göre aktif olacak
         * Form açıldığında menü seçildikten sonra menüye göre groupbox ekleyecek
         * Hesapla butonuna tıkladıktan sonra hesaplayip ekle butonu aktif hale gelecek          
         *Ekle butonuna tıklanınca Seçilen menü ekstralar adet ve fiyatla birlikte listboxa eklenecek ve gerekli kontroller temizlenecek
         *Siparişi tamamla butonuna tıklanınca listboxtaki bütün siparişler toplanacak kullanıcıya gösterilip bütün controller temizlenecek
         */



        #region Global Değişkenler
        Helper help = new Helper();
        EtMenu et;
        TavukMenu tavuk;
        string seciliCheckBox = "";
        double siparisToplamTutar = 0;
        #endregion


        public FormAna()
        {
            InitializeComponent();
        }

        //form yüklenirken comboboxı doldur
        private void ComboBoxDoldur()
        {
            et = new EtMenu();
            tavuk = new TavukMenu();


            cmbMenuler.Items.Add(et.etMenuUret("Et menü", 20));
            cmbMenuler.Items.Add(tavuk.tavukMenuUret("Tavuk Menü", 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form yüklenirken gerekli butonları false yap 
            btnEkle.Enabled = false;
            btnSiparisler.Enabled = false;

            ComboBoxDoldur();

            
        }

       //comboboxın itemi değiştikçe ona göre menülerini groupboxa yükle
        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenuler.SelectedIndex==0)
            {
                grpExtra.Controls.Clear();
                et.Extralar(grpExtra);
            }
            else if (cmbMenuler.SelectedIndex==1)
            {
                grpExtra.Controls.Clear();
                tavuk.Extralar(grpExtra);
            }
        }

        //İstenilen menünün fiyatını hesapla
        private void Hesapla()
        {
            double geneltoplam = 0;
            if (cmbMenuler.SelectedIndex == 0) // Eğer seçilen menü etse
            {
                double toplam = 0;
                double menuFiyati = ((EtMenu)cmbMenuler.SelectedItem).Fiyat;// fiyatını al
                if (rdbTam.Checked) // eğer tam porsiyon seçildiyse
                {
                    foreach (CheckBox item in grpExtra.Controls)
                    {
                        if (item.Checked)
                        {
                            toplam += (double)item.Tag; // seçili extra malzemelerin fiyatlarını topla
                            seciliCheckBox = seciliCheckBox + "" + item.Text; // seçili extra malzemelerin adlarını yaz
                        }
                    }

                }
                else if (rdbYarim.Checked) // eğer yarım porsiyon seçildiyse
                {
                    menuFiyati = menuFiyati / 2; // 
                    foreach (CheckBox item in grpExtra.Controls)
                    {
                        if (item.Checked)
                        {
                            toplam += (double)item.Tag; // seçili extra malzemelerin fiyatlarını topla

                            seciliCheckBox = seciliCheckBox + "" + item.Text; // seçili extra malzemelerin adlarını yaz


                        }

                    }

                }
                if (rdbTam.Checked == false && rdbYarim.Checked == false) // eğer ikiside seçili değilse messaj göster
                {
                    MessageBox.Show("Lütfen porsiyon giriniz");
                }
                else
                {

                    double adet = (double)nmcAdet.Value;
                    geneltoplam = toplam + menuFiyati * adet; //Menünün fiyatını hesapla
                    txtTutar.Text = geneltoplam.ToString();

                }


            }

            else if (cmbMenuler.SelectedIndex == 1) // eğer seçili item tavuk menüyse işlemleri yap
            {
                double toplam = 0;
                double menuFiyati = ((TavukMenu)cmbMenuler.SelectedItem).Fiyat;
                if (rdbTam.Checked)
                {
                    foreach (CheckBox item in grpExtra.Controls)
                    {
                        if (item.Checked)
                        {
                            toplam += (double)item.Tag;
                           
                            seciliCheckBox = seciliCheckBox + "" + item.Text;
                          

                        }
                    }

                }
                else if (rdbYarim.Checked)
                {
                    menuFiyati = menuFiyati / 2;
                    foreach (CheckBox item in grpExtra.Controls)
                    {
                        if (item.Checked)
                        {
                            toplam += (double)item.Tag;

                            seciliCheckBox = seciliCheckBox + "" + item.Text;


                        }

                    }

                }
                if (rdbTam.Checked == false && rdbYarim.Checked == false)
                {
                    MessageBox.Show("Lütfen porsiyon giriniz");
                }
                else
                {

                    double adet = (double)nmcAdet.Value;
                    geneltoplam = toplam + menuFiyati * adet;
                    txtTutar.Text = geneltoplam.ToString();

                }


            }

            else
            {
                MessageBox.Show("Menü giriniz");
            }

        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
            btnEkle.Enabled = true;
        }


        // istenilen menüyü list boxa ekle
        private void ListBoxEKle()
        {
            if (cmbMenuler.SelectedIndex == 0)
            {
                string menuAdi = ((EtMenu)cmbMenuler.SelectedItem).Ad;


                if (rdbTam.Checked)
                {
                    lstSiparisler.Items.Add(menuAdi + " (" + seciliCheckBox + ") " + rdbTam.Text + " " + nmcAdet.Value + " Adet" + "--" + txtTutar.Text + " TL ");
                    siparisToplamTutar += double.Parse(txtTutar.Text);
                }
                else
                {
                    lstSiparisler.Items.Add(menuAdi + " (" + seciliCheckBox + ") " + rdbYarim.Text + " " + nmcAdet.Value + " Adet" + "--" + txtTutar.Text + " TL ");
                    siparisToplamTutar += double.Parse(txtTutar.Text);
                }
                seciliCheckBox = "";
            }
            else if (cmbMenuler.SelectedIndex == 1)
            {
                string menuAdi = ((TavukMenu)cmbMenuler.SelectedItem).Ad;


                if (rdbTam.Checked)
                {
                    lstSiparisler.Items.Add(menuAdi + " (" + seciliCheckBox + ") " + rdbTam.Text + " " + nmcAdet.Value + " Adet" + "--" + txtTutar.Text + " TL ");
                    siparisToplamTutar += double.Parse(txtTutar.Text);
                }
                else
                {
                    lstSiparisler.Items.Add(menuAdi + " (" + seciliCheckBox + ") " + rdbYarim.Text + " " + nmcAdet.Value + " Adet" + "--" + txtTutar.Text + " TL ");
                    siparisToplamTutar += double.Parse(txtTutar.Text);
                }
                seciliCheckBox = "";
            }


        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListBoxEKle();
            help.EkleveKontrolleriTemizle(this);
            btnHesapla.Enabled = true;
            btnSiparisler.Enabled = true;
            
        }


        //siparişi tamamlayınca gerekli işlemleri yap
        private void SiparislerGetir()
        {
            MessageBox.Show("Toplam ödenecek tutar " + siparisToplamTutar.ToString() + " TL");
            help.SiparisiTamamlaveKontrolleriTemizle(this);
            btnHesapla.Enabled = true;
            siparisToplamTutar = 0;

        }
        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            SiparislerGetir();
           
        }
    }
}
