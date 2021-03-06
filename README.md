# OpenAvalancheProject
Open source project to bring data and ml to avalanche forecasting

Homepage is https://openavalancheproject.org

Directories are organized as follows:
- Data--Contains a zip file containing three CSVs
    CleanedForecastsNWAC.csv: is only the NWAC cleaned forecast data used for training 
    finalSeriesForTrainingWithLatLon.csv is the primary training file containing both input data and trainign classes for the V1 model.
    finalSeriesForPrediction.csv is a helper data set to evaluate a trained function against a full concurrent month of data.  If you use this you need to ensure you don't train your model with data from Dec 2016.
- ML--Contains a Jupyter notbook which was used to train the models
- WebApp is the bulk of the operational code
    - Functions are the Azure functions implemented as a .Net class used to drive data collection from the various data sources: NAM model from NOAA, Snotel Data and SnoDas data.
    - NAMGribParse.Utility is a utility helper function in case you need to parse GRIB files locally; this will likely be removed in the near future.
    - OpenAvalancheProject.Pipeline.DataFactory is a set of powershell scripts and json configuration files used to configure and deploy an Azure Data Factory V2 which is the main processing pipeline used to clean and join the data in to the correct format for prediction.
    - OpenAvalancheProject.Pipeline.Tests as test primarily for the Azure functions.
    - OpenAvalancheProject.Pipeline.USql contains the U-SQL code which makes up the pipeline.
    - OpenAvalancheProject.Pipeline.Usql.Udos is a .Net class library where we encapsulate the UDOs referenced by the U-SQL functions
    - OpenAvalancheProjectWebApp Contains the code for the website
    - OpenAvalancheProjectWebApp.Tests Tests for the website (unfortunately empty at the moment)
- Financials 
    -Contains the bills and any financial information related to the site operations and expendetures towards the sites or any income from donations or other sources

