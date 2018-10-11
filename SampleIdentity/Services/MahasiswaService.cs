using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleIdentity.Models;
using RestSharp;

namespace SampleIdentity.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private RestClient _restClient;
        public MahasiswaService()
        {
            _restClient = new RestClient("http://localhost:62467");
        }
        public IEnumerable<Mahasiswa> GetAll()
        {
            var request = new RestRequest("api/Mahasiswa", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", "Bearer ikYYRARNyD4uLtsPFU1qT0cZLPatjHHsAfjv3OC8ervdFLxJi9RexdwgrltUmj0YKaupMkkyiuyrA-dknOJJVrXJ3Atma780X9b1psBxGjxczOS_wjwGGYbZXj22orZ_i0or6cDnpWNll7f658dW3Nqy7w4uEot-fwij_N6Bzz_iDKIzZzsaJxstwF_TmnBk_qI5jCqV3l4DlLklI4ijFhCHmVOaThwSbJuSsorXIh2R-1pelT6VUYH7ZNAfpA8X5YtB6eCwDJfp6E9dZJD-RHslECujAxwo4Bp2lNs3eFV-PSg3R5LlAA7m0rsQGzy5FuIXcpGeo7YaPUE6PEqiCkhLEMYvavvI_GS9tG06jdLc4jaHPMTEGqPqV66FaJBrlLVCWMewYFZq5nIOe5B_7mOjVSvwVKneMJqFrYRSthLmUxiBlJPhWs7aWJNVH3lDUvmhdyK1riL3XfSPRea6v_nwxKPS0VO1mozo5_9Sdfs");

            var response = _restClient.Execute<List<Mahasiswa>>(request);

            if (response.Data == null)
            {
                throw new Exception($"Error : {response.ErrorMessage}");
            }

            return response.Data;
        }
    }
}
