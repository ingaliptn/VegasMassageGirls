namespace Domain.Models
{
    public static class Constants
    {
#if DEBUG
        //public const string DefaultConnection = "Server=DESKTOP-7NM2Q2N;Database=DreamGirlsBd;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string DefaultConnection = "Server=12.2.222.14;Database=DreamGirlsBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100";
#else
        //.102
        //public const string DefaultConnection =
        //    "Server=SP-VL;Database=DreamGirlsBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100";
        //185.165.168.2
        public const string DefaultConnection =
            "Server=SP-DB;Database=DreamGirlsBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100";
#endif
        //public const string SiteName = "www.dreamgirlsphoenix.com";
        //public const string SitePhone = "(480) 565-8850";
        //public const string SitePhoneRef = "+14805658850";
        //public const string SiteEmail = "info@dreamgirlsphoenix.com";
        //public const string SiteContentLocation = "Phoenix";

        //public const string SiteName = "www.dreamgirlshawaii.com";
        //public const string SitePhone = "(880) 427-9980";
        //public const string SitePhoneRef = "+18084279980";
        //public const string SiteEmail = "info@.dreamgirlshawaii.com";
        //public const string SiteContentLocation = "Hawaii";

        //public const string SiteName = "www.dreamgirlsseattle.com";
        //public const string SitePhone = "(206) 486-1971";
        //public const string SitePhoneRef = "+12064861971";
        //public const string SiteEmail = "info@dreamgirlsseattle.com";
        //public const string SiteContentLocation = "Seattle";
        //public const string SiteDreamGirlsLocation = "DreamGirlsSeattle";

        //https://www.dreamgirlsdetroit.com
        //public const string SiteName = "www.dreamgirlsdetroit.com";
        //public const string SitePhone = "(313) 424-4461";
        //public const string SitePhoneRef = "+13134244461";
        //public const string SiteEmail = "info@dreamgirlsdetroit.com";
        //public const string SiteContentLocation = "Detroit";
        //public const string SiteDreamGirlsLocation = "DreamGirlsDetroit";

        //https://www.dreamgirlschicago.com
        //public const string SiteName = "www.dreamgirlschicago.com";
        //public const string SitePhone = "(312) 667-9107";
        //public const string SitePhoneRef = "+13126679107";
        //public const string SiteEmail = "info@dreamgirlschicago.com";
        //public const string SiteContentLocation = "Chicago";
        //public const string SiteDreamGirlsLocation = "DreamGirlsChicago";

        //https://www.dreamgirlslosangeles.com
        //public const string SiteName = "www.dreamgirlslosangeles.com";
        //public const string SitePhone = "(213) 985-2226";
        //public const string SitePhoneRef = "+12139852226";
        //public const string SiteEmail = "info@dreamgirlslosangeles.com";
        //public const string SiteContentLocation = "LosAngeles";
        //public const string SiteDreamGirlsLocation = "DreamGirlsLosAngeles";

        //https://www.dreamgirlsneworleans.com
        //public const string SiteName = "www.dreamgirlsneworleans.com";
        //public const string SitePhone = "(504) 681-9810";
        //public const string SitePhoneRef = "+1504681-9810";
        //public const string SiteEmail = "info@dreamgirlsneworleans.com";
        //public const string SiteContentLocation = "NewOrleans";
        //public const string SiteDreamGirlsLocation = "DreamGirlsNewOrleans";

        //https://www.dreamgirlspalmsprings.com
        //public const string SiteName = "www.dreamgirlspalmsprings.com";
        //public const string SitePhone = "(760) 607-3490";
        //public const string SitePhoneRef = "+17606073490";
        //public const string SiteEmail = "info@dreamgirlspalmsprings.com";
        //public const string SiteContentLocation = "Palmsprings";
        //public const string SiteDreamGirlsLocation = "DreamGirlsPalmsprings";

        //https://www.dreamgirlsreno.com
        //public const string SiteName = "www.dreamgirlsreno.com";
        //public const string SitePhone = "(775) 372-9570";
        //public const string SitePhoneRef = "+17753729570";
        //public const string SiteEmail = "info@dreamgirlsreno.com";
        //public const string SiteContentLocation = "Reno";
        //public const string SiteDreamGirlsLocation = "DreamGirlsReno";

        //https://www.dreamgirlsorlando.com
        //public const string SiteName = "www.dreamgirlsorlando.com";
        //public const string SitePhone = "(407) 845-9430";
        //public const string SitePhoneRef = "+14078459430";
        //public const string SiteEmail = "info@dreamgirlsorlando.com";
        //public const string SiteContentLocation = "Orlando";
        //public const string SiteDreamGirlsLocation = "DreamGirlsOrlando";

        //https://www.dreamgirlsatlanta.com/
        //public const string SiteName = "www.dreamgirlsatlanta.com";
        //public const string SitePhone = "(404) 891-1380";
        //public const string SitePhoneRef = "+14048911380";
        //public const string SiteEmail = "info@dreamgirlsatlanta.com";
        //public const string SiteContentLocation = "Atlanta";
        //public const string SiteDreamGirlsLocation = "DreamGirlsAtlanta";

        //https://www.dreamgirlssandiego.com
        //public const string SiteName = "www.dreamgirlssandiego.com";
        //public const string SitePhone = "(619) 916-3125";
        //public const string SitePhoneRef = "+16199163125";
        //public const string SiteEmail = "info@dreamgirlssandiego.com";
        //public const string SiteContentLocation = "SanDiego";
        //public const string SiteDreamGirlsLocation = "DreamGirlsSanDiego";

        //https://www.dreamgirlsboston.com
        //public const string SiteName = "www.dreamgirlsboston.com";
        //public const string SitePhone = "(617) 996-8472";
        //public const string SitePhoneRef = "+16179968472";
        //public const string SiteEmail = "info@dreamgirlsboston.com";
        //public const string SiteContentLocation = "Boston";
        //public const string SiteDreamGirlsLocation = "DreamGirlsBoston";

        //https://www.dreamgirlshouston.com
        //public const string SiteName = "www.dreamgirlshouston.com";
        //public const string SitePhone = "(713) 955-2588";
        //public const string SitePhoneRef = "+17139552588";
        //public const string SiteEmail = "info@dreamgirlshouston.com";
        //public const string SiteContentLocation = "Houston";
        //public const string SiteDreamGirlsLocation = "DreamGirlsHouston";

        //https://www.atlantamassagegirls.com
        //public const string SiteName = "www.atlantamassagegirls.com";
        //public const string SitePhone = "(404) 891-1382";
        //public const string SitePhoneRef = "+14048911382";
        //public const string SiteEmail = "ams@atlantamassagegirls.com";
        //public const string SiteContentLocation = "Atlanta";
        //public const string SiteDreamGirlsLocation = "DreamGirlsAtlanta";


        //https://www.bostonmassagegirls.com
        //public const string SiteName = "www.bostonmassagegirls.com";
        //public const string SitePhone = "(617) 996-8471";
        //public const string SitePhoneRef = "+16179968471";
        //public const string SiteEmail = "bmg@bostonmassagegirls.com";
        //public const string SiteContentLocation = "Boston";
        //public const string SiteDreamGirlsLocation = "Boston Massage Girls";

        //https://www.chicagomassagegirls.com
        //public const string SiteName = "www.chicagomassagegirls.com";
        //public const string SitePhone = "(312) 392-0720";
        //public const string SitePhoneRef = "+13123920720";
        //public const string SiteEmail = "info@chicagomassagegirls.com";
        //public const string SiteContentLocation = "Chicago";
        //public const string SiteDreamGirlsLocation = "Chicago Massage Girls";

        //https://www.houstonmassagegirls.com
        //public const string SiteName = "www.houstonmassagegirls.com";
        //public const string SitePhone = "(713) 357-6886";
        //public const string SitePhoneRef = "+17133576880";
        //public const string SiteEmail = "info@houstonmassagegirls.com";
        //public const string SiteContentLocation = "Houston";
        //public const string SiteDreamGirlsLocation = "Houston Massage Girls";

        //https://www.denvermassagegirls.com
        //public const string SiteName = "www.denvermassagegirls.com";
        //public const string SitePhone = "(720) 679-8808";
        //public const string SitePhoneRef = "+17206798808";
        //public const string SiteEmail = "info@denvermassagegirls.com";
        //public const string SiteContentLocation = "Denver";
        //public const string SiteDreamGirlsLocation = "Denver Massage Girls";

        //https://www.losangelesmassagegirls.com
        //public const string SiteName = "www.losangelesmassagegirls.com";
        //public const string SitePhone = "(323) 417-5255";
        //public const string SitePhoneRef = "+13234175255";
        //public const string SiteEmail = "info@losangelesmassagegirls.com";
        //public const string SiteContentLocation = "Los Angeles";
        //public const string SiteDreamGirlsLocation = "Los Angeles Massage Girls";

        //https://www.newyorkmassagegirls.com
        //public const string SiteName = "www.newyorkmassagegirls.com";
        //public const string SitePhone = "(929) 399-2740";
        //public const string SitePhoneRef = "+19293992740";
        //public const string SiteEmail = "info@newyorkmassagegirls.com";
        //public const string SiteContentLocation = "New York";
        //public const string SiteDreamGirlsLocation = "New York Massage Girls";

        //https://www.sandiegomassagegirls.com
        //public const string SiteName = "www.sandiegomassagegirls.com";
        //public const string SitePhone = "(619) 720-6330";
        //public const string SitePhoneRef = "+16197206330";
        //public const string SiteEmail = "info@sandiegomassagegirls.com";
        //public const string SiteContentLocation = "San Diego";
        //public const string SiteDreamGirlsLocation = "San Diego Massage Girls";

        //https://www.dreamgirlsriga.com
        //public const string SiteName = "www.dreamgirlsriga.com";
        //public const string SitePhone = "+3(725) 321-3558";
        //public const string SitePhoneRef = "+37253213558";
        //public const string SiteEmail = "info@dreamgirlsriga.com";
        //public const string SiteContentLocation = "Riga";
        //public const string SiteDreamGirlsLocation = "DreamGirlsRiga";

        //https://www.dreamgirlsistanbul.com
        //public const string SiteName = "www.dreamgirlsistanbul.com";
        //public const string SitePhone = "+90(546) 638-8900";
        //public const string SitePhoneRef = "+905466388900";
        //public const string SiteEmail = "info@dreamgirlsistanbul.com";
        //public const string SiteContentLocation = "Istanbul";
        //public const string SiteDreamGirlsLocation = "DreamGirlsIstanbul";

        //https://www.dreamgirlslasvegas.com
        //public const string SiteName = "www.dreamgirlslasvegas.com";
        //public const string SitePhone = "(702) 852-3020";
        //public const string SitePhoneRef = "+17028523020";
        //public const string SiteEmail = "info@dreamgirlslasvegas.com";
        //public const string SiteContentLocation = "Las Vegas";
        //public const string SiteDreamGirlsLocation = "DreamGirlsLasVegas";

        //https://www.dreamgirlsengland.com
        //public const string SiteName = "www.dreamgirlsengland.com";
        //public const string SitePhone = "+44 (752) 063-5750";
        //public const string SitePhoneRef = "+447520635750";
        //public const string SiteEmail = "info@dreamgirlsengland.com";
        //public const string SiteContentLocation = "England";
        //public const string SiteCountry = "UK";
        //public const string SiteDreamGirlsLocation = "DreamGirlsEngland";

        //https://www.dreamgirlssaltlakecity.com
        //public const string SiteName = "www.dreamgirlssaltlakecity.com";
        //public const string SitePhone = "(801) 441-6790";
        //public const string SitePhoneRef = "+18014416790";
        //public const string SiteEmail = "info@dreamgirlssaltlakecity.com";
        //public const string SiteContentLocation = "Salt Lake City";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsSaltLakeCity";

        //https://www.dreamgirlssanfrancisco.com
        //public const string SiteName = "www.dreamgirlssanfrancisco.com";
        //public const string SitePhone = "(415) 504-3991";
        //public const string SitePhoneRef = "+14155043991";
        //public const string SiteEmail = "info@dreamgirlssanfrancisco.com";
        //public const string SiteContentLocation = "San Francisco";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsSanFrancisco";

        //http://www.dreamgirlshawaii.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlshawaii.com";
        //public const string SitePhone = "(808) 427-9980";
        //public const string SitePhoneRef = "+18084279980";
        //public const string SiteEmail = "info@dreamgirlshawaii.com";
        //public const string SiteContentLocation = "Hawaii";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsHawaii";

        //http://www.dreamgirlsdenver.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsdenver.com";
        //public const string SitePhone = "(720) 452-2853";
        //public const string SitePhoneRef = "+17204522853";
        //public const string SiteEmail = "info@dreamgirlsdenver.com";
        //public const string SiteContentLocation = "Denver";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsDenver";

        //http://www.dreamgirlsdc.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsdc.com";
        //public const string SitePhone = "(202) 503-1703";
        //public const string SitePhoneRef = "+12025031703";
        //public const string SiteEmail = "info@dreamgirlsdc.com";
        //public const string SiteContentLocation = "Washington DC";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsWashingtonDC";

        //http://www.dreamgirlssanjose.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlssanjose.com";
        //public const string SitePhone = "(408) 940-0056";
        //public const string SitePhoneRef = "+14089400056";
        //public const string SiteEmail = "info@dreamgirlssanjose.com";
        //public const string SiteContentLocation = "San Jose";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "Dream Girls San Jose";

        //http://www.dreamgirlsdallas.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsdallas.com";
        //public const string SitePhone = "(214) 396-8283";
        //public const string SitePhoneRef = "+12143968283";
        //public const string SiteEmail = "info@dreamgirlsdallas.com";
        //public const string SiteContentLocation = "Dallas";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsDallas";


        //http://www.dreamgirlsmiami.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsmiami.com";
        //public const string SitePhone = "(786) 332-5940";
        //public const string SitePhoneRef = "+17863325940";
        //public const string SiteEmail = "info@dreamgirlsmiami.com";
        //public const string SiteContentLocation = "Miami";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsMiami";

        //http://www.dreamgirlsmemphis.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsmemphis.com";
        //public const string SitePhone = "(901) 842-1341";
        //public const string SitePhoneRef = "+19018421341";
        //public const string SiteEmail = "info@dreamgirlsmemphis.com";
        //public const string SiteContentLocation = "Memphis";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsMemphis";

        //http://www.dreamgirlsnashville.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsnashville.com";
        //public const string SitePhone = "(615) 846-3080";
        //public const string SitePhoneRef = "+16158463080";
        //public const string SiteEmail = "info@dreamgirlsnashville.com";
        //public const string SiteContentLocation = "Nashville";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsNashville";

        //http://http://www.dreamgirlsaustin.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsaustin.com";
        //public const string SitePhone = "(512) 7176769";
        //public const string SitePhoneRef = "+15127176769";
        //public const string SiteEmail = "info@dreamgirlsaustin.com";
        //public const string SiteContentLocation = "Austin";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsAustin";

        //http://www.dreamgirlsphiladelphia.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsphiladelphia.com";
        //public const string SitePhone = "(215) 278-6210";
        //public const string SitePhoneRef = "+12152786210";
        //public const string SiteEmail = "info@dreamgirlsphiladelphia.com";
        //public const string SiteContentLocation = "Philadelphia";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsPhiladelphia";

        //http://www.dreamgirlsportland.com
        //public const string SiteNameSsl = "www.dreamgirlslasvegas.com";
        //public const string SiteName = "www.dreamgirlsportland.com";
        //public const string SitePhone = "(503) 770-6777";
        //public const string SitePhoneRef = "+15037706777";
        //public const string SiteEmail = "info@dreamgirlsportland.com";
        //public const string SiteContentLocation = "Portland";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsPortland";

        //http://www.dreamgirlsindianapolis.com
        //public const string SiteNameSsl = "www.dreamgirlsindianapolis.com";
        //public const string SiteName = "www.dreamgirlsindianapolis.com";
        //public const string SitePhone = "702-000-0000";
        //public const string SitePhoneRef = "+17020000000";
        //public const string SiteEmail = "info@dreamgirlsindianapolis.com";
        //public const string SiteContentLocation = "Indianapolis";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "DreamGirlsIndianapolis";

        //http://www.dreamgirlsindianapolis.com
        //public const string SiteNameSsl = "www.indianapolismassagegirls.com";
        //public const string SiteName = "www.indianapolismassagegirls.com";
        //public const string SitePhone = "463-213-3388";
        //public const string SitePhoneRef = "+14632133388";
        //public const string SiteEmail = "info@indianapolismassagegirls.com";
        //public const string SiteContentLocation = "Indianapolis";
        //public const string SiteCountry = "USA";
        //public const string SiteDreamGirlsLocation = "Indianapolis Massage Girls";

        //https://www.vegasmassagegirls.com/
        public const string SiteNameSsl = "www.vegasmassagegirls.com";
        public const string SiteName = "www.vegasmassagegirls.com";
        public const string SitePhone = "(702) 766-7988";
        public const string SitePhoneRef = "+17027667988";
        public const string SiteEmail = "info@vegasmassagegirls.com";
        public const string SiteContentLocation = "Las Vegas";
        public const string SiteCountry = "USA";
        public const string SiteDreamGirlsLocation = "Las Vegas Massage Girls";
    }
}
