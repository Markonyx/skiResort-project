namespace SkiResortService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkiResortService.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SkiResortService.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Mountains.AddOrUpdate(
                new Models.Mountain()
                {
                    _id = 0,
                    name = "Kopaonik",
                    description = "Kopaonik is one of the larger mountain ranges of Serbia and Kosovo. " +
                    "It is located in the central part of Serbia and the northern parts of Kosovo. Its highest point, " +
                    "Pancic's Peak, is 2,017 m (6,617 ft) above sea level and is located on the border between the two countries. " +
                    "Kopaonik is the major ski resort of Serbia, and after Bulgaria's Bansko, largest in Southeast Europe. There are " +
                    "25 ski lifts with capacity of 32,000 skiers per hour. A national park spread over 118.1 km2 (45.6 sq mi) of the " +
                    "central part of the Kopaonik plateau was established in 1981.",
                    country = "Serbia",
                    highest_point = "Pancic's Peak",
                    top_elevation_m = 2017,
                    base_elevation_m = 1770,
                    picture = "assets/images/mountain/kopaonik.jpg"
                },
                new Models.Mountain()
                {
                    _id = 1,
                    name = "Jahorina",
                    description = "Jahorina is a mountain in Bosnia and Herzegovina, located near Pale in the Dinaric Alps. " +
                    "It borders Mount Trebevic, another Olympic mountain. Jahorina's highest peak, Ogorjelica, has a summit " +
                    "elevation of 1,916 metres (6,286 ft), making it the second-highest of Sarajevo's mountains, after Bjelasnica " +
                    "at 2,067 m (6,781 ft). Mount Jahorina hosted the women's alpine skiing events of the 1984 Winter Olympics. " +
                    "Jahorina is located 15 km (9.3 mi) from Pale and 30 km (19 mi) from Sarajevo. The international airport in Sarajevo " +
                    "is located 33 km (21 mi) from Jahorina, connected with the ski resort by a new motorway.",
                    country = "Bosnia and Herzegovina",
                    highest_point = "Ogorjelica",
                    top_elevation_m = 1916,
                    base_elevation_m = 1300,
                    picture = "assets/images/mountain/jahorina.jpg"
                },
                new Models.Mountain()
                {
                    _id = 2,
                    name = "Krvavec",
                    description = "The Krvavec Ski Resort is the second-largest Slovenian ski resort, located in the Municipality " +
                    "of Cerklje na Gorenjskem in the Kamnik–Savinja Alps. The nearest city is Kranj and it is 25 km from Ljubljana. " +
                    "The resort is located 10 km from Ljubljana Joze Pucnik Airport and it is the nearest ski resort to an international " +
                    "airport in Europe. It has a total 30 km of ski slopes. Today 95% of skiable area is covered with artificial snow.",
                    country = "Slovenia",
                    highest_point = "Krvavec",
                    top_elevation_m = 1971,
                    base_elevation_m = 1450,
                    picture = "assets/images/mountain/krvavec.jpg"
                }
                );
            context.SaveChanges();

            context.SkiResorts.AddOrUpdate(
                new Models.Skiresort()
                {
                    _id = 0,
                    name = "Kopaonik"
                },
                new Models.Skiresort()
                {
                    _id = 1,
                    name = "Jahorina"
                },
                new Models.Skiresort()
                {
                    _id = 2,
                    name = "Krvavec"
                }
                );
            context.SaveChanges();

            context.Tracks.AddOrUpdate(
                new Models.Track()
                {
                    _id = 0,
                    mountain_id = 1,
                    name = "Krcmar",
                    length_km = 2.2M,
                    rating = 9.9M,
                    color = "black"
                },
                new Models.Track()
                {
                    _id = 1,
                    mountain_id = 1,
                    name = "Crvena duboka",
                    length_km = 1.4M,
                    rating = 9.3M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 2,
                    mountain_id = 1,
                    name = "Karaman greben",
                    length_km = 1.2M,
                    rating = 8.9M,
                    color = "blue"
                },
                new Models.Track()
                {
                    _id = 3,
                    mountain_id = 1,
                    name = "Suncana dolina",
                    length_km = 0.9M,
                    rating = 7.6M,
                    color = "blue"
                },
                new Models.Track()
                {
                    _id = 4,
                    mountain_id = 1,
                    name = "Bela reka",
                    length_km = 1.7M,
                    rating = 8.3M,
                    color = "black"
                },
                new Models.Track()
                {
                    _id = 5,
                    mountain_id = 1,
                    name = "Gvozdac",
                    length_km = 1.5M,
                    rating = 7.7M,
                    color = "black"
                },
                new Models.Track()
                {
                    _id = 6,
                    mountain_id = 1,
                    name = "Gobelja",
                    length_km = 0.8M,
                    rating = 7.5M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 7,
                    mountain_id = 2,
                    name = "Poljice",
                    length_km = 1.7M,
                    rating = 8.0M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 8,
                    mountain_id = 2,
                    name = "Olimpijski ski lift",
                    length_km = 1.4M,
                    rating = 9.5M,
                    color = "black"
                },
                new Models.Track()
                {
                    _id = 9,
                    mountain_id = 2,
                    name = "Ogorjelica",
                    length_km = 1.4M,
                    rating = 9.5M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 10,
                    mountain_id = 2,
                    name = "Praca",
                    length_km = 0.8M,
                    rating = 8.8M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 11,
                    mountain_id = 2,
                    name = "Zvoh",
                    length_km = 1.7M,
                    rating = 7.9M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 12,
                    mountain_id = 3,
                    name = "Dom - Kriska planina",
                    length_km = 0.7M,
                    rating = 6.5M,
                    color = "blue"
                },
                new Models.Track()
                {
                    _id = 13,
                    mountain_id = 3,
                    name = "neteptani Zvoh (freeride)",
                    length_km = 1.8M,
                    rating = 7.7M,
                    color = "black"
                },
                new Models.Track()
                {
                    _id = 14,
                    mountain_id = 3,
                    name = "Hanek",
                    length_km = 0.7M,
                    rating = 6.3M,
                    color = "red"
                },
                new Models.Track()
                {
                    _id = 15,
                    mountain_id = 3,
                    name = "Vrh Krvavca - Gradisce - Tiha dolina",
                    length_km = 2.0M,
                    rating = 9.2M,
                    color = "blue"
                }
                );
            context.SaveChanges();

            context.Weathers.AddOrUpdate(
                new Models.Weather()
                {
                    _id = 0,
                    mountain_id = 1,
                    date = "2017-03-22T17:30:55.588Z",
                    temperature_min = 4,
                    temperature_max = 12,
                    wind = 3M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 1,
                    mountain_id = 1,
                    date = "2017-03-23T17:30:55.588Z",
                    temperature_min = 5,
                    temperature_max = 18,
                    wind = 1.4M,
                    outlook = "rainy"
                },
                new Models.Weather()
                {
                    _id = 2,
                    mountain_id = 1,
                    date = "2017-03-24T17:30:55.588Z",
                    temperature_min = 6,
                    temperature_max = 19,
                    wind = 1.7M,
                    outlook = "sunny"
                },
                new Models.Weather()
                {
                    _id = 3,
                    mountain_id = 1,
                    date = "2017-03-25T17:30:55.588Z",
                    temperature_min = 0,
                    temperature_max = 4,
                    wind = 1.2M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 4,
                    mountain_id = 1,
                    date = "2017-03-26T17:30:55.588Z",
                    temperature_min = -1,
                    temperature_max = 2,
                    wind = 1.7M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 5,
                    mountain_id = 1,
                    date = "2017-03-27T17:30:55.588Z",
                    temperature_min = -2,
                    temperature_max = 0,
                    wind = 1.6M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 6,
                    mountain_id = 1,
                    date = "2017-03-28T17:30:55.588Z",
                    temperature_min = -4,
                    temperature_max = 9,
                    wind = 0.9M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 7,
                    mountain_id = 2,
                    date = "2017-03-22T17:30:55.588Z",
                    temperature_min = -4,
                    temperature_max = 12,
                    wind = 1.1M,
                    outlook = "sunny"
                },
                new Models.Weather()
                {
                    _id = 8,
                    mountain_id = 2,
                    date = "2017-03-23T17:30:55.588Z",
                    temperature_min = -3,
                    temperature_max = 12,
                    wind = 1.4M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 9,
                    mountain_id = 2,
                    date = "2017-03-24T17:30:55.588Z",
                    temperature_min = -4,
                    temperature_max = 12,
                    wind = 1.9M,
                    outlook = "rainy"
                },
                new Models.Weather()
                {
                    _id = 10,
                    mountain_id = 2,
                    date = "2017-03-25T17:30:55.588Z",
                    temperature_min = -5,
                    temperature_max = 7,
                    wind = 2.0M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 11,
                    mountain_id = 2,
                    date = "2017-03-26T17:30:55.588Z",
                    temperature_min = -5,
                    temperature_max = 5,
                    wind = 1.9M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 12,
                    mountain_id = 2,
                    date = "2017-03-27T17:30:55.588Z",
                    temperature_min = -5,
                    temperature_max = 2,
                    wind = 1.6M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 13,
                    mountain_id = 2,
                    date = "2017-03-28T17:30:55.588Z",
                    temperature_min = -4,
                    temperature_max = 3,
                    wind = 1.1M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 14,
                    mountain_id = 3,
                    date = "2017-03-22T17:30:55.588Z",
                    temperature_min = 2,
                    temperature_max = 12,
                    wind = 0.9M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 15,
                    mountain_id = 3,
                    date = "2017-03-23T17:30:55.588Z",
                    temperature_min = 1,
                    temperature_max = 10,
                    wind = 1.1M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 16,
                    mountain_id = 3,
                    date = "2017-03-24T17:30:55.588Z",
                    temperature_min = 0,
                    temperature_max = 8,
                    wind = 1M,
                    outlook = "cloudy"
                },
                new Models.Weather()
                {
                    _id = 17,
                    mountain_id = 3,
                    date = "2017-03-25T17:30:55.588Z",
                    temperature_min = -2,
                    temperature_max = 5,
                    wind = 1.5M,
                    outlook = "rainy"
                },
                new Models.Weather()
                {
                    _id = 18,
                    mountain_id = 3,
                    date = "2017-03-26T17:30:55.588Z",
                    temperature_min = -3,
                    temperature_max = 2,
                    wind = 1.6M,
                    outlook = "rainy"
                },
                new Models.Weather()
                {
                    _id = 19,
                    mountain_id = 3,
                    date = "2017-03-27T17:30:55.588Z",
                    temperature_min = -4,
                    temperature_max = 0,
                    wind = 1.4M,
                    outlook = "snowy"
                },
                new Models.Weather()
                {
                    _id = 20,
                    mountain_id = 3,
                    date = "2017-03-28T17:30:55.588Z",
                    temperature_min = -3,
                    temperature_max = 4,
                    wind = 1.1M,
                    outlook = "sunny"
                }
                );
            context.SaveChanges();

            context.Skipasses.AddOrUpdate(
                new Models.Skipass()
                {
                    _id = 0,
                    mountain_id = 1,
                    duration = 1,
                    price = 3200
                },
                new Models.Skipass()
                {
                    _id = 1,
                    mountain_id = 1,
                    duration = 2,
                    price = 5990
                },
                new Models.Skipass()
                {
                    _id = 2,
                    mountain_id = 1,
                    duration = 3,
                    price = 8590
                }, new Models.Skipass()
                {
                    _id = 3,
                    mountain_id = 1,
                    duration = 4,
                    price = 10710
                },
                new Models.Skipass()
                {
                    _id = 4,
                    mountain_id = 1,
                    duration = 5,
                    price = 12480
                },
                new Models.Skipass()
                {
                    _id = 5,
                    mountain_id = 1,
                    duration = 6,
                    price = 14320
                },
                new Models.Skipass()
                {
                    _id = 6,
                    mountain_id = 1,
                    duration = 7,
                    price = 15910
                },
                new Models.Skipass()
                {
                    _id = 7,
                    mountain_id = 2,
                    duration = 1,
                    price = 2482
                }, new Models.Skipass()
                {
                    _id = 8,
                    mountain_id = 2,
                    duration = 2,
                    price = 4095
                },
                new Models.Skipass()
                {
                    _id = 9,
                    mountain_id = 2,
                    duration = 3,
                    price = 6205
                },
                new Models.Skipass()
                {
                    _id = 10,
                    mountain_id = 2,
                    duration = 4,
                    price = 7571
                },
                new Models.Skipass()
                {
                    _id = 11,
                    mountain_id = 2,
                    duration = 5,
                    price = 9178
                },
                new Models.Skipass()
                {
                    _id = 12,
                    mountain_id = 2,
                    duration = 6,
                    price = 10760
                },
                new Models.Skipass()
                {
                    _id = 13,
                    mountain_id = 2,
                    duration = 7,
                    price = 11900
                },
                new Models.Skipass()
                {
                    _id = 14,
                    mountain_id = 3,
                    duration = 1,
                    price = 3971
                },
                new Models.Skipass()
                {
                    _id = 15,
                    mountain_id = 3,
                    duration = 2,
                    price = 7571
                },
                new Models.Skipass()
                {
                    _id = 16,
                    mountain_id = 3,
                    duration = 3,
                    price = 10549
                },
                new Models.Skipass()
                {
                    _id = 17,
                    mountain_id = 3,
                    duration = 4,
                    price = 11542
                },
                new Models.Skipass()
                {
                    _id = 18,
                    mountain_id = 3,
                    duration = 5,
                    price = 13625
                },
                new Models.Skipass()
                {
                    _id = 19,
                    mountain_id = 3,
                    duration = 6,
                    price = 15886
                },
                new Models.Skipass()
                {
                    _id = 20,
                    mountain_id = 3,
                    duration = 7,
                    price = 17748
                }
                );
            context.SaveChanges();
        }
    }
}
