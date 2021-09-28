using Microsoft.AspNetCore.Http;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class ArticleUpdateViewModel
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string Title { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MinLength(20, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string Content { get; set; }

        [DisplayName("Resim")]
        public string Thumbnail { get; set; }

        [DisplayName("Resim Ekle")]
        public IFormFile ThumbnailFile { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }


        [DisplayName("Yazar Adı")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoAuthor { get; set; }

        [DisplayName("Makale Açıklaması")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoDescription { get; set; }

        [DisplayName("Makale Etiketleri")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} Alanı {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} Alanı {1} Karakterden Küçük Olmamalıdır.")]
        public string SeoTags { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        public int CategoryId { get; set; }
        
        [DisplayName("Aktif Mi ?")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        public bool IsActive { get; set; }

        public IList<Category> Categories { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
