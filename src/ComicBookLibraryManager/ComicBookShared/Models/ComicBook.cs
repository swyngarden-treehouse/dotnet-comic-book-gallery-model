﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookShared.Models
{
    /// <summary>
    /// Represents a comic book.
    /// </summary>
    public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<ComicBookArtist>();
        }

        public int Id { get; set; }
        [DisplayName("Series")]
        public int SeriesId { get; set; }
        [DisplayName("Issue Number")]
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        [DisplayName("Published On")]
        public DateTime PublishedOn { get; set; }
        [DisplayName("Average Rating")]
        public decimal? AverageRating { get; set; }

        public Series Series { get; set; }
        public ICollection<ComicBookArtist> Artists { get; set; }

        /// <summary>
        /// The display text for a comic book.
        /// </summary>
        public string DisplayText
        {
            get
            {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }

        /// <summary>
        /// Adds an artist to the comic book.
        /// </summary>
        /// <param name="artist">The artist to add.</param>
        /// <param name="role">The role that the artist had on this comic book.</param>
        public void AddArtist(Artist artist, Role role)
        {
            Artists.Add(new ComicBookArtist()
            {
                Artist = artist,
                Role = role
            });
        }

        public void AddArtist(int artistId, int roleId)
        {
            Artists.Add(new ComicBookArtist
            {
                ArtistId = artistId,
                RoleId = roleId
            });
        }
    }
}
