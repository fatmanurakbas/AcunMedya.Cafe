# ☕ AcunMedya Cafe – Kafe Tanıtım ve İçerik Yönetim Sistemi

AcunMedya Cafe, bir kafenin dijital dünyada tanıtımını modern bir altyapıyla gerçekleştirmek, ürünlerini ve hizmetlerini sergilemek, kullanıcı yorumlarını almak ve içerikleri dinamik olarak yönetmek amacıyla geliştirilmiş ASP.NET Core MVC tabanlı kapsamlı bir web uygulamasıdır. Proje, admin paneli desteğiyle hem ziyaretçi tarafını hem de yönetici tarafını etkin bir şekilde sunar.


---
🚀 **Proje Hakkında**

Bu proje, AcunMedya Akademi – C# Programlama Eğitimi kapsamında geliştirilmiştir.

👨‍🏫 **Eğitmenler:**
Murat Yücedağ
Buse Nur Demirbaş
💡 Teknik Destek: Abdullah Kuş

**Projenin temel amacı, bir kafe işletmesinin:**

- Menüsünü dijital ortamda sergileyebilmesi
- Kendi blog yazıları ve duyurularını yayınlayabilmesi
- Görseller ile zengin galeri oluşturabilmesi
- Müşteri yorumlarını alabilmesi
- İçeriklerini tamamen kendi kontrolü altında yönetebilmesidir.

**AcunMedya Cafe**, bir kafenin dijital yüzünü modern web teknolojileriyle sunmak amacıyla geliştirilmiş, görsel odaklı ve yönetilebilir bir web uygulamasıdır.  
Admin paneli üzerinden içerikler kolayca **eklenebilir**, **güncellenebilir** ve **silinebilir**.  
Kod değil, mimari odaklı bir yaklaşımla yapılandırılmıştır.

---

🌐 **Genel Özellikler**

- 👩‍💼 Ziyaretçi Paneli
- 🏠 Ana Sayfa – Tanıtım, slider, kısaca içerik özeti
- 👩‍💻 Hakkımızda – Kafenin hikayesi ve vizyonu
- ☕ Menü – Tüm ürünlerin görselleri, açıklamaları ve fiyatları
- 📰 Blog – Duyurular, tarifler, etkinlik haberleri
- 📸 Galeri – Kafeye ait ürün ve ortam fotoğrafları
- 💬 Yorumlar – Ziyaretçi değerlendirmeleri

🛠️ **Admin Paneli**

- CRUD işlemleri ile içerik ekleme, silme, güncelleme
- Blog, Menü, Galeri, Yorum gibi modüllerin yönetimi
- Kullanıcı doğrulama ve oturum kontrolü
- Yönetici arayüzü sade ve kullanışlıdır
- Dinamik olarak çalışan içerik yönetim sistemi  

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji / Araç | Açıklama |
|------------------|----------|
| **ASP.NET Core MVC** | Projenin temel çatısını oluşturur |
| **Entity Framework Core (Code-First)** | Veritabanı işlemleri için ORM aracı |
| **MS SQL Server** | Veritabanı yönetimi |
| **HTML5 / CSS3 / Bootstrap 5** | Arayüz geliştirme ve responsive tasarım |
| **JavaScript / jQuery** | Dinamik kullanıcı etkileşimleri |
| **LINQ** | Kolay ve okunabilir veri sorguları |
| **Razor View Engine** | Sayfa içeriği oluşturmak için |
| **Dependency Injection** | Modüler ve test edilebilir yapı |

---

## 📁 Proje Yapısı

- `Entities/` → Veritabanı model sınıfları  
- `DataAccessLayer/` → DbContext ve Entity Framework konfigürasyonları  
- `BusinessLayer/` → Servis katmanı ve iş kuralları (business logic)  
- `PresentationLayer/` → Uygulamanın genel kullanıcı arayüzü (MVC)  
- `Areas/` → Uygulamanın modüllere bölünmesini sağlayan yapı (örn: Admin, User alanları)  
- `Controllers/` → HTTP isteklerini yöneten controller sınıfları  
- `Views/` → Razor view dosyaları (kullanıcıya gösterilen sayfa içerikleri)  
- `Program.cs` & `Startup.cs` → Uygulamanın başlangıç noktası ve servis yapılandırmaları


