using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PolicijskaUprava.Entiteti
{
    /*
       POLICAJAC_ID NUMBER PRIMARY KEY REFERENCES POLICAJAC(ID),
    KURS VARCHAR2(30),
    VESTINA VARCHAR2(30),
    DATUM_ZAVRSETKA_KURSA DATE,
    SERTIFIKAT VARCHAR2(20),
    DATUM_STICANJA_SERTIFIKATA DATE
*/
    public class P_za_vanredne_situacije : Policajac
    {

        public virtual string Kurs {  get; set; }
        public virtual string Vestina { get; set; }
        public virtual DateTime Datum_zavrsetka_kursa { get; set; }
        public virtual string Sertifikat {  get; set; }
        public virtual DateTime Datum_sticanja_sertifikata { get; set; }

        public P_za_vanredne_situacije() : base()
        {
            
            Kurs = string.Empty;
            Vestina = string.Empty;
            Sertifikat = string.Empty;
        }
        public override string ToString()
        {
            return base.ToString() + "Kurs: " + Kurs + "\nVestina:" + Vestina
                                   + "\nDatum zavrsetka kursa:" + Datum_zavrsetka_kursa
                                   + "\nSertifikat: " + Sertifikat
                                   + "\nDatum sticanja sertifikata:" + Datum_sticanja_sertifikata;
        }

    }
}
