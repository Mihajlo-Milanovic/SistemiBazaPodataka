

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

    }
}
