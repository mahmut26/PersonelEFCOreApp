using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Identity.Client;
using Personel.EFCore.DAL;
using Personel.EFCore.Domain;
namespace Personel.EFCore.BAL
{
    public class BAL
    {
        /// <summary>
        /// Listeyi al ve SQL'e yaz.Parametre Personel objesini alır
        /// </summary>
        /// <param name="personel"></param>
        /// <param name="detail"></param>
        public void SQLYAZ(Personel.EFCore.Domain.Personel personel)
        {
            using (var context = new AppDbContext())
            {

                var nC = personel;
               
                
                context.Personel.Add(nC);
                context.SaveChanges();

            }
        }
        public void SQLYAZ(PersonelDetail detail)
        {
            using (var context = new AppDbContext())
            {

                
                var newCustomer = detail;
                context.PersonelDetail.Add(newCustomer);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Personel ve PErsonel Detail olarak döndürür (liste obje)
        /// </summary>
        /// <returns></returns>
        public (List<Personel.EFCore.Domain.Personel>, List<Personel.EFCore.Domain.PersonelDetail>) Yazdır()
        {
            using (var context = new AppDbContext())
            {
                var pers = context.Personel.ToList();
                var detay = context.PersonelDetail.ToList();
                return (pers, detay);
            }
        }

        /// <summary>
        /// Kayıtta ID ye göre işlem yapılıyor. Bundan dolayı Kullanılmaktadır.
        /// </summary>
        /// <returns></returns>
        public int IndexBul()
        {
            using (var context = new AppDbContext())
            {


                List<int>a = context.Personel.Select(x => x.PersonelID).ToList();
                
                int b = a.Last();
                return b;
            }
        }
        /// <summary>
        /// Arama parametresi arama yapmak için,tablotipi ise arama yapılacak db'deki tablolardan seçilmesi içindir.
        /// Burası sadece string olan değerler için çalışmaktadır !!!
        /// </summary>
        /// <param name="Arama"></param>
        /// <param name="tablotipi"></param>
        /// <returns></returns>
        public (List<Personel.EFCore.Domain.Personel>, List<Personel.EFCore.Domain.PersonelDetail>) Arama(string Arama, string tablotipi,string sutun)
        {
           
            var a = new List<Personel.EFCore.Domain.Personel>();
            var b = new List<PersonelDetail>();
            Personel.EFCore.Domain.Personel per = new Domain.Personel();
            using (var context = new AppDbContext())
            {
               
                if (tablotipi == "Personel")

                {
                    if (sutun == "FirstName")
                    {
                        List<int> ID = context.Personel.Where(x => x.LastName.Contains(Arama)).Select(x => x.PersonelID).ToList();
                        

                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(aa)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(aa)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                    else if (sutun == "LastName")
                    {
                        List<int> ID = context.Personel.Where(x => x.LastName.Contains(Arama)).Select(x => x.PersonelID).ToList();
                       
                        
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                    else if (sutun == "IdentityNumber")
                    {
                        List<int> ID = context.Personel.Where(x => x.IdentityNumber.Contains(Arama)).Select(x => x.PersonelID).ToList();
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                    else if (sutun == "Department")
                    {
                        List<int> ID = context.Personel.Where(x => x.IdentityNumber.Contains(Arama)).Select(x => x.PersonelID).ToList();
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }

                    
                }

                else if (tablotipi == "PersonelDetails")

                {
                   if(sutun== "Email")
                    {
                        List<int> ID = context.PersonelDetail.Where(x => x.Email.Contains(Arama)).Select(x => x.PersonelDetailID).ToList();
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                   else if(sutun== "Phone")
                    {
                        List<int> ID = context.PersonelDetail.Where(x => x.Phone.Contains(Arama)).Select(x => x.PersonelDetailID).ToList();
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                   else if (sutun== "Address")
                    {
                        List<int> ID = context.PersonelDetail.Where(x => x.Address.Contains(Arama)).Select(x => x.PersonelDetailID).ToList();
                        foreach (var id in ID)
                        {
                            int aa = int.Parse(id.ToString());
                            var pers = context.Personel.Where(y => y.PersonelID.Equals(id)).ToList();
                            var perd = context.PersonelDetail.Where(y => y.PersonelID.Equals(id)).ToList();
                            a.AddRange(pers);
                            b.AddRange(perd);
                        }
                    }
                }

                
            }

            return (a, b);


        }


        /// <summary>
        /// ID ye göre değiştirir ! tabloya bakar, ID numrasına ne verirsen onu çalıştırır !
        /// </summary>
        /// <param name="degisecek"></param>
        /// <param name="tablo"></param>
        /// <param name="degissutun"></param>
        /// <param name="ID"></param>
        public void Degistir(string degisecek, string tablo, string degissutun, int ID)
        {
            using (var context = new AppDbContext())
            {
                if (tablo == "Personel")
                {
                    var personelToUpdate = context.Personel
                                       .Where(p => p.PersonelID == ID)
                                       .FirstOrDefault();
                    if (personelToUpdate != null)
                    {
                        if (degissutun == "FirstName")
                        {
                            personelToUpdate.FirstName = degisecek;
                            context.SaveChanges();
                        }

                        else if (degissutun == "LastName")
                        {
                            personelToUpdate.LastName = degisecek;
                            context.SaveChanges();
                        }

                        else if (degissutun == "IdentityNumber")
                        {
                            personelToUpdate.IdentityNumber = degisecek;
                            context.SaveChanges();
                        }

                        else if (degissutun == "Department")
                        {
                            personelToUpdate.Department = degisecek;
                            context.SaveChanges();
                        }
                    }

                }
                else if (tablo == "PersonelDetail")
                {
                    var personelToUpdate = context.PersonelDetail
                       .Where(p => p.PersonelDetailID == ID)
                       .FirstOrDefault();
                    if (personelToUpdate != null)
                    {
                        if (degissutun == "Email")
                        {
                            personelToUpdate.Email = degisecek;
                            context.SaveChanges();
                        }

                        else if (degissutun == "Phone")
                        {
                            personelToUpdate.Phone = degisecek;
                            context.SaveChanges();
                        }

                        else if (degissutun == "Address")
                        {
                            personelToUpdate.Address = degisecek;
                            context.SaveChanges();
                        }


                    }
                }

            }
        }

        /// <summary>
        /// INT ID olarak alır ve ID deki şeyi komple siler. 
        /// </summary>
        /// <param name="ID"></param>
        public void Sil(int ID)
        {
            using (var context = new AppDbContext())
            {
                
                var personelToDelete = context.Personel
                                        .Where(p => p.PersonelID == ID)
                                        .FirstOrDefault();
                var personelToDelete1 = context.PersonelDetail
                                        .Where(p => p.PersonelDetailID == ID)
                                        .FirstOrDefault();
                if (personelToDelete != null)
                {
                    context.Personel.Remove(personelToDelete);

                    if(personelToDelete1 != null)
                    {
                        context.PersonelDetail.Remove(personelToDelete1);
                    }
                       
                    context.SaveChanges();
                }
            }
        }
    }
}




   




