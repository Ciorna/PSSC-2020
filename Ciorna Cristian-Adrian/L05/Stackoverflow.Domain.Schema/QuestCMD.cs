using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stackoverflow.Domain.Schema
{
    public class QuestCMD
    {
        public QuestCMD(string titlu, string intrebare,string tag)
        {
            Titlu = titlu;
            Intrebare = intrebare;
            Tag = tag;
        }
        [Required]
        public string Titlu { get; }
        [Required]
        [MaxLength(1000)]
        public string Intrebare { get; }
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public string Tag { get; }
    }
}
