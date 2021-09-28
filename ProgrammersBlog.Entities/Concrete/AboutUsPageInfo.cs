using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class AboutUsPageInfo
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string Header { get; set; }


        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(1500, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string Content { get; set; }


        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoDescription { get; set; }


        [DisplayName("Seo Etiketleri")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoTags { get; set; }


        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(60, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoAuthor { get; set; }
    }
}
