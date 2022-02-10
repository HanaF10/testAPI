using System.ComponentModel.DataAnnotations;

namespace testAPI.DTO
{
    public class CreateDocReqDTO
    {
        [Required]
        public int Id { get; set; }
        //o   שם קובץ *
        [Required]
        public string Name { get; set; }
        //o סוג הקובץ* (PDF, Docx, xlsx, pptx, jpg) – בחירה מרשימה
        [Required]
        public int Type { get; set; }
        //o גודל הקובץ* – אפשרות הקשה או אפשרות הגדלה והקטנת ערך באמצעות +/- או חיצים וכדומה , אבל גם רכיב שמאפשר הגדרה לפי K,M,G Byte
        [Required]
        public double Size { get; set; }
        [Required]
        public int SizeType { get; set; }
        //o המחבר
        public string UserCreated { get; set; }
        //o תאריך חיבור
        public DateTime DateCreated { get; set; }
        //o   האם מוצפן – כן/לא
        public bool IsEncoded { get; set; }
    }
}
