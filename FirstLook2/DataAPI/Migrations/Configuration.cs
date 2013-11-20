namespace DataAPI.Migrations
{
    using FirstLook2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstLook2.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FirstLook2.Models.EmployeeDbContext context)
        {

            int id = 0;
            context.Employees.AddOrUpdate(
              p => p.Id,
              new Employee()
              {
                  Id = id++,
                  FirstName = "Bill",
                  LastName = "Gates",
                  Salary = 10000000.0M,
                  Company = "Microsoft"
              }
              , new Employee()
              {
                  Id = id++,
                  FirstName = "James",
                  LastName = "Butt",
                  Salary = 55550000.0M,
                  Company = "Benton, John B Jr",
                  City = "New Orleans",
                  Address = "6649 N Blue Gum St ",
                  Email = "jbutt@gmail.com",
                  PhoneNumber = "504-621-8927",
                  WebAddress = "http://www.bentonjohnbjr.com",
              }
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "James",
    LastName = "Butt",
    Salary = 55550000.0M,
    Company = "Benton, John B Jr",
    City = "New Orleans",
    Address = "6649 N Blue Gum St",
    Email = "jbutt@gmail.com",
    PhoneNumber = "504-621-8927",
    WebAddress = "http://www.bentonjohnbjr.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Josephine",
    LastName = "Darakjy",
    Salary = 55550000.0M,
    Company = "Chanay, Jeffrey A Esq",
    City = "Brighton",
    Address = "4 B Blue Ridge Blvd",
    Email = "josephine_darakjy@darakjy.org",
    PhoneNumber = "810-292-9388",
    WebAddress = "http://www.chanayjeffreyaesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Art",
    LastName = "Venere",
    Salary = 55550000.0M,
    Company = "Chemel, James L Cpa",
    City = "Bridgeport",
    Address = "8 W Cerritos Ave #54",
    Email = "art@venere.org",
    PhoneNumber = "856-636-8749",
    WebAddress = "http://www.chemeljameslcpa.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Lenna",
    LastName = "Paprocki",
    Salary = 55550000.0M,
    Company = "Feltz Printing Service",
    City = "Anchorage",
    Address = "639 Main St",
    Email = "lpaprocki@hotmail.com",
    PhoneNumber = "907-385-4412",
    WebAddress = "http://www.feltzprintingservice.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Donette",
    LastName = "Foller",
    Salary = 55550000.0M,
    Company = "Printing Dimensions",
    City = "Hamilton",
    Address = "34 Center St",
    Email = "donette.foller@cox.net",
    PhoneNumber = "513-570-1893",
    WebAddress = "http://www.printingdimensions.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Simona",
    LastName = "Morasca",
    Salary = 55550000.0M,
    Company = "Chapman, Ross E Esq",
    City = "Ashland",
    Address = "3 Mcauley Dr",
    Email = "simona@morasca.com",
    PhoneNumber = "419-503-2484",
    WebAddress = "http://www.chapmanrosseesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mitsue",
    LastName = "Tollner",
    Salary = 55550000.0M,
    Company = "Morlong Associates",
    City = "Chicago",
    Address = "7 Eads St",
    Email = "mitsue_tollner@yahoo.com",
    PhoneNumber = "773-573-6914",
    WebAddress = "http://www.morlongassociates.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Leota",
    LastName = "Dilliard",
    Salary = 55550000.0M,
    Company = "Commercial Press",
    City = "San Jose",
    Address = "7 W Jackson Blvd",
    Email = "leota@hotmail.com",
    PhoneNumber = "408-752-3500",
    WebAddress = "http://www.commercialpress.com",
}
, new Employee()
{
    Id = 4,
    FirstName = "Sage",
    LastName = "Wieser",
    Salary = 55550000.0M,
    Company = "Truhlar And Truhlar Attys",
    City = "Sioux Falls",
    Address = "5 Boston Ave #88",
    Email = "sage_wieser@cox.net",
    PhoneNumber = "605-414-2147",
    WebAddress = "http://www.truhlarandtruhlarattys.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kris",
    LastName = "Marrier",
    Salary = 55550000.0M,
    Company = "King, Christopher A Esq",
    City = "Baltimore",
    Address = "228 Runamuck Pl #2808",
    Email = "kris@gmail.com",
    PhoneNumber = "410-655-8723",
    WebAddress = "http://www.kingchristopheraesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Minna",
    LastName = "Amigon",
    Salary = 55550000.0M,
    Company = "Dorl, James J Esq",
    City = "Kulpsville",
    Address = "2371 Jerrold Ave",
    Email = "minna_amigon@yahoo.com",
    PhoneNumber = "215-874-1229",
    WebAddress = "http://www.dorljamesjesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Abel",
    LastName = "Maclead",
    Salary = 55550000.0M,
    Company = "Rangoni Of Florence",
    City = "Middle Island",
    Address = "37275 St  Rt 17m M",
    Email = "amaclead@gmail.com",
    PhoneNumber = "631-335-3414",
    WebAddress = "http://www.rangoniofflorence.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Kiley",
    LastName = "Caldarera",
    Salary = 55550000.0M,
    Company = "Feiner Bros",
    City = "Los Angeles",
    Address = "25 E 75th St #69",
    Email = "kiley.caldarera@aol.com",
    PhoneNumber = "310-498-5651",
    WebAddress = "http://www.feinerbros.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Graciela",
    LastName = "Ruta",
    Salary = 55550000.0M,
    Company = "Buckley Miller & Wright",
    City = "Chagrin Falls",
    Address = "98 Connecticut Ave Nw",
    Email = "gruta@cox.net",
    PhoneNumber = "440-780-8425",
    WebAddress = "http://www.buckleymillerwright.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Cammy",
    LastName = "Albares",
    Salary = 55550000.0M,
    Company = "Rousseaux, Michael Esq",
    City = "Laredo",
    Address = "56 E Morehead St",
    Email = "calbares@gmail.com",
    PhoneNumber = "956-537-6195",
    WebAddress = "http://www.rousseauxmichaelesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Mattie",
    LastName = "Poquette",
    Salary = 55550000.0M,
    Company = "Century Communications",
    City = "Phoenix",
    Address = "73 State Road 434 E",
    Email = "mattie@aol.com",
    PhoneNumber = "602-277-4385",
    WebAddress = "http://www.centurycommunications.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Meaghan",
    LastName = "Garufi",
    Salary = 55550000.0M,
    Company = "Bolton, Wilbur Esq",
    City = "Mc Minnville",
    Address = "69734 E Carrillo St",
    Email = "meaghan@hotmail.com",
    PhoneNumber = "931-313-9635",
    WebAddress = "http://www.boltonwilburesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Gladys",
    LastName = "Rim",
    Salary = 55550000.0M,
    Company = "T M Byxbee Company Pc",
    City = "Milwaukee",
    Address = "322 New Horizon Blvd",
    Email = "gladys.rim@rim.org",
    PhoneNumber = "414-661-9598",
    WebAddress = "http://www.tmbyxbeecompanypc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Yuki",
    LastName = "Whobrey",
    Salary = 55550000.0M,
    Company = "Farmers Insurance Group",
    City = "Taylor",
    Address = "1 State Route 27",
    Email = "yuki_whobrey@aol.com",
    PhoneNumber = "313-288-7937",
    WebAddress = "http://www.farmersinsurancegroup.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Fletcher",
    LastName = "Flosi",
    Salary = 55550000.0M,
    Company = "Post Box Services Plus",
    City = "Rockford",
    Address = "394 Manchester Blvd",
    Email = "fletcher.flosi@yahoo.com",
    PhoneNumber = "815-828-2147",
    WebAddress = "http://www.postboxservicesplus.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Bette",
    LastName = "Nicka",
    Salary = 55550000.0M,
    Company = "Sport En Art",
    City = "Aston",
    Address = "6 S 33rd St",
    Email = "bette_nicka@cox.net",
    PhoneNumber = "610-545-3615",
    WebAddress = "http://www.sportenart.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Veronika",
    LastName = "Inouye",
    Salary = 55550000.0M,
    Company = "C 4 Network Inc",
    City = "San Jose",
    Address = "6 Greenleaf Ave",
    Email = "vinouye@aol.com",
    PhoneNumber = "408-540-1785",
    WebAddress = "http://www.cnetworkinc.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Willard",
    LastName = "Kolmetz",
    Salary = 55550000.0M,
    Company = "Ingalls, Donald R Esq",
    City = "Irving",
    Address = "618 W Yakima Ave",
    Email = "willard@hotmail.com",
    PhoneNumber = "972-303-9197",
    WebAddress = "http://www.ingallsdonaldresq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Maryann",
    LastName = "Royster",
    Salary = 55550000.0M,
    Company = "Franklin, Peter L Esq",
    City = "Albany",
    Address = "74 S Westgate St",
    Email = "mroyster@royster.com",
    PhoneNumber = "518-966-7987",
    WebAddress = "http://www.franklinpeterlesq.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Alisha",
    LastName = "Slusarski",
    Salary = 55550000.0M,
    Company = "Wtlz Power 107 Fm",
    City = "Middlesex",
    Address = "3273 State St",
    Email = "alisha@slusarski.com",
    PhoneNumber = "732-658-3154",
    WebAddress = "http://www.wtlzpowerfm.com",
}
, new Employee()
{
    Id = id++,
    FirstName = "Allene",
    LastName = "Iturbide",
    Salary = 55550000.0M,
    Company = "Ledecky, David Esq",
    City = "Stevens Point",
    Address = "1 Central Ave",
    Email = "allene_iturbide@cox.net",
    PhoneNumber = "715-662-6764",
    WebAddress = "http://www.ledeckydavidesq.com",
}

            );

            
        }


    }
}
