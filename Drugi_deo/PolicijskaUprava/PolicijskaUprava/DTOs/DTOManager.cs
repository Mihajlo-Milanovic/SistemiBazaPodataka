


namespace PolicijskaUprava.DTOs
{
    public class DTOManager
    {
        public static List<PolicajacView> vratiSvePolicajce()
        {
            List<PolicajacView> Policajci = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Policajac> sviPolicajci = s.CreateQuery("from Policajac").List<Policajac>();

                foreach (var p in sviPolicajci)
                {

                    if (p.GetType() == typeof(PatrolniPolicajac))
                    {
                        PatrolniPolicajacView policajac = new((PatrolniPolicajac)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(PolicajacPozornik))
                    {
                        PolicajacPozornikView policajac = new((PolicajacPozornik)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(RadnikUUpravi))
                    {
                        RadnikUUpraviView policajac = new((RadnikUUpravi)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(SkolskiPolicajac))
                    {
                        SkolskiPolicajacView policajac = new((SkolskiPolicajac)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(PZaVanredneSituacije))
                    {
                        PZaVanredneSituacijeView policajac = new((PZaVanredneSituacije)p);
                        Policajci.Add(policajac);
                    }

                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return Policajci;
        }

        public static List<PolicijskaStanicaView> vratiSvePolicijskeStanice()
        {
            List<PolicijskaStanicaView> Stanice = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<PolicijskaStanica> sveStanice = s.CreateQuery("from PolicijskaStanica").List<PolicijskaStanica>();

                foreach (var sS in sveStanice)
                {
                    Stanice.Add(new PolicijskaStanicaView(sS));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return Stanice;
        }

        public static List<TehnickoLiceView> vratiSvaTehnickaLica()
        {

            List<TehnickoLiceView> tlv = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<TehnickoLice> svaTehnickaLica = s.CreateQuery("from TehnickoLice").List<TehnickoLice>();

                foreach (var t in svaTehnickaLica)
                {
                    tlv.Add(new TehnickoLiceView(t));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return tlv;
        }

        public static bool dodajTehnickoLice(string ime, string prezime)
        {

            TehnickoLice tl = new(ime, prezime);

            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(tl);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;

            }
        }

        public static void DodajPolicijskuStanicu(PolicijskaStanica stanica)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(stanica);
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();

            }

        }

        public static bool obrisiTehnickoLice(int id)
        {

            TehnickoLice tl = new();
            tl.Id = id;

            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(tl);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
        }

        public static bool izmeniTehnickoLice(string ime, string prezime, int id)
        {

            TehnickoLice tl = new(ime, prezime, id);

            try
            {
                ISession s = DataLayer.GetSession();

                s.Update(tl);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
        }

        public static void ObrisiPolicistkuStanicuID(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PolicijskaStanica PS = s.Load<PolicijskaStanica>(ID);

                s.Delete(PS);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
            }
        }

        public static void ObrisiPolicajcaID(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policajac P = s.Load<Policajac>(id);

                s.Delete(P);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
            }
        }
        public static List<VoziloView> vratiSvaVozila()
        {
            List<VoziloView> Vozila = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vozilo> svaVozila = s.CreateQuery("from Vozilo").List<Vozilo>();

                foreach (var v in svaVozila)
                {
                    Vozila.Add(new VoziloView(v));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return Vozila;
        }
        public static void DodajVozilo(Vozilo vozilo)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(vozilo);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
            }

        }
        public static void ObrisiVozilo(string registracija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = new Vozilo(registracija, "", "", "", "");

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
            }
        }

        public static bool AzurirajVozilo(Vozilo vozilo, string staraRegistracija)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (vozilo.RegOznaka == staraRegistracija)
                {
                    s.Update(vozilo);
                }
                else
                {
                    IEnumerable<Vozilo> vozila = from v in s.Query<Vozilo>()
                                                 where v.RegOznaka == vozilo.RegOznaka
                                                 select v;
                    if (vozila.Count() > 0)
                        return false;

                    s.Delete(new Vozilo(staraRegistracija, "", "", "", ""));
                    s.Save(vozilo);
                }
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
                return false;
            }
        }

        public static List<ObjekatView> vratiSveObjekte()
        {
            List<ObjekatView> objekti = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Objekat> svaVozila = s.CreateQuery("from Objekat").List<Objekat>();

                foreach (var o in svaVozila)
                {
                    objekti.Add(new ObjekatView(o));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return objekti;
        }

        public static void dodajObjekatStanici(ObjekatView o, int idStanice)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat obj = new Objekat();
                obj.KontaktIme = o.KontaktIme;
                obj.KontaktPrezime = o.KontaktPrezime;
                obj.Povrsina = o.Povrsina;
                obj.Adresa = o.Adresa;
                obj.Tip = o.Tip;

                obj.PolicijskaStanica = s.Load<PolicijskaStanica>(idStanice);
                s.SaveOrUpdate(obj);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
            }
        }

        public static void ObrisiObjekat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = new Objekat(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
            }
        }

        public static bool AzurirajObjekat(ObjekatView o)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Objekat ob = s.Load<Objekat>(o.Id);

                ob.Povrsina = o.Povrsina;
                ob.Adresa = o.Adresa;
                ob.KontaktIme = o.KontaktIme;
                ob.KontaktPrezime = o.KontaktPrezime;
                ob.Tip = o.Tip;
                
                s.Update(ob);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
                return false;
            }
        }
        public static List<BrojTelefonaView> VratiTelefoneZaObjekat(int idObjekta)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<BrojTelefonaView> list = new List<BrojTelefonaView> ();
                              
                IEnumerable<BrojTelefona> brojevi = from bt in s.Query<BrojTelefona>()
                                              where bt.Id.ObjekatZaBroj.Id == idObjekta
                                              select bt;

                foreach(BrojTelefona bt in brojevi)
                    list.Add(new BrojTelefonaView(bt));

                s.Flush();
                s.Close();

                return list;
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
                return null;
            }
        }

        public static void dodajBrojTelefonaZaObjekat(BrojTelefonaView btv, int idObjekta)
        {
            try 
            {
                ISession s = DataLayer.GetSession();
                BrojTelefona bt = new BrojTelefona();
                bt.Id.Broj = btv.Broj;
                bt.Id.ObjekatZaBroj = s.Load<Objekat>(idObjekta);
                
                s.Save(bt);
                s.Flush();
                s.Close();
            }
            catch(Exception ex) 
            {
                ex.FormatExceptionMessage();
            }
            
        }

        public static void ObrisiBroj(string broj,int idObjekta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojTelefona bt = new BrojTelefona();
                bt.Id.Broj = broj;
                bt.Id.ObjekatZaBroj = s.Load<Objekat>(idObjekta);

                s.Delete(bt);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
            }
        }
    }
}
