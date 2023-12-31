﻿using Microsoft.EntityFrameworkCore;
using AcmeCorporationLibrary.Models;

namespace AcmeCorporationLibrary.Data
{
    // Interface between controller and database
    public interface IApplicationDbContext
    {
        DbSet<SubmissionModel> Submission { get; set; }
        DbSet<SerialNumberModel> SerialNumbers { get; set; }
        int SaveChanges();
    }
}
