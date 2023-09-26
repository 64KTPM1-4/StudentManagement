using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model;
using System.IO;

namespace Process
{
    public class GetList
    {
        public List<Profile> MemberList()
        {
            var result = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(@"Members.json"));
            return result;
        }


    }
}
