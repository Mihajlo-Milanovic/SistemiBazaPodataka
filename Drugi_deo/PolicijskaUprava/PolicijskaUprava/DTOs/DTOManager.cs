

namespace PolicijskaUprava.DTOs
{
    public class DTOManager
    {
        public static List<Policajac> vratiSvePolicajce()
        {
            List<Policajac> Policajci = new List<Policajac>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Policajac> sviPolicajci = s.CreateQuery("from Policajac").List<Policajac>();

                foreach (var p in sviPolicajci)
                {
                    
                    //if (p.GetType() == typeof(Patrolni_policajac))
                    //{
                    //    Patrolni_policajac policajac = (Patrolni_policajac)p;
                    //    Policajci.Add(policajac);
                    //}
                    //else if (p.GetType() == typeof(Policajac_pozornik))
                    //{
                    //    Policajac_pozornik policajac = (Policajac_pozornik)p;
                    //    Policajci.Add(policajac);
                    //}
                    //else if (p.GetType() == typeof(Radnik_u_upravi))
                    //{
                    //    Radnik_u_upravi policajac = (Radnik_u_upravi)p;
                    //    Policajci.Add(policajac);
                    //}
                    //else if(p.GetType() == typeof(Skolski_policajac))
                    //{
                    //    Skolski_policajac policajac = (Skolski_policajac)p;
                    //    Policajci.Add(policajac);
                    //}
                    //else if (p.GetType() == typeof(P_za_vanredne_situacije))
                    //{
                    //    P_za_vanredne_situacije policajac = (P_za_vanredne_situacije)p;
                    //    Policajci.Add(policajac);
                    //}

                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }

            return Policajci;
        }

    }
}
