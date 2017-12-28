﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAvalancheProject.Pipeline.Utilities
{
    public class Constants
    {
        public const string LatLonCacheContainerName = "latlon-csv-westus-v1";
        public const string LatLonCacheFileName = "LatLonCache.csv";
        public const string SnotelTrackerTable = "snoteltracker";
        public const string SnotelTrackerPartitionKey = "snotel-csv-westus-v1";
        public const string NamTrackerTable = "filedownloadtracker";
        public const string NamTrackerPartitionKey = "nam-grib-westus-v1";
    }
}
