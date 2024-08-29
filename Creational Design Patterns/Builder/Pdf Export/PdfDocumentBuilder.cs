using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PdfDocumentBuilder : PresentationBuilder
    {
        private PdfDocument document = new PdfDocument();

        public void addSlide(Slide slide)
        {
            document.addPage(slide.getText());  
        }

        public PdfDocument getPdfDocument() 
        {
            return document;
        }
    }
}
