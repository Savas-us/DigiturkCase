# DigiturkCase API
---
### 1-Projede kullandığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız?
##### *Repository Pattern: 
Bu tasarım deseninin kullanmamdaki nedenler, veritabanına erişimi tek bir noktadan yönetmek ve veritabanına ortak olarak gerçekleştirdiğim operasyonlar için bir class üzerinde generic bir yapı oluşturup sonrasında diğer class’larıma uygulamak, hem vakitten tasarruf sağlıyor hem de yeniden kullanılabilirliği (Reusability) arttırıyor.

**Deneyim:** Freelance olarak tamamladığım projelerde sıklıkla kullandığım bir tasarım desenidir.

### 2-Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek yazabilir misiniz?
##### *AutoMapper: 
 Sorgu sonucunda dönen verilerden kullanıcıya sadece ihtiyacımız olan bilgileri göstermek istediğimizde, veritabanı nesnesi ve kullanıcıya göstereceğimiz bilgilerin olduğu model classımız arasındaki property eşleştirme işlemi zorlaşır ve karmaşık bir hale dönüşür. İşte tamda bu noktada AutoMapper, property eşleştirme işlemini hallederek yazdığımız kodu yalın bir hale getirmeye yarar.
 
**Deneyim:** Daha önceden bu kütüphaneyi kullanmadım fakat artık sıklıkla kullanacağım bir kütüphane olacağını söylemek istiyorum.

##### *Entity Framework:
Entity Framework, Veritabanı CRUD işlemlerinde kolaylık sağlıyor. Veritabanı arayüzüne bağımlılığımı tamamen ortadan kaldırdığı için kod tarafından ayrılmadan tüm veritabanı işlemlerimize olanak sağlar.

**Deneyim:** Bir çok projede aktif olarak kullandığım bir Framework.

#### Git/Github:
Source Control olarak tercih ettiğim bir versiyonlama çözümüdür.

**Deneyim:** Aktif kullandığım bir versiyon kontrol yönetimidir.

### 3-Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz?
* Authorization(Yetkilendirme) işlemi ile güvenliğin arttırılması.
* Kategori-Makale arasında bire-çok bir ilişki kurularak makalelerin kategorize işlemi.
* Makaleleri özel sorgulara göre filtreleme(Filtering),sıralama(sorting) ve sayfalama(pagination) işlemlerini yapmak.  
### 4-Eklemek istediğiniz bir yorumunuz var mı?
Proje bazlı değerlendirme uygulamanızı çok beğendim.İyi günler,iyi çalışmalar diliyorum.

---
## Projenin Çalıştırılması 
1- ConnectionString'lerin ayarlanması.
* **appsettings.json** altındaki veritabanı bağlantı dizesini kendi lokal sunucunuza uygun bir şekilde düzeltiniz.
* Şu dizini takip ederek veri erişim katmanındaki ConnectionString bağlantı dizesini uygun bir şekilde ayarlayınız.  **Dal** > **Concrete** > **EntityFramework** > **AppDbContext.cs**

2- **Migrations** dosyasına sağ tıklayıp delete edip projemizi **Rebuild** ettikten sonra şu adımları izleyiniz;
* Üst araç çubuğundan **Tools** > **NuGet Package Manager** > **Package Manager Console** konsolumuzu açıyoruz. 

3- Ardından şu ifadeleri konsolumuza yazıp adım adım uyguluyoruz;
- **Enable-migrations**
- **Add-migration Name**  ( **UYARI:** 'Name' alanını kendi tercihinize göre isimlendirebilirsiniz!)
- **Update-database** 

işlemlerini tamamlayarak projeyi aktif hale getirebilirsiniz.
