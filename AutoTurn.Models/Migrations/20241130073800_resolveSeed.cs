﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class resolveSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foreigns",
                columns: new[] { "Id", "FaragirCode", "FirstName", "LastName", "MobileNumber", "PassportCode", "SpecificCode", "YektaCode", "Address_City", "Address_PostalCode", "Address_Province", "Address_Street" },
                values: new object[,]
                {
                    { 1, 342868932869761L, "ali", "ali", "+986258112510", "if94t9zjz", 295680582291L, 9172058363L, "tehran", "12345fg", "tehran", "test" },
                    { 2, 8277395285857826L, "test", "ali", "+981297922357", "ui3gfxz99", 975255475606L, 9110294051L, "tehran", "123df", "yazd", "test" },
                    { 3, 2365374059664878L, "test", "foor", "+980528913386", "1u9u3bc66", 404524718680L, 9603861670L, "tehran", "123df", "yazd", "sha" },
                    { 4, 6048550656249344L, "ali", "ali", "+983493446414", "scd97ihhz", 232267357994L, 9748813660L, "yazd", "12345fg", "yazd", "test" },
                    { 5, 3091895772822696L, "foor", "mahdi", "+987019186928", "2alfmvtsz", 783720468739L, 9064707298L, "tehran", "12345fg", "tehran", "sha" },
                    { 6, 3601324166170866L, "ali", "ali", "+985008354189", "lmo287jg1", 125926224778L, 9390221399L, "tehran", "123df", "tehran", "test" },
                    { 7, 1869950235999339L, "foor", "bar", "+988327315866", "dedeygtkx", 337271398685L, 9283235558L, "tehran", "123df", "tehran", "test" },
                    { 8, 745744195246676L, "ali", "ali", "+985953956256", "mnzngl1pl", 806539751878L, 9670840982L, "yazd", "12345fg", "tehran", "sha" },
                    { 9, 4920827805014565L, "foor", "foor", "+989581421949", "vqtjl12a2", 969824599588L, 9848296138L, "tehran", "12345fg", "tehran", "test" },
                    { 10, 7866238810373405L, "mahdi", "ali", "+987284551025", "394mvjgh5", 898227222208L, 9773436962L, "yazd", "12345fg", "yazd", "sha" },
                    { 11, 8826336125737809L, "ali", "foor", "+989068818141", "fxq618d4a", 453011025879L, 9947524677L, "yazd", "123df", "yazd", "sha" },
                    { 12, 7186042395032216L, "bar", "mahdi", "+981159390370", "xfci923hj", 873150114641L, 9359022747L, "yazd", "12345fg", "yazd", "test" },
                    { 13, 7886819453894187L, "bar", "ali", "+986812742390", "dng1tdzvh", 872603595889L, 9507295122L, "tehran", "12345fg", "tehran", "sha" },
                    { 14, 7647880297215707L, "foor", "bar", "+989955069298", "7bb1s1ps9", 199759472028L, 9385207078L, "yazd", "123df", "yazd", "sha" },
                    { 15, 8395157063954901L, "bar", "bar", "+989642802942", "cl8guvsap", 167203173737L, 9255313046L, "yazd", "123df", "yazd", "sha" },
                    { 16, 6838251920913880L, "bar", "ali", "+980312909980", "ewjhp6tv9", 850871708140L, 9012319477L, "tehran", "123df", "tehran", "test" },
                    { 17, 3288267235794096L, "bar", "mahdi", "+982436673726", "q46n796ge", 354035062233L, 9815375122L, "tehran", "12345fg", "tehran", "sha" },
                    { 18, 5876566513240971L, "test", "bar", "+983363510300", "ww5hz7po6", 786244178488L, 9527006497L, "yazd", "12345fg", "yazd", "sha" },
                    { 19, 2321406099623136L, "bar", "ali", "+984382217297", "ew65wrbkh", 745040830521L, 9307563383L, "yazd", "123df", "tehran", "sha" },
                    { 20, 2754875316481861L, "bar", "foor", "+983053268139", "eckjuejgv", 651128849400L, 9905107018L, "tehran", "12345fg", "yazd", "test" },
                    { 21, 1072509748244335L, "bar", "test", "+986075435868", "uev1mh456", 540888892213L, 9467467120L, "yazd", "123df", "tehran", "sha" },
                    { 22, 3532574162742977L, "bar", "mahdi", "+986706051042", "bugluzx15", 297590987510L, 9296058461L, "tehran", "12345fg", "yazd", "test" },
                    { 23, 6550524476152785L, "mahdi", "mahdi", "+985329622668", "5g4plqc78", 461701140757L, 9345093329L, "yazd", "12345fg", "yazd", "sha" },
                    { 24, 1010284721614999L, "mahdi", "bar", "+982395806966", "vgnoh8xqh", 145560321979L, 9233039244L, "yazd", "12345fg", "tehran", "sha" },
                    { 25, 2434867536058874L, "test", "ali", "+980081805401", "w6tu4iqyj", 280632189844L, 9845140044L, "tehran", "12345fg", "tehran", "test" },
                    { 26, 1906727243287740L, "mahdi", "foor", "+985734800124", "yba31agxc", 962541084902L, 9840630748L, "tehran", "123df", "yazd", "sha" },
                    { 27, 1900582779705253L, "bar", "mahdi", "+989638728666", "hu8gm3oev", 621190810214L, 9279927738L, "tehran", "123df", "tehran", "test" },
                    { 28, 4402525448283152L, "foor", "test", "+986648441027", "f1h1nb7f1", 497307437541L, 9724877292L, "yazd", "123df", "tehran", "test" },
                    { 29, 5975766175132780L, "test", "test", "+985391170992", "q67jp7sbf", 659997258432L, 9413173868L, "tehran", "12345fg", "yazd", "sha" },
                    { 30, 7407023999427214L, "test", "bar", "+981283071335", "xzqe7mher", 138184932583L, 9454065973L, "yazd", "123df", "tehran", "sha" },
                    { 31, 6865944650144764L, "test", "foor", "+986593021494", "jm5qnfh2m", 914089212281L, 9776888339L, "yazd", "123df", "tehran", "sha" },
                    { 32, 4304127938768739L, "ali", "foor", "+980331169725", "g7ffrfrb8", 603182292349L, 9510853973L, "yazd", "12345fg", "tehran", "sha" },
                    { 33, 9087085476812651L, "ali", "foor", "+985687525545", "igcz26yei", 363834742675L, 9634917338L, "tehran", "12345fg", "yazd", "sha" },
                    { 34, 366527154247545L, "foor", "mahdi", "+985557615707", "9nq69euve", 118062577328L, 9424716240L, "tehran", "123df", "tehran", "sha" },
                    { 35, 3346581817255833L, "test", "mahdi", "+983477824803", "um7g55hvv", 368190105155L, 9582821609L, "yazd", "12345fg", "tehran", "test" },
                    { 36, 7047467503366259L, "bar", "mahdi", "+981437234358", "4wvn8n1qh", 991939927705L, 9818424417L, "tehran", "123df", "yazd", "sha" },
                    { 37, 7144810158549406L, "foor", "test", "+989687520678", "uusyulcv7", 137848087170L, 9592737349L, "tehran", "12345fg", "yazd", "test" },
                    { 38, 5067300300221758L, "ali", "mahdi", "+980087473986", "ehbgt64qr", 826178608098L, 9436589138L, "tehran", "123df", "tehran", "test" },
                    { 39, 3112862236668402L, "bar", "mahdi", "+985786860592", "3h91q4wui", 387194861067L, 9982718901L, "tehran", "123df", "tehran", "test" },
                    { 40, 4193510328049019L, "test", "test", "+988738643282", "f4dwbsdqk", 809450888690L, 9300412838L, "yazd", "123df", "yazd", "sha" },
                    { 41, 2448246749143306L, "test", "ali", "+986085846230", "hhpq76ze2", 408707132687L, 9089495970L, "yazd", "12345fg", "tehran", "test" },
                    { 42, 8213259610681140L, "bar", "test", "+986313965676", "aylp7ozqd", 333455577613L, 9587998272L, "yazd", "123df", "yazd", "sha" },
                    { 43, 4329108004934814L, "bar", "foor", "+981696601075", "mcfxyxydq", 409070726952L, 9182263222L, "tehran", "123df", "yazd", "sha" },
                    { 44, 5186856106950413L, "mahdi", "foor", "+984952770590", "6eavctaxs", 516970326610L, 9087288860L, "yazd", "12345fg", "tehran", "sha" },
                    { 45, 3286430023385470L, "mahdi", "test", "+983306130410", "a89jnhtot", 853217235094L, 9385536170L, "tehran", "12345fg", "yazd", "sha" },
                    { 46, 1531540430304792L, "ali", "mahdi", "+980865855073", "3smwt9hl9", 979453461520L, 9815143558L, "yazd", "12345fg", "yazd", "test" },
                    { 47, 8046468772574743L, "bar", "mahdi", "+984030766638", "fgwp4lnka", 782085522415L, 9140256461L, "tehran", "12345fg", "yazd", "test" },
                    { 48, 5107070423380886L, "bar", "mahdi", "+984017045839", "bnv4welbd", 232916060740L, 9515994518L, "tehran", "12345fg", "yazd", "sha" },
                    { 49, 4027917633739384L, "ali", "bar", "+982261419194", "5g4qstwpe", 670182191159L, 9085846464L, "yazd", "123df", "tehran", "test" },
                    { 50, 2277204961610669L, "ali", "foor", "+985096974856", "fza4jvu7h", 716317409922L, 9948630008L, "tehran", "12345fg", "yazd", "sha" },
                    { 51, 3385315632080245L, "bar", "test", "+982241965476", "7i14k176o", 502533140575L, 9447949152L, "tehran", "123df", "yazd", "sha" },
                    { 52, 2944874752019119L, "test", "bar", "+984927938899", "2hm7m2eto", 438272986133L, 9343102218L, "tehran", "12345fg", "tehran", "sha" },
                    { 53, 6113967009996446L, "foor", "test", "+985476683352", "qfnvjb4tv", 118542981710L, 9433142931L, "yazd", "12345fg", "yazd", "sha" },
                    { 54, 1876668901112554L, "test", "ali", "+988335949740", "e7yubnwwn", 636500172303L, 9574966461L, "yazd", "123df", "yazd", "test" },
                    { 55, 289375964077832L, "bar", "bar", "+980777918713", "3bc3b7sds", 965978181216L, 9268127632L, "yazd", "123df", "tehran", "test" },
                    { 56, 5698514209207150L, "bar", "mahdi", "+982086054918", "mq2r4mnu5", 581563498146L, 9864851842L, "yazd", "12345fg", "tehran", "sha" },
                    { 57, 4190019477998860L, "mahdi", "test", "+980590568834", "b9gg21gcl", 388789489706L, 9175128853L, "yazd", "123df", "yazd", "sha" },
                    { 58, 6208965321565210L, "foor", "ali", "+982437501718", "fz253juzr", 823254760378L, 9447892294L, "tehran", "12345fg", "yazd", "test" },
                    { 59, 860048644868660L, "mahdi", "ali", "+988622662184", "87gjntsok", 929790830517L, 9732854109L, "tehran", "12345fg", "tehran", "test" },
                    { 60, 8901981019386364L, "bar", "bar", "+989717353102", "2439xftdh", 427089237224L, 9388000259L, "yazd", "123df", "tehran", "sha" },
                    { 61, 7871957465562350L, "bar", "mahdi", "+984652173471", "mktv1vfc9", 136195895003L, 9641034459L, "yazd", "12345fg", "yazd", "sha" },
                    { 62, 6810623003350815L, "test", "ali", "+984607875125", "zhblxm2aj", 373005188349L, 9185483493L, "tehran", "123df", "tehran", "sha" },
                    { 63, 8519830154766225L, "mahdi", "mahdi", "+984598530324", "v8c8ukgpn", 979838514504L, 9126617864L, "yazd", "12345fg", "yazd", "test" },
                    { 64, 1554702863678758L, "test", "foor", "+982856855472", "uuzgai5ow", 734973365759L, 9610440180L, "yazd", "123df", "tehran", "test" },
                    { 65, 9433789672836408L, "test", "foor", "+985419147780", "7u9aqqf3c", 308610015039L, 9572638995L, "tehran", "12345fg", "yazd", "sha" },
                    { 66, 1463399913579587L, "bar", "ali", "+981389403088", "44q6qxbzy", 427870770966L, 9009118407L, "tehran", "12345fg", "yazd", "sha" },
                    { 67, 7606853763977063L, "bar", "ali", "+982715186312", "uyxq2wvy8", 939599003122L, 9075343265L, "yazd", "12345fg", "tehran", "test" },
                    { 68, 5833120523325337L, "ali", "ali", "+982489231159", "ju8aytny5", 891796306661L, 9008393415L, "yazd", "12345fg", "yazd", "sha" },
                    { 69, 4705573941462626L, "test", "mahdi", "+980611299731", "lavhmmddi", 770368934159L, 9428084060L, "yazd", "12345fg", "tehran", "sha" },
                    { 70, 8764700353277139L, "foor", "test", "+983596108683", "cssbxcxmt", 552442552904L, 9544108881L, "tehran", "123df", "yazd", "test" },
                    { 71, 3139892492166440L, "bar", "mahdi", "+988022533153", "p5j1vceke", 943521348692L, 9961890508L, "tehran", "123df", "tehran", "sha" },
                    { 72, 4309569822795826L, "ali", "foor", "+980212010532", "h5yefdh9e", 547272621570L, 9686168911L, "tehran", "12345fg", "tehran", "test" },
                    { 73, 6666561439009368L, "mahdi", "ali", "+983117705101", "nm6ddloy5", 655322039556L, 9908533939L, "tehran", "12345fg", "yazd", "test" },
                    { 74, 5546952288605928L, "ali", "bar", "+988910846760", "hof7v7atr", 745727622540L, 9116726787L, "tehran", "123df", "yazd", "sha" },
                    { 75, 5462131319844099L, "ali", "foor", "+988219981641", "95ol97gb5", 633926703114L, 9457510902L, "tehran", "12345fg", "tehran", "test" },
                    { 76, 6751710774676523L, "mahdi", "mahdi", "+980777267771", "8t72798c3", 752758304513L, 9376183394L, "tehran", "123df", "yazd", "test" },
                    { 77, 2010778694939410L, "mahdi", "mahdi", "+982885618355", "lahlqd39y", 861938713242L, 9709076700L, "tehran", "123df", "yazd", "test" },
                    { 78, 2749900010003082L, "mahdi", "test", "+980747088498", "wmrlvl4za", 403511439348L, 9652475570L, "yazd", "123df", "tehran", "test" },
                    { 79, 7989575910647300L, "ali", "foor", "+980534852047", "77kigvyry", 150360830465L, 9978406576L, "tehran", "123df", "tehran", "sha" },
                    { 80, 3040580086885476L, "ali", "bar", "+982418486781", "v6r6hzvlc", 166756061196L, 9546552222L, "yazd", "123df", "yazd", "sha" },
                    { 81, 5637224919669097L, "bar", "test", "+980152041249", "q66qaqez1", 736884872814L, 9735344120L, "tehran", "12345fg", "yazd", "test" },
                    { 82, 7063280451725146L, "bar", "foor", "+988373010052", "d4oyncqiv", 968593877210L, 9532636555L, "yazd", "123df", "tehran", "test" },
                    { 83, 861661017108812L, "test", "bar", "+989306644571", "e23zvi5ge", 663866388428L, 9960842895L, "yazd", "12345fg", "yazd", "sha" },
                    { 84, 6972465330470662L, "foor", "ali", "+984115289210", "xiuqwbvbn", 764086763304L, 9549592376L, "tehran", "123df", "tehran", "test" },
                    { 85, 8001134306489097L, "bar", "test", "+983882361839", "293u189w5", 948276401488L, 9249169007L, "tehran", "123df", "yazd", "sha" },
                    { 86, 2880051734220668L, "bar", "foor", "+988108959169", "5e9vxzxdy", 199537044587L, 9261775448L, "tehran", "123df", "yazd", "test" },
                    { 87, 2621126917099489L, "bar", "ali", "+982087639841", "bphls5uo7", 910016899142L, 9383550572L, "yazd", "123df", "yazd", "test" },
                    { 88, 7671150230408708L, "ali", "bar", "+986669828975", "8l3yj5evg", 480534627638L, 9910018077L, "yazd", "123df", "tehran", "sha" },
                    { 89, 9651682328010536L, "ali", "bar", "+987993235376", "7g5qfhgud", 291770085013L, 9296058552L, "tehran", "123df", "tehran", "sha" },
                    { 90, 2480018461138209L, "foor", "test", "+986115256927", "8xw1s7rsh", 578267697204L, 9183606763L, "yazd", "123df", "yazd", "test" },
                    { 91, 8904564131604962L, "foor", "test", "+982686895773", "uazgqi5ko", 138008100261L, 9428852475L, "tehran", "123df", "tehran", "sha" },
                    { 92, 2081949366830103L, "foor", "bar", "+986866221505", "woixu4k3n", 875133194355L, 9573448606L, "yazd", "123df", "tehran", "test" },
                    { 93, 6822015518116133L, "mahdi", "test", "+985308782252", "zkr943cvj", 695503985521L, 9069389881L, "tehran", "12345fg", "yazd", "sha" },
                    { 94, 3040374930289661L, "mahdi", "ali", "+986132353719", "huvf2k8w6", 277095716746L, 9416951660L, "yazd", "12345fg", "yazd", "sha" },
                    { 95, 6900897870459684L, "mahdi", "foor", "+981214689810", "pg4bey4gr", 733564934804L, 9626193328L, "yazd", "12345fg", "tehran", "test" },
                    { 96, 6241084060515677L, "foor", "mahdi", "+983322334716", "px11lwul3", 541923220734L, 9227140582L, "tehran", "123df", "yazd", "sha" },
                    { 97, 8367722672876066L, "bar", "mahdi", "+981335585206", "gim22u4bf", 309817919405L, 9436555562L, "tehran", "12345fg", "tehran", "test" },
                    { 98, 423085568272810L, "foor", "foor", "+980383036035", "ho9fe7mtg", 363630407015L, 9103196832L, "yazd", "123df", "tehran", "sha" },
                    { 99, 3474637737952100L, "test", "bar", "+983669056962", "ptfotieo1", 597274946556L, 9767021110L, "tehran", "123df", "tehran", "sha" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Foreigns",
                keyColumn: "Id",
                keyValue: 99);
        }
    }
}
