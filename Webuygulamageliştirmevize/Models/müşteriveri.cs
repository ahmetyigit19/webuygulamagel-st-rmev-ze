using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webuygulamageliştirmevize.Models
{
    public class müşteriveri
    {
        public static List<müşteri> müşteriler = new List<müşteri>()
        {
            new müşteri()
                        {
                            Id = 1,
                            Ad = "Ahmet Yiğit",
                            Soyad = "UYSAL",
                           
                        },
            new müşteri()
                        {
                            Id = 2,
                            Ad = "Emre",
                            Soyad = "ŞAHİN",
                            
                        },
            new müşteri()
                        {
                            Id = 3,
                            Ad = "Emine",
                            Soyad = "TOK",
                           
                        },

             new müşteri()
                        {
                            Id = 4,
                            Ad = "Mustafa",
                            Soyad = "KIR",

                        },

              new müşteri()
                        {
                            Id = 5,
                            Ad = "Furkan",
                            Soyad = "AL",

                        },


               new müşteri()
                        {
                            Id = 6,
                            Ad = "Selim",
                            Soyad = "YİĞİT",

                        },

                new müşteri()
                        {
                            Id = 7,
                            Ad = "Emirhan",
                            Soyad = "BUĞAN",

                        },








        };
    }
}
