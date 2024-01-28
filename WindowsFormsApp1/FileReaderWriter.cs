using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    class FileReaderWriter
    {
        public string currentFilePath;
        public void Read(ref string log)
        {
            Abonent[] abnts = new Abonent[0];
            using (StreamReader sr = new StreamReader(currentFilePath))
            {
                if (File.Exists(currentFilePath))
                {

                    var readData = File.ReadLines(currentFilePath);
                    abnts = new Abonent[readData.Count()];
                    int z = 0;
                    foreach (var i in readData)
                    {
                        abnts[z] = JsonConvert.DeserializeObject<Abonent>(i);
                        z++;
                    }
                    log = "File " + currentFilePath + " successfully read";


                }
           
            else
            {
                log = "File not found";
            }
            }
            AbonentsManager.abonents = abnts;
        }

        public void Write(ref string log)
        {
            using (StreamWriter sw = new StreamWriter(currentFilePath, append: false))
            {
                //File.WriteAllText(currentFilePath, string.Empty);
                foreach (var i in AbonentsManager.abonents)
                {
                    string JsonData = JsonConvert.SerializeObject(i);
                    //File.AppendAllText(currentFilePath, JsonData + "\r\n");
                    sw.WriteLine(JsonData);
                }
            }
            log = "Changes saved to file " + currentFilePath;
        }
    }
}
