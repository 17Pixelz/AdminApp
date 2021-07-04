using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class migrationFInale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 680, DateTimeKind.Local).AddTicks(4677), 2477 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2758), 2072, "Releve de note" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2857), 2344, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2878), 2447, "Releve de note" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2896), 2449 });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Trisha", "EE58199", 1, "G5272", new DateTime(1985, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Roy.Smitham5@hotmail.com", "Roy", "Smitham", "Georgia", "310-353-9068", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Denesikburgh", "EE20213", 3, "G535883", new DateTime(1980, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ramiro20@yahoo.com", "Ramiro", "Nicolas", "Venezuela", "625-770-3581", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Leifchester", "EE44609", 2, "G62648", new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Diana_Kris61@gmail.com", "Diana", "Kris", "Grenada", "908-364-9205 x313", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Dariana", "EE58530", 4, "G321966", new DateTime(1955, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Eddie.Auer37@hotmail.com", "Eddie", "Auer", "Taiwan", "(549) 338-0720 x55077" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Willowmouth", "EE47605", 2, "G556099", new DateTime(1963, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Luther_Kerluke@hotmail.com", "Luther", "Kerluke", "Cocos (Keeling) Islands", "217.691.3410 x33793" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ferryberg", "EE55918", 3, "G295863", new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Charlie34@yahoo.com", "Charlie", "Breitenberg", "Kenya", "1-751-270-8278 x2796" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Williamsonside", "EE25134", "G213093", new DateTime(1981, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Leslie.Lebsack21@hotmail.com", "Leslie", "Lebsack", "Switzerland", "356.422.8118 x29068", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kesslerfurt", "EE12909", "G498703", new DateTime(1990, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marta_Bogisich@yahoo.com", "Marta", "Bogisich", "Chad", "952.255.8553 x6756", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Moshe", "EE29629", "G207425", new DateTime(1994, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Christina_Wilkinson53@gmail.com", "Christina", "Wilkinson", "Mongolia", "(602) 331-5712 x7109" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Toney", "EE53583", 2, "G547567", new DateTime(1958, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marguerite_Witting@yahoo.com", "Marguerite", "Witting", "Tuvalu", "1-467-449-6962 x290", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2010,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Gregorymouth", "EE52369", 3, "G248402", new DateTime(1970, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo_Mertz@yahoo.com", "Guillermo", "Mertz", "Malawi", "(472) 955-7428", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Joshuafurt", "EE16252", 3, "G31065", new DateTime(1970, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sheila_Witting47@hotmail.com", "Sheila", "Witting", "Brunei Darussalam", "(825) 793-5512" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Carolynville", "EE58659", 3, "G50658", new DateTime(1963, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sue_Grant30@yahoo.com", "Sue", "Grant", "Japan", "1-979-816-7806 x66522" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kesslertown", "EE47883", 3, "G378758", new DateTime(1956, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Fahey@yahoo.com", "Leroy", "Fahey", "United States Minor Outlying Islands", "644-269-3488 x420", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Brendan", "EE38433", "G167246", new DateTime(1995, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Evelyn.Haag61@gmail.com", "Evelyn", "Haag", "Kyrgyz Republic", "1-227-517-1256 x30258", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Nedra", "EE8981", 1, "G572008", new DateTime(1982, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Robin_Abshire@gmail.com", "Robin", "Abshire", "Qatar", "(256) 606-7989 x287" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Mya", "EE21738", "G174995", new DateTime(1969, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Hope24@gmail.com", "Hope", "Schiller", "Portugal", "423.908.8588 x075", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2017,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Margaretburgh", "EE15986", 3, "G429462", new DateTime(1978, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Raquel_Connelly59@yahoo.com", "Raquel", "Connelly", "Botswana", "595.765.5316", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2018,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Beierport", "EE13957", "G71149", new DateTime(1962, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Luz_Stracke@gmail.com", "Luz", "Stracke", "United States Minor Outlying Islands", "403-386-0293", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nicomouth", "EE36995", "G475976", new DateTime(1954, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Maryann74@hotmail.com", "Maryann", "Carter", "Panama", "(974) 495-0965 x9479" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Gerryton", "EE44651", 1, "G209799", new DateTime(1959, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Irene_Hyatt93@hotmail.com", "Irene", "Hyatt", "Netherlands Antilles", "443.909.1752", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Harrisonstad", "EE5154", "G465079", new DateTime(1951, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lana.Christiansen@yahoo.com", "Lana", "Christiansen", "Panama", "1-256-960-2889", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Noahville", "EE26358", 2, "G82337", new DateTime(1970, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Leroy57@hotmail.com", "Leroy", "Walter", "Angola", "644.871.5435" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Darbyhaven", "EE59742", "G23808", new DateTime(1993, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Paul49@gmail.com", "Paul", "Ratke", "Finland", "360.466.2297", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jaronstad", "EE33634", 1, "G376937", new DateTime(1999, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Seth_Mayer@gmail.com", "Seth", "Mayer", "Poland", "(825) 839-5046 x5170" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cristophertown", "EE9209", "G153733", new DateTime(1956, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kristi8@yahoo.com", "Kristi", "O'Keefe", "Tuvalu", "411.976.1838" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobibury", "EE59080", "G580236", new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Anthony_Kreiger@yahoo.com", "Anthony", "Kreiger", "Tanzania", "1-356-236-5189" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2027,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Madgeside", "EE25617", 3, "G278757", new DateTime(1959, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Linda.Pfannerstill21@gmail.com", "Linda", "Pfannerstill", "India", "(896) 686-2278" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2028,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Brandyn", "EE12162", 2, "G520884", new DateTime(1980, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Margie.Effertz5@gmail.com", "Margie", "Effertz", "Netherlands Antilles", "389.565.2278" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2029,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Makennaside", "EE32363", 2, "G526769", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Drew_West0@yahoo.com", "Drew", "West", "Australia", "(407) 756-0399" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2030,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Clifford", "EE51827", 2, "G381991", new DateTime(1995, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Betsy81@hotmail.com", "Betsy", "Cassin", "Japan", "837.891.3929", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2031,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Tess", "EE12963", "G592029", new DateTime(1973, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas26@gmail.com", "Nicolas", "Yost", "Bolivia", "304.314.7553" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Christian", "EE48202", "G178899", new DateTime(1976, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Chelsea99@gmail.com", "Chelsea", "Durgan", "Guyana", "(472) 767-4735 x78034" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2033,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hilpertborough", "EE55272", "G413146", new DateTime(1982, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Wilbur_Bogan4@yahoo.com", "Wilbur", "Bogan", "Jordan", "(459) 876-6142" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2034,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Leofort", "EE23978", 4, "G314926", new DateTime(1974, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Cornelius54@gmail.com", "Cornelius", "Kovacek", "Malta", "374.458.3716" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2035,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Williamsonmouth", "EE29710", 4, "G277673", new DateTime(1963, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Loren.Quigley@yahoo.com", "Loren", "Quigley", "Micronesia", "353.925.7949 x6300", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Camillaberg", "EE31869", 4, "G508161", new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "April73@hotmail.com", "April", "O'Keefe", "Svalbard & Jan Mayen Islands", "1-405-256-2725 x33108" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Naderbury", "EE28734", "G234022", new DateTime(1985, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Angie.Will18@yahoo.com", "Angie", "Will", "Bermuda", "1-316-539-0635 x39326", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Coltbury", "EE459", 4, "G25124", new DateTime(1979, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lena.Walter86@hotmail.com", "Lena", "Walter", "Slovenia", "1-658-857-3023 x3706", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Teaganfort", "EE2542", 2, "G430687", new DateTime(1980, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Marcus68@gmail.com", "Marcus", "Romaguera", "French Polynesia", "1-364-567-3109 x95555" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2040,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Emmerichview", "EE46295", 1, "G328555", new DateTime(1999, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Gwendolyn15@gmail.com", "Gwendolyn", "Flatley", "New Zealand", "305-203-6295", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2041,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ankundingview", "EE12319", 2, "G352892", new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Alfonso.Ondricka81@yahoo.com", "Alfonso", "Ondricka", "Turkey", "1-214-750-5508 x135", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Kaitlyn", "EE30262", 1, "G28296", new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Clay7@hotmail.com", "Clay", "Predovic", "Myanmar", "(268) 678-0005 x9968" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Stracketown", "EE57897", 1, "G75316", new DateTime(1985, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Alexandra22@gmail.com", "Alexandra", "Jacobi", "Croatia", "447.255.7345" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Lourdes", "EE16417", "G483898", new DateTime(1974, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kristi.Heathcote@hotmail.com", "Kristi", "Heathcote", "Mali", "1-828-296-3234", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zenafort", "EE4219", 1, "G391614", new DateTime(1953, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Hattie82@gmail.com", "Hattie", "Buckridge", "Israel", "1-337-794-1126 x838" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Eltaton", "EE9116", 4, "G559432", new DateTime(1980, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Misty_Paucek89@yahoo.com", "Misty", "Paucek", "Spain", "1-840-848-9005", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Emelieside", "EE10473", "G94229", new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bob.Lemke@hotmail.com", "Bob", "Lemke", "Norway", "741-583-3712 x54011" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2048,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Christy", "EE39100", "G496249", new DateTime(1970, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Pat_Greenholt@hotmail.com", "Pat", "Greenholt", "Namibia", "(240) 609-4119 x75725", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2049,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Casandramouth", "EE9738", "G212023", new DateTime(1973, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Janie58@hotmail.com", "Janie", "Jacobi", "Gambia", "266-724-5001 x910", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Santiagoview", "EE36386", 1, "G162620", new DateTime(1977, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lynne_Cruickshank@yahoo.com", "Lynne", "Cruickshank", "Kazakhstan", "871-487-0979 x365", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Annamarietown", "EE57291", 2, "G437820", new DateTime(1994, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lucy.Pfeffer@yahoo.com", "Lucy", "Pfeffer", "Guatemala", "1-652-992-5045 x9236", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Conradport", "EE31372", 4, "G164755", new DateTime(1999, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Anne9@hotmail.com", "Anne", "O'Kon", "Switzerland", "689.561.7899 x75823" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2053,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Claire", "EE37914", 4, "G307759", new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Orville.Vandervort@hotmail.com", "Orville", "Vandervort", "Micronesia", "748-394-8569 x9305", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2054,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Nickolas", "EE30790", 4, "G72754", new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shirley80@hotmail.com", "Shirley", "Abbott", "El Salvador", "661.604.2827 x622", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Tracy", "EE20885", "G102898", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Erick.Denesik@hotmail.com", "Erick", "Denesik", "Seychelles", "1-556-895-5906 x756" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nitzschechester", "EE6290", "G168182", new DateTime(2000, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Mike47@yahoo.com", "Mike", "Sauer", "Malawi", "(963) 679-1587 x5595", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2057,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Russton", "EE42300", 2, "G552876", new DateTime(1970, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kendra3@hotmail.com", "Kendra", "Herzog", "Dominican Republic", "264-607-1820" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2058,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Bianka", "EE46266", "G261900", new DateTime(1956, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa86@hotmail.com", "Vanessa", "Lockman", "Thailand", "688-889-9054 x7847" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2059,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "O'Reillychester", "EE11300", "G287815", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Marianne4@hotmail.com", "Marianne", "Schumm", "Canada", "571.527.6208 x50322", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2060,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bernhardside", "EE54949", 3, "G550078", new DateTime(1989, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Angelica33@yahoo.com", "Angelica", "Tromp", "Antigua and Barbuda", "489.374.8510 x37767" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kenyonberg", "EE43624", 2, "G324884", new DateTime(1953, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hugh15@yahoo.com", "Hugh", "Kirlin", "Qatar", "374.547.6733 x57435", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2062,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Heloise", "EE10356", 4, "G240817", new DateTime(1974, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Claire56@hotmail.com", "Claire", "Beahan", "Mozambique", "(292) 559-5433 x30523", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2063,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Terrance", "EE1106", 1, "G173958", new DateTime(1952, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Betsy_Bayer10@hotmail.com", "Betsy", "Bayer", "Hungary", "(517) 425-4303 x229" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2064,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Armstrongshire", "EE38899", 1, "G493682", new DateTime(1962, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Brandy_Tillman30@yahoo.com", "Brandy", "Tillman", "Costa Rica", "1-683-745-8395 x4258", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Mervin", "EE52845", 4, "G125530", new DateTime(1956, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Grady20@hotmail.com", "Grady", "O'Connell", "Palestinian Territory", "1-285-760-2601" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Meghanmouth", "EE57083", "G572453", new DateTime(1975, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Chester.Williamson36@hotmail.com", "Chester", "Williamson", "Lesotho", "1-997-646-1527 x590", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2067,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Deshawnburgh", "EE36873", 1, "G428254", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Tiffany_OHara@yahoo.com", "Tiffany", "O'Hara", "Antigua and Barbuda", "237-577-3531 x45386", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2068,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abernathyburgh", "EE1900", 2, "G492470", new DateTime(1973, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Eddie.Glover11@hotmail.com", "Eddie", "Glover", "Montserrat", "726.802.9456", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tryciaberg", "EE20730", 3, "G141343", new DateTime(1958, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Juan_Jakubowski28@gmail.com", "Juan", "Jakubowski", "Tuvalu", "(264) 709-9147 x833" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Elisa", "EE38528", 2, "G413047", new DateTime(1979, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Luis.Krajcik97@gmail.com", "Luis", "Krajcik", "Niger", "379.512.6993", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Orville", "EE47202", 2, "G310662", new DateTime(1997, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Hilpert28@hotmail.com", "Shane", "Hilpert", "Kiribati", "560-417-2859 x718" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Crookschester", "EE51758", 2, "G288375", new DateTime(1981, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie44@hotmail.com", "Jeannie", "Hilll", "Albania", "861-325-1606" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Lenoraburgh", "EE27663", 4, "G160317", new DateTime(1981, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Victoria.Krajcik3@gmail.com", "Victoria", "Krajcik", "Kenya", "1-495-939-6150 x0093", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Curtmouth", "EE13742", 4, "G121776", new DateTime(1964, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Cary_Koelpin68@hotmail.com", "Cary", "Koelpin", "Holy See (Vatican City State)", "1-508-411-0516 x7444" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Chloe", "EE41690", "G182887", new DateTime(1971, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jerome33@gmail.com", "Jerome", "Jacobson", "French Guiana", "950-894-9297 x3526" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Boyerberg", "EE3219", 3, "G141023", new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Alexander.OKeefe@gmail.com", "Alexander", "O'Keefe", "Afghanistan", "518-417-0431" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Andrewland", "EE7461", "G557472", new DateTime(1970, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lula_OKon72@gmail.com", "Lula", "O'Kon", "Equatorial Guinea", "(201) 666-4315", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hicklechester", "EE58599", 3, "G132941", new DateTime(1966, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia_Dare@yahoo.com", "Sylvia", "Dare", "Spain", "1-492-469-0833", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Claudineshire", "EE25755", 3, "G71009", new DateTime(1972, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lawrence_Gleichner14@hotmail.com", "Lawrence", "Gleichner", "Paraguay", "924.984.7006", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gutmannmouth", "EE49792", "G284040", new DateTime(1970, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Charlie.Dietrich23@gmail.com", "Charlie", "Dietrich", "Kuwait", "265.365.1311 x2840", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Othafurt", "EE36884", "G488614", new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Roderick.Kovacek63@yahoo.com", "Roderick", "Kovacek", "Mongolia", "494.292.6408", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Lempifurt", "EE53443", "G219475", new DateTime(1966, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Gerlach@hotmail.com", "Tami", "Gerlach", "Tokelau", "1-418-671-8620 x154", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Thalia", "EE3109", 2, "G519999", new DateTime(1964, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lance.Tromp40@gmail.com", "Lance", "Tromp", "Gibraltar", "(285) 515-3101" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Zola", "EE32941", "G247548", new DateTime(1985, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Phil26@gmail.com", "Phil", "Kris", "Antarctica (the territory South of 60 deg S)", "840-402-1238", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Houstonport", "EE55141", 4, "G498999", new DateTime(2000, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kristine.OKeefe10@hotmail.com", "Kristine", "O'Keefe", "French Southern Territories", "730.596.2233 x01897" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2086,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Verlaton", "EE44527", "G25931", new DateTime(1970, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta_Kunze@yahoo.com", "Henrietta", "Kunze", "Tajikistan", "(593) 380-8754", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2087,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Annaliseshire", "EE30679", 2, "G427482", new DateTime(1961, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gertrude63@hotmail.com", "Gertrude", "Halvorson", "Rwanda", "(327) 691-8419", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2088,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Florian", "EE35999", 2, "G219", new DateTime(1966, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Anne.Swift@yahoo.com", "Anne", "Swift", "Nigeria", "(680) 206-4491 x301", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2089,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pasqualeside", "EE50235", 2, "G523671", new DateTime(1963, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Neal30@yahoo.com", "Neal", "Bashirian", "Sweden", "(824) 631-6800 x45545", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2090,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Oswald", "EE32197", 2, "G521572", new DateTime(1960, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Juan11@gmail.com", "Juan", "Ruecker", "Swaziland", "1-762-610-3858" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2091,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lueilwitzchester", "EE35443", 2, "G296778", new DateTime(1967, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Louise.Runolfsdottir76@hotmail.com", "Louise", "Runolfsdottir", "Guyana", "858.482.2453 x8028" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2092,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cummerataview", "EE41562", "G358399", new DateTime(1960, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Joel_Dach35@yahoo.com", "Joel", "Dach", "Sierra Leone", "(330) 811-8167", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2093,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jamie", "EE32950", "G278394", new DateTime(1959, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mike24@hotmail.com", "Mike", "Cartwright", "Turkmenistan", "940-398-8710 x36757" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2094,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Angieburgh", "EE2142", "G220273", new DateTime(1971, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Wayne_Fisher@gmail.com", "Wayne", "Fisher", "Puerto Rico", "(796) 918-1011 x6639", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2095,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Powlowskifort", "EE38962", 3, "G557902", new DateTime(1961, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Latoya_Bauch@yahoo.com", "Latoya", "Bauch", "Barbados", "(225) 461-6433 x7716", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2096,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Doylechester", "EE11650", 2, "G88579", new DateTime(1997, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Carla_Feest89@hotmail.com", "Carla", "Feest", "Tokelau", "1-398-733-7144 x21116" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2097,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Pansyview", "EE49464", 4, "G474732", new DateTime(1957, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ignacio_Stehr@yahoo.com", "Ignacio", "Stehr", "Colombia", "(263) 220-7320 x3591" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2098,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Michaelport", "EE13165", 3, "G454860", new DateTime(1974, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Shields@gmail.com", "Bradley", "Shields", "Bermuda", "960-978-1907" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2099,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kassulkechester", "EE44459", 1, "G20484", new DateTime(1965, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Dawn_Deckow@hotmail.com", "Dawn", "Deckow", "Samoa", "907-689-3972 x4415" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2100,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nicklausland", "EE38742", 1, "G290873", new DateTime(1952, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Cheryl.Connelly4@yahoo.com", "Cheryl", "Connelly", "Grenada", "238-309-7727 x019" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Langview", "EE41534", "G257950", new DateTime(1974, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Spencer30@yahoo.com", "Spencer", "Howe", "Bhutan", "1-426-252-4188 x344", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Benedict", "EE31301", 4, "G458166", new DateTime(1952, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Mike.Boyer@yahoo.com", "Mike", "Boyer", "Venezuela", "564.245.1065 x428" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Freedaburgh", "EE9818", "G481225", new DateTime(1952, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Irving.Wintheiser@gmail.com", "Irving", "Wintheiser", "Gabon", "293.908.0631 x08735" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Tateshire", "EE8823", "G548735", new DateTime(1982, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Dach40@hotmail.com", "Albert", "Dach", "Guinea-Bissau", "416-950-4468 x70595" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Annetta", "EE55931", 3, "G478369", new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cheryl.Kunde@gmail.com", "Cheryl", "Kunde", "Cote d'Ivoire", "1-899-748-9184", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Antoinetteville", "EE48212", 1, "G293682", new DateTime(1996, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jasmine.Padberg51@yahoo.com", "Jasmine", "Padberg", "Zambia", "(948) 300-9901" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2107,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Breitenbergberg", "EE40411", 3, "G377131", new DateTime(1957, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tamara.Borer@gmail.com", "Tamara", "Borer", "Mauritania", "1-878-795-4723 x9601" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2108,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jastport", "EE31688", 4, "G235010", new DateTime(1999, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Santos13@hotmail.com", "Santos", "Donnelly", "French Polynesia", "(956) 967-6813 x8604", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2109,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vivienborough", "EE33274", 3, "G247082", new DateTime(1977, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ginger_Stiedemann67@hotmail.com", "Ginger", "Stiedemann", "Egypt", "276.245.5332", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2110,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Thaliaport", "EE19796", 2, "G330131", new DateTime(1975, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Angie81@yahoo.com", "Angie", "Farrell", "Brazil", "358.647.4313" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2111,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Ressieville", "EE34397", 4, "G77048", new DateTime(1953, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Gertrude_Corwin@hotmail.com", "Gertrude", "Corwin", "Virgin Islands, U.S.", "699.592.6438", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2112,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Dolores", "EE45581", "G179562", new DateTime(1980, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Wendy82@yahoo.com", "Wendy", "Graham", "Gabon", "(672) 255-3246 x24267" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Heathcotefort", "EE14716", 2, "G454736", new DateTime(1998, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kim_Cassin0@gmail.com", "Kim", "Cassin", "French Southern Territories", "781.675.8268 x30616" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Walshville", "EE8239", 3, "G340494", new DateTime(1979, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Victor78@gmail.com", "Victor", "Krajcik", "Estonia", "252-591-0539 x992" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brakusland", "EE954", 4, "G441329", new DateTime(1959, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Pablo_Davis@yahoo.com", "Pablo", "Davis", "Virgin Islands, U.S.", "(962) 410-2263", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Presleyport", "EE3372", "G120680", new DateTime(1976, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Misty81@hotmail.com", "Misty", "Pfeffer", "French Guiana", "317.923.9726 x16893" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Romaine", "EE27180", "G210873", new DateTime(1997, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Guadalupe27@hotmail.com", "Guadalupe", "Rogahn", "Italy", "1-913-783-1052", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kamrynport", "EE59404", 2, "G79639", new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cesar.Hodkiewicz49@hotmail.com", "Cesar", "Hodkiewicz", "Jamaica", "352-209-3043 x812", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Baileyville", "EE11329", 4, "G375599", new DateTime(1977, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Mack_Ondricka59@yahoo.com", "Mack", "Ondricka", "Netherlands", "202.224.1130" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cooperland", "EE37171", 2, "G351704", new DateTime(1989, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne77@gmail.com", "Adrienne", "Beahan", "Saudi Arabia", "239-566-2678 x04672" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2121,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rennerbury", "EE43406", 2, "G409808", new DateTime(1984, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Tara_McClure47@gmail.com", "Tara", "McClure", "Belgium", "631.855.8248", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2122,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Damon", "EE4319", 2, "G338678", new DateTime(1997, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Rochelle_Block62@gmail.com", "Rochelle", "Block", "Kiribati", "331.545.4314 x909" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2123,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Madilynburgh", "EE39098", 3, "G552136", new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kerry67@yahoo.com", "Kerry", "Terry", "Pakistan", "661.682.2230" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2124,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnstonmouth", "EE49044", 1, "G313823", new DateTime(1956, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sergio90@yahoo.com", "Sergio", "Larkin", "Colombia", "917.606.8662 x472", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2125,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jaybury", "EE31305", 1, "G465057", new DateTime(1987, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Justin_Hansen@hotmail.com", "Justin", "Hansen", "Congo", "1-578-241-8116" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2126,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Alivia", "EE14496", 4, "G549781", new DateTime(1986, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Doyle29@yahoo.com", "Doyle", "Crooks", "Netherlands Antilles", "(314) 687-6501", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Bailey", "EE34218", 3, "G441749", new DateTime(1963, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Simon.Schimmel@yahoo.com", "Simon", "Schimmel", "Swaziland", "574.756.2452", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2128,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutmannfort", "EE18190", 4, "G429697", new DateTime(1988, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "Timmy_King@gmail.com", "Timmy", "King", "Mayotte", "636-711-4898 x3968" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2129,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Douglasland", "EE3436", 2, "G474140", new DateTime(1968, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Joe.Feest26@hotmail.com", "Joe", "Feest", "Poland", "406.936.4778 x095" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hankborough", "EE51057", 2, "G176490", new DateTime(1974, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Ronnie63@gmail.com", "Ronnie", "Sipes", "Vietnam", "1-868-523-5882 x7985", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ryanport", "EE16443", 4, "G450321", new DateTime(1980, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cassandra_Conn@gmail.com", "Cassandra", "Conn", "Oman", "398.558.5888", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2132,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Jettieton", "EE43507", 3, "G26675", new DateTime(1971, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Flora29@hotmail.com", "Flora", "Donnelly", "Isle of Man", "272-611-2666 x87255" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2133,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Kristoffer", "EE24943", 2, "G166510", new DateTime(1983, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jack80@hotmail.com", "Jack", "O'Conner", "Libyan Arab Jamahiriya", "1-636-570-5930 x3515" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2134,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Natstad", "EE37303", "G533981", new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Joey67@gmail.com", "Joey", "Shanahan", "Iceland", "364-835-1782" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2135,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Adamview", "EE34096", 3, "G489258", new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Earl_Quigley@yahoo.com", "Earl", "Quigley", "South Georgia and the South Sandwich Islands", "1-349-434-7700" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "McGlynnbury", "EE57606", 2, "G550563", new DateTime(1972, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne.Leuschke94@yahoo.com", "Adrienne", "Leuschke", "Syrian Arab Republic", "314.694.5193 x21235" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Berenicemouth", "EE23561", 1, "G568599", new DateTime(1957, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Wade_Grant49@hotmail.com", "Wade", "Grant", "Taiwan", "1-336-538-3347 x7120", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Madie", "EE19975", 2, "G163506", new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Becky59@gmail.com", "Becky", "Bashirian", "Lesotho", "(916) 655-0533 x7517" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ledafort", "EE24411", "G179649", new DateTime(1956, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lena.Predovic@yahoo.com", "Lena", "Predovic", "Tanzania", "(311) 772-8252 x428" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Emilianomouth", "EE36114", "G396339", new DateTime(1979, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Amelia_Marquardt@yahoo.com", "Amelia", "Marquardt", "Chile", "257-967-9100 x75175" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Oralport", "EE7636", 1, "G355936", new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Leonard_Rippin@gmail.com", "Leonard", "Rippin", "Mozambique", "1-608-851-2361 x46443", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Ollie", "EE27064", "G389422", new DateTime(1973, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Levi_Barton84@yahoo.com", "Levi", "Barton", "Saint Lucia", "897.251.6192 x909" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2143,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Rosalindaville", "EE33554", 1, "G104029", new DateTime(1965, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hilda.Connelly3@hotmail.com", "Hilda", "Connelly", "Libyan Arab Jamahiriya", "623.396.4355", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2144,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mauriciofort", "EE28365", "G274167", new DateTime(1964, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Glen64@gmail.com", "Glen", "Armstrong", "Monaco", "(451) 746-2924 x8265" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2145,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Chesley", "EE17238", 2, "G344546", new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell77@gmail.com", "Mitchell", "Langosh", "Saint Barthelemy", "1-255-537-2464" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2146,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Evaside", "EE52929", "G349099", new DateTime(1969, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Cary.Rodriguez@gmail.com", "Cary", "Rodriguez", "Guam", "435-448-6573 x6597", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Drakeburgh", "EE29860", "G238903", new DateTime(1990, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Johnny.Leuschke43@gmail.com", "Johnny", "Leuschke", "Paraguay", "238-787-5370", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2148,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Markustown", "EE45928", 1, "G513117", new DateTime(1956, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Neal38@gmail.com", "Neal", "Ondricka", "Palau", "(847) 798-4456 x2991" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2149,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Watsicaberg", "EE45729", 2, "G485015", new DateTime(2000, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lynn_Dooley@hotmail.com", "Lynn", "Dooley", "Tunisia", "473-528-0603", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2150,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Morissetteberg", "EE51295", 1, "G310608", new DateTime(1970, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Doug_Morar@gmail.com", "Doug", "Morar", "Nicaragua", "1-704-816-2845" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2151,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Skylarberg", "EE42121", 4, "G106751", new DateTime(1960, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Patty_Cronin48@hotmail.com", "Patty", "Cronin", "United Arab Emirates", "909.526.7010 x3790", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "Medhurstland", "EE4768", 4, "G74173", new DateTime(1955, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kirk_McGlynn19@gmail.com", "Kirk", "McGlynn", "484.765.8273 x74805", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ziemebury", "EE11858", 1, "G347536", new DateTime(1991, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lee_Zemlak36@hotmail.com", "Lee", "Zemlak", "Greece", "380-522-5286 x03660", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2154,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Virginia", "EE51811", "G341842", new DateTime(1976, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Frank29@hotmail.com", "Frank", "Fritsch", "Grenada", "616.749.1938" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2155,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bethport", "EE28317", 2, "G187159", new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred.Kassulke@yahoo.com", "Wilfred", "Kassulke", "Christmas Island", "(694) 407-6170", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2156,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Uptonton", "EE5245", 3, "G292338", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Elizabeth.Murphy@hotmail.com", "Elizabeth", "Murphy", "Brunei Darussalam", "966.477.4973", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2157,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kochside", "EE52454", 1, "G250833", new DateTime(1967, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kayla_Upton@yahoo.com", "Kayla", "Upton", "Sierra Leone", "768-865-9727" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Edwinaberg", "EE10233", "G79047", new DateTime(1968, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Christopher54@gmail.com", "Christopher", "Zboncak", "Malawi", "754-939-8068 x35700", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Monserratland", "EE53282", 3, "G338710", new DateTime(1987, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lula38@yahoo.com", "Lula", "Fritsch", "Vanuatu", "(991) 645-2830 x652" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Clevelandchester", "EE56137", 2, "G158665", new DateTime(1965, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jody25@yahoo.com", "Jody", "Bednar", "Mayotte", "(310) 454-4915" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Connhaven", "EE46490", "G466468", new DateTime(1962, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Eileen_Gleichner42@yahoo.com", "Eileen", "Gleichner", "Rwanda", "884-953-6339" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2162,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Clotilde", "EE21545", 4, "G451919", new DateTime(1981, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Toby_McCullough@hotmail.com", "Toby", "McCullough", "Russian Federation", "376-946-1169 x458" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2163,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brainchester", "EE35044", 4, "G446737", new DateTime(1969, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kay66@yahoo.com", "Kay", "Torphy", "Myanmar", "403.207.1787", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2164,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jarvishaven", "EE55429", 4, "G292799", new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Lindsay55@hotmail.com", "Lindsay", "Considine", "Jordan", "1-499-697-2219 x8405" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2165,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nicola", "EE8061", 4, "G307996", new DateTime(1994, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Stanley38@hotmail.com", "Stanley", "Romaguera", "Cocos (Keeling) Islands", "1-429-644-8088", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Angelafurt", "EE57884", "G492565", new DateTime(1985, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Darrel_Robel71@yahoo.com", "Darrel", "Robel", "Kenya", "1-483-255-0124" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stammborough", "EE19928", "G481426", new DateTime(1984, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jane_Schmitt29@yahoo.com", "Jane", "Schmitt", "Sweden", "696-789-9150 x4693", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dibbertberg", "EE23522", "G230983", new DateTime(1996, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell_Koch41@gmail.com", "Mitchell", "Koch", "El Salvador", "(432) 801-9427 x3396" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Clydeland", "EE23952", 3, "G386132", new DateTime(1976, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Daryl_Harber@yahoo.com", "Daryl", "Harber", "Canada", "293.368.6327" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2170,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cordellton", "EE35154", "G88287", new DateTime(1973, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.Stracke58@yahoo.com", "Maryann", "Stracke", "United States of America", "(818) 587-2687 x11019", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2171,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Skilesview", "EE55537", "G48498", new DateTime(1977, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jessica.Orn15@yahoo.com", "Jessica", "Orn", "Macao", "(202) 281-4287 x0182", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ashlyton", "EE26918", 2, "G59998", new DateTime(1970, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Boyd6@gmail.com", "Boyd", "Weimann", "Sudan", "360-777-3938 x33321" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bridiefort", "EE50386", 4, "G129863", new DateTime(1966, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sam56@hotmail.com", "Sam", "Crist", "Croatia", "1-341-294-1479" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2174,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Spinkaville", "EE2841", 1, "G562368", new DateTime(1963, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Christy.Sauer93@gmail.com", "Christy", "Sauer", "Turks and Caicos Islands", "1-232-560-5285 x68274" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2175,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Rahul", "EE32740", "G521333", new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Annette.Parker@yahoo.com", "Annette", "Parker", "Mongolia", "(309) 977-9518 x9095", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2176,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Claudstad", "EE5841", "G84777", new DateTime(1974, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kristina.McKenzie95@gmail.com", "Kristina", "McKenzie", "Puerto Rico", "258-813-3638 x9482" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2177,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Carmella", "EE35618", 3, "G40987", new DateTime(1960, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Clara.Walker7@yahoo.com", "Clara", "Walker", "Bhutan", "(399) 331-9648 x4028" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2178,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cristhaven", "EE42434", 3, "G208533", new DateTime(1955, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Van.Cruickshank@hotmail.com", "Van", "Cruickshank", "Guinea-Bissau", "703-635-5562", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kameronville", "EE57907", 3, "G486029", new DateTime(1977, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wm50@gmail.com", "Wm", "Hilpert", "Liechtenstein", "890-291-5326 x67409" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Dustin", "EE4246", "G424076", new DateTime(1971, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ivan_Johnston@gmail.com", "Ivan", "Johnston", "Luxembourg", "205.985.5456 x5963", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carriechester", "EE43130", 1, "G144063", new DateTime(1982, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Alberto_Turcotte@gmail.com", "Alberto", "Turcotte", "Central African Republic", "1-833-695-3644", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Arielton", "EE2832", "G351023", new DateTime(1963, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Franecki14@gmail.com", "Lucille", "Franecki", "Germany", "745.479.9826" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2183,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Josephinefurt", "EE9248", 2, "G83556", new DateTime(1973, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Irene.Thompson84@gmail.com", "Irene", "Thompson", "Cameroon", "929-467-1890" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2184,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Mckenzie", "EE22602", "G297203", new DateTime(1998, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Emmett_Altenwerth15@yahoo.com", "Emmett", "Altenwerth", "Papua New Guinea", "688-580-4970 x38297", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Rickey", "EE28443", "G324486", new DateTime(1986, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Naomi42@yahoo.com", "Naomi", "Greenfelder", "Iceland", "(788) 733-0487 x198" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2186,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnsonbury", "EE32461", 2, "G521571", new DateTime(1978, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Teresa2@gmail.com", "Teresa", "Wisoky", "Slovenia", "(516) 549-8806 x25844", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2187,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jaskolskihaven", "EE1796", "G125152", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rodney85@yahoo.com", "Rodney", "Bergnaum", "Russian Federation", "555.375.2269", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2188,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Willborough", "EE52188", "G496701", new DateTime(2000, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Yvonne_Fadel@hotmail.com", "Yvonne", "Fadel", "Dominica", "(295) 689-5292" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2189,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Giovannyville", "EE53575", 2, "G457388", new DateTime(1962, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ralph.Pollich@gmail.com", "Ralph", "Pollich", "India", "406-683-8808 x237" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2190,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Reillyport", "EE28404", 4, "G301598", new DateTime(1970, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Roberto80@gmail.com", "Roberto", "Koepp", "Serbia", "1-901-341-1287 x87941" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2191,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Carey", "EE58696", 1, "G152675", new DateTime(1992, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Katie78@gmail.com", "Katie", "D'Amore", "Anguilla", "950.469.6239 x387" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2192,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Kristopherland", "EE38463", 3, "G572306", new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Wilma10@yahoo.com", "Wilma", "Jakubowski", "Isle of Man", "(371) 842-9744", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Carissa", "EE46887", 1, "G218610", new DateTime(1954, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Roy_Murazik@gmail.com", "Roy", "Murazik", "Mayotte", "(238) 217-7683" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Johnstown", "EE17181", 1, "G216658", new DateTime(1964, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Darlene34@gmail.com", "Darlene", "Schmidt", "Barbados", "(447) 554-6794 x1549" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Emilport", "EE24488", 4, "G312847", new DateTime(1982, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Marcos_Kovacek@hotmail.com", "Marcos", "Kovacek", "Falkland Islands (Malvinas)", "1-785-212-0684", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Francescoview", "EE48914", 4, "G234695", new DateTime(1975, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Darryl.Hessel26@gmail.com", "Darryl", "Hessel", "Guadeloupe", "849.777.9795", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2197,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Vernafort", "EE59926", 2, "G483593", new DateTime(1962, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kerry_Olson@gmail.com", "Kerry", "Olson", "Fiji", "333.557.0693 x531" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2198,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Isidroburgh", "EE50692", 2, "G237086", new DateTime(1961, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Steve.Cartwright35@yahoo.com", "Steve", "Cartwright", "Burundi", "327.288.7243" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Opheliaville", "EE27448", "G54655", new DateTime(1960, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Josh81@yahoo.com", "Josh", "Wolff", "Micronesia", "417-605-6916 x201", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2200,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pricefurt", "EE46317", 4, "G8101", new DateTime(1966, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Essie.Marvin69@hotmail.com", "Essie", "Marvin", "Bangladesh", "1-875-913-3450", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2201,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mellieville", "EE26240", "G119751", new DateTime(1985, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Leslie.Tromp53@hotmail.com", "Leslie", "Tromp", "Virgin Islands, U.S.", "1-238-919-6331 x1992" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2202,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Misaeltown", "EE183", 4, "G594613", new DateTime(1988, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Leuschke76@gmail.com", "Kerry", "Leuschke", "Georgia", "(864) 606-2675 x90226", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2203,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Goldnerland", "EE13590", 3, "G567095", new DateTime(1966, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Natasha65@gmail.com", "Natasha", "Koepp", "Croatia", "(782) 391-5272 x4908" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Sherwoodport", "EE46972", 4, "G528192", new DateTime(1984, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Weissnat@yahoo.com", "Bradley", "Weissnat", "Cameroon", "616.816.2677", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ritchieton", "EE5926", 3, "G476058", new DateTime(1988, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jacob.Wolff85@hotmail.com", "Jacob", "Wolff", "Guadeloupe", "637.330.8935 x43187", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Gennaro", "EE46351", "G189019", new DateTime(1984, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Olivia25@yahoo.com", "Olivia", "Kuhlman", "Republic of Korea", "739-804-2679" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Baileyview", "EE468", 4, "G530751", new DateTime(1966, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lester.Erdman@yahoo.com", "Lester", "Erdman", "Peru", "(393) 243-3047 x486", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutmannland", "EE16875", 4, "G84084", new DateTime(1952, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Iris87@yahoo.com", "Iris", "McDermott", "Democratic People's Republic of Korea", "(770) 717-7616 x032" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ryleighfurt", "EE23735", "G138677", new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery47@gmail.com", "Jeffery", "Zemlak", "Guinea", "827.979.9783 x227" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Delmer", "EE9475", 4, "G108134", new DateTime(1975, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bob26@gmail.com", "Bob", "Nolan", "Micronesia", "(746) 408-1508 x614" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Eduardo", "EE53862", "G226489", new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Gayle_Koch30@yahoo.com", "Gayle", "Koch", "Saint Pierre and Miquelon", "220.216.7767 x9655", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Newtonfort", "EE17664", "G118489", new DateTime(1973, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Duane.Kulas@yahoo.com", "Duane", "Kulas", "Austria", "473-781-2325", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Arvidborough", "EE33344", 2, "G384307", new DateTime(1982, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ross.Legros@hotmail.com", "Ross", "Legros", "Western Sahara", "359-823-6244 x5579" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Olin", "EE21175", 3, "G50304", new DateTime(1978, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Pamela4@gmail.com", "Pamela", "Turner", "Ethiopia", "526-637-7759", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Sadye", "EE18672", "G396217", new DateTime(1969, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tonya_Satterfield7@hotmail.com", "Tonya", "Satterfield", "Afghanistan", "1-378-385-8744" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2216,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jaidenburgh", "EE18476", 4, "G92815", new DateTime(1968, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Terry8@yahoo.com", "Terry", "Nitzsche", "Serbia", "603.885.4679", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2217,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bashirianview", "EE57190", 4, "G145021", new DateTime(1992, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wade19@gmail.com", "Wade", "Goyette", "Nigeria", "934-763-2446 x833", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2218,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Oranberg", "EE18536", 4, "G397086", new DateTime(1997, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Christy_Adams@hotmail.com", "Christy", "Adams", "Saudi Arabia", "(819) 810-6806 x6628" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2219,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roweton", "EE9881", 2, "G567679", new DateTime(1960, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Deborah25@yahoo.com", "Deborah", "Luettgen", "Angola", "(310) 520-1179", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rippinview", "EE42987", 4, "G191011", new DateTime(1955, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Max18@hotmail.com", "Max", "Dickens", "Guatemala", "1-548-997-1613" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Reesemouth", "EE39375", "G181051", new DateTime(1983, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Ida17@gmail.com", "Ida", "Koelpin", "Monaco", "594-839-2854", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Emmittchester", "EE45931", "G65968", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dean76@hotmail.com", "Dean", "Larson", "Togo", "809.793.5392", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Miguelshire", "EE8258", 2, "G386481", new DateTime(1988, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Denise86@yahoo.com", "Denise", "Jaskolski", "Cameroon", "212.851.7452", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Carmelomouth", "EE22679", "G142864", new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Viola_Stokes99@hotmail.com", "Viola", "Stokes", "Vietnam", "869-896-1792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Towneview", "EE31198", 4, "G506867", new DateTime(1985, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Carol21@yahoo.com", "Carol", "Stanton", "Madagascar", "(865) 462-3036 x368", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2226,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Esperanzachester", "EE49103", 3, "G201498", new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Alonzo35@hotmail.com", "Alonzo", "Orn", "Virgin Islands, U.S.", "(574) 743-8105 x3061", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2227,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lavonnefort", "EE27367", 4, "G165323", new DateTime(1971, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Kelley.Schmitt@hotmail.com", "Kelley", "Schmitt", "Gambia", "(661) 731-4686 x7292", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Skileschester", "EE28628", 2, "G127357", new DateTime(1981, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Marc66@gmail.com", "Marc", "Terry", "Latvia", "(553) 545-4021 x912" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2229,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Rodshire", "EE53163", 1, "G471609", new DateTime(1957, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Mattie.Larson60@hotmail.com", "Mattie", "Larson", "Solomon Islands", "672.914.7187 x281", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2230,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bayerstad", "EE41024", 4, "G443448", new DateTime(1960, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Douglas11@hotmail.com", "Douglas", "Schaden", "Nauru", "944.904.1422", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Ameliaborough", "EE14883", 2, "G314707", new DateTime(1977, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred_Carter@yahoo.com", "Wilfred", "Carter", "Virgin Islands, U.S.", "(252) 676-7598 x75749", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Enolatown", "EE58986", "G9535", new DateTime(1978, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Wilma.Rodriguez30@gmail.com", "Wilma", "Rodriguez", "Jordan", "(336) 201-1613", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Janymouth", "EE13085", 2, "G461911", new DateTime(1976, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Edward_Miller93@yahoo.com", "Edward", "Miller", "Western Sahara", "1-556-925-0446 x0584" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2234,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Erikamouth", "EE43118", 2, "G424913", new DateTime(1975, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Shelly.Goldner80@hotmail.com", "Shelly", "Goldner", "Zimbabwe", "(498) 905-6225", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2235,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Andersontown", "EE20117", 3, "G82718", new DateTime(1994, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jamie40@hotmail.com", "Jamie", "Pacocha", "Lebanon", "1-568-329-2465 x4595" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Bohaven", "EE10995", 1, "G359322", new DateTime(1975, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Terri28@hotmail.com", "Terri", "Kuvalis", "Denmark", "575-493-6412", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Electastad", "EE31318", 4, "G597957", new DateTime(1996, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Leigh22@hotmail.com", "Leigh", "Rempel", "Lesotho", "446.721.6499" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Einarhaven", "EE3486", 3, "G298769", new DateTime(1953, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Roy.Prosacco@hotmail.com", "Roy", "Prosacco", "New Caledonia", "(625) 451-0037 x04663", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2239,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Alexander", "EE25563", 1, "G526445", new DateTime(1955, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Glenn_Bradtke50@gmail.com", "Glenn", "Bradtke", "Congo", "(678) 489-9576", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2240,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Unique", "EE39457", 2, "G461616", new DateTime(1954, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lorene.Schiller75@gmail.com", "Lorene", "Schiller", "Guadeloupe", "1-878-375-1434 x306", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2241,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Libbymouth", "EE29934", "G223670", new DateTime(1989, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jerry63@yahoo.com", "Jerry", "Schiller", "India", "256.210.1782 x021", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Feilhaven", "EE24032", "G464551", new DateTime(1967, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Kristina_Nienow@hotmail.com", "Kristina", "Nienow", "Georgia", "212.265.8033 x490" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Helenland", "EE56537", 2, "G385449", new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bruce9@gmail.com", "Bruce", "Konopelski", "Ukraine", "552.832.3154 x13872", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Friesenshire", "EE5228", "G557326", new DateTime(1964, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Winston54@gmail.com", "Winston", "Berge", "Cambodia", "257-867-6980", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kuphalberg", "EE19092", 1, "G334192", new DateTime(1952, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Raynor38@yahoo.com", "Rufus", "Raynor", "Democratic People's Republic of Korea", "1-654-270-5619 x1796" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Katlynnmouth", "EE6318", 1, "G293555", new DateTime(1974, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Larry83@yahoo.com", "Larry", "Bednar", "Republic of Korea", "(866) 419-9082 x452", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Queen", "EE56893", 1, "G585841", new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Erick_Stamm@yahoo.com", "Erick", "Stamm", "Palestinian Territory", "1-242-468-1553" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Dee", "EE6189", 2, "G396881", new DateTime(1998, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Pearl_Tromp@hotmail.com", "Pearl", "Tromp", "Turkmenistan", "398.253.8839 x137", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2249,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Holly", "EE16897", 1, "G55741", new DateTime(1995, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Terrell.Wunsch@yahoo.com", "Terrell", "Wunsch", "Guatemala", "(833) 805-8043 x36583" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2250,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jevonbury", "EE28446", 4, "G178462", new DateTime(1997, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne.Feeney53@yahoo.com", "Adrienne", "Feeney", "Montserrat", "939.982.1220 x989" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Andychester", "EE11995", "G399702", new DateTime(1999, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Lorraine.Hudson40@hotmail.com", "Lorraine", "Hudson", "Dominican Republic", "1-730-674-1559", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2252,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kadehaven", "EE23719", 4, "G452210", new DateTime(1991, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Clifford32@gmail.com", "Clifford", "Rutherford", "South Africa", "(385) 726-4603" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2253,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Fae", "EE9533", 3, "G406046", new DateTime(1986, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Benjamin_Streich16@gmail.com", "Benjamin", "Streich", "Albania", "812-849-2868", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Leannonshire", "EE12300", 1, "G271412", new DateTime(1953, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Judy.Jacobson4@yahoo.com", "Judy", "Jacobson", "French Southern Territories", "(687) 783-6170 x827" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Mae", "EE46477", 1, "G194656", new DateTime(1982, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Dustin_Quigley12@gmail.com", "Dustin", "Quigley", "Spain", "(927) 334-8762 x11906" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Priceshire", "EE20791", "G492873", new DateTime(1972, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Merle_Senger@hotmail.com", "Merle", "Senger", "Faroe Islands", "597-788-8728 x68919" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "DuBuquestad", "EE27772", "G89109", new DateTime(1978, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jesse17@gmail.com", "Jesse", "Koch", "Democratic People's Republic of Korea", "(932) 982-4136 x18297", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Abigale", "EE36756", "G38084", new DateTime(1995, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Patrick_Bednar@yahoo.com", "Patrick", "Bednar", "Swaziland", "646.246.2506 x360", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2259,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Veronicaside", "EE46162", 1, "G73948", new DateTime(1987, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Clyde.Moore@gmail.com", "Clyde", "Moore", "Samoa", "1-984-611-7907 x9378", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2260,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Opheliaview", "EE25597", 1, "G110819", new DateTime(1978, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Mandy.Simonis86@gmail.com", "Mandy", "Simonis", "Niger", "1-720-609-4023 x165" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2261,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weberbury", "EE28064", 2, "G222690", new DateTime(1971, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lorenzo90@gmail.com", "Lorenzo", "O'Reilly", "Anguilla", "(747) 222-7158 x2963" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2262,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nienowstad", "EE48607", 3, "G432336", new DateTime(1967, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Timothy19@gmail.com", "Timothy", "Cummerata", "Andorra", "413.922.9086 x5704", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2263,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Meaganmouth", "EE21518", 2, "G234650", new DateTime(1967, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Johnny.Boehm@yahoo.com", "Johnny", "Boehm", "Honduras", "1-402-912-6072 x44313", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jacobsburgh", "EE38061", 4, "G28234", new DateTime(1976, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Santos.Lindgren51@yahoo.com", "Santos", "Lindgren", "Saint Pierre and Miquelon", "303-760-5346 x590", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Joanieshire", "EE5281", 2, "G67341", new DateTime(1956, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Eula32@hotmail.com", "Eula", "Prosacco", "Belgium", "392.871.9250 x081", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Sashaville", "EE55795", 3, "G248871", new DateTime(1999, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Zachary.Simonis@hotmail.com", "Zachary", "Simonis", "Myanmar", "(546) 742-4278 x39304" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2267,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keshawnburgh", "EE39313", 1, "G465586", new DateTime(1967, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Julia.Mann21@hotmail.com", "Julia", "Mann", "Costa Rica", "1-927-575-2819 x759" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2268,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Brenda", "EE27964", "G368747", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Todd_Douglas32@gmail.com", "Todd", "Douglas", "Honduras", "1-774-805-4624" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Amiraview", "EE10774", "G79200", new DateTime(1984, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Thomas30@yahoo.com", "Thomas", "McKenzie", "Argentina", "1-717-432-0756" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2270,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Estell", "EE6192", 4, "G297372", new DateTime(1965, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Mario_Hettinger8@hotmail.com", "Mario", "Hettinger", "Oman", "791-460-2033", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2271,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carolyneville", "EE38580", 3, "G31961", new DateTime(1955, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Pearl.Kihn67@gmail.com", "Pearl", "Kihn", "Equatorial Guinea", "1-778-758-9886 x997", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Corneliusport", "EE40524", 4, "G437964", new DateTime(1970, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bob_Nitzsche43@hotmail.com", "Bob", "Nitzsche", "Tunisia", "(396) 958-5658" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Velvamouth", "EE54197", 4, "G260929", new DateTime(1982, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Marvin.Christiansen@gmail.com", "Marvin", "Christiansen", "New Zealand", "(502) 331-5579 x698", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Chelsey", "EE5740", 3, "G274401", new DateTime(1968, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Colin_Schultz@hotmail.com", "Colin", "Schultz", "Comoros", "(494) 569-9029", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Brentport", "EE23253", "G315828", new DateTime(1965, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Claire29@hotmail.com", "Claire", "Grimes", "Cote d'Ivoire", "770.421.1742 x635", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2276,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lavonshire", "EE31785", 1, "G208285", new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Glen70@yahoo.com", "Glen", "Tromp", "French Southern Territories", "1-669-398-3836 x7643", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2277,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Johnsville", "EE24860", 2, "G6128", new DateTime(1982, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Francis_Boyer@yahoo.com", "Francis", "Boyer", "Puerto Rico", "1-549-439-3307 x13229" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Greggburgh", "EE43770", "G40206", new DateTime(1967, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Eva.Moore@hotmail.com", "Eva", "Moore", "Trinidad and Tobago", "1-730-608-6635 x94975" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Ellis", "EE49774", 1, "G484361", new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ted40@gmail.com", "Ted", "Schinner", "Ethiopia", "269-691-5343 x3372" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gleasonland", "EE13710", 2, "G159100", new DateTime(1954, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Debra.Breitenberg71@gmail.com", "Debra", "Breitenberg", "Germany", "1-351-711-4096", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Susana", "EE47380", 1, "G179700", new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Moses_Mraz@yahoo.com", "Moses", "Mraz", "France", "(404) 662-7953 x8346", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2282,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Courtney", "EE48556", "G340059", new DateTime(1970, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Edgar.Yundt@gmail.com", "Edgar", "Yundt", "Chile", "(769) 792-2271 x4440" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2283,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Reubenview", "EE42980", 2, "G525940", new DateTime(1958, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Charles93@hotmail.com", "Charles", "Fisher", "Kenya", "796-891-8955 x50224", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2284,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Yasmeenfurt", "EE21091", 3, "G386815", new DateTime(1985, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kevin.Spinka66@yahoo.com", "Kevin", "Spinka", "Gabon", "(216) 636-2038 x959", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2285,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Bettie", "EE12413", 3, "G295645", new DateTime(1991, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Leah74@hotmail.com", "Leah", "Lebsack", "Mongolia", "(403) 348-9337" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2286,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Heaneyshire", "EE26081", 3, "G521775", new DateTime(1965, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Luis.Williamson20@hotmail.com", "Luis", "Williamson", "Christmas Island", "1-543-904-4334" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2287,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sanfordport", "EE26850", 2, "G527389", new DateTime(1961, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kimberly_Toy@gmail.com", "Kimberly", "Toy", "Palau", "478-353-6269", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2288,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Emiliaville", "EE23231", 4, "G594600", new DateTime(1951, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Beulah.Fisher0@yahoo.com", "Beulah", "Fisher", "Djibouti", "(985) 935-4870" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2289,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Veumburgh", "EE7837", 1, "G509968", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Doyle_Ankunding8@gmail.com", "Doyle", "Ankunding", "Lesotho", "907.274.6473 x30636", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2290,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jaskolskimouth", "EE19141", 4, "G490356", new DateTime(1997, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bertha.Doyle@hotmail.com", "Bertha", "Doyle", "Benin", "1-445-697-7273", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Weissnatmouth", "EE46472", 3, "G290722", new DateTime(1960, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Myron.Farrell50@hotmail.com", "Myron", "Farrell", "Monaco", "1-438-934-6765 x9074", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Maurice", "EE21111", 1, "G457366", new DateTime(1981, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Tricia_Kiehn72@hotmail.com", "Tricia", "Kiehn", "Armenia", "1-307-375-4270 x8168", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2293,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Sharonport", "EE34214", 3, "G187276", new DateTime(1964, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ronald.Wisoky@yahoo.com", "Ronald", "Wisoky", "Nepal", "(209) 277-1911 x33606" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2294,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zboncakburgh", "EE59548", "G587544", new DateTime(1981, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Candice61@gmail.com", "Candice", "Thompson", "Iraq", "385.868.9090 x29010" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Briannemouth", "EE11357", "G24663", new DateTime(1954, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Charlie.Crist@gmail.com", "Charlie", "Crist", "Austria", "1-827-743-7599 x9127" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Blairport", "EE20082", 4, "G523308", new DateTime(1973, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Blanche15@yahoo.com", "Blanche", "Okuneva", "Saint Vincent and the Grenadines", "(313) 841-6553" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "O'Connellport", "EE28288", 1, "G560547", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Kemmer60@hotmail.com", "Johnnie", "Kemmer", "654-260-6971 x369" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mateomouth", "EE19979", 4, "G249355", new DateTime(1999, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Willie93@yahoo.com", "Willie", "Keeling", "Japan", "(599) 637-3564", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Rubenburgh", "EE5394", 2, "G178003", new DateTime(1968, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Milton83@gmail.com", "Milton", "Huel", "Latvia", "730-860-1289 x097", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Edward", "EE45053", 2, "G74850", new DateTime(1989, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Pablo.Gorczany@gmail.com", "Pablo", "Gorczany", "Taiwan", "793.958.8903 x493", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2301,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Casey", "EE15372", 4, "G99714", new DateTime(1956, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Becky_Heaney7@yahoo.com", "Becky", "Heaney", "Uruguay", "(775) 327-2442 x98477", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2302,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Karenfort", "EE50747", 3, "G496115", new DateTime(1961, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Dan81@gmail.com", "Dan", "Conroy", "Palau", "(442) 497-9021", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2303,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Rogeliomouth", "EE50888", 3, "G34732", new DateTime(1956, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Glenn.Skiles@gmail.com", "Glenn", "Skiles", "Togo", "1-816-298-6400 x90225" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2304,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schaeferberg", "EE45220", 3, "G273139", new DateTime(1955, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Moses46@hotmail.com", "Moses", "Predovic", "El Salvador", "(210) 868-3841 x869", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bradtkemouth", "EE12341", "G357863", new DateTime(1986, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Minnie76@gmail.com", "Minnie", "Feeney", "United States Minor Outlying Islands", "397.854.0246", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marquiseberg", "EE58775", 4, "G139121", new DateTime(1989, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Upton0@yahoo.com", "Kathleen", "Upton", "Saint Barthelemy", "1-240-276-8432 x07223" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardmouth", "EE1413", "G447887", new DateTime(1978, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Neil_Koch@yahoo.com", "Neil", "Koch", "Estonia", "689.738.6907 x5655" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Mafalda", "EE13623", 2, "G176034", new DateTime(1972, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sandy0@gmail.com", "Sandy", "Bartell", "Switzerland", "1-619-725-8478 x0441" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2309,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Grahammouth", "EE24496", 3, "G92213", new DateTime(1998, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Yvonne_Gutmann@gmail.com", "Yvonne", "Gutmann", "Tonga", "382-895-3255 x859" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2310,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Antoniettastad", "EE3671", 2, "G74448", new DateTime(1977, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lula.Cartwright@hotmail.com", "Lula", "Cartwright", "Cook Islands", "1-570-650-2966 x0047" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2311,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hudson", "EE29563", 4, "G523832", new DateTime(1990, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Elsie.Pollich@hotmail.com", "Elsie", "Pollich", "Cyprus", "(587) 640-8176", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2312,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Benny", "EE25399", 3, "G4595", new DateTime(1997, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kelli97@yahoo.com", "Kelli", "Orn", "Belgium", "982.323.6311" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2313,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mina", "EE23955", 1, "G213285", new DateTime(1989, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Frederick19@hotmail.com", "Frederick", "Herzog", "Jamaica", "(614) 640-8275 x036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2314,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Goyettemouth", "EE42775", "G436342", new DateTime(1997, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Brendan53@hotmail.com", "Brendan", "Thompson", "Virgin Islands, British", "718-329-5989 x9241" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2315,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kesslermouth", "EE3513", 2, "G471177", new DateTime(1979, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Clifford45@yahoo.com", "Clifford", "Rempel", "Tuvalu", "1-559-376-2653 x553" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2316,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Isobelfort", "EE3395", "G302001", new DateTime(1961, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Shari_Mraz87@hotmail.com", "Shari", "Mraz", "Malawi", "655.533.7669 x195", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wolffchester", "EE54069", 3, "G104380", new DateTime(1984, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dolores_Langworth59@yahoo.com", "Dolores", "Langworth", "Sao Tome and Principe", "964.631.0617 x6182" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bergstromview", "EE58593", 4, "G585808", new DateTime(1952, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Goldner@hotmail.com", "Rolando", "Goldner", "Canada", "1-579-617-9296 x51884", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2319,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tremblaystad", "EE23264", 1, "G238421", new DateTime(1961, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Minnie65@gmail.com", "Minnie", "Kemmer", "Guinea", "717-929-4072" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2320,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Avery", "EE29038", 2, "G556888", new DateTime(1987, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marco_Quitzon12@gmail.com", "Marco", "Quitzon", "Sweden", "992-655-3177 x234", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Piper", "EE10240", 1, "G3203", new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lois3@gmail.com", "Lois", "Schulist", "Reunion", "381.754.0778", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2322,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Uptonview", "EE59680", 4, "G269995", new DateTime(1965, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Chelsea38@gmail.com", "Chelsea", "Blanda", "French Guiana", "239.380.3714 x04836" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2323,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Henriette", "EE55319", 2, "G219210", new DateTime(1978, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Alonzo_Kunde96@yahoo.com", "Alonzo", "Kunde", "Bahamas", "1-505-293-6449 x2039" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2324,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Raeganview", "EE28723", "G402487", new DateTime(1999, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Oscar63@hotmail.com", "Oscar", "Lueilwitz", "Iceland", "1-655-643-4321 x5766", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2325,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Hellen", "EE300", 1, "G476582", new DateTime(1952, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Horace_Weissnat@gmail.com", "Horace", "Weissnat", "Oman", "780-537-2628 x2512" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lawrencefurt", "EE56689", "G308644", new DateTime(1968, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nick15@hotmail.com", "Nick", "Blanda", "Senegal", "(749) 211-4490", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2327,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Vinniehaven", "EE34189", 1, "G476653", new DateTime(1955, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Stacey_Waters43@yahoo.com", "Stacey", "Waters", "Chad", "1-610-266-0688 x0533" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2328,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Hankfort", "EE20342", "G590581", new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kyle89@hotmail.com", "Kyle", "Ruecker", "Virgin Islands, U.S.", "1-874-479-9747 x2267", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2329,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kristofferborough", "EE12847", 4, "G227216", new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Breitenberg88@yahoo.com", "Willie", "Breitenberg", "Finland", "(697) 482-6208" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2330,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Jordynhaven", "EE33719", 4, "G438813", new DateTime(1955, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Matt_Marvin@hotmail.com", "Matt", "Marvin", "Barbados", "1-991-964-4452 x3092", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2331,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wintheiserchester", "EE28568", 1, "G157051", new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Latoya48@hotmail.com", "Latoya", "Kuhn", "Uganda", "(578) 773-1569 x97996", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2332,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Enola", "EE30410", 1, "G462023", new DateTime(1978, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Doug17@hotmail.com", "Doug", "Fay", "Lithuania", "702-820-2897", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2333,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hymanchester", "EE13110", 4, "G203035", new DateTime(1986, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jamie.Maggio35@hotmail.com", "Jamie", "Maggio", "Ethiopia", "(542) 769-5783", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2334,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Weston", "EE21723", 1, "G549377", new DateTime(1961, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Laurence25@yahoo.com", "Laurence", "Fay", "Nicaragua", "1-752-479-9889 x10032" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2335,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Roslyn", "EE30586", 3, "G175303", new DateTime(1961, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Beahan8@yahoo.com", "Tami", "Beahan", "Western Sahara", "1-810-772-7878 x63617" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2336,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kathleentown", "EE4983", 3, "G429832", new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Clyde24@yahoo.com", "Clyde", "Kihn", "Lesotho", "1-200-935-4973" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ritamouth", "EE24532", "G150438", new DateTime(1983, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Johnny69@yahoo.com", "Johnny", "Weber", "Jamaica", "(664) 277-1328 x329", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2338,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keenanmouth", "EE4824", 4, "G197741", new DateTime(1977, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lynn11@hotmail.com", "Lynn", "Dach", "Haiti", "1-837-937-3875 x80509" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2339,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Sherwood", "EE26546", 2, "G468202", new DateTime(1976, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Sipes6@gmail.com", "Mildred", "Sipes", "Kenya", "273.465.2419", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brakusside", "EE30620", 1, "G96372", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gwendolyn65@gmail.com", "Gwendolyn", "Schmeler", "Chile", "535.963.2950" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2341,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pourosberg", "EE2756", 4, "G216159", new DateTime(1983, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kelly.Franecki@yahoo.com", "Kelly", "Franecki", "Vietnam", "624.549.7279 x14606", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2342,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Gayle", "EE12986", "G126483", new DateTime(1972, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester92@hotmail.com", "Sylvester", "Mertz", "United Kingdom", "830-496-8213", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Kaleb", "EE26417", 3, "G332551", new DateTime(2000, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Garrett_Kshlerin@hotmail.com", "Garrett", "Kshlerin", "Vietnam", "905-570-6629 x52780" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alexisberg", "EE40905", 3, "G365452", new DateTime(1998, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Joseph_Koch@hotmail.com", "Joseph", "Koch", "Bangladesh", "1-737-665-3329 x36480" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Volkmanmouth", "EE28721", 4, "G571062", new DateTime(1983, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Alexander_Feil4@gmail.com", "Alexander", "Feil", "Cayman Islands", "312.585.5669 x6422" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Madisyn", "EE46243", 2, "G343346", new DateTime(1958, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rochelle4@yahoo.com", "Rochelle", "Denesik", "Kuwait", "(872) 547-3172" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lonny", "EE54430", 1, "G273986", new DateTime(1985, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kathryn.Labadie@gmail.com", "Kathryn", "Labadie", "Reunion", "1-269-839-8203 x937", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Charlietown", "EE22682", 3, "G180058", new DateTime(1957, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jordan.Kshlerin9@yahoo.com", "Jordan", "Kshlerin", "Ethiopia", "261-891-1124", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2349,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rebecamouth", "EE27708", 4, "G67233", new DateTime(1973, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Vincent96@hotmail.com", "Vincent", "Collins", "Myanmar", "624.576.3425", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2350,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gilbertoville", "EE37075", 3, "G588585", new DateTime(1993, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Tricia.Hettinger@yahoo.com", "Tricia", "Hettinger", "Uganda", "1-840-694-5452 x35227", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2351,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Omari", "EE9374", 1, "G407288", new DateTime(1995, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Beahan@hotmail.com", "Florence", "Beahan", "Norway", "(212) 532-6085", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2352,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucianomouth", "EE46959", "G480969", new DateTime(1984, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Runte@yahoo.com", "Inez", "Runte", "China", "546-278-5659 x23817" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2353,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Emilieland", "EE44019", 4, "G25323", new DateTime(1954, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Genevieve9@hotmail.com", "Genevieve", "Kunde", "Tonga", "(470) 712-3248" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2354,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Morissettebury", "EE56900", 3, "G56486", new DateTime(1999, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Roosevelt.Koelpin70@hotmail.com", "Roosevelt", "Koelpin", "Uganda", "533-908-0216 x8723" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2355,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Willfort", "EE55159", "G369763", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shawna17@gmail.com", "Shawna", "Erdman", "Bahamas", "950-936-0597 x993", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2356,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Everettfurt", "EE42470", 1, "G9297", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lorena90@hotmail.com", "Lorena", "Halvorson", "Cape Verde", "485.788.9088 x753" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2357,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ezekielhaven", "EE12273", 4, "G58007", new DateTime(1989, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Alexandra.Wisoky@yahoo.com", "Alexandra", "Wisoky", "Chad", "405-365-3664 x8215", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maggioview", "EE35137", 4, "G574388", new DateTime(1961, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Troy74@hotmail.com", "Troy", "Langosh", "Lithuania", "750-773-8347" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2359,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Abigayleton", "EE53578", 3, "G55690", new DateTime(1986, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Charlotte_Hettinger0@yahoo.com", "Charlotte", "Hettinger", "Taiwan", "1-202-286-9568 x889" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2360,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hagenesburgh", "EE14465", 1, "G210232", new DateTime(1967, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa_Durgan@yahoo.com", "Vanessa", "Durgan", "Djibouti", "812-585-8501 x4444" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2361,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Olaland", "EE16320", 4, "G7480", new DateTime(1971, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Leo80@gmail.com", "Leo", "Ortiz", "United States of America", "1-356-295-0324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2362,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Krisville", "EE17502", 1, "G563049", new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta_Mosciski40@hotmail.com", "Henrietta", "Mosciski", "Guernsey", "1-841-374-5623 x4799" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Maxwellberg", "EE31417", 3, "G422359", new DateTime(1961, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shaun_Wilkinson9@yahoo.com", "Shaun", "Wilkinson", "Central African Republic", "359-862-6556", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Alexaburgh", "EE48355", "G389230", new DateTime(1959, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Zachary35@yahoo.com", "Zachary", "Smith", "Bangladesh", "(290) 509-1270 x4782" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Altaland", "EE41135", 3, "G317082", new DateTime(1964, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tom.Purdy@gmail.com", "Tom", "Purdy", "Virgin Islands, U.S.", "(568) 475-6940 x87718", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Griffinhaven", "EE29326", "G346416", new DateTime(1963, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lucas.Abernathy28@hotmail.com", "Lucas", "Abernathy", "Zimbabwe", "1-471-800-9040" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kozeyland", "EE3739", "G596233", new DateTime(1964, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marty.Dooley@hotmail.com", "Marty", "Dooley", "Indonesia", "952.281.4375 x59155", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Avery", "EE31898", "G583312", new DateTime(1998, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen0@yahoo.com", "Gretchen", "Parisian", "Namibia", "742.769.7558" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Hazletown", "EE42227", "G273231", new DateTime(1956, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jeanette.Gulgowski70@yahoo.com", "Jeanette", "Gulgowski", "Slovakia (Slovak Republic)", "1-858-656-0832" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Meaganfort", "EE21402", "G36817", new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lisa.Nikolaus22@hotmail.com", "Lisa", "Nikolaus", "Lebanon", "984.730.9556 x26998", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rueckerfurt", "EE8058", 1, "G11646", new DateTime(1953, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Irving_Quigley41@hotmail.com", "Irving", "Quigley", "Nicaragua", "(620) 543-5417 x01225" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2372,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Bulahville", "EE49062", 3, "G64016", new DateTime(1995, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Aaron36@hotmail.com", "Aaron", "Gulgowski", "Romania", "1-689-429-5206 x71517", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2373,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "McLaughlinberg", "EE5694", 2, "G364882", new DateTime(1973, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Mindy_Becker@hotmail.com", "Mindy", "Becker", "Nicaragua", "630.213.9038", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Reillystad", "EE30293", "G476503", new DateTime(1961, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Sophie63@yahoo.com", "Sophie", "Willms", "Cocos (Keeling) Islands", "(296) 722-0518", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Braxtonmouth", "EE30583", 4, "G108771", new DateTime(1961, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Herman.Schroeder@yahoo.com", "Herman", "Schroeder", "Ecuador", "542-695-0932 x36341", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2376,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brodybury", "EE2025", 1, "G383767", new DateTime(1969, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cheryl44@yahoo.com", "Cheryl", "Zieme", "British Indian Ocean Territory (Chagos Archipelago)", "1-838-618-1541", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2377,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zellaport", "EE29382", 4, "G507549", new DateTime(1986, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Marcus48@gmail.com", "Marcus", "Greenfelder", "Montserrat", "(814) 849-6758", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2378,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Lilyanland", "EE9085", 4, "G122854", new DateTime(1951, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Carl_Willms@gmail.com", "Carl", "Willms", "Canada", "997.542.2565", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2379,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lerachester", "EE22060", "G425605", new DateTime(1991, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lewis.Thiel6@hotmail.com", "Lewis", "Thiel", "Greenland", "727.465.2001 x55266" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Malvinamouth", "EE16822", "G2864", new DateTime(1986, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Carroll_OKon35@yahoo.com", "Carroll", "O'Kon", "Hungary", "(948) 994-7581 x405", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2381,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Lylahaven", "EE24242", 2, "G509203", new DateTime(1965, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Steve.Stokes85@yahoo.com", "Steve", "Stokes", "Djibouti", "(961) 635-1477", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2382,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Ibrahim", "EE15447", 4, "G360416", new DateTime(1975, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Monique64@hotmail.com", "Monique", "Ankunding", "Romania", "(567) 697-1921 x567" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schusterstad", "EE54031", 4, "G291876", new DateTime(1995, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alfred3@hotmail.com", "Alfred", "Hills", "Rwanda", "(855) 763-9100 x210" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Penelopestad", "EE38168", "G128749", new DateTime(1966, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Amanda49@hotmail.com", "Amanda", "Bartoletti", "Wallis and Futuna", "643-654-4283 x10449", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Margarettborough", "EE18850", 2, "G341526", new DateTime(1996, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Susan.Parisian63@gmail.com", "Susan", "Parisian", "Philippines", "(245) 803-6788 x6394" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kerlukeburgh", "EE37563", "G97405", new DateTime(1974, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Guy_Gusikowski78@yahoo.com", "Guy", "Gusikowski", "Congo", "724-201-2687" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lindgrenhaven", "EE49339", 2, "G278491", new DateTime(1965, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Guy4@hotmail.com", "Guy", "Spinka", "Czech Republic", "911-918-3929", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldaton", "EE14555", "G287897", new DateTime(1990, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mark_Bins@hotmail.com", "Mark", "Bins", "Vietnam", "982-582-4418", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2389,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Alitown", "EE17445", 3, "G573268", new DateTime(1995, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jenny31@yahoo.com", "Jenny", "Kuphal", "Hungary", "(366) 205-6801 x234", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2390,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobsonfurt", "EE24437", "G251958", new DateTime(1967, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Carlos.Smitham54@yahoo.com", "Carlos", "Smitham", "Uruguay", "(408) 982-9706 x40210" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2391,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Johathanland", "EE28290", 4, "G333921", new DateTime(1951, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Richard23@yahoo.com", "Richard", "Simonis", "Burundi", "344-928-7036", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2392,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Nestor", "EE20807", "G204500", new DateTime(1979, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kendra67@hotmail.com", "Kendra", "Stoltenberg", "Guinea-Bissau", "(374) 374-6947 x72970", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Gildamouth", "EE28462", 1, "G116779", new DateTime(1964, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Johnston16@yahoo.com", "Sabrina", "Johnston", "Turkey", "836.865.1025", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2394,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Peggieville", "EE43556", 1, "G156108", new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nellie_Hamill@hotmail.com", "Nellie", "Hamill", "Cook Islands", "(858) 251-2628 x63455", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2395,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kaylifurt", "EE46322", 4, "G449519", new DateTime(1958, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lynda_Mraz56@hotmail.com", "Lynda", "Mraz", "Norway", "284.493.3588" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2396,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kavonmouth", "EE27713", 3, "G524097", new DateTime(1986, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Terry.Hoppe69@yahoo.com", "Terry", "Hoppe", "Tanzania", "1-634-375-3805", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2397,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ociestad", "EE38059", 2, "G204347", new DateTime(1973, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Van.Leffler90@gmail.com", "Van", "Leffler", "Ireland", "(744) 406-9633", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West D'angelomouth", "EE3978", "G568590", new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Delia.Pouros39@gmail.com", "Delia", "Pouros", "Uganda", "413.336.0636", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Gilbertoborough", "EE2717", 2, "G66597", new DateTime(1981, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Edward.Sporer@gmail.com", "Edward", "Sporer", "Puerto Rico", "411-296-8654 x3145", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maverickland", "EE15713", 1, "G56038", new DateTime(1953, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Brendan23@yahoo.com", "Brendan", "Robel", "Colombia", "(632) 857-4536", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Crystel", "EE32281", 2, "G53624", new DateTime(1968, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Jodi82@gmail.com", "Jodi", "Paucek", "Belize", "462-670-5523", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mauriceberg", "EE22970", 3, "G9732", new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ed_Fritsch@yahoo.com", "Ed", "Fritsch", "Netherlands Antilles", "789-503-8523 x27054" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2403,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Colleenmouth", "EE47801", 1, "G313533", new DateTime(1972, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lindsey_Cummerata@hotmail.com", "Lindsey", "Cummerata", "Oman", "(255) 932-5492", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2404,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Olsonview", "EE14237", 4, "G284560", new DateTime(1973, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Regina_Rutherford@yahoo.com", "Regina", "Rutherford", "Ukraine", "684.726.1374" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Doris", "EE53705", 1, "G274612", new DateTime(1986, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Colin72@hotmail.com", "Colin", "Wolff", "South Africa", "303-528-6997 x8453" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Maritzamouth", "EE21723", "G168429", new DateTime(1953, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stella_Weber@gmail.com", "Stella", "Weber", "Equatorial Guinea", "(600) 785-0403", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2407,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Tremaine", "EE12769", 3, "G272202", new DateTime(2001, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Patricia81@hotmail.com", "Patricia", "Denesik", "Sao Tome and Principe", "1-709-407-7521", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2408,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Karina", "EE34189", 4, "G255245", new DateTime(1993, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Beth2@hotmail.com", "Beth", "Wintheiser", "Iraq", "(900) 580-3491 x578", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lilliefurt", "EE21241", 1, "G300789", new DateTime(1960, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Peter.Hansen@gmail.com", "Peter", "Hansen", "Paraguay", "646-695-9643", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2410,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Modestoborough", "EE44255", 3, "G51486", new DateTime(1978, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Felipe.Ziemann@hotmail.com", "Felipe", "Ziemann", "Mauritania", "(669) 551-3814", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2411,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Millie", "EE169", 1, "G181503", new DateTime(1952, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ernesto_Abshire@yahoo.com", "Ernesto", "Abshire", "Saint Barthelemy", "976-487-7782" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ceciliamouth", "EE10031", 2, "G59935", new DateTime(1951, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Muriel_Zboncak13@gmail.com", "Muriel", "Zboncak", "Thailand", "483.520.2899 x00818" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2413,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Caylamouth", "EE17899", 2, "G209251", new DateTime(1971, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Tricia.Brown53@gmail.com", "Tricia", "Brown", "Burkina Faso", "908.516.0421" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2414,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pacochafurt", "EE23638", 1, "G377890", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Faith.Wuckert45@yahoo.com", "Faith", "Wuckert", "Solomon Islands", "847.584.4429" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mannfort", "EE20941", 4, "G28407", new DateTime(1990, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "John_Shields63@gmail.com", "John", "Shields", "Anguilla", "1-971-574-9915 x47005" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dooleychester", "EE26458", 3, "G276083", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Clifton_Swift@gmail.com", "Clifton", "Swift", "Sweden", "739.516.8549 x38971", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marleemouth", "EE22530", 2, "G479264", new DateTime(1989, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Angie_Glover@yahoo.com", "Angie", "Glover", "Bulgaria", "735.872.5347 x3869" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cristalton", "EE55105", "G128901", new DateTime(1998, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Nelson_Rowe38@hotmail.com", "Nelson", "Rowe", "Saint Barthelemy", "1-446-784-5121" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jamarview", "EE58779", 4, "G497923", new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Gerald44@yahoo.com", "Gerald", "Ritchie", "Bosnia and Herzegovina", "(274) 458-8679 x3510" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Oceanebury", "EE36801", 3, "G292657", new DateTime(1955, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Gilbert.Sipes@gmail.com", "Gilbert", "Sipes", "Guadeloupe", "(801) 221-7957 x51037" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Myrtleland", "EE55273", 4, "G282248", new DateTime(1953, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Jacobi92@gmail.com", "Willie", "Jacobi", "Gibraltar", "981-799-9614 x835" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Winifredstad", "EE50807", 3, "G537651", new DateTime(1967, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sheldon_Block81@hotmail.com", "Sheldon", "Block", "Lithuania", "(756) 754-7621 x413", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gulgowskiland", "EE33194", 3, "G42717", new DateTime(1955, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Andres_Frami@hotmail.com", "Andres", "Frami", "Poland", "(966) 325-3988", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2424,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Simeon", "EE39734", "G514563", new DateTime(1989, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "May.Nienow33@yahoo.com", "May", "Nienow", "Netherlands Antilles", "844.684.5259 x10206", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2425,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Eugene", "EE14512", 1, "G125819", new DateTime(1993, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Horace74@yahoo.com", "Horace", "McGlynn", "China", "474.946.8836 x79925", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2426,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Taliaport", "EE18884", "G373941", new DateTime(1959, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lucas40@yahoo.com", "Lucas", "Stroman", "Nigeria", "782-478-7436 x464" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2427,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Satterfieldmouth", "EE4101", 3, "G507686", new DateTime(1954, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wilma18@gmail.com", "Wilma", "Shanahan", "Portugal", "(563) 442-7976 x6519", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2428,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucasmouth", "EE14961", "G158579", new DateTime(1973, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Chester_Schroeder13@gmail.com", "Chester", "Schroeder", "Slovakia (Slovak Republic)", "699-409-9027" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Othaberg", "EE9674", 1, "G226146", new DateTime(1994, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Dustin.Lemke@yahoo.com", "Dustin", "Lemke", "Bosnia and Herzegovina", "(938) 553-0234 x02819", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "McKenziebury", "EE20821", "G536080", new DateTime(1969, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Amos.Schulist@hotmail.com", "Amos", "Schulist", "Wallis and Futuna", "424-220-1540", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2431,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boyerborough", "EE32702", 4, "G546687", new DateTime(1958, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Gwen.Brekke@gmail.com", "Gwen", "Brekke", "Namibia", "(958) 925-1456", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2432,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ethel", "EE10698", 3, "G232068", new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Erik_Swift63@hotmail.com", "Erik", "Swift", "Cote d'Ivoire", "1-936-474-3657 x455", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Americoberg", "EE50725", 3, "G124765", new DateTime(1977, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shelley_Schneider89@hotmail.com", "Shelley", "Schneider", "Suriname", "1-265-562-8610" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Alfordburgh", "EE42442", 3, "G454964", new DateTime(1969, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Regina.Emard22@hotmail.com", "Regina", "Emard", "Somalia", "390-737-4695 x917", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gudrunfort", "EE57762", 3, "G485770", new DateTime(1967, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rickey99@yahoo.com", "Rickey", "Willms", "Lithuania", "631.856.7037" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2436,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Tryciaview", "EE48101", 4, "G394908", new DateTime(1984, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Samantha87@gmail.com", "Samantha", "Schultz", "Belarus", "(529) 414-0379", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2437,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jovannyview", "EE26568", 4, "G471215", new DateTime(1973, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie.Hilpert20@gmail.com", "Bobbie", "Hilpert", "Guadeloupe", "(242) 995-5499 x17366" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2438,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ibrahim", "EE34709", 4, "G517191", new DateTime(1994, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Nathan_Shields@gmail.com", "Nathan", "Shields", "Thailand", "(683) 696-1307 x595", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2439,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Sisterhaven", "EE20449", "G121652", new DateTime(1956, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Shelley10@gmail.com", "Shelley", "Abernathy", "Bangladesh", "(642) 341-1359 x9550" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Audreanneside", "EE10998", "G582315", new DateTime(1980, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Tyler94@hotmail.com", "Tyler", "Feest", "Wallis and Futuna", "1-248-683-8416 x475" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Emanuel", "EE42440", "G465903", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Carla21@gmail.com", "Carla", "Reynolds", "Togo", "487.517.9737 x1659", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Americo", "EE5334", 1, "G485825", new DateTime(1967, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Elmer_Gaylord53@hotmail.com", "Elmer", "Gaylord", "Italy", "1-814-770-5196 x3122", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2443,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacintofort", "EE3453", 2, "G342392", new DateTime(1995, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jenna.Cummings6@yahoo.com", "Jenna", "Cummings", "Niue", "802.974.8411 x80561" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2444,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Garrett", "EE56791", "G319736", new DateTime(1974, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jeanne96@hotmail.com", "Jeanne", "Lowe", "Japan", "(581) 989-4507" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Darronberg", "EE7007", 1, "G9750", new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Jimmie_Batz41@yahoo.com", "Jimmie", "Batz", "Paraguay", "306-278-0528 x67067" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2446,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Merritt", "EE56283", 1, "G271538", new DateTime(1995, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Eric63@yahoo.com", "Eric", "Gulgowski", "Cameroon", "788.298.7148", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2447,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Meghan", "EE43675", 2, "G228429", new DateTime(1979, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Michele30@gmail.com", "Michele", "Bergnaum", "Costa Rica", "1-610-203-0494", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2448,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dora", "EE48839", 3, "G425651", new DateTime(1971, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Roberto.Treutel@gmail.com", "Roberto", "Treutel", "Liechtenstein", "799-578-3605" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2449,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Thielport", "EE17276", 2, "G228388", new DateTime(1967, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lila_Strosin31@hotmail.com", "Lila", "Strosin", "Bangladesh", "927-721-1985" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Laurine", "EE16356", 2, "G431872", new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Donna_Kuhn44@yahoo.com", "Donna", "Kuhn", "Nauru", "1-344-998-6613 x1979", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Baylee", "EE8308", 2, "G228803", new DateTime(1966, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rudolph.Terry96@gmail.com", "Rudolph", "Terry", "Fiji", "376-958-1691" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2452,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Busterside", "EE11759", 3, "G15057", new DateTime(1962, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "George_Smith61@gmail.com", "George", "Smith", "Gibraltar", "(886) 548-1737" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2453,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Kelsi", "EE18851", "G235777", new DateTime(1968, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Corwin@yahoo.com", "Tami", "Corwin", "Chile", "(989) 266-3366 x2550", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Kennedihaven", "EE18717", 1, "G432199", new DateTime(1995, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gladys79@yahoo.com", "Gladys", "Mosciski", "New Caledonia", "(999) 354-1311 x835", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Jerald", "EE8363", 1, "G52782", new DateTime(1963, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Frank60@hotmail.com", "Frank", "Wunsch", "Hungary", "734-947-2011 x120" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2456,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Genevievemouth", "EE5711", 4, "G527777", new DateTime(1984, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lonnie_Russel@yahoo.com", "Lonnie", "Russel", "Mozambique", "(615) 581-5616", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2457,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kayceeberg", "EE49209", 4, "G130324", new DateTime(1989, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jodi.Kuhlman50@gmail.com", "Jodi", "Kuhlman", "Germany", "712-684-0319 x782" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2458,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rupertport", "EE14323", 4, "G339816", new DateTime(1989, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Hand@gmail.com", "Paulette", "Hand", "Mayotte", "1-749-383-5840 x4265", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Parkerburgh", "EE5532", 4, "G394795", new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Randal_Effertz2@hotmail.com", "Randal", "Effertz", "Netherlands Antilles", "(498) 299-7099", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2460,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dustin", "EE46489", 2, "G327571", new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Irving.Jenkins@gmail.com", "Irving", "Jenkins", "Malta", "1-441-424-0353 x23266" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2461,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schmidtton", "EE8528", 2, "G553625", new DateTime(1982, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Gayle_Bogan14@hotmail.com", "Gayle", "Bogan", "Saint Kitts and Nevis", "259.407.6580", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2462,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mayertburgh", "EE47260", 1, "G80304", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sadie21@yahoo.com", "Sadie", "McCullough", "Solomon Islands", "1-662-680-8999 x075", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Clay", "EE40353", 3, "G324618", new DateTime(1996, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.Hickle83@hotmail.com", "Maryann", "Hickle", "Guyana", "224.596.3237 x7576", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Elsa", "EE36433", 3, "G38503", new DateTime(1993, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Krista.Senger@yahoo.com", "Krista", "Senger", "Netherlands", "691-887-8880 x8671" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Uriah", "EE36904", 4, "G128490", new DateTime(1958, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ira_Gusikowski@yahoo.com", "Ira", "Gusikowski", "New Zealand", "1-754-884-9392 x3337", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Roosevelttown", "EE13528", "G294013", new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Kelly_Ullrich@yahoo.com", "Kelly", "Ullrich", "Dominica", "1-702-540-7644 x71402" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Aletha", "EE49056", "G335761", new DateTime(1976, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Wuckert51@yahoo.com", "Kerry", "Wuckert", "Monaco", "1-969-826-6054 x9210" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roslynville", "EE13121", "G88456", new DateTime(1982, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jeannette_Zulauf6@hotmail.com", "Jeannette", "Zulauf", "Sudan", "482-785-1329", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2469,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Adriel", "EE16877", 1, "G324646", new DateTime(1951, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Faith99@gmail.com", "Faith", "Mayer", "Seychelles", "(690) 204-9147 x4448", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2470,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kimberlytown", "EE12113", 2, "G215977", new DateTime(1978, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jesse_Hodkiewicz@yahoo.com", "Jesse", "Hodkiewicz", "Republic of Korea", "(833) 555-2867 x42909" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2471,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cruzburgh", "EE8485", 4, "G527764", new DateTime(1971, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo_Ankunding60@gmail.com", "Rodolfo", "Ankunding", "Turks and Caicos Islands", "(932) 484-6795 x2069", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2472,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Smithamville", "EE1820", 2, "G270591", new DateTime(1952, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kurt_Thompson@yahoo.com", "Kurt", "Thompson", "Djibouti", "576.827.5819", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2473,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Alba", "EE35737", 1, "G289956", new DateTime(1970, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Marcia_Parker@hotmail.com", "Marcia", "Parker", "Cayman Islands", "893.785.7924 x338", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2474,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Shanahanside", "EE19367", "G317531", new DateTime(1958, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jeremiah23@yahoo.com", "Jeremiah", "Weimann", "Central African Republic", "1-644-316-0550", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2475,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ianton", "EE54451", 3, "G279781", new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Beier@gmail.com", "Lucille", "Beier", "Brunei Darussalam", "516-461-5160 x72132" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2476,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Majormouth", "EE17664", "G223460", new DateTime(1965, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Joyce_Kulas77@yahoo.com", "Joyce", "Kulas", "Nauru", "594.359.0290" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2477,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lessiehaven", "EE4074", 1, "G143554", new DateTime(1986, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Michele12@hotmail.com", "Michele", "Smitham", "Russian Federation", "(887) 493-0799" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2478,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Adityaview", "EE1497", 1, "G412739", new DateTime(1968, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Jeffrey58@gmail.com", "Jeffrey", "Rowe", "Oman", "991.823.0705 x3191", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2479,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Christ", "EE1314", 2, "G206399", new DateTime(1991, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina_Okuneva8@yahoo.com", "Sabrina", "Okuneva", "Niue", "(337) 299-8689 x35704", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2480,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Eleanore", "EE50237", "G321604", new DateTime(1996, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dan.Hahn@yahoo.com", "Dan", "Hahn", "Cape Verde", "1-640-461-1520 x566", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Martyberg", "EE13949", 4, "G453737", new DateTime(1958, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen_Ebert0@hotmail.com", "Gretchen", "Ebert", "Iraq", "518.377.6291" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2482,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Sanfordhaven", "EE15355", 2, "G179474", new DateTime(1964, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Eunice_Tillman@gmail.com", "Eunice", "Tillman", "Guinea", "580.356.3398 x35189" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2483,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Colefurt", "EE25141", 3, "G136986", new DateTime(1965, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy.Price44@hotmail.com", "Dorothy", "Price", "Iran", "(338) 452-4292 x1173" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2484,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Generalhaven", "EE48932", "G82439", new DateTime(1971, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Vicky33@yahoo.com", "Vicky", "Tromp", "Namibia", "819.772.5795 x5037" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2485,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Paxtonborough", "EE10796", 1, "G52610", new DateTime(1983, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Vicky_Hagenes94@yahoo.com", "Vicky", "Hagenes", "Saint Barthelemy", "(715) 528-7816 x912", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2486,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Allyburgh", "EE43323", 2, "G213186", new DateTime(1958, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Marion.Gulgowski@yahoo.com", "Marion", "Gulgowski", "Zambia", "1-814-444-0285 x8633", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2487,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Randy", "EE32158", "G305464", new DateTime(1972, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Joan_Casper@hotmail.com", "Joan", "Casper", "Philippines", "544-555-8035 x09549" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2488,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sharonmouth", "EE8839", 3, "G206260", new DateTime(1981, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Nelson22@gmail.com", "Nelson", "Ryan", "Guam", "292.733.1910 x2569", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2489,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Taureanburgh", "EE7008", 1, "G297446", new DateTime(1982, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Carmen_Wilderman@gmail.com", "Carmen", "Wilderman", "Saint Kitts and Nevis", "(233) 441-3611 x904", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2490,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacksonmouth", "EE18962", "G406523", new DateTime(1960, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Conrad.Morissette46@yahoo.com", "Conrad", "Morissette", "Italy", "604-863-2126 x12019" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2491,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jovanifurt", "EE57444", 3, "G27290", new DateTime(1977, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Myron_Nader@hotmail.com", "Myron", "Nader", "Togo", "335-931-9008 x96377", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2492,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Cristopher", "EE40182", 4, "G57429", new DateTime(1988, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rickey.Ruecker@gmail.com", "Rickey", "Ruecker", "Namibia", "301-366-4880", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2493,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Kaya", "EE18021", 3, "G17109", new DateTime(1956, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Laurie_Nikolaus@gmail.com", "Laurie", "Nikolaus", "Fiji", "284.844.2620 x67203" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2494,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "Port Darryl", "EE40078", 1, "G438192", new DateTime(1964, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Howard47@gmail.com", "Howard", "Windler", "(662) 427-4938 x7171", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Leonetown", "EE28523", 3, "G579037", new DateTime(1986, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Rick11@gmail.com", "Rick", "Williamson", "Brunei Darussalam", "234-402-4370 x9577" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardborough", "EE31467", 3, "G420312", new DateTime(1986, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Geraldine64@yahoo.com", "Geraldine", "Kassulke", "Luxembourg", "932-615-1840 x75652" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Eddie", "EE51979", 1, "G440243", new DateTime(1958, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jennie38@yahoo.com", "Jennie", "Koch", "Kazakhstan", "428.857.7064 x2794", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Aurelie", "EE11173", 3, "G368551", new DateTime(1967, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Erica_Breitenberg72@gmail.com", "Erica", "Breitenberg", "Jordan", "315.927.1266" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2499,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Margueriteburgh", "EE43971", 2, "G130487", new DateTime(1997, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Micheal_Jerde52@yahoo.com", "Micheal", "Jerde", "Netherlands Antilles", "805-905-1010 x1150", "Male" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Reduced Bedfordshire Buckinghamshire", 25 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "black functionalities International", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Credit Card Account grow Nakfa", 14 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "withdrawal Alley Checking Account", 18 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Bedfordshire client-server River", 3 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "white Integration Bedfordshire", 21 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Bedfordshire Home Loan Account digital", 15 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "grey Checking Account Frozen", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Loop Row Track", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Tunnel hub disintermediate", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 2, "New Jersey Guernsey Avon" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Freeway Executive Tasty", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Auto Loan Account deposit bypass", 15 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Developer Automotive, Music & Clothing International", 5 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Missouri mobile Bedfordshire", 5 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "cyan fuchsia Motorway", 3 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 2, "systems Credit Card Account Avon" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "bypass even-keeled Park", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "District calculating enhance", 5 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Ville innovate optical", 11 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "virtual definition Granite", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Personal Loan Account navigating Licensed Metal Soap", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Marketing Jamaican Dollar Bedfordshire", 13 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Granite Savings Account Washington", 17 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 4, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 6, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 8, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 10, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 19, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 22 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 7, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "A", 21 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 5, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 22, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 23, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 7, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 2, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 19, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 24, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 7, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 21, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 24, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 3, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 24, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 20, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 12, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 11, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 11, "1" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Della.Pouros@gmail.com", "Cedi", "Pouros", "Della" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Marjorie.Tillman@hotmail.com", "Automotive, Grocery & Electronics", "Tillman", "Marjorie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Clayton81@hotmail.com", "Identity", "Jacobs", "Clayton" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Anna85@hotmail.com", "Front-line", "Wintheiser", "Anna" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ismael.Ullrich@gmail.com", "Tasty Metal Bacon", "Ullrich", "Ismael" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Wendy19@gmail.com", "Personal Loan Account", "Wyman", "Wendy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Viola44@yahoo.com", "Fantastic Cotton Chips", "Haag", "Viola" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Emily22@hotmail.com", "Refined Plastic Pizza", "Windler", "Emily" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Russell_Powlowski32@hotmail.com", "Cambridgeshire", "Powlowski", "Russell" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Carolyn_Schulist19@gmail.com", "Texas", "Schulist", "Carolyn" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jaime_Kertzmann13@yahoo.com", "GB", "Kertzmann", "Jaime" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Shelia_Grady22@yahoo.com", "payment", "Grady", "Shelia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Wilma6@yahoo.com", "Practical", "Rodriguez", "Wilma" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Raul.McGlynn@gmail.com", "Movies", "McGlynn", "Raul" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Sylvester.Reynolds@yahoo.com", "4th generation", "Reynolds", "Sylvester" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Caleb5@yahoo.com", "deposit", "Altenwerth", "Caleb" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Caleb77@hotmail.com", "benchmark", "Pouros", "Caleb" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Dana.Ebert@yahoo.com", "Rustic", "Ebert", "Dana" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Grace.Cartwright@yahoo.com", "Cambridgeshire", "Cartwright", "Grace" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Enrique_Cronin72@hotmail.com", "Planner", "Cronin", "Enrique" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Rick_West@gmail.com", "input", "West", "Rick" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jean_Gleichner@gmail.com", "Curve", "Gleichner", "Jean" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Lorene.Berge@gmail.com", "payment", "Berge", "Lorene" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Ida84@yahoo.com", "Research", "Sauer", "Ida" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Wilma67@hotmail.com", "Integration", "Zulauf", "Wilma" });

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 1,
                column: "filiereId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 2,
                column: "filiereId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 3,
                column: "filiereId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 4,
                column: "filiereId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 576, DateTimeKind.Local).AddTicks(1830), 2117 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(483), 2301, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(573), 2216, "Attestation de scolarite" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(596), 2125, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(619), 2087 });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Trantowmouth", "EE22858", 4, "G153757", new DateTime(1978, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Casper@gmail.com", "Alberta", "Casper", "Macedonia", "633-707-3077 x93852", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tavaresshire", "EE3087", 1, "G14787", new DateTime(1968, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Angelica46@gmail.com", "Angelica", "O'Conner", "Netherlands Antilles", "1-233-373-2857", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Predovicmouth", "EE15320", 1, "G264866", new DateTime(1970, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Darrel.Weber55@yahoo.com", "Darrel", "Weber", "Togo", "519.405.3028 x797", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wunschmouth", "EE29178", 1, "G145789", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Javier_Boehm@yahoo.com", "Javier", "Boehm", "Republic of Korea", "429.834.5628 x09298" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Myles", "EE57358", 1, "G133217", new DateTime(1975, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Milton_Reinger@gmail.com", "Milton", "Reinger", "Costa Rica", "275-575-0273 x848" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rathbury", "EE28153", 1, "G146087", new DateTime(1988, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Elias_Ernser19@gmail.com", "Elias", "Ernser", "Philippines", "1-508-626-0971" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Leta", "EE17106", "G556021", new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Erin61@yahoo.com", "Erin", "Labadie", "Democratic People's Republic of Korea", "(858) 669-4483 x946", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hankside", "EE9337", "G593024", new DateTime(1961, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Keith.Monahan@yahoo.com", "Keith", "Monahan", "Sudan", "(369) 568-4554", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Freeda", "EE50983", "G319037", new DateTime(1955, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie8@hotmail.com", "Jeannie", "Herzog", "South Georgia and the South Sandwich Islands", "327.260.7559" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pagacburgh", "EE37483", 3, "G61787", new DateTime(1955, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cesar.Ankunding@yahoo.com", "Cesar", "Ankunding", "Italy", "809-246-7308", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2010,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Darrion", "EE57200", 2, "G156142", new DateTime(1984, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Stamm@gmail.com", "Jacqueline", "Stamm", "Serbia", "485-464-1713 x0937", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Gennarostad", "EE19708", 2, "G197826", new DateTime(1960, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Tromp62@yahoo.com", "Sadie", "Tromp", "Ecuador", "394-448-2227 x31528" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lebsackview", "EE50778", 4, "G541575", new DateTime(1963, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mary_Prosacco@hotmail.com", "Mary", "Prosacco", "Kiribati", "1-959-293-9453 x52847" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Halleside", "EE13283", 1, "G56552", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sherry.Flatley@hotmail.com", "Sherry", "Flatley", "Samoa", "611.352.7696 x101", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Whitneymouth", "EE30308", "G85402", new DateTime(1961, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine_Moen10@yahoo.com", "Jermaine", "Moen", "Slovakia (Slovak Republic)", "1-579-335-3322 x164", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Cordiaberg", "EE53861", 3, "G256496", new DateTime(1957, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Thomas90@gmail.com", "Thomas", "Reilly", "Antigua and Barbuda", "582.913.2708" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Princemouth", "EE7160", "G216743", new DateTime(1976, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Saul66@gmail.com", "Saul", "Hudson", "Western Sahara", "730-624-3314 x360", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2017,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brekkeport", "EE50981", 1, "G243934", new DateTime(1961, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Roman1@hotmail.com", "Roman", "Kub", "Wallis and Futuna", "(538) 285-5065", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2018,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Elisabethton", "EE54695", "G352843", new DateTime(1962, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Noel74@hotmail.com", "Noel", "Mitchell", "Algeria", "1-347-498-6122 x99454", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Lewismouth", "EE16772", "G587331", new DateTime(1994, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lynn.Schaden@hotmail.com", "Lynn", "Schaden", "Samoa", "1-881-332-8169" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Morissetteton", "EE2716", 4, "G348172", new DateTime(1975, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Brent.Sanford74@yahoo.com", "Brent", "Sanford", "Turkmenistan", "553-843-1564 x681", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Oda", "EE8760", "G5504", new DateTime(1985, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kristopher.OHara33@hotmail.com", "Kristopher", "O'Hara", "Madagascar", "875-775-6107", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Magnusstad", "EE2078", 1, "G275569", new DateTime(1958, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jared_Hermann@yahoo.com", "Jared", "Hermann", "Bulgaria", "601.602.5907" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Alanis", "EE30304", "G187401", new DateTime(1971, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tiffany.Sawayn@hotmail.com", "Tiffany", "Sawayn", "Spain", "1-686-637-0252", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Flavieshire", "EE22342", 2, "G329611", new DateTime(1964, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Allan.Kozey@yahoo.com", "Allan", "Kozey", "Aruba", "330-972-2541 x53296" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Torreystad", "EE7401", "G490007", new DateTime(1952, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta51@hotmail.com", "Henrietta", "Hayes", "Heard Island and McDonald Islands", "920.675.9075" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hoseashire", "EE7056", "G59795", new DateTime(1962, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Carl98@gmail.com", "Carl", "Murray", "Philippines", "1-494-818-1191 x007" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2027,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hermannfort", "EE34390", 4, "G367884", new DateTime(1959, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Dickens78@yahoo.com", "Priscilla", "Dickens", "Trinidad and Tobago", "1-847-425-0462" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2028,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Xander", "EE20976", 3, "G24804", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shawna_Ratke87@hotmail.com", "Shawna", "Ratke", "Niger", "(778) 418-2272 x57062" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2029,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Clarabelleborough", "EE4054", 1, "G490359", new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Philip.Welch99@yahoo.com", "Philip", "Welch", "Jamaica", "927-728-1451 x71855" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2030,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Woodrowport", "EE18395", 4, "G527785", new DateTime(1957, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Veum@hotmail.com", "Abraham", "Veum", "Tanzania", "922-243-1747", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2031,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Feeneystad", "EE18369", "G235722", new DateTime(1970, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Saul_Pfannerstill@hotmail.com", "Saul", "Pfannerstill", "Austria", "(925) 204-6430 x5194" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Pasqualefurt", "EE2262", "G353582", new DateTime(2000, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty6@hotmail.com", "Betty", "Harvey", "Germany", "623.813.7130 x3041" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2033,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Chanceside", "EE43613", "G47774", new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rex.Stiedemann89@gmail.com", "Rex", "Stiedemann", "Holy See (Vatican City State)", "1-636-368-8126" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2034,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Leora", "EE45056", 2, "G216820", new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kent.Skiles55@yahoo.com", "Kent", "Skiles", "Armenia", "(553) 228-0051" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2035,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Fordton", "EE44580", 1, "G249889", new DateTime(1976, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Brandi.Schaefer99@yahoo.com", "Brandi", "Schaefer", "Virgin Islands, British", "1-352-702-9700 x742", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Mohammadburgh", "EE9385", 3, "G95973", new DateTime(1997, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Miriam_Jerde@hotmail.com", "Miriam", "Jerde", "Congo", "809.819.7036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kristofferfort", "EE16072", "G75361", new DateTime(1961, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Murazik@yahoo.com", "Brent", "Murazik", "Guatemala", "1-822-305-5468 x7125", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Langworthtown", "EE31315", 3, "G575723", new DateTime(1965, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Greg1@hotmail.com", "Greg", "Gutkowski", "Maldives", "930-538-7707 x70817", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Leslie", "EE37096", 1, "G435383", new DateTime(1954, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kyle.Paucek98@gmail.com", "Kyle", "Paucek", "Albania", "1-649-474-9719" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2040,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bulahshire", "EE15478", 2, "G218534", new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "John15@gmail.com", "John", "Pagac", "Brazil", "1-824-825-6669 x3410", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2041,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Joelle", "EE59385", 3, "G95974", new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Georgia53@yahoo.com", "Georgia", "Cruickshank", "Turks and Caicos Islands", "891-782-6952", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alannabury", "EE45582", 4, "G308838", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Erik66@gmail.com", "Erik", "Bogan", "Namibia", "219.520.3668 x667" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cordellhaven", "EE40285", 2, "G186178", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Frami28@hotmail.com", "Florence", "Frami", "Albania", "(865) 691-9233" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lamont", "EE47447", "G308450", new DateTime(1998, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Maurice.Nitzsche@gmail.com", "Maurice", "Nitzsche", "Falkland Islands (Malvinas)", "321.776.0503", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jeromychester", "EE51398", 2, "G24004", new DateTime(1969, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Katrina.Bashirian@hotmail.com", "Katrina", "Bashirian", "Saint Pierre and Miquelon", "1-423-330-9698" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boscoburgh", "EE2972", 2, "G152093", new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Irvin_Kuphal18@yahoo.com", "Irvin", "Kuphal", "Guinea-Bissau", "1-614-646-6858 x978", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wittingborough", "EE58793", "G116267", new DateTime(1971, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Merle40@hotmail.com", "Merle", "Mante", "Syrian Arab Republic", "675-236-6428 x973" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2048,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Beckerton", "EE8008", "G388489", new DateTime(1987, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Alison_Parisian58@yahoo.com", "Alison", "Parisian", "Rwanda", "1-905-511-2217 x98710", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2049,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jaydenmouth", "EE36039", "G384858", new DateTime(1984, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rex_Sawayn@hotmail.com", "Rex", "Sawayn", "Botswana", "231-296-7747 x53849", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Santos", "EE28953", 4, "G103623", new DateTime(1984, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Grant@hotmail.com", "Marcus", "Grant", "Croatia", "1-574-660-4080", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Keeblerport", "EE38360", 4, "G32540", new DateTime(1966, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Orville_Rutherford@yahoo.com", "Orville", "Rutherford", "Sierra Leone", "596.816.6962 x65046", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Quinn", "EE18578", 1, "G223915", new DateTime(1961, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Joy72@yahoo.com", "Joy", "Lesch", "Sierra Leone", "374.388.3287 x2231" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2053,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stanleyborough", "EE50571", 1, "G563970", new DateTime(1953, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Elena90@gmail.com", "Elena", "Heathcote", "Costa Rica", "339.225.0258", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2054,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fredericland", "EE51210", 1, "G280598", new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Archie99@hotmail.com", "Archie", "Erdman", "Hungary", "(221) 241-7948 x776", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Christopheview", "EE36147", "G439881", new DateTime(1963, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Keith_Ernser@hotmail.com", "Keith", "Ernser", "Russian Federation", "1-621-741-6398" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Walkermouth", "EE10003", "G270940", new DateTime(1964, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Marks3@hotmail.com", "Dianna", "Marks", "Burkina Faso", "(335) 651-5049", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2057,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Antoinette", "EE38390", 3, "G25978", new DateTime(1958, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia_Reichel@yahoo.com", "Sylvia", "Reichel", "Ecuador", "(214) 851-0269 x45327" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2058,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Theresamouth", "EE44521", "G228201", new DateTime(1961, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Angelica_Swift38@gmail.com", "Angelica", "Swift", "India", "963-898-0296 x486" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2059,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Oswald", "EE46917", "G343111", new DateTime(1962, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wesley.McLaughlin@gmail.com", "Wesley", "McLaughlin", "Grenada", "(350) 637-3035", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2060,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Shanellebury", "EE54258", 4, "G595652", new DateTime(1968, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Pagac@yahoo.com", "Jackie", "Pagac", "Malta", "1-945-761-0045" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Adeleborough", "EE14617", 3, "G286128", new DateTime(1994, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sonia59@yahoo.com", "Sonia", "Upton", "French Polynesia", "702-917-3125", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2062,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jarrellshire", "EE34591", 2, "G292762", new DateTime(1957, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Henry_Walsh25@hotmail.com", "Henry", "Walsh", "Turkey", "597-644-4788 x5030", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2063,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gaylordbury", "EE39317", 2, "G196074", new DateTime(1955, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie.Bogan@yahoo.com", "Jeannie", "Bogan", "Taiwan", "634-424-1629 x209" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2064,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jamaalside", "EE36371", 4, "G295384", new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alejandro.Kovacek34@yahoo.com", "Alejandro", "Kovacek", "Moldova", "(392) 492-2860", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Deshawnberg", "EE23331", 3, "G559082", new DateTime(1986, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jose_Marvin@gmail.com", "Jose", "Marvin", "Mongolia", "(836) 825-5777 x26987" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Myriam", "EE14817", "G284614", new DateTime(1981, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Stacy28@gmail.com", "Stacy", "Conn", "Mauritius", "1-761-421-0338", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2067,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Rustyfort", "EE39875", 4, "G96482", new DateTime(1979, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Merle91@hotmail.com", "Merle", "Ryan", "Cameroon", "959.367.8931 x446", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2068,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Kole", "EE38053", 3, "G195439", new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gwen_Gibson@gmail.com", "Gwen", "Gibson", "Malawi", "1-965-985-6869 x428", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Gwen", "EE32916", 4, "G318322", new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Floyd37@yahoo.com", "Floyd", "Brown", "Guam", "465-430-1056 x710" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Harberport", "EE24623", 1, "G537391", new DateTime(1963, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Erma73@hotmail.com", "Erma", "Kuhlman", "Chad", "385-711-1310 x012", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kathleenton", "EE28050", 3, "G75441", new DateTime(1960, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Darrell.Predovic@yahoo.com", "Darrell", "Predovic", "Slovakia (Slovak Republic)", "851.882.0132 x8364" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marquesview", "EE29795", 3, "G27936", new DateTime(1966, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Beverly_Mueller@gmail.com", "Beverly", "Mueller", "Seychelles", "1-912-868-0246 x95729" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Torpmouth", "EE41119", 3, "G285440", new DateTime(1980, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Mann60@yahoo.com", "Brent", "Mann", "Algeria", "1-493-438-7160 x51207", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Josue", "EE9617", 3, "G518748", new DateTime(1979, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bryan72@hotmail.com", "Bryan", "Gusikowski", "Ghana", "1-930-324-0128 x162" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Breanne", "EE51121", "G328617", new DateTime(1964, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Huel@yahoo.com", "Abraham", "Huel", "Mauritania", "1-835-963-4393 x85723" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Lelahville", "EE56033", 1, "G409556", new DateTime(1988, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo_Smith@gmail.com", "Rodolfo", "Smith", "Cape Verde", "(948) 812-1250 x728" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Maximilianmouth", "EE21393", "G95541", new DateTime(1966, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Roderick_Harris95@hotmail.com", "Roderick", "Harris", "Oman", "300-487-9235 x9936", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hilllville", "EE34890", 2, "G434796", new DateTime(1970, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo_Lemke@yahoo.com", "Gustavo", "Lemke", "Holy See (Vatican City State)", "(817) 354-9157 x0682", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Astrid", "EE11713", 1, "G504646", new DateTime(1963, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Margie_Kertzmann@gmail.com", "Margie", "Kertzmann", "Samoa", "974-767-7837 x580", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Geovannifort", "EE40557", "G315251", new DateTime(1990, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Denise17@hotmail.com", "Denise", "Bartoletti", "Senegal", "1-239-684-0959", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Georgiannahaven", "EE2138", "G33150", new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mabel17@yahoo.com", "Mabel", "Metz", "United Arab Emirates", "1-200-877-8211", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Gertrude", "EE58467", "G192915", new DateTime(1970, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Laurence_Gleason61@yahoo.com", "Laurence", "Gleason", "San Marino", "1-983-604-8621 x744", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardshire", "EE3999", 1, "G500947", new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gordon64@hotmail.com", "Gordon", "Mante", "Singapore", "589-708-6836" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Breitenbergshire", "EE55890", "G164178", new DateTime(1971, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rose.Cormier85@gmail.com", "Rose", "Cormier", "Palestinian Territory", "(295) 837-2935", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Percivalmouth", "EE55017", 1, "G588241", new DateTime(1951, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Holly4@yahoo.com", "Holly", "Jacobson", "Bhutan", "432.373.1487 x638" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2086,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Eliseohaven", "EE15216", "G305834", new DateTime(1984, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Leland_Rau62@yahoo.com", "Leland", "Rau", "Belgium", "697-309-7058 x397", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2087,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Klingfort", "EE49509", 1, "G539139", new DateTime(1991, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nathaniel2@yahoo.com", "Nathaniel", "Tremblay", "Turkey", "1-368-999-2291", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2088,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Laurinehaven", "EE45085", 4, "G105223", new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Simon.Shanahan38@gmail.com", "Simon", "Shanahan", "Solomon Islands", "(404) 720-1709", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2089,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Reilly", "EE12944", 4, "G123086", new DateTime(1998, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lucia.Emard29@yahoo.com", "Lucia", "Emard", "Cyprus", "(965) 351-8790 x8508", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2090,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Crystelview", "EE35698", 4, "G547889", new DateTime(1952, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Leslie54@yahoo.com", "Leslie", "Yost", "Brazil", "774.682.0580 x50047" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2091,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Sofia", "EE21123", 4, "G307177", new DateTime(1956, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ellen93@hotmail.com", "Ellen", "Herman", "Guernsey", "627.388.1592 x752" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2092,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Considineberg", "EE9972", "G590506", new DateTime(1953, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Dixie_Rutherford81@hotmail.com", "Dixie", "Rutherford", "Guadeloupe", "746.537.7592 x9302", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2093,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ondrickaton", "EE41890", "G312395", new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Barry_Tillman@gmail.com", "Barry", "Tillman", "Poland", "409-379-1851 x52139" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2094,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Adolphusborough", "EE23584", "G13981", new DateTime(1988, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Kessler@hotmail.com", "Elsa", "Kessler", "Burundi", "878.516.4751 x81131", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2095,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North William", "EE12704", 1, "G492936", new DateTime(1965, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Andre.Ortiz@yahoo.com", "Andre", "Ortiz", "Monaco", "(237) 637-9260", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2096,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Robertoburgh", "EE34307", 1, "G69948", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Veum27@gmail.com", "Nora", "Veum", "Azerbaijan", "461-627-8680" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2097,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zemlakburgh", "EE59584", 1, "G572683", new DateTime(1978, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Paul_Wolff72@hotmail.com", "Paul", "Wolff", "Argentina", "266-231-0889" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2098,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Wyman", "EE52129", 1, "G158001", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stewart80@hotmail.com", "Stewart", "Auer", "Uganda", "1-881-252-5707 x95928" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2099,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jorgeland", "EE1612", 2, "G83738", new DateTime(1952, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Sheila.Beatty@hotmail.com", "Sheila", "Beatty", "Morocco", "247.468.1639" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2100,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cheyannehaven", "EE27114", 4, "G82866", new DateTime(1964, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ginger_Lubowitz@yahoo.com", "Ginger", "Lubowitz", "Spain", "713.376.2687 x2100" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johannamouth", "EE43858", "G509118", new DateTime(1999, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Cathy.Marvin57@hotmail.com", "Cathy", "Marvin", "Lao People's Democratic Republic", "985-890-6620 x83598", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Farrellburgh", "EE26107", 1, "G102487", new DateTime(1974, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Cesar45@gmail.com", "Cesar", "Strosin", "Norway", "385-628-0714" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maddisonburgh", "EE31296", "G370348", new DateTime(1968, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Phillip52@yahoo.com", "Phillip", "Schumm", "Israel", "(472) 501-7704 x3299" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Johnpaul", "EE40915", "G509886", new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Bert.Torphy@gmail.com", "Bert", "Torphy", "Montenegro", "882.427.9094" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Aureliafort", "EE34237", 4, "G410371", new DateTime(1988, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bill.Pollich@hotmail.com", "Bill", "Pollich", "Puerto Rico", "854.797.9749 x90251", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Jamesonfurt", "EE31975", 3, "G204874", new DateTime(1956, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lydia72@gmail.com", "Lydia", "Wunsch", "Pakistan", "583-468-7414 x00253" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2107,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Alek", "EE31604", 2, "G368278", new DateTime(1952, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Esther.Gleason0@yahoo.com", "Esther", "Gleason", "Niger", "747.466.2089" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2108,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Ahmad", "EE47323", 1, "G227346", new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Zemlak@yahoo.com", "Marlene", "Zemlak", "Mauritius", "(893) 526-1711", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2109,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Breana", "EE55360", 2, "G245768", new DateTime(1951, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bert_Heathcote77@gmail.com", "Bert", "Heathcote", "Cuba", "1-361-499-1890 x4371", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2110,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Derekfurt", "EE39417", 4, "G189839", new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Antonia_Leffler@hotmail.com", "Antonia", "Leffler", "Turkmenistan", "481.870.2241 x8131" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2111,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nannieshire", "EE11640", 1, "G292611", new DateTime(1981, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Maurice44@yahoo.com", "Maurice", "Treutel", "Maldives", "986.924.8268 x93079", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2112,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Alffort", "EE54564", "G115624", new DateTime(1959, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marion_Bogisich44@gmail.com", "Marion", "Bogisich", "Uzbekistan", "1-690-549-8298 x829" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roobmouth", "EE21156", 1, "G479741", new DateTime(1985, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Garrett.Wunsch86@yahoo.com", "Garrett", "Wunsch", "Holy See (Vatican City State)", "249.742.2799 x0387" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Reingerview", "EE30637", 2, "G314844", new DateTime(1975, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Robert88@gmail.com", "Robert", "Prohaska", "Mongolia", "(538) 346-1123 x5283" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gerholdhaven", "EE55401", 3, "G25558", new DateTime(1976, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Roxanne_Abbott71@yahoo.com", "Roxanne", "Abbott", "Lithuania", "(570) 800-5960", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tessieport", "EE28496", "G214341", new DateTime(1987, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Meghan.Balistreri@yahoo.com", "Meghan", "Balistreri", "Malawi", "1-590-676-9239 x583" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cieloburgh", "EE1008", "G480501", new DateTime(1953, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shawna77@gmail.com", "Shawna", "Graham", "Vietnam", "649-214-1326", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Heidenreichmouth", "EE2934", 1, "G82256", new DateTime(2000, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marsha60@hotmail.com", "Marsha", "Jast", "Bhutan", "364-389-0006 x972", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Erinshire", "EE46615", 1, "G243930", new DateTime(1976, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lamar.Conroy@hotmail.com", "Lamar", "Conroy", "Cocos (Keeling) Islands", "(437) 406-7547 x2687" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Yadiraside", "EE3323", 4, "G23309", new DateTime(1988, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Patty.Kassulke@gmail.com", "Patty", "Kassulke", "South Georgia and the South Sandwich Islands", "701.897.1026" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2121,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rohanhaven", "EE20975", 3, "G342466", new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ross.Lang@gmail.com", "Ross", "Lang", "Gabon", "(206) 918-3427 x27080", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2122,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kalebshire", "EE12372", 4, "G101103", new DateTime(1966, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Weissnat9@yahoo.com", "Nora", "Weissnat", "Iran", "950.763.9305" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2123,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Naderbury", "EE10107", 4, "G84886", new DateTime(1986, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Elisa73@yahoo.com", "Elisa", "Koelpin", "Gibraltar", "850.751.0308 x3400" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2124,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Braxtonberg", "EE43198", 2, "G307055", new DateTime(1956, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Wilma_Satterfield84@yahoo.com", "Wilma", "Satterfield", "Puerto Rico", "630.949.1174", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2125,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Uniquebury", "EE30991", 2, "G353053", new DateTime(1991, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Gordon_McGlynn@yahoo.com", "Gordon", "McGlynn", "Zimbabwe", "280-561-2213 x619" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2126,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rickey", "EE22948", 2, "G537043", new DateTime(1982, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Megan5@gmail.com", "Megan", "Bartoletti", "French Guiana", "(993) 287-2089 x4436", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Langworthchester", "EE57505", 1, "G58543", new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jaime35@gmail.com", "Jaime", "VonRueden", "Kuwait", "(910) 612-5829", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2128,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ivyfort", "EE16048", 3, "G577501", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Wayne_Stokes75@gmail.com", "Wayne", "Stokes", "Finland", "(667) 286-3808 x0736" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2129,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Christianamouth", "EE53729", 3, "G133181", new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jean81@yahoo.com", "Jean", "Waelchi", "South Georgia and the South Sandwich Islands", "665-293-5580 x20655" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Osinskiland", "EE17683", 1, "G106842", new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ana.Kreiger55@yahoo.com", "Ana", "Kreiger", "Trinidad and Tobago", "(593) 471-9990", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Deckowmouth", "EE207", 2, "G389533", new DateTime(1993, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Enrique.Hansen@hotmail.com", "Enrique", "Hansen", "France", "1-875-740-6765 x177", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2132,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ursulaberg", "EE45794", 4, "G545843", new DateTime(1998, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Kuhic69@yahoo.com", "Sadie", "Kuhic", "Senegal", "1-536-480-4013" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2133,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Carley", "EE18320", 3, "G151777", new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dean22@yahoo.com", "Dean", "Kihn", "Bouvet Island (Bouvetoya)", "1-287-496-4492" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2134,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Eloisaburgh", "EE19983", "G256422", new DateTime(1952, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Wisoky@hotmail.com", "Douglas", "Wisoky", "Palau", "(591) 836-1027 x422" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2135,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Pedro", "EE724", 2, "G318968", new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew_Heidenreich27@gmail.com", "Andrew", "Heidenreich", "Angola", "840.518.3395 x36199" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hilarioborough", "EE23632", 3, "G301569", new DateTime(1955, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Hettinger57@yahoo.com", "Florence", "Hettinger", "Georgia", "1-668-816-3086 x44893" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Darienmouth", "EE55502", 3, "G12426", new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Olivia41@yahoo.com", "Olivia", "Nienow", "Haiti", "572.687.7456 x10737", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hamillside", "EE44398", 3, "G54308", new DateTime(1957, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie_Bruen@hotmail.com", "Marjorie", "Bruen", "Macedonia", "292-762-9578 x2843" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Garthfurt", "EE26244", "G309990", new DateTime(1966, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Ernser53@hotmail.com", "Inez", "Ernser", "Denmark", "1-961-698-0696 x919" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jovany", "EE11501", "G327685", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Rebecca25@gmail.com", "Rebecca", "Dach", "Estonia", "251-835-1632 x0073" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Vivientown", "EE45467", 3, "G274605", new DateTime(1957, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Eloise4@gmail.com", "Eloise", "Pouros", "Holy See (Vatican City State)", "1-240-793-8388 x248", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Boganmouth", "EE7490", "G566522", new DateTime(1981, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cedric.Hettinger14@yahoo.com", "Cedric", "Hettinger", "Democratic People's Republic of Korea", "814-237-6814" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2143,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rowenastad", "EE43787", 4, "G283771", new DateTime(1955, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rafael67@gmail.com", "Rafael", "Marquardt", "Algeria", "(972) 246-8651 x825", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2144,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bodeborough", "EE55386", "G411774", new DateTime(1998, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery.Hegmann@gmail.com", "Jeffery", "Hegmann", "Falkland Islands (Malvinas)", "517.378.2676 x55360" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2145,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Turcotteberg", "EE10038", 1, "G49074", new DateTime(1995, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Daryl.Block75@yahoo.com", "Daryl", "Block", "Monaco", "(605) 376-5560 x22592" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2146,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boehmbury", "EE8073", "G359540", new DateTime(1980, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mercedes0@hotmail.com", "Mercedes", "Sipes", "Armenia", "(766) 995-5737 x033", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Royce", "EE45519", "G510759", new DateTime(1954, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Denise32@hotmail.com", "Denise", "Morissette", "Gambia", "774.702.5292 x329", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2148,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kutchshire", "EE27883", 4, "G439260", new DateTime(1958, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jeremy.McClure@hotmail.com", "Jeremy", "McClure", "Pitcairn Islands", "540.830.6619 x57670" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2149,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Williamsonbury", "EE35574", 4, "G499620", new DateTime(1967, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Carolyn_Hoppe75@yahoo.com", "Carolyn", "Hoppe", "Turkmenistan", "829-472-3533 x00289", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2150,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maximillianport", "EE2166", 2, "G274541", new DateTime(1968, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Oliver_Terry@gmail.com", "Oliver", "Terry", "Falkland Islands (Malvinas)", "833-531-4211 x99906" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2151,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Colton", "EE9910", 2, "G258582", new DateTime(1957, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Willard.Lockman@hotmail.com", "Willard", "Lockman", "Belgium", "302.540.4051 x277", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "North Larissa", "EE22005", 3, "G530045", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Terri83@hotmail.com", "Terri", "Donnelly", "(978) 729-9026", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wymanmouth", "EE55520", 4, "G510279", new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Theodore28@hotmail.com", "Theodore", "Barton", "Brazil", "629.848.1395 x9894", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2154,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Gianni", "EE170", "G307034", new DateTime(1959, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Scott64@hotmail.com", "Scott", "Aufderhar", "Afghanistan", "(515) 872-4893 x229" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2155,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kennashire", "EE15591", 4, "G70991", new DateTime(1965, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Johanna_McCullough@hotmail.com", "Johanna", "McCullough", "Kyrgyz Republic", "656.761.5507 x4136", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2156,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Noraton", "EE49079", 1, "G419608", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lester_Nitzsche@hotmail.com", "Lester", "Nitzsche", "Djibouti", "1-903-527-3949", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2157,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wilfredbury", "EE52492", 3, "G420653", new DateTime(1974, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Penny.Wolff41@yahoo.com", "Penny", "Wolff", "Fiji", "(853) 504-5209 x464" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Amiebury", "EE33845", "G380076", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Eileen75@hotmail.com", "Eileen", "Gaylord", "Cuba", "1-451-344-8307 x862", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Mayabury", "EE32054", 1, "G38291", new DateTime(1984, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Traci3@hotmail.com", "Traci", "Will", "Monaco", "482.969.3974 x4324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ornberg", "EE12329", 4, "G163383", new DateTime(1951, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Caroline.Huels74@gmail.com", "Caroline", "Huels", "Virgin Islands, British", "253-796-3101 x8676" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Botsfordland", "EE7264", "G164290", new DateTime(1986, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Arlene30@gmail.com", "Arlene", "Schmidt", "Reunion", "1-262-738-9233 x5467" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2162,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Randallborough", "EE55971", 2, "G469582", new DateTime(1999, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Roderick97@yahoo.com", "Roderick", "Mann", "Estonia", "(294) 274-1932" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2163,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Nikita", "EE48956", 1, "G299524", new DateTime(1971, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Casey.Moen3@hotmail.com", "Casey", "Moen", "Hungary", "1-200-806-0137", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2164,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Furmanborough", "EE51307", 3, "G465587", new DateTime(1990, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lynda.Maggio23@hotmail.com", "Lynda", "Maggio", "Republic of Korea", "594-646-9749" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2165,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Hermann", "EE45546", 1, "G105098", new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Wiegand@yahoo.com", "Paulette", "Wiegand", "Morocco", "(749) 355-0427 x666", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cadenshire", "EE29398", "G44745", new DateTime(1965, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Raul_Nolan12@hotmail.com", "Raul", "Nolan", "Croatia", "219.252.3915" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Dock", "EE54062", "G408688", new DateTime(1974, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Wyman@hotmail.com", "Aaron", "Wyman", "Belize", "(350) 406-7745 x56047", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nitzscheton", "EE55263", "G328447", new DateTime(1958, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo17@gmail.com", "Guillermo", "Huel", "Democratic People's Republic of Korea", "(491) 949-5339 x61571" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Deliatown", "EE59676", 2, "G213230", new DateTime(1966, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ernest_Bechtelar8@yahoo.com", "Ernest", "Bechtelar", "Honduras", "1-699-504-3458 x364" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2170,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Winfieldstad", "EE9642", "G160321", new DateTime(1955, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Leffler29@gmail.com", "Pete", "Leffler", "New Zealand", "1-476-470-0602", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2171,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schadenland", "EE59137", "G452374", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Greenfelder96@hotmail.com", "Albert", "Greenfelder", "Grenada", "796.689.2723", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hintzfurt", "EE9281", 4, "G485615", new DateTime(1962, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Edward.Kunde@hotmail.com", "Edward", "Kunde", "Belize", "542-525-7431" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Terryview", "EE41134", 1, "G375328", new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Thomas.Davis@gmail.com", "Thomas", "Davis", "Palestinian Territory", "523.864.5181" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2174,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Handtown", "EE2568", 4, "G356020", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Geraldine_Batz@yahoo.com", "Geraldine", "Batz", "Equatorial Guinea", "671-771-3283 x855" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2175,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Katelynstad", "EE6943", "G16545", new DateTime(1959, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nicholas_Hane0@yahoo.com", "Nicholas", "Hane", "Kazakhstan", "664-771-2229", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2176,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Elsaton", "EE38812", "G44062", new DateTime(1983, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Maggie.Lang@hotmail.com", "Maggie", "Lang", "Libyan Arab Jamahiriya", "(495) 632-2256" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2177,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Huelmouth", "EE2068", 2, "G589068", new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Candice34@hotmail.com", "Candice", "Hermann", "Canada", "(390) 981-8088" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2178,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Edwin", "EE35666", 1, "G82059", new DateTime(1978, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Bergnaum@yahoo.com", "Nora", "Bergnaum", "Colombia", "1-480-884-4929 x800", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kianmouth", "EE33238", 4, "G293420", new DateTime(1962, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Brandon_Donnelly@yahoo.com", "Brandon", "Donnelly", "Syrian Arab Republic", "878-581-0135 x31024" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Connshire", "EE17904", "G71946", new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Hartmann@yahoo.com", "Mildred", "Hartmann", "Costa Rica", "904.401.8282 x9155", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Edwardview", "EE32209", 2, "G308902", new DateTime(1976, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Desiree.Gottlieb72@gmail.com", "Desiree", "Gottlieb", "Puerto Rico", "799.805.1009", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Branditown", "EE32999", "G518599", new DateTime(1970, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Beer52@yahoo.com", "Leona", "Beer", "Burundi", "961-222-3408 x9642" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2183,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Charity", "EE25702", 4, "G394004", new DateTime(1976, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Catherine_Gorczany92@hotmail.com", "Catherine", "Gorczany", "United States Minor Outlying Islands", "1-612-634-1619 x9381" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2184,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maggioville", "EE24765", "G48713", new DateTime(1965, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jody.Bergstrom55@gmail.com", "Jody", "Bergstrom", "Mayotte", "208-486-2246", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Theresia", "EE47245", "G180529", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Fannie98@hotmail.com", "Fannie", "Keeling", "Faroe Islands", "1-636-588-6152 x45736" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2186,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mortimerborough", "EE43578", 4, "G93547", new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sean_Douglas@gmail.com", "Sean", "Douglas", "Cape Verde", "965.376.5812 x11721", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2187,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hunterview", "EE36185", "G57496", new DateTime(1961, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Cole@hotmail.com", "Priscilla", "Cole", "Gibraltar", "1-431-689-4613 x1324", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2188,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Ozellaland", "EE24758", "G321682", new DateTime(1972, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Gleason69@gmail.com", "Rhonda", "Gleason", "Chile", "835-245-0661 x5792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2189,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Alleneborough", "EE47272", 3, "G528557", new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Edwin47@hotmail.com", "Edwin", "Hoeger", "Spain", "1-328-300-4458 x30066" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2190,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Stacey", "EE44384", 3, "G255962", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Laurence.Gerlach@yahoo.com", "Laurence", "Gerlach", "Montenegro", "898.480.3317 x4844" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2191,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jazmyneville", "EE25105", 4, "G135126", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rachel86@yahoo.com", "Rachel", "Hickle", "Slovenia", "(248) 272-6720" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2192,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Harry", "EE47132", 2, "G383018", new DateTime(1951, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kevin_Bradtke@yahoo.com", "Kevin", "Bradtke", "Poland", "1-360-620-7709 x481", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lisamouth", "EE42177", 3, "G534433", new DateTime(1992, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Ian0@gmail.com", "Ian", "Conroy", "Egypt", "740-834-7177 x5327" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Alessia", "EE15621", 3, "G403908", new DateTime(1954, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Misty.Lang@hotmail.com", "Misty", "Lang", "Jordan", "989.773.8853" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Russelhaven", "EE56820", 2, "G198287", new DateTime(1956, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Murazik@yahoo.com", "Kathleen", "Murazik", "Georgia", "223.225.4264 x9542", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Yasminefort", "EE27556", 1, "G488107", new DateTime(1991, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa_Emard@yahoo.com", "Vanessa", "Emard", "New Zealand", "1-632-475-7203 x6980", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2197,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dinoberg", "EE24933", 3, "G528096", new DateTime(1955, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Wilson60@hotmail.com", "Wilson", "Collier", "Serbia", "(728) 305-6408 x9743" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2198,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hodkiewiczbury", "EE16442", 4, "G415216", new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Bennie2@hotmail.com", "Bennie", "Jenkins", "Uruguay", "1-638-250-4734 x269" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lambertside", "EE57201", "G174189", new DateTime(1963, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Joann63@gmail.com", "Joann", "Wehner", "Denmark", "688.660.7082 x363", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2200,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Croninport", "EE39115", 3, "G518532", new DateTime(1959, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ricky.Lowe50@yahoo.com", "Ricky", "Lowe", "Gambia", "647.368.6660 x0233", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2201,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weissnatshire", "EE18421", "G592967", new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jerry.Kessler@yahoo.com", "Jerry", "Kessler", "Bahrain", "710-671-0683" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2202,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schusterberg", "EE3986", 1, "G508332", new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Marguerite.Doyle@hotmail.com", "Marguerite", "Doyle", "Gabon", "1-837-690-4335", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2203,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wandaton", "EE1037", 2, "G418744", new DateTime(1965, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Myrtle_Douglas69@yahoo.com", "Myrtle", "Douglas", "Cape Verde", "295-413-9861" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Letitiaborough", "EE13954", 2, "G485751", new DateTime(1963, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sara.Schmidt@gmail.com", "Sara", "Schmidt", "Samoa", "(457) 233-6426 x893", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hirtheburgh", "EE49843", 1, "G162980", new DateTime(1994, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Darlene.White67@hotmail.com", "Darlene", "White", "Tuvalu", "883.714.0036", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Koeppbury", "EE20364", "G219311", new DateTime(1956, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Charlene_Kunde87@hotmail.com", "Charlene", "Kunde", "Cuba", "1-708-313-2322" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Haydenberg", "EE47727", 3, "G567657", new DateTime(1952, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Thelma_Sporer@gmail.com", "Thelma", "Sporer", "Netherlands Antilles", "(842) 284-0477 x8913", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobiville", "EE28995", 3, "G357616", new DateTime(1977, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Misty53@yahoo.com", "Misty", "Lebsack", "Bahamas", "1-620-418-9268 x1090" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gaylefort", "EE46385", "G370045", new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Luther.Watsica@hotmail.com", "Luther", "Watsica", "Saint Pierre and Miquelon", "(811) 238-1934 x612" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brendanland", "EE10128", 3, "G358008", new DateTime(1987, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jerry_Greenholt34@yahoo.com", "Jerry", "Greenholt", "Turkmenistan", "1-479-892-9067" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mason", "EE14764", "G283941", new DateTime(1975, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Corey.Herzog72@yahoo.com", "Corey", "Herzog", "Philippines", "(507) 430-0519 x608", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Keeley", "EE24242", "G227895", new DateTime(1975, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Eva58@yahoo.com", "Eva", "Langworth", "Niue", "295-621-5946", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Sandrineshire", "EE47927", 4, "G410654", new DateTime(1968, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Howard73@yahoo.com", "Howard", "Dickinson", "American Samoa", "(450) 893-1380 x79066" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Austentown", "EE12647", 2, "G324604", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Schuppe@gmail.com", "Aaron", "Schuppe", "Bangladesh", "376.705.5154 x74211", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Patiencebury", "EE34444", "G81550", new DateTime(1977, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Angelina.Dare@yahoo.com", "Angelina", "Dare", "Benin", "1-440-533-1231" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2216,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ashachester", "EE27541", 2, "G551603", new DateTime(1952, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dexter87@hotmail.com", "Dexter", "West", "Paraguay", "1-979-999-0493 x324", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2217,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schmittchester", "EE8553", 3, "G506944", new DateTime(1966, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Maureen_Hahn26@gmail.com", "Maureen", "Hahn", "Congo", "294-342-3098 x56253", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2218,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Devanteland", "EE53306", 3, "G32660", new DateTime(1991, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Renee87@gmail.com", "Renee", "Conroy", "Faroe Islands", "1-255-306-5821 x78417" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2219,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Juana", "EE29559", 4, "G401125", new DateTime(1980, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Frederick_Crona@hotmail.com", "Frederick", "Crona", "Slovakia (Slovak Republic)", "1-436-568-8593 x0032", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Axelhaven", "EE39188", 3, "G216637", new DateTime(1987, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Aubrey0@hotmail.com", "Aubrey", "Stokes", "Marshall Islands", "615-979-0361" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hailie", "EE13722", "G493235", new DateTime(1997, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Nick3@hotmail.com", "Nick", "Volkman", "Spain", "840.538.8626", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ledamouth", "EE4866", "G26330", new DateTime(1960, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Patti_Kling@hotmail.com", "Patti", "Kling", "Djibouti", "1-780-535-9528 x1757", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Kendall", "EE34886", 4, "G206984", new DateTime(1989, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Matthew.Schoen79@yahoo.com", "Matthew", "Schoen", "Iraq", "761.445.4514 x82476", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ilianaburgh", "EE44139", "G474959", new DateTime(1956, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Nichole18@hotmail.com", "Nichole", "Stroman", "Palestinian Territory", "1-642-969-5649 x08645" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Trentton", "EE40091", 1, "G38206", new DateTime(1969, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry90@hotmail.com", "Kerry", "Abernathy", "Germany", "1-463-959-8743 x159", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2226,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Macejkovicview", "EE31322", 1, "G232885", new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Velma.Jaskolski79@gmail.com", "Velma", "Jaskolski", "Portugal", "1-247-256-8395 x0374", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2227,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Runolfssonborough", "EE16357", 2, "G522696", new DateTime(1995, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Timothy_Herman@hotmail.com", "Timothy", "Herman", "El Salvador", "1-292-907-3324", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marleyville", "EE54050", 3, "G416884", new DateTime(1960, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Delbert38@yahoo.com", "Delbert", "Smith", "Bahrain", "775.990.8437" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2229,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Flo", "EE15660", 4, "G263257", new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Cody.West57@hotmail.com", "Cody", "West", "Saint Lucia", "424.554.5792", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2230,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Monahanfort", "EE41998", 2, "G348191", new DateTime(1972, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia69@gmail.com", "Cecelia", "Ferry", "New Caledonia", "711.901.3194", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Medhurstchester", "EE58912", 4, "G395698", new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Irene.Jacobs@hotmail.com", "Irene", "Jacobs", "Iran", "1-522-809-6146", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Titusmouth", "EE30791", "G559688", new DateTime(1990, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Eddie58@hotmail.com", "Eddie", "Mayer", "Niue", "1-992-375-5405 x3231", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Amie", "EE23294", 1, "G73661", new DateTime(1980, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ellis_Schimmel8@hotmail.com", "Ellis", "Schimmel", "Austria", "(384) 762-3864" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2234,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Morarside", "EE1530", 1, "G462716", new DateTime(1989, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Klocko@yahoo.com", "Leroy", "Klocko", "Vanuatu", "(715) 692-5909", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2235,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Daphneyview", "EE45330", 2, "G346902", new DateTime(1961, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tracy.Goyette68@hotmail.com", "Tracy", "Goyette", "Iran", "603-738-3745" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Brandtport", "EE19945", 4, "G543259", new DateTime(1957, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marcos_Kub@gmail.com", "Marcos", "Kub", "Italy", "(329) 684-3788", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dooleyshire", "EE3082", 3, "G508423", new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Joann86@hotmail.com", "Joann", "Gutkowski", "South Africa", "936.493.5974 x350" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bartolettihaven", "EE5801", 2, "G507238", new DateTime(1995, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Pacocha14@hotmail.com", "Kathleen", "Pacocha", "Thailand", "547-691-0400", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2239,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Domenicabury", "EE43760", 2, "G209017", new DateTime(1954, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tamara_Zulauf26@yahoo.com", "Tamara", "Zulauf", "Libyan Arab Jamahiriya", "1-212-884-4497 x922", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2240,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Issachaven", "EE34267", 1, "G103893", new DateTime(1968, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Troy_Dibbert15@yahoo.com", "Troy", "Dibbert", "Saint Kitts and Nevis", "(230) 486-9608 x571", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2241,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Brendonton", "EE34200", "G379545", new DateTime(1955, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "Dolores_Torphy@yahoo.com", "Dolores", "Torphy", "Maldives", "727.324.4899", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Nicklausberg", "EE19481", "G100154", new DateTime(1994, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Carrie52@gmail.com", "Carrie", "Lesch", "Belarus", "(508) 700-0761 x757" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Shaunborough", "EE6944", 4, "G181722", new DateTime(1961, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Paulette39@yahoo.com", "Paulette", "Daugherty", "Vanuatu", "(749) 400-3449 x46168", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Malindastad", "EE7666", "G219404", new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shelia89@gmail.com", "Shelia", "Weber", "Slovenia", "(319) 340-1468 x3538", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roycestad", "EE9660", 2, "G441228", new DateTime(1962, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas_Swift@yahoo.com", "Nicolas", "Swift", "Gibraltar", "835.622.5882" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kesslerport", "EE25095", 2, "G152460", new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leslie_Larson73@yahoo.com", "Leslie", "Larson", "Nepal", "1-713-565-3965", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Elianville", "EE24298", 3, "G250525", new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Dominic_Boehm88@hotmail.com", "Dominic", "Boehm", "British Indian Ocean Territory (Chagos Archipelago)", "(771) 757-6918 x7524" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Solonburgh", "EE43730", 4, "G72011", new DateTime(1951, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Ruecker@yahoo.com", "Fred", "Ruecker", "Maldives", "1-596-404-6614 x33890", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2249,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Samirbury", "EE47133", 3, "G568244", new DateTime(1960, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kelly_Purdy@yahoo.com", "Kelly", "Purdy", "Moldova", "1-912-521-9887" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2250,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lauraton", "EE27307", 2, "G156277", new DateTime(1961, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Krystal_Swift@hotmail.com", "Krystal", "Swift", "Greece", "(236) 350-7242 x7216" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Torphyside", "EE20470", "G475449", new DateTime(1968, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Devin.Brakus38@gmail.com", "Devin", "Brakus", "Argentina", "(585) 804-0965 x2278", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2252,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hauckmouth", "EE21063", 3, "G52936", new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jimmy54@hotmail.com", "Jimmy", "Heidenreich", "Pitcairn Islands", "926-657-4119" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2253,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jonesstad", "EE59568", 1, "G577161", new DateTime(1952, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Miriam36@hotmail.com", "Miriam", "Watsica", "Sweden", "1-706-468-4319", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dachland", "EE32045", 2, "G57761", new DateTime(1996, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bonnie86@hotmail.com", "Bonnie", "Simonis", "Morocco", "(714) 519-5543 x598" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Willis", "EE45698", 3, "G456681", new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Vernon_Larkin3@hotmail.com", "Vernon", "Larkin", "Guam", "1-496-828-1443" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cyrus", "EE11603", "G286993", new DateTime(1999, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Santiago_Daniel@gmail.com", "Santiago", "Daniel", "South Africa", "344-857-2875 x220" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ethylton", "EE55421", "G323532", new DateTime(1951, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jill_Jaskolski@yahoo.com", "Jill", "Jaskolski", "South Africa", "1-780-575-8900 x17059", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Daisyton", "EE18102", "G214082", new DateTime(1955, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Natasha79@gmail.com", "Natasha", "Powlowski", "Tuvalu", "799-472-8137 x057", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2259,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boscostad", "EE14999", 4, "G364208", new DateTime(1961, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kelley_OReilly@gmail.com", "Kelley", "O'Reilly", "Ecuador", "(890) 348-9442 x432", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2260,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Elwinberg", "EE53833", 2, "G111929", new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ebony.Ward@gmail.com", "Ebony", "Ward", "Gibraltar", "1-584-857-5910 x39338" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2261,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Eleanoraton", "EE1175", 3, "G95550", new DateTime(1958, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Warren8@yahoo.com", "Warren", "Adams", "Nepal", "851-512-7249" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2262,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jazmin", "EE45264", 2, "G538237", new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marian89@hotmail.com", "Marian", "Hayes", "Seychelles", "(816) 696-1565", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2263,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Laruehaven", "EE33813", 4, "G277607", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Schowalter@yahoo.com", "Velma", "Schowalter", "Chile", "(480) 353-5963", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Rethastad", "EE45449", 3, "G506885", new DateTime(1969, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hattie_Nader@gmail.com", "Hattie", "Nader", "Saudi Arabia", "690.253.8703 x18890", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Friesenville", "EE21274", 1, "G278176", new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Bryan_Hudson@hotmail.com", "Bryan", "Hudson", "Brunei Darussalam", "(721) 565-3560 x90269", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dawnmouth", "EE37124", 1, "G460014", new DateTime(1953, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Herbert_Breitenberg43@yahoo.com", "Herbert", "Breitenberg", "Virgin Islands, U.S.", "855.669.2492 x39886" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2267,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Faustino", "EE27089", 3, "G252656", new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tasha57@yahoo.com", "Tasha", "Kertzmann", "Bouvet Island (Bouvetoya)", "1-443-737-9152" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2268,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Hadleyborough", "EE34541", "G319133", new DateTime(1983, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Calvin98@hotmail.com", "Calvin", "Okuneva", "Vietnam", "703-498-0369" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Maggie", "EE47846", "G599209", new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Grant76@yahoo.com", "Pete", "Grant", "Hong Kong", "(905) 469-1792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2270,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Hectorfurt", "EE20816", 2, "G359872", new DateTime(1990, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenny_Glover31@gmail.com", "Jenny", "Glover", "Chile", "706-274-4895 x0316", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2271,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South John", "EE8454", 2, "G197792", new DateTime(1987, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ignacio_Romaguera@gmail.com", "Ignacio", "Romaguera", "Australia", "765-912-9052", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alecville", "EE6759", 3, "G176669", new DateTime(1994, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Joshua99@yahoo.com", "Joshua", "Bruen", "French Guiana", "486.908.5824 x9866" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Desmondside", "EE12448", 3, "G250075", new DateTime(1974, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Elvira_Schamberger@yahoo.com", "Elvira", "Schamberger", "Tanzania", "(373) 333-0736", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Marquardtmouth", "EE12392", 1, "G271413", new DateTime(1987, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Olga59@yahoo.com", "Olga", "Fahey", "American Samoa", "(600) 204-2824 x8591", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Mark", "EE585", "G400455", new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sidney92@yahoo.com", "Sidney", "Hoppe", "Cayman Islands", "(535) 769-8075", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2276,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zionview", "EE36579", 4, "G563496", new DateTime(1974, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Myra.Dooley28@gmail.com", "Myra", "Dooley", "Germany", "1-425-681-9768 x98148", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2277,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Gerardotown", "EE7374", 4, "G97009", new DateTime(1971, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Earnest69@hotmail.com", "Earnest", "Erdman", "Kiribati", "759-619-4606 x7412" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Strackemouth", "EE21649", "G360521", new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jodi_Ernser27@gmail.com", "Jodi", "Ernser", "Czech Republic", "594-726-1474" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobsborough", "EE16943", 2, "G420587", new DateTime(1951, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Carter72@yahoo.com", "Douglas", "Carter", "Nicaragua", "612-549-9748 x00665" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wuckertberg", "EE15717", 1, "G362261", new DateTime(1958, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Byron_Prohaska97@gmail.com", "Byron", "Prohaska", "Guinea", "423-370-8662", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abbottstad", "EE44315", 2, "G173676", new DateTime(1978, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cora_Pacocha61@yahoo.com", "Cora", "Pacocha", "San Marino", "387.538.4455 x35141", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2282,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Beulahburgh", "EE31905", "G3061", new DateTime(1951, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Donnie_Sauer46@hotmail.com", "Donnie", "Sauer", "Palau", "1-767-955-9378" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2283,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Maud", "EE36118", 3, "G360347", new DateTime(1967, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Latoya.Wisozk@gmail.com", "Latoya", "Wisozk", "India", "(448) 385-6332 x638", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2284,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Harry", "EE3476", 4, "G78141", new DateTime(1954, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ellen.Fadel@yahoo.com", "Ellen", "Fadel", "Guyana", "1-481-308-8478", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2285,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Alexie", "EE36409", 1, "G175462", new DateTime(1964, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia_Vandervort@hotmail.com", "Cecelia", "Vandervort", "Iceland", "766.513.7813 x459" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2286,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Antoinettemouth", "EE11995", 4, "G469596", new DateTime(1991, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jim83@gmail.com", "Jim", "Frami", "Pakistan", "1-332-374-7395" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2287,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Chance", "EE56339", 4, "G333955", new DateTime(1982, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Omar86@yahoo.com", "Omar", "Schulist", "Mali", "992.855.4150", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2288,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Mauricio", "EE13640", 3, "G224454", new DateTime(1967, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bertha_Homenick82@hotmail.com", "Bertha", "Homenick", "Angola", "1-497-873-9859" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2289,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Korey", "EE59518", 2, "G323638", new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lorena.King@yahoo.com", "Lorena", "King", "Sao Tome and Principe", "1-238-854-6840", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2290,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Garettfort", "EE56779", 3, "G108109", new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Conrad98@hotmail.com", "Conrad", "Reilly", "Finland", "1-426-272-9298", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Haneton", "EE18020", 1, "G113778", new DateTime(1965, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Rose94@hotmail.com", "Rose", "Breitenberg", "Ethiopia", "(513) 827-4169 x978", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Otis", "EE39607", 4, "G562256", new DateTime(1960, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Damon.Hodkiewicz@gmail.com", "Damon", "Hodkiewicz", "Cocos (Keeling) Islands", "602-203-8494 x137", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2293,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Allison", "EE3820", 1, "G454508", new DateTime(1969, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Homer31@yahoo.com", "Homer", "Powlowski", "Central African Republic", "572.783.8499 x789" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2294,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Sipeshaven", "EE12223", "G197137", new DateTime(1962, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Carol_Casper53@gmail.com", "Carol", "Casper", "Netherlands", "(719) 939-9293 x001" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jalen", "EE30664", "G500803", new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sidney96@gmail.com", "Sidney", "Dietrich", "United States of America", "490.853.1034 x49590" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Frederikberg", "EE28247", 2, "G422512", new DateTime(1953, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Pauline.Sipes@hotmail.com", "Pauline", "Sipes", "China", "403-295-7434" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "Lake Eloisefort", "EE703", 4, "G39012", new DateTime(1961, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy_Schroeder@hotmail.com", "Dorothy", "Schroeder", "840-661-0565" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Unaside", "EE32540", 1, "G286866", new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ross_Schimmel39@gmail.com", "Ross", "Schimmel", "Lithuania", "207.625.1010", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Litzy", "EE9170", 1, "G509792", new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shawna.DuBuque86@gmail.com", "Shawna", "DuBuque", "French Southern Territories", "872.885.4246 x5439", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ryanfort", "EE35956", 1, "G422622", new DateTime(1964, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Reinger76@hotmail.com", "Willie", "Reinger", "Montserrat", "(759) 963-5856", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2301,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Torphychester", "EE38562", 2, "G132976", new DateTime(1959, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Edmond.Connelly@yahoo.com", "Edmond", "Connelly", "Cuba", "1-491-213-1272 x8071", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2302,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Beaulah", "EE4716", 1, "G460584", new DateTime(1980, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Michele.Bauch17@yahoo.com", "Michele", "Bauch", "Holy See (Vatican City State)", "(767) 776-9139 x52600", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2303,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Leopoldland", "EE54996", 2, "G578912", new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Chris.Heaney@gmail.com", "Chris", "Heaney", "Myanmar", "1-922-232-9352" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2304,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Nilsfurt", "EE53606", 4, "G583100", new DateTime(1992, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shelly95@gmail.com", "Shelly", "Sipes", "Moldova", "455-337-2761 x43573", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Yazminstad", "EE43749", "G293648", new DateTime(1992, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dwayne_Kuhic86@hotmail.com", "Dwayne", "Kuhic", "Myanmar", "1-791-392-1826 x96353", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fredaburgh", "EE5052", 3, "G101430", new DateTime(1955, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jane98@gmail.com", "Jane", "Reichert", "Ghana", "(236) 798-7805 x8714" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hagenesborough", "EE53227", "G421039", new DateTime(1998, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Ward87@yahoo.com", "Rolando", "Ward", "Somalia", "368.555.1335" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mayraburgh", "EE39000", 1, "G566115", new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Melba80@hotmail.com", "Melba", "Mayer", "Trinidad and Tobago", "1-374-464-7749 x3987" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2309,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kenny", "EE38704", 2, "G38959", new DateTime(1974, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kayla_Considine4@hotmail.com", "Kayla", "Considine", "Greenland", "749.470.9543" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2310,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Flatleyfurt", "EE16797", 4, "G189069", new DateTime(1962, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Celia_Spencer10@yahoo.com", "Celia", "Spencer", "Lao People's Democratic Republic", "545.781.8705" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2311,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Constantinmouth", "EE44883", 3, "G275208", new DateTime(1971, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jean86@hotmail.com", "Jean", "Yundt", "Germany", "1-942-372-3779 x08469", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2312,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Natasha", "EE49825", 4, "G480334", new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Iris.Kuvalis11@gmail.com", "Iris", "Kuvalis", "Mongolia", "502.863.5207 x488" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2313,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Kenyatta", "EE8898", 3, "G496652", new DateTime(1999, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sergio82@gmail.com", "Sergio", "Kertzmann", "Mongolia", "1-841-647-5083 x531" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2314,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jaleelfort", "EE30147", "G260752", new DateTime(1977, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie_Dibbert@yahoo.com", "Johnnie", "Dibbert", "Iraq", "379-863-1666 x74289" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2315,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Morris", "EE35399", 1, "G426957", new DateTime(1955, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Irvin13@hotmail.com", "Irvin", "Denesik", "Nicaragua", "885-741-2036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2316,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ashlynnborough", "EE28820", "G59627", new DateTime(1965, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hector84@yahoo.com", "Hector", "MacGyver", "South Georgia and the South Sandwich Islands", "1-432-348-1022 x825", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Robertsstad", "EE8556", 1, "G277037", new DateTime(1975, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Corwin22@gmail.com", "Rhonda", "Corwin", "Belgium", "712-417-9239 x95320" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lilyanborough", "EE51561", 3, "G377021", new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jana_Maggio77@gmail.com", "Jana", "Maggio", "Bahamas", "1-602-215-1522 x759", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2319,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fritzfort", "EE48214", 3, "G497626", new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mabel_Paucek98@yahoo.com", "Mabel", "Paucek", "French Polynesia", "(600) 853-3288 x09217" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2320,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nicolasfurt", "EE4573", 1, "G211645", new DateTime(1987, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ora61@hotmail.com", "Ora", "Friesen", "Bangladesh", "648-337-6324", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Lorenza", "EE36355", 4, "G251623", new DateTime(1974, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jean.Windler97@gmail.com", "Jean", "Windler", "Grenada", "(417) 725-4871", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2322,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Cliftonfurt", "EE6544", 2, "G475236", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Christy_Hickle80@hotmail.com", "Christy", "Hickle", "Mali", "878.662.8809 x0957" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2323,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Cornell", "EE20850", 4, "G280098", new DateTime(1958, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kim.Koelpin56@gmail.com", "Kim", "Koelpin", "Barbados", "461-617-6590" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2324,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carsontown", "EE52748", "G51032", new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Parker12@hotmail.com", "Leah", "Parker", "Guadeloupe", "(704) 415-7047", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2325,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Armanistad", "EE51490", 3, "G552751", new DateTime(1977, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Shawn.Stark70@yahoo.com", "Shawn", "Stark", "Kenya", "1-415-385-3907 x555" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Weberville", "EE45249", "G398102", new DateTime(1959, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty65@gmail.com", "Betty", "Harber", "Morocco", "1-451-964-7941 x353", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2327,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Reeceshire", "EE44882", 3, "G169274", new DateTime(1970, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Hazel_Hintz64@yahoo.com", "Hazel", "Hintz", "Isle of Man", "(522) 345-9182" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2328,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kylieport", "EE39361", "G83889", new DateTime(1978, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Doreen_Morar@yahoo.com", "Doreen", "Morar", "Georgia", "781-414-3577", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2329,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kreigerton", "EE35045", 2, "G537955", new DateTime(1966, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Claude.Kuphal@yahoo.com", "Claude", "Kuphal", "Palau", "1-283-434-1092" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2330,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jennifer", "EE15190", 1, "G283154", new DateTime(1999, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Ortiz70@gmail.com", "Alberta", "Ortiz", "Saint Lucia", "321.602.9621", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2331,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Nella", "EE49031", 4, "G25059", new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Lyle_Ryan74@hotmail.com", "Lyle", "Ryan", "Burundi", "1-383-846-8689", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2332,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Emmerichburgh", "EE270", 4, "G500875", new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ernestine_Dickinson97@hotmail.com", "Ernestine", "Dickinson", "Wallis and Futuna", "1-963-946-9965 x195", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2333,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ambershire", "EE52361", 3, "G481239", new DateTime(1958, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ora_Langworth@yahoo.com", "Ora", "Langworth", "Bosnia and Herzegovina", "913-594-1508", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2334,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Rosaliafort", "EE34812", 4, "G357162", new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Derrick47@yahoo.com", "Derrick", "Beatty", "Bolivia", "275-688-5562 x5389" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2335,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Chadd", "EE31890", 4, "G315926", new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Sheri_Kutch92@yahoo.com", "Sheri", "Kutch", "Brunei Darussalam", "(484) 977-8024" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2336,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Prohaskamouth", "EE16614", 1, "G528313", new DateTime(1953, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Danny.Langosh99@gmail.com", "Danny", "Langosh", "Turkmenistan", "743-552-2039" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Shadtown", "EE44293", "G56013", new DateTime(1971, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Amber_Blick@hotmail.com", "Amber", "Blick", "Solomon Islands", "784.806.3547 x2622", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2338,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Micaelafort", "EE6878", 3, "G14812", new DateTime(1967, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Miriam4@hotmail.com", "Miriam", "Borer", "Qatar", "(626) 403-5703" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2339,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Burleyhaven", "EE45973", 1, "G67984", new DateTime(1988, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Ziemann81@yahoo.com", "Elias", "Ziemann", "Armenia", "333.667.2451", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jarredhaven", "EE39215", 2, "G588197", new DateTime(1987, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Toni_Kihn@hotmail.com", "Toni", "Kihn", "Vietnam", "1-569-644-1823 x090" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2341,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Elisaland", "EE15446", 1, "G81366", new DateTime(1973, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Johnston@hotmail.com", "Courtney", "Johnston", "Libyan Arab Jamahiriya", "982.524.3959 x563", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2342,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Mateomouth", "EE25349", "G10186", new DateTime(1980, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rachel_Wilkinson31@gmail.com", "Rachel", "Wilkinson", "Suriname", "(273) 585-8174", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mariannaton", "EE45962", 1, "G331359", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Romaguera@gmail.com", "Elias", "Romaguera", "Egypt", "1-589-913-1399 x37109" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Elodymouth", "EE7939", 1, "G144629", new DateTime(1990, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Donnelly61@hotmail.com", "Courtney", "Donnelly", "Algeria", "318-202-9069 x3767" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hudsonport", "EE32016", 1, "G317223", new DateTime(1965, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elbert_Deckow@hotmail.com", "Elbert", "Deckow", "Sudan", "211-565-8872" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kielland", "EE18718", 4, "G476706", new DateTime(1972, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Beth7@hotmail.com", "Beth", "Effertz", "Portugal", "767-410-7016 x740" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Lucindabury", "EE17383", 2, "G175126", new DateTime(1984, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Curtis.Farrell50@yahoo.com", "Curtis", "Farrell", "Singapore", "(964) 247-9518 x4840", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Gerhardstad", "EE22105", 1, "G18867", new DateTime(1969, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry24@gmail.com", "Kerry", "Schmitt", "Somalia", "774.368.0089 x49560", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2349,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Thompsonhaven", "EE23324", 3, "G408257", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Margaret39@gmail.com", "Margaret", "Greenfelder", "Russian Federation", "(450) 907-0512 x09708", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2350,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Alexzander", "EE872", 4, "G458284", new DateTime(1958, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Al_Roberts@hotmail.com", "Al", "Roberts", "Guam", "372.861.0017 x3263", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2351,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Townemouth", "EE46691", 4, "G336935", new DateTime(1989, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Pedro67@hotmail.com", "Pedro", "Erdman", "Palestinian Territory", "1-881-317-7680 x22931", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2352,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Esta", "EE55929", "G568942", new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Anita64@hotmail.com", "Anita", "Grady", "Democratic People's Republic of Korea", "469-266-4077 x88813" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2353,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Alessandrastad", "EE4082", 2, "G196379", new DateTime(1954, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha_Marvin@yahoo.com", "Tabitha", "Marvin", "Bahrain", "(561) 861-4783 x90890" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2354,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brayanton", "EE52549", 1, "G267959", new DateTime(1973, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Darin.Walsh79@gmail.com", "Darin", "Walsh", "Wallis and Futuna", "652-326-3150" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2355,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Raymondstad", "EE53738", "G587220", new DateTime(1979, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bradford.Morissette@gmail.com", "Bradford", "Morissette", "Kyrgyz Republic", "299-634-5598 x43508", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2356,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kiehnton", "EE13931", 3, "G576628", new DateTime(1998, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Lesch@gmail.com", "Elsa", "Lesch", "Saint Kitts and Nevis", "697-354-3951 x3766" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2357,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Reese", "EE20450", 1, "G231600", new DateTime(1974, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Frank10@hotmail.com", "Frank", "Fisher", "Liechtenstein", "257-308-4127", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Andersonchester", "EE51533", 1, "G397000", new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Hane72@hotmail.com", "Fred", "Hane", "Moldova", "(349) 396-9009" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2359,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Daishamouth", "EE30463", 2, "G483447", new DateTime(1997, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Alma.Harber@yahoo.com", "Alma", "Harber", "Poland", "833.961.2197 x0563" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2360,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Louveniaside", "EE30199", 3, "G134776", new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Verna80@gmail.com", "Verna", "Koss", "Micronesia", "1-937-354-2490 x40004" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2361,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hahnside", "EE37342", 3, "G325548", new DateTime(1973, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edgar_Mueller@yahoo.com", "Edgar", "Mueller", "Heard Island and McDonald Islands", "254-209-8308 x66294" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2362,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Devanberg", "EE36940", 3, "G476264", new DateTime(1953, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Janie_Monahan@gmail.com", "Janie", "Monahan", "United Kingdom", "322.921.9854 x940" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Jovannyville", "EE16929", 2, "G166809", new DateTime(1972, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kristen84@yahoo.com", "Kristen", "Volkman", "Gibraltar", "1-221-981-9266 x595", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Austynberg", "EE55030", "G188719", new DateTime(1972, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto_Parker@yahoo.com", "Gilberto", "Parker", "Cambodia", "1-573-778-8959 x98125" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Feestside", "EE2572", 4, "G276345", new DateTime(1963, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Borer@yahoo.com", "Jenny", "Borer", "Palau", "616-339-4646 x11243", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Christianamouth", "EE55502", "G554195", new DateTime(1981, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frankie_Veum@gmail.com", "Frankie", "Veum", "Luxembourg", "319.479.1828 x6598" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Sven", "EE3546", "G348841", new DateTime(1960, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Eva.Hayes86@hotmail.com", "Eva", "Hayes", "Hungary", "290-612-9963", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Desiree", "EE5534", "G433391", new DateTime(1959, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney37@yahoo.com", "Courtney", "Vandervort", "Andorra", "(986) 254-5859" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wolfhaven", "EE15152", "G255530", new DateTime(1957, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lee91@yahoo.com", "Lee", "Kuphal", "Solomon Islands", "297-960-8167 x02958" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cheyanneborough", "EE18856", "G564555", new DateTime(1977, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jon.Strosin9@gmail.com", "Jon", "Strosin", "Latvia", "1-704-282-6544", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jacintheton", "EE41230", 3, "G503976", new DateTime(1977, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ruben.Huels@gmail.com", "Ruben", "Huels", "Isle of Man", "844-934-5042" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2372,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Cyrilville", "EE57297", 1, "G498264", new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Audrey_Jerde@gmail.com", "Audrey", "Jerde", "Mauritania", "1-474-787-1943 x98696", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2373,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pfefferfort", "EE50982", 4, "G107164", new DateTime(1959, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kenneth.Bayer11@gmail.com", "Kenneth", "Bayer", "Nepal", "1-857-936-6039 x99292", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldnermouth", "EE55867", "G47874", new DateTime(1992, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Willard79@yahoo.com", "Willard", "McKenzie", "Kiribati", "(475) 574-0018 x975", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Domenicofurt", "EE271", 1, "G279101", new DateTime(1964, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Diane.Kunde29@gmail.com", "Diane", "Kunde", "Malta", "(800) 457-4251", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2376,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Bo", "EE9377", 3, "G313728", new DateTime(1960, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Cody_Lynch@hotmail.com", "Cody", "Lynch", "Malawi", "(981) 989-1337", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2377,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Melbaville", "EE15572", 2, "G380206", new DateTime(1960, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Irma.Rice@gmail.com", "Irma", "Rice", "Isle of Man", "(274) 714-1550 x757", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2378,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Micaela", "EE25092", 2, "G145448", new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Victoria_Labadie95@yahoo.com", "Victoria", "Labadie", "Indonesia", "958-872-3228 x5727", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2379,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Amelie", "EE11403", "G582672", new DateTime(1965, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Colin_Fahey@gmail.com", "Colin", "Fahey", "Madagascar", "1-415-859-4754 x191" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Kristinshire", "EE19625", "G468739", new DateTime(1998, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brenda_Stroman69@yahoo.com", "Brenda", "Stroman", "Palau", "1-787-691-1879 x3361", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2381,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Delores", "EE27980", 3, "G569045", new DateTime(1963, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kate78@gmail.com", "Kate", "Yundt", "Zambia", "323.283.8110 x8785", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2382,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ezequielhaven", "EE5560", 1, "G537219", new DateTime(1957, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Amy_Jones15@hotmail.com", "Amy", "Jones", "Montenegro", "1-334-663-4144 x6379" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Huelfort", "EE19873", 3, "G137590", new DateTime(1987, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ramon82@hotmail.com", "Ramon", "Gerlach", "Switzerland", "1-317-996-0061" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Ethelyn", "EE56727", "G511521", new DateTime(1957, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Paucek32@gmail.com", "Marcus", "Paucek", "Nepal", "(326) 732-8410", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Suzanneburgh", "EE5505", 3, "G473640", new DateTime(1952, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Maryann86@yahoo.com", "Maryann", "Hegmann", "Portugal", "545.995.6704 x8777" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Cathrynside", "EE27399", "G260944", new DateTime(1966, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Willie_Champlin@hotmail.com", "Willie", "Champlin", "Guadeloupe", "(776) 379-9293" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Jadeburgh", "EE10449", 1, "G78291", new DateTime(1988, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mildred58@hotmail.com", "Mildred", "Hoeger", "Central African Republic", "(216) 882-6894", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Collinschester", "EE51262", "G9814", new DateTime(1985, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Torp90@gmail.com", "Kerry", "Torp", "Slovenia", "308.786.0400 x262", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2389,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Holliemouth", "EE11597", 2, "G447450", new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jay.Swaniawski@yahoo.com", "Jay", "Swaniawski", "Fiji", "630-806-0900 x13042", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2390,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ronaldofurt", "EE8435", "G96883", new DateTime(1954, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Edmond_Macejkovic65@hotmail.com", "Edmond", "Macejkovic", "Lao People's Democratic Republic", "(325) 251-2200 x12906" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2391,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Ludwigtown", "EE54452", 1, "G479521", new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Gottlieb@yahoo.com", "Leona", "Gottlieb", "Djibouti", "(545) 210-1318 x57985", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2392,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Aureliaville", "EE18116", "G557778", new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jon48@yahoo.com", "Jon", "Treutel", "Sudan", "1-287-662-4946 x5659", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bartside", "EE54829", 3, "G440007", new DateTime(1982, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lance.Runolfsdottir@yahoo.com", "Lance", "Runolfsdottir", "Cayman Islands", "666.517.0148", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2394,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Joel", "EE27798", 3, "G459785", new DateTime(1956, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Clifton18@hotmail.com", "Clifton", "D'Amore", "Jersey", "1-372-666-0146 x1552", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2395,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Saul", "EE31837", 1, "G541485", new DateTime(1984, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sonya.Weimann@yahoo.com", "Sonya", "Weimann", "Gibraltar", "887.647.6908 x338" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2396,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Domenic", "EE26496", 1, "G455089", new DateTime(1978, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Jennifer.Heathcote@gmail.com", "Jennifer", "Heathcote", "Bahrain", "418.933.2982 x5174", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2397,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Kyler", "EE12674", 4, "G511904", new DateTime(1961, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Tasha.Beatty@yahoo.com", "Tasha", "Beatty", "Somalia", "1-419-298-5168 x71775", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cronaville", "EE5844", "G357632", new DateTime(1982, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ismael.Stokes@hotmail.com", "Ismael", "Stokes", "Isle of Man", "1-860-801-3077 x88107", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rafaelstad", "EE9455", 4, "G193427", new DateTime(1964, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ethel_Thompson84@gmail.com", "Ethel", "Thompson", "Barbados", "212.565.0176", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Soniamouth", "EE3962", 3, "G238609", new DateTime(1953, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Della21@gmail.com", "Della", "Crona", "Georgia", "549.296.8583", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Patriciaview", "EE13168", 3, "G414444", new DateTime(1994, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Leon0@gmail.com", "Leon", "Langworth", "British Indian Ocean Territory (Chagos Archipelago)", "1-735-741-1821 x099", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Berylmouth", "EE883", 4, "G243841", new DateTime(1994, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Salvatore76@yahoo.com", "Salvatore", "Bogan", "Germany", "966-522-6221" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2403,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Macborough", "EE11033", 2, "G10392", new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Harvey_Okuneva@yahoo.com", "Harvey", "Okuneva", "Iran", "865.294.5612", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2404,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Caleview", "EE52571", 3, "G568127", new DateTime(1953, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Harriet7@yahoo.com", "Harriet", "Gleason", "Mexico", "245.723.2392 x249" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Khalidton", "EE18900", 4, "G364491", new DateTime(1980, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jeremiah.Jacobs@yahoo.com", "Jeremiah", "Jacobs", "Mauritania", "1-505-455-0686 x46905" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Millie", "EE8617", "G250523", new DateTime(1960, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Evan59@yahoo.com", "Evan", "Raynor", "New Zealand", "788.648.1737 x092", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2407,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Jazminchester", "EE45534", 2, "G70714", new DateTime(1965, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Moen34@yahoo.com", "Rufus", "Moen", "Botswana", "1-520-638-9914 x105", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2408,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pollichtown", "EE942", 3, "G236075", new DateTime(1968, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Orlando.MacGyver@hotmail.com", "Orlando", "MacGyver", "Kazakhstan", "965-740-3383 x18972", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Alfordfort", "EE45107", 3, "G188712", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Ratke28@yahoo.com", "Lucille", "Ratke", "Virgin Islands, British", "799.654.0381 x725", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2410,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hettingerburgh", "EE51613", 2, "G121614", new DateTime(1957, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Amy7@hotmail.com", "Amy", "Mann", "Pakistan", "(547) 683-9502 x7980", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2411,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Godfreybury", "EE15664", 2, "G176235", new DateTime(1989, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dewey82@yahoo.com", "Dewey", "Greenholt", "Poland", "890.256.8337" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dwight", "EE31278", 1, "G385937", new DateTime(1988, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Natalie0@gmail.com", "Natalie", "Feest", "Niger", "765.830.4163" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2413,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Prosaccotown", "EE53617", 3, "G24611", new DateTime(1962, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kristin80@gmail.com", "Kristin", "Runolfsdottir", "Argentina", "1-395-529-0349 x79677" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2414,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Madonna", "EE49968", 2, "G280385", new DateTime(1956, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tami.OKeefe@gmail.com", "Tami", "O'Keefe", "Canada", "(970) 498-2931" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Vidahaven", "EE41607", 2, "G502762", new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Garry66@hotmail.com", "Garry", "Stiedemann", "Hungary", "458.453.7485 x404" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Jerrold", "EE11717", 4, "G468850", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Morar64@yahoo.com", "Velma", "Morar", "Norway", "279.885.9690", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roelfurt", "EE40774", 4, "G82680", new DateTime(1954, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Felicia_Little37@gmail.com", "Felicia", "Little", "Sao Tome and Principe", "(332) 769-3950 x638" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Elishaview", "EE32636", "G432350", new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tommie.Spinka@gmail.com", "Tommie", "Spinka", "Belgium", "496-756-6713" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Odellside", "EE33833", 3, "G348429", new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kenny.Wiza91@hotmail.com", "Kenny", "Wiza", "Namibia", "1-409-386-7877" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Santiago", "EE23781", 2, "G116867", new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Koepp@gmail.com", "Julio", "Koepp", "Belgium", "817.569.5218 x5054" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gregghaven", "EE56635", 1, "G241066", new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Maureen27@gmail.com", "Maureen", "Howe", "French Guiana", "682.566.5025" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Daren", "EE42363", 2, "G89131", new DateTime(1972, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Laurie_Lemke20@hotmail.com", "Laurie", "Lemke", "Ukraine", "(660) 992-3784 x259", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lucindafurt", "EE8954", 1, "G598333", new DateTime(1951, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Becky.Zemlak89@gmail.com", "Becky", "Zemlak", "Faroe Islands", "1-963-895-4340", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2424,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zoiechester", "EE10668", "G505265", new DateTime(1996, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Abraham_Weissnat49@gmail.com", "Abraham", "Weissnat", "Australia", "465-235-2353", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2425,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Tyson", "EE54132", 4, "G560773", new DateTime(1960, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Erdman@gmail.com", "Dianna", "Erdman", "Slovenia", "1-327-541-2770 x659", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2426,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Imani", "EE45593", "G56794", new DateTime(1986, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ray39@hotmail.com", "Ray", "Oberbrunner", "Guernsey", "1-780-508-8196" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2427,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Stantonland", "EE2830", 2, "G88500", new DateTime(1973, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Phillip.Price@hotmail.com", "Phillip", "Price", "Slovakia (Slovak Republic)", "1-463-596-6541", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2428,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hackettport", "EE49410", "G404753", new DateTime(1994, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cesar_Berge84@yahoo.com", "Cesar", "Berge", "Brunei Darussalam", "(724) 416-3472" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Angelineville", "EE18929", 2, "G390992", new DateTime(1973, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Fannie_Brakus93@hotmail.com", "Fannie", "Brakus", "Haiti", "245.290.7633 x4001", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Susannaburgh", "EE22125", "G292662", new DateTime(1972, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ashley.Hammes@hotmail.com", "Ashley", "Hammes", "Austria", "509.593.4812 x3469", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2431,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Willland", "EE26033", 3, "G139039", new DateTime(1979, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Graham23@hotmail.com", "Shane", "Graham", "Seychelles", "(313) 611-9835 x20807", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2432,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rebastad", "EE49560", 1, "G47990", new DateTime(1975, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha.Ondricka@yahoo.com", "Tabitha", "Ondricka", "Czech Republic", "338.229.0822 x6790", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Matildestad", "EE12082", 1, "G395155", new DateTime(1960, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jane.Padberg@gmail.com", "Jane", "Padberg", "Malawi", "(881) 539-4733 x6210" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nat", "EE1290", 1, "G303999", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred67@hotmail.com", "Wilfred", "Zulauf", "Angola", "1-548-569-6845 x035", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Pamela", "EE4167", 2, "G514806", new DateTime(1966, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lowell88@gmail.com", "Lowell", "Ziemann", "Malawi", "(980) 864-1502 x02884" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2436,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Emerson", "EE49980", 1, "G216647", new DateTime(1982, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Terrence.Steuber28@hotmail.com", "Terrence", "Steuber", "Grenada", "1-954-323-0030", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2437,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Christa", "EE2222", 3, "G316244", new DateTime(1959, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Leffler@yahoo.com", "Sabrina", "Leffler", "Mauritius", "(725) 371-2681" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2438,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lambert", "EE55801", 1, "G585606", new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kathy.Gerlach@hotmail.com", "Kathy", "Gerlach", "Uganda", "637.213.0909 x05794", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2439,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Venabury", "EE36031", "G178988", new DateTime(1951, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cathy_Lubowitz59@hotmail.com", "Cathy", "Lubowitz", "Tajikistan", "695.516.4360 x2097" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutkowskiport", "EE19626", "G356888", new DateTime(1974, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Mark_Considine86@gmail.com", "Mark", "Considine", "Saudi Arabia", "(815) 771-3417" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carterfort", "EE53860", "G80784", new DateTime(1992, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Mario85@hotmail.com", "Mario", "Von", "Belize", "1-359-225-5911 x869", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ulisesmouth", "EE16974", 4, "G212502", new DateTime(1965, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Clara_Anderson@yahoo.com", "Clara", "Anderson", "Niger", "(774) 555-7268 x317", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2443,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Rahulville", "EE23038", 3, "G335583", new DateTime(1958, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jodi67@hotmail.com", "Jodi", "O'Kon", "Northern Mariana Islands", "(966) 876-2306" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2444,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Stefan", "EE32113", "G413086", new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Charlotte.Bergnaum68@yahoo.com", "Charlotte", "Bergnaum", "Mali", "414.888.6987" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nitzscheland", "EE50407", 4, "G400641", new DateTime(1978, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Frankie.Satterfield5@hotmail.com", "Frankie", "Satterfield", "Guinea-Bissau", "775.714.5718 x1941" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2446,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Brionnaside", "EE36004", 2, "G509511", new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Marie.Dooley60@yahoo.com", "Marie", "Dooley", "Christmas Island", "1-211-867-6344 x98141", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2447,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Laurynstad", "EE50475", 4, "G457358", new DateTime(1974, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Goldner@gmail.com", "Julio", "Goldner", "Antarctica (the territory South of 60 deg S)", "724-922-9198 x178", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2448,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Orlandstad", "EE26272", 1, "G215997", new DateTime(1972, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dominick.Harber1@hotmail.com", "Dominick", "Harber", "Isle of Man", "390-367-4120" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2449,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Florianmouth", "EE11202", 1, "G583487", new DateTime(1953, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edna8@gmail.com", "Edna", "Ritchie", "Denmark", "1-624-920-0990 x489" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mckaylamouth", "EE48807", 4, "G261507", new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mack_Funk@hotmail.com", "Mack", "Funk", "Lebanon", "1-307-634-4215", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "McCluretown", "EE39710", 4, "G270899", new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Rick_Maggio88@hotmail.com", "Rick", "Maggio", "Qatar", "698.230.2810 x98412" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2452,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bartellville", "EE35110", 1, "G517727", new DateTime(1993, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Grant.Ward@hotmail.com", "Grant", "Ward", "Guinea-Bissau", "(870) 339-9098" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2453,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jettview", "EE16739", "G197552", new DateTime(1970, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jake20@gmail.com", "Jake", "Gaylord", "Democratic People's Republic of Korea", "(423) 779-9642 x92633", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Clementine", "EE38186", 2, "G186933", new DateTime(1984, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew.Carter76@gmail.com", "Andrew", "Carter", "Lesotho", "513-977-7128", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ludie", "EE3576", 3, "G379823", new DateTime(1956, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Runte@hotmail.com", "Rufus", "Runte", "Sao Tome and Principe", "1-685-771-7062" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2456,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jodyfurt", "EE46007", 3, "G193916", new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Josefina96@hotmail.com", "Josefina", "Crooks", "Tokelau", "770.302.7287", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2457,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tessview", "EE34120", 2, "G391706", new DateTime(1956, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Faye.DAmore20@gmail.com", "Faye", "D'Amore", "British Indian Ocean Territory (Chagos Archipelago)", "581.991.3296" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2458,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fayfort", "EE11839", 1, "G378473", new DateTime(1967, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Loren86@yahoo.com", "Loren", "Klein", "Guam", "935.677.1065 x3379", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Garrick", "EE41940", 3, "G237916", new DateTime(1991, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Sauer90@hotmail.com", "Jenny", "Sauer", "Trinidad and Tobago", "1-533-734-3484", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2460,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Sterlingside", "EE30048", 1, "G100995", new DateTime(1957, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Edmund_Ratke@gmail.com", "Edmund", "Ratke", "Bolivia", "(439) 275-5566 x6551" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2461,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Keelingmouth", "EE52643", 4, "G38621", new DateTime(1977, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Alfonso_Mosciski@hotmail.com", "Alfonso", "Mosciski", "Palau", "1-213-683-5656", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2462,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dickinsonfurt", "EE31653", 3, "G551609", new DateTime(1957, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jake_Wisozk@gmail.com", "Jake", "Wisozk", "China", "1-968-644-4084", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Swiftside", "EE24963", 2, "G160561", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Greg_Keebler@gmail.com", "Greg", "Keebler", "Sierra Leone", "1-565-407-8932 x7086", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Euna", "EE9957", 4, "G199324", new DateTime(1955, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Camille41@hotmail.com", "Camille", "Waelchi", "Georgia", "980.901.1330 x35581" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Chaimstad", "EE39858", 3, "G532853", new DateTime(1978, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Blanca_Gorczany48@gmail.com", "Blanca", "Gorczany", "Uzbekistan", "(334) 816-3401 x939", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cassinstad", "EE54830", "G334762", new DateTime(1973, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rita3@hotmail.com", "Rita", "Kuvalis", "Uganda", "1-388-524-8339 x8662" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Elwinport", "EE25717", "G160201", new DateTime(1984, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Conroy83@yahoo.com", "Jacqueline", "Conroy", "Slovenia", "460-285-2400 x91505" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rebekah", "EE37423", "G222619", new DateTime(1989, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cameron.Becker57@hotmail.com", "Cameron", "Becker", "Saint Martin", "1-669-520-6342", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2469,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Devin", "EE49044", 3, "G536119", new DateTime(1956, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Aaron_Bauch44@hotmail.com", "Aaron", "Bauch", "Ireland", "363.707.2177 x24089", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2470,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Amos", "EE26409", 3, "G574621", new DateTime(1999, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Roman_Collins91@yahoo.com", "Roman", "Collins", "Namibia", "326.739.0768 x2114" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2471,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Ruben", "EE2560", 3, "G426078", new DateTime(1957, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sharon_Jast@hotmail.com", "Sharon", "Jast", "Moldova", "286-498-8515 x22953", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2472,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Francofort", "EE35107", 4, "G225181", new DateTime(1978, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Silvia.Larkin7@hotmail.com", "Silvia", "Larkin", "Nepal", "456-963-0949", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2473,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Fidelfort", "EE13641", 2, "G391559", new DateTime(1959, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Walter_Johns@hotmail.com", "Walter", "Johns", "Liechtenstein", "899-491-7638 x7421", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2474,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Lottieside", "EE33442", "G594964", new DateTime(1959, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Veronica59@gmail.com", "Veronica", "O'Kon", "Tonga", "1-353-372-9639 x4225", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2475,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Darenmouth", "EE21356", 4, "G31710", new DateTime(1987, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Desiree_Mante@gmail.com", "Desiree", "Mante", "Saint Kitts and Nevis", "279.353.1197 x8418" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2476,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jimmyville", "EE3799", "G184196", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Zboncak39@yahoo.com", "Jackie", "Zboncak", "Kenya", "(546) 542-6383 x344" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2477,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Haagton", "EE40346", 3, "G190036", new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Amy.Rolfson@gmail.com", "Amy", "Rolfson", "Djibouti", "(308) 820-8656 x44108" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2478,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Chesterborough", "EE7318", 4, "G498375", new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Martha.Block@gmail.com", "Martha", "Block", "French Southern Territories", "948.449.4037", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2479,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fayeport", "EE36837", 1, "G579190", new DateTime(1969, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Schowalter@hotmail.com", "Johnnie", "Schowalter", "Western Sahara", "299-520-2950 x007", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2480,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ellie", "EE59277", "G120985", new DateTime(1955, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Cynthia_Fisher72@gmail.com", "Cynthia", "Fisher", "Solomon Islands", "215.992.9337 x611", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Esmeralda", "EE56853", 3, "G430277", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sheila_Johnston@hotmail.com", "Sheila", "Johnston", "Qatar", "972-410-4367 x8462" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2482,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Conorborough", "EE55961", 1, "G338851", new DateTime(1968, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Holly3@hotmail.com", "Holly", "Corkery", "Croatia", "442.402.9732 x563" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2483,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jonasfurt", "EE58547", 2, "G215308", new DateTime(1989, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Pamela.Watsica@yahoo.com", "Pamela", "Watsica", "China", "810-613-3467 x6238" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2484,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beiershire", "EE35326", "G487631", new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Angelica88@hotmail.com", "Angelica", "Koch", "Pitcairn Islands", "1-211-958-7010 x7784" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2485,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Barrett", "EE20508", 4, "G537980", new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Brendan.Sawayn15@gmail.com", "Brendan", "Sawayn", "New Caledonia", "711-479-9136 x5533", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2486,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Leanna", "EE49649", 1, "G306104", new DateTime(1963, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jerome_DuBuque41@yahoo.com", "Jerome", "DuBuque", "Netherlands", "701.955.4739", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2487,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Monahanfort", "EE46356", "G177566", new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cristina.Daugherty15@hotmail.com", "Cristina", "Daugherty", "Republic of Korea", "501-410-3124" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2488,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hesselview", "EE26670", 1, "G257403", new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Feest0@gmail.com", "Willie", "Feest", "Greece", "351.399.4931 x78414", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2489,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Guillermo", "EE25061", 4, "G225121", new DateTime(1967, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jody.White2@yahoo.com", "Jody", "White", "Northern Mariana Islands", "988-866-1544 x195", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2490,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hillsmouth", "EE54786", "G288350", new DateTime(1983, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leon17@gmail.com", "Leon", "Wisozk", "Lebanon", "1-255-532-0910 x899" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2491,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gleichnerburgh", "EE55782", 2, "G99138", new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nadine_Aufderhar@gmail.com", "Nadine", "Aufderhar", "Latvia", "1-964-423-0546", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2492,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Sarinaside", "EE5305", 2, "G355087", new DateTime(1963, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sarah69@gmail.com", "Sarah", "Herzog", "Burundi", "1-754-841-8452 x2642", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2493,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lisandromouth", "EE52883", 1, "G271266", new DateTime(1989, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Monique_Langworth93@gmail.com", "Monique", "Langworth", "Kiribati", "936-855-9689" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2494,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "Port Ambrosechester", "EE59607", 2, "G445073", new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Hane70@gmail.com", "Courtney", "Hane", "1-825-976-8812 x91858", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Heavenfort", "EE24835", 2, "G420078", new DateTime(1984, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Curtis55@hotmail.com", "Curtis", "Gorczany", "Rwanda", "(580) 652-9472 x19913" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Aracelychester", "EE40472", 1, "G476260", new DateTime(1959, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Keeling55@yahoo.com", "Marlene", "Keeling", "Djibouti", "847-784-9236" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Harriston", "EE16338", 4, "G396820", new DateTime(1960, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Donald63@gmail.com", "Donald", "Lakin", "Moldova", "1-310-875-3719 x23940", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pfefferhaven", "EE11372", 2, "G249735", new DateTime(1978, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jodi43@yahoo.com", "Jodi", "Cormier", "Tunisia", "1-747-820-3725 x187" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2499,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Klingberg", "EE3734", 3, "G230520", new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Predovic@gmail.com", "Leah", "Predovic", "Faroe Islands", "(941) 244-9316", "Female" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Tools, Home & Toys streamline mint green", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Cambridgeshire killer Investment Account", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Facilitator New Hampshire users", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Savings Account Colorado zero administration", 20 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "collaborative Regional Incredible Concrete Fish", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "compress Canadian Dollar Handmade", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "B2C Grove Home & Sports", 11 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Money Market Account online Metal", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Cambridgeshire calculate Stravenue", 14 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Supervisor indexing Soft", 13 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 1, "Investment Account green Markets" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "SQL Soft Gorgeous Wooden Chair", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "multi-tasking Quality Philippine Peso", 20 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Dominican Republic Sports, Jewelery & Jewelery Synergistic", 17 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Handmade Steel Pizza Rhode Island cross-platform", 19 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "CFA Franc BCEAO navigating Pataca", 21 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 1, "Data Indiana cutting-edge" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Group clicks-and-mortar District", 12 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Electronics, Sports & Tools Regional Program", 9 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "circuit Burkina Faso well-modulated", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "programming navigate Versatile", 8 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Regional array info-mediaries", 8 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Incredible Frozen Ball Practical Rubber Bike Toys", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "analyzer Incredible Granite Soap Forge", 8 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 2, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 15, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 13, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 24, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 10 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 9, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 7 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 8, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 20, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 24, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 1, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 16, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 17, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 11, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 21, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 24, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 5, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 13, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 21, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 15, "0" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Diana_Lynch@gmail.com", "synthesizing", "Lynch", "Diana" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Charlotte_Anderson86@hotmail.com", "Clothing & Music", "Anderson", "Charlotte" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Marcia.Spinka64@gmail.com", "Maine", "Spinka", "Marcia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Shelia_Ziemann@gmail.com", "Division", "Ziemann", "Shelia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Irving_Corkery81@hotmail.com", "mission-critical", "Corkery", "Irving" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Sandy.Legros55@hotmail.com", "Mountains", "Legros", "Sandy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Camille_Grant@yahoo.com", "sky blue", "Grant", "Camille" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Joan80@gmail.com", "Fantastic Granite Bike", "Reilly", "Joan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Kenneth_Reichert54@gmail.com", "index", "Reichert", "Kenneth" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Muriel5@yahoo.com", "European Unit of Account 17(E.U.A.-17)", "Wehner", "Muriel" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Adam91@yahoo.com", "solutions", "Christiansen", "Adam" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "May_Emard88@gmail.com", "Inverse", "Emard", "May" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jamie98@hotmail.com", "Technician", "Bernhard", "Jamie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Josh18@gmail.com", "override", "Zieme", "Josh" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jan98@gmail.com", "Small Frozen Shirt", "Abshire", "Jan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Lindsey.Carroll80@hotmail.com", "Kroon", "Carroll", "Lindsey" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Darrel_Cremin42@gmail.com", "emulation", "Cremin", "Darrel" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ernest.Sipes85@yahoo.com", "Human", "Sipes", "Ernest" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Bennie_Steuber47@gmail.com", "Uzbekistan Sum", "Steuber", "Bennie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Edwin.Carter@hotmail.com", "Iran", "Carter", "Edwin" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Dexter.Trantow20@hotmail.com", "sky blue", "Trantow", "Dexter" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Leslie_Feeney18@hotmail.com", "metrics", "Feeney", "Leslie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Fannie.Bartoletti@yahoo.com", "full-range", "Bartoletti", "Fannie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Charles.Abernathy86@gmail.com", "Intelligent", "Abernathy", "Charles" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Sophie_Keeling2@hotmail.com", "Congolese Franc", "Keeling", "Sophie" });

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 1,
                column: "filiereId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 2,
                column: "filiereId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 3,
                column: "filiereId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 4,
                column: "filiereId",
                value: 1);
        }
    }
}
