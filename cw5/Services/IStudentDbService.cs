﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw5.Requests;
using cw5.Responses;
using cw5.Controllers;

namespace cw5.Services
{
    public interface IStudentDbService
    {
        void EnrollStudent(EnrollStudentRequest request);
        void PromoteStudent(int semester, string studies);
    }
}
