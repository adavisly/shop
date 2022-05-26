﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllManga
    {

        IEnumerable<Manga> Mangas { get; }
        IEnumerable<Manga> getFavManga { get; }
        Manga getObjectManga(int mangaID);

    }
}
