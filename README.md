# Car Production Program

Bu proje, kullanıcıların araba bilgilerini girmesine ve bu bilgileri bir listeye eklemesine olanak tanıyan bir konsol uygulamasıdır. Kullanıcı, arabanın markasını, modelini, rengini ve seri numarasını belirtir ve arabanın kapı sayısını girer. Program, kullanıcıya başka bir araba üretmek isteyip istemediğini sorar ve kullanıcı "h" (hayır) yanıtını verene kadar bu işlemi tekrarlar.

## Kullanım

1. Program çalıştırıldığında, kullanıcıya araba üretmek isteyip istemediği sorulur.
2. Kullanıcı "e" (evet) yanıtını verirse, arabanın markası, modeli, rengi ve seri numarası gibi bilgileri girer.
3. Kullanıcıdan arabanın kapı sayısını girilmesi istenir ve hatalı girişler için tekrar denemesi sağlanır.
4. Üretilen araba, bir listeye eklenir.
5. Kullanıcıya başka bir araba üretmek isteyip istemediği sorulur.
6. Kullanıcı "h" (hayır) yanıtını verene kadar işlem tekrarlanır.
7. Program sona erdiğinde, üretilen tüm arabalar ekrana yazdırılır.

## Kodun Açıklaması

### `Car` Sınıfı

`Car` sınıfı, bir arabanın aşağıdaki özelliklerini tanımlar:
- **ProductionDate**: Arabanın üretim tarihi. (`DateTime`)
- **SerialNumber**: Arabanın seri numarası. (`int`)
- **Brand**: Arabanın markası. (`string`)
- **Model**: Arabanın modeli. (`string`)
- **Colour**: Arabanın rengi. (`string`)
- **GateCount**: Arabanın kapı sayısı. (`int`)

#### Kapı Sayısı Kontrolü

`GateCount` özelliği, sadece 2 veya 4 kapı sayısına izin verir. Geçersiz bir kapı sayısı girildiğinde, `GateCountException` özel bir hata fırlatılır.

#### `Car` Sınıfının Yapıcı Metodu

- `Car()` yapıcı metodu, arabanın üretim tarihini otomatik olarak mevcut tarih olarak ayarlar.

#### `DisplayInfo` Metodu

- `DisplayInfo()` metodu, arabanın seri numarasını ve markasını ekrana yazdırır.

### `GateCountException` Sınıfı

`GateCountException` sınıfı, geçersiz kapı sayısı girildiğinde kullanıcıyı bilgilendiren özel bir hata sınıfıdır. Kapı sayısı yalnızca 2 veya 4 olabilir; bu koşulu sağlamayan girişler için kullanıcıya hata mesajı gösterilir.

## Kurulum ve Çalıştırma

1. Projeyi klonlayın veya indirin.
2. Visual Studio veya benzeri bir IDE'de açın.
3. Programı çalıştırarak konsol uygulamasını başlatın.

## Lisans

Bu proje, [MIT Lisansı](https://opensource.org/licenses/MIT) altında lisanslanmıştır.
