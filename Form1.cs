namespace Belirtecler //public, private, protected, internal, protected internal belirte�lerinin kullan�mlar�
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
            // Public �zellik (Herkes eri�ebilir)
            public string UrunAdi { get; set; }

            // Private �zellik (Sadece bu s�n�f i�inde eri�ilebilir)
            private decimal _fiyat;

            // Protected �zellik (Sadece bu s�n�f ve ondan t�retilmi� s�n�flarda eri�ilebilir)
            protected int StokMiktari;

            // Internal �zellik (Ayn� assembly'deki di�er s�n�flar eri�ebilir)
            internal string Kategori;

            // Protected Internal �zellik (Hem bu s�n�f, t�retilmi� s�n�flar hem de ayn� assembly'deki s�n�flar eri�ebilir)
            protected internal string Uretici;

            // Public constructor (Herkes �a��rabilir)
            public Urun(string ad, decimal fiyat, string kategori, int stok, string uretici)
            {
                UrunAdi = ad;
                _fiyat = fiyat;
                Kategori = kategori;
                StokMiktari = stok;
                Uretici = uretici;
            }

            // Private metod(Sadece bu s�n�f i�inde �a�r�labilir)
            private void FiyatGuncelle(decimal yeniFiyat)
            {
                _fiyat = yeniFiyat;

            }

            // Public metod (�r�n bilgilerini d�nd�r�r)
            public string UrunBilgisiGetir()
            {
                return $"�r�n Ad�: {UrunAdi}, Fiyat: {_fiyat} TL, Stok: {StokMiktari}, Kategori: {Kategori}, �retici: {Uretici}";
            }

            // Protected metod (Sadece bu s�n�f ve ondan t�retilmi� s�n�flarda �a�r�labilir)
            protected void StokGuncelle(int yeniStok)
            {
                StokMiktari = yeniStok;
            }


            // Public metod (Stok g�ncelleme i�lemini d��ar�dan yapabilmek i�in)
            public void StokGuncellePublic(int yeniStok)
            {
                StokGuncelle(yeniStok);
            }

            // Internal metod (Ayn� assembly'deki di�er s�n�flar �a��rabilir)
            internal void KategoriDegistir(string yeniKategori)
            {
                Kategori = yeniKategori;
            }

            // Protected Internal metod (Hem bu s�n�f, t�retilmi� s�n�flar hem de ayn� assembly'deki s�n�flar �a��rabilir)
            protected internal void UreticiDegistir(string yeniUretici)
            {
                Uretici = yeniUretici;
            }

            // Public metod, fiyat� d��ar�dan g�ncellemeyi sa�lar (private olan metod yerine)
            public void FiyatGuncellePublic(decimal yeniFiyat)
            {
                FiyatGuncelle(yeniFiyat);
            }
        }

        // Form y�klendi�inde, public metodunu �a��rarak �r�n bilgilerini g�ster
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = benimUrun.UrunBilgisiGetir();  // public metod herkesin eri�ebilece�i bir metod
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Fiyat� g�ncelliyoruz
            benimUrun.FiyatGuncellePublic(1200.00m);
            // G�ncel bilgiyi labelda g�steriyoruz
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kategoriyi de�i�tiriyoruz
            benimUrun.KategoriDegistir("E�itim"); //Kategori de�i�tir dedi�imde elektronik yerine e�itim yazacak
            label1.Text = benimUrun.UrunBilgisiGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Stok miktar�n� g�ncelliyoruz
            benimUrun.StokGuncellePublic(100);
            // G�ncel bilgiyi labelda g�steriyoruz
            label1.Text = benimUrun.UrunBilgisiGetir();
        }
    }
}
