using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class addSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foreigns",
                columns: new[] { "Id", "FaragirCode", "FirstName", "LastName", "MobileNumber", "PassportCode", "SpecificCode", "YektaCode", "Address_City", "Address_PostalCode", "Address_Province", "Address_Street" },
                values: new object[,]
                {
                    { 1, 2020183946955830L, "ali", "test", "+980428034977", "6spkutr5o", 394485568538L, 9228535869L, "tehran", "123df", "yazd", "sha" },
                    { 2, 2132441656178547L, "bar", "bar", "+981394873565", "qz1plypvm", 694384171986L, 9986821242L, "tehran", "123df", "yazd", "test" },
                    { 3, 4677175592925525L, "ali", "mahdi", "+982942887691", "14br34yy4", 873345690414L, 9342747475L, "tehran", "12345fg", "yazd", "test" },
                    { 4, 3566192666105503L, "bar", "foor", "+982632330058", "hgbfjzkt6", 574599590715L, 9309528984L, "yazd", "12345fg", "yazd", "sha" },
                    { 5, 6802084162499253L, "ali", "ali", "+984288786791", "1uac9ymkm", 180529059242L, 9706273955L, "tehran", "123df", "tehran", "sha" },
                    { 6, 52203471355231L, "mahdi", "bar", "+985249764385", "9pp8ju2yp", 792764510233L, 9223092897L, "yazd", "123df", "yazd", "test" },
                    { 7, 2524579597797487L, "foor", "bar", "+983518051571", "i6dsgwnhp", 940662820223L, 9525394720L, "tehran", "12345fg", "yazd", "test" },
                    { 8, 5532523078380918L, "foor", "ali", "+989831011147", "tss4u7pti", 341846543887L, 9416942529L, "tehran", "123df", "tehran", "sha" },
                    { 9, 7107987088624063L, "foor", "foor", "+989587806159", "a7bwscior", 193503243369L, 9234918265L, "yazd", "123df", "tehran", "test" },
                    { 10, 6080303687991239L, "foor", "mahdi", "+987067300582", "dpnqswr8n", 781290581181L, 9799020172L, "yazd", "12345fg", "yazd", "test" },
                    { 11, 1691528402290896L, "test", "bar", "+982246405804", "zvjg96a3i", 580692858213L, 9444676770L, "tehran", "123df", "tehran", "sha" },
                    { 12, 6281719570249165L, "ali", "foor", "+982092998088", "kkcanywrb", 403157855276L, 9675329420L, "yazd", "123df", "tehran", "test" },
                    { 13, 2704247033902685L, "foor", "ali", "+985419182773", "f56o1hqsc", 722082210394L, 9144519593L, "yazd", "12345fg", "tehran", "test" },
                    { 14, 5343627933915706L, "bar", "bar", "+985957081908", "px3ijyhft", 444764022533L, 9711802427L, "tehran", "12345fg", "tehran", "test" },
                    { 15, 3729506924033609L, "test", "test", "+982106162811", "giz5rsou1", 970732869127L, 9415840261L, "yazd", "123df", "tehran", "sha" },
                    { 16, 9843620654963764L, "test", "mahdi", "+987214782886", "t2h9d7kt4", 880743954000L, 9056327415L, "tehran", "12345fg", "yazd", "test" },
                    { 17, 5740186264610873L, "foor", "foor", "+986866276063", "j7dr4vxzx", 185887598434L, 9988449923L, "tehran", "12345fg", "yazd", "sha" },
                    { 18, 1330184840023307L, "bar", "foor", "+989997944359", "5hzfb98kc", 607030053006L, 9970117104L, "yazd", "12345fg", "tehran", "test" },
                    { 19, 7368147526221460L, "test", "foor", "+983310489041", "wuvnxydvk", 297928088283L, 9251416597L, "tehran", "123df", "tehran", "sha" },
                    { 20, 6853696814545610L, "foor", "foor", "+989121176861", "ndgwd6xrq", 824324379509L, 9492070891L, "yazd", "123df", "tehran", "test" },
                    { 21, 8829699647090582L, "bar", "test", "+985866046304", "w8o7e9j64", 456517989456L, 9599480795L, "yazd", "12345fg", "tehran", "sha" },
                    { 22, 3806811390926527L, "foor", "ali", "+986302663377", "82svwl3cm", 726462081050L, 9694205802L, "yazd", "123df", "tehran", "test" },
                    { 23, 511068339208837L, "foor", "test", "+988074530503", "oocxjfxhy", 694679916147L, 9765044333L, "tehran", "12345fg", "yazd", "test" },
                    { 24, 5375074855575177L, "foor", "test", "+980967454462", "sdwx986jk", 331033110327L, 9222228117L, "yazd", "12345fg", "tehran", "sha" },
                    { 25, 4154257387042368L, "test", "foor", "+989530501487", "n1zgfquq5", 260322498664L, 9028644886L, "tehran", "12345fg", "tehran", "test" },
                    { 26, 7873634417833749L, "test", "test", "+988944931291", "jwfc89tt2", 780868692883L, 9877346216L, "tehran", "12345fg", "tehran", "sha" },
                    { 27, 5415230879710570L, "foor", "mahdi", "+987127836480", "428yz6o5n", 437983803065L, 9595439389L, "yazd", "12345fg", "yazd", "sha" },
                    { 28, 4699685184714913L, "foor", "test", "+983875127167", "1e2jpxddv", 697111114331L, 9187995743L, "tehran", "12345fg", "tehran", "sha" },
                    { 29, 4136360381766272L, "foor", "foor", "+988202802852", "z9ah51ssw", 321034059505L, 9158489487L, "tehran", "123df", "tehran", "sha" },
                    { 30, 1013917420685344L, "ali", "bar", "+987912076436", "5k6phpr5x", 426036902132L, 9787696017L, "yazd", "123df", "yazd", "test" },
                    { 31, 7940495412373160L, "ali", "test", "+987819030625", "p2zspy3y7", 741044511319L, 9811942512L, "tehran", "12345fg", "tehran", "test" },
                    { 32, 1898569955292532L, "mahdi", "foor", "+988740931670", "4sqvxvln2", 278914337404L, 9685237812L, "yazd", "123df", "tehran", "test" },
                    { 33, 919672849277690L, "bar", "mahdi", "+984594720142", "6v4n5c89a", 757160864027L, 9007845176L, "tehran", "12345fg", "yazd", "sha" },
                    { 34, 7246547330372248L, "bar", "foor", "+982176833751", "787rsm6ui", 889429228461L, 9845888811L, "tehran", "12345fg", "tehran", "sha" },
                    { 35, 556252755121309L, "bar", "ali", "+989280050296", "x3luw1ncv", 659694540752L, 9992472431L, "yazd", "12345fg", "tehran", "sha" },
                    { 36, 2033014755164616L, "foor", "ali", "+983222316758", "p69obdsnr", 203305155489L, 9927993637L, "yazd", "12345fg", "yazd", "sha" },
                    { 37, 5891177056512570L, "foor", "bar", "+984242943693", "p53dy6ju2", 719505004492L, 9985927683L, "yazd", "12345fg", "tehran", "sha" },
                    { 38, 3679011929806100L, "bar", "bar", "+984986276398", "v3gxp9bmf", 972981004458L, 9146771368L, "tehran", "12345fg", "tehran", "test" },
                    { 39, 6340398239553361L, "foor", "test", "+987004014963", "opyd6mmnw", 945958185477L, 9558469481L, "yazd", "12345fg", "tehran", "sha" },
                    { 40, 1992855954443653L, "test", "foor", "+988154493938", "qls7z6975", 360418146218L, 9887394874L, "tehran", "12345fg", "yazd", "sha" },
                    { 41, 6288008922426346L, "mahdi", "foor", "+980784210366", "b4u26bl9i", 877903919381L, 9984575446L, "yazd", "123df", "yazd", "sha" },
                    { 42, 3911052708210853L, "ali", "bar", "+988415716213", "82gxpacwn", 951222630318L, 9506919655L, "tehran", "12345fg", "tehran", "test" },
                    { 43, 6368933290783953L, "mahdi", "bar", "+988321189238", "zz9a9rul7", 425485551833L, 9402848599L, "tehran", "123df", "tehran", "sha" },
                    { 44, 3788620649380819L, "ali", "ali", "+983558769002", "7p89ydnnp", 270206639059L, 9353607441L, "tehran", "123df", "tehran", "sha" },
                    { 45, 2711286069242885L, "foor", "test", "+987792178514", "t32svo3hb", 389066850209L, 9004498568L, "yazd", "12345fg", "tehran", "sha" },
                    { 46, 2820873159142302L, "ali", "ali", "+982534147536", "vfbwsc9js", 612115669008L, 9722042009L, "yazd", "12345fg", "tehran", "test" },
                    { 47, 330922804297252L, "mahdi", "test", "+987808178540", "dilgrirnt", 811781165864L, 9279904330L, "tehran", "12345fg", "yazd", "test" },
                    { 48, 304698540601572L, "bar", "mahdi", "+989687435262", "e67x3zlus", 434867733371L, 9142115068L, "tehran", "12345fg", "tehran", "test" },
                    { 49, 6503805204268792L, "bar", "bar", "+985445348177", "4sz82nci4", 128935763566L, 9954299820L, "tehran", "12345fg", "yazd", "test" },
                    { 50, 6819470407738354L, "test", "ali", "+988788248140", "zdl3v7m6h", 454227750681L, 9245612736L, "tehran", "12345fg", "yazd", "sha" },
                    { 51, 8718975297991956L, "ali", "ali", "+987680889835", "2bbqbq5ka", 941568943165L, 9756166002L, "tehran", "12345fg", "yazd", "test" },
                    { 52, 7427487289285354L, "test", "test", "+983801182020", "sf4mzaeca", 327025289427L, 9868981312L, "tehran", "12345fg", "tehran", "test" },
                    { 53, 7912753882648259L, "ali", "foor", "+985679645398", "ly6jwbi59", 866555635592L, 9629405989L, "yazd", "123df", "tehran", "test" },
                    { 54, 1448443050730120L, "mahdi", "mahdi", "+985940020848", "qpg9ilj6o", 667423397690L, 9933300382L, "tehran", "12345fg", "tehran", "sha" },
                    { 55, 4369070435143876L, "test", "mahdi", "+988056147785", "j7wiu7qau", 496449712527L, 9343096042L, "tehran", "12345fg", "yazd", "test" },
                    { 56, 9030904437729551L, "foor", "test", "+980193051431", "rxxcl3wdi", 639744746667L, 9992233874L, "tehran", "12345fg", "tehran", "test" },
                    { 57, 237068999651287L, "ali", "bar", "+982055033560", "3lh6tjwys", 486809950944L, 9007819901L, "tehran", "12345fg", "tehran", "sha" },
                    { 58, 1319496282980190L, "bar", "bar", "+987502755339", "mpf4c8px3", 124829264454L, 9036540542L, "yazd", "123df", "tehran", "test" },
                    { 59, 1256370106505697L, "bar", "bar", "+986877621953", "5bz1mw4tw", 993537699509L, 9791360571L, "tehran", "123df", "tehran", "sha" },
                    { 60, 7065912948308266L, "test", "test", "+988800016182", "7vtq8y5xd", 442484603284L, 9667855433L, "tehran", "12345fg", "yazd", "test" },
                    { 61, 9331902461325637L, "ali", "test", "+987944317400", "15r6frzmm", 962779402775L, 9902486898L, "yazd", "123df", "tehran", "sha" },
                    { 62, 4621213114629529L, "mahdi", "ali", "+983455730972", "i5nng8uhp", 799177158532L, 9132678100L, "yazd", "123df", "yazd", "test" },
                    { 63, 1373304478964929L, "mahdi", "bar", "+981320462828", "ghxvg1d4v", 781373351759L, 9425517564L, "yazd", "12345fg", "tehran", "test" },
                    { 64, 4207817771492141L, "foor", "mahdi", "+981665249331", "qfojv64wm", 107398747437L, 9794739981L, "yazd", "123df", "tehran", "test" },
                    { 65, 4749756925797780L, "foor", "test", "+984006380482", "kcphyuvb8", 819914398784L, 9565115378L, "yazd", "12345fg", "yazd", "test" },
                    { 66, 3877447060355841L, "bar", "bar", "+980848291905", "9ilg4hco5", 120262628554L, 9803787554L, "yazd", "123df", "tehran", "test" },
                    { 67, 2271593847750895L, "mahdi", "ali", "+984221873116", "p5tnqvjc1", 962599460532L, 9572321966L, "tehran", "12345fg", "yazd", "sha" },
                    { 68, 252245442305125L, "test", "foor", "+980464234073", "dkgqch133", 741101523228L, 9427961037L, "yazd", "12345fg", "tehran", "test" },
                    { 69, 3335889340139046L, "foor", "foor", "+985047535421", "cfge8y1dx", 637553137012L, 9775621865L, "yazd", "12345fg", "yazd", "sha" },
                    { 70, 6680300762778941L, "bar", "ali", "+985580298625", "1hgarilo8", 334999437825L, 9015388740L, "tehran", "123df", "tehran", "test" },
                    { 71, 8178098324943132L, "test", "mahdi", "+981270270754", "udzgbu8du", 891190345305L, 9499168612L, "tehran", "12345fg", "yazd", "test" },
                    { 72, 295743733408700L, "bar", "test", "+984533147604", "lhfcm2vin", 963540576641L, 9903644317L, "tehran", "123df", "yazd", "sha" },
                    { 73, 2476667920179425L, "ali", "foor", "+987023312099", "fflezeavq", 473954909040L, 9073927020L, "yazd", "123df", "tehran", "sha" },
                    { 74, 4095066078145690L, "mahdi", "ali", "+987908240590", "pnd6z77s1", 810756778610L, 9140973074L, "yazd", "12345fg", "tehran", "sha" },
                    { 75, 3496946778150168L, "test", "foor", "+987656667610", "wnyli1kcp", 448326180173L, 9908896910L, "tehran", "12345fg", "tehran", "test" },
                    { 76, 108935544968379L, "mahdi", "foor", "+987677376211", "pdxo1166s", 245101418712L, 9222907709L, "tehran", "12345fg", "tehran", "sha" },
                    { 77, 5289405966526660L, "mahdi", "mahdi", "+986116032711", "qniqey33i", 488773924237L, 9717548405L, "tehran", "12345fg", "yazd", "sha" },
                    { 78, 1354656956970364L, "bar", "mahdi", "+983099484966", "79fxbnjug", 766370911021L, 9382480161L, "yazd", "12345fg", "tehran", "test" },
                    { 79, 1586885054176756L, "foor", "foor", "+983465371318", "nuunogp1i", 299052203758L, 9258765902L, "tehran", "123df", "yazd", "test" },
                    { 80, 382940039437271L, "test", "ali", "+984169115136", "5gcdt2x77", 994218485839L, 9126671684L, "yazd", "12345fg", "tehran", "sha" },
                    { 81, 4032409953077149L, "ali", "ali", "+987642729332", "bxosne5oe", 882997687793L, 9082073348L, "yazd", "123df", "yazd", "test" },
                    { 82, 9848264019836363L, "bar", "bar", "+983026601313", "lt2uo7svi", 560408432611L, 9462066911L, "tehran", "12345fg", "yazd", "test" },
                    { 83, 4695901451810293L, "test", "mahdi", "+986937354835", "ddq5heaju", 706487484219L, 9291167763L, "yazd", "12345fg", "yazd", "sha" },
                    { 84, 5011643875996973L, "bar", "bar", "+986890485890", "wdzb9ebgo", 399340525456L, 9613460439L, "yazd", "12345fg", "yazd", "test" },
                    { 85, 8573703860603406L, "ali", "test", "+984209323274", "1xrat82rq", 926743714540L, 9826421735L, "tehran", "12345fg", "tehran", "test" },
                    { 86, 3529001556965752L, "test", "bar", "+984792643987", "2w89qzbqm", 251169995939L, 9090503693L, "tehran", "12345fg", "yazd", "test" },
                    { 87, 2390969161013634L, "ali", "ali", "+987452274749", "ler19nkul", 302046176445L, 9272561325L, "tehran", "123df", "yazd", "sha" },
                    { 88, 6044805171759918L, "bar", "foor", "+982175795470", "tp8v46py2", 359302771235L, 9702541406L, "tehran", "12345fg", "yazd", "test" },
                    { 89, 9644290086649645L, "mahdi", "test", "+988040933516", "elqeb9sqs", 764041384150L, 9398355267L, "tehran", "123df", "tehran", "sha" },
                    { 90, 1957983978120294L, "ali", "foor", "+985559308481", "s1sp87thz", 360872062432L, 9337614945L, "tehran", "12345fg", "yazd", "test" },
                    { 91, 1189361387839564L, "mahdi", "mahdi", "+988727083040", "ebb4jiqla", 449930976476L, 9384643073L, "tehran", "123df", "tehran", "sha" },
                    { 92, 9215320188091377L, "mahdi", "test", "+984211447588", "wq8kfnkz4", 795881013132L, 9331394380L, "tehran", "12345fg", "tehran", "test" },
                    { 93, 5885963615535716L, "bar", "bar", "+982629401366", "yu7gyy63h", 906551179925L, 9883779087L, "tehran", "12345fg", "yazd", "sha" },
                    { 94, 3632946963791054L, "ali", "mahdi", "+982821981120", "79as1vuf3", 947631510192L, 9136067406L, "yazd", "123df", "tehran", "sha" },
                    { 95, 1878753484185257L, "ali", "mahdi", "+982362770388", "9y28qxmkj", 543496003223L, 9580073925L, "tehran", "12345fg", "tehran", "test" },
                    { 96, 2758257549306358L, "test", "mahdi", "+988355026189", "iq8y4v5q5", 149693221574L, 9603949653L, "tehran", "12345fg", "yazd", "sha" },
                    { 97, 2392951702944597L, "bar", "test", "+988888492519", "rieaqsn6c", 227328974808L, 9760205699L, "yazd", "12345fg", "yazd", "test" },
                    { 98, 8040998729618906L, "ali", "mahdi", "+986451139352", "nuz76lg6s", 466763691542L, 9727539566L, "yazd", "123df", "tehran", "test" },
                    { 99, 1661037248697417L, "ali", "mahdi", "+988531077216", "auebvqsyx", 335852777037L, 9866457638L, "yazd", "123df", "tehran", "sha" }
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
