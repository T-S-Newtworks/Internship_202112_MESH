using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Chat
    {
        [Key]
        [DisplayName("投稿番号")]
        public int Id { get; set; }

        [MaxLength(2000)]
        [DisplayName("投稿テキスト")]
        public string Text { get; set; }

        [DisplayName("チャンネル番号")]
        public virtual Channel ChannelNo { get; set; }

        [DisplayName("利用者番号")]
        public User User { get; set; }

        [DisplayName("画像番号")]
        public virtual Image Image { get; set;}

        [DisplayName("投稿日時")]
        public DateTime Date { get; set; }

        [DisplayName("タグ番号")]
        public virtual Tag Tag { get; set; }

    }
}