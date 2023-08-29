# Recep-Akkaya-Tutor-Exam 
# Problemler
## Oyun başlar başlamaz kaybetme ekranı çıkıyor. 
Canımız PlayerController scriptinde 0 olarak tanımlı olduğu ve start fonksiyonunda ChangeHealth içerisine 0 değeri verildiği için, ChangeHealth fonksiyonuna 100 vererek canımızı full hp haline getirip bu hatayı düzeltiyoruz.

## Mouse hareketleriyle etrafa bakılamıyor. 
Bunun için mouseSense'e 0 dan farklı bir değer atadım. Şimdi karakterimiz sadece sağa ve sola bakabiliyor. Bozuk bir script yapısı vardı. Karakterimizin baktığı yöne de ilerleyebilmesi için karakterimizin ve kameramızın uyum içerisinde açılar ile çalışabilmesi gerekiyor. Bu yüzden playerlook scriptini kameraya atadım. Aynı yapıyı koruyarak if ile yazılmış logicleri Mathf.Clamp fonksiyonunun içine tek satır halinde verdim. Böylece tam anlamıyla clamp edilen açı değerlerimiz oldu ve kod kalabalığını engelledik.

## Karakterimiz hareket etmiyor. 
Bunun için PlayerController'a CharacterController ile hareket edebileceği sciptleri ekledim.

## PlayerControllerda tanımlanan Bullet objesi, inspectordan atanmış değildi.
Bunu ekleyerek mouse sol tık basıldığında mermi ile ateş edebildik.

## Genel olarak çoğu objede componentler eksik, hatalı veya fazla.

## Enemylerin componentleri birbirlerinden farklı. Tagleri eksik olanlar var. 
Gereksiz componentleri çıkarıp gerekli olanları ekleyerek yeni bir Prefabs folderına enemyi ekledim.

## Enemylerin hiçbir özelliği yok. 
Sadece duruyorlar. Bu yüzden Player'ı kovalayacakları bir script ekledim.

## Bullet scripti içindeki if (item.tag == "Enemy") kısmı boş bırakılmış. 
Buraya bulleti ve düşmanı yok edecek iki satır Destroy kodu ekledim.

## Finish Tag'lı bir objemiz yok. 
Finish ekranına gelebilmek için başta spaceshipe finish tagı ekledim ve box collideri trigger yaptım. fikrimi değiştirdim ve daha sonra finish trigger adında boş bir obje ve bir de spaceship'in yakınına yeşil renkte küçük basamak gibi bir şey ekledim.

## Bulletlar için object pooling yapılabilir. 
bir şey ile iletişime geçmezlerse bir süre sonra Destroy edilebilir. IEnumerator ile bu yapılabilir. Aynı zamanda Terraine tag eklenip bulletin etkileşimi halinde yine yok edilebilir.
