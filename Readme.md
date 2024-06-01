# Uçak Bileti Rezervasyon Uygulaması
* Bu proje, uçak bileti rezervasyon bilgilerini SQLite veritabanı dosyasına kaydetme projesidir.
* Visual Studio 2022 (.Net SDK 8) ile yapılmıştır.
* Microsoft.EntityFrameworkCore.Sqlite (8.0.5) NuGet paketi yüklenmiştir.

# Genel Metodlar
* save => Verileri kayıt eden metoddur.
* update => Seçilen kayıta göre verileri güncelleyen metoddur.
* delete => Seçilen kayıtı silen metoddur.
* loadData => İlgili verileri ilgili datagridview nesnesine aktaran metoddur.
* clearData = > İlgili alanlardaki verileri temizleyen metoddur.

# Proje Varlıkları
* Control_Data klasöründe Aircraft, DB, Location, LocationGenerate ve Reservation sınıfları bulunmaktadır.
* Aircraft => Genel metodları içerir.
* DB => ControlDB metodunu içerir. Veritabanı var mı yok mu kontrol eder.
* Location => Genel metodları içerir.
* LocationGenerate => fillCountries, fillCities, fillAirports adlı metodları; Location adında bir yapı ve locations adında bir liste içerir.
```
public struct Location (string country, string city, string airport)
{
    public string Country = country;
    public string City = city;
    public string Airport = airport;
}
public static List<Location> locations = new List<Location>
{
    ...
}
```
* LocationGenerate -> fillCountries => Ülke isimlerini ilgili combobox nesnesine ekler.
* LocationGenerate -> fillCities => Şehir isimlerini ilgili combobox nesnesine ekler.
* LocationGenerate -> fillAirports => Havaalani isimlerini ilgili combobox nesnesine ekler.
* Reservation => Genel metodları ve fillAircraft, fillLocation, fillSeat ve button_Click adlı metodları içerir.
* Reservation -> fillAircraft => Uçak bilgilerini ilgili combobox nesnesine ekler.
* Reservation -> fillLocation => Lokasyon bilgilerini ilgili combobox nesnesine ekler.
* Reservation -> fillSeat => Koltuk düzenini oluşturur.
* Reservation -> button_Click => Koltuk düzeni için oluşturulan metoddur. Koltuk numarasını tanımlamak için kullanılır.
```
private static void button_Click(object sender, EventArgs e)
{
    if (sender is Button button)
    {
        int seat = int.Parse(button.Text);
        MainForm.seatNo = seat;
    }
}
```

# Nasıl Çalışır
* Uçak, lokasyon ve müşteri bilgileri ilgili alanlara girilir. Kayıt, güncelleme ve silme işlemlerinden birisi kullanılır.

## Veri Kayıt Etmek
1. Aircraft Ekranı Kayıt Ekleme
* Uçak modeli, markası, seri numarası ve koltuk bilgisi girilir.
* Save kısmına basılır. Veriler kayıt edilir ve listelenir.

2. Location Ekranı Kayıt Ekleme
* Ülke, şehir, havaalanı ve aktif-pasif bilgisi girilir.
* Save kısmına basılır. Veriler kayıt edilir ve listelenir.

3. Reservation Ekranı Kayıt Ekleme
* Uçak, lokasyon, tarih seçilir. Müşteri adı, soyadı, T.C. Kimlik Numarası ve cinsiyet bilgisi girilir.
* Save kısmına basılır. Veriler kayıt edilir ve listelenir.

## Veri Güncellemek ve Silmek
1. Güncelleme İşlemi
* Datagridview nesnesinden bir satır seçilir.
* Güncel bilgiler ilgili alanlara girilir.
* Update kısmına basılır. Veriler güncellenir ve listelenir.

2. Silme İşlemi
* Datagridview nesnesinden bir satır seçilir.
* Delete kısmına basılır. Veriler silinir ve listelenir.

# Önemli Notlar
* Not: Uygulamanın çalıştırıldığı dizinde 'DB.db' veritabanı dosyasının, MainForm ve Microsoft.EntityFrameworkCore.Sqlite NuGet paketinin dll dosyalarının olması gerekmektedir.
* Not: Reservation bölümünde tarih bilgisi seçilirken; mevcut tarihinten önceki bir tarih seçilememektedir.
* Not: Reservation bölümünde T.C. Kimlik Numarası bilgisi girilirken; girilen verinin 11 haneli olması gerekmektedir.