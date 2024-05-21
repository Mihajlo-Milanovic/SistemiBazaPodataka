

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
                        RadnikUUpraviView policajac = new ((RadnikUUpravi)p);
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

        public static void DodajPolicijskuStanicu(PolicijskaStanica stanica)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(stanica);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                ec.FormatExceptionMessage();
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
        public static List<VoziloView> vratiSvaVozila()
        {
            List<VoziloView> Vozila = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vozilo> svaVozila = s.CreateQuery("from Vozilo").List<Vozilo>();

                foreach (var sS in svaVozila)
                {
                    Vozila.Add(new VoziloView(sS));
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

                Vozilo v = new Vozilo(registracija,"","","","");

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
    }
}
