using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ADVANTEDGE_CSHARP.Models;
using ADVANTEDGE_CSHARP.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace ADVANTEDGE_CSHARP.Repository
{
    public class JsonOperations : IJsonOperations
    {
        private readonly string _filePath;
        public JsonOperations(string filePath)
        {
            _filePath = filePath;
        }
        
        public IEnumerable<OwnerViewModel> GetJsonData()
        {
            var schemaJson = Constants.Constants.SchemaJson;
            
            List<Owner> owners = new List<Owner>();
            try
            {                
                if (!_filePath.EndsWith("json"))
                {
                    throw new Exception("Invalid File extension. File extension must be '.json'");
                }
                
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        var schema = JSchema.Parse(schemaJson);

                        JSchemaValidatingReader validatingReader = new JSchemaValidatingReader(reader);
                        validatingReader.Schema = schema;


                        JsonSerializer serializer = new JsonSerializer();
                        owners = serializer.Deserialize<List<Owner>>(validatingReader);
                    }
                }

                var ownersByGender = owners.GroupBy(o => o.Gender)
                                           .Select(group => new OwnerViewModel()
                                           {
                                               Gender = group.Key,
                                               Owners = group.OrderBy(o => o.Name).Select(o => o.Name)
                                           }).ToList();

                return ownersByGender;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
