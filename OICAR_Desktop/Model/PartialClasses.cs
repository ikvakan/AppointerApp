using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.Model
{
    [MetadataType(typeof(ClientMD))]
    public partial class Client
    {
        public string FullName { get=>$"{Name} {Surname}";  }
    }


    [MetadataType(typeof(ServiceMD))]
    public partial class Service
    {

    }

    [MetadataType(typeof(WorkerMD))]
    public partial class Worker
    {
        public string FullName { get => $"{Name} {Surname}"; }
    } 

    //[MetadataType(typeof(SpecializationMD))]
    //public partial class Specialization
    //{
      
    //}
     [MetadataType(typeof(Service_TypeMD))]
    public partial class Service_Type
    {
      
    } 
    [MetadataType(typeof(ApponitmentMD))]
    public partial class Appointment
    {
      
    }


}
