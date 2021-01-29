using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.Hasher.Bussines.API
{
    public interface IHashAPI
    { 
        string HashByMD5(string Values);
        string HashBySHA160(string Values);
        string HashBySHA256(string Values);
        string HashBySHA384(string Values);
        string HashBySHA512(string Values);
        string HashByRIPEMD160(string Values);

    }
}
