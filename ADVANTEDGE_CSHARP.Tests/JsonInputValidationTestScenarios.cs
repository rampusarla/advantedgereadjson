using ADVANTEDGE_CSHARP.Repository;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Tests
{
    public class JsonInputValidationTestScenarios
    {
        JsonOperations invalidFileExtension, invalidFile, invalidJsonFile, validJsonFile;
        [SetUp]
        public void Setup()
        {
            invalidFileExtension = new JsonOperations("./TestFiles/InvalidExtension.txt");
            invalidFile = new JsonOperations("./TestFiles/InValidFile_MissingGenderInOneOfTheObjects.json");
            validJsonFile = new JsonOperations("./TestFiles/ValidFile.json");
        }

        [Test]
        public void InvalidFileExtensionShouldThrowAnError()
        {
            try
            {
                var output = invalidFileExtension.GetJsonData();
            }
            catch(System.Exception ex)
            {
                Assert.AreEqual("Invalid File extension. File extension must be '.json'", ex.Message);
            }
        }

        [Test]
        public void MissingGenderPropertyShouldThrowSchemaValidationError()
        {
            try
            {
                var output = invalidFile.GetJsonData();
            }
            catch (System.Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Required properties are missing from object: gender"));                
            }
        }
        

        [Test]
        public void ValidJsonFileShouldOutputOwnerNamesInAscendingOrder()
        {
            var output = validJsonFile.GetJsonData();
            List<string> finalOutput = new List<string>();
            List<string> expectedOutput = new List<string>()
            {
                "Bob",
                "Fred",
                "Steve",
                "Alice",
                "Jennifer",
                "Samantha"
            };

            foreach(var item in output)
            {
                finalOutput.AddRange(item.Owners); 
            }

            CollectionAssert.AreEqual(expectedOutput, finalOutput);
        }
    }
}