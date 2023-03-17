﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quizApi.Models
{
    public class Question
    {
        [Key]
        public int QnId { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string QnInWord { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(50")]
        public string Option4 { get; set; }

        public int Answer { get; set; }

    }
}
