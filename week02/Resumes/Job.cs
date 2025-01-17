using System;
using System.Runtime.CompilerServices;

public class Job
        {

            public string _company = "";
            public string _jobTitle = "";
            public int _startYaear = 0;
            public int _endYear = 0;

            public void Display()
            {

                {
                    Console.WriteLine($"{_jobTitle} ({_company}) {_startYaear}-{_endYear}.");
                }

            }

        }

        