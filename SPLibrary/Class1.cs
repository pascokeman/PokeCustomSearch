using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = SPLibrary.SPExcelWebService;
using SPLibrary.SearchWSDL;
using SPLibrary.SPWeb;
using SPLibrary.SPSites;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace SPLibrary
{
    public class Class1
    {
        public void SearchInWord(string docName, string docPath, string searchWord)
        {  
            var wordApp = new Word.Application();
            wordApp.Visible = true;
                        
            try
            {
                Word.Document wordDoc = wordApp.Documents.Open(docName);
                StreamReader streamReader = new StreamReader(docName);
                var readDoc = streamReader.ReadToEnd();


                streamReader.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
            wordApp.Documents.Close();


        }
        
        
    }
}
