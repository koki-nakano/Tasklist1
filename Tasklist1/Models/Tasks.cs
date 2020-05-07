using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Tasklist1.Models
{
    public class Tasks
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("作成日時")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("更新日時")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("タスク")]
        [Required(ErrorMessage = "タスクを入力してください")]
        [DataType(DataType.MultilineText)]
        public string Task { get; set; }

    }
}