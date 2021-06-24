using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB23.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        private int v1;
        private string v2;
        private string v3;

        public Book()
        {
        }

        public Book(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }
        [Required(ErrorMessage = "Mã sách không được trống")]
        [StringLength(20, ErrorMessage = "Mã sách không được quá 20 ký tự")]
        [Display(Name = "Mã sách")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage="Tiêu đề không được trống")]
        [StringLength(250, ErrorMessage= "Tiêu đề sách không được quá 250 ký tự")]
        [Display(Name="Tiêu Đề")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [Display(Name = "Tác Giả")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        [Display(Name = "Đường dẫn Ảnh Bìa")]
        public string ImageCover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }
    }
}