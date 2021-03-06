﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {

        public List<Sample> Gantt { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Editing",
                Category = "Gantt",
                Directory = "Gantt/Editing",
                Url = "Gantt/Editing",
                FileName = "Editing.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Baseline",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/Baseline",
                FileName = "FilBaselinetering.cshtml",
                Type = SampleType.New
            }
        };
    }
}
