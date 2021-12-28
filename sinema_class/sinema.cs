using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema_class
{
    class sinema
    {
        public int makskoltuk = 0, koltuk = 0, kasa = 0;
        public bool biletsatindirim = false, biletiptalindirim = false;

        public void biletsat()
        {
            if (koltuk != 0)
            {
                if (biletsatindirim == true)
                {
                    kasa = kasa + 10;
                    koltuk = koltuk - 1;
                }
                else
                {
                    kasa = kasa + 20;
                    koltuk = koltuk - 1;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Hata! Bütün Koltuklar Doludur, Bilet Satılamaz");
            }
        }

        public void biletiptalet()
        {
            if (koltuk < makskoltuk)
            {

                if (biletiptalindirim == true)
                {
                    kasa = kasa - 10;
                    koltuk = koltuk + 1;
                }
                else
                {
                    kasa = kasa - 20;
                    koltuk = koltuk + 1;
                } 
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Hata! Bütün Koltuklar Doludur, Bilet Satılamaz");
            }

        }
    }
}

    
