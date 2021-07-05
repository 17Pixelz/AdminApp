using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Professeurs_professeurId",
                table: "Modules");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 5, 13, 46, 6, 143, DateTimeKind.Local).AddTicks(7640), 2295, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 5, 13, 46, 6, 144, DateTimeKind.Local).AddTicks(5277), 2462 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 5, 13, 46, 6, 144, DateTimeKind.Local).AddTicks(5377), 2116 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 5, 13, 46, 6, 144, DateTimeKind.Local).AddTicks(5401), 2256 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 5, 13, 46, 6, 144, DateTimeKind.Local).AddTicks(5422), 2026, "Attestation de scolarite" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Felix", "EE49415", 4, "G67290", new DateTime(1961, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Julian.Hammes52@yahoo.com", "Julian", "Hammes", "Romania", "1-992-893-5124 x3478" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Emmerichshire", "EE58798", "G503261", new DateTime(1961, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lonnie15@hotmail.com", "Lonnie", "Morar", "Lesotho", "1-332-711-6398 x291" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kihnview", "EE54605", "G114322", new DateTime(1959, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Matt.Keebler64@gmail.com", "Matt", "Keebler", "Dominica", "(515) 498-9534 x612", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Marcellus", "EE19135", 2, "G367007", new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Doug89@gmail.com", "Doug", "Rippin", "Estonia", "(882) 218-6826" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Morissetteport", "EE36304", 4, "G15761", new DateTime(1992, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Dan_Nitzsche@yahoo.com", "Dan", "Nitzsche", "Benin", "440-346-7150" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Douglaschester", "EE41985", 2, "G91413", new DateTime(1993, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Muriel.Friesen15@gmail.com", "Muriel", "Friesen", "Zimbabwe", "767-250-8803 x41662", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bahringerstad", "EE21005", "G308352", new DateTime(1957, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Esther52@hotmail.com", "Esther", "Kirlin", "Haiti", "1-402-243-0509", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Eldorahaven", "EE36692", 2, "G184788", new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Dallas_Schoen@yahoo.com", "Dallas", "Schoen", "Marshall Islands", "(950) 367-6910", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Cleveland", "EE16510", "G3952", new DateTime(1988, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Toby_OConner47@yahoo.com", "Toby", "O'Conner", "Japan", "420.331.9063", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hellerbury", "EE3281", 1, "G443534", new DateTime(1994, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell_Yost9@hotmail.com", "Mitchell", "Yost", "Paraguay", "604-777-0559", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2010,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dennis", "EE9488", "G445397", new DateTime(1969, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Lonnie_Hills42@yahoo.com", "Lonnie", "Hills", "Slovenia", "1-582-377-6280 x378" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Estrellaside", "EE30647", 1, "G171381", new DateTime(1954, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Benny25@hotmail.com", "Benny", "White", "Dominican Republic", "627-505-7669 x0450", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Krisbury", "EE59942", "G12557", new DateTime(1956, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kyle55@yahoo.com", "Kyle", "Senger", "Bulgaria", "(280) 575-8770 x44074", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Juwanborough", "EE56498", 1, "G500108", new DateTime(1977, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Frankie.Lowe@hotmail.com", "Frankie", "Lowe", "Saint Lucia", "896.645.4607 x36122" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Langoshmouth", "EE25575", "G436303", new DateTime(1980, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Paula.Deckow@gmail.com", "Paula", "Deckow", "Northern Mariana Islands", "1-364-491-4107" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wittingshire", "EE26608", "G547162", new DateTime(1977, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pat_Hintz@hotmail.com", "Pat", "Hintz", "Guyana", "1-323-382-4159 x2398", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Darefurt", "EE6726", 3, "G188384", new DateTime(1968, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Patti_OKon60@gmail.com", "Patti", "O'Kon", "Bolivia", "(223) 439-5222 x24556" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2017,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Reymundo", "EE44286", 2, "G228152", new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Andres57@yahoo.com", "Andres", "Heaney", "Syrian Arab Republic", "1-751-409-2488 x54921", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2018,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Odaview", "EE24314", 2, "G429484", new DateTime(1957, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jane.Rutherford6@yahoo.com", "Jane", "Rutherford", "Micronesia", "(319) 554-8196 x4737" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Mariamhaven", "EE33685", 2, "G427878", new DateTime(1956, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rachel21@yahoo.com", "Rachel", "Durgan", "Nauru", "656.269.7921 x101" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Corbinshire", "EE39281", 4, "G157201", new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Rachael13@yahoo.com", "Rachael", "Hermann", "Canada", "575-857-4951 x0175" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Trevastad", "EE24096", 1, "G181007", new DateTime(1976, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Karl52@hotmail.com", "Karl", "Pfeffer", "Ukraine", "716-989-2337", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Eleonore", "EE1983", 4, "G459910", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Tami45@hotmail.com", "Tami", "Schowalter", "Norfolk Island", "(570) 337-7367", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Drakeside", "EE111", 4, "G116409", new DateTime(1986, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Cesar67@hotmail.com", "Cesar", "Blick", "Colombia", "616.399.1679" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Fern", "EE59535", 2, "G500516", new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Elsie70@hotmail.com", "Elsie", "Rutherford", "Hong Kong", "(954) 997-1681", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Mercedesfort", "EE53279", 1, "G97165", new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenny_Crist@gmail.com", "Jenny", "Crist", "Lao People's Democratic Republic", "(697) 409-6506" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Davisville", "EE1456", 3, "G317573", new DateTime(1988, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto_Gorczany35@hotmail.com", "Gilberto", "Gorczany", "Holy See (Vatican City State)", "(440) 884-4735" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2027,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alaynaview", "EE20831", 2, "G44957", new DateTime(1993, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Krystal.Hagenes46@gmail.com", "Krystal", "Hagenes", "Zimbabwe", "598.835.0656 x34044" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2028,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Xanderview", "EE48847", 3, "G518075", new DateTime(1953, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Oliver_Haley@gmail.com", "Oliver", "Haley", "New Zealand", "916-388-6174", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2029,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Easter", "EE37339", 1, "G35080", new DateTime(1974, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Cornelius.Kuhlman30@gmail.com", "Cornelius", "Kuhlman", "Timor-Leste", "1-886-667-1575" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2030,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Ressie", "EE15455", 3, "G117453", new DateTime(1967, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sean.Lind@yahoo.com", "Sean", "Lind", "Bosnia and Herzegovina", "(293) 671-6790 x78112", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2031,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Constancemouth", "EE20642", 4, "G323038", new DateTime(1976, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Darrel21@yahoo.com", "Darrel", "Beer", "Svalbard & Jan Mayen Islands", "764-209-2937 x30715" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Isobelberg", "EE27241", "G442003", new DateTime(1991, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "David_Stroman28@gmail.com", "David", "Stroman", "Mongolia", "(420) 652-7074 x46163", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2033,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Eudora", "EE42821", "G484657", new DateTime(1991, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ellis_Mertz12@gmail.com", "Ellis", "Mertz", "Qatar", "660.249.9209 x8536" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2034,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schoenborough", "EE32467", 3, "G517165", new DateTime(1970, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Andy91@yahoo.com", "Andy", "Gutkowski", "Jamaica", "(700) 758-4005 x69106" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2035,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bayleeshire", "EE45172", 1, "G540691", new DateTime(1961, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Roosevelt.Legros49@gmail.com", "Roosevelt", "Legros", "Australia", "983.772.8447 x28695" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Antwantown", "EE18237", 3, "G484319", new DateTime(1964, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Marion47@yahoo.com", "Marion", "Frami", "Colombia", "1-454-915-8980 x6306", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Lance", "EE59848", 1, "G225150", new DateTime(1978, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Heather68@hotmail.com", "Heather", "Nolan", "Indonesia", "262.877.8258" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Gordon", "EE19353", 1, "G152932", new DateTime(1982, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sheila.Skiles18@gmail.com", "Sheila", "Skiles", "Saint Vincent and the Grenadines", "(468) 832-9430" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Kraig", "EE53992", 4, "G153471", new DateTime(1952, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Freda22@gmail.com", "Freda", "Reichert", "Pitcairn Islands", "817-985-9334", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2040,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Merle", "EE37210", 4, "G383663", new DateTime(1954, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "George_Rowe68@hotmail.com", "George", "Rowe", "Svalbard & Jan Mayen Islands", "368.844.5382 x55398", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2041,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Deanshire", "EE52149", 4, "G567277", new DateTime(1991, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kristopher.Effertz@yahoo.com", "Kristopher", "Effertz", "Slovenia", "983-605-3046 x81198" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Grahamfurt", "EE52657", "G541206", new DateTime(1966, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kelley61@hotmail.com", "Kelley", "Sipes", "Mayotte", "804.350.5668 x742", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Yvettechester", "EE9683", 4, "G416584", new DateTime(1973, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Timothy97@yahoo.com", "Timothy", "Stamm", "Italy", "(371) 634-8310 x0637", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Smithamchester", "EE41879", 2, "G273486", new DateTime(1959, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lamar.Bergnaum@gmail.com", "Lamar", "Bergnaum", "Guernsey", "975-283-0977 x59530", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnsonstad", "EE22133", 2, "G136396", new DateTime(1971, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Chester_Kunde81@hotmail.com", "Chester", "Kunde", "Monaco", "(666) 448-4702", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mayerburgh", "EE31828", 2, "G401596", new DateTime(1986, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Ida11@hotmail.com", "Ida", "Cummerata", "Latvia", "1-781-309-1613" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wilbermouth", "EE17986", 2, "G321649", new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Rex_Schamberger46@yahoo.com", "Rex", "Schamberger", "Brunei Darussalam", "249-454-0416 x2872" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2048,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Weberhaven", "EE42815", "G188561", new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lucille22@gmail.com", "Lucille", "O'Kon", "Gabon", "660.393.3216 x1567", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2049,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Douglaschester", "EE51013", 1, "G578492", new DateTime(1956, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jeannette.Jacobs@yahoo.com", "Jeannette", "Jacobs", "Mayotte", "(411) 688-6074 x447" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Gaetanomouth", "EE35942", 2, "G279820", new DateTime(1996, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Vicki.Walter96@yahoo.com", "Vicki", "Walter", "Sierra Leone", "1-775-762-9795" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wunschshire", "EE3852", "G230859", new DateTime(1977, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Arlene_Sporer95@gmail.com", "Arlene", "Sporer", "Pakistan", "(844) 279-6887" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Greenholtton", "EE27744", 3, "G20816", new DateTime(1975, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ricardo.Harris@hotmail.com", "Ricardo", "Harris", "Saudi Arabia", "1-547-581-4695 x166", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2053,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Braden", "EE12724", 3, "G261227", new DateTime(1957, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Ethel11@yahoo.com", "Ethel", "McLaughlin", "Gibraltar", "1-243-294-9530", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2054,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Freemanbury", "EE10937", 1, "G277002", new DateTime(1984, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Megan0@yahoo.com", "Megan", "Tremblay", "Guyana", "464.564.2711" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Nyasia", "EE50007", 2, "G81243", new DateTime(1958, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Marc.Muller78@hotmail.com", "Marc", "Muller", "Bulgaria", "(325) 948-2633 x9551" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Willardbury", "EE54876", 2, "G455521", new DateTime(1953, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Raquel29@hotmail.com", "Raquel", "Wolff", "Japan", "1-906-360-1369 x0058", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2057,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Corwinview", "EE17999", 1, "G155722", new DateTime(1956, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Robyn85@yahoo.com", "Robyn", "Hickle", "Madagascar", "1-255-406-4258 x1154" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2058,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Germanville", "EE19663", 3, "G88620", new DateTime(2000, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Cary14@yahoo.com", "Cary", "Heathcote", "Egypt", "(949) 567-5728", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2059,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Johnmouth", "EE27824", "G164847", new DateTime(1963, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Ronald.Schmidt@yahoo.com", "Ronald", "Schmidt", "Mexico", "(832) 290-7020", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2060,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vivianechester", "EE27776", 1, "G65626", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Erick28@yahoo.com", "Erick", "Rogahn", "Bahamas", "409-290-6857 x77407", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Laurelburgh", "EE41100", 3, "G233093", new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Trevor39@hotmail.com", "Trevor", "Pouros", "Czech Republic", "(608) 229-0298" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2062,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kayleigh", "EE44210", 2, "G283235", new DateTime(1969, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ray_Torp@yahoo.com", "Ray", "Torp", "Morocco", "1-858-958-7581", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2063,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Bernita", "EE21448", 4, "G508575", new DateTime(1970, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Kristy_Turcotte26@yahoo.com", "Kristy", "Turcotte", "Rwanda", "1-925-509-0455" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2064,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Margaretebury", "EE6238", "G21778", new DateTime(1999, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Dan.Nicolas15@gmail.com", "Dan", "Nicolas", "Bangladesh", "933-458-4337 x56258", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sipesville", "EE24573", "G71739", new DateTime(1979, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Molly.Dare@hotmail.com", "Molly", "Dare", "Spain", "(202) 945-7869", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Candacefurt", "EE5374", 3, "G105076", new DateTime(1958, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Roman.Bayer78@yahoo.com", "Roman", "Bayer", "Rwanda", "1-296-606-5857" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2067,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Theron", "EE43095", 4, "G236537", new DateTime(1984, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Salvatore.Reichert@gmail.com", "Salvatore", "Reichert", "Benin", "252-357-8676", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2068,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carolynehaven", "EE33102", "G331488", new DateTime(1960, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rebecca29@yahoo.com", "Rebecca", "Koepp", "Latvia", "(483) 666-9541 x8757", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Jermain", "EE44818", 1, "G517715", new DateTime(1958, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jasmine_Harber@gmail.com", "Jasmine", "Harber", "Jersey", "631.443.5300 x7494", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardville", "EE52061", "G598877", new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Hickle36@yahoo.com", "Rolando", "Hickle", "Aruba", "429.329.5524 x4813" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Adrielshire", "EE53860", "G223369", new DateTime(1993, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lori.Gusikowski66@hotmail.com", "Lori", "Gusikowski", "Saudi Arabia", "1-202-619-3468 x131", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Dalton", "EE26808", "G70041", new DateTime(1956, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lonnie49@gmail.com", "Lonnie", "Dickens", "Cocos (Keeling) Islands", "812.922.7412 x804", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Brooklynberg", "EE24314", "G475363", new DateTime(1976, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Mabel92@yahoo.com", "Mabel", "Larson", "Iraq", "991.926.1722 x8115" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Emilie", "EE16596", 3, "G552161", new DateTime(1968, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Laverne39@hotmail.com", "Laverne", "Wisozk", "Cayman Islands", "(671) 785-2207", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bradtkeshire", "EE27669", 2, "G438188", new DateTime(1968, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Roxanne_Bailey70@hotmail.com", "Roxanne", "Bailey", "India", "(596) 505-3329 x71653", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "lastname", "natio", "phone" },
                values: new object[] { "West Ford", "EE44414", 4, "G72553", new DateTime(1963, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alexander90@yahoo.com", "Waelchi", "Ecuador", "1-436-338-5265 x495" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Emmie", "EE26382", 2, "G164557", new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Dominick21@gmail.com", "Dominick", "Koch", "Bhutan", "1-321-544-8033 x57293", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hardychester", "EE27357", "G364347", new DateTime(1995, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Joanne.Hyatt99@yahoo.com", "Joanne", "Hyatt", "Brunei Darussalam", "242-566-6658 x10792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Durganchester", "EE36102", "G17157", new DateTime(1996, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tamara15@hotmail.com", "Tamara", "O'Kon", "Senegal", "1-931-589-1353", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Denaside", "EE13285", 3, "G226597", new DateTime(1976, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Morris.Wyman@gmail.com", "Morris", "Wyman", "Libyan Arab Jamahiriya", "1-767-527-0730 x5351" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Antoinette", "EE27678", 3, "G484179", new DateTime(1976, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sam81@hotmail.com", "Sam", "Schaefer", "Austria", "647-498-4080" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Sanford", "EE32630", 4, "G392383", new DateTime(1976, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Elena_Turner11@yahoo.com", "Elena", "Turner", "United States Minor Outlying Islands", "1-591-970-5731 x423" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Antonetta", "EE28344", 1, "G359955", new DateTime(1977, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jeannette0@yahoo.com", "Jeannette", "Macejkovic", "Liechtenstein", "(486) 759-8784 x82097", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lynchville", "EE25915", 4, "G392281", new DateTime(1992, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Agnes.OConnell47@gmail.com", "Agnes", "O'Connell", "Tajikistan", "(711) 372-8385", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Joshuaview", "EE28247", 2, "G499300", new DateTime(1969, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Otis_Tillman42@yahoo.com", "Otis", "Tillman", "Belgium", "(777) 441-7782 x869", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2086,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Rosalindmouth", "EE24021", "G129268", new DateTime(1999, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Moses78@gmail.com", "Moses", "Roberts", "Central African Republic", "1-886-612-7439 x143", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2087,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Annettehaven", "EE34903", 1, "G329519", new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Upton51@yahoo.com", "Johnnie", "Upton", "Nigeria", "963.749.7887 x57856", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2088,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Purdyfurt", "EE29882", 3, "G598325", new DateTime(1979, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Fernando8@yahoo.com", "Fernando", "Lebsack", "Maldives", "243.896.1868", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2089,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pearlineborough", "EE27847", "G31532", new DateTime(1974, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Elaine17@hotmail.com", "Elaine", "Stamm", "Greenland", "(796) 238-6799 x1273", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2090,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Riceshire", "EE31840", 3, "G473350", new DateTime(1991, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Devin9@hotmail.com", "Devin", "Lehner", "Grenada", "228-350-5278 x21410" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2091,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maidaberg", "EE41129", 1, "G512064", new DateTime(1968, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dora_Torp50@gmail.com", "Dora", "Torp", "Saint Barthelemy", "(203) 732-8834" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2092,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stracketon", "EE19914", "G1742", new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lana.Jacobson75@hotmail.com", "Lana", "Jacobson", "Isle of Man", "(908) 897-2224 x9488", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2093,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jonasborough", "EE5658", "G537236", new DateTime(1999, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Donna.Legros@yahoo.com", "Donna", "Legros", "Sao Tome and Principe", "242.372.9312 x589", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2094,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Venastad", "EE19027", "G581235", new DateTime(1969, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Chelsea14@yahoo.com", "Chelsea", "Reilly", "Italy", "956.501.6284", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2095,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hilmaville", "EE19704", "G268043", new DateTime(1953, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Janis.Goyette83@yahoo.com", "Janis", "Goyette", "Guatemala", "1-300-608-6331 x3376" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2096,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Goyetteburgh", "EE57834", 1, "G429865", new DateTime(1999, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Bauch51@yahoo.com", "Inez", "Bauch", "Venezuela", "(467) 761-0513" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2097,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lennabury", "EE45780", 1, "G56587", new DateTime(1962, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Doyle_Windler27@gmail.com", "Doyle", "Windler", "Kazakhstan", "1-381-913-6861 x508" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2098,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Monroeville", "EE8157", 1, "G66718", new DateTime(1986, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Mamie.Mante29@gmail.com", "Mamie", "Mante", "Kuwait", "983-786-9118", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2099,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Hildamouth", "EE52508", 3, "G16838", new DateTime(1973, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Eloise_Corkery30@yahoo.com", "Eloise", "Corkery", "Turkey", "1-404-859-5573 x2185" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2100,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Edisonside", "EE27662", "G593488", new DateTime(1999, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Beatrice.Bernhard54@yahoo.com", "Beatrice", "Bernhard", "Tajikistan", "(632) 425-3520 x88094" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lorenzmouth", "EE29890", "G590929", new DateTime(1993, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sean83@hotmail.com", "Sean", "Romaguera", "Anguilla", "1-676-242-6226 x7202" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Jackelineton", "EE49933", 2, "G552399", new DateTime(1969, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kathy.OReilly1@hotmail.com", "Kathy", "O'Reilly", "El Salvador", "527.885.5726", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Tiannahaven", "EE4179", 4, "G136376", new DateTime(1972, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Crystal.Watsica93@yahoo.com", "Crystal", "Watsica", "Heard Island and McDonald Islands", "515-812-8398", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lucieside", "EE23318", 1, "G208550", new DateTime(1962, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Leona97@gmail.com", "Leona", "Hand", "Senegal", "335.731.4217 x73926", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nedraville", "EE44717", 2, "G237092", new DateTime(1997, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie_Bergnaum@hotmail.com", "Marjorie", "Bergnaum", "El Salvador", "586-415-8617" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Ellahaven", "EE25543", 3, "G104009", new DateTime(1985, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Allan_Feeney8@hotmail.com", "Allan", "Feeney", "Czech Republic", "665.988.7914", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2107,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Glennahaven", "EE42453", 1, "G281155", new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie.Ziemann13@gmail.com", "Bobbie", "Ziemann", "Antarctica (the territory South of 60 deg S)", "932.877.5023 x2988" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2108,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Royalton", "EE351", "G567904", new DateTime(1983, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jaime.Vandervort4@yahoo.com", "Jaime", "Vandervort", "Niger", "1-368-281-0684" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2109,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Esperanza", "EE33924", 2, "G349999", new DateTime(1994, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Terence.Kris@hotmail.com", "Terence", "Kris", "Grenada", "886.525.2457", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2110,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Murrayborough", "EE10042", 1, "G438223", new DateTime(1999, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sue.Kautzer@yahoo.com", "Sue", "Kautzer", "Guinea", "792-616-3093" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2111,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Tristianhaven", "EE48248", 2, "G521030", new DateTime(1977, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Clyde.Smitham@hotmail.com", "Clyde", "Smitham", "Netherlands Antilles", "1-354-722-6185 x616", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2112,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Paucekshire", "EE22781", 4, "G568919", new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Judy.Skiles@yahoo.com", "Judy", "Skiles", "Turkey", "1-763-494-8348 x4092" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Korbinstad", "EE21751", 4, "G428030", new DateTime(1955, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Emily_Krajcik@gmail.com", "Emily", "Krajcik", "Kuwait", "(831) 905-4080 x597", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Arnoldo", "EE2347", 2, "G343306", new DateTime(1979, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lynda.Labadie@gmail.com", "Lynda", "Labadie", "United Arab Emirates", "903.918.0768", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Guido", "EE2334", "G215196", new DateTime(1994, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Fredrick.Reichel@gmail.com", "Fredrick", "Reichel", "Chile", "1-409-511-0650 x2547" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Emiliano", "EE52110", 2, "G242232", new DateTime(1965, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Elmer46@yahoo.com", "Elmer", "Harris", "Democratic People's Republic of Korea", "899.277.0844 x3705", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Shanel", "EE29112", 1, "G12373", new DateTime(1970, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lucille.Beahan@yahoo.com", "Lucille", "Beahan", "Tunisia", "242-873-8603 x146", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Adela", "EE10179", 3, "G100042", new DateTime(1964, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Eric17@yahoo.com", "Eric", "Crona", "Bosnia and Herzegovina", "(318) 908-5762" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lamontport", "EE18665", 2, "G364715", new DateTime(1993, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Elaine.Johns87@hotmail.com", "Elaine", "Johns", "Sweden", "(610) 449-6403 x73165", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Daltonstad", "EE28961", 4, "G177667", new DateTime(1962, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Craig46@yahoo.com", "Craig", "Hauck", "Ethiopia", "202-741-6873 x19973", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2121,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maiabury", "EE37570", 4, "G64439", new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hubert_Wiza13@gmail.com", "Hubert", "Wiza", "Bulgaria", "1-927-631-3977", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2122,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rebamouth", "EE44343", 1, "G492485", new DateTime(1952, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Johanna45@gmail.com", "Johanna", "Durgan", "Slovenia", "1-987-701-6359" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2123,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Domenicostad", "EE56375", 2, "G375796", new DateTime(1989, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ramiro.Stiedemann@yahoo.com", "Ramiro", "Stiedemann", "Cambodia", "240-558-5281 x368", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2124,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Cecilemouth", "EE40162", 2, "G105514", new DateTime(1961, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Vivian.Cormier40@gmail.com", "Vivian", "Cormier", "Bosnia and Herzegovina", "(279) 996-1998 x47408", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2125,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Narcisofurt", "EE32630", 3, "G337963", new DateTime(1991, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Hector.Welch@hotmail.com", "Hector", "Welch", "French Southern Territories", "610-899-3542 x1310" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2126,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Zula", "EE31286", 1, "G170988", new DateTime(1958, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo.Cremin@hotmail.com", "Guillermo", "Cremin", "Martinique", "1-718-546-8577 x56536" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Rheahaven", "EE19069", 1, "G79707", new DateTime(1989, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "John72@gmail.com", "John", "Weber", "Samoa", "1-902-685-6232" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2128,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Michaelashire", "EE14610", 2, "G421642", new DateTime(1968, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Boyd_MacGyver@yahoo.com", "Boyd", "MacGyver", "Albania", "957-398-6781" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2129,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rebaberg", "EE43977", 3, "G66266", new DateTime(1964, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Rosemarie92@gmail.com", "Rosemarie", "Tremblay", "New Caledonia", "257-919-5499", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Christiansenhaven", "EE23632", 1, "G234213", new DateTime(1966, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Max.OHara@hotmail.com", "Max", "O'Hara", "Mayotte", "373-913-0525 x319" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Bernitaport", "EE15044", "G36206", new DateTime(1992, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rebecca.Moen@hotmail.com", "Rebecca", "Moen", "Lesotho", "251-696-2874 x9064" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2132,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kalebchester", "EE45421", 2, "G175448", new DateTime(1970, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Heidi.Pfannerstill80@hotmail.com", "Heidi", "Pfannerstill", "Malta", "741.499.9673" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2133,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Miketown", "EE7552", "G579084", new DateTime(1953, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lena.Lebsack63@gmail.com", "Lena", "Lebsack", "Tuvalu", "(403) 944-6593 x8555", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2134,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Alvertaport", "EE41940", "G161654", new DateTime(1957, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Orn@gmail.com", "Shane", "Orn", "Israel", "1-479-835-0913 x15877" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2135,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Martin", "EE5905", 2, "G221200", new DateTime(1980, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Marsha66@yahoo.com", "Marsha", "Reynolds", "Namibia", "(332) 689-3571", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Gailview", "EE14399", 4, "G20238", new DateTime(1982, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Andy28@hotmail.com", "Andy", "Hahn", "Kyrgyz Republic", "831-991-4784 x0840", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Auroremouth", "EE286", "G390209", new DateTime(1991, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Virginia_Jaskolski@gmail.com", "Virginia", "Jaskolski", "Iceland", "706-813-0970", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jeradberg", "EE35925", "G358747", new DateTime(1987, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Van88@yahoo.com", "Van", "Adams", "Czech Republic", "(492) 800-6676 x116", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "North Trevionstad", "EE43769", 1, "G23060", new DateTime(1961, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Laverne.Buckridge@hotmail.com", "Laverne", "Buckridge", "1-437-683-9385 x819" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Everett", "EE39535", 2, "G11810", new DateTime(1971, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Katherine_Feil@hotmail.com", "Katherine", "Feil", "Moldova", "1-514-645-0491 x452" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hilpertton", "EE56882", "G441275", new DateTime(1975, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Victor.Daugherty@gmail.com", "Victor", "Daugherty", "France", "(901) 762-0262" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Windlerville", "EE807", 3, "G299464", new DateTime(1992, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Olivia_Kulas@yahoo.com", "Olivia", "Kulas", "Luxembourg", "888-658-4291", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2143,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Reillytown", "EE57724", 4, "G93649", new DateTime(1998, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Daryl.Wisozk@hotmail.com", "Daryl", "Wisozk", "Venezuela", "448-774-4797 x27304", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2144,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jessiehaven", "EE57129", 1, "G294288", new DateTime(1955, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Vickie63@gmail.com", "Vickie", "Hoeger", "Dominican Republic", "1-954-337-8915 x52750", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2145,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Damarisside", "EE1434", 3, "G559753", new DateTime(1967, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Vernon68@yahoo.com", "Vernon", "Ortiz", "Republic of Korea", "819-506-0576 x444" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2146,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Daisy", "EE12862", 3, "G490180", new DateTime(1971, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Elsa.Cruickshank@yahoo.com", "Elsa", "Cruickshank", "Nigeria", "881-289-4821 x45070", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wolfside", "EE30738", 2, "G558925", new DateTime(1966, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wendy65@hotmail.com", "Wendy", "Bechtelar", "Fiji", "1-736-732-8629 x79186", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2148,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Brandoberg", "EE30896", 2, "G333551", new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester_Doyle@yahoo.com", "Sylvester", "Doyle", "Togo", "361.956.6566 x8029" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2149,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Percy", "EE50699", 4, "G557920", new DateTime(1979, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Linda.Thompson@hotmail.com", "Linda", "Thompson", "South Africa", "1-342-334-6905 x977", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2150,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Luella", "EE31260", 4, "G528939", new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Grady_Kunde17@yahoo.com", "Grady", "Kunde", "American Samoa", "(624) 453-6426 x8760" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2151,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Boborough", "EE7998", 3, "G490398", new DateTime(1954, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Sharon_Stokes12@gmail.com", "Sharon", "Stokes", "Tajikistan", "275.532.4406 x0747" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jordishire", "EE6954", 1, "G254977", new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Veronica77@hotmail.com", "Veronica", "Parker", "Guernsey", "(465) 715-7614 x52000", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Alana", "EE58416", 2, "G158068", new DateTime(1995, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jacquelyn.Altenwerth@yahoo.com", "Jacquelyn", "Altenwerth", "Pakistan", "1-378-367-4852" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2154,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Wilbertmouth", "EE420", "G396931", new DateTime(1984, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Roosevelt_Mohr48@gmail.com", "Roosevelt", "Mohr", "Republic of Korea", "(235) 490-1900 x3679" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2155,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dejashire", "EE15505", 1, "G125895", new DateTime(1987, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Blake_Littel97@gmail.com", "Blake", "Littel", "Paraguay", "(265) 262-4730" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2156,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jaleelstad", "EE37161", 2, "G115211", new DateTime(1966, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Mack88@yahoo.com", "Mack", "Walker", "Suriname", "1-205-250-0396 x30325", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2157,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kylietown", "EE37550", 2, "G360174", new DateTime(1984, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wesley66@hotmail.com", "Wesley", "Medhurst", "San Marino", "386.623.0362 x591", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Kianburgh", "EE32134", 2, "G572622", new DateTime(1979, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Alonzo26@yahoo.com", "Alonzo", "Halvorson", "Cocos (Keeling) Islands", "304.749.8819 x1280" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rogahnville", "EE58461", "G410594", new DateTime(1951, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla.Fay@hotmail.com", "Priscilla", "Fay", "Cyprus", "739-228-2173" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Lacyborough", "EE41959", "G27835", new DateTime(1975, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Elizabeth4@yahoo.com", "Elizabeth", "Quigley", "Maldives", "(431) 738-1529 x37617" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Vidalton", "EE59187", 4, "G236499", new DateTime(1967, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gregory_Kemmer@yahoo.com", "Gregory", "Kemmer", "Costa Rica", "954-770-5614 x6839", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2162,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Noeview", "EE31891", 3, "G401405", new DateTime(1963, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Matthew.Wuckert@gmail.com", "Matthew", "Wuckert", "Nicaragua", "(928) 968-8029 x37218" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2163,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Lincoln", "EE20607", 3, "G356593", new DateTime(1975, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kevin94@yahoo.com", "Kevin", "Conroy", "Guyana", "1-515-324-2097 x712", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2164,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gorczanyton", "EE4667", 1, "G320003", new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Virginia_Stamm2@yahoo.com", "Virginia", "Stamm", "Cocos (Keeling) Islands", "(288) 358-7602 x4447" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2165,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Vincent", "EE4767", "G476100", new DateTime(1955, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Dana97@hotmail.com", "Dana", "Hayes", "Heard Island and McDonald Islands", "1-283-676-4268" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Vincenzabury", "EE47564", 2, "G140467", new DateTime(1961, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Erin_Frami@gmail.com", "Erin", "Frami", "Nauru", "307-354-3905 x9481", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bauchberg", "EE51103", 3, "G513383", new DateTime(2001, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Stanley_Oberbrunner32@hotmail.com", "Stanley", "Oberbrunner", "China", "1-960-636-6850 x190", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Freeman", "EE14582", 3, "G437641", new DateTime(1957, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Cecilia.Quitzon@hotmail.com", "Cecilia", "Quitzon", "Ukraine", "1-287-241-7967 x98592", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Uptonberg", "EE6500", 4, "G174143", new DateTime(1977, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Nettie.Runolfsson@hotmail.com", "Nettie", "Runolfsson", "Turks and Caicos Islands", "910.555.0451", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2170,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Darius", "EE39501", "G231423", new DateTime(1952, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Tyrone51@yahoo.com", "Tyrone", "Leffler", "Hong Kong", "859.623.4565 x01719", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2171,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Shannaburgh", "EE3362", "G15545", new DateTime(1961, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Stephanie57@yahoo.com", "Stephanie", "Dicki", "Swaziland", "624-497-3960 x4634" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Marguerite", "EE53828", 1, "G385620", new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.Hoppe70@gmail.com", "Maryann", "Hoppe", "Congo", "654.738.9729 x87524", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mozellside", "EE42454", 1, "G375837", new DateTime(1973, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lucy69@hotmail.com", "Lucy", "Feil", "Namibia", "879-210-1527", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2174,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Joshuaview", "EE21731", 3, "G245905", new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Christine27@gmail.com", "Christine", "Donnelly", "San Marino", "(853) 742-6714 x206" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2175,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dwightside", "EE59154", 3, "G367513", new DateTime(1987, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Robin5@hotmail.com", "Robin", "Rohan", "Maldives", "293.495.6050 x475" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2176,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rautown", "EE19924", "G387787", new DateTime(1967, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mae.Lesch@hotmail.com", "Mae", "Lesch", "Brazil", "(672) 354-3602 x0652" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2177,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lonzoland", "EE30476", 1, "G38145", new DateTime(1989, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Belinda_Schroeder@yahoo.com", "Belinda", "Schroeder", "Togo", "1-674-431-3481" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2178,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lilaville", "EE46685", "G334041", new DateTime(1974, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Margie.Jacobs@yahoo.com", "Margie", "Jacobs", "Greece", "750-218-7354 x84510", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brownfort", "EE48519", "G56517", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Pedro_Douglas92@hotmail.com", "Pedro", "Douglas", "Anguilla", "(871) 896-3604 x08258" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Pattieberg", "EE35259", "G154013", new DateTime(1998, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Wade.Wehner51@hotmail.com", "Wade", "Wehner", "Guatemala", "1-849-429-5217" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Georgianaville", "EE10601", "G544353", new DateTime(1976, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Erik_Rodriguez77@gmail.com", "Erik", "Rodriguez", "Chad", "718.971.6800 x7663" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Alysa", "EE37067", 3, "G575431", new DateTime(1994, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hattie_Fisher20@yahoo.com", "Hattie", "Fisher", "Cocos (Keeling) Islands", "1-474-221-8858 x26068" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2183,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jeanette", "EE16250", 3, "G282043", new DateTime(1991, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kristy_Bosco53@yahoo.com", "Kristy", "Bosco", "Finland", "1-911-520-8837 x344" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2184,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lorenzofurt", "EE39449", 3, "G86113", new DateTime(1956, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Alexis36@yahoo.com", "Alexis", "Padberg", "Venezuela", "1-457-768-0862 x33134", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lillaland", "EE2041", 1, "G406844", new DateTime(1955, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sadie_Wiegand75@gmail.com", "Sadie", "Wiegand", "San Marino", "960.880.3479 x37286" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2186,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Aron", "EE50696", 4, "G301756", new DateTime(1954, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tyler.Cremin@hotmail.com", "Tyler", "Cremin", "Antarctica (the territory South of 60 deg S)", "(578) 261-1658 x72408", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2187,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Marta", "EE5325", 3, "G141979", new DateTime(1964, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo_Heaney78@yahoo.com", "Gustavo", "Heaney", "Swaziland", "(254) 874-1497" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2188,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Chanelside", "EE57737", "G419848", new DateTime(1986, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Esther_Gibson93@hotmail.com", "Esther", "Gibson", "Eritrea", "514-781-5152" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2189,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cesarmouth", "EE35790", "G503440", new DateTime(1956, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Erick53@gmail.com", "Erick", "Kessler", "Belgium", "482.822.4671" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2190,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jarrettborough", "EE44259", 2, "G564719", new DateTime(1975, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sean38@hotmail.com", "Sean", "Okuneva", "Mexico", "307.678.2815 x315" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2191,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Elenora", "EE39322", 2, "G213976", new DateTime(1957, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Freda71@gmail.com", "Freda", "Halvorson", "Guinea-Bissau", "1-766-911-7138" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2192,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schinnerfurt", "EE32162", "G24707", new DateTime(1954, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Rachel_Emard60@gmail.com", "Rachel", "Emard", "Armenia", "975.677.9769 x1598" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Heathcoteport", "EE3113", "G252600", new DateTime(1952, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Beulah71@gmail.com", "Beulah", "Grant", "Hungary", "413-643-1473 x85625", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Sydnee", "EE51098", 2, "G295821", new DateTime(1974, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jon.Kautzer39@gmail.com", "Jon", "Kautzer", "Mexico", "475-326-0049", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jason", "EE42509", 2, "G535716", new DateTime(1969, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Van.Langosh@gmail.com", "Van", "Langosh", "Nauru", "(231) 573-0427 x32611" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Moriahtown", "EE34778", "G208695", new DateTime(1993, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Darnell.Wilkinson62@gmail.com", "Darnell", "Wilkinson", "Grenada", "1-285-727-2921 x79627" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2197,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beverlyview", "EE4829", 4, "G471504", new DateTime(1976, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kevin.Larkin@gmail.com", "Kevin", "Larkin", "Kyrgyz Republic", "634-950-9063 x34989" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2198,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Raleighville", "EE56564", "G345534", new DateTime(1994, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Woodrow_Paucek@yahoo.com", "Woodrow", "Paucek", "Sweden", "965-550-7064 x594" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alexzanderborough", "EE29758", 4, "G444435", new DateTime(1960, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto_White@gmail.com", "Gilberto", "White", "Namibia", "272.402.3714 x49890" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2200,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Laronbury", "EE56195", 3, "G224171", new DateTime(1986, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Enrique56@gmail.com", "Enrique", "Gulgowski", "Guinea", "(598) 864-9891", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2201,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Kendra", "EE54582", 2, "G535423", new DateTime(1958, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred.Legros@gmail.com", "Wilfred", "Legros", "Virgin Islands, British", "1-750-978-4776" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2202,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Swifthaven", "EE14049", 1, "G590751", new DateTime(1995, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Vicky_Lueilwitz@yahoo.com", "Vicky", "Lueilwitz", "Bahamas", "1-733-369-1296 x473", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2203,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Aiyanachester", "EE35007", "G25029", new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Eduardo_Rice@yahoo.com", "Eduardo", "Rice", "Germany", "690.342.4537", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Groverfurt", "EE38881", "G322899", new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kenny_Spinka33@gmail.com", "Kenny", "Spinka", "Swaziland", "892.228.1106" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Elinorchester", "EE27578", 2, "G483410", new DateTime(1961, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Nick_Thiel@yahoo.com", "Nick", "Thiel", "Ireland", "373.893.8445 x9484" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Eddiebury", "EE22985", 2, "G47370", new DateTime(1992, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Damon_Berge@hotmail.com", "Damon", "Berge", "Isle of Man", "548-562-2702", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Willshire", "EE1398", "G521190", new DateTime(1957, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Eric6@yahoo.com", "Eric", "Hintz", "American Samoa", "731.642.4491 x3763" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "West Chesleyland", "EE52502", "G241114", new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "April.Lowe@yahoo.com", "April", "Lowe", "531.316.2395" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schummside", "EE8744", "G43026", new DateTime(1987, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Wendy_Skiles4@hotmail.com", "Wendy", "Skiles", "Saudi Arabia", "910.797.9819 x457", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Sabinashire", "EE27607", 2, "G134334", new DateTime(1964, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Alicia62@yahoo.com", "Alicia", "Schmeler", "Belgium", "315.543.0988 x53413", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Aiden", "EE26578", 3, "G70802", new DateTime(1970, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Michelle_Quitzon@yahoo.com", "Michelle", "Quitzon", "Kiribati", "1-417-599-1524" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keeblerside", "EE13973", 2, "G249336", new DateTime(1952, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Archie86@hotmail.com", "Archie", "Daniel", "Wallis and Futuna", "(892) 877-5125 x6339" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Daughertyfort", "EE48877", 4, "G87189", new DateTime(1963, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lora91@gmail.com", "Lora", "Parker", "Wallis and Futuna", "1-273-536-2696 x3192", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Haven", "EE13121", 4, "G109439", new DateTime(1989, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Christina.Hermann89@gmail.com", "Christina", "Hermann", "Iceland", "882-999-5425 x309" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Bart", "EE45603", 1, "G540569", new DateTime(1959, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Essie30@gmail.com", "Essie", "Mosciski", "Cambodia", "1-401-675-0801 x68124" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2216,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Felicitaberg", "EE33307", 1, "G236232", new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marcos37@hotmail.com", "Marcos", "Cruickshank", "Afghanistan", "883.327.6467 x771", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2217,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Tamara", "EE8953", 2, "G294981", new DateTime(1989, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ruth16@yahoo.com", "Ruth", "Kassulke", "San Marino", "(727) 291-4145 x34934", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2218,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Bryana", "EE23186", 2, "G597775", new DateTime(1968, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lois0@hotmail.com", "Lois", "Lockman", "United Kingdom", "(364) 706-0768" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2219,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bechtelarmouth", "EE48852", 4, "G147066", new DateTime(1963, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Olive_Rowe@hotmail.com", "Olive", "Rowe", "Faroe Islands", "1-803-809-9730 x143" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "Port Ameliaton", "EE25477", 2, "G400937", new DateTime(1976, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Leland.Macejkovic94@gmail.com", "Leland", "Macejkovic", "1-540-392-5235" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Bradlymouth", "EE8383", 1, "G250243", new DateTime(1974, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Annie61@yahoo.com", "Annie", "West", "Latvia", "(493) 808-8394 x37357" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Natasha", "EE11202", 3, "G18266", new DateTime(1975, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Essie_Bins85@gmail.com", "Essie", "Bins", "Comoros", "(315) 774-2132", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Volkmanside", "EE37171", "G321366", new DateTime(1968, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Toby_Kulas@gmail.com", "Toby", "Kulas", "Guinea", "1-789-573-6671", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Hymanshire", "EE50640", 1, "G83961", new DateTime(1984, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Wilson.Carroll29@yahoo.com", "Wilson", "Carroll", "Philippines", "692.672.6789 x2204", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Barrowsmouth", "EE50756", "G198204", new DateTime(1984, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Merle44@hotmail.com", "Merle", "Haag", "Netherlands Antilles", "1-917-662-2496 x17645", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2226,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Eltonburgh", "EE56413", 2, "G135524", new DateTime(1972, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Kautzer@gmail.com", "Rhonda", "Kautzer", "Venezuela", "637.832.6130 x2072", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2227,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jaylonport", "EE25338", 2, "G354038", new DateTime(1958, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Nettie57@hotmail.com", "Nettie", "Shanahan", "Indonesia", "440.929.3417 x26020" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Walton", "EE20943", "G366315", new DateTime(1978, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Klein51@gmail.com", "Johnnie", "Klein", "Rwanda", "1-611-924-6049", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2229,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Dorcas", "EE8730", 3, "G517946", new DateTime(1979, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Boyd34@yahoo.com", "Boyd", "Wehner", "Guatemala", "918.551.8647", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2230,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Steve", "EE51329", 1, "G571421", new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Derek.Von9@yahoo.com", "Derek", "Von", "Maldives", "819.710.7811 x91894" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Caitlynside", "EE17919", "G212671", new DateTime(1995, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Angelica20@gmail.com", "Angelica", "Brown", "Italy", "(429) 663-8799 x06462", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Stanton", "EE34774", 4, "G118234", new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Louis.Russel@hotmail.com", "Louis", "Russel", "Israel", "607-400-0720 x39577", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Luciusshire", "EE11467", "G377932", new DateTime(1984, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kristen70@yahoo.com", "Kristen", "Zboncak", "Turkey", "(410) 502-6179 x95349", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2234,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boylechester", "EE57886", 3, "G246162", new DateTime(1961, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Ervin.OReilly@yahoo.com", "Ervin", "O'Reilly", "Falkland Islands (Malvinas)", "972.237.2302 x751", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2235,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dennisburgh", "EE58598", "G203525", new DateTime(1961, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo_Lesch11@gmail.com", "Rodolfo", "Lesch", "Northern Mariana Islands", "1-731-885-0319 x9955", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kassandra", "EE13285", "G83492", new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Horace.Paucek@gmail.com", "Horace", "Paucek", "Uruguay", "(785) 415-4165 x99996", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cydneyborough", "EE28284", 2, "G234132", new DateTime(1972, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Terry_Mills@gmail.com", "Terry", "Mills", "Somalia", "977.216.5850 x4105", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lizastad", "EE1289", 4, "G116561", new DateTime(1991, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Eddie30@yahoo.com", "Eddie", "Anderson", "Mongolia", "1-402-763-5538 x13777" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2239,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Helen", "EE9467", 4, "G484202", new DateTime(1990, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Connie90@hotmail.com", "Connie", "Purdy", "Guatemala", "1-267-380-4828", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2240,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kaiaborough", "EE9455", 1, "G141317", new DateTime(1984, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Joel50@yahoo.com", "Joel", "Dicki", "Anguilla", "330-642-7438 x32015", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2241,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Orville", "EE46914", 3, "G505592", new DateTime(1973, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Daniel37@hotmail.com", "Daniel", "Wunsch", "United Arab Emirates", "312.662.4601" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marilieport", "EE8372", 3, "G308750", new DateTime(1978, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Angie36@gmail.com", "Angie", "Kirlin", "Christmas Island", "522-909-1336" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Idella", "EE7117", 3, "G137266", new DateTime(1959, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester_Lueilwitz58@gmail.com", "Sylvester", "Lueilwitz", "Timor-Leste", "(704) 454-7850" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Adan", "EE46511", 4, "G275861", new DateTime(1961, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Bryant.Klein94@yahoo.com", "Bryant", "Klein", "Comoros", "1-687-773-2803" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Baron", "EE17375", "G292318", new DateTime(1964, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Nina.Nikolaus@hotmail.com", "Nina", "Nikolaus", "Taiwan", "831-933-2056", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Benniestad", "EE42582", 3, "G10426", new DateTime(1968, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Randolph24@gmail.com", "Randolph", "Hahn", "Saint Vincent and the Grenadines", "837.201.7110 x15528" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pearlfurt", "EE35146", 4, "G401726", new DateTime(1977, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Wilma_King@yahoo.com", "Wilma", "King", "Liberia", "319-632-3795 x19964", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Doriantown", "EE23453", "G145770", new DateTime(1975, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Kulas@yahoo.com", "Mildred", "Kulas", "Portugal", "710-623-0349" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2249,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hendersonberg", "EE16773", 3, "G344674", new DateTime(1971, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo.Fadel12@hotmail.com", "Gustavo", "Fadel", "Tajikistan", "(370) 248-6152" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2250,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Christiansenfort", "EE37934", "G458351", new DateTime(1973, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Gutkowski42@yahoo.com", "Tami", "Gutkowski", "American Samoa", "888.777.6809 x635" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jayceefurt", "EE8685", "G84219", new DateTime(1986, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Leigh.Howe@hotmail.com", "Leigh", "Howe", "Netherlands Antilles", "354-255-7026" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2252,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Arnofort", "EE27471", 2, "G356670", new DateTime(1957, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Damon54@yahoo.com", "Damon", "Walter", "Sudan", "772-508-2663" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2253,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Olafchester", "EE38131", 4, "G378168", new DateTime(1952, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Shannon_Christiansen@hotmail.com", "Shannon", "Christiansen", "Benin", "1-901-930-6984" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Barbaraview", "EE13081", 3, "G322039", new DateTime(1966, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Marty48@gmail.com", "Marty", "Moen", "Iran", "1-264-406-0770 x11348", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Asha", "EE56564", "G474284", new DateTime(1979, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Angel_Daniel88@yahoo.com", "Angel", "Daniel", "Benin", "(450) 433-0982", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Hoyt", "EE43515", "G482841", new DateTime(1962, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Erica_Price71@gmail.com", "Erica", "Price", "Costa Rica", "435-565-9240 x7425", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Mireilleburgh", "EE20228", 2, "G176646", new DateTime(1954, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Lola_Haley25@gmail.com", "Lola", "Haley", "Angola", "(616) 769-6229", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Brandy", "EE26326", 1, "G369539", new DateTime(1960, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Erick.Sanford40@gmail.com", "Erick", "Sanford", "Saint Martin", "(869) 720-9728" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2259,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Darianshire", "EE24745", 3, "G560636", new DateTime(1964, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Monica25@yahoo.com", "Monica", "Powlowski", "Sri Lanka", "319.634.3331", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2260,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Vance", "EE1975", 2, "G171840", new DateTime(1973, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marshall46@gmail.com", "Marshall", "Morissette", "Dominican Republic", "(913) 801-1898 x006", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2261,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Neal", "EE18951", 3, "G556379", new DateTime(1994, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sammy12@gmail.com", "Sammy", "Shields", "Iceland", "(849) 893-6095 x07384" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2262,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lindgrenland", "EE56092", 4, "G592786", new DateTime(1972, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Clara.Buckridge29@yahoo.com", "Clara", "Buckridge", "Slovenia", "769.997.7811", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2263,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Reichertport", "EE26623", "G55251", new DateTime(1974, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lucy41@yahoo.com", "Lucy", "Satterfield", "Tajikistan", "898.607.2113 x984", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bennettshire", "EE2321", 3, "G165112", new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Devin.Stanton@yahoo.com", "Devin", "Stanton", "Netherlands Antilles", "(952) 872-1024 x89742" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bechtelartown", "EE28783", 1, "G43807", new DateTime(1972, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Carole_Haag@gmail.com", "Carole", "Haag", "Ghana", "(250) 895-1288 x357" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Samarachester", "EE2486", 1, "G136271", new DateTime(1983, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Ginger37@hotmail.com", "Ginger", "Goyette", "Nicaragua", "1-672-330-9311 x27833", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2267,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Raymondland", "EE17316", 4, "G38960", new DateTime(1979, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Geneva48@hotmail.com", "Geneva", "White", "Cambodia", "(437) 346-4722" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2268,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marciaside", "EE53009", 3, "G511893", new DateTime(1970, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Jimmy90@hotmail.com", "Jimmy", "Schinner", "Kiribati", "633.643.3308 x77830" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gideonfort", "EE49075", "G118324", new DateTime(1975, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Freda_Jones@yahoo.com", "Freda", "Jones", "Malaysia", "559.710.9910 x820", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2270,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Elfriedatown", "EE16743", 1, "G435599", new DateTime(1991, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Nellie.Lueilwitz95@yahoo.com", "Nellie", "Lueilwitz", "Saint Lucia", "399.509.8212", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2271,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kalebstad", "EE25735", "G123969", new DateTime(1955, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Ebony39@yahoo.com", "Ebony", "Douglas", "Bhutan", "1-955-611-8869 x40077" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Thurmanburgh", "EE17006", 2, "G417245", new DateTime(1959, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Isabel94@yahoo.com", "Isabel", "Crona", "Benin", "1-905-243-9382", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Parisianshire", "EE29684", "G537249", new DateTime(1973, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Carmen.Schroeder@hotmail.com", "Carmen", "Schroeder", "Netherlands Antilles", "(417) 385-8289 x2449", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roycetown", "EE37621", "G76187", new DateTime(1953, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Josefina_Dietrich@hotmail.com", "Josefina", "Dietrich", "Sri Lanka", "1-662-544-9616 x86662", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lisandroborough", "EE30133", 4, "G503342", new DateTime(1956, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Felipe.Balistreri29@yahoo.com", "Felipe", "Balistreri", "Guernsey", "939.218.3956", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2276,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abbyside", "EE59954", 2, "G326110", new DateTime(1973, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hannah.Gislason@hotmail.com", "Hannah", "Gislason", "Botswana", "802.539.2809 x6237", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2277,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lakintown", "EE45897", 4, "G221218", new DateTime(1972, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.VonRueden25@gmail.com", "Maryann", "VonRueden", "Malaysia", "763.663.7359", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Swiftburgh", "EE52777", "G546950", new DateTime(1960, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Frank_Brekke@gmail.com", "Frank", "Brekke", "Tokelau", "(316) 753-2313 x23942", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jasper", "EE52156", 2, "G260930", new DateTime(1995, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Christina.Toy67@yahoo.com", "Christina", "Toy", "Nigeria", "1-783-713-3989 x475", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Salma", "EE20438", 4, "G253824", new DateTime(1964, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Karla.Stroman99@gmail.com", "Karla", "Stroman", "Aruba", "913-342-3693 x53590" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Una", "EE24383", 3, "G98936", new DateTime(1958, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester.McGlynn@hotmail.com", "Sylvester", "McGlynn", "Liechtenstein", "1-548-691-8246" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2282,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Kayleeton", "EE44717", "G417310", new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Franklin34@yahoo.com", "Franklin", "Vandervort", "Japan", "656-817-6284" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2283,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Deeshire", "EE797", 3, "G453539", new DateTime(1971, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "George22@gmail.com", "George", "Carter", "Togo", "1-882-614-0547" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2284,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Mallie", "EE59446", 4, "G560966", new DateTime(1982, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Darlene.Pacocha12@yahoo.com", "Darlene", "Pacocha", "Marshall Islands", "(376) 709-5264", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2285,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Giovaniview", "EE57773", 1, "G331753", new DateTime(1955, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Allan34@hotmail.com", "Allan", "Tremblay", "Sweden", "(825) 284-5385", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2286,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kertzmannport", "EE19656", 1, "G575656", new DateTime(1986, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ian_Langosh29@yahoo.com", "Ian", "Langosh", "Cocos (Keeling) Islands", "(873) 398-2461" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2287,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Smithammouth", "EE54024", 1, "G129743", new DateTime(1959, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Boyd_Hauck@gmail.com", "Boyd", "Hauck", "Sao Tome and Principe", "(430) 401-3109", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2288,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Declanville", "EE2954", 3, "G316814", new DateTime(1959, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ebony42@yahoo.com", "Ebony", "Glover", "Indonesia", "602.207.1345" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2289,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Zula", "EE185", 3, "G161301", new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Paula_Stroman83@gmail.com", "Paula", "Stroman", "Ethiopia", "395-659-2129", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2290,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerlachchester", "EE59170", 2, "G511633", new DateTime(1978, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Darla.Rath40@gmail.com", "Darla", "Rath", "Christmas Island", "(830) 654-5061 x91063" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Conroybury", "EE15281", "G157485", new DateTime(1984, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bill.VonRueden@gmail.com", "Bill", "VonRueden", "Bosnia and Herzegovina", "842.299.9111 x68200" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Josiahton", "EE47117", 3, "G396409", new DateTime(1963, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Conn@gmail.com", "Kerry", "Conn", "Maldives", "(425) 300-0529 x745" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2293,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Drakeburgh", "EE17799", 1, "G428215", new DateTime(1991, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell62@gmail.com", "Mitchell", "Hettinger", "Costa Rica", "(621) 250-1362 x1285" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2294,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jovanny", "EE19673", 4, "G343938", new DateTime(1994, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Olive_Kris82@hotmail.com", "Olive", "Kris", "South Africa", "675-752-2156" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Rhoda", "EE44711", 4, "G413134", new DateTime(1955, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Shawn28@yahoo.com", "Shawn", "Koch", "Argentina", "(665) 266-2475" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ferryhaven", "EE14405", 2, "G1876", new DateTime(1998, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Roland_Crona57@gmail.com", "Roland", "Crona", "Lithuania", "463-250-8029", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Turnerfort", "EE47382", 3, "G106466", new DateTime(1978, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Everett_Grady@hotmail.com", "Everett", "Grady", "Equatorial Guinea", "1-902-628-5248 x66076", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Elouise", "EE37198", "G386011", new DateTime(1972, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Albert.Pollich48@yahoo.com", "Albert", "Pollich", "Austria", "773.819.6030", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Fred", "EE23055", "G583570", new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lionel_Heller@gmail.com", "Lionel", "Heller", "Vanuatu", "876-566-1781" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Abshireview", "EE57559", 3, "G558538", new DateTime(1977, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Colin94@gmail.com", "Colin", "Sauer", "Aruba", "205.986.6151 x568" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2301,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schustermouth", "EE11330", 3, "G566030", new DateTime(1997, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Norman24@gmail.com", "Norman", "Jakubowski", "Guinea", "(308) 582-5965 x27330", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2302,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ullrichside", "EE45454", 4, "G39137", new DateTime(1969, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jill_Skiles@hotmail.com", "Jill", "Skiles", "Australia", "799.553.2595 x7777", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2303,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mustafachester", "EE29141", 4, "G505452", new DateTime(1962, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Damon.Gottlieb@yahoo.com", "Damon", "Gottlieb", "Cote d'Ivoire", "449.363.9762 x456" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2304,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Dean", "EE14525", 4, "G469262", new DateTime(1991, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Hugh.Bernier@gmail.com", "Hugh", "Bernier", "Myanmar", "325-924-1877" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Alexandraborough", "EE20467", 4, "G327639", new DateTime(1974, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Brad.Corwin@gmail.com", "Brad", "Corwin", "Virgin Islands, U.S.", "(959) 955-0304 x2865", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Edna", "EE32411", 2, "G204161", new DateTime(1971, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Lionel.Funk22@yahoo.com", "Lionel", "Funk", "Gambia", "554-982-9096 x379", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Watsicaport", "EE35153", 2, "G310235", new DateTime(1992, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Clarence.VonRueden29@hotmail.com", "Clarence", "VonRueden", "Sao Tome and Principe", "752.793.1443" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jeromebury", "EE52330", 4, "G84394", new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jonathan_Bogisich44@yahoo.com", "Jonathan", "Bogisich", "Saint Pierre and Miquelon", "554-453-8996 x55777", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2309,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ahmedburgh", "EE57150", 4, "G333814", new DateTime(1969, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sharon.Collins2@yahoo.com", "Sharon", "Collins", "Andorra", "(353) 528-6655 x259" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2310,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Leif", "EE19052", 1, "G385421", new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Maurice.Hartmann@hotmail.com", "Maurice", "Hartmann", "Falkland Islands (Malvinas)", "834-977-4852", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2311,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stantonbury", "EE7022", 1, "G443116", new DateTime(1966, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Carlos.Rohan18@yahoo.com", "Carlos", "Rohan", "Sweden", "(298) 206-1033 x1279", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2312,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Noelhaven", "EE29354", "G511292", new DateTime(1952, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Pauline_Gulgowski77@gmail.com", "Pauline", "Gulgowski", "Australia", "(534) 588-1837 x70702" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2313,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Fletaton", "EE55585", 3, "G475627", new DateTime(1974, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Kyle.Cronin79@yahoo.com", "Kyle", "Cronin", "Antigua and Barbuda", "256-509-2264" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2314,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Tyreeburgh", "EE7668", "G574484", new DateTime(1993, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lila_Greenholt@hotmail.com", "Lila", "Greenholt", "New Caledonia", "833.582.1327", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2315,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Angusland", "EE54602", 1, "G207507", new DateTime(1971, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Eddie38@hotmail.com", "Eddie", "Medhurst", "Cambodia", "236-781-8083" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2316,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Carissaville", "EE22883", 3, "G4359", new DateTime(1994, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Sally55@gmail.com", "Sally", "O'Reilly", "Dominica", "1-482-249-8091 x12331" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Daxfurt", "EE6938", "G384158", new DateTime(1952, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dennis15@hotmail.com", "Dennis", "Dickinson", "Nigeria", "943-801-5038 x137", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kerlukehaven", "EE22536", 3, "G398522", new DateTime(1951, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Corey.Block@gmail.com", "Corey", "Block", "Niue", "(303) 772-2224 x81607" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2319,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Sigrid", "EE21638", 2, "G43221", new DateTime(1955, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Edith_Armstrong47@gmail.com", "Edith", "Armstrong", "Kazakhstan", "232-776-7348 x035" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2320,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jaquanton", "EE36295", "G385040", new DateTime(1951, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marian.Ryan53@gmail.com", "Marian", "Ryan", "Portugal", "(732) 544-0407 x185", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Daphnefort", "EE53491", 2, "G513682", new DateTime(1983, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Heather_Thompson@gmail.com", "Heather", "Thompson", "Suriname", "1-549-741-0998" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2322,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Camrynhaven", "EE52457", 2, "G592501", new DateTime(1957, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Rice@hotmail.com", "Paulette", "Rice", "Montserrat", "(883) 206-4103 x377" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2323,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hellerview", "EE23298", "G106857", new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lorenzo73@hotmail.com", "Lorenzo", "Carter", "Guatemala", "914.894.5678 x92265" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2324,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Donnaland", "EE3938", "G151367", new DateTime(1977, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Anita89@hotmail.com", "Anita", "Gusikowski", "Papua New Guinea", "294-367-2857", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2325,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Raymondville", "EE56030", "G126368", new DateTime(1975, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen75@yahoo.com", "Gretchen", "Bergstrom", "Jersey", "305.854.8803 x6870", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Octavia", "EE54831", 3, "G73933", new DateTime(1972, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Ramon.Waters@gmail.com", "Ramon", "Waters", "South Africa", "(343) 377-2564 x5077" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2327,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Assunta", "EE46431", 4, "G408329", new DateTime(1983, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Mabel.Will@yahoo.com", "Mabel", "Will", "Cambodia", "1-334-283-5896" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2328,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Newellborough", "EE40631", "G535362", new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ana95@hotmail.com", "Ana", "Kilback", "Cambodia", "1-525-929-9852 x589", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2329,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kariborough", "EE45089", 2, "G103191", new DateTime(1980, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jerome85@hotmail.com", "Jerome", "Schowalter", "Lithuania", "424-469-7673" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2330,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Arden", "EE42456", 1, "G320945", new DateTime(1962, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Tricia_Beer95@gmail.com", "Tricia", "Beer", "Congo", "694.838.0505", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2331,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ricefurt", "EE18518", "G361953", new DateTime(1983, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Edwin.Powlowski50@hotmail.com", "Edwin", "Powlowski", "India", "1-508-509-4410 x278", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2332,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Clarkshire", "EE38966", 2, "G254596", new DateTime(1985, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Hazel40@gmail.com", "Hazel", "Romaguera", "Mayotte", "(317) 284-8989 x96376", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2333,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Caseybury", "EE32379", "G88759", new DateTime(1954, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ellen_Kohler@gmail.com", "Ellen", "Kohler", "Vanuatu", "587.500.3229 x3001", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2334,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lilianeshire", "EE58613", 4, "G71246", new DateTime(1997, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Darrin58@gmail.com", "Darrin", "Mraz", "Azerbaijan", "253.524.0336 x2680" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2335,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Asia", "EE48350", 4, "G592739", new DateTime(1971, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jeanne_Durgan97@hotmail.com", "Jeanne", "Durgan", "Solomon Islands", "(522) 210-3516 x1330" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2336,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rodgertown", "EE29302", "G129085", new DateTime(1998, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ada_Haley12@gmail.com", "Ada", "Haley", "Faroe Islands", "931-440-4185 x27551", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Ottis", "EE9748", 3, "G542965", new DateTime(1989, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ginger_Bogan76@yahoo.com", "Ginger", "Bogan", "United States of America", "(291) 809-6043 x533", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2338,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Graysonstad", "EE5262", 2, "G591116", new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha3@gmail.com", "Tabitha", "Schmidt", "Thailand", "804-814-3073" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2339,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Carrieborough", "EE45354", 1, "G108597", new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Deborah_Kshlerin@yahoo.com", "Deborah", "Kshlerin", "French Southern Territories", "200.412.5836" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Simonisfurt", "EE17859", 3, "G469274", new DateTime(1985, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Tommie88@hotmail.com", "Tommie", "Rice", "Fiji", "1-202-677-1446 x599", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2341,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tobinfurt", "EE7075", 1, "G155568", new DateTime(1977, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bessie_Casper@hotmail.com", "Bessie", "Casper", "Antarctica (the territory South of 60 deg S)", "781-683-7313", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2342,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Stuart", "EE59989", 2, "G233384", new DateTime(1985, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Willie63@gmail.com", "Willie", "Hettinger", "Saint Helena", "673.383.0128 x0268" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Alva", "EE16837", 2, "G550788", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Danielle.Krajcik@yahoo.com", "Danielle", "Krajcik", "Djibouti", "405-426-6020 x40974", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lindhaven", "EE21345", "G303637", new DateTime(1973, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lynda77@gmail.com", "Lynda", "Russel", "Palau", "733-469-7719", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Izabella", "EE57602", "G479803", new DateTime(1993, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Kevin.Gulgowski85@yahoo.com", "Kevin", "Gulgowski", "Mexico", "831-407-7627" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Douglasshire", "EE48304", 1, "G124261", new DateTime(1970, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ron_West22@hotmail.com", "Ron", "West", "Belize", "(407) 721-4329", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Kadenmouth", "EE4677", 4, "G471591", new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Jan_Pacocha67@hotmail.com", "Jan", "Pacocha", "Taiwan", "(781) 719-6736 x3888" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Justicechester", "EE6025", "G292120", new DateTime(1970, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Helen82@yahoo.com", "Helen", "Von", "Puerto Rico", "(266) 600-3977 x7803", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2349,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Rachellechester", "EE51561", 1, "G454498", new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dana.Kilback18@hotmail.com", "Dana", "Kilback", "South Africa", "1-860-931-3919", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2350,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Curtisfurt", "EE25648", 4, "G485658", new DateTime(1986, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Cody_Goyette@gmail.com", "Cody", "Goyette", "Tunisia", "(489) 307-6284 x619", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2351,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Elmira", "EE6234", 3, "G352621", new DateTime(1975, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Doyle.Swaniawski@hotmail.com", "Doyle", "Swaniawski", "Luxembourg", "286.217.9447", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2352,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ziemannland", "EE1662", 1, "G332430", new DateTime(1984, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Marlene73@hotmail.com", "Marlene", "Steuber", "Barbados", "1-350-445-4878 x73255" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2353,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rempelville", "EE16534", 1, "G111718", new DateTime(1998, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lana92@yahoo.com", "Lana", "Labadie", "Cuba", "(205) 454-0400" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2354,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Godfreybury", "EE17254", 2, "G512134", new DateTime(2000, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Donnie99@gmail.com", "Donnie", "Kautzer", "Japan", "(309) 819-3345" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2355,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Virginiafurt", "EE8415", "G466339", new DateTime(1993, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Raquel.Gerhold@yahoo.com", "Raquel", "Gerhold", "Thailand", "993.983.4884" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2356,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Craigmouth", "EE2111", 2, "G408545", new DateTime(1964, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Michele12@yahoo.com", "Michele", "Nikolaus", "Yemen", "(511) 831-3658 x607" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2357,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schmelerstad", "EE47545", "G22256", new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Beverly87@gmail.com", "Beverly", "Koss", "Martinique", "299-985-1832" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Adrianna", "EE9483", "G195443", new DateTime(1966, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia.Kerluke11@gmail.com", "Cecelia", "Kerluke", "Cape Verde", "(878) 319-0133 x795", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2359,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Carriehaven", "EE27511", 4, "G316453", new DateTime(1977, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jasmine_Bailey@gmail.com", "Jasmine", "Bailey", "Saint Martin", "(366) 286-7083 x38496" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2360,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Elisabeth", "EE5143", 2, "G560932", new DateTime(1979, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ira70@gmail.com", "Ira", "Greenfelder", "Angola", "806-243-3486 x928", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2361,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Ruby", "EE39955", 3, "G113282", new DateTime(2000, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Russell.Jast57@hotmail.com", "Russell", "Jast", "Nigeria", "672.984.6615 x2101" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2362,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Buckstad", "EE7543", 4, "G148410", new DateTime(1962, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Ronnie86@yahoo.com", "Ronnie", "Boyle", "Burundi", "(542) 642-7876 x19954", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Davonville", "EE15107", "G261341", new DateTime(1962, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Valerie66@yahoo.com", "Valerie", "Funk", "Falkland Islands (Malvinas)", "432.508.7744 x0492", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Samaraberg", "EE59087", 1, "G546038", new DateTime(1969, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Lucia63@yahoo.com", "Lucia", "Daugherty", "Georgia", "1-987-212-8141 x837", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Patrick", "EE18546", 1, "G77997", new DateTime(1973, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine88@hotmail.com", "Jermaine", "White", "Japan", "(298) 456-9875 x645" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Reillyburgh", "EE52854", 4, "G434356", new DateTime(1976, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen_Durgan@yahoo.com", "Gretchen", "Durgan", "Cyprus", "1-940-800-6637 x65861", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Miguelfurt", "EE46117", 2, "G154511", new DateTime(1962, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Roy.Bernier@gmail.com", "Roy", "Bernier", "Iraq", "210.988.3759 x508" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dillanbury", "EE24005", 2, "G203583", new DateTime(1974, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Conrad_Herman@gmail.com", "Conrad", "Herman", "French Southern Territories", "1-909-415-0075", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Rashawn", "EE24865", 1, "G516903", new DateTime(1977, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Vincent_Hickle@yahoo.com", "Vincent", "Hickle", "Iran", "(753) 911-4608 x326", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Rainaberg", "EE44315", 4, "G553150", new DateTime(1967, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jennie67@hotmail.com", "Jennie", "Erdman", "Jordan", "(548) 217-9529" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Terrencehaven", "EE43777", "G340890", new DateTime(1958, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Alvin_Walsh35@gmail.com", "Alvin", "Walsh", "Svalbard & Jan Mayen Islands", "(976) 960-4941 x884" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2372,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Verdaborough", "EE17297", 2, "G472149", new DateTime(1983, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Erica31@yahoo.com", "Erica", "Dach", "San Marino", "966-849-0021 x90955", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2373,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Birdieborough", "EE15419", 3, "G56528", new DateTime(1982, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Judy_Reichel@gmail.com", "Judy", "Reichel", "Tajikistan", "654-597-6338 x765" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Funkburgh", "EE43843", 2, "G200287", new DateTime(1985, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Marcia.Bartell22@gmail.com", "Marcia", "Bartell", "Estonia", "(571) 855-1168 x393" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Welchview", "EE53725", "G381725", new DateTime(1992, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jared92@yahoo.com", "Jared", "Goldner", "Austria", "257.253.0175 x4970" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2376,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abernathymouth", "EE53347", 4, "G5286", new DateTime(1999, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "John_Effertz25@yahoo.com", "John", "Effertz", "Switzerland", "533.467.8743 x0172", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2377,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beierstad", "EE31680", "G257181", new DateTime(1961, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Benjamin.Greenholt@yahoo.com", "Benjamin", "Greenholt", "Latvia", "405-438-5486" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2378,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Dariana", "EE19478", 2, "G497508", new DateTime(1953, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ana.Crona@gmail.com", "Ana", "Crona", "Saint Barthelemy", "(788) 485-1250 x4428", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2379,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jaqueline", "EE48234", 3, "G433850", new DateTime(1983, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Corey.Spencer@hotmail.com", "Corey", "Spencer", "Iraq", "1-386-978-3957" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Curtisville", "EE58352", 3, "G321012", new DateTime(1956, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Rosa.King27@yahoo.com", "Rosa", "King", "United States of America", "(646) 507-7180 x768", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2381,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nicolasview", "EE22758", 1, "G541691", new DateTime(1969, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "Kellie_Shields43@gmail.com", "Kellie", "Shields", "Burkina Faso", "(608) 541-5102", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2382,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rozellabury", "EE41207", 1, "G66838", new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Derek_Stamm87@gmail.com", "Derek", "Stamm", "Madagascar", "895.789.5028", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Brody", "EE33882", 2, "G181819", new DateTime(1974, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lola.Luettgen@gmail.com", "Lola", "Luettgen", "Burkina Faso", "728.819.4587", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Abshirestad", "EE2567", 4, "G294564", new DateTime(1977, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Annie51@hotmail.com", "Annie", "Emard", "Algeria", "948-629-7635" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jeremieberg", "EE40302", "G550039", new DateTime(1994, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dallas_Prosacco63@yahoo.com", "Dallas", "Prosacco", "Jamaica", "668-401-7993 x72036", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rosariomouth", "EE6777", 3, "G536184", new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Andrea.Lesch@yahoo.com", "Andrea", "Lesch", "Kiribati", "(698) 428-2633", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "D'Amorehaven", "EE11662", 3, "G16544", new DateTime(1958, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Travis.Swift@hotmail.com", "Travis", "Swift", "Mongolia", "1-489-759-6614 x145" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Theodora", "EE19853", 4, "G326015", new DateTime(1983, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie.Daniel@hotmail.com", "Marjorie", "Daniel", "Papua New Guinea", "1-925-269-3639", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2389,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kreigermouth", "EE53785", 2, "G514170", new DateTime(1960, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred_Daugherty68@hotmail.com", "Wilfred", "Daugherty", "Paraguay", "446-878-5504 x59137", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2390,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Werner", "EE24488", 4, "G569783", new DateTime(1986, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Susie_Aufderhar80@yahoo.com", "Susie", "Aufderhar", "Papua New Guinea", "867-426-3764", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2391,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bednarbury", "EE5898", 2, "G343343", new DateTime(1965, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Gwendolyn39@gmail.com", "Gwendolyn", "Kassulke", "Pitcairn Islands", "492.407.2674", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2392,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Cydneymouth", "EE47228", 1, "G561328", new DateTime(1984, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Susan_Romaguera50@yahoo.com", "Susan", "Romaguera", "Anguilla", "977.348.1879 x508" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Adrienville", "EE21707", "G467578", new DateTime(1954, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Pablo_Gaylord@hotmail.com", "Pablo", "Gaylord", "Iran", "(357) 936-7259 x403", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2394,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Amparoshire", "EE12598", 2, "G81452", new DateTime(1969, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Saul.Mosciski@yahoo.com", "Saul", "Mosciski", "Brunei Darussalam", "1-385-963-9568", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2395,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Groverport", "EE31993", 3, "G469055", new DateTime(1991, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Terri14@hotmail.com", "Terri", "Yost", "India", "509.645.8603 x16946" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2396,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Percivalborough", "EE40201", 2, "G29289", new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sally.Cronin@gmail.com", "Sally", "Cronin", "Uganda", "822.423.5350", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2397,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Naomitown", "EE9894", 1, "G43587", new DateTime(1953, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Otis22@yahoo.com", "Otis", "Jones", "Liechtenstein", "(802) 451-4616" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Steuberfurt", "EE47704", 3, "G275053", new DateTime(1996, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Sarah49@hotmail.com", "Sarah", "Schuster", "Brunei Darussalam", "378.482.5922" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Danialville", "EE47406", 4, "G82393", new DateTime(1969, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Kent.Gislason10@yahoo.com", "Kent", "Gislason", "Sweden", "(566) 674-3518 x66964" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ashamouth", "EE9413", 4, "G78591", new DateTime(1954, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Pete_Schamberger@yahoo.com", "Pete", "Schamberger", "Saint Martin", "988-296-4543" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tedbury", "EE9654", 4, "G173385", new DateTime(1978, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Lorena_Dietrich0@hotmail.com", "Lorena", "Dietrich", "Syrian Arab Republic", "812-801-3880 x51765" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Herminaville", "EE48591", 4, "G263548", new DateTime(1965, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Joan.Beatty58@yahoo.com", "Joan", "Beatty", "Isle of Man", "1-708-460-2896", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2403,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Daytontown", "EE21911", 4, "G104963", new DateTime(1957, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Tom_Harber15@yahoo.com", "Tom", "Harber", "Ecuador", "1-631-295-9106", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2404,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Welchbury", "EE46134", 2, "G210780", new DateTime(1972, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lee_Gleichner12@gmail.com", "Lee", "Gleichner", "Holy See (Vatican City State)", "272-762-2946 x2832", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Blickfurt", "EE49660", 3, "G117308", new DateTime(1972, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Lynch@hotmail.com", "Mildred", "Lynch", "Romania", "(761) 282-1573", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ramonamouth", "EE53733", 2, "G486045", new DateTime(1979, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Hubert.Dietrich@hotmail.com", "Hubert", "Dietrich", "Niger", "327.840.8121 x1479", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2407,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Kelton", "EE28715", 2, "G283761", new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Omar27@gmail.com", "Omar", "Kohler", "Vanuatu", "(575) 287-9613 x951", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2408,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ratketon", "EE30002", "G9220", new DateTime(1966, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ross15@hotmail.com", "Ross", "Rau", "Uzbekistan", "283.576.8704 x1341", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hayesbury", "EE12424", 2, "G471807", new DateTime(1974, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tyrone.Hermann22@gmail.com", "Tyrone", "Hermann", "Democratic People's Republic of Korea", "(322) 552-8187 x68207" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2410,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Cooper", "EE36488", 4, "G549570", new DateTime(1994, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Pauline_Herman@yahoo.com", "Pauline", "Herman", "India", "1-689-519-3751 x8253", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2411,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gradyport", "EE52346", "G214602", new DateTime(1952, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Marvin24@hotmail.com", "Marvin", "Halvorson", "Andorra", "364.394.2279 x81992" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Florencio", "EE54005", "G428686", new DateTime(1994, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lindsay.Schowalter83@hotmail.com", "Lindsay", "Schowalter", "Iraq", "469.938.3397 x95167" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2413,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kossbury", "EE50381", 1, "G160118", new DateTime(1993, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rose.Ledner@yahoo.com", "Rose", "Ledner", "Maldives", "(697) 707-8862 x449" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2414,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Joana", "EE12810", 4, "G2951", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Darrell.Dicki@hotmail.com", "Darrell", "Dicki", "Angola", "1-342-848-1351 x3218", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Kaseymouth", "EE24110", 3, "G324060", new DateTime(1997, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Antoinette.Harber6@yahoo.com", "Antoinette", "Harber", "Afghanistan", "1-964-223-7800 x26396", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Tamiaberg", "EE26327", 4, "G497478", new DateTime(1975, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Kelvin_Leannon2@gmail.com", "Kelvin", "Leannon", "El Salvador", "(808) 226-5886 x65339" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Harrisfort", "EE35338", 4, "G37140", new DateTime(1999, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bryan.Hayes53@gmail.com", "Bryan", "Hayes", "Mozambique", "1-390-718-2219 x32978", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fishershire", "EE24703", 4, "G303529", new DateTime(1996, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ben.Satterfield@yahoo.com", "Ben", "Satterfield", "Armenia", "(844) 306-1241 x8928" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Tillman", "EE32998", "G86836", new DateTime(2001, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kay.Mitchell82@yahoo.com", "Kay", "Mitchell", "Netherlands Antilles", "(216) 359-9180", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Vestafurt", "EE52391", "G550901", new DateTime(1964, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Beatrice_Schiller77@yahoo.com", "Beatrice", "Schiller", "Iran", "1-303-283-1514 x0482", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Otiliaburgh", "EE43730", 1, "G274516", new DateTime(1951, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Clark.Pacocha@hotmail.com", "Clark", "Pacocha", "Burkina Faso", "(618) 567-0392", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Dale", "EE343", 4, "G517487", new DateTime(1982, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Gregg.Pollich18@yahoo.com", "Gregg", "Pollich", "Mauritania", "1-516-318-6214 x435" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jonatanfort", "EE11170", 4, "G212833", new DateTime(1977, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Hugh32@yahoo.com", "Hugh", "Schimmel", "Nauru", "324-216-8651 x661" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2424,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Francescatown", "EE44310", "G100929", new DateTime(1978, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Hugh64@gmail.com", "Hugh", "Schneider", "Haiti", "(807) 917-9878", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2425,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Robertsstad", "EE53250", 2, "G263218", new DateTime(1968, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jana.Grady@gmail.com", "Jana", "Grady", "Nepal", "1-625-679-9118 x99648", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2426,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schulistville", "EE31374", 3, "G535032", new DateTime(1980, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Randolph.Schowalter@gmail.com", "Randolph", "Schowalter", "Antigua and Barbuda", "1-617-632-3185 x87502" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2427,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ornhaven", "EE8490", 2, "G83767", new DateTime(1964, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Gene.Wolf2@gmail.com", "Gene", "Wolf", "Denmark", "1-939-765-0034 x929", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2428,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Keanu", "EE45700", 2, "G193148", new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Garry73@hotmail.com", "Garry", "Ferry", "Svalbard & Jan Mayen Islands", "1-836-466-7118 x0299" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Garettburgh", "EE2342", "G214016", new DateTime(1972, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lillian16@gmail.com", "Lillian", "Schimmel", "Israel", "851.638.1592 x709", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stammstad", "EE28636", 3, "G478729", new DateTime(1988, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hope.Stroman@gmail.com", "Hope", "Stroman", "Honduras", "(513) 255-1250 x06446", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2431,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Nathanielberg", "EE32210", 3, "G90421", new DateTime(1977, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Elias81@yahoo.com", "Elias", "Towne", "Guernsey", "(469) 852-9631", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2432,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Skylaview", "EE3561", 1, "G542521", new DateTime(2001, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Orville8@gmail.com", "Orville", "Kilback", "Malawi", "1-567-930-7958" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Leolastad", "EE47264", 1, "G274152", new DateTime(1967, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Ricardo_McClure@gmail.com", "Ricardo", "McClure", "Italy", "915-797-2522", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Edshire", "EE59336", "G576978", new DateTime(1996, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ethel_Smitham@gmail.com", "Ethel", "Smitham", "Egypt", "(203) 331-0579 x453" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Maritza", "EE49969", 4, "G65617", new DateTime(1965, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Andrea.Veum59@yahoo.com", "Andrea", "Veum", "Brazil", "567.656.1872 x040", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2436,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Donnellyberg", "EE54803", 2, "G81716", new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Cecil.Emmerich14@yahoo.com", "Cecil", "Emmerich", "Sweden", "610.461.3063 x5059", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2437,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kuvalisbury", "EE22914", 2, "G375837", new DateTime(1998, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dallas35@gmail.com", "Dallas", "VonRueden", "Germany", "619.593.5546 x829", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2438,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cristborough", "EE35360", 2, "G61468", new DateTime(1958, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jaime41@gmail.com", "Jaime", "Jacobson", "Benin", "537.634.4012", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2439,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Homenickberg", "EE43200", "G498482", new DateTime(1982, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kim67@yahoo.com", "Kim", "Kuhlman", "Nicaragua", "920.387.2408 x51483", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rosenbaumborough", "EE7912", 2, "G338843", new DateTime(1972, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "William_Jast@yahoo.com", "William", "Jast", "American Samoa", "945-935-8703 x14870" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "North Elaina", "EE41893", 1, "G136160", new DateTime(1997, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Merle_Heaney69@hotmail.com", "Merle", "Heaney", "459-713-6798 x31355", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kleinhaven", "EE7355", "G489384", new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Craig.Smith@hotmail.com", "Craig", "Smith", "Democratic People's Republic of Korea", "(444) 571-3634 x009" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2443,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Deloresview", "EE9324", 4, "G317469", new DateTime(1994, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Carol.Rutherford@gmail.com", "Carol", "Rutherford", "Zimbabwe", "515-761-8401" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2444,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Skilesmouth", "EE29846", 2, "G529268", new DateTime(1966, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lillie_Sawayn60@gmail.com", "Lillie", "Sawayn", "French Guiana", "203.472.3257 x99391" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jewellbury", "EE12377", "G463311", new DateTime(1979, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Frederick_Ullrich@yahoo.com", "Frederick", "Ullrich", "United States of America", "552.805.4491 x5425" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2446,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bartonshire", "EE30618", 3, "G199611", new DateTime(1973, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Eva_Hintz86@hotmail.com", "Eva", "Hintz", "New Zealand", "(975) 488-1789", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2447,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Newellmouth", "EE47803", 3, "G354066", new DateTime(1956, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Carmen_Graham@gmail.com", "Carmen", "Graham", "Brazil", "(600) 484-9659 x821" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2448,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Vonmouth", "EE23168", 2, "G62756", new DateTime(1965, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jose.Walter@gmail.com", "Jose", "Walter", "Venezuela", "1-797-325-7781" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2449,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Mossieside", "EE26142", "G284230", new DateTime(1986, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Delbert_Wyman89@hotmail.com", "Delbert", "Wyman", "Malawi", "(735) 942-5331", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Eleanora", "EE35415", "G376514", new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tricia.Wolf75@gmail.com", "Tricia", "Wolf", "Northern Mariana Islands", "454-832-0886 x73904" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Sunnyberg", "EE53342", 4, "G208975", new DateTime(1969, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Renee38@yahoo.com", "Renee", "O'Kon", "British Indian Ocean Territory (Chagos Archipelago)", "963.514.6236 x3900", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2452,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Nickfurt", "EE31668", 2, "G60973", new DateTime(1965, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Nick89@yahoo.com", "Nick", "Quitzon", "Uganda", "464.964.5912 x47549" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2453,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Collinstown", "EE25352", 3, "G300307", new DateTime(1967, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Harriet.Greenholt@yahoo.com", "Harriet", "Greenholt", "Argentina", "(396) 292-1523" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Bradfordville", "EE42864", "G425723", new DateTime(1968, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Connie.Streich@hotmail.com", "Connie", "Streich", "Hungary", "433-453-3144 x759" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Megane", "EE8223", 2, "G39010", new DateTime(1980, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Janie28@gmail.com", "Janie", "Cremin", "China", "323-426-3524 x323", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2456,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Heath", "EE25414", 2, "G586118", new DateTime(1994, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Eula_Gutmann@yahoo.com", "Eula", "Gutmann", "Togo", "509-503-3580", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2457,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Magnoliamouth", "EE49305", 1, "G336840", new DateTime(1965, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Monica.Weissnat89@yahoo.com", "Monica", "Weissnat", "United States Minor Outlying Islands", "758-563-8012 x08018" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2458,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Valerieland", "EE57867", "G308609", new DateTime(1981, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Elijah.Hudson@yahoo.com", "Elijah", "Hudson", "New Caledonia", "241-908-9022 x6865", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Kathryn", "EE40181", "G466480", new DateTime(1988, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Emily_Rath@gmail.com", "Emily", "Rath", "Aruba", "348.614.8337 x915", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2460,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Bobbieshire", "EE27777", 1, "G235742", new DateTime(1981, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Malcolm79@yahoo.com", "Malcolm", "Kautzer", "Kuwait", "1-740-624-1329" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2461,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Estelview", "EE43045", 4, "G184922", new DateTime(1955, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Frankie_Powlowski@yahoo.com", "Frankie", "Powlowski", "Saint Martin", "1-609-370-0169", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2462,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Camron", "EE6833", 3, "G116360", new DateTime(1957, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Jackie_Spencer@yahoo.com", "Jackie", "Spencer", "Equatorial Guinea", "499.821.9797 x530" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wunschland", "EE24050", "G546412", new DateTime(1996, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dawn81@hotmail.com", "Dawn", "Cole", "Cocos (Keeling) Islands", "(992) 856-4461 x016" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jarrettborough", "EE41314", "G33435", new DateTime(1985, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Floyd_Ratke@yahoo.com", "Floyd", "Ratke", "Bosnia and Herzegovina", "968-603-1945", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Guyview", "EE17413", 2, "G115975", new DateTime(1958, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Clyde.Durgan@yahoo.com", "Clyde", "Durgan", "Greenland", "(847) 614-9719 x76745" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vicentamouth", "EE22637", 3, "G81400", new DateTime(1995, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Keith_Abbott@hotmail.com", "Keith", "Abbott", "Saint Kitts and Nevis", "574.673.7514", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Rhea", "EE21089", 2, "G522082", new DateTime(1976, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Leonard_Johns87@yahoo.com", "Leonard", "Johns", "Burkina Faso", "(785) 979-7211 x9046", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rueckerbury", "EE4653", 1, "G349086", new DateTime(1967, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Donna.Gutmann47@yahoo.com", "Donna", "Gutmann", "Bolivia", "(928) 644-1038" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2469,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Amari", "EE17409", 3, "G46440", new DateTime(1982, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Moses59@hotmail.com", "Moses", "Heller", "Ukraine", "(562) 222-1448 x0004", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2470,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Biankafurt", "EE48347", 3, "G564325", new DateTime(2000, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Rickey43@hotmail.com", "Rickey", "Pfannerstill", "Slovakia (Slovak Republic)", "(310) 483-0206 x01713" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2471,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Seanstad", "EE45034", 1, "G468636", new DateTime(1986, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Sarah5@yahoo.com", "Sarah", "Romaguera", "Haiti", "748-682-8653", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2472,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Samson", "EE46771", "G473160", new DateTime(1986, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lamar_Nikolaus@hotmail.com", "Lamar", "Nikolaus", "Spain", "615.817.2357 x83065" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2473,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Paucekhaven", "EE36461", 3, "G143322", new DateTime(1959, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Brian_Gutmann77@gmail.com", "Brian", "Gutmann", "Falkland Islands (Malvinas)", "615.297.0033", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2474,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Natalia", "EE41115", 3, "G255669", new DateTime(1971, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kyle35@hotmail.com", "Kyle", "Ratke", "Australia", "(563) 857-7223 x884" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2475,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ziemannside", "EE28379", 2, "G36363", new DateTime(1998, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne54@yahoo.com", "Adrienne", "Reichel", "Georgia", "1-446-235-8571 x8714" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2476,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Nia", "EE21850", "G26132", new DateTime(1959, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Melinda.Herman71@yahoo.com", "Melinda", "Herman", "Saint Martin", "229.829.0752" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2477,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Patience", "EE45113", 3, "G220033", new DateTime(1971, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jan_Jakubowski@gmail.com", "Jan", "Jakubowski", "Antarctica (the territory South of 60 deg S)", "(576) 287-0375 x0373", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2478,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hanemouth", "EE39270", 4, "G581359", new DateTime(1953, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sarah_Hirthe@yahoo.com", "Sarah", "Hirthe", "Sierra Leone", "1-898-682-6948", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2479,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Greenfelderfurt", "EE29374", 1, "G355312", new DateTime(1984, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Brent.Hauck@yahoo.com", "Brent", "Hauck", "Northern Mariana Islands", "913.308.4400 x565", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2480,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Brielle", "EE50406", "G533095", new DateTime(1993, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Grant3@hotmail.com", "Grant", "Dietrich", "Saint Vincent and the Grenadines", "1-727-951-6654 x974" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Doyleborough", "EE27371", 3, "G42355", new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ronald.Koch@yahoo.com", "Ronald", "Koch", "Sierra Leone", "456-564-7647 x4286", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2482,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jayne", "EE50433", 1, "G166995", new DateTime(1954, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kelly15@yahoo.com", "Kelly", "Pacocha", "Gabon", "516.739.9176 x740" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2483,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Sedrick", "EE1078", 2, "G166450", new DateTime(1979, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Donald_Baumbach56@yahoo.com", "Donald", "Baumbach", "Antigua and Barbuda", "793.377.7006 x5636", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2484,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Maximo", "EE33409", "G300381", new DateTime(1970, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Diana.Kreiger10@yahoo.com", "Diana", "Kreiger", "Switzerland", "764-577-3069" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2485,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Sheila", "EE52355", 2, "G239437", new DateTime(1965, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ramona15@yahoo.com", "Ramona", "Murray", "Cayman Islands", "1-785-602-1297 x9077" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2486,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Alfredoside", "EE56246", 1, "G58600", new DateTime(1983, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Doug.Bradtke13@yahoo.com", "Doug", "Bradtke", "French Southern Territories", "508-493-9676", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2487,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Samantaside", "EE49669", 4, "G194576", new DateTime(1973, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jacquelyn.McGlynn88@hotmail.com", "Jacquelyn", "McGlynn", "Lebanon", "1-800-992-8102" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2488,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hankmouth", "EE32723", 1, "G52616", new DateTime(1962, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kelly.Lowe@gmail.com", "Kelly", "Lowe", "Russian Federation", "1-430-872-2891", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2489,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jasminhaven", "EE41267", 4, "G344731", new DateTime(1985, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Howard_Kihn15@gmail.com", "Howard", "Kihn", "Palau", "422-693-0464 x9588", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2490,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kuvalisborough", "EE32684", 4, "G358164", new DateTime(1973, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jean.Nikolaus@gmail.com", "Jean", "Nikolaus", "Svalbard & Jan Mayen Islands", "395-238-2588 x60581" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2491,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gislasonview", "EE55679", 2, "G49980", new DateTime(1987, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marie40@yahoo.com", "Marie", "Waelchi", "Latvia", "440-590-8152", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2492,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jettmouth", "EE21857", "G71752", new DateTime(1989, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Wilson.Romaguera@hotmail.com", "Wilson", "Romaguera", "France", "684-421-8346" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2493,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Chadshire", "EE42517", 1, "G341302", new DateTime(1998, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Gayle_Cremin74@gmail.com", "Gayle", "Cremin", "Saint Kitts and Nevis", "1-997-472-4125 x1793" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2494,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Arianna", "EE40885", 2, "G180223", new DateTime(1971, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie9@yahoo.com", "Bobbie", "Wyman", "Macao", "724.424.2797 x436", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Alexishaven", "EE4799", 1, "G95701", new DateTime(1962, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Marion.Bartell19@gmail.com", "Marion", "Bartell", "Estonia", "1-433-862-6561", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Luna", "EE35888", 2, "G411935", new DateTime(1967, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Archie_Becker@yahoo.com", "Archie", "Becker", "Wallis and Futuna", "1-400-939-2889", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Scarlettville", "EE8152", "G240392", new DateTime(1973, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "William72@hotmail.com", "William", "Goodwin", "Virgin Islands, U.S.", "(624) 561-4926", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Koreyside", "EE48925", "G216257", new DateTime(1998, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Dale.Stroman@yahoo.com", "Dale", "Stroman", "Sudan", "1-976-882-4388", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2499,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Treva", "EE32311", 1, "G564603", new DateTime(1975, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Esther_Cassin@hotmail.com", "Esther", "Cassin", "Greenland", "1-348-744-7772 x713", "Female" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "withdrawal Architect THX", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Curve multi-byte Manager", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Supervisor Metal back-end", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Handcrafted Wooden Pants Toys Tanzanian Shilling", 23 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Ergonomic bus channels", 4 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Reactive Generic Mobility", 15 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "paradigm expedite Granite", 23 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "sky blue Senior Persistent", 3 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Gorgeous bypass bottom-line", 18 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "green Investment Account Associate", 4 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "action-items Virtual Forge", 21 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "orange invoice analyzer", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Grove Panama Analyst", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Health, Movies & Sports Jamaica Cotton", 8 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "National Plastic RSS", 4 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Optimization digital Soft", 25 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "payment Port International", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "South Carolina application Tala", 13 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Garden & Home Cambridgeshire Savings Account", 21 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "payment magenta B2B", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "quantify Web override", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "bypass Iceland Krona blue", 25 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "ivory Rapids orchestration", 23 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "compressing Fantastic Soft Pizza Lodge", 23 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 23, "0" });

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
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 7, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 13 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 14 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 13 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 5 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 17, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "A", 12 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 10, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 6 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "A", 24 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 21, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 17, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 9, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 21, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 22, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 16, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 2, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 14, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 4 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 23, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 5, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 3, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 25,
                column: "moduleId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Greg.Krajcik@yahoo.com", "JBOD", "Krajcik", "Greg" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ada3@gmail.com", "application", "Roberts", "Ada" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Faye93@gmail.com", "Personal Loan Account", "Greenfelder", "Faye" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Alexander_Heathcote@yahoo.com", "Factors", "Heathcote", "Alexander" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Herman_Casper16@gmail.com", "withdrawal", "Casper", "Herman" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Kayla18@hotmail.com", "Awesome", "Beer", "Kayla" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Jamie.Hoppe@yahoo.com", "Rubber", "Hoppe", "Jamie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Kelvin20@hotmail.com", "Handcrafted", "Ebert", "Kelvin" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Helen37@yahoo.com", "Metal", "Brekke", "Helen" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Mandy.Bernier46@yahoo.com", "navigating", "Bernier", "Mandy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Valerie95@hotmail.com", "panel", "O'Reilly", "Valerie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Joann.Johns@hotmail.com", "monitor", "Johns", "Joann" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Juan_Jacobs@gmail.com", "Home Loan Account", "Jacobs", "Juan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Kerry41@hotmail.com", "Rwanda Franc", "Hackett", "Kerry" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Christy88@gmail.com", "Ouguiya", "Crooks", "Christy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Sheldon.Welch16@hotmail.com", "Future", "Welch", "Sheldon" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Frances.Miller@hotmail.com", "Buckinghamshire", "Miller", "Frances" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Gustavo_Raynor56@yahoo.com", "ROI", "Raynor", "Gustavo" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Ada_Flatley86@yahoo.com", "Accounts", "Flatley", "Ada" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Brenda89@gmail.com", "Pennsylvania", "Reynolds", "Brenda" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Oscar75@yahoo.com", "Licensed Concrete Pizza", "Pfannerstill", "Oscar" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Samuel.Kuphal@hotmail.com", "Bulgarian Lev", "Kuphal", "Samuel" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Guadalupe.Leannon@gmail.com", "silver", "Leannon", "Guadalupe" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Julian_Lindgren86@hotmail.com", "Practical Soft Salad", "Lindgren", "Julian" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Loretta.Steuber@gmail.com", "program", "Steuber", "Loretta" });

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 2,
                column: "filiereId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 3,
                column: "filiereId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 4,
                column: "filiereId",
                value: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Professeurs_professeurId",
                table: "Modules",
                column: "professeurId",
                principalTable: "Professeurs",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Professeurs_professeurId",
                table: "Modules");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 680, DateTimeKind.Local).AddTicks(4677), 2477, "Releve de note" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2758), 2072 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2857), 2344 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2878), 2447 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 52, 5, 681, DateTimeKind.Local).AddTicks(2896), 2449, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Trisha", "EE58199", 1, "G5272", new DateTime(1985, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Roy.Smitham5@hotmail.com", "Roy", "Smitham", "Georgia", "310-353-9068" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Denesikburgh", "EE20213", "G535883", new DateTime(1980, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ramiro20@yahoo.com", "Ramiro", "Nicolas", "Venezuela", "625-770-3581" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Leifchester", "EE44609", "G62648", new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Diana_Kris61@gmail.com", "Diana", "Kris", "Grenada", "908-364-9205 x313", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ferryberg", "EE55918", 3, "G295863", new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Charlie34@yahoo.com", "Charlie", "Breitenberg", "Kenya", "1-751-270-8278 x2796", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kesslerfurt", "EE12909", 3, "G498703", new DateTime(1990, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marta_Bogisich@yahoo.com", "Marta", "Bogisich", "Chad", "952.255.8553 x6756", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Moshe", "EE29629", "G207425", new DateTime(1994, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Christina_Wilkinson53@gmail.com", "Christina", "Wilkinson", "Mongolia", "(602) 331-5712 x7109", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Gregorymouth", "EE52369", "G248402", new DateTime(1970, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo_Mertz@yahoo.com", "Guillermo", "Mertz", "Malawi", "(472) 955-7428" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Joshuafurt", "EE16252", 3, "G31065", new DateTime(1970, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sheila_Witting47@hotmail.com", "Sheila", "Witting", "Brunei Darussalam", "(825) 793-5512", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Carolynville", "EE58659", "G50658", new DateTime(1963, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sue_Grant30@yahoo.com", "Sue", "Grant", "Japan", "1-979-816-7806 x66522", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kesslertown", "EE47883", 3, "G378758", new DateTime(1956, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Fahey@yahoo.com", "Leroy", "Fahey", "United States Minor Outlying Islands", "644-269-3488 x420" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Brendan", "EE38433", "G167246", new DateTime(1995, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Evelyn.Haag61@gmail.com", "Evelyn", "Haag", "Kyrgyz Republic", "1-227-517-1256 x30258" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nedra", "EE8981", "G572008", new DateTime(1982, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Robin_Abshire@gmail.com", "Robin", "Abshire", "Qatar", "(256) 606-7989 x287", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mya", "EE21738", 2, "G174995", new DateTime(1969, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Hope24@gmail.com", "Hope", "Schiller", "Portugal", "423.908.8588 x075" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beierport", "EE13957", 1, "G71149", new DateTime(1962, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Luz_Stracke@gmail.com", "Luz", "Stracke", "United States Minor Outlying Islands", "403-386-0293" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nicomouth", "EE36995", 4, "G475976", new DateTime(1954, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Maryann74@hotmail.com", "Maryann", "Carter", "Panama", "(974) 495-0965 x9479" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Gerryton", "EE44651", 1, "G209799", new DateTime(1959, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Irene_Hyatt93@hotmail.com", "Irene", "Hyatt", "Netherlands Antilles", "443.909.1752" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Harrisonstad", "EE5154", 4, "G465079", new DateTime(1951, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lana.Christiansen@yahoo.com", "Lana", "Christiansen", "Panama", "1-256-960-2889", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Noahville", "EE26358", 2, "G82337", new DateTime(1970, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Leroy57@hotmail.com", "Leroy", "Walter", "Angola", "644.871.5435", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Darbyhaven", "EE59742", 2, "G23808", new DateTime(1993, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Paul49@gmail.com", "Paul", "Ratke", "Finland", "360.466.2297" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jaronstad", "EE33634", 1, "G376937", new DateTime(1999, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Seth_Mayer@gmail.com", "Seth", "Mayer", "Poland", "(825) 839-5046 x5170", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cristophertown", "EE9209", 3, "G153733", new DateTime(1956, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kristi8@yahoo.com", "Kristi", "O'Keefe", "Tuvalu", "411.976.1838" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobibury", "EE59080", 1, "G580236", new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Anthony_Kreiger@yahoo.com", "Anthony", "Kreiger", "Tanzania", "1-356-236-5189" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Brandyn", "EE12162", 2, "G520884", new DateTime(1980, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Margie.Effertz5@gmail.com", "Margie", "Effertz", "Netherlands Antilles", "389.565.2278", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Tess", "EE12963", 1, "G592029", new DateTime(1973, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas26@gmail.com", "Nicolas", "Yost", "Bolivia", "304.314.7553" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Christian", "EE48202", "G178899", new DateTime(1976, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Chelsea99@gmail.com", "Chelsea", "Durgan", "Guyana", "(472) 767-4735 x78034", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Williamsonmouth", "EE29710", 4, "G277673", new DateTime(1963, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Loren.Quigley@yahoo.com", "Loren", "Quigley", "Micronesia", "353.925.7949 x6300" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Camillaberg", "EE31869", 4, "G508161", new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "April73@hotmail.com", "April", "O'Keefe", "Svalbard & Jan Mayen Islands", "1-405-256-2725 x33108", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Naderbury", "EE28734", 3, "G234022", new DateTime(1985, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Angie.Will18@yahoo.com", "Angie", "Will", "Bermuda", "1-316-539-0635 x39326" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Coltbury", "EE459", 4, "G25124", new DateTime(1979, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lena.Walter86@hotmail.com", "Lena", "Walter", "Slovenia", "1-658-857-3023 x3706" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Teaganfort", "EE2542", 2, "G430687", new DateTime(1980, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Marcus68@gmail.com", "Marcus", "Romaguera", "French Polynesia", "1-364-567-3109 x95555", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ankundingview", "EE12319", 2, "G352892", new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Alfonso.Ondricka81@yahoo.com", "Alfonso", "Ondricka", "Turkey", "1-214-750-5508 x135" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Kaitlyn", "EE30262", "G28296", new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Clay7@hotmail.com", "Clay", "Predovic", "Myanmar", "(268) 678-0005 x9968", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stracketown", "EE57897", 1, "G75316", new DateTime(1985, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Alexandra22@gmail.com", "Alexandra", "Jacobi", "Croatia", "447.255.7345", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Lourdes", "EE16417", 3, "G483898", new DateTime(1974, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kristi.Heathcote@hotmail.com", "Kristi", "Heathcote", "Mali", "1-828-296-3234", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zenafort", "EE4219", 1, "G391614", new DateTime(1953, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Hattie82@gmail.com", "Hattie", "Buckridge", "Israel", "1-337-794-1126 x838", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Eltaton", "EE9116", 4, "G559432", new DateTime(1980, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Misty_Paucek89@yahoo.com", "Misty", "Paucek", "Spain", "1-840-848-9005" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Emelieside", "EE10473", 3, "G94229", new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bob.Lemke@hotmail.com", "Bob", "Lemke", "Norway", "741-583-3712 x54011" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Casandramouth", "EE9738", 3, "G212023", new DateTime(1973, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Janie58@hotmail.com", "Janie", "Jacobi", "Gambia", "266-724-5001 x910" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Santiagoview", "EE36386", 1, "G162620", new DateTime(1977, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lynne_Cruickshank@yahoo.com", "Lynne", "Cruickshank", "Kazakhstan", "871-487-0979 x365" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Annamarietown", "EE57291", "G437820", new DateTime(1994, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lucy.Pfeffer@yahoo.com", "Lucy", "Pfeffer", "Guatemala", "1-652-992-5045 x9236" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Conradport", "EE31372", 4, "G164755", new DateTime(1999, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Anne9@hotmail.com", "Anne", "O'Kon", "Switzerland", "689.561.7899 x75823", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Nickolas", "EE30790", 4, "G72754", new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shirley80@hotmail.com", "Shirley", "Abbott", "El Salvador", "661.604.2827 x622" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Tracy", "EE20885", 1, "G102898", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Erick.Denesik@hotmail.com", "Erick", "Denesik", "Seychelles", "1-556-895-5906 x756" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nitzschechester", "EE6290", 3, "G168182", new DateTime(2000, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Mike47@yahoo.com", "Mike", "Sauer", "Malawi", "(963) 679-1587 x5595", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Bianka", "EE46266", 1, "G261900", new DateTime(1956, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa86@hotmail.com", "Vanessa", "Lockman", "Thailand", "688-889-9054 x7847", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bernhardside", "EE54949", 3, "G550078", new DateTime(1989, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Angelica33@yahoo.com", "Angelica", "Tromp", "Antigua and Barbuda", "489.374.8510 x37767", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kenyonberg", "EE43624", 2, "G324884", new DateTime(1953, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hugh15@yahoo.com", "Hugh", "Kirlin", "Qatar", "374.547.6733 x57435" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Armstrongshire", "EE38899", "G493682", new DateTime(1962, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Brandy_Tillman30@yahoo.com", "Brandy", "Tillman", "Costa Rica", "1-683-745-8395 x4258", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mervin", "EE52845", "G125530", new DateTime(1956, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Grady20@hotmail.com", "Grady", "O'Connell", "Palestinian Territory", "1-285-760-2601", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Meghanmouth", "EE57083", 1, "G572453", new DateTime(1975, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Chester.Williamson36@hotmail.com", "Chester", "Williamson", "Lesotho", "1-997-646-1527 x590" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abernathyburgh", "EE1900", "G492470", new DateTime(1973, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Eddie.Glover11@hotmail.com", "Eddie", "Glover", "Montserrat", "726.802.9456", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tryciaberg", "EE20730", 3, "G141343", new DateTime(1958, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Juan_Jakubowski28@gmail.com", "Juan", "Jakubowski", "Tuvalu", "(264) 709-9147 x833", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Elisa", "EE38528", "G413047", new DateTime(1979, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Luis.Krajcik97@gmail.com", "Luis", "Krajcik", "Niger", "379.512.6993" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Orville", "EE47202", "G310662", new DateTime(1997, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Hilpert28@hotmail.com", "Shane", "Hilpert", "Kiribati", "560-417-2859 x718", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Crookschester", "EE51758", "G288375", new DateTime(1981, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie44@hotmail.com", "Jeannie", "Hilll", "Albania", "861-325-1606", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Lenoraburgh", "EE27663", "G160317", new DateTime(1981, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Victoria.Krajcik3@gmail.com", "Victoria", "Krajcik", "Kenya", "1-495-939-6150 x0093" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Curtmouth", "EE13742", 4, "G121776", new DateTime(1964, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Cary_Koelpin68@hotmail.com", "Cary", "Koelpin", "Holy See (Vatican City State)", "1-508-411-0516 x7444", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Chloe", "EE41690", 3, "G182887", new DateTime(1971, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jerome33@gmail.com", "Jerome", "Jacobson", "French Guiana", "950-894-9297 x3526", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "lastname", "natio", "phone" },
                values: new object[] { "Boyerberg", "EE3219", 3, "G141023", new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Alexander.OKeefe@gmail.com", "O'Keefe", "Afghanistan", "518-417-0431" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Andrewland", "EE7461", 3, "G557472", new DateTime(1970, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lula_OKon72@gmail.com", "Lula", "O'Kon", "Equatorial Guinea", "(201) 666-4315", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hicklechester", "EE58599", "G132941", new DateTime(1966, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia_Dare@yahoo.com", "Sylvia", "Dare", "Spain", "1-492-469-0833" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Claudineshire", "EE25755", "G71009", new DateTime(1972, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lawrence_Gleichner14@hotmail.com", "Lawrence", "Gleichner", "Paraguay", "924.984.7006", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutmannmouth", "EE49792", 1, "G284040", new DateTime(1970, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Charlie.Dietrich23@gmail.com", "Charlie", "Dietrich", "Kuwait", "265.365.1311 x2840" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Othafurt", "EE36884", 4, "G488614", new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Roderick.Kovacek63@yahoo.com", "Roderick", "Kovacek", "Mongolia", "494.292.6408" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Lempifurt", "EE53443", 2, "G219475", new DateTime(1966, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Gerlach@hotmail.com", "Tami", "Gerlach", "Tokelau", "1-418-671-8620 x154" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Thalia", "EE3109", 2, "G519999", new DateTime(1964, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lance.Tromp40@gmail.com", "Lance", "Tromp", "Gibraltar", "(285) 515-3101", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Zola", "EE32941", 3, "G247548", new DateTime(1985, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Phil26@gmail.com", "Phil", "Kris", "Antarctica (the territory South of 60 deg S)", "840-402-1238", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Houstonport", "EE55141", 4, "G498999", new DateTime(2000, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kristine.OKeefe10@hotmail.com", "Kristine", "O'Keefe", "French Southern Territories", "730.596.2233 x01897", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pasqualeside", "EE50235", "G523671", new DateTime(1963, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Neal30@yahoo.com", "Neal", "Bashirian", "Sweden", "(824) 631-6800 x45545", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Jamie", "EE32950", "G278394", new DateTime(1959, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mike24@hotmail.com", "Mike", "Cartwright", "Turkmenistan", "940-398-8710 x36757", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Powlowskifort", "EE38962", "G557902", new DateTime(1961, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Latoya_Bauch@yahoo.com", "Latoya", "Bauch", "Barbados", "(225) 461-6433 x7716" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Michaelport", "EE13165", 3, "G454860", new DateTime(1974, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Shields@gmail.com", "Bradley", "Shields", "Bermuda", "960-978-1907", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nicklausland", "EE38742", "G290873", new DateTime(1952, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Cheryl.Connelly4@yahoo.com", "Cheryl", "Connelly", "Grenada", "238-309-7727 x019" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Langview", "EE41534", "G257950", new DateTime(1974, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Spencer30@yahoo.com", "Spencer", "Howe", "Bhutan", "1-426-252-4188 x344" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Benedict", "EE31301", 4, "G458166", new DateTime(1952, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Mike.Boyer@yahoo.com", "Mike", "Boyer", "Venezuela", "564.245.1065 x428", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Freedaburgh", "EE9818", 3, "G481225", new DateTime(1952, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Irving.Wintheiser@gmail.com", "Irving", "Wintheiser", "Gabon", "293.908.0631 x08735", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Tateshire", "EE8823", 4, "G548735", new DateTime(1982, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Dach40@hotmail.com", "Albert", "Dach", "Guinea-Bissau", "416-950-4468 x70595", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Annetta", "EE55931", 3, "G478369", new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cheryl.Kunde@gmail.com", "Cheryl", "Kunde", "Cote d'Ivoire", "1-899-748-9184" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Antoinetteville", "EE48212", 1, "G293682", new DateTime(1996, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jasmine.Padberg51@yahoo.com", "Jasmine", "Padberg", "Zambia", "(948) 300-9901", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jastport", "EE31688", "G235010", new DateTime(1999, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Santos13@hotmail.com", "Santos", "Donnelly", "French Polynesia", "(956) 967-6813 x8604" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Dolores", "EE45581", 2, "G179562", new DateTime(1980, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Wendy82@yahoo.com", "Wendy", "Graham", "Gabon", "(672) 255-3246 x24267" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Heathcotefort", "EE14716", 2, "G454736", new DateTime(1998, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kim_Cassin0@gmail.com", "Kim", "Cassin", "French Southern Territories", "781.675.8268 x30616", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Walshville", "EE8239", 3, "G340494", new DateTime(1979, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Victor78@gmail.com", "Victor", "Krajcik", "Estonia", "252-591-0539 x992", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brakusland", "EE954", "G441329", new DateTime(1959, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Pablo_Davis@yahoo.com", "Pablo", "Davis", "Virgin Islands, U.S.", "(962) 410-2263" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Presleyport", "EE3372", 4, "G120680", new DateTime(1976, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Misty81@hotmail.com", "Misty", "Pfeffer", "French Guiana", "317.923.9726 x16893", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Romaine", "EE27180", 2, "G210873", new DateTime(1997, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Guadalupe27@hotmail.com", "Guadalupe", "Rogahn", "Italy", "1-913-783-1052", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kamrynport", "EE59404", 2, "G79639", new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cesar.Hodkiewicz49@hotmail.com", "Cesar", "Hodkiewicz", "Jamaica", "352-209-3043 x812" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Baileyville", "EE11329", 4, "G375599", new DateTime(1977, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Mack_Ondricka59@yahoo.com", "Mack", "Ondricka", "Netherlands", "202.224.1130", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cooperland", "EE37171", 2, "G351704", new DateTime(1989, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne77@gmail.com", "Adrienne", "Beahan", "Saudi Arabia", "239-566-2678 x04672", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Madilynburgh", "EE39098", 3, "G552136", new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kerry67@yahoo.com", "Kerry", "Terry", "Pakistan", "661.682.2230", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Alivia", "EE14496", 4, "G549781", new DateTime(1986, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Doyle29@yahoo.com", "Doyle", "Crooks", "Netherlands Antilles", "(314) 687-6501" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Bailey", "EE34218", 3, "G441749", new DateTime(1963, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Simon.Schimmel@yahoo.com", "Simon", "Schimmel", "Swaziland", "574.756.2452" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Douglasland", "EE3436", 2, "G474140", new DateTime(1968, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Joe.Feest26@hotmail.com", "Joe", "Feest", "Poland", "406.936.4778 x095", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hankborough", "EE51057", 2, "G176490", new DateTime(1974, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Ronnie63@gmail.com", "Ronnie", "Sipes", "Vietnam", "1-868-523-5882 x7985" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ryanport", "EE16443", "G450321", new DateTime(1980, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cassandra_Conn@gmail.com", "Cassandra", "Conn", "Oman", "398.558.5888" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Kristoffer", "EE24943", "G166510", new DateTime(1983, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jack80@hotmail.com", "Jack", "O'Conner", "Libyan Arab Jamahiriya", "1-636-570-5930 x3515", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Adamview", "EE34096", 3, "G489258", new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Earl_Quigley@yahoo.com", "Earl", "Quigley", "South Georgia and the South Sandwich Islands", "1-349-434-7700", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "McGlynnbury", "EE57606", 2, "G550563", new DateTime(1972, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne.Leuschke94@yahoo.com", "Adrienne", "Leuschke", "Syrian Arab Republic", "314.694.5193 x21235", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Berenicemouth", "EE23561", "G568599", new DateTime(1957, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Wade_Grant49@hotmail.com", "Wade", "Grant", "Taiwan", "1-336-538-3347 x7120", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Madie", "EE19975", "G163506", new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Becky59@gmail.com", "Becky", "Bashirian", "Lesotho", "(916) 655-0533 x7517", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "Ledafort", "EE24411", 3, "G179649", new DateTime(1956, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lena.Predovic@yahoo.com", "Lena", "Predovic", "(311) 772-8252 x428" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Emilianomouth", "EE36114", 3, "G396339", new DateTime(1979, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Amelia_Marquardt@yahoo.com", "Amelia", "Marquardt", "Chile", "257-967-9100 x75175" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Oralport", "EE7636", "G355936", new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Leonard_Rippin@gmail.com", "Leonard", "Rippin", "Mozambique", "1-608-851-2361 x46443" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ollie", "EE27064", 1, "G389422", new DateTime(1973, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Levi_Barton84@yahoo.com", "Levi", "Barton", "Saint Lucia", "897.251.6192 x909", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Mauriciofort", "EE28365", 4, "G274167", new DateTime(1964, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Glen64@gmail.com", "Glen", "Armstrong", "Monaco", "(451) 746-2924 x8265", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Evaside", "EE52929", 2, "G349099", new DateTime(1969, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Cary.Rodriguez@gmail.com", "Cary", "Rodriguez", "Guam", "435-448-6573 x6597", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Drakeburgh", "EE29860", 3, "G238903", new DateTime(1990, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Johnny.Leuschke43@gmail.com", "Johnny", "Leuschke", "Paraguay", "238-787-5370", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Skylarberg", "EE42121", 4, "G106751", new DateTime(1960, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Patty_Cronin48@hotmail.com", "Patty", "Cronin", "United Arab Emirates", "909.526.7010 x3790" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Medhurstland", "EE4768", 4, "G74173", new DateTime(1955, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kirk_McGlynn19@gmail.com", "Kirk", "McGlynn", "Bermuda", "484.765.8273 x74805", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ziemebury", "EE11858", 1, "G347536", new DateTime(1991, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lee_Zemlak36@hotmail.com", "Lee", "Zemlak", "Greece", "380-522-5286 x03660" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bethport", "EE28317", 2, "G187159", new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred.Kassulke@yahoo.com", "Wilfred", "Kassulke", "Christmas Island", "(694) 407-6170" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kochside", "EE52454", 1, "G250833", new DateTime(1967, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kayla_Upton@yahoo.com", "Kayla", "Upton", "Sierra Leone", "768-865-9727", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Edwinaberg", "EE10233", 4, "G79047", new DateTime(1968, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Christopher54@gmail.com", "Christopher", "Zboncak", "Malawi", "754-939-8068 x35700" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Monserratland", "EE53282", "G338710", new DateTime(1987, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lula38@yahoo.com", "Lula", "Fritsch", "Vanuatu", "(991) 645-2830 x652" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Clevelandchester", "EE56137", "G158665", new DateTime(1965, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jody25@yahoo.com", "Jody", "Bednar", "Mayotte", "(310) 454-4915" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Connhaven", "EE46490", 2, "G466468", new DateTime(1962, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Eileen_Gleichner42@yahoo.com", "Eileen", "Gleichner", "Rwanda", "884-953-6339", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Nicola", "EE8061", "G307996", new DateTime(1994, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Stanley38@hotmail.com", "Stanley", "Romaguera", "Cocos (Keeling) Islands", "1-429-644-8088" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Angelafurt", "EE57884", 3, "G492565", new DateTime(1985, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Darrel_Robel71@yahoo.com", "Darrel", "Robel", "Kenya", "1-483-255-0124", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Stammborough", "EE19928", 4, "G481426", new DateTime(1984, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jane_Schmitt29@yahoo.com", "Jane", "Schmitt", "Sweden", "696-789-9150 x4693", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dibbertberg", "EE23522", 4, "G230983", new DateTime(1996, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell_Koch41@gmail.com", "Mitchell", "Koch", "El Salvador", "(432) 801-9427 x3396", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Clydeland", "EE23952", 3, "G386132", new DateTime(1976, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Daryl_Harber@yahoo.com", "Daryl", "Harber", "Canada", "293.368.6327", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Skilesview", "EE55537", "G48498", new DateTime(1977, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jessica.Orn15@yahoo.com", "Jessica", "Orn", "Macao", "(202) 281-4287 x0182" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ashlyton", "EE26918", 2, "G59998", new DateTime(1970, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Boyd6@gmail.com", "Boyd", "Weimann", "Sudan", "360-777-3938 x33321", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bridiefort", "EE50386", 4, "G129863", new DateTime(1966, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sam56@hotmail.com", "Sam", "Crist", "Croatia", "1-341-294-1479", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Rahul", "EE32740", 4, "G521333", new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Annette.Parker@yahoo.com", "Annette", "Parker", "Mongolia", "(309) 977-9518 x9095" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cristhaven", "EE42434", "G208533", new DateTime(1955, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Van.Cruickshank@hotmail.com", "Van", "Cruickshank", "Guinea-Bissau", "703-635-5562", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kameronville", "EE57907", "G486029", new DateTime(1977, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wm50@gmail.com", "Wm", "Hilpert", "Liechtenstein", "890-291-5326 x67409" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Dustin", "EE4246", "G424076", new DateTime(1971, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ivan_Johnston@gmail.com", "Ivan", "Johnston", "Luxembourg", "205.985.5456 x5963" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Carriechester", "EE43130", "G144063", new DateTime(1982, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Alberto_Turcotte@gmail.com", "Alberto", "Turcotte", "Central African Republic", "1-833-695-3644" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Arielton", "EE2832", 2, "G351023", new DateTime(1963, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Franecki14@gmail.com", "Lucille", "Franecki", "Germany", "745.479.9826" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Mckenzie", "EE22602", 4, "G297203", new DateTime(1998, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Emmett_Altenwerth15@yahoo.com", "Emmett", "Altenwerth", "Papua New Guinea", "688-580-4970 x38297", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Rickey", "EE28443", 4, "G324486", new DateTime(1986, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Naomi42@yahoo.com", "Naomi", "Greenfelder", "Iceland", "(788) 733-0487 x198" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jaskolskihaven", "EE1796", 2, "G125152", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rodney85@yahoo.com", "Rodney", "Bergnaum", "Russian Federation", "555.375.2269" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Giovannyville", "EE53575", "G457388", new DateTime(1962, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ralph.Pollich@gmail.com", "Ralph", "Pollich", "India", "406-683-8808 x237" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Kristopherland", "EE38463", "G572306", new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Wilma10@yahoo.com", "Wilma", "Jakubowski", "Isle of Man", "(371) 842-9744" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Carissa", "EE46887", "G218610", new DateTime(1954, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Roy_Murazik@gmail.com", "Roy", "Murazik", "Mayotte", "(238) 217-7683", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnstown", "EE17181", 1, "G216658", new DateTime(1964, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Darlene34@gmail.com", "Darlene", "Schmidt", "Barbados", "(447) 554-6794 x1549", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Emilport", "EE24488", 4, "G312847", new DateTime(1982, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Marcos_Kovacek@hotmail.com", "Marcos", "Kovacek", "Falkland Islands (Malvinas)", "1-785-212-0684" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Francescoview", "EE48914", "G234695", new DateTime(1975, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Darryl.Hessel26@gmail.com", "Darryl", "Hessel", "Guadeloupe", "849.777.9795" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Isidroburgh", "EE50692", "G237086", new DateTime(1961, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Steve.Cartwright35@yahoo.com", "Steve", "Cartwright", "Burundi", "327.288.7243" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Opheliaville", "EE27448", 1, "G54655", new DateTime(1960, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Josh81@yahoo.com", "Josh", "Wolff", "Micronesia", "417-605-6916 x201" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mellieville", "EE26240", 3, "G119751", new DateTime(1985, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Leslie.Tromp53@hotmail.com", "Leslie", "Tromp", "Virgin Islands, U.S.", "1-238-919-6331 x1992" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldnerland", "EE13590", "G567095", new DateTime(1966, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Natasha65@gmail.com", "Natasha", "Koepp", "Croatia", "(782) 391-5272 x4908", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Sherwoodport", "EE46972", "G528192", new DateTime(1984, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Weissnat@yahoo.com", "Bradley", "Weissnat", "Cameroon", "616.816.2677" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ritchieton", "EE5926", 3, "G476058", new DateTime(1988, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jacob.Wolff85@hotmail.com", "Jacob", "Wolff", "Guadeloupe", "637.330.8935 x43187" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Gennaro", "EE46351", 3, "G189019", new DateTime(1984, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Olivia25@yahoo.com", "Olivia", "Kuhlman", "Republic of Korea", "739-804-2679", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Baileyview", "EE468", "G530751", new DateTime(1966, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lester.Erdman@yahoo.com", "Lester", "Erdman", "Peru", "(393) 243-3047 x486" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "Gutmannland", "EE16875", "G84084", new DateTime(1952, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Iris87@yahoo.com", "Iris", "McDermott", "(770) 717-7616 x032" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ryleighfurt", "EE23735", "G138677", new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery47@gmail.com", "Jeffery", "Zemlak", "Guinea", "827.979.9783 x227", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Delmer", "EE9475", 4, "G108134", new DateTime(1975, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bob26@gmail.com", "Bob", "Nolan", "Micronesia", "(746) 408-1508 x614", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Eduardo", "EE53862", 4, "G226489", new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Gayle_Koch30@yahoo.com", "Gayle", "Koch", "Saint Pierre and Miquelon", "220.216.7767 x9655" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Newtonfort", "EE17664", 1, "G118489", new DateTime(1973, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Duane.Kulas@yahoo.com", "Duane", "Kulas", "Austria", "473-781-2325" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Arvidborough", "EE33344", 2, "G384307", new DateTime(1982, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ross.Legros@hotmail.com", "Ross", "Legros", "Western Sahara", "359-823-6244 x5579", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Olin", "EE21175", 3, "G50304", new DateTime(1978, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Pamela4@gmail.com", "Pamela", "Turner", "Ethiopia", "526-637-7759" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Sadye", "EE18672", 2, "G396217", new DateTime(1969, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tonya_Satterfield7@hotmail.com", "Tonya", "Satterfield", "Afghanistan", "1-378-385-8744" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roweton", "EE9881", 2, "G567679", new DateTime(1960, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Deborah25@yahoo.com", "Deborah", "Luettgen", "Angola", "(310) 520-1179" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone" },
                values: new object[] { "Rippinview", "EE42987", 4, "G191011", new DateTime(1955, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Max18@hotmail.com", "Max", "Dickens", "1-548-997-1613" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Reesemouth", "EE39375", 3, "G181051", new DateTime(1983, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Ida17@gmail.com", "Ida", "Koelpin", "Monaco", "594-839-2854" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Emmittchester", "EE45931", 1, "G65968", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dean76@hotmail.com", "Dean", "Larson", "Togo", "809.793.5392", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Miguelshire", "EE8258", "G386481", new DateTime(1988, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Denise86@yahoo.com", "Denise", "Jaskolski", "Cameroon", "212.851.7452", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carmelomouth", "EE22679", 2, "G142864", new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Viola_Stokes99@hotmail.com", "Viola", "Stokes", "Vietnam", "869-896-1792", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Towneview", "EE31198", "G506867", new DateTime(1985, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Carol21@yahoo.com", "Carol", "Stanton", "Madagascar", "(865) 462-3036 x368", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lavonnefort", "EE27367", 4, "G165323", new DateTime(1971, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Kelley.Schmitt@hotmail.com", "Kelley", "Schmitt", "Gambia", "(661) 731-4686 x7292" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Skileschester", "EE28628", "G127357", new DateTime(1981, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Marc66@gmail.com", "Marc", "Terry", "Latvia", "(553) 545-4021 x912", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bayerstad", "EE41024", 4, "G443448", new DateTime(1960, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Douglas11@hotmail.com", "Douglas", "Schaden", "Nauru", "944.904.1422" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Ameliaborough", "EE14883", "G314707", new DateTime(1977, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred_Carter@yahoo.com", "Wilfred", "Carter", "Virgin Islands, U.S.", "(252) 676-7598 x75749", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Enolatown", "EE58986", 3, "G9535", new DateTime(1978, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Wilma.Rodriguez30@gmail.com", "Wilma", "Rodriguez", "Jordan", "(336) 201-1613", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Janymouth", "EE13085", "G461911", new DateTime(1976, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Edward_Miller93@yahoo.com", "Edward", "Miller", "Western Sahara", "1-556-925-0446 x0584", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Andersontown", "EE20117", "G82718", new DateTime(1994, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jamie40@hotmail.com", "Jamie", "Pacocha", "Lebanon", "1-568-329-2465 x4595", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Bohaven", "EE10995", "G359322", new DateTime(1975, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Terri28@hotmail.com", "Terri", "Kuvalis", "Denmark", "575-493-6412", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Electastad", "EE31318", 4, "G597957", new DateTime(1996, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Leigh22@hotmail.com", "Leigh", "Rempel", "Lesotho", "446.721.6499", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Einarhaven", "EE3486", 3, "G298769", new DateTime(1953, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Roy.Prosacco@hotmail.com", "Roy", "Prosacco", "New Caledonia", "(625) 451-0037 x04663" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Libbymouth", "EE29934", 4, "G223670", new DateTime(1989, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jerry63@yahoo.com", "Jerry", "Schiller", "India", "256.210.1782 x021" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Feilhaven", "EE24032", 2, "G464551", new DateTime(1967, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Kristina_Nienow@hotmail.com", "Kristina", "Nienow", "Georgia", "212.265.8033 x490" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Helenland", "EE56537", 2, "G385449", new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bruce9@gmail.com", "Bruce", "Konopelski", "Ukraine", "552.832.3154 x13872" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Friesenshire", "EE5228", 2, "G557326", new DateTime(1964, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Winston54@gmail.com", "Winston", "Berge", "Cambodia", "257-867-6980" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kuphalberg", "EE19092", "G334192", new DateTime(1952, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Raynor38@yahoo.com", "Rufus", "Raynor", "Democratic People's Republic of Korea", "1-654-270-5619 x1796", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Katlynnmouth", "EE6318", 1, "G293555", new DateTime(1974, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Larry83@yahoo.com", "Larry", "Bednar", "Republic of Korea", "(866) 419-9082 x452" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Queen", "EE56893", 1, "G585841", new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Erick_Stamm@yahoo.com", "Erick", "Stamm", "Palestinian Territory", "1-242-468-1553", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Dee", "EE6189", "G396881", new DateTime(1998, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Pearl_Tromp@hotmail.com", "Pearl", "Tromp", "Turkmenistan", "398.253.8839 x137" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jevonbury", "EE28446", "G178462", new DateTime(1997, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Adrienne.Feeney53@yahoo.com", "Adrienne", "Feeney", "Montserrat", "939.982.1220 x989" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Andychester", "EE11995", "G399702", new DateTime(1999, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Lorraine.Hudson40@hotmail.com", "Lorraine", "Hudson", "Dominican Republic", "1-730-674-1559" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Fae", "EE9533", 3, "G406046", new DateTime(1986, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Benjamin_Streich16@gmail.com", "Benjamin", "Streich", "Albania", "812-849-2868" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Leannonshire", "EE12300", 1, "G271412", new DateTime(1953, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Judy.Jacobson4@yahoo.com", "Judy", "Jacobson", "French Southern Territories", "(687) 783-6170 x827", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Mae", "EE46477", "G194656", new DateTime(1982, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Dustin_Quigley12@gmail.com", "Dustin", "Quigley", "Spain", "(927) 334-8762 x11906", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Priceshire", "EE20791", "G492873", new DateTime(1972, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Merle_Senger@hotmail.com", "Merle", "Senger", "Faroe Islands", "597-788-8728 x68919", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "DuBuquestad", "EE27772", 1, "G89109", new DateTime(1978, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jesse17@gmail.com", "Jesse", "Koch", "Democratic People's Republic of Korea", "(932) 982-4136 x18297", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Abigale", "EE36756", 4, "G38084", new DateTime(1995, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Patrick_Bednar@yahoo.com", "Patrick", "Bednar", "Swaziland", "646.246.2506 x360" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Opheliaview", "EE25597", 1, "G110819", new DateTime(1978, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Mandy.Simonis86@gmail.com", "Mandy", "Simonis", "Niger", "1-720-609-4023 x165", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Meaganmouth", "EE21518", "G234650", new DateTime(1967, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Johnny.Boehm@yahoo.com", "Johnny", "Boehm", "Honduras", "1-402-912-6072 x44313", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobsburgh", "EE38061", 4, "G28234", new DateTime(1976, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Santos.Lindgren51@yahoo.com", "Santos", "Lindgren", "Saint Pierre and Miquelon", "303-760-5346 x590" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Joanieshire", "EE5281", 2, "G67341", new DateTime(1956, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Eula32@hotmail.com", "Eula", "Prosacco", "Belgium", "392.871.9250 x081" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Sashaville", "EE55795", 3, "G248871", new DateTime(1999, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Zachary.Simonis@hotmail.com", "Zachary", "Simonis", "Myanmar", "(546) 742-4278 x39304", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Brenda", "EE27964", 4, "G368747", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Todd_Douglas32@gmail.com", "Todd", "Douglas", "Honduras", "1-774-805-4624" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Amiraview", "EE10774", "G79200", new DateTime(1984, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Thomas30@yahoo.com", "Thomas", "McKenzie", "Argentina", "1-717-432-0756", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Carolyneville", "EE38580", "G31961", new DateTime(1955, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Pearl.Kihn67@gmail.com", "Pearl", "Kihn", "Equatorial Guinea", "1-778-758-9886 x997" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Corneliusport", "EE40524", 4, "G437964", new DateTime(1970, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bob_Nitzsche43@hotmail.com", "Bob", "Nitzsche", "Tunisia", "(396) 958-5658", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Velvamouth", "EE54197", "G260929", new DateTime(1982, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Marvin.Christiansen@gmail.com", "Marvin", "Christiansen", "New Zealand", "(502) 331-5579 x698", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Chelsey", "EE5740", "G274401", new DateTime(1968, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Colin_Schultz@hotmail.com", "Colin", "Schultz", "Comoros", "(494) 569-9029", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Brentport", "EE23253", 2, "G315828", new DateTime(1965, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Claire29@hotmail.com", "Claire", "Grimes", "Cote d'Ivoire", "770.421.1742 x635", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnsville", "EE24860", 2, "G6128", new DateTime(1982, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Francis_Boyer@yahoo.com", "Francis", "Boyer", "Puerto Rico", "1-549-439-3307 x13229", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Greggburgh", "EE43770", "G40206", new DateTime(1967, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Eva.Moore@hotmail.com", "Eva", "Moore", "Trinidad and Tobago", "1-730-608-6635 x94975", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Ellis", "EE49774", 1, "G484361", new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ted40@gmail.com", "Ted", "Schinner", "Ethiopia", "269-691-5343 x3372", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gleasonland", "EE13710", 2, "G159100", new DateTime(1954, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Debra.Breitenberg71@gmail.com", "Debra", "Breitenberg", "Germany", "1-351-711-4096" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Susana", "EE47380", 1, "G179700", new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Moses_Mraz@yahoo.com", "Moses", "Mraz", "France", "(404) 662-7953 x8346" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Reubenview", "EE42980", 2, "G525940", new DateTime(1958, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Charles93@hotmail.com", "Charles", "Fisher", "Kenya", "796-891-8955 x50224" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Bettie", "EE12413", 3, "G295645", new DateTime(1991, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Leah74@hotmail.com", "Leah", "Lebsack", "Mongolia", "(403) 348-9337", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jaskolskimouth", "EE19141", 4, "G490356", new DateTime(1997, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bertha.Doyle@hotmail.com", "Bertha", "Doyle", "Benin", "1-445-697-7273" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weissnatmouth", "EE46472", "G290722", new DateTime(1960, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Myron.Farrell50@hotmail.com", "Myron", "Farrell", "Monaco", "1-438-934-6765 x9074" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Maurice", "EE21111", 1, "G457366", new DateTime(1981, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Tricia_Kiehn72@hotmail.com", "Tricia", "Kiehn", "Armenia", "1-307-375-4270 x8168" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zboncakburgh", "EE59548", 1, "G587544", new DateTime(1981, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Candice61@gmail.com", "Candice", "Thompson", "Iraq", "385.868.9090 x29010" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Briannemouth", "EE11357", 3, "G24663", new DateTime(1954, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Charlie.Crist@gmail.com", "Charlie", "Crist", "Austria", "1-827-743-7599 x9127" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Blairport", "EE20082", 4, "G523308", new DateTime(1973, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Blanche15@yahoo.com", "Blanche", "Okuneva", "Saint Vincent and the Grenadines", "(313) 841-6553", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "O'Connellport", "EE28288", 1, "G560547", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Kemmer60@hotmail.com", "Johnnie", "Kemmer", "Albania", "654-260-6971 x369", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mateomouth", "EE19979", "G249355", new DateTime(1999, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Willie93@yahoo.com", "Willie", "Keeling", "Japan", "(599) 637-3564", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Rubenburgh", "EE5394", "G178003", new DateTime(1968, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Milton83@gmail.com", "Milton", "Huel", "Latvia", "730-860-1289 x097" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Edward", "EE45053", 2, "G74850", new DateTime(1989, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Pablo.Gorczany@gmail.com", "Pablo", "Gorczany", "Taiwan", "793.958.8903 x493" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schaeferberg", "EE45220", 3, "G273139", new DateTime(1955, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Moses46@hotmail.com", "Moses", "Predovic", "El Salvador", "(210) 868-3841 x869" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bradtkemouth", "EE12341", 3, "G357863", new DateTime(1986, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Minnie76@gmail.com", "Minnie", "Feeney", "United States Minor Outlying Islands", "397.854.0246", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Marquiseberg", "EE58775", 4, "G139121", new DateTime(1989, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Upton0@yahoo.com", "Kathleen", "Upton", "Saint Barthelemy", "1-240-276-8432 x07223", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardmouth", "EE1413", 3, "G447887", new DateTime(1978, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Neil_Koch@yahoo.com", "Neil", "Koch", "Estonia", "689.738.6907 x5655" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Mafalda", "EE13623", 2, "G176034", new DateTime(1972, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sandy0@gmail.com", "Sandy", "Bartell", "Switzerland", "1-619-725-8478 x0441", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Antoniettastad", "EE3671", 2, "G74448", new DateTime(1977, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lula.Cartwright@hotmail.com", "Lula", "Cartwright", "Cook Islands", "1-570-650-2966 x0047", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Benny", "EE25399", "G4595", new DateTime(1997, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kelli97@yahoo.com", "Kelli", "Orn", "Belgium", "982.323.6311" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goyettemouth", "EE42775", "G436342", new DateTime(1997, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Brendan53@hotmail.com", "Brendan", "Thompson", "Virgin Islands, British", "718-329-5989 x9241", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Isobelfort", "EE3395", 2, "G302001", new DateTime(1961, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Shari_Mraz87@hotmail.com", "Shari", "Mraz", "Malawi", "655.533.7669 x195" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wolffchester", "EE54069", "G104380", new DateTime(1984, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dolores_Langworth59@yahoo.com", "Dolores", "Langworth", "Sao Tome and Principe", "964.631.0617 x6182", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bergstromview", "EE58593", 4, "G585808", new DateTime(1952, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Goldner@hotmail.com", "Rolando", "Goldner", "Canada", "1-579-617-9296 x51884" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Avery", "EE29038", "G556888", new DateTime(1987, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marco_Quitzon12@gmail.com", "Marco", "Quitzon", "Sweden", "992-655-3177 x234", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Piper", "EE10240", 1, "G3203", new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lois3@gmail.com", "Lois", "Schulist", "Reunion", "381.754.0778" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Henriette", "EE55319", "G219210", new DateTime(1978, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Alonzo_Kunde96@yahoo.com", "Alonzo", "Kunde", "Bahamas", "1-505-293-6449 x2039" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hellen", "EE300", "G476582", new DateTime(1952, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Horace_Weissnat@gmail.com", "Horace", "Weissnat", "Oman", "780-537-2628 x2512", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lawrencefurt", "EE56689", 4, "G308644", new DateTime(1968, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nick15@hotmail.com", "Nick", "Blanda", "Senegal", "(749) 211-4490" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wintheiserchester", "EE28568", "G157051", new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Latoya48@hotmail.com", "Latoya", "Kuhn", "Uganda", "(578) 773-1569 x97996", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hymanchester", "EE13110", "G203035", new DateTime(1986, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jamie.Maggio35@hotmail.com", "Jamie", "Maggio", "Ethiopia", "(542) 769-5783", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kathleentown", "EE4983", "G429832", new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Clyde24@yahoo.com", "Clyde", "Kihn", "Lesotho", "1-200-935-4973", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ritamouth", "EE24532", 4, "G150438", new DateTime(1983, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Johnny69@yahoo.com", "Johnny", "Weber", "Jamaica", "(664) 277-1328 x329", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Sherwood", "EE26546", 2, "G468202", new DateTime(1976, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Sipes6@gmail.com", "Mildred", "Sipes", "Kenya", "273.465.2419" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brakusside", "EE30620", 1, "G96372", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gwendolyn65@gmail.com", "Gwendolyn", "Schmeler", "Chile", "535.963.2950", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Gayle", "EE12986", 3, "G126483", new DateTime(1972, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester92@hotmail.com", "Sylvester", "Mertz", "United Kingdom", "830-496-8213" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kaleb", "EE26417", 3, "G332551", new DateTime(2000, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Garrett_Kshlerin@hotmail.com", "Garrett", "Kshlerin", "Vietnam", "905-570-6629 x52780", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Alexisberg", "EE40905", "G365452", new DateTime(1998, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Joseph_Koch@hotmail.com", "Joseph", "Koch", "Bangladesh", "1-737-665-3329 x36480", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Volkmanmouth", "EE28721", "G571062", new DateTime(1983, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Alexander_Feil4@gmail.com", "Alexander", "Feil", "Cayman Islands", "312.585.5669 x6422" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Madisyn", "EE46243", 2, "G343346", new DateTime(1958, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rochelle4@yahoo.com", "Rochelle", "Denesik", "Kuwait", "(872) 547-3172", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Lonny", "EE54430", 1, "G273986", new DateTime(1985, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kathryn.Labadie@gmail.com", "Kathryn", "Labadie", "Reunion", "1-269-839-8203 x937" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Charlietown", "EE22682", "G180058", new DateTime(1957, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jordan.Kshlerin9@yahoo.com", "Jordan", "Kshlerin", "Ethiopia", "261-891-1124", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucianomouth", "EE46959", 4, "G480969", new DateTime(1984, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Runte@yahoo.com", "Inez", "Runte", "China", "546-278-5659 x23817" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Willfort", "EE55159", "G369763", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shawna17@gmail.com", "Shawna", "Erdman", "Bahamas", "950-936-0597 x993" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ezekielhaven", "EE12273", "G58007", new DateTime(1989, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Alexandra.Wisoky@yahoo.com", "Alexandra", "Wisoky", "Chad", "405-365-3664 x8215" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maggioview", "EE35137", "G574388", new DateTime(1961, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Troy74@hotmail.com", "Troy", "Langosh", "Lithuania", "750-773-8347", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hagenesburgh", "EE14465", 1, "G210232", new DateTime(1967, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa_Durgan@yahoo.com", "Vanessa", "Durgan", "Djibouti", "812-585-8501 x4444", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Krisville", "EE17502", 1, "G563049", new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta_Mosciski40@hotmail.com", "Henrietta", "Mosciski", "Guernsey", "1-841-374-5623 x4799", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Maxwellberg", "EE31417", "G422359", new DateTime(1961, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shaun_Wilkinson9@yahoo.com", "Shaun", "Wilkinson", "Central African Republic", "359-862-6556", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Alexaburgh", "EE48355", 2, "G389230", new DateTime(1959, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Zachary35@yahoo.com", "Zachary", "Smith", "Bangladesh", "(290) 509-1270 x4782", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Altaland", "EE41135", 3, "G317082", new DateTime(1964, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tom.Purdy@gmail.com", "Tom", "Purdy", "Virgin Islands, U.S.", "(568) 475-6940 x87718" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Griffinhaven", "EE29326", 1, "G346416", new DateTime(1963, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lucas.Abernathy28@hotmail.com", "Lucas", "Abernathy", "Zimbabwe", "1-471-800-9040", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kozeyland", "EE3739", 3, "G596233", new DateTime(1964, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marty.Dooley@hotmail.com", "Marty", "Dooley", "Indonesia", "952.281.4375 x59155" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Avery", "EE31898", 4, "G583312", new DateTime(1998, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen0@yahoo.com", "Gretchen", "Parisian", "Namibia", "742.769.7558", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Hazletown", "EE42227", 2, "G273231", new DateTime(1956, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jeanette.Gulgowski70@yahoo.com", "Jeanette", "Gulgowski", "Slovakia (Slovak Republic)", "1-858-656-0832", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Meaganfort", "EE21402", 1, "G36817", new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lisa.Nikolaus22@hotmail.com", "Lisa", "Nikolaus", "Lebanon", "984.730.9556 x26998" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rueckerfurt", "EE8058", "G11646", new DateTime(1953, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Irving_Quigley41@hotmail.com", "Irving", "Quigley", "Nicaragua", "(620) 543-5417 x01225" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "McLaughlinberg", "EE5694", 2, "G364882", new DateTime(1973, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Mindy_Becker@hotmail.com", "Mindy", "Becker", "Nicaragua", "630.213.9038" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Reillystad", "EE30293", 3, "G476503", new DateTime(1961, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Sophie63@yahoo.com", "Sophie", "Willms", "Cocos (Keeling) Islands", "(296) 722-0518" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Braxtonmouth", "EE30583", "G108771", new DateTime(1961, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Herman.Schroeder@yahoo.com", "Herman", "Schroeder", "Ecuador", "542-695-0932 x36341" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zellaport", "EE29382", "G507549", new DateTime(1986, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Marcus48@gmail.com", "Marcus", "Greenfelder", "Montserrat", "(814) 849-6758" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lerachester", "EE22060", 1, "G425605", new DateTime(1991, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lewis.Thiel6@hotmail.com", "Lewis", "Thiel", "Greenland", "727.465.2001 x55266" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Malvinamouth", "EE16822", 2, "G2864", new DateTime(1986, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Carroll_OKon35@yahoo.com", "Carroll", "O'Kon", "Hungary", "(948) 994-7581 x405", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Ibrahim", "EE15447", 4, "G360416", new DateTime(1975, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Monique64@hotmail.com", "Monique", "Ankunding", "Romania", "(567) 697-1921 x567", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schusterstad", "EE54031", 4, "G291876", new DateTime(1995, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alfred3@hotmail.com", "Alfred", "Hills", "Rwanda", "(855) 763-9100 x210", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Penelopestad", "EE38168", 3, "G128749", new DateTime(1966, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Amanda49@hotmail.com", "Amanda", "Bartoletti", "Wallis and Futuna", "643-654-4283 x10449" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Margarettborough", "EE18850", "G341526", new DateTime(1996, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Susan.Parisian63@gmail.com", "Susan", "Parisian", "Philippines", "(245) 803-6788 x6394", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kerlukeburgh", "EE37563", 4, "G97405", new DateTime(1974, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Guy_Gusikowski78@yahoo.com", "Guy", "Gusikowski", "Congo", "724-201-2687", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lindgrenhaven", "EE49339", 2, "G278491", new DateTime(1965, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Guy4@hotmail.com", "Guy", "Spinka", "Czech Republic", "911-918-3929" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldaton", "EE14555", 1, "G287897", new DateTime(1990, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mark_Bins@hotmail.com", "Mark", "Bins", "Vietnam", "982-582-4418", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jacobsonfurt", "EE24437", 1, "G251958", new DateTime(1967, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Carlos.Smitham54@yahoo.com", "Carlos", "Smitham", "Uruguay", "(408) 982-9706 x40210", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Nestor", "EE20807", 3, "G204500", new DateTime(1979, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kendra67@hotmail.com", "Kendra", "Stoltenberg", "Guinea-Bissau", "(374) 374-6947 x72970" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Gildamouth", "EE28462", "G116779", new DateTime(1964, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Johnston16@yahoo.com", "Sabrina", "Johnston", "Turkey", "836.865.1025", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ociestad", "EE38059", 2, "G204347", new DateTime(1973, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Van.Leffler90@gmail.com", "Van", "Leffler", "Ireland", "(744) 406-9633" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West D'angelomouth", "EE3978", 2, "G568590", new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Delia.Pouros39@gmail.com", "Delia", "Pouros", "Uganda", "413.336.0636" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Gilbertoborough", "EE2717", 2, "G66597", new DateTime(1981, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Edward.Sporer@gmail.com", "Edward", "Sporer", "Puerto Rico", "411-296-8654 x3145" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maverickland", "EE15713", 1, "G56038", new DateTime(1953, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Brendan23@yahoo.com", "Brendan", "Robel", "Colombia", "(632) 857-4536" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Crystel", "EE32281", 2, "G53624", new DateTime(1968, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Jodi82@gmail.com", "Jodi", "Paucek", "Belize", "462-670-5523" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mauriceberg", "EE22970", 3, "G9732", new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ed_Fritsch@yahoo.com", "Ed", "Fritsch", "Netherlands Antilles", "789-503-8523 x27054", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Olsonview", "EE14237", 4, "G284560", new DateTime(1973, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Regina_Rutherford@yahoo.com", "Regina", "Rutherford", "Ukraine", "684.726.1374", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Doris", "EE53705", 1, "G274612", new DateTime(1986, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Colin72@hotmail.com", "Colin", "Wolff", "South Africa", "303-528-6997 x8453", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Maritzamouth", "EE21723", 4, "G168429", new DateTime(1953, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stella_Weber@gmail.com", "Stella", "Weber", "Equatorial Guinea", "(600) 785-0403", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Karina", "EE34189", "G255245", new DateTime(1993, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Beth2@hotmail.com", "Beth", "Wintheiser", "Iraq", "(900) 580-3491 x578", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lilliefurt", "EE21241", 1, "G300789", new DateTime(1960, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Peter.Hansen@gmail.com", "Peter", "Hansen", "Paraguay", "646-695-9643" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Millie", "EE169", "G181503", new DateTime(1952, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ernesto_Abshire@yahoo.com", "Ernesto", "Abshire", "Saint Barthelemy", "976-487-7782" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ceciliamouth", "EE10031", "G59935", new DateTime(1951, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Muriel_Zboncak13@gmail.com", "Muriel", "Zboncak", "Thailand", "483.520.2899 x00818" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pacochafurt", "EE23638", 1, "G377890", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Faith.Wuckert45@yahoo.com", "Faith", "Wuckert", "Solomon Islands", "847.584.4429", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mannfort", "EE20941", 4, "G28407", new DateTime(1990, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "John_Shields63@gmail.com", "John", "Shields", "Anguilla", "1-971-574-9915 x47005", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dooleychester", "EE26458", 3, "G276083", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Clifton_Swift@gmail.com", "Clifton", "Swift", "Sweden", "739.516.8549 x38971" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Marleemouth", "EE22530", 2, "G479264", new DateTime(1989, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Angie_Glover@yahoo.com", "Angie", "Glover", "Bulgaria", "735.872.5347 x3869", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cristalton", "EE55105", 3, "G128901", new DateTime(1998, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Nelson_Rowe38@hotmail.com", "Nelson", "Rowe", "Saint Barthelemy", "1-446-784-5121" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jamarview", "EE58779", "G497923", new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Gerald44@yahoo.com", "Gerald", "Ritchie", "Bosnia and Herzegovina", "(274) 458-8679 x3510", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Oceanebury", "EE36801", "G292657", new DateTime(1955, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Gilbert.Sipes@gmail.com", "Gilbert", "Sipes", "Guadeloupe", "(801) 221-7957 x51037", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Myrtleland", "EE55273", 4, "G282248", new DateTime(1953, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Jacobi92@gmail.com", "Willie", "Jacobi", "Gibraltar", "981-799-9614 x835", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Winifredstad", "EE50807", 3, "G537651", new DateTime(1967, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sheldon_Block81@hotmail.com", "Sheldon", "Block", "Lithuania", "(756) 754-7621 x413" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gulgowskiland", "EE33194", 3, "G42717", new DateTime(1955, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Andres_Frami@hotmail.com", "Andres", "Frami", "Poland", "(966) 325-3988" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Taliaport", "EE18884", 4, "G373941", new DateTime(1959, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lucas40@yahoo.com", "Lucas", "Stroman", "Nigeria", "782-478-7436 x464" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucasmouth", "EE14961", 3, "G158579", new DateTime(1973, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Chester_Schroeder13@gmail.com", "Chester", "Schroeder", "Slovakia (Slovak Republic)", "699-409-9027" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Othaberg", "EE9674", "G226146", new DateTime(1994, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Dustin.Lemke@yahoo.com", "Dustin", "Lemke", "Bosnia and Herzegovina", "(938) 553-0234 x02819", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "McKenziebury", "EE20821", 2, "G536080", new DateTime(1969, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Amos.Schulist@hotmail.com", "Amos", "Schulist", "Wallis and Futuna", "424-220-1540", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Ethel", "EE10698", 3, "G232068", new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Erik_Swift63@hotmail.com", "Erik", "Swift", "Cote d'Ivoire", "1-936-474-3657 x455" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Americoberg", "EE50725", 3, "G124765", new DateTime(1977, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shelley_Schneider89@hotmail.com", "Shelley", "Schneider", "Suriname", "1-265-562-8610", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Alfordburgh", "EE42442", "G454964", new DateTime(1969, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Regina.Emard22@hotmail.com", "Regina", "Emard", "Somalia", "390-737-4695 x917" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gudrunfort", "EE57762", 3, "G485770", new DateTime(1967, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rickey99@yahoo.com", "Rickey", "Willms", "Lithuania", "631.856.7037", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jovannyview", "EE26568", 4, "G471215", new DateTime(1973, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie.Hilpert20@gmail.com", "Bobbie", "Hilpert", "Guadeloupe", "(242) 995-5499 x17366", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sisterhaven", "EE20449", "G121652", new DateTime(1956, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Shelley10@gmail.com", "Shelley", "Abernathy", "Bangladesh", "(642) 341-1359 x9550", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Audreanneside", "EE10998", 1, "G582315", new DateTime(1980, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Tyler94@hotmail.com", "Tyler", "Feest", "Wallis and Futuna", "1-248-683-8416 x475" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "North Emanuel", "EE42440", 2, "G465903", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Carla21@gmail.com", "Carla", "Reynolds", "487.517.9737 x1659", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Americo", "EE5334", "G485825", new DateTime(1967, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Elmer_Gaylord53@hotmail.com", "Elmer", "Gaylord", "Italy", "1-814-770-5196 x3122" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Garrett", "EE56791", 3, "G319736", new DateTime(1974, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jeanne96@hotmail.com", "Jeanne", "Lowe", "Japan", "(581) 989-4507" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Darronberg", "EE7007", "G9750", new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Jimmie_Batz41@yahoo.com", "Jimmie", "Batz", "Paraguay", "306-278-0528 x67067" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Meghan", "EE43675", 2, "G228429", new DateTime(1979, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Michele30@gmail.com", "Michele", "Bergnaum", "Costa Rica", "1-610-203-0494" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Thielport", "EE17276", "G228388", new DateTime(1967, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lila_Strosin31@hotmail.com", "Lila", "Strosin", "Bangladesh", "927-721-1985", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Laurine", "EE16356", "G431872", new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Donna_Kuhn44@yahoo.com", "Donna", "Kuhn", "Nauru", "1-344-998-6613 x1979" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Baylee", "EE8308", 2, "G228803", new DateTime(1966, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rudolph.Terry96@gmail.com", "Rudolph", "Terry", "Fiji", "376-958-1691", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Kelsi", "EE18851", 2, "G235777", new DateTime(1968, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Tami_Corwin@yahoo.com", "Tami", "Corwin", "Chile", "(989) 266-3366 x2550" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Kennedihaven", "EE18717", "G432199", new DateTime(1995, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gladys79@yahoo.com", "Gladys", "Mosciski", "New Caledonia", "(999) 354-1311 x835" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jerald", "EE8363", 1, "G52782", new DateTime(1963, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Frank60@hotmail.com", "Frank", "Wunsch", "Hungary", "734-947-2011 x120", "Male" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rupertport", "EE14323", "G339816", new DateTime(1989, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Hand@gmail.com", "Paulette", "Hand", "Mayotte", "1-749-383-5840 x4265", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Parkerburgh", "EE5532", "G394795", new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Randal_Effertz2@hotmail.com", "Randal", "Effertz", "Netherlands Antilles", "(498) 299-7099", "Male" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mayertburgh", "EE47260", 1, "G80304", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sadie21@yahoo.com", "Sadie", "McCullough", "Solomon Islands", "1-662-680-8999 x075" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Clay", "EE40353", "G324618", new DateTime(1996, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.Hickle83@hotmail.com", "Maryann", "Hickle", "Guyana", "224.596.3237 x7576" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Elsa", "EE36433", "G38503", new DateTime(1993, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Krista.Senger@yahoo.com", "Krista", "Senger", "Netherlands", "691-887-8880 x8671", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Uriah", "EE36904", 4, "G128490", new DateTime(1958, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ira_Gusikowski@yahoo.com", "Ira", "Gusikowski", "New Zealand", "1-754-884-9392 x3337" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Roosevelttown", "EE13528", 1, "G294013", new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Kelly_Ullrich@yahoo.com", "Kelly", "Ullrich", "Dominica", "1-702-540-7644 x71402", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Aletha", "EE49056", 4, "G335761", new DateTime(1976, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Wuckert51@yahoo.com", "Kerry", "Wuckert", "Monaco", "1-969-826-6054 x9210", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roslynville", "EE13121", 2, "G88456", new DateTime(1982, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jeannette_Zulauf6@hotmail.com", "Jeannette", "Zulauf", "Sudan", "482-785-1329" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Smithamville", "EE1820", "G270591", new DateTime(1952, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kurt_Thompson@yahoo.com", "Kurt", "Thompson", "Djibouti", "576.827.5819" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Shanahanside", "EE19367", 4, "G317531", new DateTime(1958, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jeremiah23@yahoo.com", "Jeremiah", "Weimann", "Central African Republic", "1-644-316-0550" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lessiehaven", "EE4074", 1, "G143554", new DateTime(1986, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Michele12@hotmail.com", "Michele", "Smitham", "Russian Federation", "(887) 493-0799", "Female" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Eleanore", "EE50237", "G321604", new DateTime(1996, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dan.Hahn@yahoo.com", "Dan", "Hahn", "Cape Verde", "1-640-461-1520 x566" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Martyberg", "EE13949", 4, "G453737", new DateTime(1958, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Gretchen_Ebert0@hotmail.com", "Gretchen", "Ebert", "Iraq", "518.377.6291", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Colefurt", "EE25141", 3, "G136986", new DateTime(1965, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy.Price44@hotmail.com", "Dorothy", "Price", "Iran", "(338) 452-4292 x1173", "Female" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Paxtonborough", "EE10796", 1, "G52610", new DateTime(1983, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Vicky_Hagenes94@yahoo.com", "Vicky", "Hagenes", "Saint Barthelemy", "(715) 528-7816 x912" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Randy", "EE32158", 3, "G305464", new DateTime(1972, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Joan_Casper@hotmail.com", "Joan", "Casper", "Philippines", "544-555-8035 x09549" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacksonmouth", "EE18962", 1, "G406523", new DateTime(1960, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Conrad.Morissette46@yahoo.com", "Conrad", "Morissette", "Italy", "604-863-2126 x12019" });

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
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Cristopher", "EE40182", "G57429", new DateTime(1988, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rickey.Ruecker@gmail.com", "Rickey", "Ruecker", "Namibia", "301-366-4880" });

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
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Darryl", "EE40078", 1, "G438192", new DateTime(1964, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Howard47@gmail.com", "Howard", "Windler", "Nauru", "(662) 427-4938 x7171", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Leonetown", "EE28523", 3, "G579037", new DateTime(1986, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Rick11@gmail.com", "Rick", "Williamson", "Brunei Darussalam", "234-402-4370 x9577", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wardborough", "EE31467", 3, "G420312", new DateTime(1986, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Geraldine64@yahoo.com", "Geraldine", "Kassulke", "Luxembourg", "932-615-1840 x75652", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Eddie", "EE51979", "G440243", new DateTime(1958, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jennie38@yahoo.com", "Jennie", "Koch", "Kazakhstan", "428.857.7064 x2794", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Aurelie", "EE11173", "G368551", new DateTime(1967, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Erica_Breitenberg72@gmail.com", "Erica", "Breitenberg", "Jordan", "315.927.1266", "Female" });

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
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Credit Card Account grow Nakfa", 14 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "withdrawal Alley Checking Account", 18 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Bedfordshire client-server River", 3 });

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
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Bedfordshire Home Loan Account digital", 15 });

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
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "New Jersey Guernsey Avon", 4 });

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
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Auto Loan Account deposit bypass", 15 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Developer Automotive, Music & Clothing International", 5 });

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
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "cyan fuchsia Motorway", 3 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "systems Credit Card Account Avon", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "bypass even-keeled Park", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "District calculating enhance", 5 });

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
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "1" });

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
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 8, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 10 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "A", 19 });

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
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 7 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 21, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 5 });

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
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 23 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 7 });

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
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 19, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 24, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 7, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 21, "0" });

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
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 3, "0" });

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
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 20 });

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
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 12, "0" });

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
                column: "moduleId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Della.Pouros@gmail.com", "Cedi", "Pouros", "Della" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Marjorie.Tillman@hotmail.com", "Automotive, Grocery & Electronics", "Tillman", "Marjorie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Clayton81@hotmail.com", "Identity", "Jacobs", "Clayton" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Anna85@hotmail.com", "Front-line", "Wintheiser", "Anna" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Ismael.Ullrich@gmail.com", "Tasty Metal Bacon", "Ullrich", "Ismael" });

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
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Viola44@yahoo.com", "Fantastic Cotton Chips", "Haag", "Viola" });

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
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Shelia_Grady22@yahoo.com", "payment", "Grady", "Shelia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Wilma6@yahoo.com", "Practical", "Rodriguez", "Wilma" });

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
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Caleb5@yahoo.com", "deposit", "Altenwerth", "Caleb" });

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
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Enrique_Cronin72@hotmail.com", "Planner", "Cronin", "Enrique" });

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
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Lorene.Berge@gmail.com", "payment", "Berge", "Lorene" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ida84@yahoo.com", "Research", "Sauer", "Ida" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Wilma67@hotmail.com", "Integration", "Zulauf", "Wilma" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Professeurs_professeurId",
                table: "Modules",
                column: "professeurId",
                principalTable: "Professeurs",
                principalColumn: "id");
        }
    }
}
