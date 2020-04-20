using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.Teams.Any())
            {
                var teams = new List<Team>
                {
                    new Team{Name="Gaia", Active=true},
                    new Team{Name="Tartaros", Active=true},
                    new Team{Name="Eros", Active=true},
                    new Team{Name="Apollon", Active=true},
                    new Team{Name="Dionisos", Active=true},
                    new Team{Name="Hades", Active=true},
                    new Team{Name="Zeus", Active=true},
                    new Team{Name="Athena", Active=true}
                };
                await context.Teams.AddRangeAsync(teams);
                await context.SaveChangesAsync();
            }
            if (!context.Markets.Any())
            {
                var markets = new List<Market>
                {
                    new Market{Name="FERINJECT PAZARI", Active=true},
                    new Market{Name="APRANAX PLUS PAZARI", Active=true},
                    new Market{Name="L01AB01 BUSILVEX PAZARI", Active=true},
                    new Market{Name="J01F DYNABAC PAZARI", Active=true},
                    new Market{Name="B03A FERRUM SURUP PAZARI", Active=true},
                    new Market{Name="TENOFOVIR DISOPROXIL PAZARI", Active=true},
                    new Market{Name="N03A LEVETIRACETAM PAZARI (EPIXX)", Active=true},
                    new Market{Name="LATAPOL PAZARI", Active=true}
                };
                await context.Markets.AddRangeAsync(markets);
                await context.SaveChangesAsync();
            }
            if (!context.Departments.Any())
            {
                var departments = new List<Department>
                {
                    new Department{Name="Acil Hekimliği", Active=true},
                    new Department{Name="Ağız Diş ve Çene Radyolojisi", Active=true},
                    new Department{Name="Anestezi ve Reanimasyon", Active=true},
                    new Department{Name="Beyin Cerrahi", Active=true},
                    new Department{Name="Dahiliye", Active=true},
                    new Department{Name="Genel Cerrahi", Active=true},
                    new Department{Name="Kadın Doğum", Active=true},
                    new Department{Name="Kardiyoloji", Active=true}
                };
                await context.Departments.AddRangeAsync(departments);
                await context.SaveChangesAsync();
            }
            if (!context.Cities.Any())
            {
                var cities = new List<City>
                {
                    new City{Name="Adana", Active=true},
                    new City{Name="Adıyaman", Active=true},
                    new City{Name="Afyonkarahisar", Active=true},
                    new City{Name="Ağrı", Active=true},
                    new City{Name="Aksaray", Active=true},
                    new City{Name="Amasya", Active=true},
                    new City{Name="Ankara", Active=true},
                    new City{Name="Antalya", Active=true},
                    new City{Name="Ardahan", Active=true},
                    new City{Name="Artvin", Active=true},
                    new City{Name="Aydın", Active=true},
                    new City{Name="Balıkesir", Active=true},
                    new City{Name="Bartın", Active=true},
                    new City{Name="Batman", Active=true},
                    new City{Name="Bayburt", Active=true},
                    new City{Name="Bilecik", Active=true},
                    new City{Name="Bingöl", Active=true},
                    new City{Name="Bitlis", Active=true},
                    new City{Name="Bolu", Active=true},
                    new City{Name="Burdur", Active=true},
                    new City{Name="Bursa", Active=true},
                    new City{Name="Çanakkale", Active=true},
                    new City{Name="Çankırı", Active=true},
                    new City{Name="Çorum", Active=true},
                    new City{Name="Denizli", Active=true},
                    new City{Name="Diyarbakır", Active=true},
                    new City{Name="Düzce", Active=true},
                    new City{Name="Edirne", Active=true},
                    new City{Name="Elazığ", Active=true},
                    new City{Name="Erzincan", Active=true},
                    new City{Name="Erzurum", Active=true},
                    new City{Name="Eskişehir", Active=true},
                    new City{Name="Gaziantep", Active=true},
                    new City{Name="Giresun", Active=true},
                    new City{Name="Gümüşhane", Active=true},
                    new City{Name="Hakkâri", Active=true},
                    new City{Name="Hatay", Active=true},
                    new City{Name="Iğdır", Active=true},
                    new City{Name="Isparta", Active=true},
                    new City{Name="İstanbul", Active=true},
                    new City{Name="İzmir", Active=true},
                    new City{Name="Kahramanmaraş", Active=true},
                    new City{Name="Karabük", Active=true},
                    new City{Name="Karaman", Active=true},
                    new City{Name="Kars", Active=true},
                    new City{Name="Kastamonu", Active=true},
                    new City{Name="Kayseri", Active=true},
                    new City{Name="Kilis", Active=true},
                    new City{Name="Kırıkkale", Active=true},
                    new City{Name="Kırklareli", Active=true},
                    new City{Name="Kırşehir", Active=true},
                    new City{Name="Kocaeli", Active=true},
                    new City{Name="Konya", Active=true},
                    new City{Name="Kütahya", Active=true},
                    new City{Name="Malatya", Active=true},
                    new City{Name="Manisa", Active=true},
                    new City{Name="Mardin", Active=true},
                    new City{Name="Mersin", Active=true},
                    new City{Name="Muğla", Active=true},
                    new City{Name="Muş", Active=true},
                    new City{Name="Nevşehir", Active=true},
                    new City{Name="Niğde", Active=true},
                    new City{Name="Ordu", Active=true},
                    new City{Name="Osmaniye", Active=true},
                    new City{Name="Rize", Active=true},
                    new City{Name="Sakarya", Active=true},
                    new City{Name="Samsun", Active=true},
                    new City{Name="Şanlıurfa", Active=true},
                    new City{Name="Siirt", Active=true},
                    new City{Name="Sinop", Active=true},
                    new City{Name="Sivas", Active=true},
                    new City{Name="Şırnak", Active=true},
                    new City{Name="Tekirdağ", Active=true},
                    new City{Name="Tokat", Active=true},
                    new City{Name="Trabzon", Active=true},
                    new City{Name="Tunceli", Active=true},
                    new City{Name="Uşak", Active=true},
                    new City{Name="Van", Active=true},
                    new City{Name="Yalova", Active=true},
                    new City{Name="Yozgat", Active=true},
                    new City{Name="Zonguldak", Active=true}
                };
                await context.Cities.AddRangeAsync(cities);
                await context.SaveChangesAsync();
            }
            if (!context.DepartmentCities.Any())
            {
                var cities = await context.Cities.ToListAsync();
                var departments = await context.Departments.ToListAsync();
                var departmentCities = new List<DepartmentCity>();
                foreach (var city in cities)
                {
                    foreach (var department in departments)
                    {
                        departmentCities.Add(new DepartmentCity { DepartmentId = department.Id, CityId = city.Id, Active = true, PhysicianCount = new Random().Next(250, 3000) });
                    }
                }
                await context.DepartmentCities.AddRangeAsync(departmentCities);
                await context.SaveChangesAsync();
            }
            if (!context.MarketCities.Any())
            {
                var cities = await context.Cities.ToListAsync();
                var markets = await context.Markets.ToListAsync();
                var marketCities = new List<MarketCity>();
                foreach (var city in cities)
                {
                    foreach (var market in markets)
                    {
                        marketCities.Add(new MarketCity { MarketId = market.Id, CityId = city.Id, Active = true, Amount = new decimal(new Random().NextDouble() * (new Random()).Next(10000)) });
                    }
                }
                await context.MarketCities.AddRangeAsync(marketCities);
                await context.SaveChangesAsync();
            }
        }
    }
}