---

## 🖼️ Ekran Görüntüleri

Uygulamanın bazı bölümlerine ait ekran görüntüleri aşağıda yer almaktadır:

### 📌 Ana Sayfa
![Anasayfa](https://github.com/user-attachments/assets/32d4e2c5-823f-49a7-a663-9eb8820f20d8)

### 📌 Hakkımda Sayfası
![Hakkımda](https://github.com/user-attachments/assets/b62d5828-85d3-4c3e-aa16-c333556e309a)

### 📌 Menü Sayfası
![Menü](https://github.com/user-attachments/assets/7dbfeb76-b9a9-49eb-a80a-234fe62e215b)
![Menü2](https://github.com/user-attachments/assets/092c9b60-a137-4b68-bebc-213988156ff9)
![Menü3](https://github.com/user-attachments/assets/008e4cec-ba5a-4f71-8a91-2edaba26390d)

### 📌 Blog Sayfası
![Blog](https://github.com/user-attachments/assets/ab92562d-e15e-4700-9599-11d3fd819c7b)

### 📌 Galeri Sayfası
![Galeri](https://github.com/user-attachments/assets/987b1fb7-5d65-451a-8e3b-cece93c842a0)
![Galeri 2](https://github.com/user-attachments/assets/076f3d57-a2d1-4d37-992b-f448cadf2b91)

### 📌 Yorumlar
![Geri Dönüşler](https://github.com/user-attachments/assets/6cccd79a-a312-4d94-b075-664692525516)

### 📌 Footer
![Footer](https://github.com/user-attachments/assets/e96cd067-ccee-42d7-a0d6-97f7908b4969)

### 📌 Admin Paneli
![Admin Profil](https://github.com/user-attachments/assets/61806553-f69b-491c-96ac-9a97aba357c2)

### 📌 Blog Admin
![Blog Admin](https://github.com/user-attachments/assets/b70afabd-a245-462f-a60d-fee2e8e32a38)

### 📌 Blog Ekleme Sayfası
![Blog Ekleme](https://github.com/user-attachments/assets/09e97541-e0d4-4894-b716-48f642aac884)

### 📌 Blog Güncelleme Sayfası
![Blog Güncelleme](https://github.com/user-attachments/assets/9a91ee4f-b299-4180-b727-17172b0d1e58)

### 📌 Bildirim Sayfası
![Bildirimler Admin](https://github.com/user-attachments/assets/a9004374-658e-4903-87bf-c61b1e6f301e)

### 📌 Mesaj Sayfası
![Mesaj Admin](https://github.com/user-attachments/assets/579817b2-d812-4c1a-b097-244681681760)

---

## 📜Sürüm Geçmişi
Bu proje Visual Studio 2022 ile geliştirilmiştir. Güncellemeler ve sürüm geçmişi için repository’yi takip edebilirsiniz.

## 📞Destek
Bu projeyle ilgili herhangi bir sorunuz veya geri bildiriminiz varsa, lütfen fatmanurakb1616@gmail.com üzerinden iletişime geçin.

## 🎉Teşekkür
Bu projeyi geliştirirken sağladıkları değerli bilgi, rehberlik ve destekleri için Buse Nur Demirbaş ve Murat Yücedağ’a çok teşekkür ederim. 
Ayrıca, projeye emeği geçen tüm ekip arkadaşlarıma ve geri bildirimleriyle süreci iyileştiren herkese teşekkür ederim. Gelecekte birlikte daha birçok başarılı projeye imza atmayı diliyorum. 🚀🙏

1. Bu repoyu klonlayın:  
   ```bash
   https://github.com/fatmanurakbas/AcunMedya.Cafe.git
