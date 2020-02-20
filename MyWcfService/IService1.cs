using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        //string GetData(int value);
        string HelloWorld();
        [OperationContract]
        // CompositeType GetDataUsingDataContract(CompositeType composite);
        int Add(List<int> listInt);

        [OperationContract]
        Task<int> Fibonacci(int n);
        // TODO: ajoutez vos opérations de service ici
        [OperationContract]
        string GetXmlData(string xmlContent);
    }
}
