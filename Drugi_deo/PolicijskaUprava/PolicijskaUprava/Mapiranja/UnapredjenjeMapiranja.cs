namespace PolicijskaUprava.Mapiranja {
	public class UnapredjenjeMapiranja : ClassMap<Unapredjenje>{

		public UnapredjenjeMapiranja() {

			Table("UNAPREDJENJE");

			CompositeId(x => x.Id)
				.KeyReference(x => x.Policajac, "POLICAJAC_ID")
				.KeyProperty(x => x.DatumSticanja, "DATUM_STICANJA");

			Map(x => x.Cin, "CIN");
			
		}
	}
}
