using System.Collections.Generic;
using WCSA_Data_Source_Layer;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;
using System.IO;
using System.Diagnostics;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web;

namespace WCSA_Service_Classes
{
    public class ProductPresenter
    {
        public ProductPresenter()
        {
        }

        public void Add(string code, string name, double price, uint quantity)
        {
            ProductDataSource pds = new ProductDataSource();
            pds.AddToList(new WCSA_Entity_Classes.Product(code, name,price,quantity));
        }

        public void modifyItem(string code, string name, double price, uint quantity)
        {
            ProductDataSource pds = new ProductDataSource();
            pds.ModifyList(new WCSA_Entity_Classes.Product(code, name, price, quantity));
        }

        public WCSA_Entity_Classes.Product checkProductDetails(string code)
        {
            ProductDataSource pds = new ProductDataSource();
            return pds.ReturnAnItem(code);
        }



        //This method is for calling from Browse method ???
        public WCSA_Entity_Classes.Product ReturnItemDetail(string code)
        {
            ProductDataSource sds = new ProductDataSource();
            WCSA_Entity_Classes.Product currentProduct = sds.ReturnAnItem(code);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        //This method is for calling from Search method 
        public WCSA_Entity_Classes.Product ReturnSingleItemDetail(string searchCode)
        {
            ProductDataSource sds = new ProductDataSource();
            WCSA_Entity_Classes.Product currentProduct = sds.ReturnAnItem(searchCode);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        public List<WCSA_Entity_Classes.Product> fetchProductList()
        {
            List<WCSA_Entity_Classes.Product> productList = new List<WCSA_Entity_Classes.Product>();
            ProductDataSource sds = new ProductDataSource();
            sds.returnEntireList(productList);

            return productList;
        }


        //public bool generatebarcode (Image image)
        //{
        //    Document myDocument = new Document(PageSize.A4.Rotate());

        //        // step 2:
        //        // Now create a writer that listens to this doucment and writes the document to desired Stream.
        //        string documentPath = @"C:\\Users\\ahmed\\Desktop\\PDF\\";
        //        string filename = "barcode.pdf";
        //        string documentFullPath = documentPath + filename;

        //        PdfWriter.GetInstance(myDocument, new FileStream(documentFullPath, FileMode.Create));

        //        // step 3:  Open the document now using
        //        myDocument.Open();
        //    // step 4: Now add some contents to the document
        //    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(image);
        //    png.ScalePercent(25f);    
        //    //myDocument.Add(new Paragraph("                           time: "));
        //        myDocument.Add(png);
        //    // step 5: Remember to close the documnet

        //    myDocument.Close();

        //    return true;
        //}
    }
}
