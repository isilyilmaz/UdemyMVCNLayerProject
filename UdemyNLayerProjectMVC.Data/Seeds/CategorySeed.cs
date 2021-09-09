﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProjectMVC.Core.Models;

namespace UdemyNLayerProjectMVC.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category()
                {
                    Id= _ids[0],
                    Name = "Kalemler"
                },
                new Category()
                {
                    Id = _ids[1],
                    Name = "Defterler"
                }
           );
        }
    }
}