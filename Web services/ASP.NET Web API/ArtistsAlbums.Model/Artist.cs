//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtistsAlbums.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Artist
    {
        public Artist()
        {
            this.Songs = new List<Song>();
            this.Albums = new List<Album>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        public ICollection<Song> Songs { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
