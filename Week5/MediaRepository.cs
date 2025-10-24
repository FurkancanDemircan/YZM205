using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class MediaRepository
    {
        private List<Media> medias;

        public MediaRepository()
        {
            this.medias = new List<Media>();
        }

        public void Add(Media media) => this.medias.Add(media);

        public List<Media> ListAll()
        {
            return medias;
        }

        public void SortByDuration()
        {
            medias.Sort();
        }

        public void SortByTitle()
        {
            medias = medias.OrderBy(m => m.Title).ToList();
        }
    }
}
