using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;

namespace MyWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    /// Summary description for WebService  
    /// </summary>  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.   
    // [System.Web.Script.Services.ScriptService]  
    public class Service1 : IService1
    {
        [WebMethod]
        public async Task<int> Fibonacci(int n)
        {
            var result = await Task.Run(() =>
            {
                int w;
                if (n <= 0) return 0;
                if (n == 1) return 1;
                int u = 0;
                int v = 1;
                for (int i = 2; i <= n; i++)
                {
                    w = u + v;
                    u = v;
                    v = w;
                };
                return v;
            });
 
            return result;
        }
        [WebMethod]
        public string GetXmlData(string xmlContent)
        {
            //string xmlContent = "<foo>bar</foo>";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xmlContent);
                XmlNode newNode = doc.DocumentElement;
                string jsonText = JsonConvert.SerializeXmlNode(newNode);
                //Console.WriteLine(jsonText); 
                return jsonText;
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Bad Xml format");
                return "Bad Xml format";

            }
        }
    }


}
