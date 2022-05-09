using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class Classroom
    {
        /* öğrenciye ait veritabanından kayıtlı olduğu id major minor bilgileri ile post isteği gönderildiğinde
         * post ile gelen majör ve minör değerlere ait bir sınıf olup olmadığını sınıflar tablosundan çekecek
         * eğer bu major ve minor bir sınıfı işaret etmiyorsa yapılan isteğe cevap verilecek eğer 
         * bir sınıfı belirtiyorsa sınıfa ait id bilgisi alınır
         * */
        public Classroom()
        {
            
            CourseClassrooms = new HashSet<CourseClassroom>();
        }
        public int Id { get; set; }
        public int Major { get; set; }  
        public int Minor { get; set; }
        public string ClassName { get; set; }
        
        
        public ICollection<CourseClassroom> CourseClassrooms { get; set; }
    }
}
