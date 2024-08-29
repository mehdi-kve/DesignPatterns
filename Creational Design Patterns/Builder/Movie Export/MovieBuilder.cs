using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MovieBuilder : PresentationBuilder
    {
        private Movie movie = new Movie();

        public void addSlide(Slide slide)
        {
            movie.AddFrame(slide.getText(), 3);
        }

        public Movie getMovie() 
        {
            return movie;
        }
    }
}
