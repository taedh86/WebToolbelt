using System.Collections.Generic;
using WebToolbelt.Entities.Entities;

namespace WebToolbelt.Entities.DbContext.Seed
{
    public class LanguagesSeed
    {
        private readonly List<Language> languagesList = new List<Language>()
        {
            new Language { Code = "ara", EnglishName = "Arabic", NativeName = "العربية" },
            new Language { Code = "aze", EnglishName = "Azerbaijan", NativeName = "azərbaycan dili" },
            new Language { Code = "bel", EnglishName = "Belorussian", NativeName = "беларуская мова" },
            new Language { Code = "ben", EnglishName = "Bengali", NativeName = "বাংলা" },
            new Language { Code = "bos", EnglishName = "Bosnian", NativeName = "bosanski jezik" },
            new Language { Code = "bul", EnglishName = "Bulgarian", NativeName = "български език" },
            new Language { Code = "ces", EnglishName = "Czech", NativeName = "čeština" },
            new Language { Code = "chi_sim", EnglishName = "Chinese (Simplified)", NativeName = "簡體中文" },
            new Language { Code = "chi_tra", EnglishName = "Chinese (Traditional)", NativeName = "中國傳統的" },
            new Language { Code = "cym", EnglishName = "Welsh", NativeName = "Cymraeg" },
            new Language { Code = "dan", EnglishName = "Danish", NativeName = "dansk" },
            new Language { Code = "deu", EnglishName = "German", NativeName = "Deutsch" },
            new Language { Code = "ell", EnglishName = "Greek", NativeName = "ελληνικά" },
            new Language { Code = "eng", EnglishName = "English", NativeName = "English" },
            new Language { Code = "est", EnglishName = "Estonian", NativeName = "English" },
            new Language { Code = "eus", EnglishName = "Basque", NativeName = "euskara" },
            new Language { Code = "fas", EnglishName = "Persian", NativeName = "فارسی" },
            new Language { Code = "fin", EnglishName = "Finnish", NativeName = "suomi" },
            new Language { Code = "fra", EnglishName = "French", NativeName = "français" },
            new Language { Code = "gle", EnglishName = "Irish", NativeName = "Gaeilge" },
            new Language { Code = "heb", EnglishName = "Hebrew", NativeName = "עברית" },
            new Language { Code = "hin", EnglishName = "Hindi", NativeName = "हिन्दी" },
            new Language { Code = "hrv", EnglishName = "Croatian", NativeName = "hrvatski jezik" },
            new Language { Code = "hun", EnglishName = "Hungarian", NativeName = "magyar" },
            new Language { Code = "ind", EnglishName = "Indonesian", NativeName = "Bahasa Indonesia" },
            new Language { Code = "isl", EnglishName = "Icelandic", NativeName = "Íslenska" },
            new Language { Code = "ita", EnglishName = "Italian", NativeName = "Italiano" },
            new Language { Code = "jpn", EnglishName = "Japanese", NativeName = "日本語" },
            new Language { Code = "kat", EnglishName = "Georgian", NativeName = "ქართული" },
            new Language { Code = "kaz", EnglishName = "Kazakh", NativeName = "қазақ тілі" },
            new Language { Code = "kor", EnglishName = "Korean", NativeName = "한국어" },
            new Language { Code = "lat", EnglishName = "Latin", NativeName = "latine" },
            new Language { Code = "lav", EnglishName = "Latvian", NativeName = "latviešu valoda" },
            new Language { Code = "lit", EnglishName = "Lithuanian", NativeName = "lietuvių kalba" },
            new Language { Code = "mkd", EnglishName = "Macedonian", NativeName = "македонски јазик" },
            new Language { Code = "mlt", EnglishName = "Maltese", NativeName = "Malti" },
            new Language { Code = "nld", EnglishName = "Dutch", NativeName = "Nederlands" },
            new Language { Code = "nor", EnglishName = "Norwegian", NativeName = "Norsk" },
            new Language { Code = "pol", EnglishName = "Polish", NativeName = "Polski" },
            new Language { Code = "ron", EnglishName = "Romanian", NativeName = "Română" },
            new Language { Code = "rus", EnglishName = "Russian", NativeName = "Русский" },
            new Language { Code = "slk", EnglishName = "Slovak", NativeName = "slovenčina" },
            new Language { Code = "slv", EnglishName = "Slovene", NativeName = "slovenski jezik" },
            new Language { Code = "spa", EnglishName = "Spanish", NativeName = "Español" },
            new Language { Code = "sqi", EnglishName = "Albanian", NativeName = "Shqip" },
            new Language { Code = "srp", EnglishName = "Serbian", NativeName = "српски језик" },
            new Language { Code = "swe", EnglishName = "Swedish", NativeName = "svenska" },
            new Language { Code = "tha", EnglishName = "Thai", NativeName = "ไทย" },
            new Language { Code = "tur", EnglishName = "Turkish", NativeName = "Türkçe" },
            new Language { Code = "ukr", EnglishName = "Ukrainian", NativeName = "Українська" },
            new Language { Code = "urd", EnglishName = "Kurdish", NativeName = "Kurdî" },
            new Language { Code = "uzb", EnglishName = "Uzbek", NativeName = "Oʻzbek" },
            new Language { Code = "uzb_cyrl", EnglishName = "Uzbek (Cyrillic)", NativeName = "Oʻzbek" },
            new Language { Code = "vie", EnglishName = "Vietnamese", NativeName = "Tiếng Việt" },
            new Language { Code = "yid", EnglishName = "Yiddish", NativeName = "ייִדיש" },
        };




        private readonly WebToolbeltDbContext context;

        public LanguagesSeed(WebToolbeltDbContext context)
        {
            this.context = context;
        }


        public void Seed()
        {
            Clear();

            foreach (Language lang in languagesList)
            {
                context.Languages.Add(lang);
            }
            context.SaveChanges();
        }

        private void Clear()
        {
            context.Languages.RemoveRange(context.Languages);
            context.SaveChanges();
        }
    }
}
