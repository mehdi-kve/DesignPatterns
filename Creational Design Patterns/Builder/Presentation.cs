using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Presentation
    {
        private List<Slide> slides = new List<Slide>();

        public void addSlide(Slide slide) 
        {
            slides.Add(slide);
        }

        public void export(PresentationBuilder builder) 
        {
            builder.addSlide(new Slide(text:"Copyright"));
            foreach (Slide slide in slides) 
            {
                builder.addSlide(slide);
            }
        }
    }
}
