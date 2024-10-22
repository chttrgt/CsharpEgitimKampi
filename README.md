#  🏅 **C# Eğitim Kampı** 🏅
#### Eğitmen: Murat Yücedağ | 📺 https://www.youtube.com/@MurattYucedag
 
Bu eğitim kampında C# dilinin temel yapılarını öğrenmeye başladık ve heyecanla ileri seviyedeki konuları bekliyorum.
Eğitim boyunca işlediğimiz konuları bu repoda bulabilirsiniz. Ve bu konularla alakalı kısa bilgiler de aşağıdadır.


## 📜 01_Main Subjects (Temel konular)

Yazdırma komutlarını gördük. `Console.Write()` ile `Console.WriteLine()` gibi ve bunlar arasındaki farkı öğrendik. Ayrıca `string` değişkenler ve `integer` değişkenlere giriş yaptık.

  ```csharp
  Console.Write("Bu aynı satırda kalır.");
  Console.WriteLine("Bu ise bir alt satıra geçer.");

  string name;
  name = "cihatturgut";
  Console.WriteLine(name);

  int number = 24;
  Console.WriteLine(number);
  
  ```

---

## 📜 02_Variables (Değişkenler)
Bu bölümde değişkenleri tanımlamayı, değişkenlere değer atamayı öğrendik.
double, char değişken tiplerini gördük ve kullanıcıdan veri alıp değişkenlerde kullandık.

 ```csharp
  double exam1, exam2, exam3, result;

  Console.Write("Lütfen 1. Sınav notunu giriniz: ");
  exam1 = double.Parse(Console.ReadLine());
  
  Console.Write("Lütfen 2. Sınav notunu giriniz: ");
  exam2 = double.Parse(Console.ReadLine());
  
  Console.Write("Lütfen 3. Sınav notunu giriniz: ");
  exam3 = double.Parse(Console.ReadLine());
  
  result = (exam1 + exam2 + exam3) / 3;
  
  Console.WriteLine();
  Console.WriteLine("Sınav Ortalamanız: " + result);
 
  ```
---

## 📜 03_Making Decisions (Karar Yapıları)
Bu bölümde `if-else`, `switch-case` karar yapılarını gördük.

 ```csharp
 Console.Write("Lütfen Ay girişi yapınız: ");
int monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber)
{
    case 1: Console.Write("Ocak"); break;
    case 2: Console.Write("Şubat"); break;
    case 3: Console.Write("Mart"); break;
    case 4: Console.Write("Nisan"); break;
    case 5: Console.Write("Mayıs"); break;
    case 6: Console.Write("Haziran"); break;
    case 7: Console.Write("Temmuz"); break;
    case 8: Console.Write("Ağustos"); break;
    case 9: Console.Write("Eylül"); break;
    case 10: Console.Write("Ekim"); break;
    case 11: Console.Write("Kasım"); break;
    case 12: Console.Write("Aralık"); break;
    default:
        Console.Write("Lütfen 1-12 arası bir değer giriniz!");
        break;
} 
  ```

---

## 📜 04_Loops (Döngüler)
Bu bölümde `for` ve `while` döngülerini gördük.
Döngülerle beraber karar yapılarını kullandık.

 ```csharp
   // 1 ile 100 arası 5'e bölünebilen sayılar.

   for (int i = 1; i < 100; i++)
   {
       if (i % 5 == 0)
       {
           Console.WriteLine(i);
       }
   }
  ```

---

## 📜 05_Loops With Stars (Döngüler...)
Bu bölümde iç içe döngüler kullanarak yıldızlar '*' ile çeşitli desenler oluşturduk.\
Algoritma becerimizi geliştirmeye yarayan şekiller çizdirdik.

 ```csharp
   // Piramit
    for (int i = 1; i <= 5; i++)
    {
       for (int j = 5 - i; j > 0; j--)
       {
           Console.Write(" ");
       }
  
       for (int j = 0; j < 2 * i - 1; j++)
       {
           Console.Write("*");
       }
  
       Console.WriteLine();
     }
  ```

---

## 📜 06_Arrays (Diziler)
Bu bölümde dizilerin temel yapılarını öğrendik ve dizilere ait bazı metodları gördük `length , sort , reverse` vb.\
Yine kullanıcadan veri alarak bir döngü yardımıyla diziye veri girişini sağladık.

  ```csharp
   string[] cities = new string[5];
   for (int i = 0; i < cities.Length; i++)
   {
       Console.Write("Lütfen bir şehir ismi giriniz: ");
       cities[i] = Console.ReadLine();
       if (i == cities.Length - 1)
       {
           Console.Write("Girdiğiniz şehirleri görmek için bir tuşa basın.");
           Console.ReadKey();
           Console.WriteLine("\n");
           for (int j = 0; j < cities.Length; j++)
           {
               Console.WriteLine(cities[j]);
           }
         }
   }
  
  ```

---

## 📜 07_Foreach Loop (Foreach Döngüsü)
Bu bölümde `foreach` döngüsünün yapısını öğrendik. Dizilerden sonraya bırakmamızın sebebi ise\
`foreach` döngüsünün yapısı gereği sadece iterable ifadelerde kullanılabilir olmasıdır.

  ```csharp
    int[] sayilar = {1, 2, 3, 4, 5};
  
    foreach (int sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }
 
  ```

---

## 📜 08_Methods (Metodlar)
Bu bölümde metod oluşturmayı ve metodların türlerini gördük.
  + Geriye değer döndürmeyen metodlar (void)
      - Parametresiz geriye değer döndürmeyen metodlar
      - Parametreli geriye değer döndürmeyen metodlar

  + Geriye değer döndüren metodlar (int,string,bool vs.)
      - Parametresiz geriye değer döndüren metodlar
      - Parametreli geriye değer döndüren metodlar

        
  ```csharp
      void CustomerList()
      {
        Console.WriteLine("cihatturgut");
      }

      int Sum(int number1, int number2)
      {
          int result = number1 + number2;
          return result;
      }
 
  ```

---

## 📜 09_Database (Veritabanı)
Bu bölümde MSSQL Server Management Studio ile veritabanı oluşturmayı ve tablolar eklemeyi öğrendik.\
C# tarafında ise oluşturmuş olduğumuz veritabanından `ADO.NET` teknolojisi ile verilerimizi çekip ekrana yazdırdık. 
        
  ```csharp
      SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
      con.Open();
      SqlCommand cmd = new SqlCommand("Select * from tblCategory", con);
      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      
      DataTable dt = new DataTable();
      adapter.Fill(dt);
      
      foreach (DataRow row in dt.Rows)
      {
          foreach (var item in row.ItemArray)
          {
      
              Console.Write(item.ToString());
          }
          Console.WriteLine();
      }
      
      con.Close();
 
  ```


[MSSQL Server - 2022 Kurulumu'na buradan ulaşabilirsiniz!](https://www.youtube.com/watch?v=UhhYMLVd4MA) 
###### Not: `MSSQL Server` kurulumundan sonra `MSSQL Server Management Studio`'yu da kurmanız gerek. Onu da [buradan](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) indirebilirsiniz.

---

### SONUÇ: Bu kamp'ın en güzel yanı öğrendiklerinizi hemen örneklerle uygulayıp pekiştirmeniz. Ve ayrıca Murat hocamızın bildiklerini aktarım becerisi. Bunun için hocamıza teşekkür ederim.💖


