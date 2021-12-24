using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;

namespace Walmart.Sdk.Base.Util
{
    public class XsdValidation
    {
        public static List<ValidationEventArgs> validateXml(string xsdFilePath, string xmlFilePath)
        {
            // TODO: figure out how to validate xml files with xsd schema
            XmlSchema xsd;
            using (FileStream stream = new FileStream(xsdFilePath, FileMode.Open, FileAccess.Read))
            {
                //xsd = XmlSchema.Read(stream, null);
            }
            

            return new List<ValidationEventArgs>();
        }
    }
}
