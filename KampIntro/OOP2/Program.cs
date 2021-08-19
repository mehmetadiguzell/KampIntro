namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Demir";          
            musteri1.TcNo = "11111111";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 4;
            musteri2.MusteriNo = "4324";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1323424";

            //gerçek müşteri-tüzel müşteri
            //SOLİD yazılım geliştirme prensipleri

            //Musteri classı hem gerçek hem de tüzel müşterinin referans numarasını tutuyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
