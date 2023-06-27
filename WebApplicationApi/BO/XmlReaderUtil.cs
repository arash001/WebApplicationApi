using System;
using System.Xml.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using WebApplicationApi.ViewModel;

namespace WebApplicationApi.BO
{

    public class XmlReaderUtil
    {

        public async Task<PutDataRequestDto> getXmlFromFile(string filePath)
        {
            HttpClient client = new HttpClient();
            XmlSerializer serializer = new XmlSerializer(typeof(PutDataRequestDto));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                try
                {
                    PutDataRequestDto putDataRequest = (PutDataRequestDto)serializer.Deserialize(fileStream);

                    return putDataRequest;
                }

                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }


}

