﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples.Pages.Schedule.Schedule
{
    public class ScheduleData
    {
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 6, 9, 30, 0),
                EndTime = new DateTime(2019, 1, 6, 11, 0, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(2019, 1, 7, 12, 0, 0),
                EndTime = new DateTime(2019, 1, 7, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 8, 9, 30, 0),
                EndTime = new DateTime(2019, 1, 8, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 9, 13, 0, 0),
                EndTime = new DateTime(2019, 1, 9, 14, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 10, 12, 0, 0),
                EndTime = new DateTime(2019, 1, 10, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(2019, 1, 10, 9, 30, 0),
                EndTime = new DateTime(2019, 1, 10, 11, 0, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(2019, 1, 11, 11, 0, 0),
                EndTime = new DateTime(2019, 1, 11, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 12, 9, 0, 0),
                EndTime = new DateTime(2019, 1, 12, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 14, 11, 0, 0),
                EndTime = new DateTime(2019, 1, 14, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(2019, 1, 16, 11, 0, 0),
                EndTime = new DateTime(2019, 1, 16, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2018",
                Location = "London",
                StartTime = new DateTime(2019, 1, 17, 9, 30, 0),
                EndTime = new DateTime(2019, 1, 17, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(2019, 1, 4, 10, 0, 0),
                EndTime = new DateTime(2019, 1, 4, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 2, 10, 30, 0),
                EndTime = new DateTime(2019, 1, 2, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2019, 1, 1, 10, 0, 0),
                EndTime = new DateTime(2019, 1, 1, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(2019, 1, 15, 9, 30, 0),
                EndTime = new DateTime(2019, 1, 15, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(2019, 1, 18, 11, 0, 0),
                EndTime = new DateTime(2019, 1, 18, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2019, 1, 7, 5, 30, 0),
                EndTime = new DateTime(2019, 1, 7, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 7, 17, 0, 0),
                EndTime = new DateTime(2019, 1, 7, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Fransisco",
                StartTime = new DateTime(2019, 1, 10, 6, 0, 0),
                EndTime = new DateTime(2019, 1, 10, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 10, 16, 0, 0),
                EndTime = new DateTime(2019, 1, 10, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2019, 1, 6, 14, 0, 0),
                EndTime = new DateTime(2019, 1, 6, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2019, 1, 8, 14, 30, 0),
                EndTime = new DateTime(2019, 1, 8, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(2019, 1, 11, 14, 30, 0),
                EndTime = new DateTime(2019, 1, 11, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(2019, 1, 12, 12, 30, 0),
                EndTime = new DateTime(2019, 1, 12, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            return appData;
        }

        public List<ResourceData> GetResourceData()
        {
            List<ResourceData> resourceData = new List<ResourceData>();
            resourceData.Add(new ResourceData
            {
                Id = 1,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(2018, 4, 1, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 1, 12, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 2,
                Subject = "Requirement planning",
                StartTime = new DateTime(2018, 4, 1, 12, 30, 0),
                EndTime = new DateTime(2018, 4, 1, 14, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 3,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2018, 4, 2, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 2, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 4,
                Subject = "Resource planning",
                StartTime = new DateTime(2018, 4, 2, 13, 0, 0),
                EndTime = new DateTime(2018, 4, 2, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 5,
                Subject = "Timeline estimation",
                StartTime = new DateTime(2018, 4, 3, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 3, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 6,
                Subject = "Developers Meeting",
                StartTime = new DateTime(2018, 4, 3, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 3, 16, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 7,
                Subject = "Project Review",
                StartTime = new DateTime(2018, 4, 4, 11, 15, 0),
                EndTime = new DateTime(2018, 4, 4, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 8,
                Subject = "Manual testing",
                StartTime = new DateTime(2018, 4, 4, 9, 15, 0),
                EndTime = new DateTime(2018, 4, 4, 11, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 9,
                Subject = "Project Preview",
                StartTime = new DateTime(2018, 4, 5, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 5, 12, 45, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 10,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(2018, 4, 5, 13, 45, 0),
                EndTime = new DateTime(2018, 4, 5, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 11,
                Subject = "Bug Automation",
                StartTime = new DateTime(2018, 4, 6, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 6, 12, 15, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 12,
                Subject = "Functionality testing",
                StartTime = new DateTime(2018, 4, 6, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 6, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 13,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(2018, 4, 7, 13, 0, 0),
                EndTime = new DateTime(2018, 4, 7, 15, 15, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 14,
                Subject = "Test report Validation",
                StartTime = new DateTime(2018, 4, 7, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 7, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 15,
                Subject = "Test case correction",
                StartTime = new DateTime(2018, 4, 8, 9, 45, 0),
                EndTime = new DateTime(2018, 4, 8, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 16,
                Subject = "Run test cases",
                StartTime = new DateTime(2018, 4, 8, 10, 30, 0),
                EndTime = new DateTime(2018, 4, 8, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 17,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2018, 4, 9, 12, 0, 0),
                EndTime = new DateTime(2018, 4, 9, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 18,
                Subject = "Debugging",
                StartTime = new DateTime(2018, 4, 9, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 9, 11, 15, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 19,
                Subject = "Exception handling",
                StartTime = new DateTime(2018, 4, 10, 10, 10, 0),
                EndTime = new DateTime(2018, 4, 10, 13, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 20,
                Subject = "Decoding",
                StartTime = new DateTime(2018, 4, 10, 10, 30, 0),
                EndTime = new DateTime(2018, 4, 10, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 21,
                Subject = "workflow Analysis",
                StartTime = new DateTime(2018, 4, 11, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 11, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 22,
                Subject = "Requirement planning",
                StartTime = new DateTime(2018, 4, 11, 12, 30, 0),
                EndTime = new DateTime(2018, 4, 11, 14, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 23,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2018, 4, 12, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 12, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 24,
                Subject = "Resource planning",
                StartTime = new DateTime(2018, 4, 12, 13, 0, 0),
                EndTime = new DateTime(2018, 4, 12, 14, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 25,
                Subject = "Timeline estimation",
                StartTime = new DateTime(2018, 4, 13, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 13, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 26,
                Subject = "Developers Meeting",
                StartTime = new DateTime(2018, 4, 13, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 13, 15, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 27,
                Subject = "Project Review",
                StartTime = new DateTime(2018, 4, 14, 11, 0, 0),
                EndTime = new DateTime(2018, 4, 14, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 28,
                Subject = "Manual testing",
                StartTime = new DateTime(2018, 4, 14, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 14, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 29,
                Subject = "Project Preview",
                StartTime = new DateTime(2018, 4, 15, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 15, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 30,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(2018, 4, 15, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 15, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 31,
                Subject = "Bug Automation",
                StartTime = new DateTime(2018, 4, 16, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 16, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 32,
                Subject = "Functionality testing",
                StartTime = new DateTime(2018, 4, 16, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 16, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 33,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(2018, 4, 17, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 17, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 34,
                Subject = "Test report Validation",
                StartTime = new DateTime(2018, 4, 17, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 17, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 35,
                Subject = "Test case correction",
                StartTime = new DateTime(2018, 4, 18, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 18, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 36,
                Subject = "Run test cases",
                StartTime = new DateTime(2018, 4, 18, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 18, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 37,
                Subject = "Bug fixing",
                StartTime = new DateTime(2018, 4, 9, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 9, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 38,
                Subject = "Debugging",
                StartTime = new DateTime(2018, 4, 19, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 19, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 39,
                Subject = "Exception handling",
                StartTime = new DateTime(2018, 4, 20, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 20, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 40,
                Subject = "Decoding",
                StartTime = new DateTime(2018, 4, 20, 10, 30, 0),
                EndTime = new DateTime(2018, 4, 20, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 41,
                Subject = "workflow Analysis",
                StartTime = new DateTime(2018, 4, 21, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 21, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 42,
                Subject = "Requirement planning",
                StartTime = new DateTime(2018, 4, 21, 12, 30, 0),
                EndTime = new DateTime(2018, 4, 21, 13, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 43,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2018, 4, 22, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 22, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 44,
                Subject = "Resource planning",
                StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 45,
                Subject = "Timeline estimation",
                StartTime = new DateTime(2018, 4, 4, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 46,
                Subject = "Developers Meeting",
                StartTime = new DateTime(2018, 4, 4, 14, 30, 0),
                EndTime = new DateTime(2018, 4, 4, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 47,
                Subject = "Project Review",
                StartTime = new DateTime(2018, 4, 4, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 16, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 48,
                Subject = "Manual testing",
                StartTime = new DateTime(2018, 4, 4, 17, 30, 0),
                EndTime = new DateTime(2018, 4, 4, 19, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 49,
                Subject = "Project Preview",
                StartTime = new DateTime(2018, 4, 4, 18, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 50,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(2018, 4, 25, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 25, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 51,
                Subject = "Bug Automation",
                StartTime = new DateTime(2018, 4, 26, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 26, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 52,
                Subject = "Functionality testing",
                StartTime = new DateTime(2018, 4, 26, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 26, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 53,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(2018, 4, 27, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 27, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 54,
                Subject = "Test report Validation",
                StartTime = new DateTime(2018, 4, 27, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 27, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 55,
                Subject = "Test case correction",
                StartTime = new DateTime(2018, 4, 28, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 28, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 56,
                Subject = "Run test cases",
                StartTime = new DateTime(2018, 4, 28, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 28, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 57,
                Subject = "Bug fixing",
                StartTime = new DateTime(2018, 4, 29, 12, 0, 0),
                EndTime = new DateTime(2018, 4, 29, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 58,
                Subject = "Debugging",
                StartTime = new DateTime(2018, 4, 29, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 29, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 59,
                Subject = "Exception handling",
                StartTime = new DateTime(2018, 4, 30, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 30, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 60,
                Subject = "Decoding",
                StartTime = new DateTime(2018, 4, 30, 10, 30, 0),
                EndTime = new DateTime(2018, 4, 30, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            return resourceData;
        }

        public List<ResourceData> GetTimelineResourceData()
        {
            List<ResourceData> timelineResourceData = new List<ResourceData>();
            timelineResourceData.Add(new ResourceData
            {
                Id = 61,
                Subject = "Decoding",
                StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
                EndTime = new DateTime(2018, 4, 4, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 62,
                Subject = "Bug Automation",
                StartTime = new DateTime(2018, 4, 4, 16, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 63,
                Subject = "Functionality testing",
                StartTime = new DateTime(2018, 4, 4, 9, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 64,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(2018, 4, 4, 12, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 4
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 65,
                Subject = "Test report Validation",
                StartTime = new DateTime(2018, 4, 4, 15, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 18, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 6
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 66,
                Subject = "Test case correction",
                StartTime = new DateTime(2018, 4, 4, 14, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 16, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 67,
                Subject = "Bug fixing",
                StartTime = new DateTime(2018, 4, 4, 14, 30, 0),
                EndTime = new DateTime(2018, 4, 4, 18, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 5
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 68,
                Subject = "Run test cases",
                StartTime = new DateTime(2018, 4, 4, 18, 30, 0),
                EndTime = new DateTime(2018, 4, 4, 21, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 4
            });
            timelineResourceData.Add(new ResourceData
            {
                Id = 69,
                Subject = "Bug Automation",
                StartTime = new DateTime(2018, 4, 4, 16, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 3
            });
            return timelineResourceData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string CategoryColor { get; set; }
        }
        public class ResourceData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public bool IsAllDay { get; set; }
            public int ProjectId { get; set; }
            public int TaskId { get; set; }
        }

    }
}
