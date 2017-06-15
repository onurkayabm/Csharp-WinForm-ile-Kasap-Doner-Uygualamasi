using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    class Helper
    {
        // siparis tamamlandıktan sonra formun ve group boxın ögelerini temizle
        #region SiparisiTamamlaveKontrolleriTemizle

        public void SiparisiTamamlaveKontrolleriTemizle(GroupBox grpb)
        {
            foreach (Control item in grpb.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    SiparisiTamamlaveKontrolleriTemizle(grp);
                }
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = false;
                }
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }

                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nmrc = item as NumericUpDown;
                    nmrc.Value = 1;
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.SelectedIndex = -1;
                }
                if (item is ListBox)
                {
                    ListBox lst = item as ListBox;
                    lst.Items.Clear();
                }

            }


        }
        public void SiparisiTamamlaveKontrolleriTemizle(FormAna frmAna)
        {
            foreach (Control item in frmAna.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    SiparisiTamamlaveKontrolleriTemizle(grp);
                }
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = false;
                }
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }

                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nmrc = item as NumericUpDown;
                    nmrc.Value = 1;
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.SelectedIndex = -1;
                }
                if (item is ListBox)
                {
                    ListBox lst = item as ListBox;
                    lst.Items.Clear();
                }

            }


        }
        #endregion

        //Listboxa ekleme yapılınca formun ve group boxun gerekli ögelerini temizle
        #region EkleveKontrolleriTemizle
        public void EkleveKontrolleriTemizle(GroupBox grpb)
        {


            foreach (Control item in grpb.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = false;
                }
                if (item is GroupBox)
                {
                    GroupBox grp2 = item as GroupBox;
                    EkleveKontrolleriTemizle(grp2);


                }
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }

                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nmrc = item as NumericUpDown;
                    nmrc.Value = 1;
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }

                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.SelectedIndex = -1;
                }


            }

        }
        public void EkleveKontrolleriTemizle(FormAna frmAna)
        {


            foreach (Control item in frmAna.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = false;
                }
                if (item is GroupBox)
                {
                    GroupBox grp2 = item as GroupBox;
                    EkleveKontrolleriTemizle(grp2);


                }
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }

                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nmrc = item as NumericUpDown;
                    nmrc.Value = 1;
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.SelectedIndex = -1;
                }


            }

        }
        #endregion


    }
}
