using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Googajax
{
    public struct GResultsSize
    {
        public const int Small = 2;
        public const int Medium = 4;
        public const int Large = 8;
    }

    public class GSearchParameter
    {

        internal GSearchParameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Value
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return Value;
        }

        public string ToQueryString()
        {
            return Name + "=" + HttpUtility.UrlEncode(Value);
        }
    }

    public sealed class GVersion : GSearchParameter
    {
        public static readonly GVersion V1_0 = new GVersion("1.0");

        internal const string InternalName = "v";

        private GVersion(string value) :
            base(InternalName, value) { }
    }

    public sealed class GSafetyLevel : GSearchParameter
    {
        public static readonly GSafetyLevel Active = new GSafetyLevel("active");
        public static readonly GSafetyLevel Moderate = new GSafetyLevel("moderate");
        public static readonly GSafetyLevel Off = new GSafetyLevel("off");

        internal const string InternalName = "safe";

        private GSafetyLevel(string value) :
            base(InternalName, value) { }
    }

    public sealed class GScoring : GSearchParameter
    {
        public static readonly GScoring DescendingDate = new GScoring("d");
        public static readonly GScoring AscendingDate = new GScoring("ad");

        internal const string InternalName = "scoring";

        private GScoring(string value) :
            base(InternalName, value) { }
    }

    public sealed class GImageSize : GSearchParameter
    {
        public static readonly GImageSize Icon = new GImageSize("icon");
        public static readonly GImageSize Small = new GImageSize("small");
        public static readonly GImageSize Medium = new GImageSize("medium");
        public static readonly GImageSize Large = new GImageSize("large");
        public static readonly GImageSize XLarge = new GImageSize("xlarge");
        public static readonly GImageSize XXLarge = new GImageSize("xxlarge");
        public static readonly GImageSize Huge = new GImageSize("huge");

        internal const string InternalName = "imgsz";

        private GImageSize(string value) :
            base(InternalName, value) { }
    }

    public sealed class GImageColorization : GSearchParameter
    {
        public static readonly GImageColorization Gray = new GImageColorization("gray");
        public static readonly GImageColorization Color = new GImageColorization("color");

        internal const string InternalName = "imgc";

        private GImageColorization(string value) :
            base(InternalName, value) { }
    }

    public sealed class GImageColor : GSearchParameter
    {
        public static readonly GImageColor Black = new GImageColor("black");
        public static readonly GImageColor Blue = new GImageColor("blue");
        public static readonly GImageColor Brown = new GImageColor("brown");
        public static readonly GImageColor Gray = new GImageColor("gray");
        public static readonly GImageColor Green = new GImageColor("green");
        public static readonly GImageColor Orange = new GImageColor("orange");
        public static readonly GImageColor Pink = new GImageColor("pink");
        public static readonly GImageColor Purple = new GImageColor("purple");
        public static readonly GImageColor Red = new GImageColor("red");
        public static readonly GImageColor Teal = new GImageColor("teal");
        public static readonly GImageColor White = new GImageColor("white");
        public static readonly GImageColor Yellow = new GImageColor("yellow");

        internal const string InternalName = "imgcolor";

        private GImageColor(string value) :
            base(InternalName, value) { }
        
    }

    public sealed class GImageType : GSearchParameter
    {
        public static readonly GImageType Face = new GImageType("face");
        public static readonly GImageType Photo = new GImageType("photo");
        public static readonly GImageType ClipArt = new GImageType("clipart");
        public static readonly GImageType LineArt = new GImageType("lineart");

        internal const string InternalName = "imgtype";

        private GImageType(string value) :
            base(InternalName, value) { }
    }

    public sealed class GImageFileType : GSearchParameter
    {
        public static readonly GImageFileType Jpg = new GImageFileType("jpg");
        public static readonly GImageFileType Png = new GImageFileType("png");
        public static readonly GImageFileType Gif = new GImageFileType("gif");
        public static readonly GImageFileType Bmp = new GImageFileType("bmp");

        internal const string InternalName = "as_filetype";

        private GImageFileType(string value) :
            base(InternalName, value) { }

    }

    public struct GImageRights
    {
        internal const string PublicDomain = "cc_publicdomain";
        public const int IncludePublicDomain = 0x0001;
        public const int ExcludePublicDomain = 0x0002;

        internal const string Attribute = "cc_attribute";
        public const int IncludeAttribute = 0x0004;
        public const int ExcludeAttribute = 0x0008;

        internal const string ShareAlike = "cc_sharealike";
        public const int IncludeShareAlike  = 0x0010;
        public const int ExcludeShareAlike  = 0x0020;

        internal const string NonCommercial = "cc_noncommercial";
        public const int IncludeNonCommercial = 0x0040;
        public const int ExcludeNonCommercial = 0x0080;

        internal const string NonDerived = "cc_nonderived";
        public const int IncludeNonDerived = 0x0100;
        public const int ExcludeNonDerived = 0x0200;

        internal const string InternalName = "as_rights";
    }

    public sealed class GNewsTopic : GSearchParameter
    {
        public static readonly GNewsTopic TopHeadlines = new GNewsTopic("h");
        public static readonly GNewsTopic World = new GNewsTopic("w");
        public static readonly GNewsTopic Business = new GNewsTopic("b");
        public static readonly GNewsTopic Nation = new GNewsTopic("n");
        public static readonly GNewsTopic ScienceTechnology = new GNewsTopic("t");
        public static readonly GNewsTopic Elections = new GNewsTopic("el");
        public static readonly GNewsTopic Politics = new GNewsTopic("p");
        public static readonly GNewsTopic Entertainment = new GNewsTopic("e");
        public static readonly GNewsTopic Sports = new GNewsTopic("s");
        public static readonly GNewsTopic Health = new GNewsTopic("m");

        internal const string InternalName = "topic";

        private GNewsTopic(string value) :
            base(InternalName, value) { }
    }

    public sealed class GLocalListing : GSearchParameter
    {
        public static readonly GLocalListing Blended = new GLocalListing("blended");
        public static readonly GLocalListing KmlOnly = new GLocalListing("kmlonly");
        public static readonly GLocalListing LocalOnly = new GLocalListing("localonly");

        internal const string InternalName = "mrt";

        private GLocalListing(string value) :
            base(InternalName, value) { }
    }

    public sealed class GHostLanguage : GSearchParameter
    {
        public static readonly GHostLanguage Afrikaans = new GHostLanguage("af");
        public static readonly GHostLanguage Albanian = new GHostLanguage("sq");
        public static readonly GHostLanguage Amharic = new GHostLanguage("sm");
        public static readonly GHostLanguage Arabic = new GHostLanguage("ar");
        public static readonly GHostLanguage Azerbaijani = new GHostLanguage("az");
        public static readonly GHostLanguage Basque = new GHostLanguage("eu");
        public static readonly GHostLanguage Belarusian = new GHostLanguage("be");
        public static readonly GHostLanguage Bengali = new GHostLanguage("bn");
        public static readonly GHostLanguage Bihari = new GHostLanguage("bhv");
        public static readonly GHostLanguage Bosnian = new GHostLanguage("bs");
        public static readonly GHostLanguage Bulgarian = new GHostLanguage("bg");
        public static readonly GHostLanguage Catalan = new GHostLanguage("ca");
        public static readonly GHostLanguage ChineseSimplified = new GHostLanguage("zh-CN");
        public static readonly GHostLanguage ChineseTraditional = new GHostLanguage("zh-TW");
        public static readonly GHostLanguage Croation = new GHostLanguage("hr");
        public static readonly GHostLanguage Czech = new GHostLanguage("cs");
        public static readonly GHostLanguage Danish = new GHostLanguage("da");
        public static readonly GHostLanguage Dutch = new GHostLanguage("nl");
        public static readonly GHostLanguage English = new GHostLanguage("en");
        public static readonly GHostLanguage Esperanto = new GHostLanguage("eo");
        public static readonly GHostLanguage Estonian = new GHostLanguage("et");
        public static readonly GHostLanguage Faroese = new GHostLanguage("fo");
        public static readonly GHostLanguage Finnish = new GHostLanguage("fi");
        public static readonly GHostLanguage French = new GHostLanguage("fr");
        public static readonly GHostLanguage Frisian = new GHostLanguage("fy");
        public static readonly GHostLanguage Galician = new GHostLanguage("gl");
        public static readonly GHostLanguage Georgian = new GHostLanguage("ka");
        public static readonly GHostLanguage Greek = new GHostLanguage("el");
        public static readonly GHostLanguage Gujarati = new GHostLanguage("gu");
        public static readonly GHostLanguage Hebrew = new GHostLanguage("iw");
        public static readonly GHostLanguage Hindi = new GHostLanguage("hi");
        public static readonly GHostLanguage Hungarian = new GHostLanguage("hu");
        public static readonly GHostLanguage Icelandic = new GHostLanguage("is");
        public static readonly GHostLanguage Indonesian = new GHostLanguage("id");
        public static readonly GHostLanguage Interlingua = new GHostLanguage("ia");
        public static readonly GHostLanguage Irish = new GHostLanguage("ga");
        public static readonly GHostLanguage Italian = new GHostLanguage("it");
        public static readonly GHostLanguage Japanese = new GHostLanguage("ja");
        public static readonly GHostLanguage Javanese = new GHostLanguage("jw");
        public static readonly GHostLanguage Kannada = new GHostLanguage("kn");
        public static readonly GHostLanguage Korean = new GHostLanguage("ko");
        public static readonly GHostLanguage Latin = new GHostLanguage("la");
        public static readonly GHostLanguage Latvian = new GHostLanguage("lv");
        public static readonly GHostLanguage Lithuanian = new GHostLanguage("lt");
        public static readonly GHostLanguage Macedonian = new GHostLanguage("mk");
        public static readonly GHostLanguage Malay = new GHostLanguage("ms");
        public static readonly GHostLanguage Malayam = new GHostLanguage("ml");
        public static readonly GHostLanguage Maltese = new GHostLanguage("mt");
        public static readonly GHostLanguage Marathi = new GHostLanguage("mr");
        public static readonly GHostLanguage Nepali = new GHostLanguage("ne");
        public static readonly GHostLanguage Norwegian = new GHostLanguage("no");
        public static readonly GHostLanguage NorwegianNynorsk = new GHostLanguage("nn");
        public static readonly GHostLanguage Occitan = new GHostLanguage("oc");
        public static readonly GHostLanguage Persian = new GHostLanguage("fa");
        public static readonly GHostLanguage Polish = new GHostLanguage("pl");
        public static readonly GHostLanguage PortugueseBrazil = new GHostLanguage("pt-BR");
        public static readonly GHostLanguage PortuguesePortugal = new GHostLanguage("pt-PT");
        public static readonly GHostLanguage Punjabi = new GHostLanguage("pa");
        public static readonly GHostLanguage Romanian = new GHostLanguage("ro");
        public static readonly GHostLanguage Russian = new GHostLanguage("ru");
        public static readonly GHostLanguage ScotsGaelic = new GHostLanguage("gd");
        public static readonly GHostLanguage Serbian = new GHostLanguage("sr");
        public static readonly GHostLanguage Sinhalese = new GHostLanguage("si");
        public static readonly GHostLanguage Slovak = new GHostLanguage("sk");
        public static readonly GHostLanguage Slovenian = new GHostLanguage("sl");
        public static readonly GHostLanguage Spanish = new GHostLanguage("es");
        public static readonly GHostLanguage Sudanese = new GHostLanguage("su");
        public static readonly GHostLanguage Swahili = new GHostLanguage("sw");
        public static readonly GHostLanguage Swedish = new GHostLanguage("sv");
        public static readonly GHostLanguage Tagalog = new GHostLanguage("tl");
        public static readonly GHostLanguage Tamil = new GHostLanguage("ta");
        public static readonly GHostLanguage Telugu = new GHostLanguage("te");
        public static readonly GHostLanguage Thai = new GHostLanguage("th");
        public static readonly GHostLanguage Tigrinya = new GHostLanguage("ti");
        public static readonly GHostLanguage Turkish = new GHostLanguage("tr");
        public static readonly GHostLanguage Ukrainian = new GHostLanguage("uk");
        public static readonly GHostLanguage Urdu = new GHostLanguage("ur");
        public static readonly GHostLanguage Uzbek = new GHostLanguage("uz");
        public static readonly GHostLanguage Vietnamese = new GHostLanguage("vi");
        public static readonly GHostLanguage Welsh = new GHostLanguage("cy");
        public static readonly GHostLanguage Xhosa = new GHostLanguage("xh");
        public static readonly GHostLanguage Zulu = new GHostLanguage("zu");

        internal const string InternalName = "hl";

        private GHostLanguage(string value) :
            base(InternalName, value) { }
    }

    public sealed class GLangRestriction : GSearchParameter
    {
        public static readonly GLangRestriction Arabic = new GLangRestriction("lang_ar");
        public static readonly GLangRestriction Bulgarian = new GLangRestriction("lang_bg");
        public static readonly GLangRestriction Catalan = new GLangRestriction("lang_ca");
        public static readonly GLangRestriction ChineseSimplified = new GLangRestriction("lang_zh-CN");
        public static readonly GLangRestriction ChineseTraditional = new GLangRestriction("lang_zh-TW");
        public static readonly GLangRestriction Croation = new GLangRestriction("lang_hr");
        public static readonly GLangRestriction Czech = new GLangRestriction("lang_cs");
        public static readonly GLangRestriction Danish = new GLangRestriction("lang_da");
        public static readonly GLangRestriction Dutch = new GLangRestriction("lang_nl");
        public static readonly GLangRestriction English = new GLangRestriction("lang_en");
        public static readonly GLangRestriction Estonian = new GLangRestriction("lang_et");
        public static readonly GLangRestriction Finnish = new GLangRestriction("lang_fi");
        public static readonly GLangRestriction French = new GLangRestriction("lang_fr");
        public static readonly GLangRestriction German = new GLangRestriction("lang_de");
        public static readonly GLangRestriction Greek = new GLangRestriction("lang_el");
        public static readonly GLangRestriction Hebrew = new GLangRestriction("lang_iw");
        public static readonly GLangRestriction Hungarian = new GLangRestriction("lang_hu");
        public static readonly GLangRestriction Icelandic = new GLangRestriction("lang_is");
        public static readonly GLangRestriction Indonesian = new GLangRestriction("lang_id");
        public static readonly GLangRestriction Italian = new GLangRestriction("lang_it");
        public static readonly GLangRestriction Japanese = new GLangRestriction("lang_ja");
        public static readonly GLangRestriction Korean = new GLangRestriction("lang_ko");
        public static readonly GLangRestriction Latvian = new GLangRestriction("lang_lv");
        public static readonly GLangRestriction Lithuanian = new GLangRestriction("lang_lt");
        public static readonly GLangRestriction Norwegian = new GLangRestriction("lang_no");
        public static readonly GLangRestriction Polish = new GLangRestriction("lang_pl");
        public static readonly GLangRestriction Portuguese = new GLangRestriction("lang_pt");
        public static readonly GLangRestriction Romanian = new GLangRestriction("lang_ro");
        public static readonly GLangRestriction Russian = new GLangRestriction("lang_ru");
        public static readonly GLangRestriction Serbian = new GLangRestriction("lang_sr");
        public static readonly GLangRestriction Slovak = new GLangRestriction("lang_sk");
        public static readonly GLangRestriction Slovenian = new GLangRestriction("lang_sl");
        public static readonly GLangRestriction Spanish = new GLangRestriction("lang_es");
        public static readonly GLangRestriction Swedish = new GLangRestriction("lang_sv");
        public static readonly GLangRestriction Turkish = new GLangRestriction("lang_tr");

        internal const string InternalName = "lr";

        private GLangRestriction(string value) :
            base(InternalName, value) { }
    }

    public sealed class GCountryCode : GSearchParameter
    {
        public static readonly GCountryCode Afghanistan = new GCountryCode("af");
        public static readonly GCountryCode Albania = new GCountryCode("al");
        public static readonly GCountryCode Algeria = new GCountryCode("dz");
        public static readonly GCountryCode AmericanSamoa = new GCountryCode("as");
        public static readonly GCountryCode Andorra = new GCountryCode("ad");
        public static readonly GCountryCode Angola = new GCountryCode("ao");
        public static readonly GCountryCode Anguilla = new GCountryCode("ai");
        public static readonly GCountryCode Antarctica = new GCountryCode("aq");
        public static readonly GCountryCode AntiguaAndBarbuda = new GCountryCode("ag");
        public static readonly GCountryCode Argentina = new GCountryCode("ar");
        public static readonly GCountryCode Armenia = new GCountryCode("am");
        public static readonly GCountryCode Aruba = new GCountryCode("aw");
        public static readonly GCountryCode Australia = new GCountryCode("au");
        public static readonly GCountryCode Austria = new GCountryCode("at");
        public static readonly GCountryCode Azerbaijan = new GCountryCode("az");
        public static readonly GCountryCode Bahamas = new GCountryCode("bs");
        public static readonly GCountryCode Bahrain = new GCountryCode("bh");
        public static readonly GCountryCode Bangladesh = new GCountryCode("bd");
        public static readonly GCountryCode Barbados = new GCountryCode("bb");
        public static readonly GCountryCode Belarus = new GCountryCode("by");
        public static readonly GCountryCode Belgium = new GCountryCode("be");
        public static readonly GCountryCode Belize = new GCountryCode("bz");
        public static readonly GCountryCode Benin = new GCountryCode("bj");
        public static readonly GCountryCode Bermuda = new GCountryCode("bm");
        public static readonly GCountryCode Bhutan = new GCountryCode("bt");
        public static readonly GCountryCode Bolivia = new GCountryCode("bo");
        public static readonly GCountryCode BosniaAndHerzegovina = new GCountryCode("ba");
        public static readonly GCountryCode Botswana = new GCountryCode("bw");
        public static readonly GCountryCode Bouvet = new GCountryCode("bv");
        public static readonly GCountryCode Brazil = new GCountryCode("br");
        public static readonly GCountryCode BritishIndianOcean = new GCountryCode("io");
        public static readonly GCountryCode BruneiDarussalam = new GCountryCode("bn");
        public static readonly GCountryCode Bulgaria = new GCountryCode("bg");
        public static readonly GCountryCode BurkinaFaso = new GCountryCode("bf");
        public static readonly GCountryCode Burundi = new GCountryCode("bi");
        public static readonly GCountryCode Cambodia = new GCountryCode("kh");
        public static readonly GCountryCode Cameroon = new GCountryCode("cm");
        public static readonly GCountryCode Canada = new GCountryCode("ca");
        public static readonly GCountryCode CapeVerde = new GCountryCode("cv");
        public static readonly GCountryCode CaymanIslands = new GCountryCode("ky");
        public static readonly GCountryCode CentralAfrica = new GCountryCode("cf");
        public static readonly GCountryCode Chad = new GCountryCode("td");
        public static readonly GCountryCode Chile = new GCountryCode("cl");
        public static readonly GCountryCode China = new GCountryCode("cn");
        public static readonly GCountryCode ChristmasIsland = new GCountryCode("cx");
        public static readonly GCountryCode CocosKeeling = new GCountryCode("cc");
        public static readonly GCountryCode Colombia = new GCountryCode("co");
        public static readonly GCountryCode Comoros = new GCountryCode("km");
        public static readonly GCountryCode Congo = new GCountryCode("cg");
        public static readonly GCountryCode CongoRepublic = new GCountryCode("cd");
        public static readonly GCountryCode CookIslands = new GCountryCode("ck");
        public static readonly GCountryCode CostaRica = new GCountryCode("cr");
        public static readonly GCountryCode CoteDivoire = new GCountryCode("ci");
        public static readonly GCountryCode Croatia = new GCountryCode("hr");
        public static readonly GCountryCode Cuba = new GCountryCode("cu");
        public static readonly GCountryCode Cyprus = new GCountryCode("cy");
        public static readonly GCountryCode CzechRepublic = new GCountryCode("cz");
        public static readonly GCountryCode Denmark = new GCountryCode("dk");
        public static readonly GCountryCode Djibouti = new GCountryCode("dj");
        public static readonly GCountryCode Dominica = new GCountryCode("dm");
        public static readonly GCountryCode DominicanRepublic = new GCountryCode("do");
        public static readonly GCountryCode Ecuador = new GCountryCode("ec");
        public static readonly GCountryCode Egypt = new GCountryCode("eg");
        public static readonly GCountryCode ElSalvador = new GCountryCode("sv");
        public static readonly GCountryCode EquatorialGuinea = new GCountryCode("gq");
        public static readonly GCountryCode Eritrea = new GCountryCode("er");
        public static readonly GCountryCode Estonia = new GCountryCode("ee");
        public static readonly GCountryCode Ethiopia = new GCountryCode("et");
        public static readonly GCountryCode FalklAndMalvinas = new GCountryCode("fk");
        public static readonly GCountryCode FaroeIslands = new GCountryCode("fo");
        public static readonly GCountryCode Fiji = new GCountryCode("fj");
        public static readonly GCountryCode Finland = new GCountryCode("fi");
        public static readonly GCountryCode France = new GCountryCode("fr");
        public static readonly GCountryCode FrenchGuiana = new GCountryCode("gf");
        public static readonly GCountryCode FrenchPolynesia = new GCountryCode("pf");
        public static readonly GCountryCode FrenchSouthern = new GCountryCode("tf");
        public static readonly GCountryCode Gabon = new GCountryCode("ga");
        public static readonly GCountryCode Gambia = new GCountryCode("gm");
        public static readonly GCountryCode Georgia = new GCountryCode("ge");
        public static readonly GCountryCode Germany = new GCountryCode("de");
        public static readonly GCountryCode Ghana = new GCountryCode("gh");
        public static readonly GCountryCode Gibraltar = new GCountryCode("gi");
        public static readonly GCountryCode Greece = new GCountryCode("gr");
        public static readonly GCountryCode Greenland = new GCountryCode("gl");
        public static readonly GCountryCode Grenada = new GCountryCode("gd");
        public static readonly GCountryCode Guadeloupe = new GCountryCode("gp");
        public static readonly GCountryCode Guam = new GCountryCode("gu");
        public static readonly GCountryCode Guatemala = new GCountryCode("gt");
        public static readonly GCountryCode Guinea = new GCountryCode("gn");
        public static readonly GCountryCode GuineaBissau = new GCountryCode("gw");
        public static readonly GCountryCode Guyana = new GCountryCode("gy");
        public static readonly GCountryCode Haiti = new GCountryCode("ht");
        public static readonly GCountryCode HeardAndMcdonald = new GCountryCode("hm");
        public static readonly GCountryCode HolySee = new GCountryCode("va");
        public static readonly GCountryCode Honduras = new GCountryCode("hn");
        public static readonly GCountryCode HongKong = new GCountryCode("hk");
        public static readonly GCountryCode Hungary = new GCountryCode("hu");
        public static readonly GCountryCode Iceland = new GCountryCode("is");
        public static readonly GCountryCode India = new GCountryCode("in");
        public static readonly GCountryCode Indonesia = new GCountryCode("id");
        public static readonly GCountryCode IranIslamicRepublic = new GCountryCode("ir");
        public static readonly GCountryCode Iraq = new GCountryCode("iq");
        public static readonly GCountryCode Ireland = new GCountryCode("ie");
        public static readonly GCountryCode Israel = new GCountryCode("il");
        public static readonly GCountryCode Italy = new GCountryCode("it");
        public static readonly GCountryCode Jamaica = new GCountryCode("jm");
        public static readonly GCountryCode Japan = new GCountryCode("jp");
        public static readonly GCountryCode Jordan = new GCountryCode("jo");
        public static readonly GCountryCode Kazakhstan = new GCountryCode("kz");
        public static readonly GCountryCode Kenya = new GCountryCode("ke");
        public static readonly GCountryCode Kiribati = new GCountryCode("ki");
        public static readonly GCountryCode KoreaPeoplesRepublic = new GCountryCode("kp");
        public static readonly GCountryCode KoreaRepublic = new GCountryCode("kr");
        public static readonly GCountryCode Kuwait = new GCountryCode("kw");
        public static readonly GCountryCode Kyrgyzstan = new GCountryCode("kg");
        public static readonly GCountryCode Lao = new GCountryCode("la");
        public static readonly GCountryCode Latvia = new GCountryCode("lv");
        public static readonly GCountryCode Lebanon = new GCountryCode("lb");
        public static readonly GCountryCode Lesotho = new GCountryCode("ls");
        public static readonly GCountryCode Liberia = new GCountryCode("lr");
        public static readonly GCountryCode LibyanArabJamahiriya = new GCountryCode("ly");
        public static readonly GCountryCode Liechtenstein = new GCountryCode("li");
        public static readonly GCountryCode Lithuania = new GCountryCode("lt");
        public static readonly GCountryCode Luxembourg = new GCountryCode("lu");
        public static readonly GCountryCode Macao = new GCountryCode("mo");
        public static readonly GCountryCode Macedonia = new GCountryCode("mk");
        public static readonly GCountryCode Madagascar = new GCountryCode("mg");
        public static readonly GCountryCode Malawi = new GCountryCode("mw");
        public static readonly GCountryCode Malaysia = new GCountryCode("my");
        public static readonly GCountryCode Maldives = new GCountryCode("mv");
        public static readonly GCountryCode Mali = new GCountryCode("ml");
        public static readonly GCountryCode Malta = new GCountryCode("mt");
        public static readonly GCountryCode MarshallIslands = new GCountryCode("mh");
        public static readonly GCountryCode Martinique = new GCountryCode("mq");
        public static readonly GCountryCode Mauritania = new GCountryCode("mr");
        public static readonly GCountryCode Mauritius = new GCountryCode("mu");
        public static readonly GCountryCode Mayotte = new GCountryCode("yt");
        public static readonly GCountryCode Mexico = new GCountryCode("mx");
        public static readonly GCountryCode Micronesia = new GCountryCode("fm");
        public static readonly GCountryCode Moldova = new GCountryCode("md");
        public static readonly GCountryCode Monaco = new GCountryCode("mc");
        public static readonly GCountryCode Mongolia = new GCountryCode("mn");
        public static readonly GCountryCode Montserrat = new GCountryCode("ms");
        public static readonly GCountryCode Morocco = new GCountryCode("ma");
        public static readonly GCountryCode Mozambique = new GCountryCode("mz");
        public static readonly GCountryCode Myanmar = new GCountryCode("mm");
        public static readonly GCountryCode Namibia = new GCountryCode("na");
        public static readonly GCountryCode Nauru = new GCountryCode("nr");
        public static readonly GCountryCode Nepal = new GCountryCode("np");
        public static readonly GCountryCode Netherlands = new GCountryCode("nl");
        public static readonly GCountryCode NetherlandsAntilles = new GCountryCode("an");
        public static readonly GCountryCode NewCaledonia = new GCountryCode("nc");
        public static readonly GCountryCode NewZealand = new GCountryCode("nz");
        public static readonly GCountryCode Nicaragua = new GCountryCode("ni");
        public static readonly GCountryCode Niger = new GCountryCode("ne");
        public static readonly GCountryCode Nigeria = new GCountryCode("ng");
        public static readonly GCountryCode Niue = new GCountryCode("nu");
        public static readonly GCountryCode NorfolkIsland = new GCountryCode("nf");
        public static readonly GCountryCode NorthernMariana = new GCountryCode("mp");
        public static readonly GCountryCode Norway = new GCountryCode("no");
        public static readonly GCountryCode Oman = new GCountryCode("om");
        public static readonly GCountryCode Pakistan = new GCountryCode("pk");
        public static readonly GCountryCode Palau = new GCountryCode("pw");
        public static readonly GCountryCode PalestinianTerritory = new GCountryCode("ps");
        public static readonly GCountryCode Panama = new GCountryCode("pa");
        public static readonly GCountryCode PapuaNewGuinea = new GCountryCode("pg");
        public static readonly GCountryCode Paraguay = new GCountryCode("py");
        public static readonly GCountryCode Peru = new GCountryCode("pe");
        public static readonly GCountryCode Philippines = new GCountryCode("ph");
        public static readonly GCountryCode Pitcairn = new GCountryCode("pn");
        public static readonly GCountryCode Poland = new GCountryCode("pl");
        public static readonly GCountryCode Portugal = new GCountryCode("pt");
        public static readonly GCountryCode PuertoRico = new GCountryCode("pr");
        public static readonly GCountryCode Qatar = new GCountryCode("qa");
        public static readonly GCountryCode Reunion = new GCountryCode("re");
        public static readonly GCountryCode Romania = new GCountryCode("ro");
        public static readonly GCountryCode RussianFederation = new GCountryCode("ru");
        public static readonly GCountryCode Rwanda = new GCountryCode("rw");
        public static readonly GCountryCode SaintHelena = new GCountryCode("sh");
        public static readonly GCountryCode SaintKittsAndNevis = new GCountryCode("kn");
        public static readonly GCountryCode SaintLucia = new GCountryCode("lc");
        public static readonly GCountryCode SaintPierreAndMiquelon = new GCountryCode("pm");
        public static readonly GCountryCode SaintVincentAndGrenadines = new GCountryCode("vc");
        public static readonly GCountryCode Samoa = new GCountryCode("ws");
        public static readonly GCountryCode SanMarino = new GCountryCode("sm");
        public static readonly GCountryCode SaoTomeAndPrincipe = new GCountryCode("st");
        public static readonly GCountryCode SaudiArabia = new GCountryCode("sa");
        public static readonly GCountryCode Senegal = new GCountryCode("sn");
        public static readonly GCountryCode SerbiaAndMontenegro = new GCountryCode("cs");
        public static readonly GCountryCode Seychelles = new GCountryCode("sc");
        public static readonly GCountryCode SierraLeone = new GCountryCode("sl");
        public static readonly GCountryCode Singapore = new GCountryCode("sg");
        public static readonly GCountryCode Slovakia = new GCountryCode("sk");
        public static readonly GCountryCode Slovenia = new GCountryCode("si");
        public static readonly GCountryCode SolomonIslands = new GCountryCode("sb");
        public static readonly GCountryCode Somalia = new GCountryCode("so");
        public static readonly GCountryCode SouthAfrica = new GCountryCode("za");
        public static readonly GCountryCode SouthGeorgiaAndSouthSandwich = new GCountryCode("gs");
        public static readonly GCountryCode Spain = new GCountryCode("es");
        public static readonly GCountryCode SriLanka = new GCountryCode("lk");
        public static readonly GCountryCode Sudan = new GCountryCode("sd");
        public static readonly GCountryCode Suriname = new GCountryCode("sr");
        public static readonly GCountryCode SvalbardJanMayen = new GCountryCode("sj");
        public static readonly GCountryCode Swaziland = new GCountryCode("sz");
        public static readonly GCountryCode Sweden = new GCountryCode("se");
        public static readonly GCountryCode Switzerland = new GCountryCode("ch");
        public static readonly GCountryCode Syria = new GCountryCode("sy");
        public static readonly GCountryCode Taiwan = new GCountryCode("tw");
        public static readonly GCountryCode Tajikistan = new GCountryCode("tj");
        public static readonly GCountryCode Tanzania = new GCountryCode("tz");
        public static readonly GCountryCode Thailand = new GCountryCode("th");
        public static readonly GCountryCode TimorLeste = new GCountryCode("tl");
        public static readonly GCountryCode Togo = new GCountryCode("tg");
        public static readonly GCountryCode Tokelau = new GCountryCode("tk");
        public static readonly GCountryCode Tonga = new GCountryCode("to");
        public static readonly GCountryCode TrinidadAndTobago = new GCountryCode("tt");
        public static readonly GCountryCode Tunisia = new GCountryCode("tn");
        public static readonly GCountryCode Turkey = new GCountryCode("tr");
        public static readonly GCountryCode Turkmenistan = new GCountryCode("tm");
        public static readonly GCountryCode TurksAndCaicos = new GCountryCode("tc");
        public static readonly GCountryCode Tuvalu = new GCountryCode("tv");
        public static readonly GCountryCode Uganda = new GCountryCode("ug");
        public static readonly GCountryCode Ukraine = new GCountryCode("ua");
        public static readonly GCountryCode UnitedArabEmirates = new GCountryCode("ae");
        public static readonly GCountryCode UnitedKingdom = new GCountryCode("uk");
        public static readonly GCountryCode UnitedStates = new GCountryCode("us");
        public static readonly GCountryCode UnitedStatesMinor = new GCountryCode("um");
        public static readonly GCountryCode Uruguay = new GCountryCode("uy");
        public static readonly GCountryCode Uzbekistan = new GCountryCode("uz");
        public static readonly GCountryCode Vanuatu = new GCountryCode("vu");
        public static readonly GCountryCode Venezuela = new GCountryCode("ve");
        public static readonly GCountryCode VietNam = new GCountryCode("vn");
        public static readonly GCountryCode VirginIslandsBritish = new GCountryCode("vg");
        public static readonly GCountryCode VirginIslandsUS = new GCountryCode("vi");
        public static readonly GCountryCode WallisAndFutuna = new GCountryCode("wf");
        public static readonly GCountryCode WesternSahara = new GCountryCode("eh");
        public static readonly GCountryCode Yemen = new GCountryCode("ye");
        public static readonly GCountryCode Zambia = new GCountryCode("zm");
        public static readonly GCountryCode Zimbabwe = new GCountryCode("zw");

        internal const string InternalName = "gl";

        private GCountryCode(string value) :
            base(InternalName, value) { }
    }

    public sealed class GCountryRestriction : GSearchParameter
    {
        public static readonly GCountryRestriction Afghanistan = new GCountryRestriction("countryAF");
        public static readonly GCountryRestriction Albania = new GCountryRestriction("countryAL");
        public static readonly GCountryRestriction Algeria = new GCountryRestriction("countryDZ");
        public static readonly GCountryRestriction AmericanSamoa = new GCountryRestriction("countryAS");
        public static readonly GCountryRestriction Andorra = new GCountryRestriction("countryAD");
        public static readonly GCountryRestriction Angola = new GCountryRestriction("countryAO");
        public static readonly GCountryRestriction Anguilla = new GCountryRestriction("countryAI");
        public static readonly GCountryRestriction Antarctica = new GCountryRestriction("countryAQ");
        public static readonly GCountryRestriction AntiguaAndBarbuda = new GCountryRestriction("countryAG");
        public static readonly GCountryRestriction Argentina = new GCountryRestriction("countryAR");
        public static readonly GCountryRestriction Armenia = new GCountryRestriction("countryAM");
        public static readonly GCountryRestriction Aruba = new GCountryRestriction("countryAW");
        public static readonly GCountryRestriction Australia = new GCountryRestriction("countryAU");
        public static readonly GCountryRestriction Austria = new GCountryRestriction("countryAT");
        public static readonly GCountryRestriction Azerbaijan = new GCountryRestriction("countryAZ");
        public static readonly GCountryRestriction Bahamas = new GCountryRestriction("countryBS");
        public static readonly GCountryRestriction Bahrain = new GCountryRestriction("countryBH");
        public static readonly GCountryRestriction Bangladesh = new GCountryRestriction("countryBD");
        public static readonly GCountryRestriction Barbados = new GCountryRestriction("countryBB");
        public static readonly GCountryRestriction Belarus = new GCountryRestriction("countryBY");
        public static readonly GCountryRestriction Belgium = new GCountryRestriction("countryBE");
        public static readonly GCountryRestriction Belize = new GCountryRestriction("countryBZ");
        public static readonly GCountryRestriction Benin = new GCountryRestriction("countryBJ");
        public static readonly GCountryRestriction Bermuda = new GCountryRestriction("countryBM");
        public static readonly GCountryRestriction Bhutan = new GCountryRestriction("countryBT");
        public static readonly GCountryRestriction Bolivia = new GCountryRestriction("countryBO");
        public static readonly GCountryRestriction BosniaAndHerzegovina = new GCountryRestriction("countryBA");
        public static readonly GCountryRestriction Botswana = new GCountryRestriction("countryBW");
        public static readonly GCountryRestriction BouvetIsland = new GCountryRestriction("countryBV");
        public static readonly GCountryRestriction Brazil = new GCountryRestriction("countryBR");
        public static readonly GCountryRestriction BritishIndianOcean = new GCountryRestriction("countryIO");
        public static readonly GCountryRestriction BruneiDarussalam = new GCountryRestriction("countryBN");
        public static readonly GCountryRestriction Bulgaria = new GCountryRestriction("countryBG");
        public static readonly GCountryRestriction BurkinaFaso = new GCountryRestriction("countryBF");
        public static readonly GCountryRestriction Burundi = new GCountryRestriction("countryBI");
        public static readonly GCountryRestriction Cambodia = new GCountryRestriction("countryKH");
        public static readonly GCountryRestriction Cameroon = new GCountryRestriction("countryCM");
        public static readonly GCountryRestriction Canada = new GCountryRestriction("countryCA");
        public static readonly GCountryRestriction CapeVerde = new GCountryRestriction("countryCV");
        public static readonly GCountryRestriction CaymanIslands = new GCountryRestriction("countryKY");
        public static readonly GCountryRestriction CentralAfrica = new GCountryRestriction("countryCF");
        public static readonly GCountryRestriction Chad = new GCountryRestriction("countryTD");
        public static readonly GCountryRestriction Chile = new GCountryRestriction("countryCL");
        public static readonly GCountryRestriction China = new GCountryRestriction("countryCN");
        public static readonly GCountryRestriction ChristmasIsland = new GCountryRestriction("countryCX");
        public static readonly GCountryRestriction CocosKeeling = new GCountryRestriction("countryCC");
        public static readonly GCountryRestriction Colombia = new GCountryRestriction("countryCO");
        public static readonly GCountryRestriction Comoros = new GCountryRestriction("countryKM");
        public static readonly GCountryRestriction Congo = new GCountryRestriction("countryCG");
        public static readonly GCountryRestriction CongoRepublic = new GCountryRestriction("countryCD");
        public static readonly GCountryRestriction CookIslands = new GCountryRestriction("countryCK");
        public static readonly GCountryRestriction CostaRica = new GCountryRestriction("countryCR");
        public static readonly GCountryRestriction CoteDivoire = new GCountryRestriction("countryCI");
        public static readonly GCountryRestriction CroatiaHrvatska = new GCountryRestriction("countryHR");
        public static readonly GCountryRestriction Cuba = new GCountryRestriction("countryCU");
        public static readonly GCountryRestriction Cyprus = new GCountryRestriction("countryCY");
        public static readonly GCountryRestriction CzechRepublic = new GCountryRestriction("countryCZ");
        public static readonly GCountryRestriction Denmark = new GCountryRestriction("countryDK");
        public static readonly GCountryRestriction Djibouti = new GCountryRestriction("countryDJ");
        public static readonly GCountryRestriction Dominica = new GCountryRestriction("countryDM");
        public static readonly GCountryRestriction DominicanRepublic = new GCountryRestriction("countryDO");
        public static readonly GCountryRestriction EastTimor = new GCountryRestriction("countryTP");
        public static readonly GCountryRestriction Ecuador = new GCountryRestriction("countryEC");
        public static readonly GCountryRestriction Egypt = new GCountryRestriction("countryEG");
        public static readonly GCountryRestriction ElSalvador = new GCountryRestriction("countrySV");
        public static readonly GCountryRestriction EquatorialGuinea = new GCountryRestriction("countryGQ");
        public static readonly GCountryRestriction Eritrea = new GCountryRestriction("countryER");
        public static readonly GCountryRestriction Estonia = new GCountryRestriction("countryEE");
        public static readonly GCountryRestriction Ethiopia = new GCountryRestriction("countryET");
        public static readonly GCountryRestriction EuropeanUnion = new GCountryRestriction("countryEU");
        public static readonly GCountryRestriction FalklAndMalvinas = new GCountryRestriction("countryFK");
        public static readonly GCountryRestriction FaroeIslands = new GCountryRestriction("countryFO");
        public static readonly GCountryRestriction Fiji = new GCountryRestriction("countryFJ");
        public static readonly GCountryRestriction Finland = new GCountryRestriction("countryFI");
        public static readonly GCountryRestriction France = new GCountryRestriction("countryFR");
        public static readonly GCountryRestriction FranceMetropolitan = new GCountryRestriction("countryFX");
        public static readonly GCountryRestriction FrenchGuiana = new GCountryRestriction("countryGF");
        public static readonly GCountryRestriction FrenchPolynesia = new GCountryRestriction("countryPF");
        public static readonly GCountryRestriction FrenchSouthern = new GCountryRestriction("countryTF");
        public static readonly GCountryRestriction Gabon = new GCountryRestriction("countryGA");
        public static readonly GCountryRestriction Gambia = new GCountryRestriction("countryGM");
        public static readonly GCountryRestriction Georgia = new GCountryRestriction("countryGE");
        public static readonly GCountryRestriction Germany = new GCountryRestriction("countryDE");
        public static readonly GCountryRestriction Ghana = new GCountryRestriction("countryGH");
        public static readonly GCountryRestriction Gibraltar = new GCountryRestriction("countryGI");
        public static readonly GCountryRestriction Greece = new GCountryRestriction("countryGR");
        public static readonly GCountryRestriction Greenland = new GCountryRestriction("countryGL");
        public static readonly GCountryRestriction Grenada = new GCountryRestriction("countryGD");
        public static readonly GCountryRestriction Guadeloupe = new GCountryRestriction("countryGP");
        public static readonly GCountryRestriction Guam = new GCountryRestriction("countryGU");
        public static readonly GCountryRestriction Guatemala = new GCountryRestriction("countryGT");
        public static readonly GCountryRestriction Guinea = new GCountryRestriction("countryGN");
        public static readonly GCountryRestriction GuineaBissau = new GCountryRestriction("countryGW");
        public static readonly GCountryRestriction Guyana = new GCountryRestriction("countryGY");
        public static readonly GCountryRestriction Haiti = new GCountryRestriction("countryHT");
        public static readonly GCountryRestriction HeardAndMcdonald = new GCountryRestriction("countryHM");
        public static readonly GCountryRestriction HolySee = new GCountryRestriction("countryVA");
        public static readonly GCountryRestriction Honduras = new GCountryRestriction("countryHN");
        public static readonly GCountryRestriction HongKong = new GCountryRestriction("countryHK");
        public static readonly GCountryRestriction Hungary = new GCountryRestriction("countryHU");
        public static readonly GCountryRestriction Iceland = new GCountryRestriction("countryIS");
        public static readonly GCountryRestriction India = new GCountryRestriction("countryIN");
        public static readonly GCountryRestriction Indonesia = new GCountryRestriction("countryID");
        public static readonly GCountryRestriction IranIslamicRepublic = new GCountryRestriction("countryIR");
        public static readonly GCountryRestriction Iraq = new GCountryRestriction("countryIQ");
        public static readonly GCountryRestriction Ireland = new GCountryRestriction("countryIE");
        public static readonly GCountryRestriction Israel = new GCountryRestriction("countryIL");
        public static readonly GCountryRestriction Italy = new GCountryRestriction("countryIT");
        public static readonly GCountryRestriction Jamaica = new GCountryRestriction("countryJM");
        public static readonly GCountryRestriction Japan = new GCountryRestriction("countryJP");
        public static readonly GCountryRestriction Jordan = new GCountryRestriction("countryJO");
        public static readonly GCountryRestriction Kazakhstan = new GCountryRestriction("countryKZ");
        public static readonly GCountryRestriction Kenya = new GCountryRestriction("countryKE");
        public static readonly GCountryRestriction Kiribati = new GCountryRestriction("countryKI");
        public static readonly GCountryRestriction KoreaPeoplesRepublic = new GCountryRestriction("countryKP");
        public static readonly GCountryRestriction KoreaRepublic = new GCountryRestriction("countryKR");
        public static readonly GCountryRestriction Kuwait = new GCountryRestriction("countryKW");
        public static readonly GCountryRestriction Kyrgyzstan = new GCountryRestriction("countryKG");
        public static readonly GCountryRestriction Lao = new GCountryRestriction("countryLA");
        public static readonly GCountryRestriction Latvia = new GCountryRestriction("countryLV");
        public static readonly GCountryRestriction Lebanon = new GCountryRestriction("countryLB");
        public static readonly GCountryRestriction Lesotho = new GCountryRestriction("countryLS");
        public static readonly GCountryRestriction Liberia = new GCountryRestriction("countryLR");
        public static readonly GCountryRestriction LibyanArabJamahiriya = new GCountryRestriction("countryLY");
        public static readonly GCountryRestriction Liechtenstein = new GCountryRestriction("countryLI");
        public static readonly GCountryRestriction Lithuania = new GCountryRestriction("countryLT");
        public static readonly GCountryRestriction Luxembourg = new GCountryRestriction("countryLU");
        public static readonly GCountryRestriction Macao = new GCountryRestriction("countryMO");
        public static readonly GCountryRestriction Macedonia = new GCountryRestriction("countryMK");
        public static readonly GCountryRestriction Madagascar = new GCountryRestriction("countryMG");
        public static readonly GCountryRestriction Malawi = new GCountryRestriction("countryMW");
        public static readonly GCountryRestriction Malaysia = new GCountryRestriction("countryMY");
        public static readonly GCountryRestriction Maldives = new GCountryRestriction("countryMV");
        public static readonly GCountryRestriction Mali = new GCountryRestriction("countryML");
        public static readonly GCountryRestriction Malta = new GCountryRestriction("countryMT");
        public static readonly GCountryRestriction MarshallIslands = new GCountryRestriction("countryMH");
        public static readonly GCountryRestriction Martinique = new GCountryRestriction("countryMQ");
        public static readonly GCountryRestriction Mauritania = new GCountryRestriction("countryMR");
        public static readonly GCountryRestriction Mauritius = new GCountryRestriction("countryMU");
        public static readonly GCountryRestriction Mayotte = new GCountryRestriction("countryYT");
        public static readonly GCountryRestriction Mexico = new GCountryRestriction("countryMX");
        public static readonly GCountryRestriction Micronesia = new GCountryRestriction("countryFM");
        public static readonly GCountryRestriction Moldova = new GCountryRestriction("countryMD");
        public static readonly GCountryRestriction Monaco = new GCountryRestriction("countryMC");
        public static readonly GCountryRestriction Mongolia = new GCountryRestriction("countryMN");
        public static readonly GCountryRestriction Montserrat = new GCountryRestriction("countryMS");
        public static readonly GCountryRestriction Morocco = new GCountryRestriction("countryMA");
        public static readonly GCountryRestriction Mozambique = new GCountryRestriction("countryMZ");
        public static readonly GCountryRestriction Myanmar = new GCountryRestriction("countryMM");
        public static readonly GCountryRestriction Namibia = new GCountryRestriction("countryNA");
        public static readonly GCountryRestriction Nauru = new GCountryRestriction("countryNR");
        public static readonly GCountryRestriction Nepal = new GCountryRestriction("countryNP");
        public static readonly GCountryRestriction Netherlands = new GCountryRestriction("countryNL");
        public static readonly GCountryRestriction NetherlandsAntilles = new GCountryRestriction("countryAN");
        public static readonly GCountryRestriction NewCaledonia = new GCountryRestriction("countryNC");
        public static readonly GCountryRestriction NewZealand = new GCountryRestriction("countryNZ");
        public static readonly GCountryRestriction Nicaragua = new GCountryRestriction("countryNI");
        public static readonly GCountryRestriction Niger = new GCountryRestriction("countryNE");
        public static readonly GCountryRestriction Nigeria = new GCountryRestriction("countryNG");
        public static readonly GCountryRestriction Niue = new GCountryRestriction("countryNU");
        public static readonly GCountryRestriction NorfolkIsland = new GCountryRestriction("countryNF");
        public static readonly GCountryRestriction NorthernMariana = new GCountryRestriction("countryMP");
        public static readonly GCountryRestriction Norway = new GCountryRestriction("countryNO");
        public static readonly GCountryRestriction Oman = new GCountryRestriction("countryOM");
        public static readonly GCountryRestriction Pakistan = new GCountryRestriction("countryPK");
        public static readonly GCountryRestriction Palau = new GCountryRestriction("countryPW");
        public static readonly GCountryRestriction PalestinianTerritory = new GCountryRestriction("countryPS");
        public static readonly GCountryRestriction Panama = new GCountryRestriction("countryPA");
        public static readonly GCountryRestriction PapuaNewGuinea = new GCountryRestriction("countryPG");
        public static readonly GCountryRestriction Paraguay = new GCountryRestriction("countryPY");
        public static readonly GCountryRestriction Peru = new GCountryRestriction("countryPE");
        public static readonly GCountryRestriction Philippines = new GCountryRestriction("countryPH");
        public static readonly GCountryRestriction Pitcairn = new GCountryRestriction("countryPN");
        public static readonly GCountryRestriction Poland = new GCountryRestriction("countryPL");
        public static readonly GCountryRestriction Portugal = new GCountryRestriction("countryPT");
        public static readonly GCountryRestriction PuertoRico = new GCountryRestriction("countryPR");
        public static readonly GCountryRestriction Qatar = new GCountryRestriction("countryQA");
        public static readonly GCountryRestriction Reunion = new GCountryRestriction("countryRE");
        public static readonly GCountryRestriction Romania = new GCountryRestriction("countryRO");
        public static readonly GCountryRestriction RussianFederation = new GCountryRestriction("countryRU");
        public static readonly GCountryRestriction Rwanda = new GCountryRestriction("countryRW");
        public static readonly GCountryRestriction SaintHelena = new GCountryRestriction("countrySH");
        public static readonly GCountryRestriction SaintKittsAndNevis = new GCountryRestriction("countryKN");
        public static readonly GCountryRestriction SaintLucia = new GCountryRestriction("countryLC");
        public static readonly GCountryRestriction SaintPierreAndMiquelon = new GCountryRestriction("countryPM");
        public static readonly GCountryRestriction SaintVincentAndGrenadines = new GCountryRestriction("countryVC");
        public static readonly GCountryRestriction Samoa = new GCountryRestriction("countryWS");
        public static readonly GCountryRestriction SanMarino = new GCountryRestriction("countrySM");
        public static readonly GCountryRestriction SaoTomeAndPrincipe = new GCountryRestriction("countryST");
        public static readonly GCountryRestriction SaudiArabia = new GCountryRestriction("countrySA");
        public static readonly GCountryRestriction Senegal = new GCountryRestriction("countrySN");
        public static readonly GCountryRestriction SerbiaAndMontenegro = new GCountryRestriction("countryCS");
        public static readonly GCountryRestriction Seychelles = new GCountryRestriction("countrySC");
        public static readonly GCountryRestriction SierraLeone = new GCountryRestriction("countrySL");
        public static readonly GCountryRestriction Singapore = new GCountryRestriction("countrySG");
        public static readonly GCountryRestriction Slovakia = new GCountryRestriction("countrySK");
        public static readonly GCountryRestriction Slovenia = new GCountryRestriction("countrySI");
        public static readonly GCountryRestriction SolomonIslands = new GCountryRestriction("countrySB");
        public static readonly GCountryRestriction Somalia = new GCountryRestriction("countrySO");
        public static readonly GCountryRestriction SouthAfrica = new GCountryRestriction("countryZA");
        public static readonly GCountryRestriction SouthGeorgiaAndSouthSandwich = new GCountryRestriction("countryGS");
        public static readonly GCountryRestriction Spain = new GCountryRestriction("countryES");
        public static readonly GCountryRestriction SriLanka = new GCountryRestriction("countryLK");
        public static readonly GCountryRestriction Sudan = new GCountryRestriction("countrySD");
        public static readonly GCountryRestriction Suriname = new GCountryRestriction("countrySR");
        public static readonly GCountryRestriction SvalbardJanMayen = new GCountryRestriction("countrySJ");
        public static readonly GCountryRestriction Swaziland = new GCountryRestriction("countrySZ");
        public static readonly GCountryRestriction Sweden = new GCountryRestriction("countrySE");
        public static readonly GCountryRestriction Switzerland = new GCountryRestriction("countryCH");
        public static readonly GCountryRestriction SyrianArabRepublic = new GCountryRestriction("countrySY");
        public static readonly GCountryRestriction Taiwan = new GCountryRestriction("countryTW");
        public static readonly GCountryRestriction Tajikistan = new GCountryRestriction("countryTJ");
        public static readonly GCountryRestriction Tanzania = new GCountryRestriction("countryTZ");
        public static readonly GCountryRestriction Thailand = new GCountryRestriction("countryTH");
        public static readonly GCountryRestriction Togo = new GCountryRestriction("countryTG");
        public static readonly GCountryRestriction Tokelau = new GCountryRestriction("countryTK");
        public static readonly GCountryRestriction Tonga = new GCountryRestriction("countryTO");
        public static readonly GCountryRestriction TrinidadAndTobago = new GCountryRestriction("countryTT");
        public static readonly GCountryRestriction Tunisia = new GCountryRestriction("countryTN");
        public static readonly GCountryRestriction Turkey = new GCountryRestriction("countryTR");
        public static readonly GCountryRestriction Turkmenistan = new GCountryRestriction("countryTM");
        public static readonly GCountryRestriction TurksAndCaicos = new GCountryRestriction("countryTC");
        public static readonly GCountryRestriction Tuvalu = new GCountryRestriction("countryTV");
        public static readonly GCountryRestriction Uganda = new GCountryRestriction("countryUG");
        public static readonly GCountryRestriction Ukraine = new GCountryRestriction("countryUA");
        public static readonly GCountryRestriction UnitedArabEmirates = new GCountryRestriction("countryAE");
        public static readonly GCountryRestriction UnitedKingdom = new GCountryRestriction("countryUK");
        public static readonly GCountryRestriction UnitedStates = new GCountryRestriction("countryUS");
        public static readonly GCountryRestriction UnitedStatesMinor = new GCountryRestriction("countryUM");
        public static readonly GCountryRestriction Uruguay = new GCountryRestriction("countryUY");
        public static readonly GCountryRestriction Uzbekistan = new GCountryRestriction("countryUZ");
        public static readonly GCountryRestriction Vanuatu = new GCountryRestriction("countryVU");
        public static readonly GCountryRestriction Venezuela = new GCountryRestriction("countryVE");
        public static readonly GCountryRestriction Vietnam = new GCountryRestriction("countryVN");
        public static readonly GCountryRestriction VirginIslandsBritish = new GCountryRestriction("countryVG");
        public static readonly GCountryRestriction VirginIslandsUS = new GCountryRestriction("countryVI");
        public static readonly GCountryRestriction WallisAndFutuna = new GCountryRestriction("countryWF");
        public static readonly GCountryRestriction WesternSahara = new GCountryRestriction("countryEH");
        public static readonly GCountryRestriction Yemen = new GCountryRestriction("countryYE");
        public static readonly GCountryRestriction Yugoslavia = new GCountryRestriction("countryYU");
        public static readonly GCountryRestriction Zambia = new GCountryRestriction("countryZM");
        public static readonly GCountryRestriction Zimbabwe = new GCountryRestriction("countryZW");

        internal const string InternalName = "cr";

        private GCountryRestriction(string value) :
            base(InternalName, value) { }
    }
}
