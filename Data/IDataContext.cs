using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterWatch.Models;
using Microsoft.EntityFrameworkCore;


namespace WaterWatch.Data
{
    public interface IDataContext
    {
        DbSet<WaterConsumption> Consumptions { get; set; }
        int SaveChanges();
    }
}