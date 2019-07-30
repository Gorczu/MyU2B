using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyU2B.Model
{
    public class Playlist
    {
        public Guid Id { get; set; }

        public IdentityUser Owner { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public List<Item> Items { get; set; }


    }
}
