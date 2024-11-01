using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ncmdumpGUI
{
    [DataContract]
    class NeteaseCopyrightData
    {
        [DataMember(Name = "musicId")]
        public Int64 MusicId { get; set; }

        [DataMember(Name = "musicName")]
        public string MusicName { get; set; }

        [DataMember(Name = "artist")]
        public List<List<object>> Artist { get; set; }

        [DataMember(Name = "albumId")]
        public Int64 AlbumId { get; set; }

        [DataMember(Name = "album")]
        public string Album { get; set; }

        [DataMember(Name = "albumPicDocId")]
        public string AlbumPicDocId { get; set; }

        [DataMember(Name = "albumPic")]
        public string AlbumPic { get; set; }

        [DataMember(Name = "bitrate")]
        public string Bitrate { get; set; }//1

        [DataMember(Name = "mp3DocId")]
        public string Mp3DocId { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "mvId")]
        public string MvId { get; set; }//1

        [DataMember(Name = "alias")]
        public List<string> Alias { get; set; }

        // missing `transNames` unknow type usually empty

        [DataMember(Name = "format")]
        public string Format { get; set; }
    }
}
