List<Rehber> kisiler=new List<Rehber>();

Rehber kisi1=new Rehber{Adi="kardelen",Soyadi="cavdar",Numarasi="5413558899"};
kisiler.Add(kisi1);
Rehber kisi2=new Rehber{Adi="nihat",Soyadi="cihan",Numarasi="5413558899"};
kisiler.Add(kisi2);
Rehber kisi3=new Rehber{Adi="yusuf",Soyadi="yurukogullari",Numarasi="5413558899"};
kisiler.Add(kisi3);
Rehber kisi4=new Rehber{Adi="yusuf",Soyadi="cavdar",Numarasi="5365489512"};
kisiler.Add(kisi4);
Rehber kisi5=new Rehber{Adi="emre",Soyadi="atalay",Numarasi="5365489512"};
kisiler.Add(kisi5);

Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz");
Console.Write("(1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak:");
int deger=Convert.ToInt32(Console.ReadLine());

switch (deger)
{
    case 1:
        yeniKisiEkle(kisiler);
        break;
    case 2:
        numaraSil(kisiler);
        break;
    case 3:
        numaraGuncelleme(kisiler);
        break;
    case 4:
        rehberListele(kisiler);
        break;
    case 5:
        listedeArama(kisiler);
        break;
    default:
        break;


}

  void yeniKisiEkle(List<Rehber> list)
    {   
        Console.Write("Lütfen eklemek istediğiniz kişinin adını giriniz: ");
        string ad = Console.ReadLine().ToLower();
        Console.Write("Lütfen eklemek istediğiniz kişinin soyadını giriniz: ");
        string soyad=Console.ReadLine().ToLower();
        Console.Write("Lütfen eklemek istediğiniz kişinin numarasını giriniz: ");
        string number=Console.ReadLine();

        Rehber yeniKisi=new Rehber
        {
            Adi=ad,
            Soyadi=soyad,
            Numarasi=number
        };
        list.Add(yeniKisi);
        for (int i = 0; i < list.Count; i++)
        {
            System.Console.WriteLine($"Adi:{list[i].Adi}, Soyadi:{list[i].Soyadi}, Numarasi:{list[i].Numarasi}");
        }
    }

    void numaraSil(List<Rehber> list)
    {
        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string isimYaDaSoyisim=Console.ReadLine().ToLower();
        int kontrol=0;
        int silinecekKisi=0;
        for (int i = 0; i < list.Count; i++)
        {
            if(isimYaDaSoyisim==list[i].Adi||isimYaDaSoyisim==list[i].Soyadi)
            {
                silinecekKisi=i;
                kontrol++;
                break;
            }
        }
        if(kontrol==0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int switchDegeri=Convert.ToInt32(Console.ReadLine());
                switch (switchDegeri)
                {
                    case 1:
                        break;
                    case 2:
                        numaraSil(list);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{list[silinecekKisi].Adi} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                char onay=Convert.ToChar(Console.ReadLine().ToLower());
                switch (onay)
                {
                    case 'y':
                        list.Remove(list[silinecekKisi]);
                        break;
                    case 'n':
                        break;
                    default:
                        break;
                }
            }
            kontrol=0;
            silinecekKisi=0;
    }
    void numaraGuncelleme(List<Rehber> list)
    {
        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string isimYaDaSoyisim=Console.ReadLine().ToLower();
        int kontrol=0;
        int guncellenecekKisi=0;
        for (int i = 0; i < list.Count; i++)
        {
            if(isimYaDaSoyisim==list[i].Adi||isimYaDaSoyisim==list[i].Soyadi)
            {
                guncellenecekKisi=i;
                kontrol++;
                break;
            }
        }
        if(kontrol==0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int switchDegeri=Convert.ToInt32(Console.ReadLine());
                switch (switchDegeri)
                {
                    case 1:
                        break;
                    case 2:
                        numaraGuncelleme(list);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lutfen yeni numarayi giriniz:");
                list[guncellenecekKisi].Numarasi=Console.ReadLine();
            }
            kontrol=0;
            guncellenecekKisi=0;

            for (int i = 0; i < list.Count; i++)
            {
            System.Console.WriteLine($"Adi:{list[i].Adi}, Soyadi:{list[i].Soyadi}, Numarasi:{list[i].Numarasi}");
            }
    }

    void rehberListele(List<Rehber> list)
    {
        Console.WriteLine("Sıralamak istediğiniz düzeni seçiniz");
        Console.WriteLine("A-Z için:(1)");
        Console.WriteLine("Z-A için:(2)");
        int kontrol=Convert.ToInt32(Console.ReadLine());
        switch (kontrol)
        {
            case 1:
                 for (int i = 0; i < list.Count; i++)
                {
                    list.Sort((g1,g2) => g1.Adi.CompareTo(g2.Adi));
                }
                for (int i = 0; i < list.Count; i++)
                {
                Console.WriteLine($"Adi:{list[i].Adi}, Soyadi:{list[i].Soyadi}, Numarasi:{list[i].Numarasi}");
                }
                break;
                
            case 2:
                   for (int i = 0; i < list.Count; i++)
                {
                    list.Sort((g1,g2) => g2.Adi.CompareTo(g1.Adi));
                }
                for (int i = 0; i < list.Count; i++)
                {
                Console.WriteLine($"Adi:{list[i].Adi}, Soyadi:{list[i].Soyadi}, Numarasi:{list[i].Numarasi}");
                }
                break;
            default:
                break;
        }
        
    }
    void listedeArama(List<Rehber> list)
    {
        Console.WriteLine("Lütfen Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        int kontrol=Convert.ToInt32(Console.ReadLine());
        List<Rehber> yeniListe=new List<Rehber>();
        switch (kontrol)
        {
            case 1:
                Console.WriteLine("Arama yapmak istediğiniz isim ya da soyismi giriniz");
                string bulunanKisi=Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    if(bulunanKisi==list[i].Adi||bulunanKisi==list[i].Soyadi)
                    {
                        yeniListe.Add(list[i]);
                    }
                }
                
                for (int i = 0; i < yeniListe.Count; i++)
                {
                Console.WriteLine($"Adi:{yeniListe[i].Adi}, Soyadi:{yeniListe[i].Soyadi}, Numarasi:{yeniListe[i].Numarasi}");
                }
                break;
            case 2:
            Console.WriteLine("Arama yapmak istediğiniz numarayı giriniz");
                string numarasıBulunacak=Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    if(numarasıBulunacak==list[i].Numarasi||numarasıBulunacak==list[i].Numarasi)
                    {
                        yeniListe.Add(list[i]);
                    }
                }

                for (int i = 0; i < yeniListe.Count; i++)
                {
                Console.WriteLine($"Adi:{yeniListe[i].Adi}, Soyadi:{yeniListe[i].Soyadi}, Numarasi:{yeniListe[i].Numarasi}");
                }
                break;
            
            default:
                break;
        }
    }

