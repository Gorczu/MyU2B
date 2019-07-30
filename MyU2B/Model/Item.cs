using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyU2B.Model
{
    public class Item
    {
        public Guid Id { get; set; }

        public IdentityUser Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public byte[] Content { get; set; }

        public DateTime Added{ get; set; }

    }
}
