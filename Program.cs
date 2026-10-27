using System.Text;
Console.WriteLine("=== KULLANICI KAYIT SİSTEMİ ===");

Console.Write("Adınızı giriniz: ");
string? firstName = Console.ReadLine();

Console.Write("Soyadınızı giriniz: ");
string? lastName = Console.ReadLine();

Console.Write("E-posta adresinizi giriniz: ");
string? email = Console.ReadLine();

// Boş giriş kontrolü
if (string.IsNullOrWhiteSpace(firstName) ||
    string.IsNullOrWhiteSpace(lastName) ||
    string.IsNullOrWhiteSpace(email))
{
    Console.WriteLine("Hata: Alanlar boş bırakılamaz!");
}
else
{
    // Gereksiz boşlukları temizle
    firstName = firstName.Trim();
    lastName = lastName.Trim();
    email = email.Trim();

    // Ad ve soyadı birleştir
    string fullName = $"{firstName} {lastName}";

    Console.WriteLine("\n=== KAYIT BİLGİLERİ ===");

    Console.WriteLine($"Ad Soyad: {fullName}");

Console.WriteLine(
        $"Büyük harf: {fullName.ToUpper()}"
    );

    Console.WriteLine(
        $"Küçük harf: {fullName.ToLower()}"
    );

    Console.WriteLine(
        $"Adın karakter sayısı: {firstName.Length}"
    );

Console.WriteLine(
        $"ilk adın son harfi : {firstName[firstName.Length - 1]}"
);



    Console.WriteLine(
        $"Soyadın ilk harfi: {lastName[0]}"
    );

    Console.WriteLine(
        $"Soyadın son harfi: {lastName[lastName.Length - 1]}"
    );

    Console.WriteLine(
        $"E-posta gmail.com içeriyor mu? {email.Contains("gmail.com")}"
    );

Console.WriteLine("\n=== METİN ANALİZİ ===");

int characterCount = 0;

foreach (char c in fullName)
{
    Console.WriteLine(c);

    if (c != ' ')
    {
        characterCount++;
    }
}

Console.WriteLine(
    $"Boşluklar hariç karakter sayısı: {characterCount}"
);

bool isGmail = email.EndsWith(
    "@gmail.com",
    StringComparison.OrdinalIgnoreCase
);

Console.WriteLine($"Gmail adresi mi? {isGmail}");



bool isBerke = string.Equals(
    firstName,
    "BERKE",
    StringComparison.CurrentCultureIgnoreCase
);

Console.WriteLine($"Kullanıcının adı Berke mi? {isBerke}");



int aCount = 0;

foreach (char c in fullName)
{
    if (c == 'a' || c == 'A')
    {
        aCount++;
    }
}

Console.WriteLine($"A harfi sayısı: {aCount}");



Console.WriteLine("\n=== KULLANICI KODU ===");

// Rastgele sayı üreticisi
Random rnd = new Random();

// Başlangıçta boş bir string
string userCode = "";

// 8 karakter oluştur
for (int i = 0; i < 8; i++)
{
    int ascii = rnd.Next(65, 91);

    char randomLetter = (char)ascii;

    userCode += randomLetter;
}

// Oluşturulan kodu yazdır
Console.WriteLine($"Oluşturulan kod: {userCode}");
Console.WriteLine($"Kod uzunluğu: {userCode.Length}");
Console.WriteLine($"kod A içeriyor mu: {userCode.Contains("A")}");






Console.WriteLine("\n=== AŞAMA 4: KAYIT RAPORU ===");

// 1. StringBuilder oluştur
StringBuilder report = new StringBuilder();

// 2. Kullanıcı bilgilerini ekle
report.AppendLine($"Ad Soyad: {fullName}");
report.AppendLine($"E-posta: {email}");
report.AppendLine($"Kullanıcı kodu: {userCode}");

// 3. Kullanıcı kodunun uzunluğunu ekle
report.AppendLine($"Kod uzunluğu: {userCode.Length}");

// 4. Gmail kontrolünün sonucunu ekle
report.AppendLine($"Gmail kullanıcısı mı?: {isGmail}");

// 5. Kayıt tarihi
report.AppendLine(
    $"Kayıt tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}"
);

// 6. Kullanıcı kodundaki harfleri ekle
report.Append("Kod harfleri: ");

foreach (char letter in userCode)
{
    report.Append(letter).Append(", ");
}

// 7. Sondaki gereksiz virgül ve boşluğu kaldır
if (userCode.Length > 0)
{
    report.Remove(report.Length - 2, 2);
}

report.AppendLine();

// 8. Başlık ekle
report.Insert(0, "=== KULLANICI KAYIT RAPORU ===\n");

// 9. Metindeki ifadeyi değiştir
report.Replace("Kullanıcı kodu:", "Üyelik kodu:");

// 10. Normal string'e dönüştür
string finalReport = report.ToString();

// 11. Raporu ekrana yazdır
Console.WriteLine(finalReport);




}


