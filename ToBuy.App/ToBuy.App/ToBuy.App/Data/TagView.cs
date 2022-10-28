using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToBuy.App.Models;

namespace ToBuy.App.Data
{
    class TagView
    {
        public IList<ItemTag> Tags { get; set; }

        public TagView()
        {
            Tags = new ObservableCollection<ItemTag>();
            Tags.Add(new ItemTag
            {
                Id = 1,
                Title= "Alimento"
            });
            Tags.Add(new ItemTag
            {
                Id = 2,
                Title = "Doméstico"
            });
            Tags.Add(new ItemTag
            {
                Id = 3,
                Title = "Ferramentas"
            });

            Tags.Add(new ItemTag
            {
                Id = 4,
                Title = "Outros"
            });


        }
    }
}
