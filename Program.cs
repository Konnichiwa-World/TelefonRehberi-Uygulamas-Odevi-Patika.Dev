using System;
using System.Collections.Generic;
using System.Collections;

namespace TelefonUygulamasi
{
    class Program
    {

        public static void Main(string[] args)
        {   ArrayList kişilerismi = new ArrayList();
            ArrayList kişilersoyismi = new ArrayList();
            ArrayList kişilerTelNo = new ArrayList();
            kişilerismi.Add("Ali");
            kişilerismi.Add("Veli");
            kişilerismi.Add("Didem");
            kişilerismi.Add("Zeynel");
            kişilerismi.Add("Ercan");
            kişilersoyismi.Add("Alioğlu");
            kişilersoyismi.Add("Velioğlu");
            kişilersoyismi.Add("Didemoğlu");
            kişilersoyismi.Add("Zeyneloğlu");
            kişilersoyismi.Add("Ercanoğlu");
            kişilerTelNo.Add("05341111111");
            kişilerTelNo.Add("05342222222");
            kişilerTelNo.Add("05343333333");
            kişilerTelNo.Add("05344444444");
            kişilerTelNo.Add("05345555555");
            
            a1:
            System.Console.WriteLine("1- Telefon Numarası Kaydet\n2-Telefon Numarası Sil\n3-Telefon Numarası Güncelle\n4-Rehber Listeleme(A-Z, Z-A seçimli)\n5-Rehberde Arama");
            Int32 x =Int32.Parse(Console.ReadLine());

            if(1==x){
            System.Console.WriteLine("Lütfen isim giriniz:");
            kişilerismi.Add(Console.ReadLine());
            System.Console.WriteLine("Lütfen soyisminizi giriniz:");
            kişilersoyismi.Add(Console.ReadLine());
            System.Console.WriteLine("Lütfen telefon numarası giriniz:");
            kişilerTelNo.Add(Console.ReadLine());System.Console.WriteLine("Girdiğiniz kayıt bilgileri:"); System.Console.WriteLine(kişilerismi[5]); System.Console.WriteLine(kişilersoyismi[5]);System.Console.WriteLine(kişilerTelNo[5]); goto a1;
            }

            if(2==x)
            {a2:
                System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string adyadasoyad = Console.ReadLine();

                if(kişilerismi.Contains(adyadasoyad)==true||kişilersoyismi.Contains(adyadasoyad)==true)
                {  
                    if(kişilerismi.Contains(adyadasoyad)==true)
                    {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", adyadasoyad);
                    char b= Convert.ToChar(Console.ReadLine());char y= Convert.ToChar("y");char n= Convert.ToChar("n");
                        if(y==b)
                        {
                        int yyy=kişilerismi.BinarySearch(adyadasoyad);
                        System.Console.WriteLine(yyy);
                        kişilerismi.Remove(adyadasoyad);
                        kişilersoyismi.Remove(kişilerismi[yyy]);
                        kişilerTelNo.Remove(kişilerismi[yyy]); goto a1;
                        }
                        else if(b==n){goto a1;}
                        else{System.Console.WriteLine("Birşeyler ters gitti.");goto a1;}
                    }

                    else if(kişilersoyismi.Contains(adyadasoyad)==true)
                    {
                    Console.WriteLine("{0} soyisimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", adyadasoyad);
                    char b= Convert.ToChar(Console.ReadLine());
                    char y= Convert.ToChar("y");
                    char n= Convert.ToChar("n");
                        if(y==b)
                        {
                        int xxx = kişilersoyismi.BinarySearch(adyadasoyad);
                        kişilersoyismi.Remove(adyadasoyad);
                        kişilerismi.Remove(kişilerismi[xxx]);
                        kişilerTelNo.Remove(kişilerismi[xxx]);
                        }
                        else if(b==n){goto a1;}
                    }
                }
                else{
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");
                Int32 a =Int32.Parse(Console.ReadLine());
                if(a==1){goto a1;}
                if(a==2){goto a2;}
                }
            }

            if(x==3)
            {a4:
            System.Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string adyadasoyad1 = Console.ReadLine();
                if(kişilerismi.Contains(adyadasoyad1)==true||kişilersoyismi.Contains(adyadasoyad1)==true)
                {
                if(kişilerismi.Contains(adyadasoyad1)==true)
                {
                Console.WriteLine("{0} isimli kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)", adyadasoyad1);
                char b= Convert.ToChar(Console.ReadLine());char y= Convert.ToChar("y");char n= Convert.ToChar("n");
                    if(y==b){
                        Console.WriteLine("Lütfen mevcut kişiye yeni isim giriniz:");
                        kişilerismi.Add(Console.ReadLine());
                        Console.WriteLine("Lütfen mevcut kişiye yeni soyisim giriniz:");
                        kişilersoyismi.Add(Console.ReadLine());
                        Console.WriteLine("Lütfen mevcut kişiye yeni numara giriniz:");
                        kişilerTelNo.Add(Console.ReadLine());goto a1;
                        }

                    else if(b==n){goto a4;}
                    else{System.Console.WriteLine("Yanlış bir tuşa bastınız."); goto a4;};
                    
                }

                else if(kişilersoyismi.Contains(adyadasoyad1)==true){
                Console.WriteLine("{0} soyisimli kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)", adyadasoyad1);
                char b= Convert.ToChar(Console.ReadLine());
                char y= Convert.ToChar("y");
                char n= Convert.ToChar("n");
                    if(y==b){
                    System.Console.WriteLine("Lütfen mevcut kişiye yeni isim giriniz:");
                    kişilerismi[kişilerismi.BinarySearch(adyadasoyad1)]=Console.ReadLine();
                    System.Console.WriteLine("Lütfen mevcut kişiye yeni soyisim giriniz:");
                    kişilersoyismi[kişilerismi.BinarySearch(adyadasoyad1)]=Console.ReadLine();
                    System.Console.WriteLine("Lütfen mevcut kişiye yeni numara giriniz:");
                    kişilerTelNo[kişilerismi.BinarySearch(adyadasoyad1)]=Console.ReadLine();goto a1;}
                    else if(b==n){goto a4;}}
                }
            

            else{
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için           : (2)");
                Int32 a =Int32.Parse(Console.ReadLine());
                if(a==1){goto a1;}
                if(a==2){goto a4;}
                }}
            

            if(x==4){
                System.Console.WriteLine("Telefon Rehberi");
                System.Console.WriteLine("**********************************************");
                int e=kişilerismi.Count;
                for(int ee=0;ee<1;ee++){
                for(int h=0;h<e;h++){

                    kişilerismi.Sort();
                    kişilersoyismi.Sort();
                    kişilerTelNo.Sort();
                    System.Console.WriteLine("isim: " + kişilerismi[h]);
                    System.Console.WriteLine("Soyisim: " + kişilersoyismi[h]);
                    System.Console.WriteLine("Telefon Numarası: " + kişilerTelNo[h]);
                    System.Console.WriteLine("");
                    } goto a1; }
                    }

            if(x==5){a5:
                System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
                System.Console.WriteLine("**********************************************");
                System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                Int32 secenek =Int32.Parse(Console.ReadLine());
                if(1==secenek){
                    System.Console.WriteLine("Lütfen isim veya soyisim giriniz:");
                    string adyadasoyad2 = Console.ReadLine();
                    if(kişilerismi.Contains(adyadasoyad2)==true||kişilersoyismi.Contains(adyadasoyad2)==true)
            {
                if(kişilerismi.Contains(adyadasoyad2)==true){
                    System.Console.WriteLine("Arama Sonuçlarınız:");
                    System.Console.WriteLine(" **********************************************");
                    System.Console.WriteLine("İsim: " + kişilerismi[kişilersoyismi.BinarySearch(adyadasoyad2)]);
                    System.Console.WriteLine("Soyisim: " + kişilersoyismi[kişilersoyismi.BinarySearch(adyadasoyad2)]);
                    System.Console.WriteLine("Telefon Numarası: " + kişilerTelNo[kişilersoyismi.BinarySearch(adyadasoyad2)]);}

            else if(kişilersoyismi.Contains(adyadasoyad2)==true){
                    System.Console.WriteLine("Arama Sonuçlarınız:");
                    System.Console.WriteLine(" **********************************************");
                    System.Console.WriteLine("İsim: " + kişilerismi[kişilersoyismi.BinarySearch(adyadasoyad2)]);
                    System.Console.WriteLine("Soyisim: " + kişilersoyismi[kişilersoyismi.BinarySearch(adyadasoyad2)]);
                    System.Console.WriteLine("Telefon Numarası: " + kişilerTelNo[kişilersoyismi.BinarySearch(adyadasoyad2)]);}

                if(2==secenek){

                    System.Console.WriteLine("Lütfen telefon numarası giriniz:");
                    string aramaTelno = Console.ReadLine();
                    if(kişilerTelNo.Contains(aramaTelno)==true){
                        System.Console.WriteLine(aramaTelno + " aranıyor...");
                    }
                    else{System.Console.WriteLine("Böyle bir Telefon numarası bulunmamaktadır.");goto a5;}
                }}}}  
        }   
    } 
}
                
                
                
                
                
                
                
              
              
              
              
              

