Advantedge Challenge

Below is the folder structure that's been followed for better maintainability of the code.

    Controllers - All the controllers are placed here.
    ViewModels - View Models used to bind the user inputs and validate them before assigning back to the 
    actual Model.
    Models - Used to bind and validate the data.
    Repository - Entire business logic has been placed here and a corresponding interface has been created 
    in order to properly unit test the code.
    Constants- Application level constants and exceptions are defined here.

Business Rule Validations -

    Check for the extension of the input file.
    Validate the json file with the json schema that's been implemented based on the sample json file provided.
    Display owner names will be displayed in ascending order in case the json file is valid.
    Throw exception messages whereever required.
