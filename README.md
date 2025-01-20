# C# Eğitim Kampı Projeleri

Bu repo, Murat Yücedağ'ın liderliğinde düzenlenen **C# Eğitim Kampı** kapsamında geliştirilmiş 9 farklı projeyi içermektedir. Her bir proje, belirli bir programlama konseptini öğrenmek ve uygulamak için tasarlanmıştır. Aşağıda projelerle ilgili detaylı açıklamalar yer almaktadır.

---

## 🚀 Projeler

### 📍 Proje 1: Temel Konular
  - `Console.WriteLine` ve `Console.Write` kullanımı.
  - Temel veri türleri (`string`, `int`) ile değişken tanımlama ve kullanımı.
  - Restoran menü fiyatlandırma ve müşteri bilgilerini yazdırma gibi uygulamalar.

---

### 📍 Proje 2: Değişkenler ve Klavyeden Veri Girişleri
  - `double` ve `char` veri türleri ile işlemler.
  - Klavyeden alınan veriler ile kullanıcı bilgilerini toplama.
  - Sayısal verilerle işlem yapma ve dönüştürme uygulamaları.

---

### 📍 Proje 3: Karar Yapıları
  - `if`, `else if`, `else` gibi koşullu ifadeler kullanarak karar yapıları oluşturma.
  - Kullanıcıdan alınan değerlerle doğrulama uygulamaları (şifre kontrolü, sayı doğrulama).

---

### 📍 Proje 4: Döngüler
  - `for` ve `while` döngüleri ile tekrarlayan işlemleri otomatikleştirme.
  - 1’den 100’e kadar sayıların toplamını hesaplama.
  - 3 basamaklı bir sayının basamaklarını toplama gibi algoritmalar.

---

### 📍 Proje 5: Yıldızlarla Şekiller
  - Yıldızlarla dik üçgen, ters üçgen, piramit ve baklava dilimi oluşturma.
  - Yan yana ve alt alta yıldızlarla görselleştirme çalışmaları.

---

### 📍 Proje 6: Diziler
  - Dizilerde veri saklama ve döngülerle bu veriler üzerinde işlem yapma.
  - Dizinin maksimum ve minimum değerlerini bulma, çift/tek sayıları ayırma uygulamaları.
  - Kullanıcıdan alınan değerlerle dizi oluşturma.

---

### 📍 Proje 7: Foreach Döngüsü
  - `foreach` döngüsü ile diziler ve koleksiyonlar üzerinde işlem yapma.
  - Sınav notları ile öğrencilerin ortalamalarını hesaplama ve geçme/kalma durumlarını belirleme uygulaması.

---

### 📍 Proje 8: Metotlar
  - Geriye değer döndürmeyen (`void`) ve döndüren metotlar yazma.
  - Parametre alan ve almayan metotlar ile işlemleri düzenleme.
  - Öğrenci sınav sonuçlarını hesaplayan ve geri döndüren bir uygulama geliştirme.

---

### 📍 Proje 9: Veritabanı Tabanlı Uygulama
  - **ADO.NET** kullanarak veritabanı bağlantısı kurma.
  - `SqlConnection`, `SqlCommand` ve `SqlDataAdapter` sınıflarını kullanarak SQL verilerini çekme.
  - Kullanıcıdan tablo seçimini alarak, ilgili tablo bilgilerini listeleme.

---

### 📍 Proje 10: CRUD İşlemleri
- **CRUD Açılımı:** Create (Oluştur), Read (Oku), Update (Güncelle), Delete (Sil)
- **Detaylar:**
  - SQL veritabanı üzerinde temel CRUD işlemlerini gerçekleştirme.
  - **Kategori ve Ürünler** üzerinde işlem yapma.
  - **İşlem Detayları:**
    - **Kategori Ekleme:**
      - Kullanıcıdan kategori adı alınır.
      - `INSERT INTO` sorgusu ile yeni kategori veritabanına eklenir.
    - **Ürün Ekleme:**
      - Ürün adı ve fiyatı kullanıcıdan alınır.
      - `INSERT INTO` sorgusu ile yeni ürün eklenir.
    - **Ürün Listeleme:**
      - `SELECT * FROM TblProduct` sorgusu ile ürünler ekranda listelenir.
    - **Ürün Silme:**
      - Silinecek ürünün ID bilgisi kullanıcıdan alınır.
      - `DELETE FROM TblProduct WHERE ProductId=@productId` sorgusu ile ürün silinir.
    - **Ürün Güncelleme:**
      - Güncellenecek ürünün ID bilgisi alınır.
      - Yeni ürün adı ve fiyatı kullanıcıdan alınır.
      - `UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice WHERE ProductId=@productId` sorgusu ile ürün güncellenir.

---

### 📍 Proje 11: EfTravel İstatistik

Bu proje, **Entity Framework** ve **LINQ** kullanarak seyahat veritabanındaki bilgileri sorgulayıp görselleştiren bir istatistik paneli geliştirmektedir. **Windows Forms** üzerinde, kullanıcıya çeşitli istatistikleri canlı olarak gösterir. 💻



## Proje Özellikleri:
- Toplam lokasyon sayısı, kapasite, rehber sayısı ve ortalama kapasite/fiyat gibi genel istatistiklerin hesaplanması.
- En yüksek kapasiteli ve en pahalı turların tespiti.
- Belirli şehirler ve rehberler için detaylı analizlerin yapılması.
- Görselleştirilmiş istatistik paneli.

----


## 🛠️ Kullanılan Araçlar ve Teknolojiler
- **C#**   
- **Visual Studio**   
- **SQL Server**  
- **.NET Framework** 
- **Entity Framework**.
- **LINQ**

 

