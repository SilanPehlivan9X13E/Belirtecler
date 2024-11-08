namespace Belirtecler //public, private, protected, internal, protected internal belirteçlerinin kullanýmlarý
{
    public partial class Form1 : Form
    {
        private Urun benimUrun;
        public Form1()
        {
            InitializeComponent();
            benimUrun = new Urun("Laptop",  1000.00m,  "Elektronik",  550,  "Dell" );
        }
        public class Urun
        {
            // Public özellik (Herkes eriþebilir)
            public string UrunAdi { get; set; }

            // Private özellik (Sadece bu sýnýf içinde eriþilebilir)
            private decimal _fiyat;

            // Protected özellik (Sadece bu sýnýf ve ondan türetilmiþ sýnýflarda eriþilebilir)
            protected int StokMiktari;

            // Internal özellik (Ayný assembly'deki diðer sýnýflar eriþebilir)
            internal string Kategori;

            // Protected Internal özellik (Hem bu sýnýf, türetilmiþ sýnýflar hem de ayný assembly'deki sýnýflar eriþebilir)
            protected internal string Uretici;

            // Public constructor (Herkes çaðýrabilir)
            public Urun(string ad, decimal fiyat, string kategori, int stok, string uretici)
            {
                UrunAdi = ad;
                _fiyat = fiyat;
                Kategori = kategori;
                StokMiktari = stok;
                Uretici = uretici;
            }

            // Private metod(Sadece bu sýnýf içinde çaðrýlabilir)
            private void FiyatGuncelle(decimal yeniFiyat)
            {
                _fiyat = yeniFiyat;

            }

            // Public metod (Ürün bilgilerini döndürür)
            public string UrunBilgisiGetir()
            {
                return $"Ürün Adý: {UrunAdi}, Fiyat: {_fiyat} TL, Stok: {StokMiktari}, Kategori: {Kategori}, Üretici: {Uretici}";
            }

            // Protected metod (Sadece bu sýnýf ve ondan türetilmiþ sýnýflarda çaðrýlabilir)
            protected void StokGuncelle(int yeniStok)
            {
                StokMiktari = yeniStok;
            }


            // Public metod (Stok güncelleme iþlemini dýþarýdan yapabilmek için)
            public void StokGuncellePublic(int yeniStok)
            {
                StokGuncelle(yeniStok);
            }

            // Internal metod (Ayný assembly'deki diðer sýnýflar çaðýrabilir)
            internal void KategoriDegistir(string yeniKategori)
            {
                Kategori = yeniKategori;
            }

            // Protected Internal metod (Hem bu sýnýf, türetilmiþ sýnýflar hem de ayný assembly'deki sýnýflar çaðýrabilir)
            protected internal void UreticiDegistir(string yeniUretici)
            {
                Uretici = yeniUretici;
            }

            // Public metod, fiyatý dýþarýdan güncellemeyi saðlar (private olan metod yerine)
            public void FiyatGuncellePublic(decimal yeniFiyat)
            {
                FiyatGuncelle(yeniFiyat);
            }
        }

        // Form yüklendiðinde, public metodunu çaðýrarak ürün bilgilerini göster
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = benimUrun.UrunBilgisiGetir();  // public metod herkesin eriþebileceði bir metod
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Fiyatý güncelliyoruz
            benimUrun.FiyatGuncellePublic(1200.00m);
            // Güncel bilgiyi labelda gösteriyoruz
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kategoriyi deðiþtiriyoruz
            benimUrun.KategoriDegistir("Eðitim"); //Kategori deðiþtir dediðimde elektronik yerine eðitim yazacak
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Stok miktarýný güncelliyoruz
            benimUrun.StokGuncellePublic(100);
            // Güncel bilgiyi labelda gösteriyoruz
            label1.Text = benimUrun.UrunBilgisiGetir();
        }
    }
}
